using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Cortex
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Start();
        }

        private DiscordClient _client;

        public void Start()
        {
            _client = new DiscordClient(x =>
            {
                x.AppName = "Cortex";
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            _client.UsingCommands(x =>
            {
                x.PrefixChar = '-'; // -help
                x.AllowMentionPrefix = true;
            });

            var token = "MjY0NTAxNDgzMDA3OTAxNjk2.C0hwhA.IPjHytJTQKC3yqyqyre7WkXtnXQ";

            CreateCommands();

            _client.ExecuteAndWait(async () =>
            {
                await _client.Connect(token, TokenType.Bot);
            });

        }

        public void CreateCommands()
        {
            var cService = _client.GetService<CommandService>();

            cService.CreateCommand("top50")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://www.youtube.com/watch?v=HJJVkqFa7sA");

                });

            cService.CreateCommand("joinserver")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("https://discordapp.com/oauth2/authorize?client_id=264501483007901696&scope=bot&permissions=0");

                });

            cService.CreateCommand("cortexvideo")
                .Do(async (e) =>
                {
                    Random ale = new Random();
                    int nbrvid = ale.Next(1, 11);

                    switch (nbrvid)
                    {
                        case 1: //Cortex j'investis beaucoup d'argent en Californie
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=Np7joTqguXM");
                                break;
                            }
                        case 2: //Cortex explique pourquoi il est devenu éboueur
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=Tbv_dl1o8Ho");
                                break;
                            }
                        case 3: //Cortex repond au pique de gradur sur Twitter concernant le bain a Jeremstar
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=izBq1SX8Dg4");
                                break;
                            }
                        case 4: //Cortex réclame 10 millions au rappeur desiigner il a volé mon DRAAA
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=kiRo1mun4tM");
                                break;
                            }
                        case 5: //Cortex ont ma dit que c'est benash qui ma tiré dessus sous ordre de booba
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=BUzSeyEbUgE");
                                break;
                            }
                        case 6: //cortex au coiffeur annonce son premier court metrage !!!
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=BPYByTT_DOU");
                                break;
                            }
                        case 7: //cortex au petit déjeuner !!!
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=5FEZHvtWgWU");
                                break;
                            }
                        case 8: //cortex péte un plomb sur l'affaire du psg police ARRETER ARRETER)
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=17mjE5BN-9o");
                                break;
                            }
                        case 9: //cortex clash les clowns de rue tueur
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=gmNU6kHuhH0");
                                break;
                            }
                        case 10: //cortex tu est un voleur cyprien 60euros tes places de spectacle
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=jhozVbO1CaQ");
                                break;
                            }

                        case 11: //Cortex president des Etats-Unis
                            {
                                await e.Channel.SendMessage("https://www.youtube.com/watch?v=Ykd1C34mJXk");
                                break;
                            }

                    }
                    

                });
        }

        public void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine($"[{e.Severity}] [{e.Source}] {e.Message}");
        }
    }
}
