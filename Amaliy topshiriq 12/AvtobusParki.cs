using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq_12
{
    public class AvtobusParki
    {
        private List<Avtobus> avtobuslar = new List<Avtobus>();

        public void MalumotKiritish(string raqam, string haydovchiIsmi, string yonalishRaqam)
        {
            Avtobus avtobus = new Avtobus { Raqam = raqam, HaydovchiIsmi = haydovchiIsmi, YonalishRaqam = yonalishRaqam };
            avtobuslar.Add(avtobus);
        }

        public void YonalishgaChiqarilgan(string raqam)
        {
            Avtobus avtobus = avtobuslar.Find(a => a.Raqam == raqam);
            if (avtobus != null)
            {
                avtobuslar.Remove(avtobus);
                Console.WriteLine($"{raqam} raqamli avtobus yo'nalishdan chiqarildi.");
                HarakatlanayotganAvtobuslarRoyxati(avtobus);
            }
            else
            {
                Console.WriteLine($"{raqam} raqamli avtobus topilmadi.");
            }
        }

        public void DaraxtChiqarish()
        {
            foreach (var avtobus in avtobuslar)
            {
                Console.WriteLine($"Avtobus raqami: {avtobus.Raqam}, Haydovchi ismi: {avtobus.HaydovchiIsmi}, Yo'nalish raqami: {avtobus.YonalishRaqam}");
            }
        }

        private void HarakatlanayotganAvtobuslarRoyxati(Avtobus avtobus)
        {
            Console.WriteLine($"Yo'nalishda harakatlanayotgan avtobuslar ro'yxati:");
            Console.WriteLine($"Avtobus raqami: {avtobus.Raqam}, Haydovchi ismi: {avtobus.HaydovchiIsmi}, Yo'nalish raqami: {avtobus.YonalishRaqam}");
        }
    }
}


