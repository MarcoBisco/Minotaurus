using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Minotaurus
{
   
    public partial class Form3 : System.Windows.Forms.Form
    {
        int id;
        public Form3(int index)
        {
            InitializeComponent();
            id = index;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void AddPlayerBtn_Click(object sender, EventArgs e)
        {
            if(G3L.Visible==false)
            {
                G3L.Visible = true;
                G3TB.Visible = true;
                RemovePlayerBtn.Visible = true;
                BlueTarget.Items[2] = "G3";
                RedTarget.Items[2] = "G3";
                YellowTarget.Items[2] = "G3";
                WhiteTarget.Items[2] = "G3";
                YellowTarget.Text = "G3";
                WhiteTarget.Text = "--";
            }
            else
            {
                G4L.Visible = true;
                G4TB.Visible = true;
                AddPlayerBtn.Visible = false;
                BlueTarget.Items[3] = "G4";
                RedTarget.Items[3] = "G4";
                YellowTarget.Items[3] = "G4";
                WhiteTarget.Items[3] = "G4";
                WhiteTarget.Text = "G4";
            }
        }

        private void RemovePlayerBtn_Click(object sender, EventArgs e)
        {
            if (G4L.Visible == true)
            {
                G4L.Visible = false;
                G4TB.Visible = false;
                AddPlayerBtn.Visible = true;
                BlueTarget.Items[3] = "--";
                RedTarget.Items[3] = "--";
                YellowTarget.Items[3] = "--";
                WhiteTarget.Items[3] = "--";
                WhiteTarget.Text = "--";
            }
            else
            {
                G3L.Visible = false;
                G3TB.Visible = false;
                RemovePlayerBtn.Visible = false;
                BlueTarget.Items[2] = "--";
                RedTarget.Items[2] = "--";
                YellowTarget.Items[2] = "--";
                WhiteTarget.Items[2] = "--";
                YellowTarget.Text = "--";
            }
        }

        private void MinotaurusStepsNumber_ValueChanged(object sender, EventArgs e)
        {
            if(MinotaurusStepsNumber.Value<8)
                MessageBox.Show("Il numero dei passi del Minotauro non può essere minore di 8.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(MinotaurusStepsNumber.Value>100)
                MessageBox.Show("Il numero dei passi del Minotauro non può essere maggiore di 100.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BlueTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BlueTarget.Text == RedTarget.Text)
            {
                RedTarget.Text = Convert.ToString(BlueTarget.Items[0]);
                if (BlueTarget.Text == Convert.ToString(BlueTarget.Items[0]))
                    RedTarget.Text = Convert.ToString(BlueTarget.Items[1]);
            }
            if (BlueTarget.Text == YellowTarget.Text)
            {
                YellowTarget.Text = Convert.ToString(BlueTarget.Items[0]);
                if (BlueTarget.Text == Convert.ToString(BlueTarget.Items[0]))
                    YellowTarget.Text = Convert.ToString(BlueTarget.Items[2]);
            }   
            if (BlueTarget.Text == WhiteTarget.Text)
            {
                WhiteTarget.Text = Convert.ToString(BlueTarget.Items[0]);
                if (BlueTarget.Text == Convert.ToString(BlueTarget.Items[0]))
                    WhiteTarget.Text = Convert.ToString(BlueTarget.Items[3]);
            }
        }

        private void RedTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RedTarget.Text == BlueTarget.Text)
            {
                BlueTarget.Text = Convert.ToString(RedTarget.Items[1]);
                if (RedTarget.Text == Convert.ToString(RedTarget.Items[1]))
                    BlueTarget.Text = Convert.ToString(RedTarget.Items[0]);
            }
            if (RedTarget.Text == YellowTarget.Text)
            {
                YellowTarget.Text = Convert.ToString(RedTarget.Items[1]);
                if (RedTarget.Text == Convert.ToString(RedTarget.Items[1]))
                    YellowTarget.Text = Convert.ToString(RedTarget.Items[2]);
            } 
            if (RedTarget.Text == WhiteTarget.Text)
            {
                WhiteTarget.Text = Convert.ToString(RedTarget.Items[1]);
                if (RedTarget.Text == Convert.ToString(RedTarget.Items[1]))
                    WhiteTarget.Text = Convert.ToString(RedTarget.Items[3]);
            }
                
        }

        private void YellowTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YellowTarget.Text == BlueTarget.Text)
            {
                BlueTarget.Text = Convert.ToString(YellowTarget.Items[2]);
                if (RedTarget.Text == Convert.ToString(YellowTarget.Items[1]))
                    BlueTarget.Text = Convert.ToString(YellowTarget.Items[0]);
            } 
            if (YellowTarget.Text == RedTarget.Text)
            {
                RedTarget.Text = Convert.ToString(YellowTarget.Items[2]);
                if (YellowTarget.Text == Convert.ToString(YellowTarget.Items[2]))
                    RedTarget.Text = Convert.ToString(YellowTarget.Items[1]);
            }
            if (YellowTarget.Text == WhiteTarget.Text)
            { 
                WhiteTarget.Text = Convert.ToString(YellowTarget.Items[2]);
                if (YellowTarget.Text == Convert.ToString(YellowTarget.Items[2]))
                    WhiteTarget.Text = Convert.ToString(YellowTarget.Items[3]);
            }
               
        }

        private void WhiteTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhiteTarget.Text == BlueTarget.Text)
            {
                BlueTarget.Text = Convert.ToString(WhiteTarget.Items[3]);
                if (WhiteTarget.Text == Convert.ToString(WhiteTarget.Items[3]))
                    BlueTarget.Text = Convert.ToString(WhiteTarget.Items[0]);
            }
            if (WhiteTarget.Text == RedTarget.Text)
            {
                RedTarget.Text = Convert.ToString(WhiteTarget.Items[3]);
                if (WhiteTarget.Text == Convert.ToString(WhiteTarget.Items[3]))
                    RedTarget.Text = Convert.ToString(WhiteTarget.Items[1]);
            } 
            if (WhiteTarget.Text == YellowTarget.Text)
            {
                YellowTarget.Text = Convert.ToString(WhiteTarget.Items[3]);
                if (WhiteTarget.Text == Convert.ToString(WhiteTarget.Items[3]))
                    YellowTarget.Text = Convert.ToString(WhiteTarget.Items[2]);
            }
                
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
           
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (G1TB.Text == "" || G2TB.Text == "" || (G3TB.Text ==""& G3TB.Visible==true) || (G4TB.Text == ""&G4TB.Visible==true))
                MessageBox.Show("Uno o più giocatori sono senza nome!", "MINOTAURUS", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                if(G1TB.Text!=G2TB.Text && G1TB.Text!=G3TB.Text && G1TB.Text!=G4TB.Text && G2TB.Text!=G1TB.Text && G2TB.Text!=G3TB.Text && G2TB.Text!=G4TB.Text && G3TB.Text!=G1TB.Text && G3TB.Text!=G2TB.Text && G3TB.Text!=G4TB.Text && G4TB.Text!= G1TB.Text && G4TB.Text!=G2TB.Text && G4TB.Text!=G3TB.Text)
                {
                    Match match = new Match
                    {
                        Index = id,
                        New = true,
                        Date = DateTime.Now,
                        Players = new string[] { G1TB.Text, G2TB.Text, G3TB.Text, G4TB.Text },
                        PlayersCopy=new string[] { G1TB.Text, G2TB.Text, G3TB.Text, G4TB.Text },
                        Teams = new string[] {BlueTarget.Text+" Blue",RedTarget.Text+" Red",YellowTarget.Text+ " Yellow", WhiteTarget.Text+ " White" },
                        MinotaurusStepsNum = Convert.ToInt32(MinotaurusStepsNumber.Value),

                    };
                    switch(id)
                    {
                        case 1:
                            File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P1.json", JsonSerializer.Serialize(match));
                            break;
                        case 2:
                            File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P2.json", JsonSerializer.Serialize(match));
                            break;
                        case 3:
                            File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P3.json", JsonSerializer.Serialize(match));
                            break;
                    }
                    Form5 f5 = new Form5(id);
                    this.Hide();
                    f5.ShowDialog();

                }
                else
                {
                    if (G3TB.Visible == false && G4TB.Visible == false)
                    {
                        Match match = new Match
                        {
                            Index = id,
                            New = true,
                            Date = DateTime.Now,
                            Players = new string[] { G1TB.Text, G2TB.Text , G3TB.Text, G4TB.Text},
                            PlayersCopy = new string[] { G1TB.Text, G2TB.Text, G3TB.Text, G4TB.Text },
                            Teams = new string[] { BlueTarget.Text+" Blue", RedTarget.Text+" Red", YellowTarget.Text+ " Yellow", WhiteTarget.Text+ " White" },
                            MinotaurusStepsNum = Convert.ToInt32(MinotaurusStepsNumber.Value),

                        };
                        switch (id)
                        {
                            case 1:
                                File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P1.json", JsonSerializer.Serialize(match));
                                break;
                            case 2:
                                File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P2.json", JsonSerializer.Serialize(match));
                                break;
                            case 3:
                                File.WriteAllText(Environment.CurrentDirectory + "\\JSON\\P3.json", JsonSerializer.Serialize(match));
                                break;
                        }
                        Form5 f5 = new Form5(id);
                        this.Hide();
                        f5.ShowDialog();
                    }
                    else
                        MessageBox.Show("La partita non può iniziare!\nNon possono esserci nomi uguali.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void G1TB_TextChanged(object sender, EventArgs e)
        {
            if((G1TB.Text==G2TB.Text||G1TB.Text==G3TB.Text||G1TB.Text==G4TB.Text)&G1TB.Text!="")
            {
                if (MessageBox.Show("Questo nome è già stato usato da un altro giocatore!\nVuoi aggiungere caratteri?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    G1TB.Text = null;
                else
                    G1TB.Focus();

            }
        }

        private void G2TB_TextChanged(object sender, EventArgs e)
        {
            if ((G2TB.Text == G1TB.Text || G2TB.Text == G3TB.Text || G2TB.Text == G4TB.Text)&G2TB.Text!="")
            {
                if(MessageBox.Show("Questo nome è già stato usato da un altro giocatore!\nVuoi aggiungere caratteri?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.No)
                    G2TB.Text = null;
                else
                    G2TB.Focus();
            }
        }

        private void G3TB_TextChanged(object sender, EventArgs e)
        {
            if ((G3TB.Text == G1TB.Text || G3TB.Text == G2TB.Text || G3TB.Text == G4TB.Text)&G3TB.Text!="")
            {
                if (MessageBox.Show("Questo nome è già stato usato da un altro giocatore!\nVuoi aggiungere caratteri?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    G3TB.Text = null;
                else
                    G3TB.Focus();
            }
        }

        private void G4TB_TextChanged(object sender, EventArgs e)
        {
            if ((G4TB.Text == G1TB.Text || G4TB.Text == G2TB.Text || G4TB.Text == G3TB.Text)&G4TB.Text!="")
            {
                if (MessageBox.Show("Questo nome è già stato usato da un altro giocatore!\nVuoi aggiungere caratteri?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    G4TB.Text = null;
                else
                    G4TB.Focus();
            }
        }
    }
}
