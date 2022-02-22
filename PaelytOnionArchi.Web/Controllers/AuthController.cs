using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PaelytOnionArchi.Data;
using PaelytOnionArchi.Repo;
using PaelytOnionArchi.Service;
using System;

using System.Threading.Tasks;

namespace PaelytOnionArchi.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IPhotosService _photosService;
        private IConfiguration _Dbcontext;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly ApplicationDbContext _context;
       
        public AuthController(ICustomerService customerService, IPhotosService photosService, IConfiguration configuration, IWebHostEnvironment hostEnvironment, ApplicationDbContext context)
        {
            _customerService = customerService;
            _photosService = photosService;
            _Dbcontext = configuration;
            this.hostEnvironment = hostEnvironment;
            _context = context;
           

        }
        public IActionResult Index()
        {
            return View();
        }

       // [HttpPost]

        //public async Task<IActionResult> Login(Customer customer)
        //{
        //    try
        //    {

        //        //var findentity = await _context.Customer();
        //        //   if (x => x.Email == email &&  x => x.TransactionNumber == TransactionNumber);
        //        //if (findentity == null)
        //        //    return null;
        //        //return ViewResult


                
                

        //    }


        //    catch (Exception)
        //    {
        //        // return StatusCode(StatusCodes.Status500InternalServerError, "could not create Driver"); this also works.

        //        return (new ResponseModel<object)


        //    }


        }

    }

