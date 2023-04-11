using modul8_1302213117;

internal class Program
{
    private static void Main(string[] args)
    {
        BankTransferConfig bankTransferRegy = new BankTransferConfig();
        string language = bankTransferRegy.config.lang;

        if (language == "id" || language == "en")
        {
            //D.i
            if (language == "en")
            {
                Console.Write("Please insert the amount of money to transfer: ");
            }
            else if (language == "id")
            {
                Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
            }

            //D.ii.1
            int jumlah = Convert.ToInt32(Console.ReadLine());
            int biaya;
            if (jumlah <= bankTransferRegy.config.transfer.threshold)
            {
                biaya = bankTransferRegy.config.transfer.low_fee;
            }
            else
            {
                biaya = bankTransferRegy.config.transfer.high_fee;
            }

            //D.ii.2
            int total = jumlah + biaya;

            //D.ii.3
            if (language == "en")
            {
                Console.WriteLine("Transfer fee = " + biaya);
                Console.WriteLine("Total amount = " + total);
            }
            else if (language == "id")
            {
                Console.WriteLine("Biaya transfer = " + biaya);
                Console.WriteLine("Total biaya = " + total);
            }

            //D.iii
            if (language == "en")
            {
                Console.WriteLine("Select tranfer method:");
            }
            else if (language == "id")
            {
                Console.WriteLine("Pilih metode transfer:");
            }

            //D.iv
            for (int i = 0; i < bankTransferRegy.config.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + bankTransferRegy.config.methods[i]);
            }
            Console.WriteLine("Ketik: ");
            string metode = Console.ReadLine();

            //D.v
            if (language == "en")
            {
                Console.WriteLine("Please type " + bankTransferRegy.config.confirmation.en +
                    " to confirm the transaction: ");
            }
            else if (language == "id")
            {
                Console.WriteLine("Ketik " + bankTransferRegy.config.confirmation.id +
                    " untuk mengkonfirmasi transaksi: ");
            }
            string konfirmasi = Console.ReadLine();

            //D.vi & D.vii
            if (language == "en")
            {
                if (konfirmasi == bankTransferRegy.config.confirmation.en)
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }
            else if (language == "id")
            {
                if (konfirmasi == bankTransferRegy.config.confirmation.id)
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
        } else
        {
            Console.WriteLine("Unknown language");
        }
    }
}