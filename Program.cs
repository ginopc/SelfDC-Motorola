using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SelfDC.Models;
using SelfDC.Utils;

namespace SelfDC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            /* Carico le impostazioni del programma */
            ScsUtils.WriteLog("Caricamento impostazioni");
            Settings.AppCfgFileName = string.Format("{0}\\conf.txt", ScsUtils.GetAppPath());
            Settings.LoadFromFile(Settings.AppCfgFileName);

            Application.Run(new MainMenu());

            /*
            Application.Run(new MainMenu());
             */
            /*
            ScsUtils.WriteLog("Creo nuovo ordine");
            List<OrderItem> lista = new List<OrderItem>();
            lista.Add(new OrderItem("123456"));
            lista.Add(new OrderItem("111111"));
            lista.Add(new OrderItem("222222"));
            lista.Remove(new OrderItem("111111"));
            
            // Stampo la lista degli item dell'ordine
            foreach(OrderItem item in lista)
            {
                Console.WriteLine("[DEBUG]: {0}", item.ToString());
            }

            Settings.SaveToFile(Settings.AppCfgFileName);
             * */
        }
    }
}