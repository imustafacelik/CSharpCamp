using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-Listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}


            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();



            #endregion


            #region Geriye Değer Döndürmeyen string Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mustafa ÇELİK");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: "+name +" "+ surname);
            //}

            //CustomerCard("Mustafa","Çelik");
            //CustomerCard("Murat","Yucedağ");

            #endregion


            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Mustafa ÇELİK";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Mustafa";
            //    string surname = "ÇELİK";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo="Ülke: "+countryName+" -  Başkent: "+capital+" - Bayrak Rengi: "+flagColor;

            //    return cardInfo;
            //}

            //string x,y,z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkent Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));


            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));


            #endregion


            #region Geriye Değer Döndüren int Parametreli Metotlar


            //int sum(int number1,int number2)
            //{
            //    int result=number1 + number2;

            //    return result;
            //}

            //Console.WriteLine(sum(45,98));
            //Console.WriteLine(sum(36,25));
            //Console.WriteLine(sum(44,36));
            //Console.WriteLine(sum(14,20));


            #endregion


            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1+exam2+exam3)/3;

            //    if (result>=50)
            //    {
            //        return student+" isimli Öğrenci Sınavı Geçti "+"Ortalama: "+result;
            //    }
            //    else
            //    {
            //        return student+" isimli Öğrenci Başarısız Oldu "+"Ortalama: "+result;

            //    }

              

            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Mustafa", 25, 41, 85));

            #endregion

            Console.Read();
        }
    }
}
