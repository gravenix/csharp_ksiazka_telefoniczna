using System;
using System.Collections.Generic;

namespace App.Forms {
    public class SelectOneForm : AbstractForm<int> {
        public SelectOneForm(){
            FormItems.Add(new FormItem<int>("select", "Podaj numer kontaktu do usunięcia: "));
        }
        public int Get() {
            FillForm();
            return GetValues().GetValueOrDefault("select");
        }
    }
}