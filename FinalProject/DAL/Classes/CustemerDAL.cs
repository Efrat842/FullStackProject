using DAL.Models;
using DAL.servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class CustemerDAL : ICustemerDAL
    {
        GameStore_2025Context DB = new GameStore_2025Context();

       

        public bool AddCustomer(Customer entity)
        {
            try
            {
                DB.Customers.Add(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {

                Customer i = DB.Customers.FirstOrDefault(o => o.CustId == id);
                DB.Customers.Remove(i);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool UpdateCustomer(int id, Customer entity)
        {
            try
            {
                Customer existingEntity = DB.Customers.FirstOrDefault(o => o.CustId == id);
                DB.Entry(existingEntity).CurrentValues.SetValues(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        List<Customer> ICustemerDAL.GetAllCustomer()
        {
            return DB.Customers.ToList();
        }
    }
}
