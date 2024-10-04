namespace ThreadStartPro
{
  class Program
  {
    static void WriteLine()
    {
      while (true)
      {
        Console.WriteLine(new string(' ', 20) + "hay");
      }
    }
    public static void Main(string[] args)
    {
      ThreadStart writeLine = new ThreadStart(WriteLine);
      Thread thread = new Thread(writeLine);
      thread.Start();

      while (true)
      {
        Console.WriteLine("Hello");
      }
    }
  }
}
