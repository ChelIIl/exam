using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static Products[] prod;
        static int num;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите кол-во продуктов: ");
                string val = Console.ReadLine();

                while (!Int32.TryParse(val, out num) || num < 0)
                {
                    Console.WriteLine("Введите целое число!");
                    val = Console.ReadLine();
                }

                prod = new Products[num];
                MasFill();
                DesSort();
                FileSave();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static private void MasFill()
        {
            try
            {
                int price;
                string val;

                for (int i = 0; i < num; i++)
                {
                    prod[i] = new Products();

                    Console.WriteLine("Рыба №{0}:", i + 1);
                    Console.WriteLine("Введите вид рыбы: ");
                    val = (Console.ReadLine());
                    prod[i].SetFishType = val;

                    Console.WriteLine("Введите наименование производителя: ");
                    val = Console.ReadLine();
                    prod[i].SetProiz = val;

                    Console.WriteLine("Введите цену рыбы: ");
                    val = Console.ReadLine();
                    while (!Int32.TryParse(val, out price) || price < 0)
                    {
                        Console.WriteLine("Некорректный ввод цены!");
                        val = Console.ReadLine();
                    }
                    prod[i].SetPrice = price;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);            }
        }

        static private void DesSort()
        {
            prod = prod.AsQueryable<Products>().OrderByDescending(f => f.fishtype).ThenByDescending(p => p.price).ToArray();
        }

        static private void FileSave()
        {
            using(StreamWriter sw = new StreamWriter("products.txt"))
            {
                foreach (Products item in prod)
                {
                    sw.WriteLine(item.fishtype + "||" + item.proiz + "||" + item.price);
                }                
            }

            Console.WriteLine("Массив отсортирован и сохранен в файл!");
        }
    }
}
