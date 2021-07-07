using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Reguest 
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JSON_Deserealising_Test
{
    public partial class jsonparser : Form
    {
        public jsonparser()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region UI events
        private void deserializeButton_Click(object sender, EventArgs e)
        {
            Uri outUri;

            if (Uri.TryCreate(rawjsonTextbox.Text, UriKind.Absolute, out outUri)
                && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
            {
                deserealizeJSON(Get(rawjsonTextbox.Text));
            }
            else
            {
                debugOutput("Ungültiger URI");
            }
        }

        private void deserializeListButton_Click(object sender, EventArgs e)
        {
            Uri outUri;

            if (Uri.TryCreate(rawjsonTextbox.Text, UriKind.Absolute, out outUri)
                && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
            {
                deserealizeJSONList(Get(rawjsonTextbox.Text));
            }
            else
            {
                debugOutput("Ungültiger URI");
            }
        }

        private void cleardebugButton_Click(object sender, EventArgs e)
        {
            debugTextbox.Text = String.Empty;
        }
        #endregion

        #region Debug Output
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                debugTextbox.Text = debugTextbox.Text + strDebugText + Environment.NewLine;
                debugTextbox.SelectionStart = debugTextbox.TextLength;
                debugTextbox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }
        #endregion

        #region Get Data
        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        #endregion

        #region json functions
        private void deserealizeJSONList(string strJSON)
        {
            try
            {
                if (rawjsonTextbox.Text.Contains("nodes"))
                {
                    var newnodes = Node.FromJsonList(strJSON);
                    foreach (var jNode in newnodes)
                    {
                        debugOutput("Node: " + jNode.FarmId);
                        debugOutput("Node: " + jNode.Id);
                        debugOutput("Node: " + jNode.Uptime);
                        debugOutput("Node: " + jNode.Updated);
                        debugOutput("Node: " + jNode.NodeId);
                    }
                }
                if (rawjsonTextbox.Text.Contains("farms"))
                {
                    var newnfarms = Farm.FromJsonList(strJSON);
                    foreach (var jFarm in newnfarms)
                    {
                        debugOutput("Node: " + jFarm.Name);
                        debugOutput("Node: " + jFarm.Id);
                        debugOutput("Node: " + jFarm.Email);
                        debugOutput("Node: " + jFarm.Location);
                        foreach (var wallets in jFarm.WalletAddresses)
                        {
                            debugOutput("Node: " + wallets.Address);
                            debugOutput("Node: " + wallets.Address);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                debugOutput("we had a problem: " + ex.Message.ToString());
            }
        }

        private void deserealizeJSON(string strJSON)
        {
            try
            {
                if (rawjsonTextbox.Text.Contains("nodes"))
                {
                    var jNode = Node.FromJson(strJSON);
                    debugOutput("Last status: " + UnixTimeStampToDateTime(jNode.Updated));
                    debugOutput("Online time in seconds: " + SecondsToDateTime(jNode.Uptime));
                    debugOutput("Total CRU: " + jNode.TotalResources.Cru);
                    debugOutput("Total MRU: " + jNode.TotalResources.Mru);
                    debugOutput("Total HRU: " + jNode.TotalResources.Hru);
                    debugOutput("Total SRU: " + jNode.TotalResources.Sru);

                    debugOutput("Reserved CRU: " + jNode.ReservedResources.Cru);
                    debugOutput("Reserved MRU: " + jNode.ReservedResources.Mru);
                    debugOutput("Reserved HRU: " + jNode.ReservedResources.Hru);
                    debugOutput("Reserved SRU: " + jNode.ReservedResources.Sru);

                    debugOutput("Used CRU: " + jNode.UsedResources.Cru);
                    debugOutput("Used MRU: " + jNode.UsedResources.Mru);
                    debugOutput("Used HRU: " + jNode.UsedResources.Hru);
                    debugOutput("Used SRU: " + jNode.UsedResources.Sru);

                    debugOutput("NodeId: " + jNode.NodeId);
                    debugOutput("NodeIdV1: " + jNode.NodeIdV1);

                    debugOutput("Address: " + jNode.Address);
                    debugOutput("Approved: " + jNode.Approved);
                    debugOutput("Created: " + jNode.Created);
                    debugOutput("FreeToUse: " + jNode.FreeToUse);
                    debugOutput("Id: " + jNode.Id);

                    debugOutput("Location: " + jNode.Location.CityNode);
                    debugOutput("Location: " + jNode.Location.ContinentNode);
                    debugOutput("Location: " + jNode.Location.CountryNode);
                    debugOutput("Location: " + jNode.Location.LatitudeNode);
                    debugOutput("Location: " + jNode.Location.LongitudeNode);

                    debugOutput("OsVersion: " + jNode.OsVersion);
                    debugOutput("FarmId: " + jNode.FarmId);
                    debugOutput("Proofs: " + jNode.Proofs);
                    debugOutput("PublicConfig: " + jNode.PublicConfig);
                    debugOutput("PublicKeyHex: " + jNode.PublicKeyHex);
                    debugOutput("WgPorts: " + jNode.WgPorts);

                    foreach (var ifaces in jNode.Ifaces)
                    {
                        debugOutput("IFace: " + ifaces.Name);

                        if (ifaces.Addrs != null)
                        {
                            foreach (var addrs in ifaces.Addrs)
                            {
                                debugOutput("Address: " + addrs.ToString());
                            }
                        }
                        else
                        {
                            debugOutput("Address: empty");
                        }

                        if (ifaces.Gateway != null)
                        {
                            foreach (var gw in ifaces.Gateway)
                            {
                                debugOutput("GW: " + gw.ToString());
                            }
                        }
                        else
                        {
                            debugOutput("GW: empty");
                        }

                        debugOutput("MAC: " + ifaces.Macaddress);
                    }
                }

                if (rawjsonTextbox.Text.Contains("farms"))
                {
                    var newfarm = Farm.FromJson(strJSON);

                        debugOutput("Node: " + newfarm.Name);
                        debugOutput("Node: " + newfarm.Id);
                        debugOutput("Node: " + newfarm.Email);
                        debugOutput("Node: " + newfarm.Location);
                        foreach (var wallets in newfarm.WalletAddresses)
                        {
                            debugOutput("Node: " + wallets.Address);
                            debugOutput("Node: " + wallets.Address);
                        }
                }
            }
            catch (Exception ex)
            {
                debugOutput("we had a problem: " + ex.Message.ToString());
            }
        }
        #endregion

        #region div functions
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static string SecondsToDateTime(long secs)
        {
            TimeSpan t = TimeSpan.FromSeconds(secs);

            string answer = string.Format("{0:D2}h:{1:D2}h:{2:D2}m:{3:D2}s:{4:D3}ms",
                t.Days,
                t.Hours,
                t.Minutes,
                t.Seconds,
                t.Milliseconds);
            return answer;
        }
        #endregion

        #region Testdaten
        public string getJsonTestString()
        {
            string JsonString = "{\"id\": 59,\"node_id\": " +
                                "\"74cu7Tf2N6h1MfCYRVJTP5LTPjZZ5ZWsyfExd5CehRAM\"," +
                                "\"node_id_v1\": \"001b213abda0\"," +
                                "\"farm_id\": 173599," +
                                "\"os_version\": \"0.2.3\"," +
                                "\"created\": 1586456124," +
                                "\"updated\": 1586680525," +
                                "\"uptime\": 224627," +
                                "\"address\": \"\"," +
                                "\"location\": {" +
                                "\"city\": \"Uknown\"," +
                                "\"country\": \"Austria\"," +
                                "\"continent\": \"Europe\"," +
                                "\"latitude\": 48.1865," +
                                "\"longitude\": 16.3549" +
                                "}," +
                                "\"total_resources\": {" +
                                "\"cru\": 80," +
                                "\"mru\": 756," +
                                "\"hru\": 0," +
                                "\"sru\": 0" +
                                "}," +
                                "\"used_resources\": {" +
                                "\"cru\": 0," +
                                "\"mru\": 0," +
                                "\"hru\": 0," +
                                "\"sru\": 0" +
                                "}," +
                                "\"reserved_resources\": {" +
                                "\"cru\": 0," +
                                "\"mru\": 0," +
                                "\"hru\": 0," +
                                "\"sru\": 0" +
                                "}," +
                                "\"proofs\": null," +
                                "\"ifaces\": [" +
                                "{" +
                                "\"name\": \"lo\"," +
                                "\"addrs\": [" +
                                "\"127.0.0.1/8\"," +
                                "\"::1/128\"" +
                                "]," +
                                "\"gateway\": null," +
                                "\"macaddress\": \"\"" +
                                "}," +
                                "{" +
                                "\"name\": \"enp70s0\"," +
                                "\"addrs\": [" +
                                "\"fe80::21b:21ff:fe3a:bda0/64\"" +
                                "]," +
                                "\"gateway\": null," +
                                "\"macaddress\": \"\"" +
                                "}," +
                                "{" +
                                "\"name\": \"zos\"," +
                                "\"addrs\": [" +
                                "\"10.0.1.204/24\"," +
                                "\"2a02:1748:dd1d:66e0:21b:21ff:fe3a:bda0/64\"," +
                                "\"fe80::50b5:cbff:fedf:5d1a/64\"" +
                                "]," +
                                "\"gateway\": [" +
                                "\"10.0.1.1\"" +
                                "]," +
                                "\"macaddress\": \"\"" +
                                "}," +
                                "{" +
                                "\"name\": \"br-ndmz\"," +
                                "\"addrs\":  null," +
                                "\"gateway\": null," +
                                "\"macaddress\": \"\"" +
                                "}" +
                                "]," +
                                "\"public_config\": null," +
                                "\"free_to_use\": false," +
                                "\"approved\": false," +
                                "\"public_key_hex\": \"5a13745b392c0210cb8450a6eb2be22289d623ae088d5dcb20f1367b12bd58ee\"," +
                                "\"wg_ports\": null" +
                                "}";

            return JsonString;
        }
        #endregion
    }
}