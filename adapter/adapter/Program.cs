using System;
using System.Collections.Generic;

namespace adapter
{

    public class Solution
    {
        public static IDictionary<string, string> countries = new Dictionary<string, string>();

        public static void Main(string[] args)
        {
            initCountries();
            IncomeData incomeData = new IncomeData("UA", "JavaRush Ltd.", "Ivan", "Ivanov", 38, 501234567);
            IncomeDataAdapter incomeDataAdapter = new IncomeDataAdapter(incomeData);

            Customer customer = new Customer(incomeDataAdapter.CompanyName, incomeDataAdapter.CountryName);
            Contact contact = new Contact(incomeDataAdapter.Name, incomeDataAdapter.PhoneNumber);

            Console.WriteLine("Income data: " + incomeData);
            Console.WriteLine("Customer: " + customer);
            Console.WriteLine("Contact: " + contact);
        }

        private static void initCountries()
        {
            countries["UA"] = "Ukraine";
            countries["RU"] = "Russia";
            countries["CA"] = "Canada";
        }

        public class IncomeDataAdapter : ICustomer, IContact
        {

            internal IncomeData incomeData;

            public IncomeDataAdapter(IncomeData incomeData)
            {
                this.incomeData = incomeData;
            }

            public virtual string Name
            {
                get
                {
                    return this.incomeData.ContactLastName + ", " + this.incomeData.ContactFirstName;
                }
            }

            public virtual string PhoneNumber
            {
                get
                {
                    string phoneNumber = "" + incomeData.PhoneNumber;

                    for (int i = phoneNumber.Length; i < 10; i++)
                    {
                        phoneNumber = "0" + phoneNumber;
                    }

                    return "+" + incomeData.CountryPhoneCode + "(" + phoneNumber.Substring(0, 3) + ")" + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6, 2) + "-" + phoneNumber.Substring(8, 2);
                }
            }

            public virtual string CompanyName
            {
                get
                {
                    return this.incomeData.Company;
                }
            }

            public virtual string CountryName
            {
                get
                {
                    return countries[this.incomeData.CountryCode];
                }
            }

        }

        public interface IIncomeData
        {
            string CountryCode { get; }
            string Company { get; }
            string ContactFirstName { get; }
            string ContactLastName { get; }
            int CountryPhoneCode { get; }
            int PhoneNumber { get; }
        }

        public interface ICustomer
        {
            string CompanyName { get; }
            string CountryName { get; }
        }

        public interface IContact
        {
            string Name { get; }
            string PhoneNumber { get; }
        }
    }


}