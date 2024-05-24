using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagementApp.Data
{
    [Table("Job")]
    public class Job
    {
        [Key]
        public int Job_id { get; set; } 
        public string Job_type { get; set; }

        //public int Task_id { get; set; }
    }
}
