namespace CorsairRollBot_WF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Select_POLID = new System.Windows.Forms.Button();
            this.POLID = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RollTwo_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.RollOne_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RandomDeal_Switch = new MetroFramework.Controls.MetroToggle();
            this.SnakeEye_Switch = new MetroFramework.Controls.MetroToggle();
            this.CrookedCards_Switch = new MetroFramework.Controls.MetroToggle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CurrentRoll_Number = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AddonActive = new System.Windows.Forms.Button();
            this.ActivityButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ReloadParty = new System.Windows.Forms.Button();
            this.PartyMembersRequired = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.FollowerTarget = new MetroFramework.Controls.MetroTextBox();
            this.Roll_Timer = new System.Windows.Forms.Timer(this.components);
            this.Follow_Timer = new System.Windows.Forms.Timer(this.components);
            this.AddonReader = new System.ComponentModel.BackgroundWorker();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.DEBUG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Select_POLID);
            this.groupBox1.Controls.Add(this.POLID);
            this.groupBox1.Location = new System.Drawing.Point(11, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Process:";
            // 
            // Select_POLID
            // 
            this.Select_POLID.Location = new System.Drawing.Point(280, 15);
            this.Select_POLID.Name = "Select_POLID";
            this.Select_POLID.Size = new System.Drawing.Size(111, 31);
            this.Select_POLID.TabIndex = 3;
            this.Select_POLID.Text = "SELECT";
            this.Select_POLID.UseVisualStyleBackColor = true;
            this.Select_POLID.Click += new System.EventHandler(this.Select_POLID_Click);
            // 
            // POLID
            // 
            this.POLID.FormattingEnabled = true;
            this.POLID.ItemHeight = 23;
            this.POLID.Location = new System.Drawing.Point(7, 16);
            this.POLID.Name = "POLID";
            this.POLID.Size = new System.Drawing.Size(266, 29);
            this.POLID.TabIndex = 2;
            this.POLID.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RollTwo_ComboBox);
            this.groupBox2.Controls.Add(this.RollOne_ComboBox);
            this.groupBox2.Location = new System.Drawing.Point(11, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Corsair Rolls: ";
            // 
            // RollTwo_ComboBox
            // 
            this.RollTwo_ComboBox.FormattingEnabled = true;
            this.RollTwo_ComboBox.ItemHeight = 23;
            this.RollTwo_ComboBox.Items.AddRange(new object[] {
            "Corsair\'s Roll ",
            "Ninja Roll ",
            "Hunter\'s Roll ",
            "Chaos Roll ",
            "Magus\'s Roll ",
            "Healer\'s Roll ",
            "Drachen Roll ",
            "Choral Roll ",
            "Monk\'s Roll ",
            "Beast Roll ",
            "Samurai Roll ",
            "Evoker\'s Roll ",
            "Rogue\'s Roll ",
            "Warlock\'s Roll ",
            "Fighter\'s Roll ",
            "Puppet Roll ",
            "Gallant\'s Roll ",
            "Wizard\'s Roll ",
            "Dancer\'s Roll ",
            "Scholar\'s Roll ",
            "Naturalist\'s Roll ",
            "Runeist\'s Roll ",
            "Bolter\'s Roll ",
            "Caster\'s Roll ",
            "Courser\'s Roll ",
            "Blitzer\'s Roll ",
            "Tactician\'s Roll ",
            "Allies\' Roll ",
            "Miser\'s Roll ",
            "Companion\'s Roll ",
            "Avenger\'s Roll "});
            this.RollTwo_ComboBox.Location = new System.Drawing.Point(7, 55);
            this.RollTwo_ComboBox.MaxDropDownItems = 5;
            this.RollTwo_ComboBox.Name = "RollTwo_ComboBox";
            this.RollTwo_ComboBox.Size = new System.Drawing.Size(215, 29);
            this.RollTwo_ComboBox.TabIndex = 3;
            this.RollTwo_ComboBox.UseSelectable = true;
            // 
            // RollOne_ComboBox
            // 
            this.RollOne_ComboBox.FormattingEnabled = true;
            this.RollOne_ComboBox.ItemHeight = 23;
            this.RollOne_ComboBox.Items.AddRange(new object[] {
            "Corsair\'s Roll ",
            "Ninja Roll ",
            "Hunter\'s Roll ",
            "Chaos Roll ",
            "Magus\'s Roll ",
            "Healer\'s Roll ",
            "Drachen Roll ",
            "Choral Roll ",
            "Monk\'s Roll ",
            "Beast Roll ",
            "Samurai Roll ",
            "Evoker\'s Roll ",
            "Rogue\'s Roll ",
            "Warlock\'s Roll ",
            "Fighter\'s Roll ",
            "Puppet Roll ",
            "Gallant\'s Roll ",
            "Wizard\'s Roll ",
            "Dancer\'s Roll ",
            "Scholar\'s Roll ",
            "Naturalist\'s Roll ",
            "Runeist\'s Roll ",
            "Bolter\'s Roll ",
            "Caster\'s Roll ",
            "Courser\'s Roll ",
            "Blitzer\'s Roll ",
            "Tactician\'s Roll ",
            "Allies\' Roll ",
            "Miser\'s Roll ",
            "Companion\'s Roll ",
            "Avenger\'s Roll "});
            this.RollOne_ComboBox.Location = new System.Drawing.Point(6, 19);
            this.RollOne_ComboBox.MaxDropDownItems = 5;
            this.RollOne_ComboBox.Name = "RollOne_ComboBox";
            this.RollOne_ComboBox.Size = new System.Drawing.Size(216, 29);
            this.RollOne_ComboBox.TabIndex = 2;
            this.RollOne_ComboBox.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.RandomDeal_Switch);
            this.groupBox3.Controls.Add(this.SnakeEye_Switch);
            this.groupBox3.Controls.Add(this.CrookedCards_Switch);
            this.groupBox3.Location = new System.Drawing.Point(11, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Corsair Job Abilities: ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Random Deal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Snake Eye";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Crooked Cards";
            // 
            // RandomDeal_Switch
            // 
            this.RandomDeal_Switch.AutoSize = true;
            this.RandomDeal_Switch.DisplayStatus = false;
            this.RandomDeal_Switch.Location = new System.Drawing.Point(120, 82);
            this.RandomDeal_Switch.Name = "RandomDeal_Switch";
            this.RandomDeal_Switch.Size = new System.Drawing.Size(50, 17);
            this.RandomDeal_Switch.TabIndex = 2;
            this.RandomDeal_Switch.Text = "Off";
            this.RandomDeal_Switch.UseSelectable = true;
            // 
            // SnakeEye_Switch
            // 
            this.SnakeEye_Switch.AutoSize = true;
            this.SnakeEye_Switch.DisplayStatus = false;
            this.SnakeEye_Switch.Location = new System.Drawing.Point(120, 52);
            this.SnakeEye_Switch.Name = "SnakeEye_Switch";
            this.SnakeEye_Switch.Size = new System.Drawing.Size(50, 17);
            this.SnakeEye_Switch.TabIndex = 1;
            this.SnakeEye_Switch.Text = "Off";
            this.SnakeEye_Switch.UseSelectable = true;
            // 
            // CrookedCards_Switch
            // 
            this.CrookedCards_Switch.AutoSize = true;
            this.CrookedCards_Switch.DisplayStatus = false;
            this.CrookedCards_Switch.Location = new System.Drawing.Point(120, 22);
            this.CrookedCards_Switch.Name = "CrookedCards_Switch";
            this.CrookedCards_Switch.Size = new System.Drawing.Size(50, 17);
            this.CrookedCards_Switch.TabIndex = 0;
            this.CrookedCards_Switch.Text = "Off";
            this.CrookedCards_Switch.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CurrentRoll_Number);
            this.groupBox4.Location = new System.Drawing.Point(11, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 90);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Roll: ";
            // 
            // CurrentRoll_Number
            // 
            this.CurrentRoll_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRoll_Number.Location = new System.Drawing.Point(6, 17);
            this.CurrentRoll_Number.Name = "CurrentRoll_Number";
            this.CurrentRoll_Number.Size = new System.Drawing.Size(98, 67);
            this.CurrentRoll_Number.TabIndex = 0;
            this.CurrentRoll_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AddonActive);
            this.groupBox5.Location = new System.Drawing.Point(123, 348);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 90);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Addon Active: ";
            this.metroToolTip1.SetToolTip(this.groupBox5, "Click this to send a request for verification.");
            // 
            // AddonActive
            // 
            this.AddonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddonActive.Location = new System.Drawing.Point(7, 20);
            this.AddonActive.Name = "AddonActive";
            this.AddonActive.Size = new System.Drawing.Size(100, 57);
            this.AddonActive.TabIndex = 0;
            this.AddonActive.Text = "NO";
            this.metroToolTip1.SetToolTip(this.AddonActive, "Click this to send a request for verification.");
            this.AddonActive.UseVisualStyleBackColor = true;
            this.AddonActive.Click += new System.EventHandler(this.AddonActive_Click);
            // 
            // ActivityButton
            // 
            this.ActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityButton.Location = new System.Drawing.Point(245, 395);
            this.ActivityButton.Name = "ActivityButton";
            this.ActivityButton.Size = new System.Drawing.Size(163, 43);
            this.ActivityButton.TabIndex = 6;
            this.ActivityButton.Text = "START";
            this.ActivityButton.UseVisualStyleBackColor = true;
            this.ActivityButton.Click += new System.EventHandler(this.ActivityButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ReloadParty);
            this.groupBox6.Controls.Add(this.PartyMembersRequired);
            this.groupBox6.Location = new System.Drawing.Point(245, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 205);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Required Members: ";
            // 
            // ReloadParty
            // 
            this.ReloadParty.Location = new System.Drawing.Point(76, 172);
            this.ReloadParty.Name = "ReloadParty";
            this.ReloadParty.Size = new System.Drawing.Size(75, 23);
            this.ReloadParty.TabIndex = 1;
            this.ReloadParty.Text = "reload";
            this.ReloadParty.UseVisualStyleBackColor = true;
            this.ReloadParty.Click += new System.EventHandler(this.ReloadParty_Click);
            // 
            // PartyMembersRequired
            // 
            this.PartyMembersRequired.FormattingEnabled = true;
            this.PartyMembersRequired.Location = new System.Drawing.Point(6, 19);
            this.PartyMembersRequired.Name = "PartyMembersRequired";
            this.PartyMembersRequired.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PartyMembersRequired.Size = new System.Drawing.Size(145, 147);
            this.PartyMembersRequired.TabIndex = 0;
            this.PartyMembersRequired.SelectedValueChanged += new System.EventHandler(this.PartyMembersRequired_SelectedValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FollowerTarget);
            this.groupBox7.Location = new System.Drawing.Point(245, 335);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 54);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Follow Target: ";
            // 
            // FollowerTarget
            // 
            // 
            // 
            // 
            this.FollowerTarget.CustomButton.Image = null;
            this.FollowerTarget.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.FollowerTarget.CustomButton.Name = "";
            this.FollowerTarget.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FollowerTarget.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FollowerTarget.CustomButton.TabIndex = 1;
            this.FollowerTarget.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FollowerTarget.CustomButton.UseSelectable = true;
            this.FollowerTarget.CustomButton.Visible = false;
            this.FollowerTarget.Lines = new string[] {
        "Follower target name."};
            this.FollowerTarget.Location = new System.Drawing.Point(6, 20);
            this.FollowerTarget.MaxLength = 32767;
            this.FollowerTarget.Name = "FollowerTarget";
            this.FollowerTarget.PasswordChar = '\0';
            this.FollowerTarget.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FollowerTarget.SelectedText = "";
            this.FollowerTarget.SelectionLength = 0;
            this.FollowerTarget.SelectionStart = 0;
            this.FollowerTarget.ShortcutsEnabled = true;
            this.FollowerTarget.Size = new System.Drawing.Size(151, 23);
            this.FollowerTarget.TabIndex = 0;
            this.FollowerTarget.Text = "Follower target name.";
            this.FollowerTarget.UseSelectable = true;
            this.FollowerTarget.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FollowerTarget.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Roll_Timer
            // 
            this.Roll_Timer.Enabled = true;
            this.Roll_Timer.Interval = 500;
            this.Roll_Timer.Tick += new System.EventHandler(this.Roll_Timer_TickAsync);
            // 
            // Follow_Timer
            // 
            this.Follow_Timer.Interval = 500;
            this.Follow_Timer.Tick += new System.EventHandler(this.Follow_Timer_Tick);
            // 
            // AddonReader
            // 
            this.AddonReader.WorkerReportsProgress = true;
            this.AddonReader.WorkerSupportsCancellation = true;
            this.AddonReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AddonReader_DoWork);
            this.AddonReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AddonReader_RunWorkerCompleted);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DEBUG
            // 
            this.DEBUG.Location = new System.Drawing.Point(333, 34);
            this.DEBUG.Name = "DEBUG";
            this.DEBUG.Size = new System.Drawing.Size(75, 23);
            this.DEBUG.TabIndex = 9;
            this.DEBUG.Text = "DEBUG";
            this.DEBUG.UseVisualStyleBackColor = true;
            this.DEBUG.Visible = false;
            this.DEBUG.Click += new System.EventHandler(this.DEBUG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 452);
            this.Controls.Add(this.DEBUG);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ActivityButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Corsair Roll Bot v2.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label CurrentRoll_Number;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroToggle RandomDeal_Switch;
        private MetroFramework.Controls.MetroToggle SnakeEye_Switch;
        private MetroFramework.Controls.MetroToggle CrookedCards_Switch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button ActivityButton;
        private MetroFramework.Controls.MetroComboBox RollTwo_ComboBox;
        private MetroFramework.Controls.MetroComboBox RollOne_ComboBox;
        private MetroFramework.Controls.MetroComboBox POLID;
        private System.Windows.Forms.Button Select_POLID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroTextBox FollowerTarget;
        private System.Windows.Forms.Timer Roll_Timer;
        private System.Windows.Forms.Timer Follow_Timer;
        private System.ComponentModel.BackgroundWorker AddonReader;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Button AddonActive;
        private System.Windows.Forms.Button DEBUG;
        private System.Windows.Forms.ListBox PartyMembersRequired;
        private System.Windows.Forms.Button ReloadParty;
    }
}
