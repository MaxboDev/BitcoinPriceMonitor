﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinPriceMonitor
{
    public interface ITradePriceMonitorContextMenu
    {
        ContextMenu Menu { get; }
    }
}
