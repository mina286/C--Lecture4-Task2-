namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Menu Options :");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a Number in the list");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                string ChoiseUser = Console.ReadLine().ToUpper();

                switch (ChoiseUser)
                {
                    case "P":
                        if (Numbers.Count > 0)
                        {
                            Console.WriteLine($"The List is - [{string.Join(" ", Numbers)}]");
                        }
                        else
                        {
                            Console.WriteLine("[] - the list is empty");

                        }                      
                        break;

                    case "A":
                        Console.Write("Enter an integer to add : ");
                        int InputNumber = Convert.ToInt32(Console.ReadLine());
                        bool IsDuplicate = false;
                        for (int i = 0; i < Numbers.Count; i++)
                        {
                            if(InputNumber == Numbers[i])
                            {
                                Console.WriteLine($"{InputNumber} is already in the list");
                                IsDuplicate = true;
                                break;
                            }
                        }
                        if (!IsDuplicate)
                        {
                            Numbers.Add(InputNumber);
                            Console.WriteLine($"{InputNumber} added ");
                        }                   
                        break;

                    case "M":
                        if(Numbers.Count > 0)
                        {
                            int SumNumbers = 0;
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                SumNumbers += Numbers[i];
                            }
                            int CountNumbers = Numbers.Count;
                            int Mean = SumNumbers / CountNumbers;
                            Console.WriteLine($"Mean : {Mean}");
                            
                        }
                        else
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        break;

                    case "S":
                        if (Numbers.Count > 0)
                        {
                            int smallest = Numbers[0];
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                if (Numbers[i] < smallest)
                                {
                                    smallest = Numbers[i];
                                }

                            }
                            Console.WriteLine($"the smallest number is : {smallest}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }      
                        break;

                    case "L":

                        if (Numbers.Count > 0)
                        {
                            int largest = Numbers[0];
                            for (int i = 0; i < Numbers.Count; i++)
                            {
                                if (Numbers[i] > largest)
                                {
                                    largest = Numbers[i];
                                }

                            }
                            Console.WriteLine($"the largest number is : {largest}");
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        break;

                    case "F":                  
                        Console.Write($"Enter a number to found: ");
                        int InputNumberFound = Convert.ToInt32(Console.ReadLine());
                        bool IsFound = false;
                        for (int i = 0;i <Numbers.Count; i++)
                        {
                            if(InputNumberFound == Numbers[i])
                            {
                                
                                Console.WriteLine($"found at index: {i}");
                                IsFound = true;
                                break;
                            }
                        }
                        if (!IsFound)
                        {
                            Console.WriteLine($"{InputNumberFound} is not found in the list");

                        }                   
                        break;

                    case "C":
                        Numbers.Clear();
                        Console.WriteLine("List is cleared");
                        break;

                    case "Q":
                        Console.WriteLine("Goodbye");
                        return;
                    default:
                        Console.WriteLine("invalid choice, please try again.");
                        break;
                }
                
            }







        }
    }
}
