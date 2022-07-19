using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserManager
    {
        void Register(User user);
        User GetUserByEmail(string email);
    }
}
