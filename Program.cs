namespace mod4_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("Kode Buah: " + (KodeBuah.Buah)i + " -> " + KodeBuah.getKodeBuah((KodeBuah.Buah)i) );
            }
        }
    }
}