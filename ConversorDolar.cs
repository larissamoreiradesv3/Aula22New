namespace Aula22New
{
    public class ConversorDolar
    {
         private static float CotacaoDolar = 5.24f;
        public static float RealConDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }
        public static float DolarConReais(float valorUS){
            return CotacaoDolar * valorUS;
        }
    }
}