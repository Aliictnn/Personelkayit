﻿using Form1;
using System;
using System.Windows.Forms;

namespace Personelkayit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Personel()); // Personel sınıfı burada çağrılıyor
        }
    }
}
