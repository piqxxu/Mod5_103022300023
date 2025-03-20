using Mod5_103022300023;

public class Program
{
    public static void Main(String[] args)
    {
        double q = 30;
        double w = 00;
        double e = 23;
        PemrosesData data = new PemrosesData();

        Console.Write("Nilai terbesar dari A(30), B(00), dan C(23) adalah ");
        Console.WriteLine(data.DapatkanNilaiTerbesar(q, w, e));
    }
}