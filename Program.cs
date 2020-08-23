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

            // string msg="Hi i am Bunyamin.";
            // Console.WriteLine(msg.ToUpper());
            // Console.WriteLine(msg.Length);
            // Console.WriteLine(msg.Substring(5,7));
            // Console.WriteLine(msg.EndsWith("in."));
            // Console.WriteLine(msg.Trim());
            // Console.WriteLine(msg.Contains("am"));
            


            //Arrays

            // string message="My name is Jose Ernesto Sosa.";
            // var msgarray=message.Split();
            // Console.WriteLine(msgarray[0]);

            // string[] players={"Sosa","Thiam","Hakan","Caner"};
            // Console.WriteLine(players[1]);

            // int[] array=new int[4];
            // array[0]=5;
            // array[1]=5;
            // array[2]=5;
            // array[3]=5;
            // Console.WriteLine(array.Length);



            //Array Methods

            string[] players={"Sosa","Thiam","Hakan","Caner"};
            var index=Array.IndexOf(players,"Caner");
            players.SetValue("Gökhan",index);
            Console.WriteLine(players[3]);
            Array.Sort(players);
            Console.WriteLine(players.GetValue(2));

            Array.Clear(players,1,1);
            Console.WriteLine(players.GetValue(0));            
            
            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
            string msg="Hello World!";
            Console.WriteLine(msg[0..3]);
        }
    }
}
