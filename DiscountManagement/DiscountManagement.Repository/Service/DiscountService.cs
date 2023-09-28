using DiscountManagement.Data.Data;
using DiscountManagement.Domain.Models;
using DiscountManagement.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Repository.Service
{
    public class DiscountService: IDiscountService
    {
        public readonly ApplicationDbContext _dbContext;
        public DiscountService(ApplicationDbContext dbContext) 
        {
           _dbContext = dbContext;
        
        }

        public async Task<bool> AddDiscountType(DiscountType discountType)
        {
            try
            {
                var model = new DiscountType() {
                    DiscountName = discountType.DiscountName
                };
                _dbContext.DiscountTypes.Add(model);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }
}
