using System;
namespace OperatorsLogical 
{
   class Program 
   {
      static void Main(string[] args) 
      {
         bool a = true; 
         bool b = true;
         
         if (a && b)
         {
            Console.WriteLine("1.koşul doğrudur."); //Mantıksal VE operatörü olarak adlandırılır.
			//Her iki işlenen sıfırdan farklıysa koşul koşulur.
         }
         
        else if (a || b)
         {
            Console.WriteLine("2.koşul doğrudur."); //Mantıksal VEYA Operatör olarak adlandırılır.
			//İki işlenenden herhangi biri sıfırdan farklıysa, durum geçerlidir.
         }
         
      }
   }
}
