

namespace CodigoClase06
{
    // Definición de una estructura
    struct Point
    {
        public int X;
        public int Y;

        // Constructor
        //Funcion que tienen el mismo nombre de la estructura, 
        //que inicializa los valores
        public Point(int px, int py)
        {
            X = px;
            Y = py;
        }

        // Método para mostrar la posición
        public void DisplayPosition()
        {            
            Console.WriteLine($"Posición: ({X}, {Y})");
        }
    }
}
