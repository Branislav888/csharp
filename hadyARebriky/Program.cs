﻿using System.Diagnostics;
using System.Threading;

namespace hadyARebriky
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     HHH       HHH           AAA           DDDDDDDD      YYYY         YYY");
            Console.WriteLine("     HHH       HHH          AAAAA          DDD    DDD     YYY        YYY");
            Console.WriteLine("     HHH       HHH         AAA AAA         DDD     DDD     YYY      YYY");
            Console.WriteLine("     HHH       HHH        AAA   AAA        DDD      DDD     YYY    YYY");
            Console.WriteLine("     HHHHHHHHHHHHH       AAAAAAAAAAA       DDD       DDD     YYY  YYY");
            Console.WriteLine("     HHHHHHHHHHHHH      AAAAAAAAAAAAA      DDD       DDD      YYYYY");
            Console.WriteLine("     HHH       HHH     AAA         AAA     DDD      DDD        YYY");
            Console.WriteLine("     HHH       HHH    AAA           AAA    DDD     DDD         YYY");
            Console.WriteLine("     HHH       HHH   AAA             AAA   DDDDDDDD            YYY");
            Console.WriteLine();
            Console.WriteLine("                                 AAA");
            Console.WriteLine("                                AAAAA");
            Console.WriteLine("                               AAA AAA");
            Console.WriteLine("                              AAA   AAA");
            Console.WriteLine("                             AAAAAAAAAAA");
            Console.WriteLine("                            AAAAAAAAAAAAA");
            Console.WriteLine("                           AAA         AAA");
            Console.WriteLine("                          AAA           AAA");
            Console.WriteLine("                         AAA             AAA");
            Console.WriteLine();
            Console.WriteLine("RRRRRRRR      EEEEEEEEE   BBBBBBBB     RRRRRRRR     IIIIIIII  KKK      KKK   YYYY         YYY");
            Console.WriteLine("RRR    RRR    EEE         BBB    BBB   RRR    RRR     III     KKK    KKK      YYY        YYY");
            Console.WriteLine("RRR     RRR   EEE         BBB     BBB  RRR     RRR    III     KKK  KKK         YYY      YYY");
            Console.WriteLine("RRR     RRR   EEE         BBB    BBB   RRR     RRR    III     KKK KKK           YYY    YYY");
            Console.WriteLine("RRR    RRR    EEEEEEE     BBBBBBB      RRR    RRR     III     KKKKKK             YYY  YYY");
            Console.WriteLine("RRR RRRR      EEE         BBB    BBB   RRR RRRR       III     KKK KKK             YYYYY");
            Console.WriteLine("RRR   RRR     EEE         BBB     BBB  RRR   RRR      III     KKK  KKK             YYY");
            Console.WriteLine("RRR    RRR    EEE         BBB    BBB   RRR    RRR     III     KKK   KKK            YYY");
            Console.WriteLine("RRR     RRR   EEEEEEEEE   BBBBBBBB     RRR     RRR  IIIIIIII  KKK     KKK          YYY");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("Ak chceš začať hrať hru zmačkni tlačidlo ENTER");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Vyber možnosť:");
            Console.WriteLine("Zmačkni čislo 1 ak chceš vedieť informacie o tom kdo vytvoril tuto hru");
            Console.WriteLine("Zmačkni čislo 2 ak chceš vedieť pravidla o tejto hre");
            Console.WriteLine("Zmačkni čislo 3 ak chceš napisať recenziu alebo dať napad na vylepšenie");
            Console.WriteLine("Zmačkni čislo 4 ak chceš začať hrať hru");
            
            

            
            bool running = true;
            while (running) 
            {

                
                var choice = Console.ReadLine();

                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Tato hra bola vytvorena Branislavom Sventekom a Alicou Laštíkovou" +
                            "z 1.AI skupiny Appslab");
                        Thread.Sleep(1000);
                        break;


                    case "2":
                        Console.WriteLine("Pravidla hry su jednoduché:");
                        Thread.Sleep(1000);
                        Console.WriteLine("Hodiš kocko a posunieš sa dane poličko");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak na poličku sa nachdza rebrik posunieš sa na poličko kde rebrik konči");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak sa nachadzaš na poličku kde je hadová hlava");
                        Thread.Sleep(1000);
                        Console.WriteLine("tak sa  Console.WriteLin až na hodov chvost ");
                        Thread.Sleep(1000);
                        Console.WriteLine("Kdo bode prvý v cieli hrava.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ak pravidla neboli jasné tak nam dajte vedieť na naš email :))");
                        Thread.Sleep(1000);
                        Console.WriteLine("Prajeme vela zabavý a hlavne šťastia");
                        Thread.Sleep(1000);
                        break;

                   
                    case "3":
                        Console.WriteLine("Môžete nam napísať ako sa vam hra pači a čo by ste na nej vylepšili na email branislaw3@gmail.com alebo alicalastikova12@gmail.com");
                        Thread.Sleep(100);
                        break;

                    case "4":

                        {

                            Kocka kocka = new Kocka();  

                            Hrac1 hrac1 = new Hrac1("Hráč 1");
                            Hrac2 hrac2 = new Hrac2("Hráč 2");
                            

                            Console.WriteLine("Hráč 1 hodí kockou:");
                            int hod1 = hrac1.HodKockou(kocka);
                            Console.WriteLine($"{hrac1.Meno} hodil: {hod1} (Skóre: {hrac1.Skore})");
                            

                            Console.WriteLine("Hráč 2 hodí kockou:");
                            int hod2 = hrac2.HodKockou(kocka);
                            Console.WriteLine($"{hrac2.Meno} hodil: {hod2} (Skóre: {hrac2.Skore})");

                            
                        }
                        break;

                        
                }
            }
        }
    }  
}