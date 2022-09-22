using System;


namespace CSHConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
		    {
			    Console.WriteLine("1.Multi Dimension array");
			    Console.WriteLine("2.Jagged array");
			    Console.WriteLine("3.Array demo");
			    Console.WriteLine("4.Testing Array");
			    Console.WriteLine("5.Exit");
			
			    Console.Write("Enter your choice : ");
	            int choice = Convert.ToInt32(Console.ReadLine());

	            if (choice == 5)
	                    break;
			
	            switch(choice)
			    {
				    case 1 : 
				       CShArrays.MultiDimArrays();
				       break;
				    case 2 : 
				       CShArrays.JaggedArraysDemo();
				       break;
				    case 3: 
				       CShArrays.ArraysDemo();
				       break;
				    case 4:
				       CShArrays.Test1BasedArray();
				       break;
				
			    }
		    }

           
        }
    }
}
