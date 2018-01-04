﻿using ProxyPattern.DynamicProxyForLogging.Interfaces;
using System;

namespace ProxyPattern.DynamicProxyForLogging
{
    public class BankAccount : IBankAccount
    {
        private int balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            balance += amount;

            Console.WriteLine($"Deposited ${amount}, balance is now {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;

                Console.WriteLine($"Withdrew ${amount}, balance is now {balance}");

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
