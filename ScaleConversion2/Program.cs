using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleConversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "CDD#FGAB";
            //string con;
            string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<string> arr = new List<string>();
            int j = 0;
            for (int i = 0; i < key.Length; i++)
            {
                char c1 = key[i];
                char c2 = '.';
                if (i < key.Length - 1)
                {
                    c2 = key[i + 1];
                }
                arr.Add(key[i].ToString());
                //arr[j] = key[i].ToString();
                if (c2 == '#')
                {
                    arr[j] = arr[j] + c2;
                    i++;
                }
                j++;
            }
            foreach (string c in arr)
            {
                Console.WriteLine(c);
            }
            
             
            foreach (string c in arr)
            {
               // Console.WriteLine(c);
                if (!notes.Contains(c))
                {
                    Console.WriteLine(c + " not valid ");
                }
                else
                    Console.WriteLine(c + " valid ");
            }
            string c3 = arr[0];
            string c4 = "";
            int index=0;
            int ind = arr.IndexOf(c3);
            int[] ar = new int[12];
            string ss = "";// ind.ToString();
           // index = Array.IndexOf(notes, c3);
            for (int i= (arr.Count())-1; i>=0;i--)
            {
                //Console.WriteLine("i= "+i);
                c4 = arr[i];
                //ss = index.ToString();
                index = Array.IndexOf(notes,c4);
                //Console.WriteLine(index);
                if(i>0)
                {
                    //int t = ar[i-1];

                    ar[i] = index; //- ar[i - 1];
                   // Console.WriteLine(ar[i]);
                }
            }

            for(int i =ar.Length-1;i>=0;i--)
            {
                if (i > 0)
                {
                    ar[i] =ar[i]-  ar[i - 1];
                   // Console.WriteLine("i= " + i);
                   //Console.WriteLine(ar[i]);
                }
            }
            for(int i =0;i<arr.Count();i++)
            {
                Console.Write(ar[i]);
            }
        }
    }
}
