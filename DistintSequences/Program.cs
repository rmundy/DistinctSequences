namespace DistintSequences
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            using (var fs = File.Open(args[0], FileMode.Open, FileAccess.Read))
            {
                using (var bs = new BufferedStream(fs))
                {
                    using (var sr = new StreamReader(bs))
                    {
                        String line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            var split = line.Split(',');

                        }
                    }
                }
            }
        }
    }
}
