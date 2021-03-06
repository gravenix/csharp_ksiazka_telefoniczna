using System;
using System.Threading;

namespace App.Utils {
    public static class Messages {
        private const int SLEEP_TIME = 1500;

        /// <summary>
        ///   Pokazuje komunikat
        /// </summary>
        /// <param name="text">komunikat do pokazania</param>
        public static void ShowMessage(string text) {
            Console.Clear();
            Console.WriteLine(text);
            Thread.Sleep(SLEEP_TIME);
            Console.Clear();
        }
    }
}