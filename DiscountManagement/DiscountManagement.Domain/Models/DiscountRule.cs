using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Domain.Models
{
    public class DiscountRule
    {
        public int DiscountRuleId { get; set; }
        public decimal DiscountValue { get; set; }

        //Foriegn Key
        public int DiscountTypeId { get; set; }

        [ForeignKey("DiscountTypeId")]
        public virtual DiscountType DiscountType { get; set; }
    }
}
