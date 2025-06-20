namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1067_uri
    {
        public static void NumerosImpares()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
