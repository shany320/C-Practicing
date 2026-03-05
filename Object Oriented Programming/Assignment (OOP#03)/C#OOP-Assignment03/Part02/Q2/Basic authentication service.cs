using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment03.Part02.Q2
{
    class Basic_authentication_service : Iauthentication_service
    {
        public string username { get; set; }
        public string Password { get; set; }
        public Userrole role { get; set; }

        private Dictionary<string, (string password, Userrole role)> users = new()
        {
            { "Saif",("1234",Userrole.Admin) },
            { "Omar",("abcd",Userrole.User) },
            { "Ahmed",("54321",Userrole.Guest) }

        };
        public bool Authenticate_user(string username, string Password)
        {
            return users.ContainsKey(username) && users[username].password == Password;
        }

        public bool Authorize_user(string username, Userrole Role)
        {
            return users.ContainsKey(username) && users[username].role ==Role ;
        }
    }
}
