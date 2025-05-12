using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DTO
{
    public class MyProfile : Profile
    {
        public MyProfile() {
           
            CreateMap<Game,GameDTO>();
            CreateMap<GameDTO, Game>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Customer, CustemerDTO>();
            CreateMap<CustemerDTO,Customer>();

            CreateMap<Buy, BuyDTO>();
            CreateMap<BuyDTO, Buy>();

            CreateMap<SaleDetail, SaleDetailDTO>();
            CreateMap<SaleDetailDTO, SaleDetail>();       
        }
    }
}
