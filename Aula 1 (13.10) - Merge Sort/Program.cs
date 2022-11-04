using System;

// ctrl+k+c comenta tudo e ctrl+; descomenta
// dotnet new console //iniciar a usar C#
// dotnet new --list // mostra templates disponíveis
// dotnet clean // tira as compilações
// dotnet build //compila sem rodar
// dotnet run //compila e roda
// clear // limpa o console

// char c = 'a'; // para saber o maior valor possível = short.MaxValue
// byte b = 255; // sem sinal e se colocar s (signed) na frente coloca sinal
// short s = 32767;
// int i = 2147483647;
// long l = 9223372036854775807; // se colocar u (unsigned) na frente tira o sinal, aumentando um pouco do quanto salva "ulong"
// l = (int)(l); // forçar mudança de váriavel, se não der para transformar dá overflow, transformando-o no valor mínimo, checked força erro se der overflow
// bool b1 = true;
// bool b2 = false;
// float f = 2f; // tem que colocar o fe atras para indicar que é float
// double d = 2.5;
// double d1 = double.NegativeInfinity;
// double d2 = double.Epsilon; // menor valor positivo
// decimal m = 5.0m; // aceita números muito pequenos (para juros)
// object obj = s; // aceita tudo
// dynamic dy = 8; // váriavel igual do python
// dy = "Olá, mundo!";
// var x = 7; // ele descobre o tipo, ele identifica que 7 é int
// int[] arr = new int[10]; // cria um vetor de tamanho 10
// arr[0] = 4;
// arr[arr.Length - 1] = 6;
// int? y = null;
// Console.WriteLine(y ?? 7); // se y for nulo, coloque 7


// Console.WriteLine("Hello, World!");

// ====================================================================================

// using System;

// int i = 3;
// if (i < 10) {
//     Console.WriteLine(i);
// }
// else if (i < 15) {
//     Console.WriteLine("Muito Forte");
// }
// else {
//     Console.WriteLine("...");
// }

// switch (i) {
//     case 3:
//         Console.WriteLine(3);
//         goto case 5;
//     case 4:
//         Console.WriteLine(4);
//         break;
//     case 5:
//         Console.WriteLine("Bom dia");
//         break;
//     default:
//         Console.WriteLine("Não sei");
//         break;
// }

// for (int i = 0; i < 10; i++) {
//     Console.WriteLine("Oi!");
// }

// while (i < 10) {
//     Console.WriteLine("oi");
//     i++;
// }

// int[] arr = new int[100];
// for(int i = 0; i < arr.Length; i++)
// {
//     arr[i] = 1;
// }
// foreach (int n in arr)
// {
//     Console.WriteLine(n)
// }

// ====================================================================================

using System;

int[] arr = new int []
{ 8, 4, 2, 3, 9, 12, 11, 1 };

mergesort(arr);
foreach(var x in arr)
{
    Console.Write($"{x},");
}

void mergesort(int[] arr)
{
    int e = arr.Length;
    int[] arraux = new int[e];
    mergesortrec(arr, arraux, 0, e);
}

void mergesortrec(int[] arr, int[] arraux, int s, int e)
{
    if (e - s < 2)
        return;
    int p = (s + e) / 2;
    mergesortrec(arr, arraux, s, p);
    mergesortrec(arr, arraux, p, e);
    merge(arr, arraux, s, p, e);
}

void merge(
    int[] arr,
    int[] arraux,
    int s, int p, int e)
{
    int i = s, j = p, k = s;
    while (i < p && j < e)
    {
        if (arr[i] < arr[j])
        {
            arraux[k] = arr[i];
            i++;
            k++;
        }
        else
        {
            arraux[k] = arr[j];
            j++;
            k++;
        }
    }
    while (i < p)
    {
        arraux[k] = arr[i];
        i++;
        k++;
    }
    while (j < e)
    {
        arraux[k] = arr[j];
        j++;
        k++;
    }

    for (int t = s; t < e; t++)
    {
        arr[t] = arraux[t];
    }
}