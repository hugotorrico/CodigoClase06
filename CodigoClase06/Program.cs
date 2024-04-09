
using CodigoClase06;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {

        Rectangulo rectangulo = new Rectangulo(0, 0, 8, 0, 8, 4, 0, 8);
        rectangulo.color = "Rojo";
        rectangulo.CalcularArea();
        rectangulo.CalcularPerimetro();
        rectangulo.color = "Verde";

      


        /*
        //int[] notas = new int[5];
        //Estudiante[] estudiantes= new Estudiante[5];      
        List<Estudiante> estudiantes = new List<Estudiante>();
        string Salir = "";
        string? Nombres="";//? : Nullable!!!    
        int Edad=0;
        int Calificacion=0;
                 
        do
        {
          
            //Leo la información de consola.
            Console.WriteLine("Ingrese Nombres");
            Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese Edad");
            Edad = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Ingrese Calificacion");
            Calificacion = Convert.ToInt32(Console.ReadLine());

            //Instancio al estudiante
            Estudiante estudiante= new Estudiante(Nombres,Edad, Calificacion);

            //Lleno mi colección
            estudiantes.Add(estudiante);

            Console.WriteLine("Desea Salir?");
            Salir= Console.ReadLine();

        } while (Salir.ToUpper()!="S");


        foreach (var item in estudiantes)
        {
            Console.WriteLine($"Nombres: {item.Nombres} Edad:{item.Edad} Calificacion: {item.Calificacion} ");
        }
        */
        /*

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
        */
        Console.Read();


       
    }
}
