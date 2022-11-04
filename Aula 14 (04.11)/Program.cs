
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //Tudo que fizemos ta aqui

// void ChameNVezesExemplo()
// {
//     ChameNVezes(Console.WriteLine, 10);

//     ChameNVezes(meuPrint, 2);

//     MeuDelegate func = delegate(string s)
//     {
//         Console.WriteLine("Função Anonima diz:" + s);
//     };
//     ChameNVezes(func, 5);

//     MeuDelegate func2 = s => Console.WriteLine("Lambda diz:" + s);
//     ChameNVezes(func2, 3);

//     ChameNVezes(s => Console.WriteLine("Lambda direto diz:" + s), 3);

//     void meuPrint(string s)
//     {
//         Console.WriteLine("Mensagem: " + s);
//     }
//     void ChameNVezes(MeuDelegate f, int n)
//     {
//         for (int i = 0; i < n; i++)
//             f("Olá Mundo");
//     }  
// }

Transformador vezes2 = n => n *= 2;
Transformador multiplicadopor3 = n => n*3; 

// int aoQuadrado(int i) // == i => i * i
// {
//     return i * i;
// }

// Transformador aoQuadrado = n => n*n;

// var array = new int[] { 1, 2, 3, 4, };
// foreach (var x in Transforme(array, multiplicadopor3))
// {
//     Console.WriteLine(x);
// }
// array = Transforme(array, aoQuadrado);

// foreach (var x in Transforme(array, i => i * i))
// {
//     Console.WriteLine(x);
// }
// array = Transforme(array, aoQuadrado);

// int[] Transforme(int[] entrada, Transformador t)
// {
//     for(int i=0;i<entrada.Count();i++)
//     {
//         entrada[i] = t(entrada[i]);
//     }
//     return entrada;
// }

// var x = array.Where(i => i > 4);

// void meuPrint(string s)
// {
//     Console.WriteLine("Mensagem: "+s);
// }
// void ChameNVezes(MeuDelegate f, int N)
// {
//     for (int i=0; i<N;i++)
//         f("Olá mundo");
// }

int[] TransformeGenerico(int[] entrada, Transformador2<int> t)
{
    int[] saida = new int[entrada.Length];
    for (int i = 0; i < saida.Length; i++)
        saida[i] = t(entrada[i]);
    return saida;
}

public delegate void MeuDelegate(string x);
public delegate T Transformador2<T>(T n);
public delegate R Transformador3<T, R>(T n);
public delegate int Transformador(int n);


// MeuDelegate print = Console.WriteLine;
// MeuDelegate1 sqrt = Math.Sqrt;
// var y = sqrt(9.0);
// print("PR");
// public delegate void MeuDelegate(string s); //usamos para mudar o comando padrão, nesse caso alguma função que recebe string e retorna void
// public delegate double MeuDelegate1(double x);

public static class MyExtensionMehods
{
    public static IEnumerable<R> Select<T, R>(
        this IEnumerable<T> coll, 
        Func<T, R> func) //Func = TransformadorGenerico2
    {
        var it = coll.GetEnumerator();
        while (it.MoveNext())
            yield return func(it.Current);
    }

    public static IEnumerable<T> Where<T>(
        this IEnumerable<T> coll,
        Func<T, bool> condition
    )
    {
        foreach(var x in coll)
        {
            if(condition(x))
            {
                yield return x;
            }
        }
    }

    public static int myMax<T>(
        this IEnumerable<T> coll,
        Func<T, int> func
    )
    {
        var it = coll.GetEnumerator();
        var maxi = int.MinValue;
        while (it.MoveNext())
        {
            if(func(it.Current)>maxi)
            {
                maxi = func(it.Current);
            }
        }
        return maxi;
    }

    public static double Avarage<T>(
        this IEnumerable<T> coll,
        Func<T, double> func
    )
        {
            var it = coll.GetEnumerator();
            var soma = 0;
            while(it.MoveNext())
            {
                soma += func(it.Current);
            }
        }

    public static IEnumerable<T> Skip<T>(this IEnumerable<T> coll, int N)
    {
        var it = coll.GetEnumerator();
        for(int i = 0; i < N && it.MoveNext(); i++);

        while (it.MoveNext())
            yield return it.Current;
    }

    public static IEnumerable<T> Take<T>(this IEnumerable<T> coll, int N)
    {
        var it = coll.GetEnumerator();
        for(int i = 0; i < N && it.MoveNext(); i++)
            yield return it.Current;            
    }

    public static IEnumerable<T> ToList<T>(this IEnumerable<T> coll)
    {
        List<T> list = new List<T>();

        var it = coll.GetEnumerator();
        while (it.MoveNext())
            list.Add(it.Current);

        return list;
    }

    public static int Count<T>(this IEnumerable<T> coll)
    {
        int count = 0;
        var it = coll.GetEnumerator();

        while(it .MoveNext())
            count++;

        return count;
    }

    public static T LastOrDefault<T>(this IEnumerable<T> coll)
    {
        int count = 0;
        var it = coll.GetEnumerator();
        while(it .MoveNext())
            count++;

        return count == 0 ? default(T) : it.Current;
    }

    public static IEnumerable<T> Append<T>(IEnumerable<T> coll, T item)
    {
        var it = coll.GetEnumerator();
        while(it .MoveNext())
            yield return it.Current;
        yield return item;
    }

    public static IEnumerable<T> Prepend<T>(this IEnumerable<T> coll, T item)
    {
        yield return item;

        foreach (var x in coll)
            yield return x;
    }

    public static T FirstOrDefault<T>(this IEnumerable<T> coll)
    {
        var it = coll.GetEnumerator();

        return it.MoveNext() ? it.Current : default(T);
    }

    public static T[] ToArray<T>(this IEnumerable<T> coll)
    {
        var it = coll.GetEnumerator();
        T[] list = new T[coll.Count()];
        int count = 0;

        while (it.MoveNext())
        {
            list[count] = it.Current;
            count++;
        }
        return list;
    }

    public static IEnumerable<string> Open(this string file)
    {
        var stream = new StreamReader(file);
        while(!stream.EndOfStream)
        {
            var line = stream.ReadLine();
            yield return line;
        }
        stream.Close();
    }

    public static IEnumerable<string[]> Split(this IEnumerable<string> coll)
    {
        foreach (var x in coll)
            yield return x.Split(";");
    }
}