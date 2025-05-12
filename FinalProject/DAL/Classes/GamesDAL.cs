using DAL.Models;
using DAL.servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class GamesDAL : IGamesDAL
    {

        GameStore_2025Context DB = new GameStore_2025Context();

        
        public bool AddGame(Game entity)
        {
            try
            {
                DB.Games.Add(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGame(int id)
        {
            try
            {
                
                Game i = DB.Games.FirstOrDefault(o => o.GameId == id);
                DB.Games.Remove(i);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Game> GetAllGame()
        {

            return DB.Games.ToList();
        }

        public bool UpdateGame(int id, Game entity)
        {

            try
            {

                Game existingEntity = DB.Games.FirstOrDefault(o=>o.GameId==id);
                DB.Entry(existingEntity).CurrentValues.SetValues(entity);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
