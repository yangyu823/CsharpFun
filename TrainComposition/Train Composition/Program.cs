using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Composition
{
    public class TrainComposition
    {
        private LinkedList<int> tree;

        public TrainComposition()
        {
            tree = new LinkedList<int>();
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            tree.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            tree.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            var x = tree.First.Value;
            tree.RemoveFirst();
            return x;
        }

        public int DetachWagonFromRight()
        {
            var x = tree.Last.Value;
            tree.RemoveLast();
            return x;
        }

        public static void Main(string[] args)
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13
            Console.ReadKey();
        }
    }
}
