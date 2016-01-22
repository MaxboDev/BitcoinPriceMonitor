﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinPriceMonitor
{
    interface INotificationTrayIcon : ITradePriceObserver
    {
        void Update(string iconText);
        void Close();
    }
}
