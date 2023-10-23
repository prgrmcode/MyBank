
using System.Text.Json;
using Backend.Services;

namespace Backend.Cards;

public class CreditCard : Card
{
    public String CvcCode { get; set; }
    public int Balance { get; set; }
    public CreditCard(Customer.Customer _customer) : base(_customer)  // The base keyword is used to call the constructor of the base class, which is Card in this case. This is known as invoking the base class constructor.
    {
        CvcCode = BankFunc.RandomNumber(3);
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

    public void RemoveCreditCard() {
        if (Balance == 0)
        {

            Console.WriteLine($"Credit Card removed from account: {this.ToString()}");
        }
        else
        {
            Console.WriteLine($"Credit Card is not existing in account");
        }
    }
}
