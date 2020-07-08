using System;
using App.Menu.Main;

namespace App {
    public class App {
        public App() {
            MainMenu menu = new MainMenu();
            Console.WriteLine(menu.Ask());
        }
    }
}