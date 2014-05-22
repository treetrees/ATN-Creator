using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ATNCreator
{
    public partial class Creator : Form
    {
        int varfaction = 0;
        int varnpcflag = 0;
        int varrank = 0;
        int varmodel = 19646;

        int gender = 0;
        int race = 0;
        int varskin = 0;
        int varface = 0;
        int varhair = 0;
        int varhaircolor = 0;
        int varfacialhair = 0;


        string input = "Passwort";

        bool newModel = false;

        public Creator()
        {

            
            ShowInputDialog(ref input);
            string connectionSQL = "server=logon.atom-network.eu;database=world;uid=atncreator;password=" + input + ";";
            MySqlConnection conn = new MySqlConnection(connectionSQL);
            try
            {
                conn.Open();
                conn.Close();
                MessageBox.Show("Passwort akzeptiert\n");
                InitializeComponent();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Keine Verbindung zur Datenbank\n\n\nFehlermeldung untenstehend:\n\n\n\n" + ex.ToString());
                this.Close();
            }
        }


        private void Template_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void npc_faction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NPCgetfaction()
        {
            switch (npc_faction.SelectedIndex)
            {
                case 0: //Horde
                    varfaction = 1602;
                    break;

                case 1: //Allianz
                    varfaction = 11;
                    break;

                case 2: //Neutral
                    varfaction = 35;
                    break;

                case 3: //feindlich
                    varfaction = 14;
                    break;

                default:
                    break;
            }
        }

        private void NPCgettemplate()
        {
            switch (npc_template.SelectedIndex)
            {
                case 0: //Ohne Aufgabe
                    break;

                case 1: //Wache
                    varrank = 1;
                    break;

                case 2: //Questgeber
                    varnpcflag = 2;
                    break;

                case 3: //Händler
                    varnpcflag = 4096;
                    break;

                case 4: //Lehrer
                    varnpcflag = 16;
                    break;

                case 5: //Gegner
                    break;

                case 6: //Boss
                    varrank = 3;
                    break;

                case 7: //EliteMob
                    varrank = 1;
                    break;

                case 8: //Gossip
                    varnpcflag = 1;
                    break;

                default:
                    break;
            }
        }

        private void NPCgetmodelid()
        {
            if (npc_modelid.Text == "0" || npc_modelid.Text == "")
            {
                newModel = true;
            }
            else
            {
                int model_id;
                model_id = Convert.ToInt32(npc_modelid.Text);
                varmodel = model_id;
            }

        }

        private void NPCgetGender()
        {
            switch (npc_gender.SelectedIndex)
            {
                case 0: //Männlich
                    gender = 0;
                    break;

                case 1: //Weiblich
                    gender = 1;
                    break;
                default:
                    break;
            }
        }

        private void NPCgetRace()
        {
            switch (npc_race.SelectedIndex)
            {
                case 0: //Nachtelf
                    race = 4;
                    break;

                case 1: //Mensch
                    race = 1;
                    break;

                case 2: //Zwerg
                    race = 3;
                    break;

                case 3: //Gnom
                    race = 7;
                    break;

                case 4: //Draenei
                    race = 11;
                    break;

                case 5: //Orc
                    race = 2;
                    break;

                case 6: //Untot
                    race = 5;
                    break;

                case 7: //Troll
                    race = 8;
                    break;

                case 8: //Tauren
                    race = 6;
                    break;

                case 9: //Blutelf
                    race = 10;
                    break;

                default:
                    break;
            }
        }
        private void NPCrandomizeFace()
        {
            Random Rnd = new Random();
            varskin = Rnd.Next(0, 8);
            varface = Rnd.Next(0, 8);
            varhair = Rnd.Next(0, 8);
            varhaircolor = Rnd.Next(0, 8);
            varfacialhair = Rnd.Next(0, 5);

        }

        private void NPCcreate_button_Click(object sender, EventArgs e)
        {

            NPCgettemplate();
            NPCgetfaction();
            NPCgetmodelid();


            string connectionSQL = "server=logon.atom-network.eu;database=world;uid=atncreator;password=" + input + ";";
            MySqlConnection conn = new MySqlConnection(connectionSQL);
            try
            {
                conn.Open();
                MySqlCommand cmdtemplate = new MySqlCommand("INSERT INTO creature_template (entry,modelid1,name,subname,faction,npcflag,rank) VALUES (@entry,@modelid,@name,@subname,@faction,@npcflag,@rank)", conn);
                cmdtemplate.Parameters.AddWithValue("@entry", npc_entry.Text);
                cmdtemplate.Parameters.AddWithValue("@name", npc_name.Text);
                cmdtemplate.Parameters.AddWithValue("@subname", npc_guild.Text);
                cmdtemplate.Parameters.AddWithValue("@faction", varfaction);
                cmdtemplate.Parameters.AddWithValue("@npcflag", varnpcflag);
                cmdtemplate.Parameters.AddWithValue("@rank", varrank);
                cmdtemplate.Parameters.AddWithValue("@modelid", varmodel);
                cmdtemplate.ExecuteNonQuery();

                MySqlCommand cmdweapons = new MySqlCommand("INSERT INTO creature_equip_template (entry,id,itemEntry1,itemEntry2,itemEntry3) VALUES (@entry,@id,@mainhand,@offhand,@distance)", conn);
                cmdweapons.Parameters.AddWithValue("@entry", npc_entry.Text);
                cmdweapons.Parameters.AddWithValue("@id", "0");
                cmdweapons.Parameters.AddWithValue("@mainhand", npc_mainhand.Text);
                cmdweapons.Parameters.AddWithValue("@offhand", npc_offhand.Text);
                cmdweapons.Parameters.AddWithValue("@distance", npc_distance.Text);
                cmdweapons.ExecuteNonQuery();

                if (newModel)
                {
                    NPCgetGender();
                    NPCgetRace();
                    NPCrandomizeFace();

                    MySqlCommand cmdmodel = new MySqlCommand("INSERT INTO creature_template_outfits (entry,race,gender,skin,face,hair,haircolor,facialhair,head,shoulders,body,chest,waist,legs,feet,wrists,hands,back,tabard) VALUES (@entry,@race,@gender,@skin,@face,@hair,@haircolor,@facialhair,@head,@shoulders,@body,@chest,@waist,@legs,@feet,@wrists,@hands,@back,@tabard)", conn);
                    cmdmodel.Parameters.AddWithValue("@entry", npc_entry.Text);
                    cmdmodel.Parameters.AddWithValue("@race", race);
                    cmdmodel.Parameters.AddWithValue("@gender", gender);
                    cmdmodel.Parameters.AddWithValue("@skin", varskin);
                    cmdmodel.Parameters.AddWithValue("@face", varface);
                    cmdmodel.Parameters.AddWithValue("@hair", varhair);
                    cmdmodel.Parameters.AddWithValue("@haircolor", varhaircolor);
                    cmdmodel.Parameters.AddWithValue("@facialhair", varfacialhair);
                    cmdmodel.Parameters.AddWithValue("@head", kopf.Text);
                    cmdmodel.Parameters.AddWithValue("@shoulders", schultern.Text);
                    cmdmodel.Parameters.AddWithValue("@body", Brust.Text);
                    cmdmodel.Parameters.AddWithValue("@chest", Hemd.Text);
                    cmdmodel.Parameters.AddWithValue("@waist", gürtel.Text);
                    cmdmodel.Parameters.AddWithValue("@legs", beine.Text);
                    cmdmodel.Parameters.AddWithValue("@feet", Füße.Text);
                    cmdmodel.Parameters.AddWithValue("@wrists", armschienen.Text);
                    cmdmodel.Parameters.AddWithValue("@hands", hände.Text);
                    cmdmodel.Parameters.AddWithValue("@back", Rücken.Text);
                    cmdmodel.Parameters.AddWithValue("@tabard", wappenrock.Text);
                    cmdmodel.ExecuteNonQuery();
                }
               
                MessageBox.Show("NPC erfolgreich hinzugefügt\n");
                conn.Close();
            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Keine Verbindung zur Datenbank\n\nFehlermeldung untenstehend:\n\n\n\n\n\n\n" + ex.ToString());
            }
        }

        private void default_button_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(tabControl1.SelectedTab);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void npcaussehen_box_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void hals_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_2(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                TextBox textBox = child as TextBox;
                if (textBox == null)
                    ClearTextBoxes(child);
                else
                    textBox.Text = string.Empty;
            }
        }

        private void ClearTextBox_click(object sender, EventArgs e)
        {
           TextBox textBox = sender as TextBox;
           textBox.Text = string.Empty;
        }
        
        private void npc_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void npc_modelid_TextChanged(object sender, EventArgs e)
        {

        }

        private void gürtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Creator_Load(object sender, EventArgs e)
        {

        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "ATN Creator";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void quest_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void quest_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void quest_kill_npc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
