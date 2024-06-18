public class MyClass // Задание 1
{
    private string name;
    private int age;

    public MyClass(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Name //Задание 2
    {
        get { return name; }
        set
        {
            if(value.Length < 1) 
            {
                Console.WriteLine("Ошибка: имя не может быть пустым");
            }
            else
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ошибка: возраст не может меньше 0");
            }
            else { age = value; }
        }
    } // конец 2 задания

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name );
        Console.WriteLine("Age: " + age);
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass("Edic Yazikov", 21);
        obj1.DisplayInfo();

        Console.WriteLine();
        MyClass obj2 = new MyClass("Mishka Koreev", 17);
        obj2.DisplayInfo();
    }
}