using System;

namespace App.Menu.Browser {
    public class BrowserMenu : AbstractMenu {
        public BrowserMenu(bool showNext, bool showPrev) {
            HideOptions(showNext, showPrev);
        }

        public void HideOptions(bool showNext, bool showPrev) {
            MenuOptions.Clear();
            if(showNext) MenuOptions.Add(new MenuItem(1, "Następne"));
            if(showPrev) MenuOptions.Add(new MenuItem(2, "Poprzednie"));
            MenuOptions.Add(new MenuItem(3, "Powrót"));
        }
    }
}