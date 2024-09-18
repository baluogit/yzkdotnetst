namespace asynctest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string filename = @"D:\study\C#\file\a.txt";
            await File.AppendAllTextAsync(filename, "hello");
            string s = File.ReadAllText(filename);
            //string s = await File.ReadAllTextAsync(filename);
            Console.WriteLine(s);
        }
    }
}
