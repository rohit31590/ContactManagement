using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ContactManagement.Models
{

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
    }

    public interface IContactRepository
    {
        Contact CreateContact(Contact contactToCreate);
        void DeleteContact(Contact contactToDelete);
        Contact EditContact(Contact contactToUpdate);
        Contact GetContact(int id);
        IEnumerable<Contact> ListContacts();

    }
    public interface IContactManagementService
    {
        bool AddContact(Contact contactToAdd);
        bool DeleteContact(Contact contactToDelete);
        bool EditContact(Contact contactToEdit);
        Contact GetContact(int id);
        IEnumerable<Contact> ListContacts();
    }

    public class ContactManagementService : IContactManagementService
    {
        public bool AddContact(Contact contactToAdd)
        {
            throw new NotImplementedException();
        }

        public bool DeleteContact(Contact contactToDelete)
        {
            throw new NotImplementedException();
        }

        public bool EditContact(Contact contactToEdit)
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Contact> ListContacts()
        {
            throw new NotImplementedException();
        }
    }
}