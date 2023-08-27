using System.ComponentModel.DataAnnotations;

namespace ITLicenseManagement.Models
{
    public class LicenseIT
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Portal { get; set; }
        public string OrderLoadTerm { get; set; }
        public string ReSeller { get; set; }
        public string SallerEmail { get; set; }
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public string EmailID { get; set; }
        public string MicrosoftTenendAdoveVIP { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string LicenceTerm { get; set; }
        public string OrderType { get; set; }
        public string ProductName { get; set; }
        public string Billing { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.MinValue;
        public DateTime EndDateTime { get; set; } 
        public string PaymentTerm { get; set; }
        public string RateCommitment { get; set; }
        public int RatePerday { get; set; }
        public int NumberOfDays { get; set; }
        public int ProrateForBilling { get; set; }
        public int Units { get; set; }
        public int Ammount { get; set; }
        public int GSTAmmount { get; set; }
        public int BillingAmmountWithGST { get; set; }
        public int? TaxInvoiceNumber { get; set; } = new Random().Next(1111, 9999);
        public DateTime Date { get; set; } = DateTime.Now;

        
    }

}
