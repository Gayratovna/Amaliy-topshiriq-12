using Amaliy_topshiriq_12;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        AvtobusParki avtobusParki = new AvtobusParki();

        // 1. Avtobus parkidagi barcha avtobuslar haqidagi ma’lumotlarni kiritish va ularni daraxt shaklida tasvirlash
        avtobusParki.MalumotKiritish("101", "Ali Ota", "5");
        avtobusParki.MalumotKiritish("202", "Vali Ogly", "12");
        avtobusParki.MalumotKiritish("303", "Hasan Ova", "8");

        // 2. Avtobus parkida yo’nalishga chiqqan avtobus raqami kiritilganda, ushbu avtobusni parkdagi ro’yxatdan chiqarib, yo’nalishda harakatlanayotgan avtobuslar ro’yxatiga qo’shish
        avtobusParki.YonalishgaChiqarilgan("202");

        // Avtobus parkini chiqarish
        avtobusParki.DaraxtChiqarish();
    }
}