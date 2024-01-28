using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_custom_orm.Attributes
{
	public class EntityAttribute : Attribute
	{
		public string TableName { get; set; }
	}
}
