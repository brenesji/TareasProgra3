using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasPrograTres
{
    class Program
    {
        public static void TareaDos()
        {
            List<String> list = new List<String>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");

            Console.WriteLine("La lista es: ");
            for (int i = 0; i < list.Count; i++)
            {

                Console.Write(list[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("La lista invertida es: ");
            for (int i = list.Count - 1; i >= 0; i--)
            {

                Console.Write(list[i]);
            }


            Console.ReadKey();
        }

        public static void TareaQuince()
        {
            int[] myArray = new int[100];

            Console.Write("El arreglo digitado es: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + 1 + i);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            myArray[4] = 4;
            myArray[3] = 4;
            myArray[80] = 4;


            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 4)
                    Console.WriteLine("El número " + myArray[i] + " está repetido en " + i);

            }


            //Console.Write("El arreglo digitado es: ");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write(myArray[i]);
            //}


            Console.ReadKey();


            //Console.WriteLine(i + " = " + myArray[i]); Para digitar indice + va;or

        }

        public static void TareaDiecisiete()
        {
            string S = "Jaaairo";
            Dictionary<char, int> contador = new Dictionary<char, int>(); // declare un diccionario, (Clave, Valor) el cual almacenara los caracteres
            Console.WriteLine("El string existente es:  " + S);
            Console.WriteLine("");
            Console.WriteLine("CAntidad de Caracteres: ");

            foreach (char caracter in S)
            {
                // pregunta si contiene el caracter 
                if (contador.ContainsKey(caracter))
                    // si está el valor, le suma 1 
                    contador[caracter]++;
                else
                    // sino cuando el caracter no está, lo agrega al diccionario 
                    // el diccionario solo agregará caracteres no repetidos 
                    contador.Add(caracter, 1);
            }

            foreach (KeyValuePair<char, int> item in contador)
            {
                Console.WriteLine(string.Format("{0} = {1}", item.Key, item.Value));
            }

            Console.ReadKey();
        }

        


        static void Main(string[] args)
        {

            //TareaDos();
            //TareaDiecisiete();
            TareaQuince();
        }
    }
}
