using System;

namespace Client
{
    partial class Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabChat = new MetroFramework.Controls.MetroTabPage();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.lstClientList = new System.Windows.Forms.ListBox();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.rdoDefault = new MetroFramework.Controls.MetroRadioButton();
            this.rdoManual = new MetroFramework.Controls.MetroRadioButton();
            this.btnCheckPort = new MetroFramework.Controls.MetroButton();
            this.btnCheckIP = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lblDisplayName = new MetroFramework.Controls.MetroLabel();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.txtPortNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblIPAddress = new MetroFramework.Controls.MetroLabel();
            this.txtIPAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroControl = new MetroFramework.Controls.MetroTabControl();
            this.lstMessageBox = new System.Windows.Forms.DataGridView();
            this.Composer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChat.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.metroControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMessageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.lstMessageBox);
            this.tabChat.Controls.Add(this.txtMessage);
            this.tabChat.Controls.Add(this.btnSend);
            this.tabChat.Controls.Add(this.lstClientList);
            this.tabChat.HorizontalScrollbarBarColor = true;
            this.tabChat.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChat.HorizontalScrollbarSize = 10;
            this.tabChat.Location = new System.Drawing.Point(4, 38);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(552, 378);
            this.tabChat.TabIndex = 1;
            this.tabChat.Text = "Chat Room";
            this.tabChat.VerticalScrollbarBarColor = true;
            this.tabChat.VerticalScrollbarHighlightOnWheel = false;
            this.tabChat.VerticalScrollbarSize = 10;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(287, 1);
            this.txtMessage.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(159, 351);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(309, 23);
            this.txtMessage.TabIndex = 13;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(474, 351);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstClientList
            // 
            this.lstClientList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClientList.FormattingEnabled = true;
            this.lstClientList.Location = new System.Drawing.Point(3, 3);
            this.lstClientList.Name = "lstClientList";
            this.lstClientList.Size = new System.Drawing.Size(150, 342);
            this.lstClientList.TabIndex = 5;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.rdoDefault);
            this.tabSettings.Controls.Add(this.rdoManual);
            this.tabSettings.Controls.Add(this.btnCheckPort);
            this.tabSettings.Controls.Add(this.btnCheckIP);
            this.tabSettings.Controls.Add(this.btnConnect);
            this.tabSettings.Controls.Add(this.txtUsername);
            this.tabSettings.Controls.Add(this.lblDisplayName);
            this.tabSettings.Controls.Add(this.lblPort);
            this.tabSettings.Controls.Add(this.txtPortNumber);
            this.tabSettings.Controls.Add(this.lblIPAddress);
            this.tabSettings.Controls.Add(this.txtIPAddress);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(552, 378);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // rdoDefault
            // 
            this.rdoDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoDefault.AutoSize = true;
            this.rdoDefault.Location = new System.Drawing.Point(300, 104);
            this.rdoDefault.Name = "rdoDefault";
            this.rdoDefault.Size = new System.Drawing.Size(61, 15);
            this.rdoDefault.Style = MetroFramework.MetroColorStyle.Orange;
            this.rdoDefault.TabIndex = 87;
            this.rdoDefault.Text = "Default";
            this.rdoDefault.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdoDefault.UseSelectable = true;
            // 
            // rdoManual
            // 
            this.rdoManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoManual.AutoSize = true;
            this.rdoManual.Checked = true;
            this.rdoManual.Location = new System.Drawing.Point(199, 104);
            this.rdoManual.Name = "rdoManual";
            this.rdoManual.Size = new System.Drawing.Size(63, 15);
            this.rdoManual.Style = MetroFramework.MetroColorStyle.Orange;
            this.rdoManual.TabIndex = 86;
            this.rdoManual.TabStop = true;
            this.rdoManual.Text = "Manual";
            this.rdoManual.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdoManual.UseSelectable = true;
            // 
            // btnCheckPort
            // 
            this.btnCheckPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckPort.Location = new System.Drawing.Point(377, 202);
            this.btnCheckPort.Name = "btnCheckPort";
            this.btnCheckPort.Size = new System.Drawing.Size(85, 23);
            this.btnCheckPort.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCheckPort.TabIndex = 85;
            this.btnCheckPort.Text = "Check";
            this.btnCheckPort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCheckPort.UseSelectable = true;
            this.btnCheckPort.Visible = false;
            // 
            // btnCheckIP
            // 
            this.btnCheckIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckIP.Location = new System.Drawing.Point(377, 170);
            this.btnCheckIP.Name = "btnCheckIP";
            this.btnCheckIP.Size = new System.Drawing.Size(85, 23);
            this.btnCheckIP.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCheckIP.TabIndex = 84;
            this.btnCheckIP.Text = "Check";
            this.btnCheckIP.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCheckIP.UseSelectable = true;
            this.btnCheckIP.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(199, 241);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(162, 23);
            this.btnConnect.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnConnect.TabIndex = 83;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnConnect.UseSelectable = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(199, 139);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Enter A Nickname..";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(162, 23);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtUsername.TabIndex = 82;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Enter A Nickname..";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(93, 140);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(93, 19);
            this.lblDisplayName.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblDisplayName.TabIndex = 81;
            this.lblDisplayName.Text = "Display Name:";
            this.lblDisplayName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(93, 204);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(91, 19);
            this.lblPort.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblPort.TabIndex = 80;
            this.lblPort.Text = "Port Number:";
            this.lblPort.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPortNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPortNumber.CustomButton.Image = null;
            this.txtPortNumber.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtPortNumber.CustomButton.Name = "";
            this.txtPortNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPortNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPortNumber.CustomButton.TabIndex = 1;
            this.txtPortNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPortNumber.CustomButton.UseSelectable = true;
            this.txtPortNumber.CustomButton.Visible = false;
            this.txtPortNumber.Lines = new string[0];
            this.txtPortNumber.Location = new System.Drawing.Point(199, 202);
            this.txtPortNumber.MaxLength = 32767;
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.PasswordChar = '\0';
            this.txtPortNumber.PromptText = "Enter A Port Number..";
            this.txtPortNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPortNumber.SelectedText = "";
            this.txtPortNumber.SelectionLength = 0;
            this.txtPortNumber.SelectionStart = 0;
            this.txtPortNumber.ShortcutsEnabled = true;
            this.txtPortNumber.Size = new System.Drawing.Size(162, 23);
            this.txtPortNumber.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtPortNumber.TabIndex = 79;
            this.txtPortNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPortNumber.UseSelectable = true;
            this.txtPortNumber.WaterMark = "Enter A Port Number..";
            this.txtPortNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPortNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(93, 173);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(74, 19);
            this.lblIPAddress.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblIPAddress.TabIndex = 78;
            this.lblIPAddress.Text = "IP Address:";
            this.lblIPAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIPAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIPAddress.CustomButton.Image = null;
            this.txtIPAddress.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtIPAddress.CustomButton.Name = "";
            this.txtIPAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIPAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIPAddress.CustomButton.TabIndex = 1;
            this.txtIPAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIPAddress.CustomButton.UseSelectable = true;
            this.txtIPAddress.CustomButton.Visible = false;
            this.txtIPAddress.Lines = new string[0];
            this.txtIPAddress.Location = new System.Drawing.Point(199, 170);
            this.txtIPAddress.MaxLength = 32767;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.PasswordChar = '\0';
            this.txtIPAddress.PromptText = "Enter An IP Address..";
            this.txtIPAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIPAddress.SelectedText = "";
            this.txtIPAddress.SelectionLength = 0;
            this.txtIPAddress.SelectionStart = 0;
            this.txtIPAddress.ShortcutsEnabled = true;
            this.txtIPAddress.Size = new System.Drawing.Size(162, 23);
            this.txtIPAddress.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtIPAddress.TabIndex = 77;
            this.txtIPAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIPAddress.UseSelectable = true;
            this.txtIPAddress.WaterMark = "Enter An IP Address..";
            this.txtIPAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIPAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroControl
            // 
            this.metroControl.Controls.Add(this.tabSettings);
            this.metroControl.Controls.Add(this.tabChat);
            this.metroControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroControl.Location = new System.Drawing.Point(20, 60);
            this.metroControl.Name = "metroControl";
            this.metroControl.SelectedIndex = 1;
            this.metroControl.Size = new System.Drawing.Size(560, 420);
            this.metroControl.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroControl.TabIndex = 1;
            this.metroControl.UseSelectable = true;
            // 
            // lstMessageBox
            // 
            this.lstMessageBox.AllowUserToAddRows = false;
            this.lstMessageBox.AllowUserToDeleteRows = false;
            this.lstMessageBox.AllowUserToResizeRows = false;
            this.lstMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessageBox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lstMessageBox.BackgroundColor = System.Drawing.Color.White;
            this.lstMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMessageBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.lstMessageBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMessageBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Composer,
            this.Message,
            this.Created});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstMessageBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.lstMessageBox.Location = new System.Drawing.Point(159, 3);
            this.lstMessageBox.MultiSelect = false;
            this.lstMessageBox.Name = "lstMessageBox";
            this.lstMessageBox.ReadOnly = true;
            this.lstMessageBox.RowHeadersVisible = false;
            this.lstMessageBox.RowTemplate.ReadOnly = true;
            this.lstMessageBox.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lstMessageBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstMessageBox.ShowCellToolTips = false;
            this.lstMessageBox.ShowEditingIcon = false;
            this.lstMessageBox.Size = new System.Drawing.Size(390, 342);
            this.lstMessageBox.TabIndex = 14;
            // 
            // Composer
            // 
            this.Composer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Composer.HeaderText = "Composer";
            this.Composer.Name = "Composer";
            this.Composer.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Created
            // 
            this.Created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Created.HeaderText = "Created";
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.metroControl);
            this.Name = "Client";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Client";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tabChat.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.metroControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstMessageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabChat;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroTabControl metroControl;
        private System.Windows.Forms.ListBox lstClientList;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroRadioButton rdoDefault;
        private MetroFramework.Controls.MetroRadioButton rdoManual;
        private MetroFramework.Controls.MetroButton btnCheckPort;
        private MetroFramework.Controls.MetroButton btnCheckIP;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel lblDisplayName;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroTextBox txtPortNumber;
        private MetroFramework.Controls.MetroLabel lblIPAddress;
        private MetroFramework.Controls.MetroTextBox txtIPAddress;
        private System.Windows.Forms.DataGridView lstMessageBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
    }
}