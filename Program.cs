 using System;

namespace Girrafe
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                int secreteNum = 8;
                int guess = 0;
                int guessCount = 0;
                int guessLimit = 6;
                bool outOfGuess = false;

                Console.WriteLine("Type.1 for easy 6 guess: 2.for medium 4 guess: 3.for hard 3guess: ");
                guess = int.Parse(Console.ReadLine());

                if ( guess == 1)
                
                
                {
                    while (guess != secreteNum && !outOfGuess )
                    {
                        if (guessCount < guessLimit)
                        {
                            Console.Write("Guess from 1-10: ");
                            guess = int.Parse(Console.ReadLine());
                            guessCount++;
                        }
                        else
                        {
                            outOfGuess = true;
                        }   
                        if (guess > secreteNum) 
                        {
                            Console.Write("Way too high ");
                        }
                        else if( guess < secreteNum)
                        {
                            Console.Write("Way too low ");
                            
                        }
                    
                    }
                     if (outOfGuess)
                        {
                            Console.Write("You Loose");
                        
                        }
                        else
                        {
                            Console.Write("You win ");
                        }
                        
                    
                        
                } 
                
                secreteNum = 19;
                guessLimit = 4;
                   
                     if( guess == 2  )
                    {
                        while (guess != secreteNum && !outOfGuess)
                        {
                            if (guessCount < guessLimit)
                            {
                                Console.Write("Enter guess range from  1-20: ");
                                guess = int.Parse(Console.ReadLine());
                                guessCount++;
                            }
                            else
                            {
                                outOfGuess = true;
                            }
                            if (guess > secreteNum) 
                        {
                            Console.Write("Way too high ");
                        }
                        else if( guess < secreteNum)
                        {
                            Console.Write("Way too low ");
                            
                        }
                        }
                         if (outOfGuess)
                            {
                                Console.Write("Out of Guess");
                            }
                            else
                            {
                                Console.Write("you win ");
                            }
                    }
                      secreteNum = 35;
                      guessLimit = 3;
                   
                     if( guess == 3  )
                    {
                        while (guess != secreteNum && !outOfGuess)
                        {
                            if (guessCount < guessLimit)
                            {
                                Console.Write("Enter guess range from  1-50: ");
                                guess = int.Parse(Console.ReadLine());
                                guessCount++;
                            }
                            else
                            {
                                outOfGuess = true;
                            }
                            if (guess > secreteNum) 
                        {
                            Console.Write("Way too high ");
                        }
                        else if( guess < secreteNum)
                        {
                            Console.Write("Way too low ");
                            
                        }
                        }
                         if (outOfGuess)
                            {
                                Console.Write("Out of Guess");
                            }
                            else
                            {
                                Console.Write("You win ");
                            }
                           
                    }
                   
            }
        
        }

        
         
    }
}
