﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Guncelle()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Güncellendi.");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}