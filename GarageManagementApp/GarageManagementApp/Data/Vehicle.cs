using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementApp.Data
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int Vehicle_id { get; set; }
        public int Customer_id { get; set; }
        public string Reg_plate {  get; set; } 
        public string Vehicle_model { get; set; }  
        public string Vehicle_make { get; set; }
        public string Vehicle_colour { get; set; } 
    }
}
