using System;
using App.Menu.Main;

namespace App {
    public class App {
        public App() {
            MainMenu menu = new MainMenu();
            while (true) {
                int action = menu.Ask();
                switch (action) {
                case 4:
                    Environment.Exit(0);
                    break;
                }
            }
        }
    }
}