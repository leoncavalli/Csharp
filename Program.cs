using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Some variables

            // float kilo=70.5f;    
            // string plaka="34PR1177";
            // double km=125425.8;
            // int musteriId=1;
            // bool satistami=true;
            // float maas=2135.80f;
            // string adsoyad="Bünyamin Gültekin";
            // char sube='a';
            

            //App-Type transformation

            // int shortSide;
            // int longSide;

            // Console.WriteLine("Please enter the 1. length");
            // int len1=int.Parse(Console.ReadLine());
            // int len2=int.Parse(Console.ReadLine());

            // if(len1>len2){
            //     shortSide=len2;
            //     longSide=len1;
            // }
            // else{
            //     shortSide=len1;
            //     longSide=len2;
            // }

            // var area=longSide*shortSide;
            // Console.WriteLine($"The area is :{area}");


            //String Methods

            string msg="Hi i am Bunyamin.";
            Console.WriteLine(msg.ToUpper());
            Console.WriteLine(msg.Length);
            Console.WriteLine(msg.Substring(5,7));
            Console.WriteLine(msg.EndsWith("in."));
            Console.WriteLine(msg.Trim());
            Console.WriteLine(msg.Contains("am"));

        }
    }
}
