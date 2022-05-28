using System;

namespace dzArTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ArTree T = new ArTree();
            ArNode t1 = new ArNode(5, 'n', null, null);
            ArNode t2 = new ArNode(3, 'n', null, null);
            ArNode t3 = new ArNode(4, 'n', null, null);
            ArNode t4 = new ArNode(6, 'n', null, null);
            ArNode t5 = new ArNode(1, 'n', null, null);
            ArNode t6 = new ArNode(25, 'n', null, null);
            ArNode t7 = new ArNode(9, 'n', null, null);
            ArNode t8 = new ArNode(7, 'n', null, null);

            ArNode tt1 = new ArNode(0, '*', t1, t2);
            ArNode tt2 = new ArNode(0, '+', t3, t4);
            ArNode tt3 = new ArNode(0, '-', t5, t6);
            ArNode tt4 = new ArNode(0, '+', t8, t7);

            ArNode ttt1 = new ArNode(0, '/', tt1, tt2);
            ArNode ttt2 = new ArNode(0, '-', tt3, tt4);

            ArNode tttt1 = new ArNode(0, '-', ttt1, ttt2);

            // =41,5

            T.Root = tttt1;
            Console.WriteLine(T.Calculate(T.Root));
            Console.ReadLine();


        }
    }
}
