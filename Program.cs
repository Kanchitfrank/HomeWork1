using System;

namespace Homework1{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Password : "); int password = int.Parse(Console.ReadLine());
            int check = 0;
            while(check < 1){
          if(password >1000000 || password < 99999){
            Console.Write("Password : "); password = int.Parse(Console.ReadLine());
          }else{check++;}
           }
            if(check==1){
              Console.Write("Agency : "); string agency = (Console.ReadLine());

            //CIA
            float ciadigit = password % 10;
            float ciatenno = password % 100; int ciaten = (int)ciatenno / 10;  
            float ciathousandsno = password % 10000; int ciathousands = (int)ciathousandsno / 1000;
            // Console.WriteLine("{0} {1} {2}",ciathousands,ciaten,ciadigit);
            
            //FBI
            int fbihundredthousands = password / 100000;
            int fbihundredno = password % 1000; int fbihundred = fbihundredno /100;
            int fbitenthousandsno = password / 10000 ; int fbitenthousands = fbitenthousandsno % 10; 
            // Console.WriteLine("{0} {1} {2}",fbihundredthousands,fbitenthousands,fbihundred);

            //NSA
            float nsadigit = password % 10; 
            float nsahundredsno = password % 1000;int nsahundreds = (int)nsahundredsno /100; 
            float nsatenno = password % 100; int nsaten = (int)nsatenno / 10;
            float nsathousandsno = password % 10000; int nsathousands = (int)nsathousandsno / 1000;
            int nsatenthousandsno = password / 10000 ; int nsatenthousands = nsatenthousandsno % 10;
            int nsahundredthousands = password / 100000;
            // Console.WriteLine("{0} {1} {2} {3} {4} {5}",nsahundredthousands,nsatenthousands,nsathousands,nsahundreds,nsaten,nsadigit);

            
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
            }if(agency == "NSA"){
                 if(30 % nsadigit  == 0 && nsahundreds % 3 == 0 && nsahundreds % 2 != 0 ){
                    if(nsahundredthousands == 7|| nsatenthousands == 7 || nsathousands == 7 
                        || nsahundreds == 7 ||nsaten == 7 || nsadigit == 7  ){
                            Console.WriteLine("True");
                        }
                    }else{
                        Console.WriteLine("False");
                    }
            }if(agency != "FBI" && agency != "CIA"&& agency != "NSA"){
                Console.WriteLine("False");
            }

         }

       }
    }
}
