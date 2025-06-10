using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Array
    {
        //static void Main()
        //{
        //    JFunt();
        //    int[] Even = new int[3];
        //    Even[0] = 1;
        //    Even[1] = 2;
        //    Even[2] = 3;
        //    Console.WriteLine(Even);
        //}
        public static void JFunt()
        {
            string[] emp = new string[3];
            emp[0] = "Mark";
            emp[1] = "Maida";
            emp[2] = "Brenna";
            //jaggedArray
            string[][] jArrar = new string[3][];

            jArrar[0] = new string[3];
            jArrar[1] = new string[1];
            jArrar[2] = new string[2];

            jArrar[0][0] = "Suhail";
            jArrar[0][1] = "Salam";
            jArrar[0][2] = "Sha";

            jArrar[1][0] = "sss";


            jArrar[2][0] = "ffff";
            jArrar[2][1] = "lllll";

            for (int i = 0; i < jArrar.Length; i++)
            {
                Console.WriteLine(emp[i]);
                Console.WriteLine("===============");
                string[] innerArray = jArrar[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);   
                }
                Console.WriteLine();
            }

        }

    }
}
