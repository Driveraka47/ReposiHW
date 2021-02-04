#region Автор Ткаченко Влад Задача:1. Написать программу «Анкета».
#endregion
using System;
//имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Здравствуйте, Это программа Анкета. \n\t Введите свои данные на нижеследующие вопросы:");
            Console.WriteLine("Как вас зовут?\n"); 
            String name = Console.ReadLine();
            Console.WriteLine("Напишите вашу Фамилию \n");
            String sname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            int age = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Какой у вас рост?\n");
            int tol = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Какой у вас вес?\n");
            int wet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваши данные: {name} {sname}, Возраст  {age} года, Рост {tol} см, Вес {wet} кг.");
            Console.ReadLine();
        }
   
    
    }
}
