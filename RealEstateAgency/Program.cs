using System;
using System.Windows.Forms;
using RealEstateAgency.Forms;
using RealEstateAgency.Data;

namespace RealEstateAgency
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SeedData.Initialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}