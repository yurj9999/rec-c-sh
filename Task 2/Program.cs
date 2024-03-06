class Checker
{
    public static int Akkerman(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if ((m != 0) && (n == 0)) {
            return Akkerman(m - 1, 1);
        } else {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}

class AkkermanMaker
{
    public static void Main()
    {
        int M = 2;
        int N = 3;

        int result = Checker.Akkerman(M, N);

        Console.WriteLine(result);
    }
}
