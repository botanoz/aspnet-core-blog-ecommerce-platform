
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Product service implementation providing specific operations for Product.
/// </summary>
public class ProductService : GenericService<Product>, IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork.Products, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> GetProductByNameAsync(string name)
    {
        return await _unitOfWork.Products.FirstOrDefaultAsync(p => p.Name == name);
    }
}