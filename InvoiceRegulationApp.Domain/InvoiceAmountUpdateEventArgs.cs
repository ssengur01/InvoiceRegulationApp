using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegulationApp.Domain
{
    public class InvoiceAmountUpdateEventArgs : EventArgs
    {
        public InvoiceAmountUpdateEventArgs(decimal oldAmount, decimal newAmount, DateTime docDate, int serialNumber)
        {
            OldAmount = oldAmount;
            NewAmount = newAmount;
            DocDate = docDate;
            SerialNumber = serialNumber;
        }

        public decimal OldAmount { get; }

        public decimal NewAmount { get; }

        public DateTime DocDate { get; }

        public int SerialNumber { get; }

    }
}
