using System;
using System.Collections.Generic;
using System.Text;
using testbank.Sistemas;

namespace testbank
{
    public class CommercialPartner : IAuthentication
    {
        public string password { get; set; }
        

        public bool Authentication(string password)
        {
            return this.password == password;
        }
    }
}
