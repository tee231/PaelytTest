using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo.Mailer;
using PaelytOnionArchi.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PaelytOnionArchi.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IPhotosService _photosService;
        private IConfiguration _configuration;
        private readonly IWebHostEnvironment hostEnvironment;
        public HomeController(ICustomerService customerService, IPhotosService photosService, IConfiguration configuration, IWebHostEnvironment hostEnvironment)
        {
            _customerService = customerService;
            _photosService = photosService;
            _configuration = configuration;
            this.hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Send(Customer customer, List<IFormFile> attachedFiles)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                var body = "Name: " + customer.Name + "<br>Email: " + customer.Email + "<br>TransanctionNumber: " + customer.TransactionNumber + "<br>";
                var mailHelper = new MailSender(_configuration);
                List<string> fileNames = null;
                if (attachedFiles != null && attachedFiles.Count > 0)
                {
                    fileNames = new List<string>();
                    foreach (IFormFile attachment in attachedFiles)
                    {
                        var path = Path.Combine(hostEnvironment.WebRootPath, "uploads", attachment.FileName);
                        uniqueFileName = attachment.FileName;
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            attachment.CopyToAsync(stream);
                        }
                        fileNames.Add(path);
                    }
                }
                if (mailHelper.Send(customer.Email, _configuration["Gmail:Username"], customer.Subject, body, fileNames))
                {
                    ViewBag.msg = "Sent Mail Successfully";
                }
                else
                {
                    ViewBag.msg = "Failed";
                }
                Customer newCustomer = new Customer
                {
                    Name = customer.Name,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    TransactionNumber = Guid.NewGuid().ToString(),
            
                };
                var ret = _customerService.Add(newCustomer);  // assigns via the foreignkey

                foreach (var f in fileNames)
                {
                    var foto = new Photos
                    {
                        CustomerId = ret,
                        Image = f
                    };

                    _photosService.Add(foto);

                }

                //var r = _customerService.Add(newCustomer){
                //   var s = new
                //   {
                //       Id = r,
                //       GenderName = 
                //   }
                //}


            }

            return View();

        }


        [HttpGet("GetAll")]
        public  IActionResult GetAll(string Email, string TransactionNumber)
            
        {
            var t =  _customerService.GetAllCustomers().ToList();
            

            //     var words = from word in _context.Clients
            //            select word;
            //if (!String.IsNullOrEmpty())
            //{
            //    words = words.Where(s => s.Email.Contains(search));

            //}
            //if (words == null)
                return View();

           // return View(t);
        }

    }

}