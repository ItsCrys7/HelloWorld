namespace Impartire2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (b != 0 && a % b == 00)
            {
                c = a / b;

                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("Impartirea nu se poate efectuata");
            }

        }
    }
}