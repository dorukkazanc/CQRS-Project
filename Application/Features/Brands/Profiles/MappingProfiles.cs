using Application.Features.Brands.Commands.Create;
using Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Paging;
using Core.Application.Responses;
using Application.Features.Brands.Queries.GetList;

namespace Application.Features.Brands.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
                
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
                
            CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
                
            CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();

            CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();

        }
    }
}
