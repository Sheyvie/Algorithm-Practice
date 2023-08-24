
//create an algorith that reverses each word in a sentence
//the input to the function is a string
//output : a new string with each word reversed
//assumptions : no punctuation in the string , each word separated by spaces
//casing should remain the same


using System.Net.WebSockets;

public class Algorithm
{
    static string Reverse( string input)
    {
        if (string.IsNullOrEmpty(input)){
            return input;
        }

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new String(arr);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("My name is Abdallah and I am a developer"));
        Console.WriteLine(Reverse("I like going to the sandy beaches of Diani"));
        Console.WriteLine( Reverse("La vie est belle"));
    }
}