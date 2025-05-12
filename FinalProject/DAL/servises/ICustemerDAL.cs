using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.servises
{
    public interface ICustemerDAL
    {
        //שליפת רשימה
        public List<Customer> GetAllCustomer();

        //הוספה לרשימה
        public bool AddCustomer(Customer entity);

        //הסרת קטגוריה מהרשימה
        public bool DeleteCustomer(int id);

        //עידכון קטגוריה ברשימה
        public bool UpdateCustomer(int id, Customer entity);

    }
}
