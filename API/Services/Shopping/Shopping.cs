using API.Data;
using API.Data.DTOs;
using API.Data.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Shopping;

class Shopping : IShopping
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public Shopping(DataContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<bool> AddProductToCartCheck(Guid productid)
    {
        return await _db.Products.AnyAsync(x => x.Id == productid);
    }

    public async Task<bool> Checkout(PurchaseLogDTO purchasetolog)
    {
        PurchaseLog purchaselog = _mapper.Map<PurchaseLog>(purchasetolog);
        await _db.PurchaseLogs.AddAsync(purchaselog);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task RetrieveCart()
    {
        throw new NotImplementedException();
    }
    
    
    
}