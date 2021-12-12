using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    public delegate double delegate1(double R);

    public class MyMath
    {
        public static double Circumference(double R)
        {
            double l = 2 * Math.PI * R;
            return l;
        }
        public static double CircleSquare(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            return S;
        }
        public static double SphereVolume(double R)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            return V;
        }

    }
    internal class Program
    {
        static void Main()
        {
            delegate1 toCircumference = new delegate1(MyMath.Circumference);
            delegate1 toCircleSquare = new delegate1(MyMath.CircleSquare);
            delegate1 toSphereVolume = new delegate1(MyMath.SphereVolume);

            Console.Write("Введите радиус: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Длина окружности: {toCircumference(radius):f2}");
            Console.WriteLine($"Площадь окружности: {toCircleSquare(radius):f2}");
            Console.WriteLine($"Обьем шара: {toSphereVolume(radius):f2}");



            Console.ReadKey();
        }
    }
}
