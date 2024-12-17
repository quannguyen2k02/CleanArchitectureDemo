using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Infrastructure.ExternalServices.Mapper;

public class ApplicationMapper:Profile
{
    public ApplicationMapper() 
    {
        CreateMap<Product, ProductDTO>();
        CreateMap<Order, OrderDTO>();
        CreateMap<OrderDetail, OrderDetailDTO>();

        //reverse map
        CreateMap<ProductDTO, Product>();
        CreateMap<OrderDTO, Order>();
        CreateMap<OrderDetailDTO, OrderDetail>();
    }
}
