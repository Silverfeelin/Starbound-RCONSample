namespace StarboundRcon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSendCommand = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Tabs = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.RconTab = new System.Windows.Forms.TabPage();
            this.LblCommand = new MaterialSkin.Controls.MaterialLabel();
            this.TbxCommand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.LbLMessageFormat = new MaterialSkin.Controls.MaterialLabel();
            this.TbxMessageFormat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LbLServerPassword = new MaterialSkin.Controls.MaterialLabel();
            this.TbxServerPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblServerPort = new MaterialSkin.Controls.MaterialLabel();
            this.TbxServerPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblServerAddress = new MaterialSkin.Controls.MaterialLabel();
            this.TbxServerAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RtbxOutput = new System.Windows.Forms.RichTextBox();
            this.ChkShowPassword = new MaterialSkin.Controls.MaterialCheckBox();
            this.TabControl.SuspendLayout();
            this.RconTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSendCommand
            // 
            this.BtnSendCommand.Depth = 0;
            this.BtnSendCommand.Location = new System.Drawing.Point(10, 60);
            this.BtnSendCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSendCommand.Name = "BtnSendCommand";
            this.BtnSendCommand.Primary = true;
            this.BtnSendCommand.Size = new System.Drawing.Size(204, 60);
            this.BtnSendCommand.TabIndex = 1;
            this.BtnSendCommand.TabStop = false;
            this.BtnSendCommand.Text = "Send Command";
            this.BtnSendCommand.UseVisualStyleBackColor = true;
            this.BtnSendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.BaseTabControl = this.TabControl;
            this.Tabs.Depth = 0;
            this.Tabs.Location = new System.Drawing.Point(0, 64);
            this.Tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(683, 40);
            this.Tabs.TabIndex = 1;
            this.Tabs.TabStop = false;
            this.Tabs.Text = "materialTabSelector1";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.RconTab);
            this.TabControl.Controls.Add(this.SettingsTab);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(0, 110);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(683, 152);
            this.TabControl.TabIndex = 2;
            this.TabControl.TabStop = false;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // RconTab
            // 
            this.RconTab.BackColor = System.Drawing.Color.White;
            this.RconTab.Controls.Add(this.LblCommand);
            this.RconTab.Controls.Add(this.TbxCommand);
            this.RconTab.Controls.Add(this.BtnSendCommand);
            this.RconTab.Location = new System.Drawing.Point(4, 22);
            this.RconTab.Name = "RconTab";
            this.RconTab.Padding = new System.Windows.Forms.Padding(3);
            this.RconTab.Size = new System.Drawing.Size(675, 126);
            this.RconTab.TabIndex = 0;
            this.RconTab.Text = "RCON";
            // 
            // LblCommand
            // 
            this.LblCommand.AutoSize = true;
            this.LblCommand.Depth = 0;
            this.LblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCommand.Location = new System.Drawing.Point(6, 3);
            this.LblCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCommand.Name = "LblCommand";
            this.LblCommand.Size = new System.Drawing.Size(82, 19);
            this.LblCommand.TabIndex = 2;
            this.LblCommand.Text = "Command:";
            // 
            // TbxCommand
            // 
            this.TbxCommand.Depth = 0;
            this.TbxCommand.Hint = "kick $1";
            this.TbxCommand.Location = new System.Drawing.Point(10, 25);
            this.TbxCommand.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbxCommand.Name = "TbxCommand";
            this.TbxCommand.PasswordChar = '\0';
            this.TbxCommand.SelectedText = "";
            this.TbxCommand.SelectionLength = 0;
            this.TbxCommand.SelectionStart = 0;
            this.TbxCommand.Size = new System.Drawing.Size(657, 23);
            this.TbxCommand.TabIndex = 0;
            this.TbxCommand.UseSystemPasswordChar = false;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.White;
            this.SettingsTab.Controls.Add(this.ChkShowPassword);
            this.SettingsTab.Controls.Add(this.LbLMessageFormat);
            this.SettingsTab.Controls.Add(this.TbxMessageFormat);
            this.SettingsTab.Controls.Add(this.LbLServerPassword);
            this.SettingsTab.Controls.Add(this.TbxServerPassword);
            this.SettingsTab.Controls.Add(this.LblServerPort);
            this.SettingsTab.Controls.Add(this.TbxServerPort);
            this.SettingsTab.Controls.Add(this.LblServerAddress);
            this.SettingsTab.Controls.Add(this.TbxServerAddress);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(675, 126);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // LbLMessageFormat
            // 
            this.LbLMessageFormat.AutoSize = true;
            this.LbLMessageFormat.Depth = 0;
            this.LbLMessageFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbLMessageFormat.Location = new System.Drawing.Point(51, 89);
            this.LbLMessageFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbLMessageFormat.Name = "LbLMessageFormat";
            this.LbLMessageFormat.Size = new System.Drawing.Size(126, 19);
            this.LbLMessageFormat.TabIndex = 7;
            this.LbLMessageFormat.Text = "Message Format:";
            // 
            // TbxMessageFormat
            // 
            this.TbxMessageFormat.Depth = 0;
            this.TbxMessageFormat.Hint = "{message}";
            this.TbxMessageFormat.Location = new System.Drawing.Point(183, 89);
            this.TbxMessageFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbxMessageFormat.Name = "TbxMessageFormat";
            this.TbxMessageFormat.PasswordChar = '\0';
            this.TbxMessageFormat.SelectedText = "";
            this.TbxMessageFormat.SelectionLength = 0;
            this.TbxMessageFormat.SelectionStart = 0;
            this.TbxMessageFormat.Size = new System.Drawing.Size(484, 23);
            this.TbxMessageFormat.TabIndex = 3;
            this.TbxMessageFormat.UseSystemPasswordChar = false;
            this.TbxMessageFormat.TextChanged += new System.EventHandler(this.SettingTextChanged);
            // 
            // LbLServerPassword
            // 
            this.LbLServerPassword.AutoSize = true;
            this.LbLServerPassword.Depth = 0;
            this.LbLServerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbLServerPassword.Location = new System.Drawing.Point(8, 61);
            this.LbLServerPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.LbLServerPassword.Name = "LbLServerPassword";
            this.LbLServerPassword.Size = new System.Drawing.Size(169, 19);
            this.LbLServerPassword.TabIndex = 5;
            this.LbLServerPassword.Text = "RCON Server Password:";
            // 
            // TbxServerPassword
            // 
            this.TbxServerPassword.Depth = 0;
            this.TbxServerPassword.Hint = "securePassword";
            this.TbxServerPassword.Location = new System.Drawing.Point(183, 60);
            this.TbxServerPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbxServerPassword.Name = "TbxServerPassword";
            this.TbxServerPassword.PasswordChar = '•';
            this.TbxServerPassword.SelectedText = "";
            this.TbxServerPassword.SelectionLength = 0;
            this.TbxServerPassword.SelectionStart = 0;
            this.TbxServerPassword.Size = new System.Drawing.Size(358, 23);
            this.TbxServerPassword.TabIndex = 2;
            this.TbxServerPassword.UseSystemPasswordChar = false;
            this.TbxServerPassword.TextChanged += new System.EventHandler(this.SettingTextChanged);
            // 
            // LblServerPort
            // 
            this.LblServerPort.AutoSize = true;
            this.LblServerPort.Depth = 0;
            this.LblServerPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblServerPort.Location = new System.Drawing.Point(46, 32);
            this.LblServerPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblServerPort.Name = "LblServerPort";
            this.LblServerPort.Size = new System.Drawing.Size(131, 19);
            this.LblServerPort.TabIndex = 3;
            this.LblServerPort.Text = "RCON Server Port:";
            // 
            // TbxServerPort
            // 
            this.TbxServerPort.Depth = 0;
            this.TbxServerPort.Hint = "21026";
            this.TbxServerPort.Location = new System.Drawing.Point(183, 32);
            this.TbxServerPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbxServerPort.Name = "TbxServerPort";
            this.TbxServerPort.PasswordChar = '\0';
            this.TbxServerPort.SelectedText = "";
            this.TbxServerPort.SelectionLength = 0;
            this.TbxServerPort.SelectionStart = 0;
            this.TbxServerPort.Size = new System.Drawing.Size(486, 23);
            this.TbxServerPort.TabIndex = 1;
            this.TbxServerPort.Text = "21026";
            this.TbxServerPort.UseSystemPasswordChar = false;
            this.TbxServerPort.TextChanged += new System.EventHandler(this.SettingTextChanged);
            // 
            // LblServerAddress
            // 
            this.LblServerAddress.AutoSize = true;
            this.LblServerAddress.Depth = 0;
            this.LblServerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblServerAddress.Location = new System.Drawing.Point(63, 3);
            this.LblServerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblServerAddress.Name = "LblServerAddress";
            this.LblServerAddress.Size = new System.Drawing.Size(114, 19);
            this.LblServerAddress.TabIndex = 1;
            this.LblServerAddress.Text = "Server Address:";
            // 
            // TbxServerAddress
            // 
            this.TbxServerAddress.Depth = 0;
            this.TbxServerAddress.Hint = "127.0.0.1";
            this.TbxServerAddress.Location = new System.Drawing.Point(183, 3);
            this.TbxServerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbxServerAddress.Name = "TbxServerAddress";
            this.TbxServerAddress.PasswordChar = '\0';
            this.TbxServerAddress.SelectedText = "";
            this.TbxServerAddress.SelectionLength = 0;
            this.TbxServerAddress.SelectionStart = 0;
            this.TbxServerAddress.Size = new System.Drawing.Size(486, 23);
            this.TbxServerAddress.TabIndex = 0;
            this.TbxServerAddress.Text = "127.0.0.1";
            this.TbxServerAddress.UseSystemPasswordChar = false;
            this.TbxServerAddress.TextChanged += new System.EventHandler(this.SettingTextChanged);
            // 
            // RtbxOutput
            // 
            this.RtbxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbxOutput.Location = new System.Drawing.Point(12, 239);
            this.RtbxOutput.Name = "RtbxOutput";
            this.RtbxOutput.ReadOnly = true;
            this.RtbxOutput.Size = new System.Drawing.Size(659, 281);
            this.RtbxOutput.TabIndex = 4;
            this.RtbxOutput.Text = "";
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.Depth = 0;
            this.ChkShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkShowPassword.Location = new System.Drawing.Point(544, 58);
            this.ChkShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ChkShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Ripple = true;
            this.ChkShowPassword.Size = new System.Drawing.Size(128, 30);
            this.ChkShowPassword.TabIndex = 8;
            this.ChkShowPassword.Text = "Show Password";
            this.ChkShowPassword.UseVisualStyleBackColor = true;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 532);
            this.Controls.Add(this.RtbxOutput);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Tabs);
            this.Name = "MainForm";
            this.Text = "Starbound RCON Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.RconTab.ResumeLayout(false);
            this.RconTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton BtnSendCommand;
        private MaterialSkin.Controls.MaterialTabSelector Tabs;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage RconTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbxServerAddress;
        private MaterialSkin.Controls.MaterialLabel LblServerAddress;
        private MaterialSkin.Controls.MaterialLabel LblServerPort;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbxServerPort;
        private MaterialSkin.Controls.MaterialLabel LbLServerPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbxServerPassword;
        private MaterialSkin.Controls.MaterialLabel LbLMessageFormat;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbxMessageFormat;
        private System.Windows.Forms.RichTextBox RtbxOutput;
        private MaterialSkin.Controls.MaterialLabel LblCommand;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbxCommand;
        private MaterialSkin.Controls.MaterialCheckBox ChkShowPassword;
    }
}

