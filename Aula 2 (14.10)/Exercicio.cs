
namespace Aula_02
{
    class Programa
    {
        static void Main(string[] args)
        {
            byte[] arr = new byte[10];
            byte[] compactado = compress(arr);    
            byte[] descompactado = decompress(compactado);
        }

        static byte[] decompress(byte[] arr)
        {
            byte[] newArr = new byte[arr.Length * 2];

            for(int i = 0, j = 0; i<arr.Length; i+=2, j++)
                newArr[j] = (byte) ((arr[i] >> 4 << 4));

            return newArr;
        }

        static byte[] compress(byte[] arr)
        {
            byte[] newArr = new byte[arr.Length/2];

            for(int i = 0, j = 0; i < arr.Length; i+=2, j++)
                newArr[j] = (byte) ((arr[i] >> 4 <<4) | (arr[i+1] >> 4));

            return newArr;
        }
            
    }
}