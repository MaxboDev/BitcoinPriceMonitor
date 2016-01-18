﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinPriceMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ITradePriceMonitor priceMonitor = new BitcoinAveragePriceMonitor(TradePriceType.Last, 2000);
            ITradePriceMonitorContextMenu trayMenu = new TradePriceMonitorContextMenu(priceMonitor);
            INotificationTrayIcon trayIcon = new NotificationTrayIcon(trayMenu);
            priceMonitor.StartMonitoring((result) =>
            {
                trayIcon.Update(Math.Round(result).ToString());
            });
            Application.Run();
        }
    }
}
