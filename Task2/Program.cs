public enum AccountType
{
    Free,
    Premium,
    Corporate
}
//Для вполнения этого задания возьмём аккаунт почты(как пример)
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

    public void DisplayInfo()
    {
        Console.WriteLine("Username: " + Username);
        Console.WriteLine("Password: " + Password);
        Console.WriteLine("Account Type: " + AccountType);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MailAccount account1 = new MailAccount("user123", "password");
        account1.AccountType = AccountType.Premium;
        account1.DisplayInfo();
        Console.WriteLine();

        MailAccount account2 = new MailAccount("Admin", "123456");
        account2.DisplayInfo();
    }
}