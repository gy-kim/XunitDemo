using System;

namespace GameEngine
{
    public class PlayerCharacter
    {
        private int _health = 100;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string NickName { get; set; }

        public bool IsNoob { get; set; }

        public PlayerCharacter()
        {
            IsNoob = true;
        }
    }
}
