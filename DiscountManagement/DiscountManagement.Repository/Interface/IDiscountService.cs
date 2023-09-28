using DiscountManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Repository.Interface
{
    public interface IDiscountService
    {
        Task<bool> AddDiscountType(DiscountType discountType);
        
        
        //int GetId(string name);
        //DiscountType GetAllDiscountType(int id);
        //int DeleteDiscountType(int id);

        //Task<bool> DeleteDiscountType(DiscountType discountType);
        //Task<DiscountType> GetDiscountTypeById(int id);
        //Task<DiscountType> GetDiscountTypeById(string id);
        //Task<DiscountType> GetDiscountTypeById(DiscountType discountType);
        //Task<DiscountType> GetDiscountTypeById();

    }
}
