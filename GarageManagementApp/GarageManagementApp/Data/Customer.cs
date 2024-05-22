using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementApp.Data
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public String Customer_firstname { get; set; }

        public String Customer_surname { get;set; }

        public String Customer_phone { get; set; }

        public String Customer_email { get; set; }

        public String Customer_address { get; set;}

        public String Customer_city { get; set;}
    }
}
