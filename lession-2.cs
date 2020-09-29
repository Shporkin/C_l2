using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Lession_2
    ///Григорий Шпоркин
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Домашнее задание 1 
            ///Написать метод, возвращающий минимальное из трёх чисел.

            int n1, n2, n3;
            int min;

            Console.Write($"Введите первое число: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write($"Введите второе число: ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.Write($"Введите третье число: ");
            int.TryParse(Console.ReadLine(), out n3);

            if (n1 < n2 && n1 < n3) min = n1;
            else if (n2 < n3) min = n2;
            else min = n3;
            Console.WriteLine(min);

            #endregion

            //max = (n1 > n2 && n1 > n3) ? n1 : (n2 > n3) ? n2 : n3;


            #region Домашнее задание 2

            ///Написать метод подсчета количества цифр числа.

            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            Console.ReadKey();

            #endregion

            #region Домашнее задание 3

            ///С клавиатуры вводятся числа, пока не будет введен 0. 
            ///Подсчитать сумму всех нечетных положительных чисел.

            int sum = 0;
            int num_s = 0;

            do
            {
                num_s = int.Parse(Console.ReadLine());
                if (num_s > 0 && num_s % 2 == 1)
                    sum += num_s;

            } while (num_s != 0);

            Console.WriteLine("Cумма всех нечетных положительных чисел равна " + sum);

            #endregion

            #region Домашнее задание 4

            ///Реализовать метод проверки логина и пароля. 
            ///На вход метода подается логин и пароль. 
            ///На выходе истина, если прошел авторизацию, и ложь, если не прошел 
            ///(Логин: root, Password: GeekBrains). 
            ///Используя метод проверки логина и пароля, написать программу: 
            ///пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            ///С помощью цикла do while ограничить ввод пароля тремя попытками.

            string login = "root";
            string password = "GeekBrains";

            int c = 0;

            do
            {
                Console.WriteLine("\nВведите логин: ");
                string userLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string userPassword = Console.ReadLine();

                if (login == userLogin && password == userPassword)
                {

                    Console.WriteLine("Вы успешно прошли проверку");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Вы взломщик или просто пьяный?");
                Console.ReadLine();
                ++c;
            } while (c < 3);

            #endregion

            #region Домашнее задание 5 А

            ///Написать программу, которая запрашивает массу и рост человека, 
            ///вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
            ///набрать вес или всё в норме.

            ///16 и менее  Выраженный дефицит массы тела
            ///16—18,5 Недостаточная(дефицит) масса тела
            ///18,5—25 Норма
            ///25—30   Избыточная масса тела(предожирение)
            ///30—35   Ожирение
            ///35—40   Ожирение резкое

            Console.Write("\nВведите вес человека в кг: ");
            double ves = double.Parse(Console.ReadLine());

            Console.Write("\nВведите рост человека в см: ");
            double rost = double.Parse(Console.ReadLine());

            rost /= 100;

            double index = ves / (rost * rost);

            Console.Write("Индекс массы тела: " + index);

            if (index >= 18.5 && index <= 25)
            {

                Console.WriteLine("Ваш вес в пределах нормы");
                Console.ReadLine();
            }

            else if (index < 18.5)
            {
                Console.WriteLine("Масса вашего тела недостаточна");
                Console.ReadLine();
            }

            else Console.WriteLine("Масса вашего тела избыточна");

            Console.ReadKey();

            #endregion

            #region Домашнее задание 7

            ///Разработать рекурсивный метод, 
            ///который выводит на экран числа от a до b(a<b)

            Console.Write("Введите число а: ");
            int a_f = (int)double.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b_f = (int)double.Parse(Console.ReadLine());

            int aa = a_f;
            int bb = a_f + 1;
            int ii, rec;

            for (ii = a_f; ii < b_f; ii++)
            {
                rec = aa;
                aa = bb;
                bb += rec;

                Console.WriteLine(rec + " ");

            }

            Console.ReadKey();

            #endregion
        }


    }
}


