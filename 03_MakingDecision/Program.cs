﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Please enter password: ");
            //string password;
            //password=Console.ReadLine();
            //if (password=="abcd")
            //{
            //    Console.WriteLine("Password is true");
            //}
            //else
            //{
            //    Console.WriteLine("Password is false");
            //}

            //string capital, country;

            //Console.Write("Please enter capital: ");
            //capital = Console.ReadLine();

            //Console.Write("Plase enter country: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Data verified");
            //}
            //else
            //{
            //    Console.Write("Incorrect information");
            //}


            //int number;
            //Console.Write("Please enter number: ");
            //number=int.Parse(Console.ReadLine());
            //if (number==5)
            //{
            //    Console.WriteLine("Number is true");
            //}
            //else
            //{
            //    Console.Write("Incorrect Number");
            //}


            //int exam1, exam2, exam3, average;

            //string result="Error";

            //Console.Write("Exam 1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Exam 2: ");
            //exam2=int.Parse(Console.ReadLine());

            //Console.Write("Exam 2: ");
            //exam3=int.Parse(Console.ReadLine());


            //average=(exam1+exam2+exam3)/3;

            //Console.WriteLine("Average of exams: "+average);

            //if (average>0 & average<=50)
            //{
            //    result="result is mediocre";
            //}

            //if (average>50 & average<=70)
            //{
            //    result="result is medium";
            //}

            //if (average>70 & average<=84)
            //{
            //    result="result is good";
            //}


            //if (average>84)
            //{
            //    result="result is very good";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Please enter city: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city=="ankara" || city=="bursa" || city=="trabzon") 
            //{
            //    Console.WriteLine("City is available");
            //}
            //else
            //{
            //    Console.WriteLine("City is not available");
            //}

            //Console.Write("Please enter username: ");
            //string username=Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.WriteLine("This username incorrect");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome");
            //}
            #endregion

            #region Mod Operations

            //int number;
            //number=26;
            //int result = number%5;
            //Console.WriteLine(result);

            //Console.Write("Please enter first number: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Please enter second number: ");
            //int number2= int.Parse(Console.ReadLine());

            //int result=number1%number2;

            //Console.WriteLine("Remainder of the division of the 1st number by the 2nd number: " +result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number%2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team=='f' | team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team=='b' | team=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Egitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------");
            //Console.ReadLine();
            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if(menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somun");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------------Ana Yemekler-------------");

            //    Console.WriteLine();

            //}

            //if (menuItem =="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");

            //    Console.WriteLine("-------------Çorbalar-------------");

            //    Console.WriteLine();

            //}
            //if (menuItem =="3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");

            //    Console.WriteLine("-------------Pizzalar-------------");

            //    Console.WriteLine();

            //}
            //if (menuItem =="4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");

            //    Console.WriteLine("-------------İçecekler-------------");

            //    Console.WriteLine();

            //}
            //if (menuItem =="5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");

            //    Console.WriteLine("-------------Tatlılar-------------");

            //    Console.WriteLine();

            //}




            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break ;

            //}

            

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;

            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());


            //Console.Write("Yapmak İstediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());




            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: "+ result);
            //        break;

            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Fark: "+ result);
            //        break;

            //    case '*':
            //        result=number1 * number2;
            //        Console.WriteLine("Çarpım: "+ result);
            //        break;

            //    case '/':
            //        result=number1 / number2;
            //        Console.WriteLine("Bölüm: "+ result);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı İşlem"); break;

            //}
            //Console.Read();

            #endregion

        }
    }
}
