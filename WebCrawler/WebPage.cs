namespace WebCrawler
{
    public class WebPage
    {
        public string Id { get; }

        public string Url { get; }
        public string Title { get; }

        public string Content { get; }

        public WebPage(string url, string title, string content)
        {
            Url = url;
            Title = title;
            Content = content;
            Id = Helper.CreateSHA512(Url);
        }
    }
}