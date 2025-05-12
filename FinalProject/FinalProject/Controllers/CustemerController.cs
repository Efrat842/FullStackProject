using BL.servises;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustemerController : ControllerBase
    {

        ICustemerBL I;
        public CustemerController(ICustemerBL i)
        {
            this.I = i;
        }

        [HttpGet("GetAll")]
        public List<CustemerDTO> GetAllCustomer()
        {
            return I.GetAllCustomer();
        }
        [HttpPut("Add")]
        public bool Add(CustemerDTO c)
        {
            return I.AddCustomerd(c);
        }
        [HttpGet("ifExist/{pass}/{name}")]
        public bool IfExsist(string pass, string name)
        {
          
            return I.IsExsistCustomerd(pass,name); 
        }
        [HttpGet("CustID/{pass}/{name}")]
        public int CustID(string pass, string name)
        {
            return I.CustID(pass,name); 
        }

    }
}
