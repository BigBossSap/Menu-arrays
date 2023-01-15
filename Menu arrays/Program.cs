using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Menu_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulaPlena = { 32, 25, 38, 25, 46, 12, 87, 128, 49, 110, 121, 12, 13, 44, 85, 0, 0, 0, 0, 0, 0, 10000, 1 };
            int nElementsPlena = 15;
            Console.WriteLine(nElementsPlena);
            int[] taulaBuida = new int[100];

            string num = Menu();
            Console.Clear();

            while (num != "14")
            {



                switch (num)
                {
                    case "1":

                        MostrarTaula(taulaPlena);
                        break;

                    case "2":
                        int n;
                        Console.WriteLine("Quant elements de la taula vols mostrar: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        MostrarTaulaN(taulaPlena, n);
                        break;
                    case "3":

                        taulaBuida = EmplenarTaulaBuida(taulaBuida);
                        MostrarTaula(taulaBuida);
                        Thread.Sleep(3000);
                        taulaBuida = new int[30];

                        break;
                    case "4":
                        int n2;
                        Console.WriteLine("Quant elements vols omplir: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        taulaBuida = EmplenarTaulaBuidaN(taulaBuida, n2);
                        MostrarTaula(taulaBuida);
                        Thread.Sleep(3000);
                        taulaBuida = new int[30];
                        break;
                    case "5":
                        int n3, limitS, limitI;
                        Console.WriteLine("Quant elements vols omplir: ");
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Limit Superior: ");
                        limitS = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Limit Inferior: ");
                        limitI = Convert.ToInt32(Console.ReadLine());
                        taulaBuida = EmplenarTaulaBuidaNlimit(taulaBuida, n3, limitI, limitS);
                        MostrarTaula(taulaBuida);
                        Thread.Sleep(3000);
                        taulaBuida = new int[30];

                        break;
                    case "6":

                        taulaBuida = EmplenarTaulaBuidaTeclat(taulaBuida);
                        MostrarTaula(taulaBuida);
                        Thread.Sleep(3000);
                        taulaBuida = new int[30];

                        break;
                    case "7":

                        Console.WriteLine("Quants elements te la taula? ");
                        int nElements = Convert.ToInt32(Console.ReadLine());
                        int[] taulaBuida2 = new int[nElements + 1];
                        Console.WriteLine("Nou valor: ");
                        int valorAfegir = Convert.ToInt32(Console.ReadLine());
                        Random rnd = new Random();


                        for (int i = 0; i < nElements; i++)
                        {
                            int n4 = rnd.Next(101);
                            taulaBuida2[i] = n4;
                        }

                        MostrarTaula(taulaBuida2);
                        Thread.Sleep(2000);
                        AfegirNouValor(taulaBuida2, ref nElements, valorAfegir);
                        MostrarTaula(taulaBuida2);
                        Thread.Sleep(2000);

                        break;
                    case "8":



                        break;

                    case "9":

                        Console.WriteLine("Mitjana d'una taula: ");
                        int mitjana = MitjanaTaula(taulaPlena, nElementsPlena);
                        Console.WriteLine(mitjana);
                        Thread.Sleep(2000);



                        break;

                    case "10":

                        Console.WriteLine("Valor mes gran: ");
                        int valorGran = valorMesGran(taulaPlena, nElementsPlena);
                        Console.WriteLine(valorGran);
                        Thread.Sleep(2000);



                        break;

                    case "11":

                        Console.WriteLine("Posicio valor mes gran: ");
                        int posValorGran = posicioValorMesGran(taulaPlena, nElementsPlena);
                        Console.WriteLine(posValorGran);
                        Thread.Sleep(2000);



                        break;

                    default:

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("No es un numero correcte!");
                        break;
                }

                num = Menu();

            }

            if (num == "9")
                Console.WriteLine("num Incorrecte");




        }

        static string Menu()
        {


            string[] menu = {
                "1. Troba el Màxim de dos nombres.\n",
                "2. Troba el Maxim Comu Divisor de dos nombres.\n",
                "3. Troba el Minim Comú Múltiple de dos nombres.\n",
                "4. Calcula el Factorial d'un nombre.\n",
                "5. Calcula la Combinatoria de dos nombres.\n",
                "6. Calcula el Major Divisor d'un nombre.\n",
                "7. Indica si el nombre es Primer.\n",
                "8. Mostra els N nombres Primers.\n",
                "9. Sortir.\n"};


            Console.WriteLine(new String('*', Console.WindowWidth));

            Console.WriteLine();
            Console.WriteLine(@"
                                              _                       _   _      
        /\/\   ___ _ __  _ //_    /\/\   __ _| |_ ___ _ __ ___   _\\_| |_(_) ___ 
       /    \ / _ \ '_ \| | | |  /    \ / _` | __/ _ \ '_ ` _ \ / _` | __| |/ __|
      / /\/\ \  __/ | | | |_| | / /\/\ \ (_| | ||  __/ | | | | | (_| | |_| | (__ 
      \/    \/\___|_| |_|\__,_| \/    \/\__,_|\__\___|_| |_| |_|\__,_|\__|_|\___|
                                                                             
");
            Console.WriteLine();



            foreach (string opcio in menu)
            {




                Console.WriteLine(opcio);
            }



            Console.WriteLine();
            Console.WriteLine(new String('*', Console.WindowWidth));

            Console.Write("Selecciona una opció: ");

            string num = Console.ReadLine();



            return num;
        }
        static void ContadorRetorn()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presiona qualsevol tecla per continuar...");
            Console.ReadKey();

            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Tornant al menu en {i} segons...");
                Thread.Sleep(1000);

            }
            Console.Clear();
        }

        static void MostrarTaula(int[] taula)
        {
            Console.Clear();
            for (int i = 0; i < taula.Length; i++)
                Console.WriteLine(taula[i]);
            Thread.Sleep(3000);

        }

        static void MostrarTaulaN(int[] taula, int n)
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
                Console.WriteLine(taula[i]);
            Thread.Sleep(3000);

        }

        static int[] EmplenarTaulaBuida(int[] taulaBuida)
        {
            Random rnd = new Random();


            for (int i = 0; i < taulaBuida.Length; i++)
            {
                int n = rnd.Next(101);
                taulaBuida[i] = n;
            }

            return taulaBuida;

        }

        static int[] EmplenarTaulaBuidaN(int[] taulaBuida, int n2)
        {
            Random rnd = new Random();


            for (int i = 0; i < n2; i++)
            {
                int n = rnd.Next(101);
                taulaBuida[i] = n;
            }

            return taulaBuida;

        }

        static int[] EmplenarTaulaBuidaNlimit(int[] taulaBuida, int n2, int limitInf, int limitSup)
        {
            Random rnd = new Random();


            for (int i = 0; i < n2; i++)
            {
                int n = rnd.Next(limitInf, limitSup + 1);
                taulaBuida[i] = n;
            }

            return taulaBuida;




        }

        static int[] EmplenarTaulaBuidaTeclat(int[] taulaBuida)
        {


            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (n != -1)
            {
                Console.Clear();
                taulaBuida[i] = n;
                Console.WriteLine("Entra cada numero que vulguis afegir, acaba amb -1: ");
                n = Convert.ToInt32(Console.ReadLine());
                i++;
            }


            return taulaBuida;


        }

        static int[] AfegirNouValor(int[] taulaBuida, ref int nElements, int valorNou)
        {


            taulaBuida[nElements] = valorNou;
            nElements++;


            return taulaBuida;


        }

        static int MitjanaTaula(int[] taulaPlena, int nElements)
        {

            int suma = 0;
            for (int i = 0; i < nElements; i++)
            {
                suma += taulaPlena[i];


            }

            return suma / nElements;


        }

        static int valorMesGran(int[] taulaPlena, int nElements)
        {
            int valorGran = int.MinValue;


            for (int i = 0; i < nElements - 1; i++)
            {

                if (taulaPlena[i] > valorGran)

                    valorGran = taulaPlena[i];


            }

            return valorGran;


        }

        static int posicioValorMesGran(int[] taulaPlena, int nElements)
        {
            int valorGran = int.MinValue;
            int cont = 0, pos = 0;


            for (int i = 0; i < nElements - 1; i++)
            {

                if (taulaPlena[i] > valorGran)
                {

                    valorGran = taulaPlena[i];

                    pos = cont;


                    

                }

                cont++;


            }
            return pos;

        }
    }

}

