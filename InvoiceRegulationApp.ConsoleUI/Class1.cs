using InvoiceRegulationApp.Domain;

Invoice invoice = new Invoice();
invoice.DocDate = Convert.ToDateTime("10.03.2023");
invoice.DocAmount = 545;
invoice.SerialNumber = 88888;

invoice.InvoiceDateUpdated += Invoice_InvoiceDateUpdated;
invoice.DocDate = DateTime.Now;


invoice.InvoiceSerialNumberUpdated += Invoice_InvoiceSerialNumberUpdated;
invoice.SerialNumber = 34567;

invoice.InvoiceAmountUpdated += Invoice_InvoiceAmountUpdated;
invoice.DocAmount = 8765;

void Invoice_InvoiceAmountUpdated(Invoice invoice, InvoiceAmountUpdateEventArgs e)
{
    Console.WriteLine($"{e.SerialNumber} numaralı faturanın belge tutarı değişti : {e.NewAmount}");
}

void Invoice_InvoiceSerialNumberUpdated(Invoice invoice, InvoiceSerialNumberUpdateEventArgs e)
{
    Console.WriteLine($"{e.OldSerialNumber} numaralı faturanın yeni belge numarası : {e.NewSerialNumber}");
}

void Invoice_InvoiceDateUpdated(Invoice invoice, InvoiceDateUpdateEventArgs e)
{
    Console.WriteLine($"{e.SerialNumber} numaralı faturanın tarihi güncellendi : {e.NewDate}");
}
