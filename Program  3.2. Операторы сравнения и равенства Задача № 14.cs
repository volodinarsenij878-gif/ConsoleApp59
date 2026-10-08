using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = new int[] { 1 };
            object b = new int[] { 1 };

            // 1. Оператор == для object: сравнивает ссылки
            bool refCompare = a == b;
            Console.WriteLine($"a == b (ссылки) = {refCompare}"); // False

            // 2. Явная проверка ссылок
            bool sameRef = object.ReferenceEquals(a, b);
            Console.WriteLine($"ReferenceEquals(a, b) = {sameRef}"); // False

            // 3. Сравнение содержимого массивов (приводим к int[] и используем SequenceEqual)
            // Это уже не про оператор ==, а про сравнение значений — важно показать контраст
            bool contentCompare = ((int[])a).SequenceEqual((int[])b);
            Console.WriteLine($"Содержимое массивов одинаково = {contentCompare}"); // True
        }
    }
}

