using DiscountManagement.Domain.Models;
using DiscountManagement.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscountManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountRuleController : ControllerBase
    {
        private readonly IDiscountService _idiscountService;
        public DiscountRuleController(IDiscountService idiscountService) 
        {
           _idiscountService = idiscountService;
        
        }

        [HttpGet]
        public IEnumerable<string> DiscountType()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string DiscountType(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<bool> SaveDiscountType(DiscountType discountTypeModel)
        {
            return await _idiscountService.AddDiscountType(discountTypeModel);
        }

        [HttpDelete]
        public void RemoveDiscountType(int id)
        {

        }

    }
}
