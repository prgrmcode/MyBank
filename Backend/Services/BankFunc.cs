namespace Backend.Services;

public class BankFunc
{
    public static String RandomNumber(int len) {
        var randomNumber = new Random();
        String randomString = String.Empty;

        for (int i = 0; i < len; i++)
        {
            randomString = String.Concat(randomString, randomNumber.Next(10).ToString());

        }
        return randomString;
    }


}
