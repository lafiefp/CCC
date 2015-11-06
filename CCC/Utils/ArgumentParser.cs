using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CCC.Utils
{
    class ArgumentParser
    {
        public static List<Dictionary<string, object>> ParseFile(string filename)
        {
            var lines = File.ReadAllLines(filename);
            var list = new List<Dictionary<string, object>>();

            foreach(var line in lines)
            {
                var dict = new Dictionary<string,object>();

                var args = line.Split(' ');
                for (var i = 1; i < args.Length; i++)
                {
                    var parts = args[i].Split('=');
                    if (parts.Length > 1)
                        dict.Add(parts[0], parts[1]);
                }

                list.Add(dict);
            }
            return list;
        }



    }
}
