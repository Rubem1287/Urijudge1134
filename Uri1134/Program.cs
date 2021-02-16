using System;

namespace Uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            a = int.Parse(Console.ReadLine());
            
            while(a!=4)
            {
                if(a==1)
                {
                    alcool += +1;
                }

                if (a == 2)
                {
                    gasolina += +1;
                }

                if (a == 3)
                {
                    diesel += +1;
                }


                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine();
            Console.WriteLine("Álcool : " + alcool);
            Console.WriteLine();
            Console.WriteLine("Gasolina : " + gasolina);
            Console.WriteLine();
            Console.WriteLine("Diesel : " + diesel);


        }
    }
}
