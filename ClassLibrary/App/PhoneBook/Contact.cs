using System;
using App.Interfaces;

namespace App.PhoneBook {
    public struct Contact : IViewable {
        public enum SEX{man, woman}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public SEX Sex{get; set;}
        public string PhoneNumber{get; set;}
        public void View() => Console.WriteLine($"{FirstName} {LastName} ({Sex}) -> {PhoneNumber}");
        public string Serialize() => $"{FirstName}|{LastName}|{Sex}|{PhoneNumber}";
        public static Contact Deserialize(string text) {
            String[] data = text.Split('|');
            Contact contact = new Contact();
            contact.FirstName = data[0];
            contact.LastName = data[1];
            contact.Sex = data[2] == "man" ? SEX.man : SEX.woman;
            contact.PhoneNumber = data[3];
            return contact;
        }
    }
}