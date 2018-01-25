using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Exercise_Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        
           


            {
                string command = Console.ReadLine();
            long result = 0;
            while (command != "END")
                {
                    string[] codeArgs = command.Split(' ');

                   
                    switch (codeArgs[0])
                    {
                        case "INC":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                result = ++operandOne;
                                break;
                            }
                        case "DEC":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                result= --operandOne;
                                break;
                            }
                        case "ADD":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                long operandTwo = long.Parse(codeArgs[2]);
                                result = (long)operandOne + operandTwo;
                                break;
                            }
                        case "MLA":
                            {
                                long operandOne = long.Parse(codeArgs[1]);
                                long operandTwo = long.Parse(codeArgs[2]);
                                result = (long)(operandOne) *(long)(operandTwo);
                                break;
                            }
                    }
               
               command = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
        }
    }
    

