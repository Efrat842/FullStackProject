using DAL.Models;
using DAL.servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class CategoryDAL : ICategoryDAL
    {
        GameStore_2025Context DB = new GameStore_2025Context();


        public bool AddCatgory(Category entity)
        {
            try
            {
                var existingCategory = DB.Categories.FirstOrDefault(c => c.CategoryName == entity.CategoryName);
                if (existingCategory != null)
                {
                    
                    return false;
                }

                DB.Categories.Add(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCatgory(int id)
        {
            try
            {

                Category i = DB.Categories.FirstOrDefault(o => o.CategoryId == id);
                DB.Categories.Remove(i);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Category> GetAllCatgory()
        {
            return DB.Categories.ToList();
        }

        public bool UpdateCatgory(int id, Category entity)
        {
            try
            {
                Category existingEntity = DB.Categories.FirstOrDefault(o => o.CategoryId == id);
                DB.Entry(existingEntity).CurrentValues.SetValues(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
