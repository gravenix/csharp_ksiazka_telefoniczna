using System;

namespace App.Forms {
    public class ChooseFileForm : AbstractForm<string> {
        public ChooseFileForm() {
            FormItems.Add(new FormItem<string>("filename", "Podaj nazwę pliku: "));
        }
        public string Get() {
            FillForm();
            return FormItems[0].Value;
        }
    }
}