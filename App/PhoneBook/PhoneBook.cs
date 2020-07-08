using System;
using System.Collections.Generic;

namespace App.PhoneBook {
    public class PhoneBook {
        private List<Contact> data = new List<Contact>();
        public void AddContact(Contact contact) {
            data.Add(contact);
        }
    }
}