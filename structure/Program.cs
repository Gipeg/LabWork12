public class structure
{

    public enum OrderType
    {
        Free,
        Proffesional,
        Corporate
    }
    public struct OrderAccount
    {
        public string Name;
        public string Addres;
        public OrderType OrderType;
    }
}