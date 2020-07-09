using System;
using App.Menu.Main;
using App.Forms;
using App.PhoneBook;

namespace App {
    public class App {
        const int ADD_ENTRY = 1;
        const int VIEW_ENTRIES = 2;
        const int EDIT_ENTRY = 3;
        const int REMOVE_ENTRY = 4;
        const int EXIT = 5;

        const int BROWSER_SIZE = 5;
        public App() {
            MainMenu menu = new MainMenu();
            PhoneBook.PhoneBook book = new PhoneBook.PhoneBook();
            while (true) {
                int action = menu.Ask();
                switch (action) {
                case ADD_ENTRY:
                    ContactForm contactForm = new ContactForm();
                    contactForm.FillForm();
                    book.AddContact(contactForm.GetContact());
                    break;
                case VIEW_ENTRIES:
                    PhoneBrowser browser = new PhoneBrowser(book.Data, BROWSER_SIZE);
                    browser.Browse();
                    break;
                case EDIT_ENTRY:
                    break;
                case REMOVE_ENTRY:

                    break;
                case EXIT:
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}