using System;
namespace Operaciones_Basicas
{
    class Program
    {
        public static void Menu(){
            int Opcion;
            Console.WriteLine("Seleccione Operacion que desea realizar");
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
                    Console.Write("\n\nPresione una tecla para salir . . . ");
			        Console.ReadKey(true);
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
            Console.Write("\n\nPresione una tecla para salir . . . ");
            Console.ReadKey(true);
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
            Console.Write("\n\nPresione una tecla para salir . . . ");
            Console.ReadKey(true);
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
            Console.Write("\n\nPresione una tecla para salir . . . ");
            Console.ReadKey(true);
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
            Console.Write("\n\nPresione una tecla para salir . . . ");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
