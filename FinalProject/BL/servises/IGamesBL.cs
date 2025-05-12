using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.servises
{
    public interface IGamesBL
    {


        //שליפת רשימה
        public List<GameDTO> GetAllGame();

        //הוספה לרשימה
        public bool AddGame(GameDTO entity);

        //הסרת קטגוריה מהרשימה
        public bool DeleteGame(int id);

        //עידכון קטגוריה ברשימה
        public bool UpdateGame(int id, GameDTO entity);


        //שליפת משחק ע"י קוד 
        public GameDTO GatIdGame(int id);

        //שליפת משחקים לפי קטגוריה מבוקשת
        public List<GameDTO> GatGameCatgory(int IdCatgory);
    }
}
