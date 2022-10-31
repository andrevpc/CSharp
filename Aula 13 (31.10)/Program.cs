// var coll = exemplo("Trevisan");
// var it = coll.GetEnumerator();
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// Console.WriteLine(it.MoveNext());
// Console.WriteLine(it.Current);
// foreach(var x in coll)
// {
//     Console.WriteLine(x);
// }


// IEnumerable<string> exemplo(string parametroLegal)
// {
//     Console.WriteLine("Rodou 1");
//     yield return parametroLegal; //função congela até dar o movenext
//     Console.WriteLine("Rodou 2");
//     yield return "disse: ";
//     Console.WriteLine("Rodou 3");
//     yield return "Java";
//     Console.WriteLine("Rodou 4");
//     yield return " é ";
//     Console.WriteLine("Rodou 5");
//     yield return "Ruim!";
//     Console.WriteLine("Rodou 6");
// }

//////////////////////////////////////////////////////////////////////////

// var coll = infinity();

// foreach (var x in coll)
// {
//     Console.WriteLine(x);
// }

// IEnumerable<long> infinity()
// {
//     for (long i = 0; true; i++)
//         yield return i; //lista infinita
// }

// var file = open("LAB_PR_COV.csv");

// foreach(var line in file)
// {
//     Console.WriteLine(line);
// }

// IEnumerable<string> open(string file)
// {
//     var stream = new StreamReader(file);
    
//     while(!stream.EndOfStream)
//     {
//         var line = stream.ReadLine();
//         yield return line;
//     }

//     stream.Close();
// }

var coll = "LAB_PR_COV.csv"
    .Open()
    .Skip(1)
    .Take(1000)
    .ToList();

foreach (var x in coll)
{
    Console.WriteLine(x);
}

public static class MyExtensionMehods
{
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