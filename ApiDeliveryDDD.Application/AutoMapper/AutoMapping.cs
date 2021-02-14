using ApiDeliveryDDD.Application.Dtos;
using ApiDeliveryDDD.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDeliveryDDD.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            #region Entities to Dto

            CreateMap<Client, ClientDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Delivery, DeliveryDto>();
            CreateMap<Employee, EmployeeDto>();

            #endregion

            #region Dto to Entities

            CreateMap<ClientDto, Client>();
            CreateMap<CompanyDto, Company>();
            CreateMap<DeliveryDto, Delivery>();
            CreateMap<EmployeeDto, Employee>();

            #endregion
        }
    }
}
