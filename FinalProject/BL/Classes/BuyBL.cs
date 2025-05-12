using AutoMapper;
using BL.servises;
using DAL.Models;
using DAL.servises;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Classes
{
    public class BuyBL : IBuyBL
    {

        IBuyDAL I;
        
        IMapper imap;

        public BuyBL(IBuyDAL i, IMapper m)
        {

            I = i;
            imap = m;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            m = config.CreateMapper();
        }

        

        public List<BuyDTO> GetAll()
        {
            return imap.Map<List<Buy>, List<BuyDTO>>(I.GetAll());
        }

        public int SaveShopping(BuyDTO s)
        {
            s.BuyDaty = DateTime.Today;
            Buy s1 = imap.Map<BuyDTO, Buy>(s);
            I.Add(s1);
            return s1.BuyId;
        }
    }


    


}

