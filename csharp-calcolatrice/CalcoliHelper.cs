using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        public static int SommaNumeri(int num1, int num2)
        {
            int somma =  num1 + num2;
            return somma;
        }
        public static double SommaNumeri(double num1, double num2)
        {
            double somma = num1 + num2;
            return somma;
        }
        public static int DifferenzaNumeri(int num1, int num2)
        {
            int differenza = num1 - num2;
            return differenza;
        }
        public static double DifferenzaNumeri(double num1, double num2)
        {
            double differenza = num1 - num2;
            return differenza;
        }
        public static int MoltiplicazioneNumeri(int num1, int num2)
        {
            int moltiplicazione = num1 * num2;
            return moltiplicazione;
        }
        public static double MoltiplicazioneNumeri(double num1, double num2)
        {
            double moltiplicazione = num1 * num2;
            return moltiplicazione;
        }
        public static int ValAssoluto(int num)
        {
          
            if(num < 0)
            {
               string numStringa = num.ToString();
              string stringa = numStringa.Remove(0, 1);
                
               return Int32.Parse(stringa);
            }
            else
             return num;
            
        }
        public static double ValAssoluto(double num)
        {
            if (num < 0)
            {
                double nuovoNum = num * -1;
      
                return nuovoNum;
            }
            else
                return num;
        }
        public static int MinNum(int num1,int num2)
        {
            if (num1 < num2)

                return num1;

            else 
                return num2;
           
           
           
        }
        public static double MinNum(double num1,double num2)
        {
            if (num1 < num2)

                return num1;

            else
                return num2;
        }
        public static int MaxNum(int num1, int num2)
        {
            if (num1 > num2)

                return num1;

            else
                return num2;
        }
        public static double MaxNUm(double num1, double num2)
        {
            if (num1 > num2)

                return num1;

            else
                return num2;
        }
        //overloading
        public static double ElevamentoPotenza(int num1,int num2)

        {
            if (num1 == 0)
                num1 = 1;

            else if (num2 == 0)
                num2 = 1;
            double elevamento = 1;
            double numBase = (double)num1;
            if(num2 < 0)
            {
                numBase =1.0/numBase;
                //num2 = num2 * -1;
                for (int i = 0; i < ValAssoluto(num2); i++)
                {
                    elevamento *= numBase;
                }
            }
            else
            {
              for(int i = 0; i < ValAssoluto(num2); i++)
               {
                 elevamento *=  numBase ;
               }
            }
           
           
            
            return elevamento;
        }
       
    }
}
