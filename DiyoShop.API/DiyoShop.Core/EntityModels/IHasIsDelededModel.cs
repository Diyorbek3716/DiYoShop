using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyoShop.Core.EntityModels
{
	public interface IHasIsDelededModel
	{
		public bool IsDeleded { get; set; }
	}
}
