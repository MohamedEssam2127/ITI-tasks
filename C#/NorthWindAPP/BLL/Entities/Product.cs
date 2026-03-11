using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class Product : EntityBase
    {

		public Product() => this.State = EntitySate.Added;

        public int ProductID { get; set;  }
		public required string ProductName
		{
			get;
			set
			{
				if (field != value)
				{
					field = value;
					if (State != EntitySate.Added)
						this.State = EntitySate.Modified;
				}
			}
		}
		public int? SupplierID { get; set;  }
        public int? CategoryID { get; set; }
		public string? QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; }
		public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
		public bool Discontinued { get; set; }
    }
}
