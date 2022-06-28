

using System;
class MainClass
{
    

    static void Main(string[] args)
    {
        
        //GetUpperBound nhận giới hạn kích thước đc chỉ định của mảng 

        Array objAuthorID = Array.CreateInstance(typeof(int), 3);
        Array objAuthorName = Array.CreateInstance(typeof(string), 3);
        Array objAddress = Array.CreateInstance(typeof(string), 3);
        Array objState = Array.CreateInstance(typeof(string), 3);

        string input = "";

        for (int i = 0; i < objAuthorName.Length; i++)
        {
            Console.WriteLine("Enter the ID of author :");
            input = Console.ReadLine();
            objAuthorID.SetValue(Convert.ToInt32(input), i);

            Console.WriteLine("Enter the Name of author");
            input= Console.ReadLine();
            objAuthorName.SetValue(input, i);

            Console.WriteLine("Enter the Address ");
            input = Console.ReadLine();
            objAddress.SetValue(input, i);

            Console.WriteLine("Enter the Static");
            input = Console.ReadLine();
            objState.SetValue(input, i);

            Console.WriteLine();
        }
        Console.WriteLine("\n Details of the author : \n");
        Console.WriteLine("Author ID \t Name \t\t Address\t\t State");

        for (int i = 0; i <= objAuthorName.GetUpperBound(0) ; i++)
        {
            Console.WriteLine(objAuthorID.GetValue(i) + "\t\t");
            Console.WriteLine(objAuthorName.GetValue(i) + "\t");
            Console.WriteLine(objAddress.GetValue(i) + "\t");
            Console.WriteLine(objState.GetValue(i) );
        }

        Array.Sort(objAuthorName);

        Console.WriteLine("\n Author names after sorting :\n");
        for (int i = 0; i <= objAuthorName.GetUpperBound(0) ; i++)
        {
            Console.WriteLine(objAuthorName.GetValue(i) + "\t");
        }

      


    }


}