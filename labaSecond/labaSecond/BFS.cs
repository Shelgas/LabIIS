using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaSecond
{
    class BFS : ISubject
    {

        private List<IObserver> raid_list = new List<IObserver>();
        Graph graph = new Graph();

        public BFS()
        {


            graph.AddEdge(1, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);

            graph.AddEdge(2, 5);
            graph.AddEdge(2, 6);
            graph.AddEdge(4, 7);
            graph.AddEdge(4, 8);

            graph.AddEdge(5, 9);
            graph.AddEdge(5, 10);
            graph.AddEdge(7, 11);
            graph.AddEdge(7, 12);



           
        }

        public void Attach(IObserver observer)
        {
            raid_list.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            raid_list.Remove(observer);
        }

        public void Notify()
        {
            IIterator iterator = graph.GetIterator();
            while (iterator.HasMoveNext())
            {

                Console.WriteLine(iterator.Next());
                

                    foreach (var observer in raid_list)
                    {
                        observer.Update(observer);
                    }
                
            }

        }
    }
}
