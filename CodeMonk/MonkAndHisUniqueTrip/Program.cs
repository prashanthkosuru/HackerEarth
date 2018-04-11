using System;
using System.Collections.Generic;

namespace MonkAndHisUniqueTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int NoOfCities= Input1[0];
            int OneWayRoads = Input1[1];
            
            LinkedListNode<int>[] nodesArray;
            LinkedList<int> list = new LinkedList<int>();
            for(int i=0;i<NoOfCities;i++){
                int[] Input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                LinkedListNode<int> node = new LinkedListNode<int>();
                nodesArray[i]=node;
            }
            
            foreach(int node in list)
            {
                Console.WriteLine(list);
            }
        }
    }
}
