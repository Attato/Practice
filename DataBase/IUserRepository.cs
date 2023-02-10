using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataBase
{
    public interface IUserRepository
    {
        Boolean CheckUser(string login,string password);
    }
}
