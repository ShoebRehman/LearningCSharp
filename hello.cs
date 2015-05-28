using System;
namespace AreaApplication
{
   class Rectangle
   {
		  double length;
		  double width;
		  
		  public void getDimensions(){
			  
              Console.WriteLine("Please input the length of the rectangle");
              do{
                  length = double.Parse(Console.ReadLine());
                  if (length < 0)
                  {
                      Console.WriteLine("Your input is a non-positive integer. Please try again.");
                  }
              } while (length < 0);

			  Console.WriteLine("Please input the width of the rectangle");
              do
              {
                  width = double.Parse(Console.ReadLine());
                  if (width < 0)
                  {
                      Console.WriteLine("Your input is a non-positive integer. Please try again.");
                  }
              } while (width < 0);
              width = double.Parse(Console.ReadLine());
			  return;
		  }
		  public double returnArea(){
			  return length*width;
			  }
		public void DisplayValues(){
			Console.WriteLine("The Length is: " + length);
			Console.WriteLine("The Width is: " + width);
			Console.WriteLine("The Area of the rectangle is: {0}", returnArea());
			return;
		}
		public Rectangle(double l, double w){ //Constructor Practice, takes length and width
			length = l;
			width = w;
		}
		public Rectangle(){}
	}
	
	class ExecuteProgram{
		static void Main(string[] args){
			Console.WriteLine("Welcome to my program!\nWould you like to use the constructor or no?");
			char ans;

			ans = char.Parse(Console.ReadLine());
			
			if(ans != 'y'){
				//Console.WriteLine("Calls function to receive dimensions for area calculation");
				Rectangle r = new Rectangle();
				r.getDimensions();
				r.DisplayValues();
			}
			if(ans == 'y'){
				//Console.WriteLine("Receives user input and then initializes class object through constructor");
				double l, w;
                Console.WriteLine("Please enter the Length");
                do
                {
                    l = double.Parse(Console.ReadLine());
                    if (l < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (l < 0);
				Console.WriteLine("Please enter the Width");
                do
                {
                    w = double.Parse(Console.ReadLine());
                    if (w < 0)
                    {
                        Console.WriteLine("Your input is a non-positive integer. Please try again.");
                    }
                } while (w < 0);
				Rectangle f = new Rectangle(l, w);
				f.DisplayValues();
			}
            Console.ReadLine();
        }
	}
			
		
		
		
		 
}
