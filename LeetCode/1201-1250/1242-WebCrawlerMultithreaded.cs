//-----------------------------------------------------------------------------
// Runtime: 368ms
// Memory Usage: 41.2 MB
// Link: https://leetcode.com/submissions/detail/367598201/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    /**
     * // This is the HtmlParser's API interface.
     * // You should not implement it, or speculate about its implementation
     * class HtmlParser {
     *     public List<String> GetUrls(String url) {}
     * }
     */
    public class _1242_WebCrawlerMultithreaded
    {
        public IList<string> Crawl(string startUrl, HtmlParser htmlParser) {
            var uri = new Uri(startUrl);
            var visited = new HashSet<string>();
            var queue = new List<string>();
            queue.Add(startUrl);

            while (queue.Count > 0) {
                var nextWave = new List<string>();
                Parallel.ForEach(queue, (next) => {
                    if (visited.Contains(next) || !next.StartsWith($"http://{uri.Host}")) return;

                    visited.Add(next);
                    nextWave.AddRange(htmlParser.GetUrls(next));
                });
                queue = nextWave;
            }

            return visited.ToArray();
        }

        public class HtmlParser
        {
            private readonly IDictionary<string, List<string>> connections;

            public HtmlParser(List<string> urls, List<int[]> edges) {
                connections = new Dictionary<string, List<string>>();
                foreach (var url in urls)
                    connections.Add(url, new List<string>());

                foreach (var edge in edges)
                    connections[urls[edge[0]]].Add(urls[edge[1]]);
            }

            public List<string> GetUrls(string url) {
                return connections[url];
            }
        }
    }
}
