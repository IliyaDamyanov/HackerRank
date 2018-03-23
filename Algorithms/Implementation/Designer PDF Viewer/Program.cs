using System;

namespace Designer_PDF_Viewer
{
    public class Program
    {
        static int designerPdfViewer(int[] h, string word)
        {
            // Complete this function
            int maxHeight = 0;
            int finalValue = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (h[word[i]-97]>maxHeight)
                {
                    maxHeight = h[word[i] - 97];
                }
            }
            finalValue = maxHeight * 1 * word.Length;
            return finalValue;
        }

        static void Main(String[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            int result = designerPdfViewer(h, word);
            Console.WriteLine(result);
        }
    }
}
