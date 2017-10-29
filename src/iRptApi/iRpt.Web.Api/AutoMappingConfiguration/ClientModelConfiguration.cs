using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using iRpt.Common.TypeMapping;
using iRpt.Data.Entities;
using iRpt.Web.Api.Models;

namespace iRpt.Web.Api.AutoMappingConfiguration
{
    public class ClientModelConfiguration : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<ClientModel, Client>();
            Mapper.CreateMap<Client, ClientModel>();
        }
    }
}