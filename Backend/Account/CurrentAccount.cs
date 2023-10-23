using System.Text.Json;
using Backend.Cards;
using Backend.Services;

namespace Backend.Accounts;

public class CurrentAccount : Account
{
    public List<BankCard> BankCards { get; set; } = new List<BankCard>();
    public CurrentAccount()
    {
        AccountNumber = BankFunc.RandomNumber(10);
    }

    public void AddBankCard(BankCard _bankCard) {
        if (!BankCards.Contains(_bankCard) && Customers.Contains(_bankCard.Customer))
        {
            BankCards.Add(_bankCard);
            Cards.Add(_bankCard);
            Console.WriteLine($"Bank Card added to account: {this.ToString()}");
        }
        else
        {
            Console.WriteLine($"Bank Card is already existing in account");
        }
    }

    public void RemoveBankCard(BankCard _bankCard) {
        if (BankCards.Contains(_bankCard))
        {
            BankCards.Remove(_bankCard);
            Cards.Remove(_bankCard);
            Console.WriteLine($"Bank Card removed from account: {this.ToString()}");
        }
        else
        {
            Console.WriteLine($"Bank Card is not existing in account");
        }
    }

    public void WithdrawMoney(int amount) {
        if (Balance >= amount)
        {
            Balance -= amount;
        } else
        {
            Console.WriteLine($"Not enough money in your account: {Balance}");
        }
        
    }

    public void DepositMoney(int amount) {
        Balance += amount;
        Console.WriteLine($"Money deposited to your account: {Balance}");
    }

    

}
