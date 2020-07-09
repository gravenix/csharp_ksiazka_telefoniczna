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
    }
}