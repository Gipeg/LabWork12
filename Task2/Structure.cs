
namespace structure
{
    internal class Structure
    {
        public enum AccountType
        {
            Free,
            Premium,
            Corporate
        }
        public struct MailAccount
        {
            public string Username;
            public string Password;
            public AccountType AccountType;

            public MailAccount(string username, string password)
            {
                Username = username;
                Password = password;
                AccountType = AccountType.Free;
            }

        }

    }
}
