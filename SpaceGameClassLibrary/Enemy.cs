﻿
namespace SpaceGameClassLibrary
{
    public class Enemy
    {
        public string AppearMessage = "";
        public string Name = "";

        public int Health { get; set; }

        public Enemy()
        {
            Health = 3;
        }

        public Enemy(int hp)
        {
            Health = hp;
        }

        public void LoseHealth(int hp)
        {
            Health -= hp;
        }

        public bool IsDead()
        {
            if (Health <= 0) return true;

            return false;
        }
    }
}
