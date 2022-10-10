﻿namespace UserRegistrationForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidationForm patternValidation = new ValidationForm();
            Console.WriteLine("Enter The First Name: ");
            string firstname = Console.ReadLine();
            patternValidation.ValidationFirstName(firstname);

            Console.WriteLine("Enter The Last Name: ");
            string lastname = Console.ReadLine();
            patternValidation.ValidationLastName(lastname);

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            patternValidation.ValidationEmail(email);

            Console.WriteLine("Enter PhoneNumber: ");
            string phonenumber = Console.ReadLine();
            patternValidation.ValidationPhoneNumber(phonenumber);

            Console.WriteLine("Enter password 8 characters");
            string password = Console.ReadLine();
            patternValidation.ValidationPassword(password);
        }

    }
    }
