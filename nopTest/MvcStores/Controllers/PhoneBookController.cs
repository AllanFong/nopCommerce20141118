using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStores.Models;

namespace MvcStores.Controllers
{
    public class PhoneBookController : Controller
    {

        private static List<PhoneBookModel> _PhoneBookList;

        public static List<PhoneBookModel> PhoneBookList
        {
            get
            {
                if (_PhoneBookList == null)
                {
                    _PhoneBookList = new List<PhoneBookModel>();
                    _PhoneBookList.Add(new PhoneBookModel
                    {
                        FirstName = "Alan",
                        LastName = "Fong",
                        MiddleName="Kent",
                        MobileNumber = "204 255 5266",
                        Email = "allank.fong@gmail.com"
                    });
                }
                    return _PhoneBookList;
            }
            set { _PhoneBookList = value; }
        }
        //
        // GET: /PhoneBook/

        public ActionResult Index()
        {
            return View(PhoneBookList);
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}
