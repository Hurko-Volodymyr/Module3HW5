namespace AsyncHelloWorld
{
    internal class FileService
    {
        private readonly string _helloPath = "Hello.txt";
        private readonly string _worldPath = "World.txt";
        public async Task<string> ReaderAsync(string path)
        {
            using StreamReader reader = new StreamReader(path);
            string text = await reader.ReadToEndAsync();
            return text;
        }

        public async Task<string> StringSummonerAsync()
        {
            string first = await ReaderAsync(_helloPath);
            string second = await ReaderAsync(_worldPath);
            string result = $"{first} {second}!";
            return result;
        }
    }
}
