using System;
using System.Collections.Generic;
using App.Menu.Browser;

namespace App.PhoneBook {
    public class PhoneBrowser {
        const int ACTION_NEXT = 1;
        const int ACTION_PREV = 2;
        const int ACTION_BACK = 3;
        private List<Contact> Data;
        private BrowserMenu menu;
        private int Offset = 0;
        private int Size = 5;

        public PhoneBrowser(List<Contact> contacts, int size) {
            Data = contacts;
            Size = size;
            menu = new BrowserMenu(contacts.Count > size, false);
        }

        public void Browse() {
            while (true) {
                ViewItems();
                Console.WriteLine();
                int action = menu.Ask();
                switch (action) {
                case ACTION_NEXT:
                    if(Offset + Size < Data.Count) Offset += Size;
                    break;
                case ACTION_PREV: 
                    if(Offset - Size >= 0) Offset -= Size;
                    break;
                case ACTION_BACK:
                    return;
                }
                menu.HideOptions(Data.Count > Offset+Size, Offset-Size >= 0);
            }
        }

        private void ViewItems() {
            int i = Offset + 1;
            int length = Data.Count - Offset;
            if (length > Size) length = Size;
            foreach(Contact contact in Data.GetRange(Offset, length)) {
                Console.Write($"{i++}. ");
                contact.View();
            }
        }
    }
}