namespace LBG.Client.Shell
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bs = new BootStrapper();
            bs.ConfigureContainer();
            bs.StartClient(args);
        }
    }
}
