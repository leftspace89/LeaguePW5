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

        private void lblSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://memoryhackers.org/members/leftspace.8/");
        }

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

            var status = await lcu.http_client.PostAsync(lcu.baseURL + "/lol-lobby/v2/lobby", new ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(lobby)))).ConfigureAwait(true);
        }
    }
}
