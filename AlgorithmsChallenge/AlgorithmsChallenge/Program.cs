
//create an algorith that reverses each word in a sentence
//the input to the function is a string
//output : a new string with each word reversed
//assumptions : no punctuation in the string , each word separated by spaces
//casing should remain the same


using System.Linq;
using System.Text;

public class Algorithm
{

    static String ReverseWord(String input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder result = new StringBuilder();
        string[] arr = input.Split(" ");
        for (int  i=0; i < arr.Length; i++)
        {
            result.Append(Reverse1(arr[i]));

                if(i != arr.Length - 1) 
            {
                result.Append(" ");
            }
                
        }
        return result.ToString();
    }
    static string Reverse1( string input)
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
        //Console.WriteLine(Reverse1("My name is Abdallah and I am a developer"));
        //Console.WriteLine(Reverse1("I like going to the sandy beaches of Diani"));
        //Console.WriteLine( Reverse1("La vie est belle"));
        Console.WriteLine(ReverseWord("My name is Abdallah and I am a developer"));
        Console.WriteLine(ReverseWord("I like going to the sandy beaches of Diani"));
        Console.WriteLine(ReverseWord("La vie est belle"));
        Console.WriteLine(ReverseWord(null));
        Console.WriteLine(ReverseWord(" "));
    }
}