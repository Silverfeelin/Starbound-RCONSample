using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading;

namespace StarboundRcon
{
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Cached configuration folder path.
        /// </summary>
        private string _configurationPath = null;

        /// <summary>
        /// Gets the full folder path to the configuration folder.
        /// </summary>
        public string ConfigurationPath
        {
            get
            {
                if (string.IsNullOrEmpty(_configurationPath) || !Directory.Exists(_configurationPath))
                {
                    string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string folder = Path.Combine(appData, Properties.Settings.Default.ConfigurationFolder);

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    _configurationPath = folder;
                }

                return _configurationPath;
            }
        }

        /// <summary>
        /// Gets the full file path to the configuration file.
        /// </summary>
        public string ConfigurationFile
        {
            get
            {
                string configPath = ConfigurationPath;
                string file = Properties.Settings.Default.ConfigurationFile;
                string filePath = Path.Combine(configPath, file);

                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "{}");
                }

                return filePath;
            }
        }

        /// <summary>
        /// Indicates whether the config has been changed inside the application.
        /// Used to write changes to disk only when necessary.
        /// </summary>
        private bool configDirty = false;

        /// <summary>
        /// Currently selected tab. Same as <see cref="TabControl.SelectedTab"/>.
        /// Used to determine what tab was left/closed.
        /// </summary>
        /// <see cref="TabControl_SelectedIndexChanged(object, EventArgs)"/> 
        private TabPage currentPage = null;

        /// <summary>
        /// Used to send RCON messages.
        /// </summary>
        private RconManager manager;

        /// <summary>
        /// Initializes the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Set up MaterialSkin (https://github.com/IgnaceMaes/MaterialSkin)
            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue100, TextShade.WHITE);

            LoadSettings();

            int port;
            if (!int.TryParse(TbxServerPort.Text, out port))
                port = 21026;

            manager = new RconManager(TbxServerAddress.Text, port, TbxServerPassword.Text);

            if (configDirty)
                SaveSettings();
        }

        /// <summary>
        /// Event handler for switching tabs.
        /// Saves settings when leaving the settings tab. Loads settings when entering the settings tab.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var previousPage = currentPage;

            if (TabControl.SelectedTab == SettingsTab)
                LoadSettings();
            else if (previousPage == SettingsTab)
                SaveSettings();

            currentPage = TabControl.SelectedTab;
        }

        private void LoadSettings()
        {
            JObject configuration;
            try
            {
                configuration = JObject.Parse(File.ReadAllText(ConfigurationFile));
            }
            catch
            {
                Log("Configuration file could not be read. The file will be overwritten when any setting changes.");
                configuration = new JObject();
            }

            // Address
            JToken tAddress;
            string address = null;
            if (configuration.TryGetValue("serverAddress", out tAddress))
                address = tAddress.Value<string>();

            if (string.IsNullOrWhiteSpace(address))
            {
                address = "127.0.0.1";
                configDirty = true;
            }

            TbxServerAddress.Text = address;

            // Port
            JToken tPort;
            string port = null;
            if (configuration.TryGetValue("rconPort", out tPort))
                port = tPort.Value<string>();

            if (string.IsNullOrWhiteSpace(port))
            {
                port = "21026";
                configDirty = true;
            }

            TbxServerPort.Text = port;

            // Password
            JToken tPassword;
            string password = "";
            if (configuration.TryGetValue("rconPassword", out tPassword))
                password = tPassword.Value<string>();
            
            TbxServerPassword.Text = password;

            // Message Format
            JToken tMessageFormat;
            string messageFormat = null;
            if (configuration.TryGetValue("messageFormat", out tMessageFormat))
                messageFormat = tMessageFormat.Value<string>();

            if (string.IsNullOrWhiteSpace(messageFormat))
            {
                messageFormat = "{message}";
                configDirty = true;
            }

            TbxMessageFormat.Text = messageFormat;
        }

        /// <summary>
        /// Saves the configuration, if settings have been changed inside the application.
        /// </summary>
        /// <returns>True if the configuration has been saved, false otherwise.</returns>
        private bool SaveSettings()
        {
            if (configDirty)
            {
                configDirty = false;

                JObject configuration;
                try
                {
                    configuration = JObject.Parse(File.ReadAllText(ConfigurationFile));
                }
                catch
                {
                    configuration = new JObject();
                }

                configuration["serverAddress"] = TbxServerAddress.Text;
                configuration["rconPort"] = TbxServerPort.Text;
                configuration["rconPassword"] = TbxServerPassword.Text;
                configuration["messageFormat"] = TbxMessageFormat.Text;

                manager.Address = TbxServerAddress.Text;
                int port;
                if (!int.TryParse(TbxServerPort.Text, out port))
                    port = 21026;
                manager.Port = port;
                manager.Password = TbxServerPassword.Text;
                File.WriteAllText(ConfigurationFile, configuration.ToString(Formatting.Indented));

                Log("Configuration saved!");

                return true;
            }

            return false;
        }

        /// <summary>
        /// Marks the configuration as changed.
        /// </summary>
        private void SettingTextChanged(object sender, EventArgs e)
        {
            configDirty = true;
        }

        /// <summary>
        /// Saves the configuration.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Returns the command to send to RCON, using the entered command and the command format.
        /// </summary>
        /// <returns>RCON command.</returns>
        private string GetCommand()
        {
            string format = TbxMessageFormat.Text;
            string text = TbxCommand.Text;

            return format.Replace("{message}", text);
        }

        /// <summary>
        /// Sends the entered RCON command, after verifying the command and settings.
        /// </summary>
        private void SendCommand_Click(object sender, EventArgs e)
        {
            // Get command
            string command = GetCommand();
            if (string.IsNullOrEmpty(command))
            {
                Log("Please enter an RCON command.");
                TbxCommand.Select();
                TbxCommand.Focus();
                return;
            }

            if (!manager.ValidPassword)
            {
                Log("Please configure the RCON password.");
                return;
            }

            SendCommand(command);
        }

        /// <summary>
        /// Asynchronously sends the RCON command and logs the response.
        /// </summary>
        /// <param name="command">Command to send.</param>
        private async void SendCommand(string command)
        {
            string result;
            try
            {
                result = await manager.RunCommand(command);
                Log(result);
            }
            catch (Exception exc)
            {
                Log("Exception unaccounted for.\r\n" + exc.Message);
            }
        }

        /// <summary>
        /// Logs a (formatted) message. A timestamp is added, and a line break is appended to the end.
        /// </summary>
        /// <param name="message">Message to log.</param>
        /// <param name="args">Optional message format arguments.</param>
        public void Log(string message, params string[] args)
        {
            if (string.IsNullOrEmpty(message)) return;

            // Format
            if (args != null && args.Length > 0)
                message = string.Format(message, args);

            // Log
            RtbxOutput.AppendText(string.Format("[{0}] {1}{2}", DateTime.Now.ToShortTimeString(), message, Environment.NewLine));

            // Scroll to bottom
            RtbxOutput.SelectionStart = RtbxOutput.Text.Length - 1;
            RtbxOutput.ScrollToCaret();
        }

        /// <summary>
        /// Shows or hides the RCON password
        /// </summary>
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TbxServerPassword.PasswordChar = ChkShowPassword.Checked ? '\0' : '•';
        }
    }
}
