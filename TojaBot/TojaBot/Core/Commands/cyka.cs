using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace TojaBot.Core.Commands
{
    public class cyka : ModuleBase<SocketCommandContext>
    {
        [Command("cyka"), Summary("Hello world command")]
        public async Task cykaEmbed([Remainder]string Input = "None")
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("CYKA BLYAT!", Context.User.GetAvatarUrl(), "https://www.ostoja.tk/");
            Embed.WithColor(255, 0, 0);
            Embed.WithFooter("IDI NAHUI", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("BLYAT!");

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}
