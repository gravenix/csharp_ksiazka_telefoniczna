using System;
using System.Collections.Generic;
using App.PhoneBook;

namespace App.Forms {
    public class ContactForm : AbstractForm<string> {
        public ContactForm(){
            FormItems.Add(new FormItem<string>("firstName", "Podaj imię:"));
            FormItems.Add(new FormItem<string>("lastName", "Podaj nazwisko:"));
            FormItems.Add(new FormItem<string>("sex", "Podaj płeć (k/m):"));
            FormItems.Add(new FormItem<string>("number", "Podaj numer telefonu:"));
        }
        public Contact GetContact() {
            Dictionary<string, string> values = GetValues();
            Contact contact = new Contact();
            contact.FirstName = values.GetValueOrDefault("firstName");
            contact.FirstName = values.GetValueOrDefault("lastName");
            contact.FirstName = values.GetValueOrDefault("sex");
            contact.FirstName = values.GetValueOrDefault("number");
            return contact;
        }
    }
}