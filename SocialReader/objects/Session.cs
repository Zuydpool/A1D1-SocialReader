using System;

namespace SocialReader.objects
{
    public class Session
    {
        private Account account;
        private DateTime sessionSince;
        private User selectedUser;

        public void CreateSession(Account account)
        {
            this.account = account;
            this.sessionSince = new DateTime();
            //Console.WriteLine("Users: " + account.Users);
        }

        public void setSelectedUser(User user)
        {
            selectedUser = user;
        }

        public void TerminateSession()
        {
            account = null;
        }

        public bool HasSession()
        {
            return account != null && selectedUser != null;
        }

        public bool HasUserSelected()
        {
            return selectedUser != null;
        }

        public string GetAccountUserName()
        {
            return account.Username;
        }

        public string GetUserName()
        {
            return selectedUser.Name;
        }

        public Account GetAccount()
        {
            return account;
        }
    }
}
