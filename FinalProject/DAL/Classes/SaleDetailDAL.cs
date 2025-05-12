using DAL.Models;
using DAL.servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class SaleDetailDAL : ISaleDetailDAL
    {

        GameStore_2025Context DB = new GameStore_2025Context();

        public bool Add(SaleDetail item)
        {
            try
            {
                DB.SaleDetails.Add(item);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SaleDetail> GetAll()
        {
            return DB.SaleDetails.ToList();

        }
    }

}
 
