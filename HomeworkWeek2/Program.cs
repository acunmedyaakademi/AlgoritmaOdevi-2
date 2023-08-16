using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Soru Sayısı girin : ");
            string question = Console.ReadLine();

            if (question == "1")
            {
                Question1();
            }
            else if (question == "2")
            {
                Question2();
            }
            else if (question == "3")
            {
                Question3();
            }
            else if (question == "4")
            {
                Question4();
            }

        }

        static void Question1()
        {
            int i = 0;
            DateTime stop;
            DateTime start = DateTime.Now.ToLocalTime();

            while (i <= 3000000)
            {
                bool statüs = i.ToString().Contains("000000");
                if (statüs)
                {
                    stop = DateTime.Now.ToLocalTime();
                    string result = (stop - start).ToString();
                    var list = result.Split('.');
                    var print = list[1].ToString().Substring(0, 3);
                    Console.WriteLine($"{i} Sayısı gelene kadar geçen süre {print} milisaniyedir.");
                    start = DateTime.Now.ToLocalTime();
                }
                i++;
            }
            Console.ReadLine();
        }

        static void Question2()
        {
            // Mesaj Şifreleme 
            Console.WriteLine("Şifreli mesaj göndermek için 1 Şifreli mesajı çözmek için 2 giriniz.");
            int result = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            int pass = 0;
            string mess;
            var newlist = new List<int>();
            var returnlist = new List<int>();
            if (result == 1)
            {
                Console.Write("Göndermek istediğiniz 4 basamaklı veriyi giriniz : ");

                string data = Console.ReadLine();
                var list = data.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    number = Convert.ToInt32(list[i].ToString()) + 7;
                    pass = number - 10;
                    if (pass >= 0)
                    {
                        newlist.Add(pass);
                    }
                    else if (pass < 0)
                    {
                        pass = pass * (-1);
                        newlist.Add(pass);
                    }
                }
                Console.WriteLine("GÖnderilen şifreli veri : " + newlist[3] + newlist[4] + newlist[1] + newlist[2]);
            }

            // Mesaj Çözme 
            else if (result == 2)
            {
                Console.WriteLine("Çözmek istediğiniz 4 basamaklı sayıyı giriniz.");
                mess = Console.ReadLine();
                var list = mess.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    number = Convert.ToInt32(list[i].ToString()) + 7;
                    pass = number - 10;
                    if (pass >= 0)
                    {
                        returnlist.Add(pass);
                    }
                    else if (pass < 0)
                    {
                        pass = pass * (-1);
                        returnlist.Add(pass);
                    }
                }
                Console.WriteLine("GÖnderilen şifreli veri : " + newlist[3] + newlist[4] + newlist[1] + newlist[2]);
            }
            Console.ReadKey();
        }
        static void Question3()
        {
            int number = 0;
            for (int i = 2; i <= 30;)
            {
                Console.WriteLine(i);
                number += i;
                i = i + 2;

            }
            Console.WriteLine("Toplam : " + number);
            Console.ReadKey();
        }
        static void Question4()
        {

            Console.WriteLine("TAMAMLAAAAA");
            Console.ReadKey();
        }
        static void Question5()
        {


            do
            {
                result = Convert.ToInt32(Console.ReadLine());
                if (result == Convert.ToInt32(list[0]) + Convert.ToInt32(list[1]))
                {
                    Console.WriteLine("Çok güzel");
                    statüs = false;
                }
                else
                {
                    Console.WriteLine("Lütfen tekrar deneyin");
                }

            } while (statüs == true);


        }
        public string input()
        {
            int result = 0;
            string input;
            string statüs = "True";
            Console.WriteLine("Çarpmak istediğiniz 1 basamaklı 2 sayıyı giriniz : ");
            input = Console.ReadLine();
            var list = input.Split(' ');
            Console.WriteLine($"{list[0]} kere {list[1]} kaçtır ?");
            return list[0];
            return list[1];
            return statüs;
            
        }
    }
}
