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

    public async Task<Product> GetProduct(string productid)
    {
        var productguid = Guid.Parse(productid);
        return await _db.Products.FirstAsync(product => product.Id == productguid);
    }

    public async Task<List<ParentCategory>> GetParentCategories()
    {
        return await _db.ParentCategories.Include(parentcat => parentcat.Categories).ToListAsync();
    }

    public async Task<List<Category>> GetCategories(string parentcategoryid)
    {
        var parentcatguid = Guid.Parse(parentcategoryid);
        return await _db.ParentCategories.Where(x => x.Id == parentcatguid).SelectMany(z => z.Categories).Include(a => a.ParentCategory).ToListAsync();
    }

    public async Task<List<Product>> GetProductsByCategory(string categoryid)
    {
        Guid categoryguid = Guid.Parse(categoryid);
        return await _db.Products.Where(x => x.Category.ParentCategoryId == categoryguid || x.CategoryId == categoryguid ).ToListAsync();
    }
    
    public async Task<List<Product>> GetMostSelling()
    {
        return await _db.Products.OrderByDescending(x => x.sells).Take(15).ToListAsync();
    }

    public async Task CreateAssetsFolders()
    {
        try
        {
            List<Product> allproducts = await _db.Products.ToListAsync();
            foreach (Product product in allproducts)
            {
                var productfoldertocreate = Path.Combine(_hostingenv.ContentRootPath, "Storage", "Products",
                    $"{product.Id}", "Images");
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
        Product newproduct = new Product { Id = Guid.NewGuid(),name = producttoadd.name , description = producttoadd.description, descriptionbullets = producttoadd.descriptionbullets, CategoryId = producttoadd.SubCategoryId, price = producttoadd.price, addedon = new DateOnly(2024,1,1), DiscountEvent = null };
        await _db.Products.AddAsync(newproduct);
        var productfoldertocreate = Path.Combine(_hostingenv.ContentRootPath, "Storage", "Products", $"{newproduct.Id}", "Images");
        Directory.CreateDirectory(productfoldertocreate);
        foreach (var imagefile in producttoadd.imagefiles)
        {
            Directory.CreateDirectory(productfoldertocreate); 
        }
        await _db.SaveChangesAsync();
    }

    public async Task AddQuantity(string productid)
    {
        
    }

    public async Task RemoveQuantity(string productid)
    {
        
    }

    public async Task UpdateProduct(ProductDTO producttoupdate)
    {
        Product selectedproduct = await _db.Products.FirstAsync(x => x.Id == producttoupdate.id);
        _mapper.Map(producttoupdate, selectedproduct);
        await _db.SaveChangesAsync();
    }

    public async Task RemoveProduct(ProductDTO producttoremove)
    {
        Product removeproduct = await _db.Products.FirstAsync(x => x.Id == producttoremove.id);
        _db.Products.Remove(removeproduct);
        await _db.SaveChangesAsync();
    }
}   