using DiscountManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Repository.Interface
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(UserModel users);
    }
}
