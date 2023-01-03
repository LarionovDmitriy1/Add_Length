using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Length;

public class AddsLength
{
    public static string[] AddLength(string str)
    {
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + ' ' + words[i].Length;
        }
        return words;
    }
}
