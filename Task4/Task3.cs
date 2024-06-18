namespace Task3
{
    internal class Task3
    {
        enum ТипЗаказчика
        {
            Корпоративный,
            Частный
        }

        class Заказчик
        {
            public string ФИО { get; set; }
            public string Адрес { get; set; }
            public double ПотраченнаяСумма { get; set; }
            public ТипЗаказчика Тип { get; set; }

            public Заказчик(string ФИО, string Адрес, double ПотраченнаяСумма)
            {
                this.ФИО = ФИО;
                this.Адрес = Адрес;
                this.ПотраченнаяСумма = ПотраченнаяСумма;
                this.Тип = ТипЗаказчика.Корпоративный;
            }

            public void ВывестиИнформацию()
            {
                Console.WriteLine($"ФИО: {ФИО}");
                Console.WriteLine($"Адрес: {Адрес}");
                Console.WriteLine($"Потраченная сумма: {ПотраченнаяСумма}");
                Console.WriteLine($"Тип заказчика: {Тип}");
            }
        }
    }
}
