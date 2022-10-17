using System;

int[] bin = new int[]
{0, 0, 0, 0, 0, 0, 0, 0};
int v1 = 127;
int v2 = 16;
int soma = 0;

int BintoDec(int[] bin, int soma)
{
    for (int a = 0; a < 8;a++)
    {
        if (bin[a] == 1)
        {
            soma += (int)(Math.Pow(2, a));
        }
    }
    Console.WriteLine(soma);
    return soma;
}

void ConvertBin(int[] bin, int v1, int v2)
{
    
    v1 = v1/16;
    v2 = v2/16;

    for (int a = 3; a > -1; a--) 
    {
        bin[a] = v1 % 2;
        v1 = v1/2;
    }
    for (int a = 7; a > 3; a--) 
    {
        bin[a] = v2 % 2;
        v2 = v2/2;
    }
    foreach(var x in bin)
    {
        Console.Write(x);
    }
    soma = BintoDec(bin, soma);
    RevertBin(soma);
}

void RevertBin(int num)
{
    byte binr1 = (byte)(num >> 4 << 4);
    byte binr2 = (byte)(num << 4);
    Console.WriteLine(binr1);
    Console.WriteLine(binr2);
}

var s = DateTime.Now;
ConvertBin(bin, v1, v2);
var e = DateTime.Now;

Console.Write("Tempo" + (e - s).TotalMilliseconds);