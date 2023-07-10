using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public delegate void InvoiceAmountUpdateEventHandler(Invoice invoice, InvoiceAmountUpdateEventArgs e);
}
