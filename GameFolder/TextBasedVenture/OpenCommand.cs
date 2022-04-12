using System;


namespace DungeonGame
{
    public class OpenCommand : Command
	{
		public OpenCommand()
		{
			this.name = "Open";
		}
        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                player.open(this.secondWord);
            }
            else
            {
                player.warningMessage("\nOpen What?");
            }
            return false;
        }
    }
}


