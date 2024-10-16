using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyoShop.Identity.Models.Roles
{
	public class Role:IdentityRole
	{
        public Role() { }

        public Role( string roleName, string? discreption)
        {
            Name = roleName;
            Discription = discreption;
        }

        public string? Discription {  get; set; }
        
    }
}
