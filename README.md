# ErbiumCustomListProject
CustomList<T>.Operator- overload

The Operator- overload, takes in two parameters:
1)CustomList<T> one
2)CustomList<T> two

*Note that the parameters established are of type: generic giving us a custom return type.

The overload method creates a new list with all items from 1st parameter and a new list with all items from the second parameter. It then goes through each item in the first new list and compares them against each item in the second new list. If there are matches they are then removed from both new lists using Remove(). Once the comparisons have finished it then adds both new lists together with the remaining items using the operator+ overload.

class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list1.Add(2);
            list1.Add(1);
            list1.Add(8);
            list1.Add(12);
            list2.Add(12);
            list2.Add(3);
            list2.Add(2);
            list2.Add(4);
            CustomList<int> newList = new CustomList<int>();
            newList = list1 - list2;
            Console.WriteLine("newList: {0}", newList);
            Console.ReadLine();
        }
    }
//Output:
//1 8 3 4



 


