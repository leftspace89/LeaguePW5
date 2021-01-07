using LeaguePW5.Lobby;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaguePW5
{
    public partial class LeaguePW5 : Form
    {

        public LCU lcu = new LCU();
        public LeaguePW5()
        {
            InitializeComponent();
        }

        public class BotComps
        {
            public enum Champions : long
            {
                Morgana = 25,
                Lux = 99,
                Leona = 89,
                BlitzCrank = 53,
                Amumu = 32,
                Annie = 1,
                Trundle = 48

            }
            public enum CompType
            {
                FULLCC,
                FULLADC,
                FULLTANK,
                FULLMAGIC
            };
            public static Champions[] FULLCC =
            {
                Champions.Morgana,
                Champions.Lux,
                Champions.Leona,
                Champions.BlitzCrank,
                Champions.Amumu,
                Champions.Annie,
                Champions.Trundle
            };

            static Random rnd = new Random();

            static HashSet<int> activeChampions = new HashSet<int>();

            public static Champions GetBotCompByType(CompType type)
            {


                switch (type)
                {
                    case CompType.FULLCC:
                        return FULLCC[0];
                    case CompType.FULLADC:
                        break;
                    case CompType.FULLTANK:
                        break;
                    case CompType.FULLMAGIC:
                        break;
                    default:
                        break;
                }

                return Champions.Morgana;
            }
        }


        private async void lblSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://memoryhackers.org/members/leftspace.8/");
        }


        //lol-summoner/v1/current-summoner/icon
        private async void createLobby_Click(object sender, EventArgs e)
        {
            var lobby = new CustomLobby
            {
                isCustom = true,
                customGameLobby = new CustomGameLobby
                {
                    lobbyName = lobbyName.Text,
                    lobbyPassword = "memoryhackers.org",
                    configuration = new Configuration
                    {
                        gameMode = "PRACTICETOOL",
                        gameMutator = "",
                        gameServerRegion = "",
                        mapId = 11,
                        mutators = new Mutators { id = 1 },
                        spectatorPolicy = "AllAllowed",
                        teamSize = 5
                    }
                }
            };


            var status = await lcu.PostData(lcu.baseURL + "/lol-lobby/v2/lobby", new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(lobby)))).ConfigureAwait(true);

        }

        private async void btn_addBots_Click(object sender, EventArgs e)
        {
            var selectedbotDifficulty = botDifficulty.Items[botDifficulty.SelectedIndex].ToString();

            for (int i = 0; i < 5; i++)
            {

                var botId = BotComps.FULLCC[i]; //TEMPPPPPP

                var customBot = new CustomBot()
                {
                    BotDifficulty = selectedbotDifficulty,
                    ChampionId = (long)botId,
                    TeamId = "200"
                };


                var status = await lcu.PostData(lcu.baseURL + "/lol-lobby/v1/lobby/custom/bots", new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(customBot)))).ConfigureAwait(true);

                await Task.Delay(300);
            }


        }

        private void LeaguePW5_Load(object sender, EventArgs e)
        {
            botDifficulty.SelectedIndex = 0;
        }

        private async void boostFuck_Click(object sender, EventArgs e)
        {
            var status = await lcu.PostData(lcu.baseURL + "/lol-champ-select/v1/team-boost/purchase", new ByteArrayContent(Encoding.UTF8.GetBytes("null"))).ConfigureAwait(true);

        }
        //   https://127.0.0.1:64212/lol-champ-select/v1/team-boost/purchase
        //POST /lol-champ-select/v1/team-boost/purchase HTTP/1.1
        //ContentType: application/json
        //Accept: application/json
        //Authorization: Basic 
        //User-Agent: RestSharp/106.6.8.0
        //Content-Type: application/json
        //Host: 127.0.0.1:64212
        //Connection: Keep-Alive
        //Accept-Encoding: gzip, deflate
        //Content-Length: 4

        //null
    }
}