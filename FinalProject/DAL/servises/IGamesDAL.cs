using DAL.Classes;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.servises
{
    public interface IGamesDAL
    {

        //שליפת רשימה
        public List<Game> GetAllGame();

        //הוספה לרשימה
        public bool AddGame(Game entity);

        //הסרת קטגוריה מהרשימה
        public bool DeleteGame(int id);

        //עידכון קטגוריה ברשימה
        public bool UpdateGame(int id, Game entity);

       
    }
}
