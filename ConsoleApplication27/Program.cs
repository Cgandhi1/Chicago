using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 50);
            string chars = "ABC DEF GHIJ KLMNOPQ RSTUV WXYZ abcdef ghi jklmn op qrst uvwxyz";
            Random rnd = new Random();
            StringBuilder b = new StringBuilder(randomNumber);
            for (int i = 0; i < randomNumber; i++)
            {
                b.Append(chars[rnd.Next(chars.Length)]);
            }
            string city = b.ToString();

            string combined = "";
            string combo = "";
            city = city.ToLower().Replace(" ", "");
            int count = 0;
            for (int i = 0; i < city.Length;)
            {
                count = city.Count(x => x == city[i]);
                string result = new string('*', count);
                combined = (city[i] + ":" + result + ",");
                combo = combo + combined;
                city = city.Replace(city[i], ' ').Replace(" ", "");

            }
            combo = combo.Remove(combo.Length - 1, 1);
            Console.WriteLine(combo);
            Console.ReadLine();

        }
    }
}
