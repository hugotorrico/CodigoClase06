

namespace CodigoClase06
{
   struct Persona
    {
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public int Edad;
        public double Sueldo;

        public Persona(string pNombres, string pApellidos, string pDireccion,
            int pEdad, double pSueldo)
        {

            Nombres = pNombres;
            Apellidos = pApellidos;
            Direccion = pDireccion;
            Edad = pEdad;
            Sueldo = pSueldo;

        }

    }
}
