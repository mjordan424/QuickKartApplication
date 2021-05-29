using System;
using QuickKartDAL.AllModels.Models;
namespace QuickKartDAL
{
    public class QuickKartRepository : IQuickKartRepository
    {
        private readonly QuickKartDBContext quickKartDBContext;
        public QuickKartRepository()
        {
            quickKartDBContext = new QuickKartDBContext();
        }

        public byte ValidateUser(string emailId, string password)
        {
            byte roleid = 99;
            var user = quickKartDBContext.Users.Find(emailId);
            if(user!=null)
            {
                if(password.Equals(user.UserPassword))
                {
                    roleid = user.RoleId;
                }
                else
                {
                    roleid = 98;
                }
            }
            return roleid;
        }
    }
}
