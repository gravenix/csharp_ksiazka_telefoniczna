using System;
using System.Collections.Generic;

namespace App.Menu {
    public abstract class AbstractMenu {
        private const int NO_SELECT = 0xFFFFFF;
        protected List<MenuItem> MenuOptions = new List<MenuItem>();
        public int Ask() {
            int selected = NO_SELECT;
            while (!MenuOptions.Exists(item => item.Number == selected)) {
                DisplayAllOptions();
                try {
                    selected = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                } catch (FormatException) {
                    Console.Clear();
                    Console.WriteLine("Proszę podać poprawną liczbę!");
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