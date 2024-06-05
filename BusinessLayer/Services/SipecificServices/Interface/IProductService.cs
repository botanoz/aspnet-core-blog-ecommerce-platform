
using BusinessLayer.Services.GenericServices;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// Product service interface defining additional operations specific to Product.
/// </summary>
public interface IProductService : IGenericService<Product>
{
    Task<Product> GetProductByNameAsync(string name);
}