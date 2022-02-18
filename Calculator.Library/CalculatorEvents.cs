using System;

namespace Calculator.Library
{
    public class CalculatorEvents
    {
        //Addition Task
        public int Addition(int x,int y)
        {
            return x + y; //returns added result
        }
        //Subtraction Task
        public int Subtraction(int x,int y)
        {
            return x - y; //returns subtracted result            
        }
        //Multiplication Task
        public int Multiplication(int x,int y)
        {
            return x * y; //returns multiplication result 
        }
        //Division Task
        public int Division(int x,int y)
        {
            return x / y; //returns division result
        }
    }
}
