using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class BankAccount
    {

        private double _amount;
        private string _name;
        private int _agencia;
        private int _conta;

        public BankAccount(String name, int agencia, int conta)
        {
            this._name = name;
            this._agencia = agencia;
            this._conta = conta;
            this._amount = 0.0;
        }


        public Boolean checkAmountIsOk(double amount)
        {
            if (!(amount > 0.0))
            {
                return false;
                throw new ArgumentException("A quantia deve ser maior do que R$ 0.0");
            }

            return true;
        }

        public Boolean deposit(double amount)
        {
            if (checkAmountIsOk(amount))
            {
                this._amount += amount;
                return true;
            }

            return false;
        }

        public Boolean withdraw(double amount)
        {
            if (checkAmountIsOk(amount))
            {
                if (this._amount >= amount)
                {
                    this._amount -= amount;
                    return true;
                }
                throw new ArgumentException("Saldo insuficiente");

            }

            return false;
        }

        public void transfer(double amount, BankAccount account)
        {
            withdraw(amount);
            account.deposit(amount);
        }

        public Double getAmount()
        {
            return this._amount;
        }

        public String getOwner()
        {
            return this._name;
        }


    }
}
