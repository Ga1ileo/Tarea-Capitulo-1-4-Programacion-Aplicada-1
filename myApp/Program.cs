using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //declaracion de variables generales
            int casos;
            int cap1;
            int cap2;
            int cap3;
            int cap4;
            string entrada = "";

           //declaracion de variables capitulo 2
           //ejercicio 2.1
            float numeroDeLados = 0.0f;
            float longitudLado = 0.0f;
            float perimetro = 0.0f;
            //ejercicio 2.3
            double grados = 0.0f;
            double radianes = 0.0f;
            string valor = "";
            //ejercicio 2.5
            double dolares;
            double euros;
            double tazaDolar;
            double tazaEuro;
            int cualCambiar;
            double totalEuros;
            double totalDolares; 
           //declaracion de variables capitulo 3
           //ejercicio 3.1
           double num;
           //ejercicio 3.2
           double numeroSemana;
           //ejercicio 3.3
           int queCalcular;
           //declaracion de variables capitulo 4
           

            Console.WriteLine("Tarea, capitulos 1-4, libro asignado en aplicada 1");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            

            do
            {
                Console.WriteLine("Navegar por las tareas");
                Console.WriteLine("1- Capitulo 1");
                Console.WriteLine("2- Capitulo 2");
                Console.WriteLine("3- Capitulo 3");
                Console.WriteLine("4- Capitulo 4");
                Console.WriteLine("0- Salir");
               Console.Write("Eliga una opcion -> ");
               entrada = Console.ReadLine();
               casos = Convert.ToInt32(entrada);
               System.Console.Clear();
               switch (casos)
               {
                   //CAPITULO 1
                   case 1:
                       Console.WriteLine("1- Cree un proyecto nuevo que imprima su nombre en la ventana de la consola.");
                       Console.WriteLine("2- Agregue más mensajes a la aplicación que ha creado.");
                       Console.Write("Elija una opcion ->");
                       entrada = Console.ReadLine();
                       cap1 = Convert.ToInt32(entrada);
                       switch(cap1){
                           case 1:
                                System.Console.Clear();
                                Console.WriteLine("Hola Mundo");
                                Console.WriteLine("El ejercicio 5 es agregarle mas mensajes al 1");
                                Console.WriteLine("aprendiendo C Sharp");
                                Console.WriteLine("Familiarizandome con la ide");
                                Console.WriteLine(" ");
                           break;
                           case 2:
                                System.Console.Clear();
                                Console.WriteLine("El ejercicio 5 es agregarle mas mensajes al 1");
                                Console.WriteLine("aprendiendo C Sharp");
                                Console.WriteLine("Familiarizandome con la ide");
                                Console.WriteLine(" ");
                           break;
                           default:
                                System.Console.Clear();
                           break;
                       }
                       break;
                   //CAPITULO 2
                   case 2:
                       Console.WriteLine("1- Hacer un programa que calcule el perímetro de cualquier polígono regular.");
                       Console.WriteLine("2- Hacer un programa que transforme de grados a radianes.");
                       Console.WriteLine("3- Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.");
                       Console.Write("Elija una opcion ->");
                       entrada = Console.ReadLine();
                       cap2 = Convert.ToInt32(entrada);
                       switch(cap2){
                           case 1:
                           System.Console.Clear();
                           Console.WriteLine("En este programa se puede saber el perimetro de cualquier poligono regular");
                            Console.Write("Escribir el numero de lados ->");

                            entrada = Console.ReadLine();
                            numeroDeLados = Convert.ToSingle(entrada);

                            Console.Write("Escribir la longitud del lado ->");

                            entrada = Console.ReadLine();
                            longitudLado = Convert.ToSingle(entrada);

                            perimetro = (numeroDeLados * longitudLado);

                            Console.WriteLine("Perimero --> {0}", perimetro);
                           break;
                           case 2:
                           System.Console.Clear();
                           Console.WriteLine("GRADOS -- RADIANES");
                            Console.Write("Escribir la cantidad de grados -> ");

                            valor = Console.ReadLine();
                            grados = Convert.ToSingle(valor);

                            radianes = (3.14 / 180) * grados;

                            Console.WriteLine("Radianes --> {0}", radianes);
                           break;
                           case 3:
                           System.Console.Clear();
                            Console.WriteLine("EUROS -- DOLARES");
                            Console.WriteLine("1- Euro a Dolares");
                            Console.WriteLine("2- Dolares a Euros");
                            entrada = Console.ReadLine();
                            cualCambiar = Convert.ToInt32(entrada);
                            switch(cualCambiar){
                                case 1:
                                System.Console.Clear();
                                Console.Write("Taza del euro");
                                entrada = Console.ReadLine();
                                tazaEuro = Convert.ToDouble(entrada);
                                Console.Write("Cantidad de euros a cambiar");
                                entrada = Console.ReadLine();
                                euros = Convert.ToDouble(entrada);
                                totalEuros = tazaEuro * euros;
                                Console.WriteLine("Total -> {0}",totalEuros);
                                break;
                                case 2:
                                System.Console.Clear();
                                Console.Write("Taza del Dolar");
                                entrada = Console.ReadLine();
                                tazaDolar = Convert.ToDouble(entrada);
                                Console.Write("Cantidad de dolares a cambiar");
                                entrada = Console.ReadLine();
                                dolares = Convert.ToDouble(entrada);
                                totalDolares = tazaDolar * dolares;
                                Console.WriteLine("Total -> {0}",totalDolares);
                                break;
                                default:
                                System.Console.Clear();

                                break;

                            }

                           break;
                           default:
                            System.Console.Clear();
                           break;
                       }
                       break;
                   //CAPITULO 3
                   case 3:
                       Console.WriteLine("1- Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.");
                       Console.WriteLine("2- Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.");
                       Console.WriteLine("3- Hacer una programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular.");
                       Console.Write("Elija una opcion ->");
                       entrada = Console.ReadLine();
                       cap3 = Convert.ToInt32(entrada);
                       switch(cap3){
                           case 1:
                           System.Console.Clear();
                           Console.Write("Escriba un numero ->");
                           entrada = Console.ReadLine();
                           num = Convert.ToDouble(entrada);
                           if(num % 2 == 0){
                               Console.WriteLine("Par");
                           }else{
                               Console.WriteLine("Impar");
                           }

                           break;
                           case 2:
                           System.Console.Clear();
                           Console.Write("Escribe un numero 1-7 -> "); 
                           entrada = Console.ReadLine();
                           numeroSemana = Convert.ToDouble(entrada);
                           if(numeroSemana == 1){
                               Console.WriteLine("Lunes");
                           }
                           if(numeroSemana == 2){
                               Console.WriteLine("Martes");
                           }
                           if(numeroSemana == 3){
                               Console.WriteLine("Miercoles");
                           }
                           if(numeroSemana == 4){
                               Console.WriteLine("Jueves");
                           }
                           if(numeroSemana == 5){
                               Console.WriteLine("Viernes");
                           }
                           if(numeroSemana == 6){
                               Console.WriteLine("sabado");
                           }
                           if(numeroSemana == 7){
                               Console.WriteLine("Domingo");
                           }
                           
                           break;
                           case 3:
                           System.Console.Clear();
                           Console.WriteLine("1- Calcular area");
                           Console.WriteLine("2- Calcular Perimetro");
                           entrada = Console.ReadLine();
                           queCalcular = Convert.ToInt32(entrada);
                           switch(queCalcular){
                               case 1:
                               System.Console.Clear();
                               double epotema;
                               double area;
                               entrada = Console.ReadLine();
                               epotema = Convert.ToDouble(entrada);
                                area = 1.5 * epotema * perimetro;
                                Console.WriteLine("Area -> {0}",area);
                               break;
                               case 2:
                               System.Console.Clear();
                               Console.WriteLine("En este programa se puede saber el perimetro de cualquier poligono regular");
                                Console.Write("Escribir el numero de lados ->");

                                entrada = Console.ReadLine();
                                numeroDeLados = Convert.ToSingle(entrada);

                                Console.Write("Escribir la longitud del lado ->");

                                entrada = Console.ReadLine();
                                longitudLado = Convert.ToSingle(entrada);

                                perimetro = (numeroDeLados * longitudLado);

                                Console.WriteLine("Perimero --> {0}", perimetro);
                               break;
                               default:
                               System.Console.Clear();
                               break;
                           }
                           break;
                           default:
                            System.Console.Clear(); 
                           break;
                       } 
                       break;
                   //CAPITULO 4    
                   case 4:
                       Console.WriteLine("1- Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.r.");
                       Console.WriteLine("2- Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.");
                       Console.WriteLine("3- Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cual es la mas grande y cual es la mas joven");
                       Console.Write("Elija una opcion ->");
                       entrada = Console.ReadLine();
                       cap4 = Convert.ToInt32(entrada);
                       switch(cap4){
                           case 1:
                           System.Console.Clear();
                           for (int i = 1; i <= 10; i++)
                            {
                                Console.WriteLine("\nTabla de multiplicar del {0}", i);
                                Console.WriteLine("------------------------------");
                                for (int j = 1; j <= 10; j++)
                                {
                                    Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
                                }
                            }
                           break;
                           case 2:
                           System.Console.Clear();
                           double n, p, res;
                           Console.Write("Numero ->");
                            entrada = Console.ReadLine();
                            n = Convert.ToDouble(entrada);
                            Console.Write("Potencia ->");
                            entrada = Console.ReadLine();
                            p = Convert.ToDouble(entrada);
                            res= n * p;
                            Console.WriteLine("Potencia -> {0}",res);
                           break;
                           case 3:
                           System.Console.Clear();
                           int edad;
                           Console.WriteLine("Ingresar edad ->");
                           entrada = Console.ReadLine();
                           edad = Convert.ToInt32(entrada);
                           if(edad >= 18){
                                Console.WriteLine("mayor");
                           }else{
                                Console.WriteLine("menor");
                           }
                           break;
                           default:
                           System.Console.Clear();
                           break;
                       } 
                       break;
                   default:
                       Console.WriteLine("Gracias por utilizar el programa!! :)");
                       Console.WriteLine(" ");
                       Console.WriteLine(" ");
                       Console.WriteLine(" ");
                       Console.WriteLine(" ");
                       break;
               }

            } while (casos != 0);


        }
    }
}
