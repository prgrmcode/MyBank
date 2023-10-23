using System;
using System.Reflection;
using System.Text.Json;

namespace Backend.Customer;

public class Customer
{
    static int currentID = 0;
    public int Id { get; init; }
    public String? Name { get; set; }
    public String? Phone { get; set; }
    public DateTime? Birthday { get; set; }

    public Customer() {
        Id = currentID;
        currentID++; // increment the id each time for a new customer
        do
        {
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
        } while (Name == "");

        do
        {
            Console.WriteLine("Enter phone number:");
            Phone = Console.ReadLine();
        } while (Phone == "");

        do
        {
            try
            {
                Console.WriteLine("Enter your birthdate as dd/mm/yyyy:");
                Birthday = Convert.ToDateTime(Console.ReadLine());                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter the birtdate in correct format!");
                Birthday = null;
            }
            
        } while (Birthday == null);

        Console.WriteLine($"New Customer created: {this.ToJson()}");
    }

    public Customer(String _name, String _phone, DateTime _birthday)
    {
        Id = currentID;
        currentID++;
        Name = _name;
        Phone = _phone;
        Birthday = _birthday;

        Console.WriteLine($"New Customer created: {this.ToJson()}");        
    }

    public string ToJson()
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
