using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.servises
{
    public interface IBuyBL
    { 
        //א:שמירת רשומה בטבלת קניות 
        public int SaveShopping(BuyDTO s);


        //שליפה
        public List<BuyDTO> GetAll();
      

       
       

      

    }
}
