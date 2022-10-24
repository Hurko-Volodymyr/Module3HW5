namespace AsyncHelloWorld
{
    internal class Program
    {
        protected Program()
        {
        }

        protected static async Task Main(string[] args)
        {
            var fileService = new FileService();
            var helloWorld = await fileService.StringSummonerAsync();
            Console.WriteLine(helloWorld);
        }
    }
}