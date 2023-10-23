using System.Text.Json;
using Backend.Customer;
using Backend.Services;

namespace Backend.Cards;

public class Card
{
    public String CardNumber { get; set; }
    public String Pin { get; set; }

    public Customer.Customer Customer { get; init; }

    public Card (Customer.Customer _customer) {
        Customer = _customer;
        string v = BankFunc.RandomNumber(8);
        CardNumber = v;

    }


    public string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true, // Format the JSON for readability
            };

            // Serialize the current instance to JSON
            string json = JsonSerializer.Serialize(this, options);

            return json;
        }


}
