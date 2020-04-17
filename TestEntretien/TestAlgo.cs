using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TestEntretien
{
    public class TestAlgo
    {

        /// <summary>
        /// grouper les anagrammes 
        /// 10 min
        /// </summary>
        public static void RemoveDuplicate()
        {
            Console.WriteLine("RemoveDuplicate start");
            List<List<int>> datas = new List<List<int>>()
            {
                new List<int>() { 1,2,3,4,5,6,7,8,9},
                new List<int>() { 6,10,11,8,13,14,15,23},
                new List<int>() { 6,23,7,8},
                new List<int>() { 2,50,100,88},
            };

            List<int> all = new List<int>();
            foreach (var lst in datas)
            {
                all.AddRange(lst);
            }

            all = all.Distinct().ToList();

            for (int i = 0; i < datas.Count() ; i++)
            {
                var curlist = datas[i];
                var newList = new List<int>();
                foreach (var elt in curlist)
                {
                    if (!all.Any(e => e == elt))
                    {
                        newList.
                    }
                }
            }

            
        }

       


    }
}
