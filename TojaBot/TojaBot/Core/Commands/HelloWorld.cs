using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace TojaBot.Core.Commands
{
    public class HelloWorld : ModuleBase<SocketCommandContext>
    {
        [Command("hello"), Alias("helloworld"), Summary("Hello world command")]
        public async Task hello()
        {
            await Context.Channel.SendMessageAsync("Hello World");
        }

        [Command("embed"), Summary("Embed test command")]
        public async Task Embed([Remainder]string Input = "None")
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Test embed", Context.User.GetAvatarUrl(), "https://www.ostoja.tk/");
            Embed.WithColor(255, 170, 0);
            Embed.WithFooter("The footer of the embed", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("Test Descriptiopns.\n" + "Cyka Blyet");
            Embed.AddInlineField("User Input:", Input);

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
