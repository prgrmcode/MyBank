using Backend.Customer;

namespace Backend.Accounts;

public class SavingAccount : Account
{
    public String RandomNumber(int len) {
        var randomNumber = new Random();
        String randomString = "123";

        for (int i = 0; i < len-3; i++)
        {
            randomString = String.Concat(randomString, randomNumber.Next(10).ToString());

        }
        return randomString;
    }

    public SavingAccount()
    {
        AccountNumber = RandomNumber(10);
        
    }

    new public void AddCustomer(Customer.Customer _customer) {
        base.AddCustomer(_customer);
        if (IsAgeUnder12(_customer))
        {
            Balance += 50;

        }


    }

    public bool IsAgeUnder12(Customer.Customer _customer)
    {
        // Calculate the age by subtracting the birthdate from the current date
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - (_customer.Birthday?.Year ?? currentDate.Year);

        // Check if the age is less than 12
        return age < 12;
    }

}
