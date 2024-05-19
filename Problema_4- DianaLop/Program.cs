/*
 * TRABAJO UNIVERSIDAD: UNAD
 * CURSO: FUNDAMENTOS DE PROGRAMACION
 * PERIODO: 16-2
 * GRUPO: 213022-31
 */


using System.Runtime.CompilerServices;

class Problema_4
{
    private static string? nombreUsuario;
    private static string Opcion_Menu = "0";
    private static int Cantidad_Pera = 0;
    private static int Cantidad_Manzana = 0;
    private static int Cantidad_Ciruela = 0;
    private static int Cantidad_Banano = 0;
    private static int Cantidad_Pina = 0;
    private static int Cantidad_Total = 0;
    private static double Precio_Pera = 450.0;
    private static double Precio_Manzana = 560.0;
    private static double Precio_Ciruela = 30.0;
    private static double Precio_Banano = 80.0;
    private static double Precio_Pina = 1000.0;
    private static double Total_Pera = 0;
    private static double Total_Manzana = 0;
    private static double Total_Ciruela = 0;
    private static double Total_Banano = 0;
    private static double Total_Pina = 0;
    private static double Valor_Total = 0;
    private static string Valor_Titulo = "Lista de Compras: ";
    private static bool Estado_Compra=false;

    public static void Main(string[] args)//creacion del metodo principal 
    {
        Mensaje_Bienvenida(); //llama el metodo de bienvenida
        while (Opcion_Menu!="7") 
        {
            if (!Estado_Compra)
            {
                Menu();
            }
            int Cantidad=0;
            double Subtotal = 0;
            switch (Opcion_Menu)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Peras");
                    Cantidad = Preguntar_Cantidad("Peras");
                    Cantidad_Pera = Cantidad_Pera + Cantidad;
                    Cantidad_Total = Cantidad_Total + Cantidad;
                    Subtotal = Calcular_valor_precio(Cantidad, Precio_Pera);
                    Total_Pera = Total_Pera + Subtotal;
                    Valor_Total = Valor_Total + Subtotal;

                    break;

                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Manzanas");
                    Cantidad = Preguntar_Cantidad("Manzanas");
                    Cantidad_Manzana = Cantidad_Manzana + Cantidad;
                    Cantidad_Total = Cantidad_Total + Cantidad;
                    Subtotal = Calcular_valor_precio(Cantidad, Precio_Manzana);
                    Total_Manzana = Total_Manzana + Subtotal;
                    Valor_Total = Valor_Total + Subtotal;

                    break;

                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Ciruelas");
                    Cantidad = Preguntar_Cantidad("Ciruelas");
                    Cantidad_Ciruela = Cantidad_Ciruela + Cantidad;
                    Cantidad_Total = Cantidad_Total + Cantidad;
                    Subtotal = Calcular_valor_precio(Cantidad, Precio_Ciruela);
                    Total_Ciruela = Total_Ciruela + Subtotal;
                    Valor_Total = Valor_Total + Subtotal;

                    break;

                case "4":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Bananos");
                    Cantidad = Preguntar_Cantidad("Bananos");
                    Cantidad_Banano = Cantidad_Banano + Cantidad;
                    Cantidad_Total = Cantidad_Total + Cantidad;
                    Subtotal = Calcular_valor_precio(Cantidad, Precio_Banano);
                    Total_Banano = Total_Banano + Subtotal;
                    Valor_Total = Valor_Total + Subtotal;

                    break;

                case "5":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Piñas");
                    Cantidad = Preguntar_Cantidad("Piñas");
                    Cantidad_Pina = Cantidad_Pina + Cantidad;
                    Cantidad_Total = Cantidad_Total + Cantidad;
                    Subtotal = Calcular_valor_precio(Cantidad, Precio_Pina);
                    Total_Pina = Total_Pina + Subtotal;
                    Valor_Total = Valor_Total + Subtotal;

                    break;

                case "6":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Finalizar Compra");
                    if (Cantidad_Total < 1)
                    {
                        Console.WriteLine("La lista de compras se encuentra vacía");
                    }
                    else
                    {
                        Pregutar_Confirmacion_Pago();
                    }

                    break;

                case "7":
                    Console.WriteLine("");
                    Console.WriteLine("Elegiste Salir");
                    if (Cantidad_Total > 0)
                    {
                        Pregutar_Salir();
                    }
                    break;

                case "8":
                    if (Estado_Compra)
                    {
                        double Porcentaje_Descuento = Valor_Descuento();
                        Console.WriteLine("Subtotal: $" + Valor_Total);
                        Generar_Factura();
                        Porcentaje_Descuento = ((1 - Porcentaje_Descuento) * 100);
                        Console.WriteLine("Descuento Aplicado: " + Math.Round(Porcentaje_Descuento,2) + "%");
                        Console.WriteLine("Total: $" + Valor_Total);
                        Opcion_Menu = "7";
                        Cantidad_Total = 0;
                        Estado_Compra = false;
                        Console.WriteLine("");
                        Console.WriteLine(nombreUsuario+", ¡¡Gracias por tu compra!!");
                        System.Threading.Thread.Sleep(1500); //espera un tiempo determinado en milisegundos 
                    }
                    else
                    {
                        Opcion_Menu = "";
                    }
                    break;

                default:
                    Console.WriteLine("Elige entre las opciones del 1 al 7");
                    System.Threading.Thread.Sleep(1500); //espera un tiempo determinado en milisegundos 
                    break;
            }

            if (Opcion_Menu != "7")
            {
                Console.WriteLine("");
                Console.WriteLine(Valor_Titulo);
                if (Cantidad_Pera > 0)
                {
                    Console.WriteLine("- Peras:     " + Cantidad_Pera + "    Valor: $" + Total_Pera);
                }

                if (Cantidad_Manzana > 0)
                {
                    Console.WriteLine("- Manzanas:  " + Cantidad_Manzana + "    Valor: $" + Total_Manzana);
                }

                if (Cantidad_Ciruela > 0)
                {
                    Console.WriteLine("- Ciruelas:  " + Cantidad_Ciruela + "    Valor: $" + Total_Ciruela);
                }

                if (Cantidad_Banano > 0)
                {
                    Console.WriteLine("- Bananos:   " + Cantidad_Banano + "    Valor: $" + Total_Banano);
                }

                if (Cantidad_Pina > 0)
                {
                    Console.WriteLine("- Piñas:     " + Cantidad_Pina + "    Valor: $" + Total_Pina);
                }

                if (Cantidad_Total > 0)
                {
                    Console.WriteLine("================================================");
                    Console.WriteLine("");
                    Console.WriteLine("Cantidad: " + Cantidad_Total + " Valor: $" + Valor_Total);
                    Console.WriteLine("");
                    Console.WriteLine("================================================");
                }
            }
        }
    }

    private static void Generar_Factura()
    {
        Valor_Total = Valor_Total * Valor_Descuento();
    }

    private static double Valor_Descuento()
    {
        if (Valor_Total > 20000)
        {
            return 0.9;   
        }
        else
        {
            return 1;
        }
    }
    
    private static void Pregutar_Salir()
    {
        Console.WriteLine("¿Está seguro que desea salir de La Frutera?");
        Console.WriteLine("1) Ingresa 1 para regresar");
        Console.WriteLine("7) Ingresa 7 para salir");
        Console.Write("Ingrese Opcion 1 o 7: ");
        string Opcion_Salir = Console.ReadLine() + "";
        if(Opcion_Salir != "7")
        {
            Opcion_Menu = Opcion_Salir;
        }
    }

    private static void Pregutar_Confirmacion_Pago()
    {
        Console.WriteLine("1) Ingresa 1 para continuar con el pago");
        Console.WriteLine("2) Ingresa 2 para regresar");
        Console.Write("Ingrese Opcion 1 o 2: ");
        string Opcion_Confirmacion_Pago = Console.ReadLine() + "";
        if(Opcion_Confirmacion_Pago == "1")
        {
            Opcion_Menu = "8";
            Estado_Compra = true;
            Valor_Titulo = "Factura: ";
        }
    }

    private static int Preguntar_Cantidad(string nombre_fruta)
    {
        Console.Write("Ingrese la cantidad de " + nombre_fruta +": ");
        return int.Parse(Console.ReadLine() + "");
    }
    private static double Calcular_valor_precio(int Cantidad, double Precio)
    {
        return Cantidad * Precio;
    }

    private static void Menu()
    {
        Console.WriteLine("");
        Console.WriteLine("================================================");
        Console.WriteLine("");

        Console.WriteLine("Para seleccionar presiona: ");
        Console.WriteLine("1) Pera      ($" + Precio_Pera + ")");
        Console.WriteLine("2) Manzana   ($" + Precio_Manzana + ")");
        Console.WriteLine("3) Ciruela   ($" + Precio_Ciruela + ")");
        Console.WriteLine("4) Banano    ($" + Precio_Banano + ")");
        Console.WriteLine("5) Pina      ($"+ Precio_Pina + ")");
        Console.WriteLine("6) Finalizar compra");
        Console.WriteLine("7) Salir");
        Console.WriteLine("");
        Console.Write("Ingrese Opcion del 1 al 7: ");
        Opcion_Menu = Console.ReadLine()+"";
    }

    private static void Mensaje_Bienvenida() //metodo de bienvenida 
    {
        Console.Write("Por favor escriba su nombre: "); //imprime el mensaje que esta entre parentesis
        nombreUsuario = Console.ReadLine()+""; //lee lo que el usuario escriba en consola
        Console.Write("");
        Console.WriteLine("Hola "+nombreUsuario+ ", Bienvenid@ a La Frutera"); // concatena el nombre de usuario con el saludo y bienvenida
        System.Threading.Thread.Sleep(1500); //espera un tiempo determinado en milisegundos 
    }
}