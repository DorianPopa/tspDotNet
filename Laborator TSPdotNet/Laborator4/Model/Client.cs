using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laborator4.Model
{
    public partial class Client
    {
        public int ClientId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        // 0 = inregistrare corecta; 1 = inregistrare stearsa
        //public int Deleted { get; set; }

        public ICollection<Order> Orders { get; set; }

        protected Client() { }
    }

}
