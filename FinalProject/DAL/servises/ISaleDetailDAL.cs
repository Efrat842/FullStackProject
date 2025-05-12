using DAL.Classes;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.servises
{
    public interface ISaleDetailDAL
    {

        //שליפה
        public List<SaleDetail> GetAll();

        //הוספה
        public bool Add(SaleDetail item);
    }
}
