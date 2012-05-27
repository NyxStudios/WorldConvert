using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;

namespace WorldConvert
{
    public class WorldConvert : TerrariaPlugin
    {
        private enum Biome
        {
            Normal,
            Corruption,
            Hallow,
            Meteor,
            Jungle,
        }

        public override string Author
        {
            get { return "Tshock Team"; }
        }

        public override string Description
        {
            get { return "Commands to convert different biomes."; }
        }

        public override string Name
        {
            get { return "World Convert"; }
        }

        public override Version Version
        {
            get { return new Version(1, 0); }
        }

        public WorldConvert(Main game) : base(game)
        {
            
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("wconvert", ConvertBiome, "convert"));
            Commands.ChatCommands.Add(new Command("wconvert", RemoveBiome, "remove"));
        }

        private void ConvertBiome( CommandArgs args )
        {
            if( args.Parameters.Count < 2 )
            {
                args.Player.SendMessage( "You must specify the biome you wish to convert and what to convert to.");
            }

            Biome inbiome,outbiome;

            if (!Biome.TryParse(args.Parameters[0], out inbiome) )
            {
                args.Player.SendMessage(String.Format("{0} is not a valid biome", args.Parameters[0] ), Color.Red);
                return;
            }

            if (!Biome.TryParse(args.Parameters[0], out outbiome))
            {
                args.Player.SendMessage(String.Format("{0} is not a valid biome", args.Parameters[1]), Color.Red);
                return;
            }

            switch( inbiome )
            {
                case Biome.Hallow:
                    break;
                case Biome.Corruption:
                    break;
                default:
                    return;
            }
        }

        private void RemoveBiome(CommandArgs args)
        {
            if (args.Parameters.Count < 1)
            {
                args.Player.SendMessage("You must specify the biome you wish to remove.");
            }

            Biome inbiome;

            if (!Biome.TryParse(args.Parameters[0], out inbiome))
            {
                args.Player.SendMessage(String.Format("{0} is not a valid biome", args.Parameters[0]), Color.Red);
                return;
            }

            switch (inbiome)
            {
                case Biome.Hallow:
                    break;
                case Biome.Corruption:
                    break;
                default:
                    return;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if( disposing )
            {
                
            }
            base.Dispose(disposing);
        }
    }
}
