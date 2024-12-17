using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IMapper mapper, IUnitOfWork unitOfWork) 
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<ProductDTO> AddProduct(ProductDTO productDTO)
    {
        var product = _mapper.Map<Product>(productDTO);
        var result = await _unitOfWork.Products.Add(product);
        await _unitOfWork.Complete();
        return productDTO;
    }

    public async Task<List<ProductDTO>> GetAllProducts()
    {
        return _mapper.Map<List<ProductDTO>>(await _unitOfWork.Products.GetAll());
    }

    public async Task<ProductDTO> GetProductById(int id)
    {
        return _mapper.Map<ProductDTO>(await _unitOfWork.Products.Find(x=>x.Id == id));
    }

    public Task<ProductDTO> UpdateProduct(ProductDTO product)
    {
        throw new NotImplementedException();
    }
}
