

namespace CodigoClase06
{
    struct Cuadrado
    {
        //Propiedades
        public int lado;

        //Comportamiento (Funciones y Procedimientos)
        public int CalcularArea()
        {
            return lado * lado;
        }
        public int CalcularPerimetro()
        {
            return 4 * lado;
        }

        public void MostrarValores()
        {

        }
    }
}
