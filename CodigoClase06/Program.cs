
using CodigoClase06;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        //Constructor.
        Persona persona = new Persona("Hugo","Torico","Nasca",36,1500);

        Persona persona1 = new Persona();
        persona1.Apellidos = "Marquez";
        persona1.Nombres = "Felipe";
       
        // Crear una instancia de la estructura Point
        Point p1 = new Point(10, 20);      
        // Acceder a los miembros de la estructura
        Console.WriteLine($"Coordenada X: {p1.X}");
        Console.WriteLine($"Coordenada Y: {p1.Y}");

        // Llamar al método de la estructura
        p1.DisplayPosition();




        //NEW: Instanciar     
        Cuadrado cuadrado = new Cuadrado();
        cuadrado.lado = 10;

        Console.WriteLine("El área del cuadrado es:");
        Console.WriteLine(cuadrado.CalcularArea());

        Console.WriteLine("El períemtro del cuadrado es:");
        Console.WriteLine(cuadrado.CalcularPerimetro());


        Impuesto impuesto = new Impuesto();
        impuesto.Monto = 5000;
      
        Console.WriteLine("El IGV Del Monto es: ");
        Console.WriteLine(impuesto.CalcularIGV());


        Calculadora calculadora = new Calculadora();
        calculadora.a = 40;
        calculadora.b = 20;





        Console.WriteLine("Sumar");
        Console.WriteLine( calculadora.Sumar());
        Console.WriteLine("Restar");
        Console.WriteLine(calculadora.Restar());
        Console.WriteLine("Multiplicar");
        Console.WriteLine(calculadora.Multiplicar());
        Console.WriteLine("Dividir");
        Console.WriteLine(calculadora.Dividir());







        Console.Read();


       
    }
}
