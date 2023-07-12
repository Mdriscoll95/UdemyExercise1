namespace UdemyExercise1;

class Program
{
    static void Main(string[] args)
    {
        string myName = "mike";
        Console.Write("please enter your name and press enter : ");
        myName = Console.ReadLine();
        string myNameUpperCase = string.Format("Upper case : {0}", myName.ToUpper());
        string myNameLowerCase = string.Format("Lower case : {0}", myName.ToLower());
        string myNameTrimmed = string.Format("Trimmed value : {0}", myName.Trim());
        string myNameSubString = string.Format("Substring Vaue :{0}", myName.Substring(0, 5));
        Console.WriteLine(myNameUpperCase);
        Console.WriteLine(myNameLowerCase);
        Console.WriteLine(myNameTrimmed);
        Console.WriteLine(myNameSubString);


        Console.ReadKey();
    }
}

