using AutoMapper;
using BL.servises;
using DAL.Models;
using DAL.servises;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Classes
{
    public class CategoryBL : ICategoryBL
    {

        IMapper mapper;
        ICategoryDAL I;

        public CategoryBL(IMapper mapper, ICategoryDAL I)
        {
            this.mapper = mapper;
            this.I = I;

            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<MyProfile>();
            });
            mapper = config.CreateMapper();
        }

        public bool AddCatgory(CategoryDTO entity)
        {
            var game = mapper.Map<CategoryDTO, Category>(entity);
            return I.AddCatgory(game);
        }

        public bool DeleteCatgory(int id)
        {
            return I.DeleteCatgory(id);

        }

        public CategoryDTO GatIdCatgory(int id)
        {
            return mapper.Map<List<Category>, List<CategoryDTO>>(I.GetAllCatgory()).FirstOrDefault(x => x.CategoryId == id);
        }

        public List<CategoryDTO> GetAllCatgory()
        {
            return mapper.Map<List<Category>, List<CategoryDTO>>(I.GetAllCatgory());
        }

        public bool UpdateCatgory(int id, CategoryDTO entity)
        {
            Category c = mapper.Map<CategoryDTO, Category>(entity);
            return I.UpdateCatgory(id, c);
        }
    }
}
