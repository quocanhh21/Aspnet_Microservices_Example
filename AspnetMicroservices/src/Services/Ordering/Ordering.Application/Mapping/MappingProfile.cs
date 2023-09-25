﻿using AutoMapper;
using Ordering.Application.Features.Oders.Commands.CheckoutOrder;
using Ordering.Application.Features.Oders.Commands.UpdateOrder;
using Ordering.Application.Features.Oders.Queries.GetOrderList;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
