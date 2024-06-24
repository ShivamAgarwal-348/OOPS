using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        //public ICollection<Vehicle> Vehicles { get; set; } = new HashSet<Vehicle>();
    }
}
