using API.Data.DTOs;
using API.Data.Models;
using API.Services.Images;
using API.Services.ProductsRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("Warehouse")]
public class WarehouseController : Controller
{
    private readonly IProductsRepository _warehouse;
    
    public WarehouseController(IProductsRepository warehouse)
    {
        _warehouse = warehouse;
    }

    [HttpGet("GetAllProducts")]
    public async Task<List<Product>> GetAllProducts()
    {
        return await _warehouse.GetProducts();
    }
    
    [HttpGet("GetParentCategories")]
    public async Task<List<ParentCategory>> GetParentCategories()
    {
        return await _warehouse.GetParentCategories();
    }
    
    [HttpGet("GetCategories/{patid}")]
    public async Task<List<Category>> GetCategories(string patid)
    {
        return await _warehouse.GetCategories(patid);
    }
    
    [HttpGet("GetProduct/{productid}")]
    public async Task<Product> GetProduct(string productid)
    {
        return await _warehouse.GetProduct(productid);
    }
    
    [HttpGet("GetCategoryProducts/{categoryid}")]
    public async Task<List<Product>> GetCategoryProducts(string categoryid)
    {
        return await _warehouse.GetProductsByCategory(categoryid);
    }

    [HttpGet("MostSelling")]
    public async Task<List<Product>> ReturnMostSelling()
    {
        return await _warehouse.GetMostSelling();
    }

    [HttpPost("AddProduct")]
    public async Task AddProduct(ProductDTO newproductrequest)
    { 
        await _warehouse.AddProduct(newproductrequest);
    }
    
}