using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Dependency_Inversion
{
    delegate void EventHandler(int first, int second);
    internal class PrimitiveCalculator
    {
        private event EventHandler EventCalculaor;
        public PrimitiveCalculator()
        {
            EventCalculaor = Handler.Add;
        }
        public void ChangeStrategy(char i)
        {
            switch (i) 
            {
                case '+':
                    EventCalculaor = Handler.Add;
                    break;
                case '-':
                    EventCalculaor = Handler.Subtract;
                    break;
                case '*':
                    EventCalculaor = Handler.Multiply;
                    break;
                case '/':
                    EventCalculaor = Handler.Divide;
                    break;

            }
        }

        public void PerformCalculation(int firstOperand,int secondOperand)
        {
            EventCalculaor?.Invoke(firstOperand, secondOperand);
        }
    }
}
