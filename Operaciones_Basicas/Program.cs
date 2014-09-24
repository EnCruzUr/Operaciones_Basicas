using System;
namespace Operaciones_Basicas
{
    class Program
    {
        public static void Menu(){
            int Opcion;
            Console.WriteLine("\n\nSeleccione Operacion que desea realizar");
            Console.WriteLine("1)Suma");
            Console.WriteLine("2)Resta");
            Console.WriteLine("3)Multiplicacion");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Salir");
            Opcion=int.Parse(Console.ReadLine());
            switch(Opcion){
                case 1:
                    Suma();
                    break;
                case 2:
                    Res();
                    break;
                case 3:
                    Mult();
                    break;
                case 4:
                    Div();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }

        }
        public static void Suma()
        {
            int NumSum1, NumSum2, ResSum;
            Console.Write("\n\nIngresa Primer Valor: ");
            NumSum1=int.Parse(Console.ReadLine());
            Console.Write("Ingresa Segundo Valor: ");
            NumSum2 = int.Parse(Console.ReadLine());
            ResSum = NumSum1 + NumSum2;
            Console.Write("El Resultado de la Suma es: "+ResSum);
            Menu2();
        }
        public static void Res()
        {
            int NumRes1, NumRes2, ResRes;
            Console.Write("\n\nIngresa Primer Valor: ");
            NumRes1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa Segundo Valor: ");
            NumRes2 = int.Parse(Console.ReadLine());
            ResRes = NumRes1 - NumRes2;
            Console.Write("El Resultado de la Resta es: " + ResRes);
            Menu2();
        }
        public static void Mult()
        {
            int NumMult1, NumMult2, ResMult;
            Console.Write("\n\nIngresa Valor: ");
            NumMult1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa Valor a multiplicar: ");
            NumMult2 = int.Parse(Console.ReadLine());
            ResMult = NumMult1 * NumMult2;
            Console.Write("El Resultado de la Multiplicacion es: " + ResMult);
            Menu2();
        }
        public static void Div()
        {
            int NumDiv1, NumDiv2;
            double ResDiv;
            Console.Write("\n\nIngresa Divisor: ");
            NumDiv1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa Dividendo: ");
            NumDiv2 = int.Parse(Console.ReadLine());
            ResDiv = NumDiv1 / NumDiv2;
            Console.Write("El Resultado de la Division es: " + ResDiv);
            Menu2();
        }
        public static void Menu2()
        {
            int Respuesta;
            Console.Write("\n\n\n1)Regresar al Menu\n2)Salir\n");
            Respuesta = int.Parse(Console.ReadLine());
            switch (Respuesta)
            {
                case 1:
                    Menu();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
