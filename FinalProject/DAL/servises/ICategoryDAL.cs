using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.servises
{
    public interface ICategoryDAL
    {
        //שליפת רשימה
        public List<Category> GetAllCatgory();

        //הוספה לרשימה
        public bool AddCatgory(Category entity);

        //הסרת קטגוריה מהרשימה
        public bool DeleteCatgory(int id);

        //עידכון קטגוריה ברשימה
        public bool UpdateCatgory(int id, Category entity);

    }
}
