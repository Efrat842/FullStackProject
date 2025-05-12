using BL.servises;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using DAL.servises;




namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
       

        ICategoryBL I;
        public CategoryController(ICategoryBL I)
        {
            this.I = I;
        }

        [HttpGet("myget")]
        public List<CategoryDTO> GetAllCatgory()
        {
            return I.GetAllCatgory();

        }


        [HttpPut("addCategory")]
        public bool AddCatgory(CategoryDTO g)
        {

            return I.AddCatgory(g);

        }


        // הסרת קטגוריה מהרשימה
        [HttpDelete("delete/{id}")]
        public bool DeleteCatgory(int id)
        {

            return I.DeleteCatgory(id);

        }

        // עידכון קטגוריה ברשימה
        [HttpPost("update/{id}")]
        public bool UpdateCatgory(int id, CategoryDTO category)
        {

            return I.UpdateCatgory(id, category);

        }

            [HttpGet("GetByID")]
            public CategoryDTO GatIdCatgory(int id)
            {
                return I.GatIdCatgory(id);
            }

            //[HttpGet("GetByIDCatgory")]
            //public List<GameDTO> GatGameCatgory(int IdCatgory)
            //{
            //    return I.GatGameCatgory(IdCatgory);
            //}

        }


    }
