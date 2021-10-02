namespace Test
{
    public class Program
    {
        static void Main()
        {
            var test = new UnitTestFolder();
            UnitTestFolder.Initialize(null);
            test.YardiFolderDownload(); 
        }
    }
}