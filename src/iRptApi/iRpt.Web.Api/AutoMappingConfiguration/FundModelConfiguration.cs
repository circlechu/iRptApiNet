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
    public class FundModelConfiguration : IAutoMapperTypeConfigurator
    {
        public void Configure()
        {
            Mapper.CreateMap<FundModel, Fund>().ForMember(opt => opt.Client, x => x.Ignore());
        }
    }
}