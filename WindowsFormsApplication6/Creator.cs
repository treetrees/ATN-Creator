using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ATNCreator
{
    public partial class Creator : Form
    {
        int var_npcfaction = 0;
        int var_npcflag = 0;
        int var_npcrank = 0;
        int var_npcmodel = 19646;

        int var_npcgender = 0;
        int var_npcrace = 0;
        int var_npcskin = 0;
        int var_npcface = 0;
        int var_npchair = 0;
        int var_npchaircolor = 0;
        int var_npcfacialhair = 0;

        int var_questfaction = 0;
        int var_questzone = 0;
        int var_questgold = 0;
        int var_questehre = 0;

        bool newModel = false;
        string input = "Passwort";


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
                case 0:
                    break;
                case 1: //Horde
                    var_npcfaction = 1602;
                    break;

                case 2: //Allianz
                    var_npcfaction = 11;
                    break;

                case 3: //Neutral
                    var_npcfaction = 35;
                    break;

                case 4: //feindlich
                    var_npcfaction = 14;
                    break;

                default:
                    break;
            }
        }

        private void NPCgettemplate()
        {
            switch (npc_template.SelectedIndex)
            {
                case 0:
                    break;
                case 1: //Ohne Aufgabe
                    break;

                case 2: //Wache
                    var_npcrank = 1;
                    break;

                case 3: //Questgeber
                    var_npcflag = 2;
                    break;

                case 4: //Händler
                    var_npcflag = 4096;
                    break;

                case 5: //Lehrer
                    var_npcflag = 16;
                    break;

                case 6: //Gegner
                    break;

                case 7: //Boss
                    var_npcrank = 3;
                    break;

                case 8: //EliteMob
                    var_npcrank = 1;
                    break;

                case 9: //Gossip
                    var_npcflag = 1;
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
                var_npcmodel = model_id;
            }

        }

        private void NPCgetGender()
        {
            switch (npc_gender.SelectedIndex)
            {
                case 0:
                    break;

                case 1: //Männlich
                    var_npcgender = 0;
                    break;

                case 2: //Weiblich
                    var_npcgender = 1;
                    break;
                default:
                    break;
            }
        }

        private void NPCgetRace()
        {
            switch (npc_race.SelectedIndex)
            {
                case 0:
                    break;

                case 1: //Nachtelf
                    var_npcrace = 4;
                    break;

                case 2: //Mensch
                    var_npcrace = 1;
                    break;

                case 3: //Zwerg
                    var_npcrace = 3;
                    break;

                case 4: //Gnom
                    var_npcrace = 7;
                    break;

                case 5: //Draenei
                    var_npcrace = 11;
                    break;

                case 6: //Orc
                    var_npcrace = 2;
                    break;

                case 7: //Untot
                    var_npcrace = 5;
                    break;

                case 8: //Troll
                    var_npcrace = 8;
                    break;

                case 9: //Tauren
                    var_npcrace = 6;
                    break;

                case 10: //Blutelf
                    var_npcrace = 10;
                    break;

                default:
                    break;
            }
        }
        private void NPCrandomizeFace()
        {
            Random Rnd = new Random();
            var_npcskin = Rnd.Next(0, 8);
            var_npcface = Rnd.Next(0, 8);
            var_npchair = Rnd.Next(0, 8);
            var_npchaircolor = Rnd.Next(0, 8);
            var_npcfacialhair = Rnd.Next(0, 5);

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
                cmdtemplate.Parameters.AddWithValue("@faction", var_npcfaction);
                cmdtemplate.Parameters.AddWithValue("@npcflag", var_npcflag);
                cmdtemplate.Parameters.AddWithValue("@rank", var_npcrank);
                cmdtemplate.Parameters.AddWithValue("@modelid", var_npcmodel);
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
                    cmdmodel.Parameters.AddWithValue("@race", var_npcrace);
                    cmdmodel.Parameters.AddWithValue("@gender", var_npcgender);
                    cmdmodel.Parameters.AddWithValue("@skin", var_npcskin);
                    cmdmodel.Parameters.AddWithValue("@face", var_npcface);
                    cmdmodel.Parameters.AddWithValue("@hair", var_npchair);
                    cmdmodel.Parameters.AddWithValue("@haircolor", var_npchaircolor);
                    cmdmodel.Parameters.AddWithValue("@facialhair", var_npcfacialhair);
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
                conn.Close();

                FileStream fs = new FileStream("Erstellt.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("NPC: " + "ID: " + npc_entry.Text + " Name: " + npc_name.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

                MessageBox.Show("NPC erfolgreich hinzugefügt\n");
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

        private void QuestGetFaction()
        {
            switch (quest_faction.SelectedIndex)
            {
                case 0:
                    break;

                case 1: //Horde
                    var_questfaction = 690;
                    break;

                case 2: //Allianz
                    var_questfaction = 1101;
                    break;

                default:
                    break;
            }
        }

        private void QuestGetZone()
        {
            switch (quest_zone.SelectedIndex)
            {
                case 0:
                    break;
                case 1: //Ferne grüne Land
                    var_questzone = 5500;
                    break;

                case 2: //Iberia
                    var_questzone = 5200;
                    break;

                case 3: //Horde Start Gebiet
                    var_questzone = 5200;
                    break;

                default:
                    break;
            }
        }

        private void QuestGetItemReward_Click(object sender, EventArgs e)
        {
            QuestGetItemReward();
        }

        private void QuestGetItemReward()
        {
            if (quest_marken.SelectedIndex != 0)
            {
                switch (quest_marken.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1: //1 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "1";
                        }
                        break;
                    case 2: //5 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "5";
                        }
                        break;
                    case 3: //10 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "10";
                        }
                        break;
                    case 4: //20 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "20";
                        }
                        break;
                    case 5: //50 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "50";
                        }
                        break;
                    case 6: //100 Abzeichen des Triumphs
                        {
                            quest_reward1.Text = "47241";
                            quest_reward1_amount.Text = "100";
                        }
                        break;
                    case 7: //1 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "1";
                        }
                        break;
                    case 8: //5 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "5";
                        }
                        break;
                    case 9: //10 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "10";
                        }
                        break;
                    case 10: //20 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "20";
                        }
                        break;
                    case 11: //50 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "50";
                        }
                        break;
                    case 12: //100 Abzeichen des Frosts
                        {
                            quest_reward1.Text = "49426";
                            quest_reward1_amount.Text = "100";
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void QuestGetMoney()
        {
            switch (quest_gold.SelectedIndex)
            {
                case 0:
                    break;
                case 1: //1 Gold
                    var_questgold = 10000;
                    break;
                case 2: //5 Gold
                    var_questgold = 50000;
                    break;
                case 3: //10 Gold
                    var_questgold = 100000;
                    break;
                case 4: //20 Gold
                    var_questgold = 200000;
                    break;
                case 5: //50 Gold
                    var_questgold = 500000;
                    break;
                case 6: //100 Gold
                    var_questgold = 1000000;
                    break;
                default:
                    break;
            }
        }

        private void QuestGetHonor()
        {
            switch (quest_ehre.SelectedIndex)
            {
                case 0: //1000 Ehre
                    var_questehre = 1000;
                    break;
                case 1: //5000 Ehre
                    var_questehre = 5000;
                    break;
                case 2: //10000 Ehre
                    var_questgold = 10000;
                    break;
                case 3: //20000 Ehre
                    var_questgold = 20000;
                    break;
                default:
                    break;
            }
        }

        private void Quest_create_button_Click(object sender, EventArgs e)
        {
            QuestGetFaction();
            QuestGetZone();
            QuestGetMoney();
            QuestGetHonor();

            string connectionSQL = "server=logon.atom-network.eu;database=world;uid=atncreator;password=" + input + ";";
            MySqlConnection conn = new MySqlConnection(connectionSQL);
            try
            {
                conn.Open();
                MySqlCommand cmdqtemplate = new MySqlCommand("INSERT INTO quest_template "+
                    "(Id,ZoneOrSort,RequiredRaces,Title,Details,Objectives,RequiredNpcOrGo1,RequiredNpcOrGo2,RequiredNpcOrGo3,RequiredNpcOrGo4,RequiredNpcOrGoCount1,RequiredNpcOrGoCount2,RequiredNpcOrGoCount3,RequiredNpcOrGoCount4,RequiredItemId1,RequiredItemId2,RequiredItemId3,RequiredItemId4,RequiredItemCount1,RequiredItemCount2,RequiredItemCount3,RequiredItemCount4,RewardItemId1,RewardItemId2,RewardItemId3,RewardItemId4,RewardOrRequiredMoney,RewardMoneyMaxLevel,RewardHonor) " + 
                    "VALUES"+
                    "(@Id,@ZoneOrSort,@RequiredRaces,@Title,@Details,@Objectives,@RequiredNpcOrGo1,@RequiredNpcOrGo2,@RequiredNpcOrGo3,@RequiredNpcOrGo4,@RequiredNpcOrGoCount1,@RequiredNpcOrGoCount2,@RequiredNpcOrGoCount3,@RequiredNpcOrGoCount4,@RequiredItemId1,@RequiredItemId2,@RequiredItemId3,@RequiredItemId4,@RequiredItemCount1,@RequiredItemCount2,@RequiredItemCount3,@RequiredItemCount4,@RewardItemCount1,@RewardItemCount2,@RewardItemCount3,@RewardItemCount4,@RewardOrRequiredMoney,@RewardMoneyMaxLevel,@RewardHonor)", conn);
                cmdqtemplate.Parameters.AddWithValue("@Id", quest_entry.Text);
                cmdqtemplate.Parameters.AddWithValue("@ZoneOrSort", var_questzone);
                cmdqtemplate.Parameters.AddWithValue("@RequiredRaces", var_questfaction);
                cmdqtemplate.Parameters.AddWithValue("@Title", quest_title.Text);
                cmdqtemplate.Parameters.AddWithValue("@Details", quest_longtext);
                cmdqtemplate.Parameters.AddWithValue("@Objectives", quest_kurz.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGo1", quest_kill_npc1.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGo2", quest_kill_npc2.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGo3", quest_kill_npc3.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGo4", quest_kill_npc4.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGoCount1", quest_kill_npc1_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGoCount2", quest_kill_npc2_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGoCount3", quest_kill_npc3_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredNpcOrGoCount4", quest_kill_npc4_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemId1", quest_sammel_item1.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemId2", quest_sammel_item2.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemId3", quest_sammel_item3.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemId4", quest_sammel_item4.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemCount1", quest_sammel_item1_anzahl.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemCount2", quest_sammel_item1_anzahl.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemCount3", quest_sammel_item1_anzahl.Text);
                cmdqtemplate.Parameters.AddWithValue("@RequiredItemCount4", quest_sammel_item1_anzahl.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemId1", quest_reward1.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemId2", quest_reward2.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemId3", quest_reward3.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemId4", quest_reward4.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemCount1", quest_reward1_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemCount2", quest_reward2_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemCount3", quest_reward3_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardItemCount4", quest_reward4_amount.Text);
                cmdqtemplate.Parameters.AddWithValue("@RewardOrRequiredMoney", var_questgold);
                cmdqtemplate.Parameters.AddWithValue("@RewardMoneyMaxLevel", var_questgold);
                cmdqtemplate.Parameters.AddWithValue("@RewardHonor", var_questehre);
                cmdqtemplate.ExecuteNonQuery();

                MySqlCommand cmdqgiver = new MySqlCommand("INSERT INTO creature_queststarter (id,quest) VALUES (@id,@quest)", conn);
                cmdqgiver.Parameters.AddWithValue("@id", quest_giver.Text);
                cmdqgiver.Parameters.AddWithValue("@quest", quest_entry.Text);
                cmdqgiver.ExecuteNonQuery();

                MySqlCommand cmdqender = new MySqlCommand("INSERT INTO creature_questender (id,quest) VALUES (@id,@quest)", conn);
                cmdqender.Parameters.AddWithValue("@id", quest_ender.Text);
                cmdqender.Parameters.AddWithValue("@quest", quest_entry.Text);
                cmdqender.ExecuteNonQuery();

                conn.Close();

                FileStream fs = new FileStream("Erstellt.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Quest: " + "ID: " + quest_entry.Text + " Name: " + quest_title.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

                MessageBox.Show("NPC erfolgreich hinzugefügt\n");
            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Keine Verbindung zur Datenbank\n\nFehlermeldung untenstehend:\n\n\n\n\n\n\n" + ex.ToString());
            }   
        }

        private void quest_ehre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quest_marken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "ATN Creator Version 1.2\n\n Atom-Network.eu\n", "Versions Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gobject_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
