using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        //homework
        //number8
        //static double Density(double mass, double volume)
        //{
        //    return mass / volume;
        //}

        //number9
        //static double Current(double resistance, double voltage)
        //{
        //    return voltage / resistance;
        //}

        //number10
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 целые числа от 20 до 25");
            Console.WriteLine("2 квадраты всех целых чисел от 10 до b");
            Console.WriteLine("3 третьи степени всех целых чисел от a до 50");
            Console.WriteLine("4 все целые числа от a до b");
            Console.WriteLine("\n0 выход");
        }
        static void Main(string[] args)
        {
            //number 1
            //Random rand = new Random();
            //int a, b, c;

            //a = rand.Next(15);
            //b = rand.Next(15);
            //c = rand.Next(15);


            //Console.Write(a);
            //Console.Write(" ");
            //Console.Write(b);
            //Console.Write(" ");
            //Console.Write(c);

            //Console.ReadKey();
            //number2
            //Console.WriteLine(5);
            //Console.WriteLine(10);
            //Console.WriteLine(21);
            //Console.ReadKey();
            //number3
            //Console.WriteLine("Сантиметры в полные метры\n");
            //Console.Write("СМ: ");
            //int sm = Int32.Parse(Console.ReadLine());
            //int m = (int)(sm * .01);
            //Console.Write("М: " + m);

            //Console.ReadLine();
            //number4
            //int day = 234;
            //int week = day / 7;

            //Console.WriteLine(week);
            //Console.ReadKey();

            //number5
            //int number = 23;
            //int unit = number % 10;
            //int decade = number / 10;
            //var sum = unit + decade;
            //var composition = unit * decade;


            //Console.WriteLine(decade);
            //Console.WriteLine(unit);
            //Console.WriteLine(sum);
            //Console.WriteLine(composition);
            //Console.ReadKey();
            //number6
            //bool A = true;
            //bool B = false;
            //bool C = false;

            //bool result1 = A || B;
            //bool result2 = A && B;
            //bool result3 = B || C;

            //Console.WriteLine("A || B = " + result1);
            //Console.WriteLine("A && B = " + result2);
            //Console.WriteLine("B || C = " + result3);

            //Console.ReadLine();
            //7

            //int side = 2;
            //int radius = 3;

            //double CircleSquare = 3.14 * Math.Pow(radius, 2);
            //double Square = Math.Pow(side, 2);

            //Console.WriteLine(CircleSquare);
            //Console.WriteLine(Square);

            //if (CircleSquare < Square)
            //{
            //    Console.WriteLine("Площодь квадрата больше площади круга");
            //}
            //else Console.WriteLine("Площодь круга больше площади квадрата");

            //Console.ReadKey();
            //number8
            //double volume1, mass1, volume2, mass2;

            //Console.WriteLine("У какого материала бОльшая плотность?\n");

            //Console.WriteLine("Материал 1");
            //Console.Write("Объем: ");
            //volume1 = Double.Parse(Console.ReadLine());
            //Console.Write("Масса: ");
            //mass1 = Double.Parse(Console.ReadLine());

            //double density1 = Density(mass1, volume1);
            //Console.WriteLine("Плотность: " + density1);

            //Console.WriteLine("\nМатериал 2");
            //Console.Write("Объем: ");
            //volume2 = Double.Parse(Console.ReadLine());
            //Console.Write("Масса: ");
            //mass2 = Double.Parse(Console.ReadLine());

            //double density2 = Density(mass2, volume2);
            //Console.WriteLine("Плотность: " + density2);

            //string answer = density1 > density2 ? "первого" : "второго";
            //Console.WriteLine("\nНаибольшая плотность у {0} материала", answer);

            //Console.ReadLine();

            //number9
            //double resistance1, voltage1, resistance2, voltage2;

            //Console.WriteLine("По какому участку цепи проходит меньший ток?\n");

            //Console.WriteLine("Участок 1");
            //Console.Write("Сопротивление: ");
            //resistance1 = Double.Parse(Console.ReadLine());
            //Console.Write("Напряжение: ");
            //voltage1 = Double.Parse(Console.ReadLine());

            //double elCurrent1 = Current(resistance1, voltage1);
            //Console.WriteLine("Ток: " + elCurrent1);

            //Console.WriteLine("\nУчасток 2");
            //Console.Write("Сопротивление: ");
            //resistance2 = Double.Parse(Console.ReadLine());
            //Console.Write("Напряжение: ");
            //voltage2 = Double.Parse(Console.ReadLine());

            //double elCurrent2 = Current(resistance2, voltage2);
            //Console.WriteLine("Ток: " + elCurrent2);

            //string answer = elCurrent1 < elCurrent2 ? "первому" : "второму";
            //Console.WriteLine("\nМеньший ток проходит по {0} участку цепи", answer);

            //Console.ReadLine();

            //number10
            string menu = "#";

            while (menu != "0")
            {
                Menu();
                Console.Write("Выберите действие: ");
                menu = Console.ReadLine();

                Console.Clear();
                if (menu == "1")
                {
                    for (int i = 20; i < 25; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }
                else if (menu == "2")
                {
                    Console.Write("Верхняя граница(b>10): ");
                    int number = Int32.Parse(Console.ReadLine());

                    number = number < 10 ? 20 : number;

                    for (int i = 10; i < number; i++)
                    {
                        Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if (menu == "3")
                {
                    Console.Write("Нижняя граница(a<50): ");
                    int number = Int32.Parse(Console.ReadLine());

                    number = number > 50 ? 40 : number;

                    for (int i = number; i < 50; i++)
                    {
                        Console.WriteLine(i + "^3 = " + Math.Pow(i, 2));
                    }
                    Console.ReadLine();
                }
                else if (menu == "4")
                {
                    Console.Write("Нижняя граница: ");
                    int numberA = Int32.Parse(Console.ReadLine());
                    Console.Write("Верхняя граница: ");
                    int numberB = Int32.Parse(Console.ReadLine());

                    if (numberA > numberB)
                    {
                        int tmp = numberB;
                        numberB = numberA;
                        numberA = tmp;
                    }

                    for (; numberA < numberB; numberA++)
                    {
                        Console.WriteLine(numberA);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
