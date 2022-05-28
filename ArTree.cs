using System;
using System.Collections.Generic;
using System.Text;

namespace dzArTree
{
    public class ArTree
    {
        private ArNode root;
        public ArNode Root
        {
            get
            { return root; }
            set
            { root = value; }
        }
        public ArTree() // Конструктор
        {
            root = null;
        }
        // Методы:
        public double Calculate(ArNode root)
        {
            double result = 0;
            if (root.Pr == 'n') result = root.Info;
            else
            {
                double a = Calculate(root.Left);
                double b = Calculate(root.Right);
                switch (root.Pr)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        result = a / b;
                        break;
                }
            }
            return result;
        }
        
    }

    

    
}
