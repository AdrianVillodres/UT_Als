using System;

namespace CodeWithIssues
{
    static class Program
    {
        //Afegit "public" al Main
        public static void Main(string[] args)
        {
            //Fer els textos contants i eliminar el negatiu ja que no passarà mai
            const string Welcome = "Benvingut al programa de càlculs!";
            const string Zero = "El resultat és zero.";
            const string PositiveResult = "El resultat és positiu.";
            const string EndProg = "Finalitzant el programa...";
            // Escriure totes les variables en una sola linea i elimar la que no s'utilitzaba 
            int numOne = 5, numTwo = 10, numThree = 15, result;

            Console.WriteLine(Welcome);
            result = SumByMoreOfZero(numOne, numTwo, numThree);
            Console.WriteLine(result == 0 ? Zero : PositiveResult);

            int counter = 0;
            while (true)
            {
                counter++;
                if (counter > 100)
                {
                    break;
                }
            }
            //Treiem la variable x degut a que no s'utilitza

            Console.WriteLine(EndProg);
        }
        public static int SumByMoreOfZero(int numOne, int numTwo, int numThree)
        {
            if (numOne > 0)
            {
                if (numTwo > 0)
                    return numThree > 0 ? numOne + numTwo + numThree : numOne + numTwo;
                else
                    return numOne;
            }
            else
                return 0;
        }
    }
}
