using DAL.EF;
using DAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.UserDetails
{
    internal class UserRepo : IRepo<user_details, int, bool>
    {
        public bool Create(user_details obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<user_details> Get()
        {
            throw new NotImplementedException();
        }

        public user_details Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(user_details obj)
        {
            throw new NotImplementedException();
        }
    }
}
