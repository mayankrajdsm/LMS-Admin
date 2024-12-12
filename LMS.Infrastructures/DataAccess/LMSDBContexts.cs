using LMS.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructures.DataAccess
{
    public class LMSDBContexts:DbContext
    {
        public DbSet<Class> Class1Set { get; set; }
        public LMSDBContexts(DbContextOptions<LMSDBContexts> dbcontext): base (dbcontext) 
        {
        }
    }
}
