namespace CCC
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Utils.ArgumentParser.ParseFile(@"C:\Users\Franz\Documents\input-level2.txt");



            foreach (var l in list)
            {
                foreach(var d in l)
                    System.Console.WriteLine(string.Format("{0} - {1}", d.Key, d.Value));
                System.Console.WriteLine("----");
            }
            System.Console.ReadLine();
        }
    }
}
