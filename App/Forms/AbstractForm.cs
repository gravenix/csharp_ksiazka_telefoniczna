using System;
using System.Collections.Generic;
using System.Reflection;

namespace App.Forms {
    public abstract class AbstractForm<T> {
        protected List<FormItem<T>> FormItems = new List<FormItem<T>>();

        public void FillForm() {
            foreach(FormItem<T> item in FormItems){
                item.Ask();
            }
        }

        public Dictionary<string, T> GetValues() {
            Dictionary<string, T> values = new Dictionary<string, T>();
            foreach(FormItem<T> item in FormItems) {
                values.Add(item.Name, item.Value);
            }
            return values;
        }
    }
}