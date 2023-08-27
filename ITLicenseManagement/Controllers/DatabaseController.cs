using ITLicenseManagement.Data;
using ITLicenseManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITLicenseManagement.Controllers
{
    public class DatabaseController : Controller
    {
        private ApplicationDbContext _context;

        public DatabaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<LicenseIT> licenseITs = _context.licenseITs;
            return View(licenseITs);
        }
        [HttpGet]
        public IActionResult AddLicense()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLicense(LicenseIT licenseIT)
        {


            _context.licenseITs.Add(licenseIT);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Add
        [HttpGet]
        public IActionResult AddNew(string domain)
        {
            if (domain != null)
            {
                LicenseIT objnewLicenseIT = new LicenseIT();
                var data = _context.licenseITs.Where(x => x.Domain == domain).FirstOrDefault();
                if (data != null)
                {
                    objnewLicenseIT.Portal = data.Portal;
                    objnewLicenseIT.OrderLoadTerm = data.OrderLoadTerm;
                    objnewLicenseIT.ReSeller = data.ReSeller;
                    objnewLicenseIT.SallerEmail = data.SallerEmail;
                    objnewLicenseIT.CustomerName = data.CustomerName;
                    objnewLicenseIT.ContactNo = data.ContactNo;
                    objnewLicenseIT.EmailID = data.EmailID;
                    objnewLicenseIT.MicrosoftTenendAdoveVIP = data.MicrosoftTenendAdoveVIP;
                    objnewLicenseIT.Password = data.Password;
                    objnewLicenseIT.LicenceTerm = data.LicenceTerm;
                    objnewLicenseIT.OrderType = data.OrderType;
                    objnewLicenseIT.ProductName = data.ProductName;
                    objnewLicenseIT.Billing = data.Billing;
                    //objnewLicenseIT.StartDateTime = Convert.ToDateTime(data.StartDateTime);
                    objnewLicenseIT.EndDateTime = Convert.ToDateTime(data.EndDateTime);
                    objnewLicenseIT.PaymentTerm = data.PaymentTerm;
                    objnewLicenseIT.RateCommitment = data.RateCommitment;
                    objnewLicenseIT.RatePerday = data.RatePerday;
                    objnewLicenseIT.NumberOfDays = data.NumberOfDays;
                    objnewLicenseIT.ProrateForBilling = data.ProrateForBilling;
                    objnewLicenseIT.Units = data.Units;
                    objnewLicenseIT.Ammount = data.Ammount;
                    objnewLicenseIT.GSTAmmount = data.GSTAmmount;
                    objnewLicenseIT.BillingAmmountWithGST = data.BillingAmmountWithGST;

                }

                return View(objnewLicenseIT);
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNew(LicenseIT licenseIT)
        {


            _context.licenseITs.Add(licenseIT);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


