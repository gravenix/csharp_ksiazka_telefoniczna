using System;

namespace App.Forms {
    public class FormItem<T> {
        public string Text{get;}
        public T Value{get; set;}
        public string Name{get;}
        public FormItem(string name, string text) {
            Name = name;
            Text = text;
        }
        public T Ask() {
            while (true) {
                Console.WriteLine(Text);
                try {
                    T value = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
                    Value = value;
                    return value;
                } catch(InvalidCastException) {
                    Console.WriteLine("Niepoprawny Format!");
                } catch(FormatException) {
                    Console.WriteLine("Niepoprawny Format!");
                }
            }
        }
    }
}