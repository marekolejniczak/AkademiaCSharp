﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class NormalContact : GeneralPersonalDetails
    {
        public uint PhoneNumber { get; set; }

        public NormalContact()
        {

        }

        public NormalContact(string name, string surname, string street, uint phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.PhoneNumber = phone;
        }
    }
}