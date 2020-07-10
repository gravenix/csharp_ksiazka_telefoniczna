using System;
using System.Collections.Generic;

namespace App.Menu {
    public abstract class AbstractMenu {
        private const int NO_SELECT = 0xFFFFFF;
        protected List<MenuItem> MenuOptions = new List<MenuItem>();

        /// <summary>Odpytuje uzytkownika, dopoki nie otrzyma poprawnej odpowiedzi</summary>
        /// <param name="clear">czysci konsole po kliknieciu klawisza</param>
        /// <param name="redisplay">wyswietla opcje tylko raz</param>
        /// <returns>wartość, którą wybrał użytkownik</returns>
        public int Ask(bool clear = true, bool redisplay = true) {
            int selected = NO_SELECT;
            if (!redisplay) DisplayAllOptions();
            while (!MenuOptions.Exists(item => item.Number == selected)) {
                if(redisplay) DisplayAllOptions();
                try {
                    selected = Int32.Parse(Console.ReadKey(true).KeyChar.ToString());
                    if(clear) Console.Clear();
                } catch (FormatException) {
                    if (clear) Console.Clear();
                    else Console.Write("\r");
                    Console.Write("Proszę podać poprawną liczbę!");
                }
            }
            return selected;
        }
        private void DisplayAllOptions() {
            foreach (MenuItem item in MenuOptions) {
                item.DisplayOption();
            }
        }
    }
}