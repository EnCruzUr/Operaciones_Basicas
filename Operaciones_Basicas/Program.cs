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

        }
        public static void Res()
        {

        }
        public static void Mult()
        {

        }
        public static void Div()
        {

        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
