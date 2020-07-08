using System;
using System.Collections.Generic;

namespace App.Menu.Main {
    public class MainMenu : AbstractMenu {
        public MainMenu() {
            MenuOptions.Add(new MenuItem(1, "Dodaj Wpis"));
            MenuOptions.Add(new MenuItem(2, "Edytuj Wpis"));
            MenuOptions.Add(new MenuItem(3, "Usuń Wpis"));
            MenuOptions.Add(new MenuItem(4, "Wyjdź"));
        }
    }
}