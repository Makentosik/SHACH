using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaManager.Models
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }

        public int Leaderboard_rank { get; set; }
        public string Country { get; set; }
        public string ProfileURL { get; set; }

        public Player(int id, string name, string nickname, string avatar, int leaderboard, string country, string profileurl)
        {
            Id = id;
            Name = name;
            Nickname = nickname;
            Avatar = avatar;
            Leaderboard_rank = leaderboard;
            Country = country;
            ProfileURL = profileurl;
        }
    }
}
