using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactManagement.Models;
namespace ContactManagement.Controllers
{
    public class HomeController : Controller
    {
        static List<Contact> contactList;

        public ActionResult Index()
        {
            if (contactList == null) { contactList = new List<Contact>(); }
            ViewBag.Title = "Home Page";

            return View(contactList.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contactToCreate)
        {
            ViewBag.Title = "Create Page";
            if (contactList.Where(p => p.Email.Equals(contactToCreate.Email, StringComparison.OrdinalIgnoreCase)).FirstOrDefault() == null)
            {
                contactToCreate.Id = contactList.Count + 1;
                contactList.Add(contactToCreate);

            }
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            Contact editContact = contactList.Where(p => p.Id == id).FirstOrDefault();
            return View(editContact);
        }

        [HttpPost]
        public ActionResult Edit(int id, Contact contactToEdit)
        {
            try
            {
                if (contactList.Where(p => p.Id != id && p.Email.Equals(contactToEdit.Email, StringComparison.OrdinalIgnoreCase)).FirstOrDefault() == null)
                {
                    (contactList.Where(p => p.Id == id).ToList<Contact>()).ForEach(p => p.FirstName = contactToEdit.FirstName);
                    (contactList.Where(p => p.Id == id).ToList<Contact>()).ForEach(p => p.LastName = contactToEdit.LastName);
                    (contactList.Where(p => p.Id == id).ToList<Contact>()).ForEach(p => p.Email = contactToEdit.Email);
                    (contactList.Where(p => p.Id == id).ToList<Contact>()).ForEach(p => p.Phone = contactToEdit.Phone);
                    (contactList.Where(p => p.Id == id).ToList<Contact>()).ForEach(p => p.Status = contactToEdit.Status);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            Contact getContact = contactList.Where(p => p.Id == id).FirstOrDefault();
            return View(getContact);
        }

        public ActionResult Delete(int id)
        {
            Contact deleteContact = contactList.Where(p => p.Id == id).FirstOrDefault();
            return View(deleteContact);
        }

        [HttpPost]
        public ActionResult Delete(int id, Contact deleteContact)
        {
            try
            {
                deleteContact = contactList.Where(p => p.Id == id).FirstOrDefault();
                contactList.Remove(deleteContact);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
