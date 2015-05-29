using System;
using System.Data;
using System.Data.SqlClient;

namespace AreaApplication
{
   class Rectangle
   {
		  double length;
		  double width;
		  
          SqlConnection myConnection = new SqlConnection("server = ")
		  public void getDimensions(){
			  
              Console.WriteLine("Please input the length of the rectangle");
              do{
                  length = Convert.ToDouble(Console.ReadLine());
                  if (length < 0)
                  {
                      Console.WriteLine("Your input is a non-positive integer. Please try again.");
                  }
              } while (length < 0);

			  Console.WriteLine("Please input the width of the rectangle");
              do
              {
                  width = Convert.ToDouble(Console.ReadLine());
                  if (width < 0)
                  {
                      Console.WriteLine("Your input is a non-positive integer. Please try again.");
                  }
              } while (width < 0);
			  return;
		  }

          public void setDimensions(double l, double w)
          {
              length = l;
              width = w;
          }

		  public double returnArea(){
			  return length*width;
			  }
		public void DisplayValues(){
			Console.WriteLine("The Length is: " + length);
			Console.WriteLine("The Width is: " + width);
			Console.WriteLine("The Area of the rectangle is: {0:#,##0.00}", returnArea());
			return;
		}
		public Rectangle(double l, double w){ //Constructor Practice, takes length and width
			length = l;
			width = w;
		}
		public Rectangle(){}//default constructor
	}
	
	class ExecuteProgram{
		static void Main(string[] args){
			double ans;

            Console.WriteLine("Welcome! Please pick one of the following:\n1. Use Constructor\n2. Use Set Dimensions Function\n3. Use Get Dimensions Function\n4. Exit\n");
            do{
                ans = Convert.ToInt32(Console.ReadLine());
                if(ans != 1 && ans != 2 && ans != 3 && ans != 4){
                    Console.WriteLine("Please enter a valid choice!");
                }
            } while(ans != 1 && ans != 2 && ans != 3 && ans != 4);

			if(ans == 1){
				//Console.WriteLine("Receives user input and then initializes class object through constructor");
				double l, w;
                Console.WriteLine("Please enter the Length");
                do
                {
                    l = Convert.ToDouble(Console.ReadLine());
                    if (l < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (l < 0);
				Console.WriteLine("Please enter the Width");
                do
                {
                    w = Convert.ToDouble(Console.ReadLine());
                    if (w < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (w < 0);
				Rectangle f = new Rectangle(l, w);
				f.DisplayValues();
			}
            if(ans == 2){
                Rectangle r = new Rectangle();
                double l, w;
                Console.WriteLine("Please enter the Length");
                do
                {
                    l = Convert.ToDouble(Console.ReadLine());
                    if (l < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (l < 0);
                Console.WriteLine("Please enter the Width");
                do
                {
                    w = Convert.ToDouble(Console.ReadLine());
                    if (w < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (w < 0);
                r.setDimensions(l, w);
                r.DisplayValues();
            }
            if(ans == 3){
				//Console.WriteLine("Calls function to receive dimensions for area calculation");
				Rectangle r = new Rectangle();
				r.getDimensions();
				r.DisplayValues();
			}

            if (ans == 4)
            {
                return;
            }
            Console.ReadLine();
            return;


        }
	}
			
		
		
		 
}
