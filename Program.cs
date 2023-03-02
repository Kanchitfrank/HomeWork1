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
            Console.Write("{0} {1} {2}",ciadigit, ciaten, ciathousands);
            if(agency == "CIA"){
               if(ciadigit % 3 == 0 
                && ciaten != 1 && ciaten != 3 && ciaten != 5 
                && ciathousands > 6 && ciathousands != 8){
                 Console.WriteLine("True");
               }else{
                Console.WriteLine("False");
               }
            }else{
                Console.WriteLine("False");
            }
        }
    }
}