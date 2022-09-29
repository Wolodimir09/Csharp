using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
            /*Завдання 3
        Створіть клас «Кредитна картка». Клас повинен містити:
        ■ Номер картки;            
        ■ ПІБ власника;
        ■ Термін дії карти;
        ■ PIN;
        ■ Кредитний ліміт;
        ■ Сума грошей.
        Створіть потрібний набір способів класу. Реалізуйте
        події для наступних ситуацій:
        ■ Поповнення рахунку;
        ■ Витрата коштів з рахунку;
        ■ Старт використання кредитних коштів;
        ■ Досягнення ліміту заданої суми грошей;
        ■ Зміна PIN.*/
    internal class CreditCard
    {
        public static long CardNumber { get; private set; } = 0;
        public string NameOfTheOwner { get;private set; }
        public DateTime Validity { get; private set; }
        private int _pinCode;
        private int _pinCodeError = 3;
        public double CreditLimit { get; private set; }
        public double Balance { get; private set; }

        private Random rand = new Random();
        public CreditCard(string firstName,string lastName, string middlName)
        {
            CardNumber++;
            NameOfTheOwner = middlName + " " + firstName + " " + lastName;
            Validity = DateTime.Now.AddYears(3);
            _pinCode = rand.Next(1, 9999);
            CreditLimit = 10000;
            Balance = CreditLimit;
        }

        public void Refill(int pinCode, double money)
        {
            if (pinCode==_pinCode)
            {
                Balance += money;
                _pinCodeError = 3;
            }
            else
            {
                _pinCodeError--;
                if (_pinCodeError==0)
                {
                   new throw MyException("Карту заблоковано! Зверніться до найближчого відділення банку!!!")
                }
            }
        }




        

    }
}
