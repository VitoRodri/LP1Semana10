using System;

namespace SamePlayer
{
    public enum PlayerType { Tank , Fighter, Slayer, Mage, Controller, Marksmen}

    public class Player
    {
        public PlayerType Type { get ; set ; }
        public string Name { get ; set ; }
    }
}