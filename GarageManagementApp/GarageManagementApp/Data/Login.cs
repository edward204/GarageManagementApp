using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementApp.Data
{

    [Table("Login")]
    public class Login
    {
        public int Login_id { get; set; }
        public String Login_username { get; set; }

        public String Login_password { get; set; }

        public String Login_firstname { get; set; }

        public String Login_surname { get; set; }

        public String Login_job_role { get; set; }
    }
}