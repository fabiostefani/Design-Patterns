using System;

namespace fabiostefani.io.DesignPatterns.Command
{
    public class Calculator
    {
        private int _curr;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _curr += operand;
                    break;
                case '-':
                    _curr -= operand;
                    break;
                case '*':
                    _curr *= operand;
                    break;
                case '/':
                    _curr /= operand;
                    break;
                default: throw new ArgumentException("@operator");
            }
            Console.WriteLine($"Valor atual = {_curr,3} (dado {@operator} {operand}");
        }
    }
}
