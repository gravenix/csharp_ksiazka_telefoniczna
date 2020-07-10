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
                Console.Clear();
                ViewItems();
                Console.WriteLine();
                int action = menu.Ask(false, false);
                switch (action) {
                case ACTION_NEXT:
                    if(IsNext()) Offset += Size;
                    break;
                case ACTION_PREV: 
                    if(IsPrev()) Offset -= Size;
                    break;
                case ACTION_BACK:
                    Console.Clear();
                    return;
                }
                menu.HideOptions(IsNext(), IsPrev());
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

        private bool IsNext() => Offset + Size < Data.Count;
        private bool IsPrev() => Offset - Size >= 0;
    }
}