
namespace CodigoClase06
{
    struct Impuesto
    {
        public int Monto;
        public double CalcularIGV()
        {
            return Monto * 0.18;
        }
        public double Calcular5Ta()
        {
            return 0;
        }
        public double Calcular4Ta()
        {
            return 0;
        }

        public double Declarar()
        {
            return 0;
        }

        public double Pagar()
        {
            return 0;
        }
        public double Amortizar()
        {
            return 0;
        }
    }
}
