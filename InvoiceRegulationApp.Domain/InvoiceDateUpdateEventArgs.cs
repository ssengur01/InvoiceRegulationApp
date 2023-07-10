using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public class InvoiceDateUpdateEventArgs : EventArgs
    {
        public InvoiceDateUpdateEventArgs(DateTime oldDate, DateTime newDate, int serialNumber, decimal docAmount)
        {
            OldDate = oldDate;
            NewDate = newDate;
            SerialNumber = serialNumber;
            DocAmount = docAmount;
        }

        public DateTime OldDate { get; }

        public DateTime NewDate { get; }

        public int SerialNumber { get; }

        public decimal DocAmount { get; }

    }
}

