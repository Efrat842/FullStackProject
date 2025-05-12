using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.servises
{
    public interface ICustemerBL
    {
        public List<CustemerDTO> GetAllCustomer();

        public bool AddCustomerd(CustemerDTO c);

        public bool IsExsistCustomerd(string pass, string name);

        //פונקצייה שמקבלת שם משתמש וסיסמה ומחזירה את הקוד האוטומטי שלו

        public int CustID(string pass, string name);
    }
}
