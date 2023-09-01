using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] places = { 9, 43, 67, 21 };
            string[] films = { "Барби", "Драйв", "Бегущий по лезвию 2047", "Шрек 2" };
            bool openProgram = true;
            while(openProgram)
            { 
            Console.SetCursorPosition(0, 20);
            for (int i = 0; i < places.Length; i++) 
            {
                Console.WriteLine("Оставшиеся билеты "+ "'"+films[i]+"'" +" "+places[i]);
            }
            Console.SetCursorPosition(0, 0);
            
                Console.WriteLine("купить - купить билеты");
                Console.WriteLine("выход - выход из программы");
                Console.Write( "Введите требуюмую операцию: ");

                string numberOfChoising = (Console.ReadLine());
                switch (numberOfChoising)
                {
                    case "купить":
                        Console.WriteLine("На какой фильм нужны билеты");
                        string filmUser = Console.ReadLine();
                        switch (filmUser)
                        {
                            case "Барби":
                                Console.WriteLine("Сколько билетов нужно купить");
                               int biletsKolv1 = Convert.ToInt32(Console.ReadLine());
                                if(biletsKolv1 > places[0]|| biletsKolv1 < 0)
                                {
                                    Console.WriteLine("Данная покупка невозможна");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    places[0] -= biletsKolv1;
                                    Console.WriteLine("Покупка успешна!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case "Драйв":
                                Console.WriteLine("Сколько билетов нужно купить");
                                int biletsKolv2 = Convert.ToInt32(Console.ReadLine());
                                if (biletsKolv2 > places[1] || biletsKolv2 < 0)
                                {
                                    Console.WriteLine("Данная покупка невозможна");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    places[1] -= biletsKolv2;
                                    Console.WriteLine("Покупка успешна!");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                break;
                                
                            case "Бегущий по лезвию 2047":
                                Console.WriteLine("Сколько билетов нужно купить");
                                int biletsKolv3 = Convert.ToInt32(Console.ReadLine());
                                if (biletsKolv3 > places[2] || biletsKolv3 < 0)
                                {
                                    Console.WriteLine("Данная покупка невозможна");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    places[2] -= biletsKolv3;
                                    Console.WriteLine("Покупка успешна!");
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                break;
                                
                            case "Шрек 2":
                                Console.WriteLine("Сколько билетов нужно купить");
                                int biletsKolv4 = Convert.ToInt32(Console.ReadLine());
                                if (biletsKolv4 > places[3] || biletsKolv4 < 0)
                                {
                                    Console.WriteLine("Данная покупка невозможна");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Покупка успешна!");
                                    places[3] -= biletsKolv4;
                                    Console.ReadKey();
                                    Console.Clear();

                                }
                                break;
                                
                            default:
                                Console.WriteLine("Данного фильма нет в прокате");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }

                        break;

                    case "выход":
                        openProgram = false;
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                }

            }

        }
    }
}
