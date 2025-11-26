namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            
            hanoi(4, from: 'A', to: 'C', aux: 'B'); 

            void hanoi(int n, char from, char to, char aux)
            {
                if (n == 1)
                {
                    Console.WriteLine($"移動圓盤 {n} 從 {from} 到 {to}");
                    return;

                }

                //1
                hanoi(n-1, from: from, to: aux, aux: to); 

                //2
                Console.WriteLine($"移動圓盤 {n} 從 {from} 到 {to}");

                //3
                hanoi(n - 1, from: aux, to: to, aux: from);

            }
        }
    }
}
