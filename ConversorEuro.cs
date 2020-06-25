namespace Aula22New
{
    public class ConversorEuro
    {
        private static float CotacaoEU = 5.82f;
        public static float RealConEu(float valorRS){
            return valorRS / CotacaoEU;
        }
        public static float EuConReal(float valorEU){
            return CotacaoEU * valorEU;
        }
        
    }
}