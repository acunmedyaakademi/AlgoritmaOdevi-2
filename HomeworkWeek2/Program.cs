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
        bas:
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
            else if (question == "5")
            {
                Question5();
            }
            else if (question == "6")
            {
                Question6();
            }
            else if (question == "7")
            {
                Question7();
            }
            else if (question == "8")
            {
                Question8();
            }
            else
            {
                Console.Write("Hatalı Sayı girdiniz");
                goto bas;
            }

        }
        //*****************QUESTION_1*************************//
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
        //*****************QUESTION_2*************************//
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
                    if (number >= 10)
                    {
                        number = number - 10;
                        newlist.Add(number);
                    }
                    else if (number < 10)
                    {
                        newlist.Add(number);
                    }

                    //pass = number - 10;
                    //if (pass >= 0)
                    //{
                    //    newlist.Add(pass);
                    //}
                    //else if (pass < 0)
                    //{
                    //    pass = pass * (-1);
                    //    newlist.Add(pass);
                    //}
                }
                Console.WriteLine("GÖnderilen şifreli veri : " + newlist[2] + newlist[3] + newlist[0] + newlist[1]);
            }

            // Mesaj Çözme 
            else if (result == 2)
            {
                Console.WriteLine("Çözmek istediğiniz 4 basamaklı sayıyı giriniz.");
                mess = Console.ReadLine();
                var list = mess.ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    number = Convert.ToInt32(list[i].ToString());

                    if (number >= 0 && number<=6)
                    {
                        number = number + 3;
                        returnlist.Add(number);
                    }
                    else
                    {
                        number = number - 7;
                        returnlist.Add(number);
                    }
                    
                    //pass = number - 10;
                    //if (pass >= 0)
                    //{
                    //    returnlist.Add(pass);
                    //}
                    //else if (pass < 0)
                    //{
                    //    pass = pass * (-1);
                    //    returnlist.Add(pass);
                    //}
                }
                Console.WriteLine("GÖnderilen şifreli veri : " + returnlist[2] + returnlist[3] + returnlist[0] + returnlist[1]);
            }
            Console.ReadKey();
        }
        //*****************QUESTION_3*************************//
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
        //*****************QUESTION_4*************************//
        
        static bool mukemmel(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }
            return toplam == sayi;
        }

        static void Question4()
        {

            for (int i = 1; i < 2000; i++)
            {
                if (mukemmel(i) == true)
                {
                    Console.WriteLine($"{i} Mükemmel sayıdır.");
                }
            }
            Console.ReadLine();


           


        }
        //*****************QUESTION_5*************************//
        static void Question5()
        {
            bool statüs = true;
            int result = Convert.ToInt32(Input());
            
            while (statüs)
            {
                int cevapx = Convert.ToInt32(Console.ReadLine());
                if (result == cevapx)
                {
                    Console.WriteLine("Çok güzel");
                    
                    Console.WriteLine("Yeni soru girmek istiyor musunuz?(y/n)");
                    string input = Console.ReadLine();
                    if (input.ToLower() =="y" || input.ToLower() == "yes")
                    {
                        statüs = true;
                        result = Convert.ToInt32(Input());
                    }
                    else if (input.ToLower() == "n" || input.ToLower() == "no")
                    {
                        statüs = false;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen tekrar deneyin");
                    
                }
            }
            
        }
        public static string Input()
        {
            string input;
            Console.Write("Çarpmak istediğiniz 1 basamaklı 2 sayıyı aralarında boşluk bırakarak giriniz : ");
            input = Console.ReadLine();
            var list = input.Split(' ');
            Console.WriteLine($"{list[0]} kere {list[1]} kaçtır ?");
            return (Convert.ToUInt16(list[0]) * Convert.ToUInt16(list[1])).ToString();   
        }
        //*****************QUESTION_6*************************//
        static void Question6()
        {










            
        }
        //*****************QUESTION_7*************************//
        static void Question7()
        {
            Console.WriteLine("Aralarında birer boşluk bırakacak şekilde diziye eklemek istediğiniz sayıları girin : ");
            var list = Console.ReadLine().Split(' ');
            List<int> numberList = new List<int>();
            List<int> asalList = new List<int>();
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                numberList.Add(Convert.ToInt32(list[i]));
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = 2; j <= numberList[i]; j++)
                {
                    int result = numberList[i] % j ;
                    if (result == 0)
                    {
                        count +=1;
                    }
                }
                if (count == 1)
                {
                    asalList.Add(numberList[i]);
                }
                count = 0;
            }
            Console.WriteLine("Asal sayılar aşağıdadır. ");
            foreach (var item in asalList)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            Console.ReadKey();  
        }
        //*****************QUESTION_8*************************//
        static void Question8()
        {
            Console.WriteLine("Aralarında birer boşluk bırakacak şekilde listeye eklemek istediğiniz sayıları girin : ");
            var list = Console.ReadLine().Split(' ');
            List<int> numberList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                numberList.Add(Convert.ToInt32(list[i]));
            }
            int smallest = numberList.Min();
            int biggest = numberList.Max();
            Console.WriteLine($"En küçük sayı : {smallest}");
            Console.WriteLine($"En Büyük sayı : {biggest}");
            Console.ReadKey();
        }
    }
}
