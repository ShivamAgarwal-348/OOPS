using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop
{
    internal class QuoteService
    {
        public RepairShopContext Context { get; init; }

        public QuoteService(RepairShopContext context) { Context = context; }


    }
}
