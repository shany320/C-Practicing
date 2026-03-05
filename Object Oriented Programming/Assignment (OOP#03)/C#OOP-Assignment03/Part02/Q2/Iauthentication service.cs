using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment03.Part02.Q2
{
    interface Iauthentication_service
    {
        public bool Authenticate_user(string username, string password);
        public bool Authorize_user(string username,Userrole role);
    }
}
