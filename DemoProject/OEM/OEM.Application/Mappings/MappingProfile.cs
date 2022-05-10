using AutoMapper;
using OEM.Application.Features.OEMCampaigns.Queries;
using OEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Application.Mappings
{
    internal class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<OEMCampaign, OEMCampaignVM>().ReverseMap();
        }
    }
}
