using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;




namespace Minotaurus
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        int count;
        public Form2()
        {
            InitializeComponent();
            count = 0;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Match1Btn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            MatchDisplay.Text = "PARTITA 1";
            if(File.Exists(Environment.CurrentDirectory + "\\JSON\\P1.json"))
            {
                count = 0;
                Match match1 = JsonSerializer.Deserialize<Match>(File.ReadAllText(Environment.CurrentDirectory + "\\JSON\\P1.json"));
                for(int i=0;i<match1.Players.Length;i++)
                {
                    if (match1.Players[i] != "")
                        count++;
                }
                PlayersNumberTB.Text = Convert.ToString(count);
                DateTB.Text = Convert.ToString(match1.Date);
            }
            else
            {
                PlayersNumberTB.Text ="-";
                DateTB.Text = "--/--/---- --:--:--";
            }
            
        }

        private void Match2Btn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            MatchDisplay.Text = "PARTITA 2";
            if(File.Exists(Environment.CurrentDirectory+ "\\JSON\\P2.json"))
            {
                count = 0; 
                groupBox1.Visible = true;
                
                Match match2 = JsonSerializer.Deserialize<Match>(File.ReadAllText(Environment.CurrentDirectory + "\\JSON\\P2.json"));
                for (int i = 0; i < match2.Players.Length; i++)
                {
                    if (match2.Players[i] != "")
                    count++;
                }
                PlayersNumberTB.Text = Convert.ToString(count);
                DateTB.Text = Convert.ToString(match2.Date);

            }
            else
            {
                PlayersNumberTB.Text = "-";
                DateTB.Text = "--/--/---- --:--:--";
            }
            
           
        }

        private void Match3Btn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            MatchDisplay.Text = "PARTITA 3";
            if(File.Exists(Environment.CurrentDirectory+ "\\JSON\\P3.json"))
            {
                count = 0;
                groupBox1.Visible = true;
           
                Match match3 = JsonSerializer.Deserialize<Match>(File.ReadAllText(Environment.CurrentDirectory + "\\JSON\\P3.json"));
                for (int i = 0; i < match3.Players.Length; i++)
                {
                    if (match3.Players[i] != "")
                        count++;
                }
                PlayersNumberTB.Text = Convert.ToString(count);
                DateTB.Text = Convert.ToString(match3.Date);
            }
            else
            {
                PlayersNumberTB.Text = "-";
                DateTB.Text = "--/--/---- --:--:--";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\JSON\\P1.json"))
                Match1Btn.Text = "CONTINUA PARTITA";
            if (File.Exists(Environment.CurrentDirectory + "\\JSON\\P2.json"))
                Match2Btn.Text = "CONTINUA PARTITA";
            if (File.Exists(Environment.CurrentDirectory + "\\JSON\\P3.json"))
                Match3Btn.Text = "CONTINUA PARTITA";

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            switch(MatchDisplay.Text)
            {
                case "PARTITA 1":
                    if(Match1Btn.Text=="NUOVA PARTITA")
                    {
                        Form3 f3 = new Form3(1);
                        this.Hide();
                        f3.ShowDialog();
                    }
                    else
                    {
                        Form5 f5 = new Form5(1);
                        this.Hide();
                        f5.ShowDialog();
                    }
                    break;
                case "PARTITA 2":
                    if (Match2Btn.Text == "NUOVA PARTITA")
                    {
                        Form3 f3 = new Form3(2);
                        this.Hide();
                        f3.ShowDialog();
                    }
                    else
                    {
                        Form5 f5 = new Form5(2);
                        f5.ShowDialog();
                        this.Hide();
                    }
                    break;
                case "PARTITA 3":
                    if (Match3Btn.Text == "NUOVA PARTITA")
                    {
                        Form3 f3 = new Form3(3);
                        this.Hide();
                        f3.ShowDialog();
                    }
                    else
                    {
                        Form5 f5 = new Form5(3);
                        this.Hide();
                        f5.ShowDialog();
                    }
                    break;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (MatchDisplay.Text)
            {
                case "PARTITA 1":
                    if (Match1Btn.Text == "NUOVA PARTITA")
                        MessageBox.Show("Non ci sono dati salvati relativi a questa partita da eliminare.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if(MessageBox.Show("Ci sono dati salvati relativi questa partita.\nProseguendo con questa operazione, i dati andranno persi e non potranno più essere recuperati, Procedere?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                        {
                            File.Delete(Environment.CurrentDirectory+ "\\JSON\\P1.json");
                            Match1Btn.Text = "NUOVA PARTITA";
                            PlayersNumberTB.Text = "-";
                            DateTB.Text = "--/--/---- --:--:--";
                        }
                    }
                    break;
                case "PARTITA 2":
                    if (Match2Btn.Text == "NUOVA PARTITA")
                            MessageBox.Show("Non ci sono dati salvati relativi a questa partita da eliminare.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (MessageBox.Show("Ci sono dati salvati relativi questa partita.\nProseguendo con questa operazione, i dati andranno persi e non potranno più essere recuperati, Procedere?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            File.Delete(Environment.CurrentDirectory + "\\JSON\\P2.json");
                            Match2Btn.Text = "NUOVA PARTITA";
                            PlayersNumberTB.Text = "-";
                            DateTB.Text = "--/--/---- --:--:--";
                        }
                    }
                    break;
                case "PARTITA 3":
                    if (Match3Btn.Text == "NUOVA PARTITA")
                        MessageBox.Show("Non ci sono dati salvati relativi a questa partita da eliminare.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        if (MessageBox.Show("Ci sono dati salvati relativi questa partita.\nProseguendo con questa operazione, i dati andranno persi e non potranno più essere recuperati, Procedere?", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            File.Delete(Environment.CurrentDirectory + "\\JSON\\P3.json");
                            Match3Btn.Text = "NUOVA PARTITA";
                            PlayersNumberTB.Text = "-";
                            DateTB.Text = "--/--/---- --:--:--";
                        }
                    }
                    break;
            }
        }
    }
}
