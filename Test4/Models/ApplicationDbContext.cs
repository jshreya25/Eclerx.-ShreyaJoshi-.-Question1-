using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test4.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext():base("EclerxCon")
        {

        }
        public DbSet<Registration> Registrations { get; set; }
    }
}