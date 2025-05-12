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
    public class GamesBL : IGamesBL
    {


        IMapper mapper;
        IGamesDAL I;

        public GamesBL(IMapper mapper, IGamesDAL I)
        {
            this.mapper = mapper;
            this.I = I;


            //var config = new MapperConfiguration(c =>
            // { 
            //c.AddProfile<MyProfile>();
            // });
            //mapper=config.CreateMapper();
            //
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<MyProfile>();
            });
            mapper = config.CreateMapper();
        }

        public bool AddGame(GameDTO entity)
        {
            //return I.AddGame(mapper.Map<GameDTO,Game>(entity));

            var game = mapper.Map<GameDTO, Game>(entity);
            return I.AddGame(game);
        }

        public bool DeleteGame(int id)
        {
           return I.DeleteGame(id);
        }

        public List<GameDTO> GatGameCatgory(int IdCatgory)
        {
            return mapper.Map<List<Game>, List<GameDTO>>(I.GetAllGame()).FindAll(x => x.GameCategory==IdCatgory);
        }

        public GameDTO GatIdGame(int id)
        {
            return mapper.Map<List<Game>, List<GameDTO>>(I.GetAllGame()).FirstOrDefault(x => x.GameId == id);
        }

        public List<GameDTO> GetAllGame()
        {
            return mapper.Map<List<Game>, List<GameDTO>>(I.GetAllGame());
        }

        public bool UpdateGame(int id, GameDTO entity)
        {
            Game game = mapper.Map<GameDTO,Game>(entity);   
            return I.UpdateGame(id, game);
        }

       
    }
}
