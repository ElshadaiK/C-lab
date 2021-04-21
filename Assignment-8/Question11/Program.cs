using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char[] arr1;
            char ch;
            int i,j,l;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();	
            l=str.Length;
            arr1 = str.ToCharArray(0, l);

            for(i=1;i<l;i++)
                for(j=0;j<l-i;j++)
                
                if(arr1[j]>arr1[j+1])
                {
                ch=arr1[j];
                arr1[j] = arr1[j+1];
                arr1[j+1]=ch;
                }
            Console.Write("After sorting: \n");
                foreach (char c in arr1)
                { 
                    ch=c;
                    Console.Write("{0} ",ch);
                }
        }
    }
}
