using System;
using App.Menu.Main;
using App.Forms;
using App.PhoneBook;

namespace App {
    public class App {
        public App() {
            MainMenu menu = new MainMenu();
            PhoneBook.PhoneBook book = new PhoneBook.PhoneBook();
            while (true) {
                int action = menu.Ask();
                switch (action) {
                case 1:
                    ContactForm contactForm = new ContactForm();
                    contactForm.FillForm();
                    book.AddContact(contactForm.GetContact());
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}