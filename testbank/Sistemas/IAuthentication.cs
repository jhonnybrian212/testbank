using System;
using System.Collections.Generic;
using System.Text;

namespace testbank.Sistemas
{
    public interface IAuthentication
    {
        bool Authentication(string password);
    }
}
