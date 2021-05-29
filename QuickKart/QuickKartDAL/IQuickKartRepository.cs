using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartDAL
{
    public interface IQuickKartRepository
    {
        byte ValidateUser(string emailId, string password);
    }
}
