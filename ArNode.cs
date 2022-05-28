using System;
using System.Collections.Generic;
using System.Text;

namespace dzArTree
{
    public class ArNode
    {
        private double info; // значение операнда в терминальном узле
        private char pr; // признак операции
        private ArNode left; // ссылка на левое поддерево
        private ArNode right; // ссылка на правое поддерево
        // свойства:
        public double Info
        {
            get { return info; }
            set { info = value; }
        }
        public char Pr
        {
            get { return pr; }
            set { pr = value; }
        }
        public ArNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public ArNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public ArNode() { }
        public ArNode(double info, char pr)
        { Info = info; Pr = pr; }

        public ArNode(double info, char pr, ArNode left, ArNode right)
        { Info = info; Pr = pr; Left = left; Right = right; }
    }

}

