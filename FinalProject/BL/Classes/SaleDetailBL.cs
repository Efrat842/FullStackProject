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
    public class SaleDetailBL : ISaleDetailBL
    {
        ISaleDetailDAL I;
        IMapper imap;

        public SaleDetailBL(ISaleDetailDAL i, IMapper m)
        {

            I = i;
            imap = m;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyProfile>();
            });
            m = config.CreateMapper();
        }


        //פונקציית שליפה של כל הפרטי קניה
        public List<SaleDetailDTO> GetAll()
        {
            return imap.Map<List<SaleDetail>, List<SaleDetailDTO>>(I.GetAll());
        }
        //ב:שמירת פרטי הקניה בטבלת פרטי קניה
      

        public bool Add(int buyId, List<ShoppingCartDTO> ListNewSal)
        {
            try
            {
                foreach (ShoppingCartDTO ListSal in ListNewSal)
                {

                    SaleDetailDTO bt = new SaleDetailDTO();//אני יוצרת משתנה מסוג פרטי קניה
                    bt.BuyId = buyId;
                    //bt.SaleCode = buyId;//ומכניסה לתוכו את הקוד האוטומטי
                    bt.GameId = ListSal.gameId;//הכנסת הקוד משחק של השורה הספציפית בסל לתוך הפרטי קניה
                    bt.SaleAmount = ListSal.GameAmount;//הכנסת כמות משחק של השורה הספציפית בסל לתוך הפרטי קניה
                    
                    SaleDetail saleDetail = imap.Map<SaleDetailDTO,SaleDetail>(bt);
                    I.Add(saleDetail);
                    //G.UpdateGamesAmount(bt.GameId, bt.BuyingDetailsAmount);

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
