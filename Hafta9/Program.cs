using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matematik_Library;

namespace Hafta9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            Hesapla h = new Hesapla();
            bool flag = true;

            while (flag)
            { 
                if (list.Count == 0)
                {
                    Console.WriteLine("İlk Sayıyı Giriniz: ");
                    list.Add(Convert.ToDouble(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Bir sayı giriniz veya İşlem Giriniz Toplama(t)/Çarpma(ç): ");
                    var Value = Console.ReadLine();

                    switch (Value)
                    {
                        case "t":
                           Console.WriteLine(  h.Topla(list.ToArray()));
                            flag = false;
                            break;
                        case "ç":
                            Console.WriteLine(h.Carpma(list.ToArray()));
                            flag = false;
                            break;
                        default:
                            list.Add(Convert.ToDouble(Value));
                            break;
                    }
                }
            }

           // Hesapla h = new Hesapla();
           //Console.Write("Toplam = " +  h.Topla(1, 2, 3, 4, 5));
           //Console.Write("Çarpım = " +  h.Carpma(1, 2, 3, 4, 5));

        }
    }
}
