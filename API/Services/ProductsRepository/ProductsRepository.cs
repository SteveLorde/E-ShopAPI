using API.Data;
using API.Data.DTOs;
using API.Data.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.ProductsRepository;

class ProductsRepository : IProductsRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;
    public List<Product> primarymostselling = new List<Product>();
    private readonly IWebHostEnvironment _hostingenv;

    public ProductsRepository(DataContext db, IMapper mapper, IWebHostEnvironment hostingEnvironment)
    {
        _db = db;
        _mapper = mapper;
        _hostingenv = hostingEnvironment;
    }
    
    public async Task<List<Product>> GetProducts()
    {
        return await _db.Products.ToListAsync();
    }

    public async Task<List<Product>> GetProductsByCategory(string category)
    {
        return await _db.Products.Where(x => x.category == category).ToListAsync();
    }
    
    public List<Product> GetMostSelling()
    {
        return primarymostselling;
    }

    private async Task MostSelling()
    {
        primarymostselling.Clear();
        primarymostselling = await _db.Products.OrderByDescending(x => x.sells).Take(15).ToListAsync();
    }

    public async Task CreateAssetsFolders()
    {
        try
        {
            List<Product> allproducts = await _db.Products.ToListAsync();
            foreach (Product product in allproducts)
            {
                var productfoldertocreate = Path.Combine(_hostingenv.ContentRootPath, "Storage", "Products",
                    $"{product.ProductId}", "Images");
                Directory.CreateDirectory(productfoldertocreate); 
            }
            Console.WriteLine("Created Products assets folders successfully");
        }
        catch (Exception err)
        {
            throw err;
        }
    }


    public async Task AddProduct(ProductDTO producttoadd)
    {
        Product newproduct = new Product { name = producttoadd.name , description = producttoadd.description, descriptionbullets = producttoadd.descriptionbullets, category = producttoadd.category, price = producttoadd.price, addedon = new DateOnly(2024,1,1), discount = null };
        await _db.Products.AddAsync(newproduct);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateProduct(ProductDTO producttoupdate)
    {
        Product selectedproduct = await _db.Products.FirstAsync(x => x.ProductId == producttoupdate.id);
        _mapper.Map(producttoupdate, selectedproduct);
        
        /*
        void functionlol()
        {
            selectedproduct.name = producttoupdate.name;
            selectedproduct.description = producttoupdate.description;
            selectedproduct.category = producttoupdate.category;
            selectedproduct.barcode = producttoupdate.barcode;
            selectedproduct.descriptionbullets = producttoupdate.descriptionbullets;
            selectedproduct.discount = producttoupdate.discount;
            selectedproduct.
        }
        */
        
        await _db.SaveChangesAsync();
    }

    public async Task RemoveProduct(ProductDTO producttoremove)
    {
        Product removeproduct = await _db.Products.FirstAsync(x => x.ProductId == producttoremove.id);
        _db.Products.Remove(removeproduct);
        await _db.SaveChangesAsync();
    }
}   