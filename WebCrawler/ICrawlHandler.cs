using Abot2.Poco;

namespace WebCrawler
{
    public interface ICrawlHandler
    {
        Task PageCrawledAsync(CrawledPage page);

        Task CrawlFinishedAsync();
    }
}
