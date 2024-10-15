using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyoShop.Core.EntityModels
{
	public class BaseEntity:IHasIsDelededModel
	{
		public Guid Id { get; set; }
		[AllowNull]
		public DateTime CreateDate { get; set; }
		[AllowNull]
		public DateTime UpdateDate { get; set; } 
		[AllowNull]
		public Guid CreateBy { get; set; }
		[AllowNull]
		public Guid UpdateBy { get; set; }
		public bool IsDeleted { get; set; }
	}
}
