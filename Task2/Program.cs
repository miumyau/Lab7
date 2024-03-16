namespace Task2;
//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
class Program
{
    static void GetVolSquare (double a, out double V, out double S)
    {
        V = a * a * a;
        S = 6 * a * a;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра куба");
        double a = Convert.ToDouble(Console.ReadLine());
        double V;
        double S;
        GetVolSquare(a, out V, out S);
        Console.WriteLine("Площадь {0:.00}, Объем {1:.00}",S,V);
        Console.ReadKey();
    }
}

