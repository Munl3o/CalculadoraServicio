using System.Web.Services;

namespace CalculadoraServicio
{
    [WebService(Namespace = "http://localhost/ws/calculadora")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Calculadora : WebService
    {
        [WebMethod]
        public double Suma(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Resta(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Division(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("No se puede dividir entre cero.");
            return a / b;
        }

        [WebMethod]
        public double Potencia(double baseNum, double exponente)
        {
            return System.Math.Pow(baseNum, exponente);
        }

        [WebMethod]
        public int Resto(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("No se puede calcular el resto con divisor cero.");
            return a % b;
        }
    }
}
