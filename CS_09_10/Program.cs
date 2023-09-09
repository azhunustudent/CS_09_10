namespace CS_09_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ранее в одном из практических заданий вы создавали класс «Shop».
            // Добавьте к уже созданному классу информацию о площади магазина.
            // Выполните перегрузку + (для увеличения площади магазина на указанную величину),
            // — (для уменьшения площади магазина на указанную величину),
            // == (проверка на равенство площадей магазинов),
            // < и > (проверка на меньше или больше площади магазина),
            // != и Equals. Используйте механизм свойств для полей класса.

            Shop shop1 = new Shop(100);
            Shop shop2 = new Shop(150);

            Console.WriteLine("Shop1: " + shop1);
            Console.WriteLine("Shop2: " + shop2);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Operator + : {shop1} + 30 = {shop1 + 30}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Operator - : {shop2} - 70 = {shop2 - 70}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Operator < : {shop1} < {shop2} : {shop1 < shop2}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Operator > : {shop1} > {shop2} : {shop1 > shop2}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Operator == : " + (shop1 == shop2));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Operator != : " + (shop1 != shop2));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Equals Method: " + shop1.Equals(shop2));
        }
    }
}