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
    public class CustemerBL : ICustemerBL
    {
        ICustemerDAL I;
        IMapper mapper;

        public CustemerBL(ICustemerDAL ic)
        {
            I = ic;
            var config = new MapperConfiguration(cf =>
                cf.AddProfile<MyProfile>());
            mapper = config.CreateMapper();
        }



        public bool AddCustomerd(CustemerDTO c)
        {
            Customer cu = mapper.Map<CustemerDTO, Customer>(c);
            return I.AddCustomer(cu);
        }

        public List<CustemerDTO> GetAllCustomer()
        {
            return mapper.Map<List<Customer>, List<CustemerDTO>>(I.GetAllCustomer());
        }

        public bool IsExsistCustomerd(string pass, string name)
        {
            List<Customer> AllCistemer = I.GetAllCustomer();
            Customer customer = AllCistemer.FirstOrDefault(x => x.CustPassWord == pass && x.CustName == name);
            if (customer == null)
                return false;
            return true;

        }

        public int CustID(string pass, string name)
        {
            List<CustemerDTO> getAll = mapper.Map<List<Customer>, List<CustemerDTO>>(I.GetAllCustomer());

            for (int i = 0; i < getAll.Count; i++)
            {
                if (getAll[i].CustName == name && getAll[i].CustPassWord == pass)
                {
                    return getAll[i].CustId;
                }
            }
            return 0;
        }


        

        //public int CustID(string pass, string name)

        //{

        //    List<CustemerDTO> allCustomers = mapper.Map<List<Customer>, List<CustemerDTO>>(I.GetAllCustomer());


        //    var customer = allCustomers.FirstOrDefault(c => c.CustName == name && c.CustPassWord == pass);


        //    return customer != null ? customer.CustId : 0;

        //}
    }
}

