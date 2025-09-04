using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftLookup
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient http = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void btnLookupName_Click_1(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            await LookupByName(username);
        }
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string uuid = txtUUID.Text.Trim();
            if (string.IsNullOrEmpty(uuid))
            {
                MessageBox.Show("Please enter a UUID (no dashes).");
                return;
            }

            await LookupByUUID(uuid);
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            var label = sender as Guna.UI2.WinForms.Guna2HtmlLabel;
            string url = label?.Tag as string;

            if (!string.IsNullOrEmpty(url) && url != "None")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            var label = sender as Guna.UI2.WinForms.Guna2HtmlLabel;
            string url = label?.Tag as string;

            if (!string.IsNullOrEmpty(url) && url != "None")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }
        private async Task LookupByName(string username)
        {
            try
            {
                HttpResponseMessage resp = await http.GetAsync($"https://api.mojang.com/users/profiles/minecraft/{username}");
                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("No profile found for that username.");
                    return;
                }

                string response = await resp.Content.ReadAsStringAsync();
                JsonNode profile = JsonNode.Parse(response);

                string id = profile?["id"]?.ToString() ?? "None";
                string name = profile?["name"]?.ToString() ?? "None";

                lblUUID.Text = $"UUID: {id}";
                lblCurrentName.Text = $"Current Username: {name}";

                string flags = "";
                if (profile?["legacy"] != null) flags += "[Legacy] ";
                if (profile?["demo"] != null) flags += "[Demo] ";
                if (string.IsNullOrEmpty(flags)) flags = "None";
                lblFlags.Text = $"Account Flags: {flags}";
                HttpResponseMessage histResp = await http.GetAsync($"https://api.mojang.com/user/profiles/{id}/names");
                if (histResp.IsSuccessStatusCode)
                {
                    string histData = await histResp.Content.ReadAsStringAsync();
                    JsonNode history = JsonNode.Parse(histData);

                    if (history != null && history.AsArray().Count > 0)
                    {
                        StringBuilder sb = new StringBuilder("Name History:\n");
                        foreach (var entry in history.AsArray())
                        {
                            sb.Append("  " + entry?["name"]);
                            if (entry?["changedToAt"] != null)
                            {
                                sb.Append(" (changed at " + entry["changedToAt"] + ")");
                            }
                            sb.AppendLine();
                        }
                        txtOutput.Text = sb.ToString();
                    }
                    else
                    {
                        txtOutput.Text = "Name History: None";
                    }
                }
                else
                {
                    txtOutput.Text = "Name History: None";
                }
                await LookupByUUID(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LookupByUUID(string uuid)
        {
            try
            {
                HttpResponseMessage resp = await http.GetAsync($"https://sessionserver.mojang.com/session/minecraft/profile/{uuid}");
                if (!resp.IsSuccessStatusCode)
                {
                    txtOutput.Text = "Textures Info: None (no profile found)";
                    return;
                }

                string response = await resp.Content.ReadAsStringAsync();
                JsonNode data = JsonNode.Parse(response);

                lblUUID.Text = $"UUID: {data?["id"]}";
                lblCurrentName.Text = $"Current Username: {data?["name"]}";
                lblFlags.Text = "Account Flags: None";

                if (data?["properties"] != null)
                {
                    foreach (var prop in data["properties"].AsArray())
                    {
                        if (prop?["name"]?.ToString() == "textures")
                        {
                            string b64 = prop["value"]?.ToString() ?? "";
                            string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(b64));
                            JsonNode texJson = JsonNode.Parse(decoded);

                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Textures Info:");
                            sb.AppendLine($"  Timestamp: {texJson?["timestamp"]}");
                            sb.AppendLine($"  ProfileId: {texJson?["profileId"]}");
                            sb.AppendLine($"  ProfileName: {texJson?["profileName"]}");
                            if (texJson?["textures"]?["SKIN"] != null)
                            {
                                string skinUrl = texJson["textures"]["SKIN"]["url"]?.ToString() ?? "None";
                                guna2HtmlLabel1.Text = $"Skin URL: {skinUrl}";
                                guna2HtmlLabel1.Tag = skinUrl;
                               

                                if (texJson["textures"]["SKIN"]?["metadata"]?["model"] != null)
                                    sb.AppendLine($"  Model: {texJson["textures"]["SKIN"]["metadata"]["model"]}");
                                else
                                    sb.AppendLine("  Model: Steve (default)");
                            }
                            else
                            {
                                guna2HtmlLabel1.Text = "Skin: None";
                            }
                            if (texJson?["textures"]?["CAPE"] != null)
                            {
                                string capeUrl = texJson["textures"]["CAPE"]["url"]?.ToString() ?? "None";
                                guna2HtmlLabel2.Text = $"Cape URL: {capeUrl}";
                                guna2HtmlLabel2.Tag = capeUrl;
                            }
                            else
                            {
                                guna2HtmlLabel2.Text = "Cape: None";
                                guna2HtmlLabel2.Tag = null;
                            }

                            txtOutput.Text = sb.ToString();
                        }
                    }
                }
                else
                {
                    txtOutput.Text = "Textures Info: None";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
       
    }
}
