namespace Act3
{
    public class Operaciones
    {
        public static int Sumar(int a, int b) => a + b;
        public static int Restar(int a, int b) => a - b;
        public static int Multiplicar(int a, int b) => a * b;
        public static int Dividir(int a, int b) => b != 0 ? a / b : throw new DivideByZeroException();
    }
}
