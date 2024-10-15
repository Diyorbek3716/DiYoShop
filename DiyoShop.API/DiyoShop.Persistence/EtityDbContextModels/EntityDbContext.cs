using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyoShop.Persistence.EtityDbContextModels
{
	public class EntityDbContext:DbContext
	{
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base(options) { }

        
    }
}
