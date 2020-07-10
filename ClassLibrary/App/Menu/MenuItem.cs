using System;

namespace App.Menu {
    public class MenuItem {
        public int Number{get;}
        public string Text{get;}
        public MenuItem(int id, string text) {
            Number = id;
            Text = text;
        }
        public void DisplayOption() {
            Console.WriteLine($"[{Number}] {Text}");
        }
    }
}