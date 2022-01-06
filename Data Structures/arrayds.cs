using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    
 
    public static int HighestHourglassSum(List<List<int>> arr)
    {
        List<int> resultadoDasSomas = new List<int>();
        int Soma =0;
        for(int x =0; x<4;x++){
            for(int y =0; y<4;y++){
                Console.WriteLine(arr.ElementAt(x).ElementAt(y)); 
                Soma =  arr.ElementAt(x).ElementAt(y) + arr.ElementAt(x).ElementAt(y+1) + arr.ElementAt(x).ElementAt(y+2)+  
                                                        arr.ElementAt(x+1).ElementAt(y+1)+
                        arr.ElementAt(x+2).ElementAt(y) + arr.ElementAt(x+2).ElementAt(y+1) + arr.ElementAt(x+2).ElementAt(y+2);                resultadoDasSomas.Add(Soma);
            }
        }
        return resultadoDasSomas.Max();
    }

   

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.HighestHourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
