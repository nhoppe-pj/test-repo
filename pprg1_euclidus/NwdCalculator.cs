public static class NwdCalculator
{
    public static int Nwd(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Liczby muszą być dodatnie.");
        }

        while (b != 0)
        {
            int reszta = a % b;
            a = b;
            b = reszta;
        }

        return a;
    }
}
