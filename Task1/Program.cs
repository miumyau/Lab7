namespace Task1;
//Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
//(создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона 
class Program
{
    static double GetSquare (double a, double b, double c)
    {
        double p = (double)(a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите стороны первого треугольника");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());
        double S1 = GetSquare(a1, b1, c1);

        Console.WriteLine("Введите стороны второго треугольника");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());
        double c2 = Convert.ToDouble(Console.ReadLine());
        double S2 = GetSquare(a2, b2, c2);

       
        if (S1 > S2)
        {
            Console.WriteLine("Площадь первого треугольника больше");

        }
        else if (S1 < S2)
        {
            Console.WriteLine("Площадь второго треугольника больше");

        }

        else
        {
            Console.WriteLine("Площадь первого треугольника равна площади второго треугольника ");
        }
        Console.ReadKey();
    }
}

