using BL.Classes;
using BL.servises;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailController : ControllerBase
    {
        ISaleDetailBL I;
        public SaleDetailController(ISaleDetailBL i)
        {
            I = i;
        }

        //שליפה
        [HttpGet("myget")]
        public List<SaleDetailDTO> GetAll()
        {
            return I.GetAll();
        }

        //א:שמירת רשומה בטבלת קניות
        [HttpPut("Add/{buyId}")]
        public bool Add(int buyId, List<ShoppingCartDTO> salKniots)
        {

            return I.Add(buyId, salKniots);
        }
    }
}
