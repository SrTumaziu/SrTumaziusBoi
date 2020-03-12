using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace TutorialBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        //https://prnt.sc/rdxrs0

        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }
        [Command("guido")]
        public async Task guido()
        {
            await ReplyAsync(":potato: Guido is a naughty potato :potato:");
            await ReplyAsync(":eggplant: :sweat_drops:");
            await ReplyAsync("https://prnt.sc/regu9y");
        }
        [Command("oof")]
        public async Task oof()
        {
            await ReplyAsync("https://tenor.com/view/roblox-fortnite-dance-default-memes-cool-gif-12661768");
        }
        [Command("Help")]
        public async Task Help()
        {
            await ReplyAsync(":exclamation:**Here is a list of commands:**:exclamation: \n > !art --> Will show you art by Alex_Otter \n > !motivation --> Will give you motivation. \n > !Covid-19 --> All the news you need. Stay safe! \n > !square (number) --> it will square a number. \n > !coin --> Will flip a coin. (Heads or Tails) \n > !ppsize (@name) --> Will show THE PP SIZE! \n ```Other Stuff --> !MissAnaHappy, !Jackie, !Alex_Otter, !Nekas20, !Nathan, !poetry, !oof, !guido.``` \n > :exclamation: If you want your own command send a MSG to SrTumaziu#2825 \n  \n ***Bot by SrTumaziu*** ");
        }
        [Command("poetry")]
        public async Task Poetry()
        {
            await ReplyAsync("Drunk in the moonlight, drunk with horizons, \n We believe that to live was to embrace \n The noise of the pine forests, the blue of the mountains \n And all the green gardens by the sea. \n \n ");
            await ReplyAsync("But we are lonely and we pass, \n The fruits and the flowers are not ours,\n  The sky and the sea fade outwards \n And they become the ghosts we dream of.\n \n ");
            await ReplyAsync("Why gardens that we will not harvest,\n  Clear at dawn,\n  Why the sky and the sea if we won't be\n  Never the gods capable of living them.\n ");
        }
        [Command("surprise")]
        public async Task surprise()
        {
            await ReplyAsync("https://tenor.com/view/jim-carey-dumb-and-dumber-lloyd-christmas-silly-face-gif-5623684");
        }
        [Command("trigger")]
        public async Task trigger()
        {
            await ReplyAsync("https://prnt.sc/rdy04m");
        }
        [Command("MissAnaHappy")]
        public async Task MissAnaHappy()
        {
            await ReplyAsync("She is just happy.");
        }
        [Command("Alex_Otter")]
        public async Task Alex_Otter()
        {
            await ReplyAsync("Otters rule, others drool \n - Alex Otter 9/3/20");
        }
        [Command("Nekas20")]
        public async Task StopIt()
        {
            await ReplyAsync("PTHHTHTHTHHTHTHTHHTHHHH");
        }
        [Command("Not_Like_This")]
        [Alias("Zoey")]
        public async Task NotLikeThis()
        {
            await ReplyAsync("@MissAnaHappy send nudes \n ty c: ");
        }
        [Command("Jackie")]
        public async Task Jackie()
        {
            await ReplyAsync("complain skill 10/10");
        }
        [Command("Nathan")]
        public async Task Nathan()
        {
            await ReplyAsync("HHHHhhhhHHHHhhhhHHHhhhHMMMMmmmmmMMMmmmmMMMM");
        }
        [Command("play")]
        public async Task play()
        {
            await ReplyAsync("~TOSS A COIN TO YOUR WITCHER!!!~ \n https://www.youtube.com/watch?v=hqbS7O9qIXE");
        }
        [Command("square")]
        public async Task SquareAsync(int num)
        {
            // We can also access the channel from the Command Context.
            await Context.Channel.SendMessageAsync($"{num}^2 = {Math.Pow(num, 2)}");
        }
        [Command("CoronaVirus")]
        [Alias("Covid-19")]
        public async Task CoronaVirus()
        {
            await ReplyAsync("***Check this out for news:*** \n > https://www.reddit.com/r/Coronavirus/new/ \n \n Stay safe guys! :wink:");
        }
        [Command("Number")]
        [Alias("Random")]
        public async Task Number()
        {
            Random numero = new Random();
            await ReplyAsync("Hmm, maybe " + numero.Next(100));
        }
        [Command("Coin")]
        public async Task coin()
        {
            Random coin = new Random();

            if (coin.Next(2) == 1)
            {
                await ReplyAsync("Hmm, it landed on TAILS");
            }
            else
            {
                await ReplyAsync("Hmm, it landed on HEADS");
            }

        }
        [Command("Status")]
        public async Task TestAsync(String status)
        {
            await Context.Client.SetGameAsync(status);

            await Task.CompletedTask;
        }
        [Command("Ball")]
        public async Task Ball()
        {
            Random n = new Random();

            if (n.Next(5) == 1)
            {
                await ReplyAsync("Abso-fucking-lutely");
            }
            if (n.Next(5) == 2)
            {
                await ReplyAsync("Pretty likely, yeah");
            }
            if (n.Next(5) == 3)
            {
                await ReplyAsync("Meh");
            }
            if (n.Next(5) == 4)
            {
                await ReplyAsync("Eh, probably not");
            }
            if (n.Next(5) == 5)
            {
                await ReplyAsync("Not gonna happen");
            }
        }
        [Command("ppsize")]
        public async Task ppsize(string nome)
        {
            Random size = new Random();

            int n = size.Next(10);

            if (n == 1)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8=D");
            }
            if (n == 2)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8===D");
            }
            if (n == 3)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8====D");
            }
            if (n == 4)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8======D");
            }
            if (n == 5)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8=======D");
            }
            if (n == 6)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8=====D");
            }
            if (n == 7)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8==D");
            }
            if (n == 8)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8===============D");
            }
            if (n == 9)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8=====================================================================================D");
            }
            if (n == 10)
            {
                await ReplyAsync("> " + nome + " _PP SIZE_");
                await ReplyAsync("> 8====D");
            }

        }
        [Command("art")]
        public async Task art()
        {
            Random art = new Random();

            int n = art.Next(23);
            if (n == 1)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezs4i");
            }
            if (n == 2)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezsfi");
            }
            if (n == 3)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezspr");
            }
            if (n == 4)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezstl");
            }
            if (n == 5)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezswh");
            }
            if (n == 6)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezt06");
            }
            if (n == 7)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezt5e");
            }
            if (n == 8)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezt95");
            }
            if (n == 9)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztcb");
            }
            if (n == 10)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztfr");
            }
            if (n == 11)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztip");
            }
            if (n == 12)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztl8");
            }
            if (n == 13)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztok");
            }
            if (n == 14)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztrh");
            }
            if (n == 15)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztu1");
            }
            if (n == 16)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/reztx2");
            }
            if (n == 17)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezu06");
            }
            if (n == 18)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezu32");
            }
            if (n == 19)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezu57");
            }
            if (n == 20)
            {
                await ReplyAsync("By Alex_Otter \n (This guy is my daddy -> SrTumaziu) \b https://prnt.sc/rezu84");
            }
            if (n == 21)
            {
                await ReplyAsync("By Alex_Otter \n https://prnt.sc/rezuaj");
            }
            if (n == 22)
            {
                await ReplyAsync("By Alex_Otter \b https://prnt.sc/rezuf0");
            }
            if (n == 23)
            {
                await ReplyAsync("By Alex_Otter \n https://prnt.sc/rezuht");
            }

        }
        [Command("motivation")]
        public async Task motivation()
        {
            Random motivation = new Random();

            int n = motivation.Next(30);

            if (n == 1)
            {
                await ReplyAsync("Quality is not an act, it is a habit. Keep going!");
            }
            if (n == 2)
            {
                await ReplyAsync("Don’t let yesterday take up too much of today. Go do what you need to do!");
            }
            if (n == 3)
            {
                await ReplyAsync("This, too, shall pass.");
            }
            if (n == 4)
            {
                await ReplyAsync("You can do the thing! ");
            }
            if (n == 5)
            {
                await ReplyAsync("If at first you don’t succeed, then skydiving definitely isn’t for you. For everything else, though, keep trying!");
            }
            if (n == 6)
            {
                await ReplyAsync("Opportunity does not knock, it presents itself when you beat down the door. Go break down that fucker.");
            }
            if (n == 7)
            {
                await ReplyAsync("Don’t worry about the world coming to an end today. It is already tomorrow in Australia.");
            }
            if (n == 8)
            {
                await ReplyAsync("The minute you settle for less than you deserve, you get even less than you settled for. Do better!");
            }
            if (n == 9)
            {
                await ReplyAsync("It takes less time to do things right than to explain why you did it wrong. Stop whining and do the thing.");
            }
            if (n == 10)
            {
                await ReplyAsync("The key to success is not through achievement but through enthusiasm. Fuck up and be happy already.");
            }
            if (n == 11)
            {
                await ReplyAsync("You can’t wait for inspiration. You have to go after it with a club. Beat that fucker!");
            }
            if (n == 12)
            {
                await ReplyAsync("Opportunity is missed by most people because it looks a lot like work. Stop being lazy and go do what you need to do today!");
            }
            if (n == 13)
            {
                await ReplyAsync("A diamond is merely a lump of coal that did well under pressure. Go and shine bright you beautiful calhau!");
            }
            if (n == 14)
            {
                await ReplyAsync("Failure is the condiment that gives success its flavor. Fuck up often and grow!");
            }
            if (n == 15)
            {
                await ReplyAsync("People often say that motivation doesn’t last. Well, neither does wiping your ass, but, you know...");
            }
            if (n == 16)
            {
                await ReplyAsync("If you’re going to be able to look back on something and laugh about it, you might as well laugh about it now. Life is too short to take seriously.");
            }
            if (n == 17)
            {
                await ReplyAsync("Fill what is empty. Empty what is full. Scratch where it itches. You do you.");
            }
            if (n == 18)
            {
                await ReplyAsync("Listen, smile, agree, and then do whatever you were gonna do anyway. Do it right though!");
            }
            if (n == 19)
            {
                await ReplyAsync("If someone says you can't do it, do it twice and take pictures.");
            }
            if (n == 20)
            {
                await ReplyAsync("Do your future self a big favor and work hard today!");
            }
            if (n == 21)
            {
                await ReplyAsync("It doesn't have to be perfect, it has to be done. Get off your butt and do the thing!");
            }
            if (n == 22)
            {
                await ReplyAsync("Be busy focusing on your own grass and stop worrying about other people's. You do you!");
            }
            if (n == 23)
            {
                await ReplyAsync("Be like a stamp and stick to it until you get there.");
            }
            if (n == 24)
            {
                await ReplyAsync("Everyone fucks up, so it's likely everyone is focused on themselves and their own fuck-ups. Go and be free!");
            }
            if (n == 25)
            {
                await ReplyAsync("Hard work beats talent. Work it beech!");
            }
            if (n ==26)
            {
                await ReplyAsync("If you can't handle me at my OwO, you don't deserve me at UwU.");
            }
            if (n == 27)
            {
                await ReplyAsync("You're overthinking it. Just go do your thing.");
            }
            if (n == 28)
            {
                await ReplyAsync("I'd never say this to your face, but I think you're pretty awesome.");
            }
            if (n == 29)
            {
                await ReplyAsync("Live as you like, peace for the hippies!");
            }
            if (n == 30)
            {
                await ReplyAsync("Nobody cares. Be happy.");
            }
        }
    }
}
