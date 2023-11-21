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

    public ProductsRepository(DataContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<List<Product>> GetProducts()
    {
        return await _db.Products.ToListAsync();
    }

    public async Task<List<Product>> GetProductsByCategory(string category)
    {
        return await _db.Products.Where(x => x.category == category).ToListAsync();
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