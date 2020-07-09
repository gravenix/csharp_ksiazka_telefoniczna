using System;
using App.Menu.Main;
using App.Forms;
using App.PhoneBook;
using App.Utils;

namespace App {
    public class App {
        const int ADD_ENTRY = 1;
        const int VIEW_ENTRIES = 2;
        const int REMOVE_ENTRY = 3;
        const int EXIT = 0;

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
                case REMOVE_ENTRY:
                    SelectOneForm sof = new SelectOneForm();
                    if(book.RemoveContact(sof.Get() - 1)) {
                        Messages.ShowMessage("Usunięto!");
                    } else {
                        Messages.ShowMessage("Brak takiego kontaktu!");
                    }
                    break;
                case EXIT:
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}