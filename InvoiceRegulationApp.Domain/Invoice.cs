namespace InvoiceRegulationApp.Domain
{
    public class Invoice
    {
        public event InvoiceAmountUpdateEventHandler InvoiceAmountUpdated;

        public event InvoiceDateUpdateEventHandler InvoiceDateUpdated;

        public event InvoiceSerialNumberUpdateEventHandler InvoiceSerialNumberUpdated;

        private DateTime docdate;

        private decimal docAmount;

        private int serialNumber;



        public DateTime DocDate
        {
            get { return docdate; }
            set
            {
                var oldDate = docdate;
                docdate = value;

                InvoiceDateUpdated?.Invoke(this, new InvoiceDateUpdateEventArgs(oldDate, docdate, serialNumber, docAmount));
            }
        }

        public decimal DocAmount
        {
            get { return docAmount; }
            set
            {
                var oldAmount = docAmount;
                docAmount = value;

                InvoiceAmountUpdated?.Invoke(this, new InvoiceAmountUpdateEventArgs(oldAmount, docAmount, docdate, serialNumber));
            }
        }

        public int SerialNumber
        {
            get { return serialNumber; }
            set
            {
                var oldSerialNumber = serialNumber;
                serialNumber = value;

                InvoiceSerialNumberUpdated?.Invoke(this, new InvoiceSerialNumberUpdateEventArgs(oldSerialNumber, serialNumber, docdate, docAmount));
            }
        }
    }
}