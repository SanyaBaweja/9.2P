﻿namespace Iteration6
{
    public class CommandProcessor : Command
    {

        List<Command> _cmd = new List<Command>()
        { new LookCommand(), new Move() };
        public CommandProcessor() : base(new string[] { "execute" })
        {
           
        }

        public override string Execute(Player p, string[] text)
        {
            foreach (Command cmd in _cmd)
            {
                if (cmd.AreYou(text[0]))
                {
                    return cmd.Execute(p, text);
                }
            }
            return "What is that command! ";
        }
    }
}