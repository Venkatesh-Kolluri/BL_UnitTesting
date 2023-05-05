using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class UserManager
    {
        public IDatabaseService Services { get; }

        public UserManager(IDatabaseService services)
        {
            Services = services;
        }

        public bool AddNewUser(UserModel User)
        {
            return this.Services.AddUser(User);
        }
    }
}
