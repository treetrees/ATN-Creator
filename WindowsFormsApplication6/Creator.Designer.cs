namespace ATNCreator
{
    partial class Creator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.npc_template = new System.Windows.Forms.ListBox();
            this.npcart_box = new System.Windows.Forms.GroupBox();
            this.npc_faction = new System.Windows.Forms.ListBox();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.npc_name = new System.Windows.Forms.TextBox();
            this.npc_guild = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npcinfo_box = new System.Windows.Forms.GroupBox();
            this.npc_entry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.npcaussehen_box = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wappenrock = new System.Windows.Forms.TextBox();
            this.armschienen = new System.Windows.Forms.TextBox();
            this.Füße = new System.Windows.Forms.TextBox();
            this.beine = new System.Windows.Forms.TextBox();
            this.gürtel = new System.Windows.Forms.TextBox();
            this.hände = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Hemd = new System.Windows.Forms.TextBox();
            this.Brust = new System.Windows.Forms.TextBox();
            this.Rücken = new System.Windows.Forms.TextBox();
            this.schultern = new System.Windows.Forms.TextBox();
            this.kopf = new System.Windows.Forms.TextBox();
            this.npc_gender = new System.Windows.Forms.ListBox();
            this.npc_race = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.npc_default_button = new System.Windows.Forms.Button();
            this.npc_create_button = new System.Windows.Forms.Button();
            this.npc_model_box = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ENTWEDER = new System.Windows.Forms.Label();
            this.npc_modelid = new System.Windows.Forms.TextBox();
            this.npcwaffen_box = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.npc_distance = new System.Windows.Forms.TextBox();
            this.npc_offhand = new System.Windows.Forms.TextBox();
            this.npc_mainhand = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.npcart_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.npcinfo_box.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.npcaussehen_box.SuspendLayout();
            this.npc_model_box.SuspendLayout();
            this.npcwaffen_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // npc_template
            // 
            this.npc_template.FormattingEnabled = true;
            this.npc_template.Items.AddRange(new object[] {
            "Ohne Aufgabe",
            "Wache",
            "Questgeber",
            "Händler",
            "Lehrer",
            "Gegner",
            "Boss",
            "Elite Mob",
            "Gossip"});
            this.npc_template.Location = new System.Drawing.Point(6, 19);
            this.npc_template.Name = "npc_template";
            this.npc_template.Size = new System.Drawing.Size(120, 108);
            this.npc_template.TabIndex = 0;
            this.npc_template.SelectedIndexChanged += new System.EventHandler(this.Template_SelectedIndexChanged);
            // 
            // npcart_box
            // 
            this.npcart_box.Controls.Add(this.npc_faction);
            this.npcart_box.Controls.Add(this.npc_template);
            this.npcart_box.Location = new System.Drawing.Point(6, 6);
            this.npcart_box.Name = "npcart_box";
            this.npcart_box.Size = new System.Drawing.Size(268, 149);
            this.npcart_box.TabIndex = 2;
            this.npcart_box.TabStop = false;
            this.npcart_box.Text = "NPC Art";
            // 
            // npc_faction
            // 
            this.npc_faction.FormattingEnabled = true;
            this.npc_faction.Items.AddRange(new object[] {
            "Horde",
            "Allianz",
            "Neutral",
            "Feindlich"});
            this.npc_faction.Location = new System.Drawing.Point(132, 19);
            this.npc_faction.Name = "npc_faction";
            this.npc_faction.Size = new System.Drawing.Size(121, 108);
            this.npc_faction.TabIndex = 1;
            this.npc_faction.SelectedIndexChanged += new System.EventHandler(this.npc_faction_SelectedIndexChanged);
            // 
            // npc_name
            // 
            this.npc_name.Location = new System.Drawing.Point(6, 32);
            this.npc_name.Name = "npc_name";
            this.npc_name.Size = new System.Drawing.Size(100, 20);
            this.npc_name.TabIndex = 3;
            this.npc_name.TextChanged += new System.EventHandler(this.npc_name_TextChanged);
            // 
            // npc_guild
            // 
            this.npc_guild.Location = new System.Drawing.Point(6, 74);
            this.npc_guild.Name = "npc_guild";
            this.npc_guild.Size = new System.Drawing.Size(100, 20);
            this.npc_guild.TabIndex = 4;
            this.npc_guild.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // npcinfo_box
            // 
            this.npcinfo_box.Controls.Add(this.npc_entry);
            this.npcinfo_box.Controls.Add(this.label3);
            this.npcinfo_box.Controls.Add(this.label2);
            this.npcinfo_box.Controls.Add(this.npc_guild);
            this.npcinfo_box.Controls.Add(this.label1);
            this.npcinfo_box.Controls.Add(this.npc_name);
            this.npcinfo_box.Location = new System.Drawing.Point(280, 6);
            this.npcinfo_box.Name = "npcinfo_box";
            this.npcinfo_box.Size = new System.Drawing.Size(119, 149);
            this.npcinfo_box.TabIndex = 6;
            this.npcinfo_box.TabStop = false;
            this.npcinfo_box.Text = "NPC Info";
            // 
            // npc_entry
            // 
            this.npc_entry.Location = new System.Drawing.Point(6, 113);
            this.npc_entry.Name = "npc_entry";
            this.npc_entry.Size = new System.Drawing.Size(100, 20);
            this.npc_entry.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NPC Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gildenname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 487);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.npcaussehen_box);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.npc_default_button);
            this.tabPage1.Controls.Add(this.npc_create_button);
            this.tabPage1.Controls.Add(this.npc_model_box);
            this.tabPage1.Controls.Add(this.npcwaffen_box);
            this.tabPage1.Controls.Add(this.npcart_box);
            this.tabPage1.Controls.Add(this.npcinfo_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NPC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // npcaussehen_box
            // 
            this.npcaussehen_box.Controls.Add(this.label10);
            this.npcaussehen_box.Controls.Add(this.wappenrock);
            this.npcaussehen_box.Controls.Add(this.armschienen);
            this.npcaussehen_box.Controls.Add(this.Füße);
            this.npcaussehen_box.Controls.Add(this.beine);
            this.npcaussehen_box.Controls.Add(this.gürtel);
            this.npcaussehen_box.Controls.Add(this.hände);
            this.npcaussehen_box.Controls.Add(this.label9);
            this.npcaussehen_box.Controls.Add(this.Hemd);
            this.npcaussehen_box.Controls.Add(this.Brust);
            this.npcaussehen_box.Controls.Add(this.Rücken);
            this.npcaussehen_box.Controls.Add(this.schultern);
            this.npcaussehen_box.Controls.Add(this.kopf);
            this.npcaussehen_box.Controls.Add(this.npc_gender);
            this.npcaussehen_box.Controls.Add(this.npc_race);
            this.npcaussehen_box.Location = new System.Drawing.Point(222, 161);
            this.npcaussehen_box.Name = "npcaussehen_box";
            this.npcaussehen_box.Size = new System.Drawing.Size(304, 289);
            this.npcaussehen_box.TabIndex = 11;
            this.npcaussehen_box.TabStop = false;
            this.npcaussehen_box.Text = "Neues Modell";
            this.npcaussehen_box.Enter += new System.EventHandler(this.npcaussehen_box_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Wichtig: Hier nur die Item Model Id eintragen!";
            // 
            // wappenrock
            // 
            this.wappenrock.Location = new System.Drawing.Point(7, 259);
            this.wappenrock.Name = "wappenrock";
            this.wappenrock.Size = new System.Drawing.Size(100, 20);
            this.wappenrock.TabIndex = 23;
            this.wappenrock.Text = "Wappenrock";
            this.wappenrock.Click += new System.EventHandler(this.ClearTextBox_click);
            this.wappenrock.TextChanged += new System.EventHandler(this.textBox6_TextChanged_2);
            // 
            // armschienen
            // 
            this.armschienen.Location = new System.Drawing.Point(183, 126);
            this.armschienen.Name = "armschienen";
            this.armschienen.Size = new System.Drawing.Size(100, 20);
            this.armschienen.TabIndex = 22;
            this.armschienen.Text = "Armschienen";
            this.armschienen.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // Füße
            // 
            this.Füße.Location = new System.Drawing.Point(183, 233);
            this.Füße.Name = "Füße";
            this.Füße.Size = new System.Drawing.Size(100, 20);
            this.Füße.TabIndex = 20;
            this.Füße.Text = "Füße";
            this.Füße.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // beine
            // 
            this.beine.Location = new System.Drawing.Point(183, 207);
            this.beine.Name = "beine";
            this.beine.Size = new System.Drawing.Size(100, 20);
            this.beine.TabIndex = 19;
            this.beine.Text = "Beine";
            this.beine.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // gürtel
            // 
            this.gürtel.Location = new System.Drawing.Point(183, 181);
            this.gürtel.Name = "gürtel";
            this.gürtel.Size = new System.Drawing.Size(100, 20);
            this.gürtel.TabIndex = 18;
            this.gürtel.Text = "Gürtel";
            this.gürtel.Click += new System.EventHandler(this.ClearTextBox_click);
            this.gürtel.TextChanged += new System.EventHandler(this.gürtel_TextChanged);
            // 
            // hände
            // 
            this.hände.Location = new System.Drawing.Point(183, 155);
            this.hände.Name = "hände";
            this.hände.Size = new System.Drawing.Size(100, 20);
            this.hände.TabIndex = 17;
            this.hände.Text = "Hände";
            this.hände.Click += new System.EventHandler(this.ClearTextBox_click);
            this.hände.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Item Model IDs";
            // 
            // Hemd
            // 
            this.Hemd.Location = new System.Drawing.Point(6, 233);
            this.Hemd.Name = "Hemd";
            this.Hemd.Size = new System.Drawing.Size(100, 20);
            this.Hemd.TabIndex = 13;
            this.Hemd.Text = "Hemd";
            this.Hemd.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // Brust
            // 
            this.Brust.Location = new System.Drawing.Point(6, 207);
            this.Brust.Name = "Brust";
            this.Brust.Size = new System.Drawing.Size(100, 20);
            this.Brust.TabIndex = 12;
            this.Brust.Text = "Brust";
            this.Brust.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // Rücken
            // 
            this.Rücken.Location = new System.Drawing.Point(6, 181);
            this.Rücken.Name = "Rücken";
            this.Rücken.Size = new System.Drawing.Size(100, 20);
            this.Rücken.TabIndex = 11;
            this.Rücken.Text = "Rücken";
            this.Rücken.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // schultern
            // 
            this.schultern.Location = new System.Drawing.Point(7, 155);
            this.schultern.Name = "schultern";
            this.schultern.Size = new System.Drawing.Size(100, 20);
            this.schultern.TabIndex = 10;
            this.schultern.Text = "Schultern";
            this.schultern.Click += new System.EventHandler(this.ClearTextBox_click);
            this.schultern.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // kopf
            // 
            this.kopf.Location = new System.Drawing.Point(6, 129);
            this.kopf.Name = "kopf";
            this.kopf.Size = new System.Drawing.Size(100, 20);
            this.kopf.TabIndex = 8;
            this.kopf.Text = "Kopf";
            this.kopf.Click += new System.EventHandler(this.ClearTextBox_click);
            // 
            // npc_gender
            // 
            this.npc_gender.FormattingEnabled = true;
            this.npc_gender.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.npc_gender.Location = new System.Drawing.Point(169, 19);
            this.npc_gender.Name = "npc_gender";
            this.npc_gender.Size = new System.Drawing.Size(120, 30);
            this.npc_gender.TabIndex = 6;
            // 
            // npc_race
            // 
            this.npc_race.FormattingEnabled = true;
            this.npc_race.Items.AddRange(new object[] {
            "Nachtelf",
            "Mensch",
            "Zwerg",
            "Gnom",
            "Draenei",
            "Orc",
            "Untot",
            "Troll",
            "Tauren",
            "Blutelf"});
            this.npc_race.Location = new System.Drawing.Point(7, 19);
            this.npc_race.Name = "npc_race";
            this.npc_race.Size = new System.Drawing.Size(120, 69);
            this.npc_race.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "ODER";
            // 
            // npc_default_button
            // 
            this.npc_default_button.Location = new System.Drawing.Point(103, 418);
            this.npc_default_button.Name = "npc_default_button";
            this.npc_default_button.Size = new System.Drawing.Size(84, 23);
            this.npc_default_button.TabIndex = 9;
            this.npc_default_button.Text = "Zurücksetzen";
            this.npc_default_button.UseVisualStyleBackColor = true;
            this.npc_default_button.Click += new System.EventHandler(this.npc_default_button_Click);
            // 
            // npc_create_button
            // 
            this.npc_create_button.Location = new System.Drawing.Point(12, 417);
            this.npc_create_button.Name = "npc_create_button";
            this.npc_create_button.Size = new System.Drawing.Size(75, 23);
            this.npc_create_button.TabIndex = 8;
            this.npc_create_button.Text = "Erstellen";
            this.npc_create_button.UseVisualStyleBackColor = true;
            this.npc_create_button.Click += new System.EventHandler(this.npccreate_button_Click);
            // 
            // npc_model_box
            // 
            this.npc_model_box.Controls.Add(this.label7);
            this.npc_model_box.Controls.Add(this.ENTWEDER);
            this.npc_model_box.Controls.Add(this.npc_modelid);
            this.npc_model_box.Location = new System.Drawing.Point(26, 270);
            this.npc_model_box.Name = "npc_model_box";
            this.npc_model_box.Size = new System.Drawing.Size(136, 114);
            this.npc_model_box.TabIndex = 10;
            this.npc_model_box.TabStop = false;
            this.npc_model_box.Text = "NPC Aussehen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Existierende Model ID";
            // 
            // ENTWEDER
            // 
            this.ENTWEDER.AutoSize = true;
            this.ENTWEDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENTWEDER.Location = new System.Drawing.Point(7, 20);
            this.ENTWEDER.Name = "ENTWEDER";
            this.ENTWEDER.Size = new System.Drawing.Size(78, 13);
            this.ENTWEDER.TabIndex = 2;
            this.ENTWEDER.Text = "ENTWEDER";
            // 
            // npc_modelid
            // 
            this.npc_modelid.Location = new System.Drawing.Point(6, 71);
            this.npc_modelid.Name = "npc_modelid";
            this.npc_modelid.Size = new System.Drawing.Size(111, 20);
            this.npc_modelid.TabIndex = 1;
            this.npc_modelid.Text = "0";
            this.npc_modelid.Click += new System.EventHandler(this.ClearTextBox_click);
            this.npc_modelid.TextChanged += new System.EventHandler(this.npc_modelid_TextChanged);
            // 
            // npcwaffen_box
            // 
            this.npcwaffen_box.Controls.Add(this.label6);
            this.npcwaffen_box.Controls.Add(this.label5);
            this.npcwaffen_box.Controls.Add(this.label4);
            this.npcwaffen_box.Controls.Add(this.npc_distance);
            this.npcwaffen_box.Controls.Add(this.npc_offhand);
            this.npcwaffen_box.Controls.Add(this.npc_mainhand);
            this.npcwaffen_box.Location = new System.Drawing.Point(405, 6);
            this.npcwaffen_box.Name = "npcwaffen_box";
            this.npcwaffen_box.Size = new System.Drawing.Size(121, 149);
            this.npcwaffen_box.TabIndex = 7;
            this.npcwaffen_box.TabStop = false;
            this.npcwaffen_box.Text = "NPC Waffen Item ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distanz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nebenhand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Haupthand";
            // 
            // npc_distance
            // 
            this.npc_distance.Location = new System.Drawing.Point(6, 113);
            this.npc_distance.Name = "npc_distance";
            this.npc_distance.Size = new System.Drawing.Size(100, 20);
            this.npc_distance.TabIndex = 2;
            // 
            // npc_offhand
            // 
            this.npc_offhand.Location = new System.Drawing.Point(6, 74);
            this.npc_offhand.Name = "npc_offhand";
            this.npc_offhand.Size = new System.Drawing.Size(100, 20);
            this.npc_offhand.TabIndex = 1;
            // 
            // npc_mainhand
            // 
            this.npc_mainhand.Location = new System.Drawing.Point(7, 32);
            this.npc_mainhand.Name = "npc_mainhand";
            this.npc_mainhand.Size = new System.Drawing.Size(100, 20);
            this.npc_mainhand.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(534, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gameobject";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "Creator";
            this.Text = "ATN Creator";
            this.Load += new System.EventHandler(this.Creator_Load);
            this.npcart_box.ResumeLayout(false);
           // ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.npcinfo_box.ResumeLayout(false);
            this.npcinfo_box.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.npcaussehen_box.ResumeLayout(false);
            this.npcaussehen_box.PerformLayout();
            this.npc_model_box.ResumeLayout(false);
            this.npc_model_box.PerformLayout();
            this.npcwaffen_box.ResumeLayout(false);
            this.npcwaffen_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox npc_template;
        private System.Windows.Forms.GroupBox npcart_box;
        private System.Windows.Forms.ListBox npc_faction;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TextBox npc_name;
        private System.Windows.Forms.TextBox npc_guild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox npcinfo_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox npc_entry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox npcwaffen_box;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox npc_distance;
        private System.Windows.Forms.TextBox npc_offhand;
        private System.Windows.Forms.TextBox npc_mainhand;
        private System.Windows.Forms.Button npc_default_button;
        private System.Windows.Forms.Button npc_create_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox npc_model_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ENTWEDER;
        private System.Windows.Forms.TextBox npc_modelid;
        private System.Windows.Forms.GroupBox npcaussehen_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox wappenrock;
        private System.Windows.Forms.TextBox armschienen;
        private System.Windows.Forms.TextBox Füße;
        private System.Windows.Forms.TextBox beine;
        private System.Windows.Forms.TextBox gürtel;
        private System.Windows.Forms.TextBox hände;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Hemd;
        private System.Windows.Forms.TextBox Brust;
        private System.Windows.Forms.TextBox Rücken;
        private System.Windows.Forms.TextBox schultern;
        private System.Windows.Forms.TextBox kopf;
        private System.Windows.Forms.ListBox npc_gender;
        private System.Windows.Forms.ListBox npc_race;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

