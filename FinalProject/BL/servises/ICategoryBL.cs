using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.servises
{
    public interface ICategoryBL
    {

        //שליפת רשימה
        public List<CategoryDTO> GetAllCatgory();

        //הוספה לרשימה
        public bool AddCatgory(CategoryDTO entity);

        //הסרת קטגוריה מהרשימה
        public bool DeleteCatgory(int id);

        //עידכון קטגוריה ברשימה
        public bool UpdateCatgory(int id, CategoryDTO entity);

        //שליפת משחק ע"י קוד 
        public CategoryDTO GatIdCatgory(int id);

    }
}
