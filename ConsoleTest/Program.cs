// See https://aka.ms/new-console-template for more information
using Backend;
using Backend.Customer;
using Backend.Accounts;
using Backend.Cards;
using Backend.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System;


Console.WriteLine("Hello, World!");
Customer customer = new("kiki", "0567817821", new DateTime(1999, 01, 12));
// Customer customer2 = new();
Customer customer3 = new("riri", "06751245", new DateTime(2000, 11, 01));

// Write code that will create some instances (customers, accounts, Cards), Deposit and Withdraw some money from accounts and test the rest of your program.
Bank bank = new();
bank.AddCustomer(customer);
bank.AddCustomer(customer3);

// create instances of accounts and cards
CurrentAccount currentAccount = new();
SavingAccount savingAccount = new();
BankCard bankCard = new(customer);
BankCard bankCard2 = new(customer3);
CreditCard creditCard = new(customer);
CreditCard creditCard2 = new(customer3);

// add customers to accounts
bank.AddCustomerToAccount(currentAccount, customer);
bank.AddCustomerToAccount(currentAccount, customer3);
bank.AddCustomerToAccount(savingAccount, customer3);

// add cards to accounts
bank.AddBankCardToCurrentAccount(currentAccount, bankCard);
bank.AddBankCardToCurrentAccount(currentAccount, bankCard2);

// remove bank card from account
bank.RemoveBankCardFromCurrentAccount(currentAccount, bankCard2);
