using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public delegate void InvoiceDateUpdateEventHandler(Invoice invoice, InvoiceDateUpdateEventArgs e);
}
