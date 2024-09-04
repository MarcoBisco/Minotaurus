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

namespace Minotaurus
{
    public partial class Form6 : Form
    {
        int count;
        string[] plys;
        int[] result;
        

        public Form6(string[] players)
        {
            InitializeComponent();
            plys = players;
            count = 0;
            
            result = new int[players.Length];
        }
        private string CreateSequence()
        {
            string sequence="";
            Array.Sort(result, plys, 0, result.Length);
            for(int i= result.Length-1; i>-1;i--)
            {
                sequence = sequence+plys[i]+" ";
            }
            return sequence;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            MessageBox.Show("Per tirare il dado premere sul pulsante con raffigurati i dadi.", "MINOTAURUS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            G1TB.Text = plys[count];
        }

        private void DiceBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            switch (rnd.Next(1, 7))
            {
                case 1:
                    MessageBox.Show("E' uscita la faccia nera!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = null;
                    DiceDisplay.BackColor = Color.Black;
                    result[count] = 0;
                    break;
                case 2:
                    MessageBox.Show("E' uscita la faccia grigia!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = null;
                    DiceDisplay.BackColor = Color.Gray;
                    result[count] = 0;
                    break;
                case 3:
                    MessageBox.Show("E' uscito 3!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-3-outline-icon.png");
                    DiceDisplay.BackColor = Color.White;
                    result[count] = 3;
                    break;
                case 4:
                    MessageBox.Show("E' uscito 4!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-4-outline-icon.png");
                    DiceDisplay.BackColor = Color.White;
                    result[count] = 4;
                    break;
                case 5:
                    MessageBox.Show("E' uscito 5!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-5-outline-icon.png");
                    DiceDisplay.BackColor = Color.White;
                    result[count] = 5;
                    break;
                case 6:
                    MessageBox.Show("E' uscito 6!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-6-outline-icon.png");
                    DiceDisplay.BackColor = Color.White;
                    result[count] = 6;
                    break;
            }
            switch (count)
            {
                case 0:
                    G1PTB.Text = Convert.ToString(result[count]);
                    G2TB.Text =plys[count+1];
                    break;
                case 1:
                    G2PTB.Text = Convert.ToString(result[count]);
                    G3TB.Text = plys[count + 1];
                    if (G3TB.Text == "")
                    {
                        MessageBox.Show($"L'ordine di gioco è stato creato ed è il seguente:\n{CreateSequence()}", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.WriteAllText(Environment.CurrentDirectory + "data.txt", CreateSequence());
                        this.Close();
                    }
                    break;
                case 2:
                    G3PTB.Text = Convert.ToString(result[count]);
                    G4TB.Text = plys[count + 1];
                    if (G4TB.Text=="")
                    {
                        MessageBox.Show($"L'ordine di gioco è stato creato ed è il seguente:\n{CreateSequence()}", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.WriteAllText(Environment.CurrentDirectory + "data.txt", CreateSequence());
                        this.Close();
                    }
                    break;
                case 3:
                    G4PTB.Text = Convert.ToString(result[count]);
                    MessageBox.Show($"L'ordine di gioco è stato creato ed è il seguente:\n{CreateSequence()}", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.WriteAllText(Environment.CurrentDirectory + "data.txt", CreateSequence());
                    this.Close();
                    break;
            }
            count++;

        }
    }
}
