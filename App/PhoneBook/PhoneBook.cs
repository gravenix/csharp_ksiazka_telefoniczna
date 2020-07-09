using System;
using System.Collections.Generic;

namespace App.PhoneBook {
    public class PhoneBook {
        public List<Contact> Data{get;}
        public PhoneBook() {
            Data = new List<Contact>();
        }
        public void AddContact(Contact contact) {
            Data.Add(contact);
        }
    }
}