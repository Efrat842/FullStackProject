using BL.servises;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {

        IBuyBL I;
        public BuyController(IBuyBL I)
        {
            this.I = I;
        }

        //שליפה
        [HttpGet("myget")]
        public List<BuyDTO> GetAll()
        {
            return I.GetAll();
        }

        //א:שמירת רשומה בטבלת קניות
        [HttpPut("SaveShopping")]
        public int SaveShopping(BuyDTO buy)
        {
            return I.SaveShopping(buy);
        }
    }
}
