using API.Data.DTOs;
using API.Data.Models;
using API.Services.Images;
using API.Services.ProductsRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/*
[Authorize]
*/
[ApiController]
[Route("Warehouse")]
public class WarehouseController : Controller
{
    private readonly IProductsRepository _warehouse;
    private readonly I_ImageService _imageservice;

    public WarehouseController(IProductsRepository warehouse, I_ImageService imageService)
    {
        _warehouse = warehouse;
        _imageservice = imageService;
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
    
    [HttpPost("GetCategories")]
    public async Task<List<Category>> GetCategories(string parentcategoryid)
    {
        return await _warehouse.GetCategories(parentcategoryid);
    }
    
    [HttpGet("GetProduct/${productid}")]
    public async Task<Product> GetProduct(string productid)
    {
        return await _warehouse.GetProduct(productid);
    }
    
    [HttpGet("GetCategorizedProducts/${category}")]
    public async Task<List<Product>> GetCategorizedProducts(string category)
    {
        return await _warehouse.GetProductsByCategory(category);
    }

    [HttpGet("MostSelling")]
    public async Task<List<Product>> ReturnMostSelling()
    {
        return await _warehouse.GetMostSelling();
    }

    [HttpGet("GetImage/${productid}/${imagename}")]
    public async Task<FileContentResult> GetImage(Guid productid,string imagename)
    {
        var image = await _imageservice.ServeImage(imagename, productid);
        return File(image, "image/jpeg");
    }
    
    [HttpPost("AddProduct")]
    public async Task AddProduct(ProductDTO newproductrequest)
    {
        try
        {
            await _warehouse.AddProduct(newproductrequest);
        }
        catch (Exception err)
        {
            throw err;
        }
    }
    
}