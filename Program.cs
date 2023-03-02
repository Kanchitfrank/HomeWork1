using System;

namespace Homework1{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Password : "); int password = int.Parse(Console.ReadLine());
            Console.Write("Agency : "); string agency = (Console.ReadLine());

            float ciadigit = password % 10;
            float ciatenno = password % 100; int ciaten = (int)ciatenno / 10;  
            float ciathousandsno = password % 10000; int ciathousands = (int)ciathousandsno / 1000;
            // Console.WriteLine("{0} {1} {2}",ciadigit, ciaten, ciathousands);

            int fbihundredthousands = password / 100000;
            int fbihundredno = password % 1000; int fbihundred = fbihundredno /100;
            int fbitenthousandsno = password / 10000 ; int fbitenthousands = fbitenthousandsno % 10; 
            Console.WriteLine("{0} {1} {2}",fbihundred, fbitenthousands, fbihundredthousands);
            
            if(agency == "CIA"){
               if(ciadigit % 3 == 0 
                && ciaten != 1 && ciaten != 3 && ciaten != 5 
                && ciathousands > 6 && ciathousands != 8){
                 Console.WriteLine("True");
               }else{
                Console.WriteLine("False");
               }
            }if(agency == "FBI"){
               if(fbihundredthousands>=4 && fbihundredthousands <=7 
                && fbihundred != 6  && fbihundred % 2 == 0
                && fbitenthousands % 2 !=0){
                    Console.WriteLine("True");
                }else{
                    Console.WriteLine("False");
                }
                     }
            }
        }
    }
