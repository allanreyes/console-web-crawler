namespace WebCrawler
{
    // Credit: https://github.com/thomas11/AzureSearchCrawler

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var serviceEndPoint = ""; // e.g. https://asdfasdfasdf.search.windows.net
            var indexName = "webpage";
            var adminApiKey = "";
            var rootUri = "https://yourwebsite.com";
            var maxPagesToIndex = 5000;
            var maxCrawlDepth = 60;

            var indexer = new AzureSearchIndexer(serviceEndPoint, indexName, adminApiKey, new TextExtractor());
            var crawler = new Crawler(indexer);
            await crawler.Crawl(rootUri, maxPagesToIndex, maxCrawlDepth);

        }
    }
}
