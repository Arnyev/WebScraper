using System;
using Reddit;

namespace reddit_scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            string appid = string.Empty;
            string refreshToken = string.Empty;
            var reddit = new RedditClient(appid, refreshToken);
        }
    }
}
