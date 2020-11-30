using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaguePW5.Lobby
{
    public partial class CustomBot
    {
        [JsonProperty("botDifficulty")]
        public string BotDifficulty { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }


    public class Mutators
    {

        [JsonProperty("id")]
        public int id { get; set; }
    }

    public class Configuration
    {

        [JsonProperty("gameMode")]
        public string gameMode { get; set; }

        [JsonProperty("gameMutator")]
        public string gameMutator { get; set; }

        [JsonProperty("gameServerRegion")]
        public string gameServerRegion { get; set; }

        [JsonProperty("mapId")]
        public int mapId { get; set; }

        [JsonProperty("mutators")]
        public Mutators mutators { get; set; }

        [JsonProperty("spectatorPolicy")]
        public string spectatorPolicy { get; set; }

        [JsonProperty("teamSize")]
        public int teamSize { get; set; }
    }

    public class CustomGameLobby
    {

        [JsonProperty("configuration")]
        public Configuration configuration { get; set; }

        [JsonProperty("lobbyName")]
        public string lobbyName { get; set; }

        [JsonProperty("lobbyPassword")]
        public object lobbyPassword { get; set; }
    }

    public class CustomLobby
    {

        [JsonProperty("customGameLobby")]
        public CustomGameLobby customGameLobby { get; set; }

        [JsonProperty("isCustom")]
        public bool isCustom { get; set; }

      
    }
}
