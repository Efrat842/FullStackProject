using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingCartDTO
    {

        public int gameId { get; set; }

        public string? GameName { get; set; }

        public int? GamePrice { get; set; }

        public int? GameAmount { get; set; }

        public int? AllGamePrice { get; set; }

    }
}
