using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public class InvoiceSerialNumberUpdateEventArgs : EventArgs
    {
        public InvoiceSerialNumberUpdateEventArgs(int oldSerialNumber, int newSerialNumber, DateTime docDate, decimal docAmount)
        {
            OldSerialNumber = oldSerialNumber;
            NewSerialNumber = newSerialNumber;
            DocDate = docDate;
            DocAmount = docAmount;
        }

        public int OldSerialNumber { get; }

        public int NewSerialNumber { get; }

        public DateTime DocDate { get; }

        public decimal DocAmount { get; }
    }
}

