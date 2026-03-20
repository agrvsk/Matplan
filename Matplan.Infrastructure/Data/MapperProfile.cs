using System;
using AutoMapper;
using Matplan.EntityModels.Models;
using Matplan.Infrastructure.IdentityModel;
using Matplan.Shared.AuthDtos;
using Matplan.Shared.EntityDtos;
using Matplan.Shared.KodtabellDtos;
using Microsoft.AspNetCore.Identity;

namespace Matplan.Infrastructure.Data;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Z_Veckodag, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Steg, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Plandag, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_NejJa, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Matratt, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Maltid, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Ja, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_Handlar, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_BristViaSMS, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_BeredInkop, KodtabellByteDto>().ReverseMap();
        CreateMap<Z_ART_RecEnh, KodtabellByteDto>().ReverseMap();

        CreateMap<Z_VG, KodtabellStringDto>()
            .ForMember(dest => dest.Displayed, opt => opt.MapFrom(src => src.DisplayedVG));

        CreateMap<KodtabellStringDto, Z_VG>()
            .ForMember(dest => dest.DisplayedVG, opt => opt.MapFrom(src => src.Displayed));


        CreateMap<Z_Kat, KodtabellStringDto>().ReverseMap();
        CreateMap<Z_HI, KodtabellStringDto>().ReverseMap();
        CreateMap<Z_ART_Typ, KodtabellStringDto>().ReverseMap();
        CreateMap<Z_ART_Lagring, KodtabellStringDto>().ReverseMap();
        CreateMap<Z_ART_Grupp, KodtabellStringDto>().ReverseMap();

        CreateMap<Z_ART_Enhet, KodtabellStringDto>().ReverseMap();
        CreateMap<Z_AltBild, KodtabellStringDto>().ReverseMap();

        //CreateMap<Z_Datum, KodtabellDateDto>().ReverseMap();



        CreateMap<Artikel_ART, ArtikelDto>().ReverseMap();
        CreateMap<User_USR, UserRegistrationDto>().ReverseMap();
        CreateMap<IdentityResult ,RegistrationResultDto>().ReverseMap();



        //CreateMap<DeviationDto, Deviation>().ReverseMap();
        //CreateMap<DeviationUpdateDto, Deviation>().ReverseMap();

        //CreateMap<OfflineQueueCreateDto, OfflineQueue>().ReverseMap();
        //CreateMap<OfflineQueueDto, OfflineQueue>().ReverseMap();
        //CreateMap<OfflineQueueUpdateDto, OfflineQueue>().ReverseMap();

        //CreateMap<OrderItemDto, OrderItem>();
        //CreateMap<OrderItem, OrderItemDto>()
        //.ForMember(dest => dest.ProductDto, opt => opt.MapFrom(src => src.Product));
        //;

        //CreateMap<OrderItemCreateDto, OrderItem>().ReverseMap();
        //CreateMap<OrderItemUpdateDto, OrderItem>().ReverseMap();

        ////CreateMap<OrderDto,         Order>().ReverseMap();
        //CreateMap<OrderDto, Order>();
        //CreateMap<Order, OrderDto>()
        //    .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));



        ////      CreateMap<OrderCreateDto,   Order>().ReverseMap();
        //CreateMap<OrderCreateDto, Order>()
        //    .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
        //CreateMap<Order, OrderCreateDto>();

        //CreateMap<OrderUpdateDto, Order>().ReverseMap();

        //CreateMap<ProductCreateDto, Product>().ReverseMap();
        //CreateMap<ProductDto, Product>().ReverseMap();
        //CreateMap<ProductUpdateDto, Product>().ReverseMap();

        //CreateMap<ScanCreateDto, Scan>().ReverseMap();
        //CreateMap<ScanDto, Scan>().ReverseMap();
        //CreateMap<ScanUpdateDto, Scan>().ReverseMap();

        //CreateMap<SystemLogCreateDto, SystemLog>().ReverseMap();
        //CreateMap<SystemLogDto, SystemLog>().ReverseMap();
        //CreateMap<SystemLogUpdateDto, SystemLog>().ReverseMap();

        //CreateMap<UserCreateDto, User>().ReverseMap();
        //CreateMap<UserDto, User>().ReverseMap();
        //CreateMap<UserUpdateDto, User>().ReverseMap();

        //CreateMap<ShopifySyncParam, ShopifySyncParamDto>().ReverseMap();
        //CreateMap<ShopifySyncParam, ShopifySyncParamCreateDto>().ReverseMap();
        //CreateMap<ShopifySyncParam, ShopifySyncParamUpdateDto>().ReverseMap();

        //// User mappings
        //CreateMap<UserRegistrationDto, User>().ReverseMap();
        //CreateMap<UserCreateDto, User>().ReverseMap();
        //CreateMap<UserUpdateDto, User>().ReverseMap();

        //// PackingSession mappings
        //CreateMap<PackingSession, PackingSessionDto>().ReverseMap();
    }
}
