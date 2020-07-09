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
        public bool RemoveContact(int id) {
            if(id < 0 || id > Data.Count-1) return false;
            return Data.Remove(Data[id]);
        }
        public string Serialize() {
            string serialized = "";
            foreach(Contact contact in Data) {
                serialized += "\n" + contact.Serialize();
            }
            return serialized.Substring(1);
        }
    }
}