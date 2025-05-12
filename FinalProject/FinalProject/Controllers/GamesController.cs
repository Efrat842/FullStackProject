using BL.servises;
using DAL.Models;
using DAL.servises;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {

        IGamesBL I;
        public GamesController(IGamesBL I)
        {
            this.I = I;
        }

        [HttpGet("myget")]
        public List<GameDTO> getGame()
        {
            return I.GetAllGame();
            
        }


        [HttpPut("addGame")]
        public bool addGame(GameDTO g)
        {
           
                return I.AddGame(g);
           
        }


        // הסרת קטגוריה מהרשימה
        [HttpDelete("delete/{id}")]
        public bool DeleteGame(int id)
        {
           
                return I.DeleteGame(id);
           
        }

        // עידכון קטגוריה ברשימה
        [HttpPost("update/{id}")]
        public bool UpdateGame(int id, GameDTO game)
        {
            
                return I.UpdateGame(id, game);
            
        }

        [HttpGet("GetByID")]
        public GameDTO GatIdGame(int id)
        {
            return I.GatIdGame(id); 
        }

        [HttpGet("GetByIDCatgory")]
        public List<GameDTO> GatGameCatgory(int IdCatgory)
        {
            return I.GatGameCatgory(IdCatgory);
        }

    }


}
