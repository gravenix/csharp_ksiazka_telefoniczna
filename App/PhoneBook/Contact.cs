using System;

namespace App.PhoneBook {
    public struct Contact {
        public enum SEX{man, woman}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public SEX Sex{get; set;}
        public string PhoneNumber{get; set;}
    }
}