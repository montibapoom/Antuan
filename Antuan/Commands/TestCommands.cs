using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Antuan.Commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel
                .SendMessageAsync("Pong")
                .ConfigureAwait(false);
        }

        [Command("Response")]
        public async Task Response(CommandContext ctx)
        {
            var respondTo = ctx.Member.DisplayName;

            await ctx.Channel
                .SendMessageAsync($"Display name {respondTo}")
                .ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Adds two numbers")]
        public async Task Add(CommandContext ctx,
            [Description("Lhs")] int first,
            [Description("Rhs")] int second)
        {
            await ctx.Channel
                .SendMessageAsync((first + second).ToString())
                .ConfigureAwait(false);
        }
    }
}
