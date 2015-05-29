using System;

namespace Chapter3
{	
	class ExecuteProgram{
		static void Main(string[] args){
            int [] scores = new int [11];
            for (int i = 0; i < scores.Length; i++){
                scores[i] = i;
            }
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Element {0:#0} is: {1:#0}", i, scores[i]);
            }
            Console.ReadLine();
        }
	}
			
		
		
		 
}
