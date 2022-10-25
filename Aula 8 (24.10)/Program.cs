using System.Collections.Generic;
using System;

List<int> list = new List<int>();
list.Add(10);
list.Add(11);
list.Add(12);
list.Add(13);
list.Add(14);
list.Add(15);

list.Skip(2).Take(3).ToStringList().Concat().Print();

// LinkedList<string> list = new LinkedList<string>();
// list.Add("teste");
// list.Add("lucas");
// list.Add("andre");
// list.Add("dALE");
// list.Add("CHAMA");

// for (int i=0; i < list.Count; i++)
// {
//     Console.WriteLine(list[i]);
// }

// public class LinkedList<T>
// {
//     private LinkedListNode<T> first = null;
//     private int count = 0;
//     public int Count => count;
//     public T this[int index]
//     {
//         get
//         {
//             if(first == null)
//                 throw new IndexOutOfRangeException();

//             var atual = first;
//             for (int i = 0; i < index; i++)
//             {
//                 if (atual.Next == null)
//                     throw new IndexOutOfRangeException();
                
//                 atual = atual.Next;
//             }
//             return atual.Value;
//         }
//         set
//         {
//             if(first == null)
//                 throw new IndexOutOfRangeException();

//             var atual = first;
//             for (int i = 0; i < index; i++)
//             {
//                 if (atual.Next == null)
//                     throw new IndexOutOfRangeException();
                
//                 atual = atual.Next;
//             }

//             atual.Value = value;
//         }
//     }

//     public void Add(T value)
//     {
//         if (first == null)
//         {
//             first = new LinkedListNode<T>(value);
//             first.Value = value;
//             count++;
//             return;
//         }
//         var atual = first;
//         while(atual.Next != null)
//             atual = atual.Next;
        

//         atual.Next = new LinkedListNode<T>();
//         atual.Next.Value = value;
//         count++;
//     }
// }

// public class LinkedListNode<T>
// {
//     public T Value { get; set; }
//     public LinkedListNode<T> Next { get; set; }


//     public LinkedListNode()
//     {

//     }

   
//     public LinkedListNode(T value)
//     {
//         this.Value = value;
//     }
// }

public static class MyExtensionMethods
{
    public static double Sqrt(this double x)
    {
        return Math.Sqrt(x);
    }
    public static void Print<T>(this T obj)
    {
        Console.WriteLine(obj);
    }
    public static List<T> Take<T>(this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < N && i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }
    public static List<T> Skip<T>(this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for (int i = N; i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }
    public static List<string> ToStringList<T>(this List<T> list)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < list.Count; i++)
        {
            result.Add(list[i]?.ToString() ?? "");
        }
        return result;
    }
    public static string Concat(this List<string> list)
    {
        string result = "";
        for (int i = 0; i < list.Count; i++)
        {
            result += list[i];
        }
        return result;
    }
}