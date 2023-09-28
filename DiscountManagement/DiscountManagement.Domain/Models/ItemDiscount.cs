using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Domain.Models
{
    public class ItemDiscount
    {
        public int ItemDiscountId { get; set; }

        public bool IsActive { get; set; }

        //Foriegn Key
        public int DiscountRuleId { get; set; }
        public virtual DiscountRule DiscountRule { get; set; }

        public int ItemId { get; set; }
        public virtual ItemDiscount Item { get; set; }
    }
}
