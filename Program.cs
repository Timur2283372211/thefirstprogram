using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace thefirstprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Якщо у тебе є 5 яблук і ти з'їв 2, скільки яблук у тебе залишилося?
            Console.WriteLine("Apples: " + (5 - 2));
            //2. У тебе є 4 коробки, в кожній з яких 3 олівці. Скільки у тебе олівців загалом?
            Console.WriteLine("Pensils: " + (4 * 3));
            //3. У тебе 10 печив, і ти хочеш розділити їх порівну між собою та своїм другом. Скільки печив отримає кожен?
            Console.WriteLine("Cookies: " + (10 / 2));
            //if 1. Дано ціле число. Якщо воно є позитивним, додати до нього 1; інакше не змінювати
            //його.Вивести отримане число.
            int number = int.Parse(Console.ReadLine());
            if (number > 0) {
                number++;
            }
            Console.WriteLine(number);
            //If 2.Дано ціле число. Якщо воно є позитивним, додати до нього 1; інакше відняти від нього
            //2.Вивести отримане число.
            if (number > 0)
            {
                number++;
            }
            else {
                number--;
            }
            Console.WriteLine(number);
            //If 3.Дано ціле число. Якщо воно є позитивним, додати до нього 1; якщо негативним, то
            //відняти від нього 2; якщо нульовим, то замінити його на 10.Вивести отримане число.
            if (number > 0)
            {
                number++;
            }
            else if (number == 0){
                number = 10;
            }
            else
            {
                number--;
            }
            Console.WriteLine(number);
            //If 4°. Дано два числа.Вивести більше з них.
            int number2 = int.Parse(Console.ReadLine());
            if (number > number2)
            {
                Console.WriteLine(number);
            }
            else 
            {
                Console.WriteLine(number2);
            }
            //If 5°. Дано два числа.Вивести спочатку більше, а потім менше з них.
            if (number > number2)
            {
                Console.WriteLine(number);
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number2);
                Console.WriteLine(number);
            }
            /*Напишіть програму, яка запитує у користувача поточний час(в годинах, від 0 до 23).
            Якщо час від 6 до 11 години включно, програма повинна виводити: "Доброго ранку!".
            Якщо від 12 до 17 години включно -"Доброго дня!".
            Якщо від 18 до 22 години включно -"Доброго вечора!".
            В інших випадках - "Доброї ночі!".*/
            Console.Write("Input time from 0 about 23 hours: ");
            int time = int.Parse(Console.ReadLine());
            if (time > 6 && time < 11)
            {
                Console.WriteLine("Доброго ранку!");
            }
            else if (time > 12 && time < 17)
            {
                Console.WriteLine("Доброго дня!");
            }
            else if (time > 18 && time < 22)
            {
                Console.WriteLine("Доброго вечора!");
            }
            else
            {
                Console.WriteLine("Доброї ночі!");
            }
            //Case 1. Дано ціле число у діапазоні 1–7. Вивести рядок - назву дня тижня, що відповідає
            //даному числу(1 - "понеділок", 2 - "вівторок" і т. д.).
        }
    }
}
