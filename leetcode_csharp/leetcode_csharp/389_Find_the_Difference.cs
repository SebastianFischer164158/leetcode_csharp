using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_csharp
{
    public static class ThreeightnineFindTheDifference
    {
        public static char FindTheDifference(string s, string t)
        {
            Hashtable charsTable = new Hashtable();
            
            foreach (var ch in s)
            {
                if (charsTable.ContainsKey(ch))
                {
                    charsTable[ch] = Convert.ToInt32(charsTable[ch]) + 1;
                }
                else
                {
                    charsTable.Add(ch,1);
                }
                
            }
            
            //PrintHashTable(charsTable);

            foreach (char cht in t)
            {
                if (charsTable.ContainsKey(cht))
                {
                    charsTable[cht] = Convert.ToInt32(charsTable[cht]) - 1;
                    if (Convert.ToInt32(charsTable[cht]) == -1)
                    {
                        return cht;
                    }
                }
                else
                {
                    return cht;
                }
            }
            return t[0];
        }

        private static void PrintHashTable(IDictionary hashtable)
        {
            foreach(char key in hashtable.Keys)
            {
                Console.WriteLine($"{key}: {hashtable[key]}");
            }
        }
    }
}