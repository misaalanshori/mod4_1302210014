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

            Console.WriteLine();

            PosisiKarakterGame steve = new PosisiKarakterGame();
            PosisiKarakterGame.KarakterTrigger[] listTrigger = new PosisiKarakterGame.KarakterTrigger[] {
                PosisiKarakterGame.KarakterTrigger.TombolS,
                PosisiKarakterGame.KarakterTrigger.TombolS,
                PosisiKarakterGame.KarakterTrigger.TombolW,
                PosisiKarakterGame.KarakterTrigger.TombolW,
                PosisiKarakterGame.KarakterTrigger.TombolW,
                PosisiKarakterGame.KarakterTrigger.TombolS,
                PosisiKarakterGame.KarakterTrigger.TombolW,
                PosisiKarakterGame.KarakterTrigger.TombolX
            };
            Console.WriteLine("Starting State: " + steve.currentState);
            for (int i = 0; i < listTrigger.Length; i++)
            {
                Console.WriteLine("Menekan " + listTrigger[i]);
                steve.activateTrigger(listTrigger[i]);
                Console.WriteLine("Current State: " + steve.currentState);
            }
        }
    }
}