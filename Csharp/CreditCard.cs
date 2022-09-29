using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Csharp{
            
    internal class CreditCard
    {
        public static long CardNumber { get; private set; } = 0;
        public string NameOfTheOwner { get;private set; }
        public DateTime Validity { get; private set; }
        private int? _pinCode;
        private int _pinCodeError = 3;
        public double CreditLimit { get; private set; }
        public double Balance { get; private set; }
        

        public CreditCard(string firstName,string lastName, string middlName)
        {
            CardNumber++;
            NameOfTheOwner = middlName + " " + firstName + " " + lastName;
            Validity = DateTime.Now.AddYears(3);
            _pinCode = 1111;
            CreditLimit = 10000;
            Balance = CreditLimit;
        }

        public string Refill(int pinCode, double money) //Поповнення кaрти
        {
            NotCorrectMoney(money);
            if (pinCode==_pinCode)
            {
                Balance += money;                                
            }            
            else
            {
                PinCodError();
            }
            return $"Ваш рахунок успішно поповнено! \n\t\t{Show()}";
        }
        public string withdrawalOfFunds(int pinCode, double money) //Зняття коштів з карти
        {
            NotCorrectMoney(money);
            if (pinCode == _pinCode && money <= Balance)
            {
                Balance -= money;                                
            }
            else if(pinCode == _pinCode && money > Balance)
            {
                throw new MyExceptionCreditCart($"На вашому рахунку не достатньо коштів! \n\t\t{Show()}");
            }
            else
            {
                PinCodError();
            }
            return $"\n\t\tУспішне зняття коштів! \n\t\t{Show()}";
        }
        private void NotCorrectMoney(double money)
        {
            if (money < 0)
            {
                throw new MyExceptionCreditCart("Не корректно введена сума!");
            }
        }
        private void PinCodError()
        {
            _pinCodeError--;
            if (_pinCodeError == 0 || _pinCode==null)
            {
                _pinCode=null;
                throw new MyExceptionCreditCart("\tКарту заблоковано! Зверніться до найближчого відділення банку!");
            }
            else
            {
                throw new MyExceptionCreditCart("\tНе вірний пiн-код!!!");
            }
        }
        public string AlterationPinCod() // Зміна пін-коду
        {
            Console.Write($"\tВведіть ваш поточний пін-код: ");            
            if (_pinCode==int.Parse(Console.ReadLine()))
            {
                Console.Write($"\tВведіть новий пін-код: ");
                int newPin = Convert.ToInt32(Console.ReadLine());
                if (newPin<=9999)
                {
                    _pinCode = newPin;
                }
                else
                {
                    throw new MyExceptionCreditCart("Не корректно заданий пін-код!");
                }                
            }
            else
            {
                PinCodError();
            }
            return $"Ваш пін-код успішно змінено!";
        }
        public string StartCreditMoney(double money) // Відстеження початку використання кредитних коштів
        {
            if (Balance>=CreditLimit && (Balance - money)<CreditLimit)
            {
               return $"\n\t\tУвага! Старт використання кредитних коштів";
            }
            return " ";
        }
        private string Show()
        {
            return String.Format("Номер карти: {0:D16}", CardNumber) +
                   "\n\t\tВласник: " + NameOfTheOwner+
                   "\n\t\tКредитний ліміт: "+CreditLimit+
                   "\n\t\tБаланс: "+Balance;
        } 
    }
}
