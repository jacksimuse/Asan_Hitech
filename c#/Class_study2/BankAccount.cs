using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Study2
{
    internal class BankAccount
    {
        private double money; // 캡슐화, private을 사용하여 외부에서 접근 불가하도록 데이터를 보호
        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    money += value; // 계좌에는 금액이 추가 될거기 때문
                }
                else
                {
                    money += value;
                }
            }
        }

        public string Name;
        public int Account;

        // 생성자
        public BankAccount(string name, int account)
        {
            Name = name;
            Account = account;
        }


        // 입금 메서드
        public string Deposit(double amount)
        {
            if (amount > 0)
            {
                money += amount;
            }

            return $"{amount}원이 입금되었습니다";
        }

        // 출금 메서드
        public string Withdraw(double amount)
        {
            string result = string.Empty; // ""

            if (amount > money)
            {
                result = $"출금 금액이 {amount}이므로 잔액보다 많습니다";
                return result ;
            }

            money -= amount;
            result = $"{amount}만큼 출금 되었습니다";

            return result ;
        }
    }
}
