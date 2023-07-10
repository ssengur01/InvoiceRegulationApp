using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public delegate void InvoiceSerialNumberUpdateEventHandler(Invoice invoice, InvoiceSerialNumberUpdateEventArgs e);
}
