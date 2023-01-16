using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace Menu_arrays
{
    class Program
    {
        static void Main(string[] args)



        {

            Console.WindowWidth = 110;
            Console.WindowHeight = 50;

            
            int[] taulaPlena = { 32, 25, 38, 25, 46, 12, 870, 128, 49, 110, 121, 25, 13, 44, 25, 66, 0, 0, 0, 0, 0, 10000, 1 };           
            int nElementsPlena = 15;          
            int copiaNelementsPlena= nElementsPlena;
            int[] copiaTaulaPlena = taulaPlena;


            int[] taulaBuida = new int[100];

            string num = Menu();
            Console.Clear();

            while (num != "20")
            {



                switch (num)
                {
                    case "1":
                        Console.Clear();
                        MostrarTaula(taulaPlena);
                        ContadorRetorn();
                        break;

                    case "2":
                        int n;
                        Console.WriteLine("Quant elements de la taula vols mostrar: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        MostrarTaulaN(taulaPlena, n);
                        ContadorRetorn();
                        break;
                    case "3":
                        Console.WriteLine();
                        taulaBuida = EmplenarTaulaBuida(taulaBuida);
                        MostrarTaula(taulaBuida);                       
                        ContadorRetorn();
                        taulaBuida = new int[30];

                        break;
                    case "4":
                        int n2;
                        Console.WriteLine();
                        Console.Write(Format("Quant elements vols omplir: "));
                        n2 = Convert.ToInt32(Console.ReadLine());
                        taulaBuida = EmplenarTaulaBuidaN(taulaBuida, n2);
                        MostrarTaulaN(taulaBuida, n2);
                        
                        taulaBuida = new int[30];
                        ContadorRetorn();
                        break;
                    case "5":
                        int n3, limitS, limitI;
                        Console.WriteLine();
                        Console.Write(Format("Quant elements vols omplir: "));
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write(Format("Limit Superior: "));
                        limitS = Convert.ToInt32(Console.ReadLine());
                        Console.Write(Format("Limit Inferior: "));
                        limitI = Convert.ToInt32(Console.ReadLine());
                        taulaBuida = EmplenarTaulaBuidaNlimit(taulaBuida, n3, limitI, limitS);
                        MostrarTaulaN(taulaBuida, n3);                      
                        taulaBuida = new int[30];
                        ContadorRetorn();

                        break;
                    case "6":
                        int nElementsTeclat=0;
                        taulaBuida = EmplenarTaulaBuidaTeclat(taulaBuida, ref nElementsTeclat);
                        MostrarTaulaN(taulaBuida, nElementsTeclat);
                        
                        taulaBuida = new int[30];
                        ContadorRetorn();
                        break;
                    case "7":

                        Console.WriteLine();
                        Console.Write(Format("Quants elements te la taula? "));
                        int nElements = Convert.ToInt32(Console.ReadLine());
                        int[] taulaBuida2 = new int[nElements+1];
                        Console.WriteLine();
                        Console.Write(Format("Nou valor: "));
                        int valorAfegir = Convert.ToInt32(Console.ReadLine());
                        Random rnd = new Random();


                        for (int i = 0; i < nElements; i++)
                        {
                            int n4 = rnd.Next(1,101);
                            taulaBuida2[i] = n4;
                        }

                       
                        AfegirNouValor(taulaBuida2, ref nElements, valorAfegir);
                        MostrarTaula(taulaBuida2);
                        ContadorRetorn();

                        break;
                    case "8":
                        Console.WriteLine();
                        Console.WriteLine(tornarString(taulaPlena,nElementsPlena));
                        ContadorRetorn();


                        break;

                    case "9":

                        Console.WriteLine("Mitjana d'una taula: ");
                        int mitjana = MitjanaTaula(taulaPlena, nElementsPlena);
                        Console.WriteLine(mitjana);
                        ContadorRetorn();



                        break;

                    case "10":

                        
                        
                        Console.WriteLine($"El valor mes gran es {valorMesGran(taulaPlena, nElementsPlena)}");
                        ContadorRetorn();



                        break;

                    case "11":

                       
                        Console.WriteLine($"El valor mes gran {valorMesGran(taulaPlena, nElementsPlena)} es troba a la posició index {posicioValorMesGran(taulaPlena, nElementsPlena)}");
                        ContadorRetorn();



                        break;

                    case "12":
                        int valor;
                        Console.WriteLine("Valor a buscar: ");
                        valor = int.Parse(Console.ReadLine());
                        if (valorBuscar(taulaPlena, nElementsPlena, valor))
                            Console.WriteLine($"Valor Trobat a la posició index {posValorBuscar(taulaPlena,nElementsPlena,valor)}");
                        else
                            Console.WriteLine("Valor no Trobat");

                        ContadorRetorn();



                        break;

                    case "13":

                        int posDonada, valor2;
                        bool trobat2 = false;
                        Console.WriteLine("A partir de quina posicio vols buscar el valor: ");
                        posDonada = int.Parse(Console.ReadLine());
                        Console.WriteLine("Quin valor vols buscar: ");
                        valor2 = int.Parse(Console.ReadLine());
                        posValorBuscarNpos(taulaPlena, nElementsPlena, valor2, posDonada, ref trobat2);
                        if (trobat2)
                        {
                            Console.WriteLine($"La posicio de {valor2} a partir de la posicio {posDonada} es {posValorBuscarNpos(taulaPlena, nElementsPlena, valor2, posDonada, ref trobat2)}");
                        }
                        else
                        Console.WriteLine($"{valor2} no trobat");
                        ContadorRetorn();



                        break;

                    case "14":

                        int posBorrar;
                        Console.WriteLine("Quina posicio vols esborrar: ");
                        posBorrar = int.Parse(Console.ReadLine());
                        MostrarTaula(taulaPlena);
                        taulaPlena = eliminarValor(taulaPlena, ref nElementsPlena, posBorrar);
                        MostrarTaulaN(taulaPlena, nElementsPlena);
                        taulaPlena = copiaTaulaPlena; // Per deixar la taula com al principi.
                        nElementsPlena = copiaNelementsPlena; // Per deixar el n Elements com al principi.


                        ContadorRetorn();




                        break;

                    case "15":

                        int valorBorrar2;
                        Console.WriteLine();
                        Console.Write(Format("Valor a borrar: "));
                        valorBorrar2 = Convert.ToInt32(Console.ReadLine());
                        borrarValorRepetit(taulaPlena, ref nElementsPlena, valorBorrar2);
                        MostrarTaulaN(taulaPlena, nElementsPlena);
                        taulaPlena = copiaTaulaPlena; // Per deixar la taula com al principi.
                        nElementsPlena = copiaNelementsPlena; // Per deixar el nElements com al principi.
                        ContadorRetorn();

                        break;

                    case "16":
                        if (ordenadaOno(taulaPlena, nElementsPlena))
                        {
                            Console.WriteLine();
                            Console.WriteLine(Format("La taula esta ordenada!"));
                            ContadorRetorn();
                        }

                        else {
                            Console.WriteLine();
                            Console.WriteLine(Format("La taula no esta ordenada!"));
                            ContadorRetorn();
                        }

                        
                            break;

                    case "17":


                    default:

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(Format("No es una opció correcte!"));
                        ContadorRetorn();
                        break;
                }

                num = Menu();
                Console.Clear();
            }

          




        }

        static string FormatMenu(string text)
        {
            text = new string(' ', 23) + text;
            return text;
        }

        static string Format(string text)
        {

            text = new string(' ', ((Console.WindowWidth - (text.Length)) / 2)) + text;
            return text;
        }

        static string Menu()
        {


            string[] menu = {
                "1. Mostra els valors de la taula.\n",
                "2. Mostra la taula fins a N elements.\n",
                "3. Omple la taula amb valors aleatoris de 0 a 100.\n",
                "4. Omple amb valors aleatoris fins a N elements.\n",
                "5. Omple amb valors aleatoris fins a N elements amb limit superior i inferior.\n",
                "6. Omple la taula per teclat.\n",
                "7. Afegeix un valor nou a la taula.\n",
                "8. Mostra la taula detallada en text.\n",
                "9. Calcula el valor mitjà de la taula.\n",
                "10. Troba el valor mes gran de la taula.\n",
                "11. Troba la posició del valor mes gran de la taula.\n",
                "12. Busca un valor dins la taula, si el troba n'indica la posició.\n",
                "13. Busca la primera posició d'un valor a partir de N.\n",
                "14. Elimina un valor en una determinada posició.\n",
                "Llista 8b: \n",
                "15(2).Elimina totes les aparicions d'un valor en una taula.\n",
                "16(3).Esta la taula ordenada.\n",
                "17. Sortir.\n"};


        Console.WriteLine(new String('*', Console.WindowWidth));

            Console.WriteLine();
            Console.WriteLine(@"
                        __  __                        _        _              _           
                       |  \/  | ___ _ __  _   _    __| | ___  | |_ __ _ _   _| | ___  ___ 
                       | |\/| |/ _ \ '_ \| | | |  / _` |/ _ \ | __/ _` | | | | |/ _ \/ __|
                       | |  | |  __/ | | | |_| | | (_| |  __/ | || (_| | |_| | |  __/\__ \
                       |_|  |_|\___|_| |_|\__,_|  \__,_|\___|  \__\__,_|\__,_|_|\___||___/
                                                                    
");
            Console.WriteLine();



            foreach (string opcio in menu)
            {




                Console.WriteLine(FormatMenu(opcio));
            }



            Console.WriteLine();
            Console.WriteLine(new String('*', Console.WindowWidth));

            Console.Write(FormatMenu("Selecciona una opció: "));

            string num = Console.ReadLine();



            return num;
        }
        static void ContadorRetorn()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Format("Presiona qualsevol tecla per continuar..."));
            Console.ReadKey();

            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Format($"Tornant al menu en {i} segons..."));
                Thread.Sleep(1000);

            }
            Console.Clear();
        }

       
        static void MostrarTaula(int[] taula)
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < taula.Length; i++)
                Console.WriteLine(Format(Convert.ToString(taula[i])));

        }

      

        static void MostrarTaulaN(int[] taula, int n)
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.WriteLine(Format(Convert.ToString(taula[i])));
            

        }

        static int[] EmplenarTaulaBuida(int[] taulaBuida)
        {
            Random rnd = new Random();


            for (int i = 0; i < taulaBuida.Length; i++)
            {
                int n = rnd.Next(1,101);
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

        static int[] EmplenarTaulaBuidaTeclat(int[] taulaBuida, ref int nElements)
        {

            Console.WriteLine();
            Console.Write(Format("Entra cada numero que vulguis afegir, acaba amb -1: "));
            int n = Convert.ToInt32(Console.ReadLine());           
            int i = 0;

            while (n != -1)
            {
                Console.Clear();
                taulaBuida[i] = n;
                Console.WriteLine();
                Console.Write(Format("Entra cada numero que vulguis afegir, acaba amb -1: "));
                n = Convert.ToInt32(Console.ReadLine());
                nElements++;
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


            for (int i = 0; i < nElements; i++)
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


            for (int i = 0; i < nElements; i++)
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


        static bool valorBuscar(int[] taulaPlena, int nElements, int valorBuscar)
        {
            
            bool trobat = false;

            for (int i = 0; i < nElements; i++)
            {

                if (valorBuscar == taulaPlena[i])
                    trobat = true;


            }

            return trobat;

            


        }

        static int posValorBuscar(int[] taulaPlena, int nElements, int valorBuscar)
        {

            int cont = 0;
            int pos = 0;

            for (int i = 0; i < nElements; i++)
            {

                if (valorBuscar == taulaPlena[i])
                    pos = cont;

                cont++;
            }

            return pos;




        }

        static int posValorBuscarNpos(int[] taulaPlena, int nElements, int valorBuscar, int posDonada, ref bool trobat)
        {

            int cont = 0;
            int pos = 0;

            for (int i = posDonada; i < nElements; i++)
            {

                if (valorBuscar == taulaPlena[i])
                {
                    pos = cont;
                    trobat = true;
                    i = nElements;
                    
                }
                cont++;
            }

            return pos;




        }

        static int[] eliminarValor(int[] taulaPlena, ref int nElements, int posBorrar)
        {


            if (posBorrar == nElements)
            {
                nElements--;
            }

            else
            {
                for (int i = posBorrar; i < nElements-1; i++)
                {
                    taulaPlena[i] = taulaPlena[i + 1];

                }
            }

            return taulaPlena;


        } 

        static string tornarString(int[] taulaPlena, int nElements)
        {

            string taulaText = "";

            for (int i=0; i<nElements;i++)
            {
                taulaText += Format($"En l'index {i} trobem el valor {taulaPlena[i]}\n\n");
                
            }

            taulaText += Format("Hem arribat a l'ultim element vàlid de la taula");

            return taulaText;
        }

        static int[] borrarValorRepetit(int[] taulaPlena, ref int nElements, int valorBorrar)
        {
            int pos = 0;
            for (int i=0; i<nElements;i++)
            {

                

                if (taulaPlena[i]==valorBorrar)
                {
                   

                   

                        for (int j = pos; j < nElements-1; j++)
                        {
                            taulaPlena[j] = taulaPlena[j + 1];
                            
                        }

                    nElements--;
                }

                pos++;

                

            }



            return taulaPlena;
        }

        static bool ordenadaOno (int[] taulaPlena,  int nElements)
        {

            bool ordenada = true;

            for(int i=0; i<nElements-1 && ordenada==true; i++)
            {

                if (taulaPlena[i] > taulaPlena[i + 1])
                    ordenada = false;

            }

            return ordenada;



        }

    }
}

