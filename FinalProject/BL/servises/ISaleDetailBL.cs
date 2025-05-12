using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.servises
{
    public interface ISaleDetailBL
    {
        //שליפה
        public List<SaleDetailDTO> GetAll();

        //ב:שמירת פרטי הקניה בטבלת פרטי קניה
        public bool Add(int buyId, List<ShoppingCartDTO> ListNewSal);

    }
}
