using System;
using System.IO;
using App.Menu.Main;
using App.Forms;
using App.PhoneBook;
using App.Utils;

namespace App {
    public class App {
        const int ADD_ENTRY = 1;
        const int VIEW_ENTRIES = 2;
        const int REMOVE_ENTRY = 3;
        const int SAVE_FILE = 4;
        const int READ_FILE = 5;
        const int EXIT = 0;

        const int BROWSER_SIZE = 5;

        private PhoneBook.PhoneBook book = new PhoneBook.PhoneBook();
        public App() {
            MainMenu menu = new MainMenu();
            while (true) {
                int action = menu.Ask();
                switch (action) {
                case ADD_ENTRY:
                    AddNew();
                    break;
                case VIEW_ENTRIES:
                    Browse();
                    break;
                case REMOVE_ENTRY:
                    Remove();
                    break;
                case SAVE_FILE:
                    Save();
                    break;
                case READ_FILE:
                    Load();
                    break;
                case EXIT:
                    Environment.Exit(0);
                    break;
                }
            }
        }

        private void AddNew() {
            ContactForm contactForm = new ContactForm();
            contactForm.FillForm();
            book.AddContact(contactForm.GetContact());
        }

        private void Browse() {
            PhoneBrowser browser = new PhoneBrowser(book.Data, BROWSER_SIZE);
            browser.Browse();
        }

        private void Remove() {
            SelectOneForm sof = new SelectOneForm();
            if(book.RemoveContact(sof.Get() - 1)) {
                Messages.ShowMessage("Usunięto!");
            } else {
                Messages.ShowMessage("Brak takiego kontaktu!");
            }
        }

        private void Save() {
            ChooseFileForm form = new ChooseFileForm();
            string filename =  form.Get();
            using (StreamWriter writer = new StreamWriter(File.OpenWrite($"{filename}.phonebook"))) {
                writer.Write(book.Serialize());
            }
            Console.Clear();
            Console.WriteLine("Zapisano!");
        }

        public void Load() {
            ChooseFileForm form = new ChooseFileForm();
            string filename = form.Get();
            if(!File.Exists(filename)) {
                filename += ".phonebook";
                if(!File.Exists(filename)){
                    Utils.Messages.ShowMessage("Taki plik nie istnieje!");
                    return;
                }
            }
            book.Data.Clear();
            using (StreamReader reader = new StreamReader(File.OpenRead(filename))) {
                string line;
                while ( (line = reader.ReadLine()) != null) {
                    book.Data.Add(Contact.Deserialize(line));
                }
            }
            Console.Clear();
            Console.WriteLine("Wczytano!");
        }
    }
}