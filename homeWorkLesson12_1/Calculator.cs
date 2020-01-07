using System;

namespace homeWorkLesson12_1
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b; 
        }
        public double Div(int a, int b)
        {
            if (b != 0)
            {
                return a / (double)b;
            }
            else
            {
                throw new Exception("Попытка деления на ноль!!!");
            }    
        }
    }
}
