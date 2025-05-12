using DAL.Models;
using DAL.servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Classes
{
    public class BuyDAL : IBuyDAL
    {

        GameStore_2025Context DB = new GameStore_2025Context();

        public bool Add(Buy item)
        {
            try
            {
                DB.Buys.Add(item);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Buy> GetAll()
        {
            return DB.Buys.ToList();
        }
    }
}
