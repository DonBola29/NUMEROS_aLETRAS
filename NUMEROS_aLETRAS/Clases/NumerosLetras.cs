using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    class NumerosLetras
    {
        static String[] Unidades = { "cero" , "uno" , "dos" ,  "tres" , "cuatro"
                , "cinco" , "seis" , "siete" , "ocho" , "nueve" , "diez" , "once" 
        , "doce" , "trece" , "catorce" , "quince" , "dieciseis" , "diecisiete" , "dieciocho" , "diecinueve"};

       static String[] Decenas = {"cero" , "diez" , "veinte" , "treinta" , "cuarenta"
                , "cincuenta", "sesenta" , "setenta" , "ochenta" , "noventa" };

       static String[] Centenas = { "cero" , "cien" , "doscientos" , "trescientos" , "cuatrocientos" , "quinientos", "seiscientos" , "setecientos"
                , "ochocientos" , "novecientos" };
        
        public static void TestUnidades()
        {
            //recorre todo el array de string
            foreach (String cad in Unidades)
            {
                Console.WriteLine(cad);
            }
            Console.ReadKey();
        }
    

    /// <summary>
    /// Devuelve el equivalente en letras para las unidades
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static String getUnidades(int num)
       {
        string aux = "";
        if (num >= 0 && num < 20)
            aux = Unidades[num];
        return aux;

       }

        public static String getDecenas(int num)
        {
            string aux = "";
            if (num >= 0 && num < 20)
                aux = Unidades[num]; 
            else if (num >= 20 && num < 100)
            {
                int residuo = num % 10;
                aux = Decenas[num/10];
                if (residuo > 0)
                    aux += " y " + Unidades[residuo];
            }

            return aux;
        }

        public static string getCentenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 100)
                aux = getDecenas(num);
           
            else if (num == 100)
                aux = "cien";
            
            else if (num > 100 && num < 200) {
                int residuo = num % 100;
                if (residuo > 0)
                {
                    aux += "ciento " + getDecenas(residuo);
                }

            }
            else if (num >= 200 && num < 1000)
            {
                int residuo = num % 100;
                aux = Centenas[num / 100];
                if (residuo > 0) 
                    aux += " " + getDecenas(residuo);
               
            }
            return aux;
        }
        public static string getmiles(int num)
        {
            String aux = "";
            if (num < 1000)
                aux = getCentenas(num);
            else if (num == 1000)
                aux = "mil";
            else if (num >= 1001 && num < 1000000)
            {
                int n1 = num / 1000, n2 = num % 1000;
                aux = getCentenas(n1) + " mil ";
                if (n2 > 0) aux = getCentenas(n1) + " mil " + getCentenas(n2);
            }
            return aux;
        }
        public static string getMillar(int num)
        {
            int n1 = num / 1000000, n2 = num % 1000000, n3 = n2 % 1000;
            String aux = "";
            if (num < 1000000)
                aux = getmiles(num);
            else if (num >= 1000000 && num < 2000000)
            {
                aux = "un millon ";
                if (n2 > 0) aux = "un millon " + getmiles(n2);
            }
            else if (num >= 2000000 && num < 1000000000)
            {
                aux = getmiles(n1) + " millones ";
                if (n2 > 0) aux = getmiles(n1) + " millones " + getmiles(n2);
            }
            return aux;
        }
    }
}


