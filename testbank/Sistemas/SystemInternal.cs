using System;
using System.Collections.Generic;
using System.Text;

namespace testbank.Sistemas
{
    class SystemInternal
    {
        public bool Login(IAuthentication employee, string password)
        {
            bool authenticatedUser = employee.Authentication(password);
            if (authenticatedUser) { 
                Console.WriteLine("Login Realizado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Autenticação invalida");
                return true;
            }
        }
    }
}
