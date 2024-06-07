using Calculadora;

public class CalculadoraProgramador : CalculadoraPadrao
{
    public int E(int a, int b)
    {
        return a & b;
    }

    public int Ou(int a, int b)
    {
        return a | b;
    }

    public int Xor(int a, int b)
    {
        return a ^ b;
    }

    public int Nao(int a)
    {
        return ~a;
    }
}
