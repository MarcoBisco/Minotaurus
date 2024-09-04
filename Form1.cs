using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Minotaurus
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SoundPlayer music;
        bool musicState;
        public Form1()
        {
            InitializeComponent();
            music = new SoundPlayer(Environment.CurrentDirectory + "\\music\\StudioKolomna_-_Epic_Fantasy_Story.wav");
           
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void RulesBtn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", "MINOTAUROS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
           
        }

        private void SoundBtn_Click(object sender, EventArgs e)
        {
            if(musicState)
            {
                musicState = false;
                music.Stop();
                SoundBtn.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\Sound-off-icon.png");
            }
            else
            {
                musicState = true;
                music.PlayLooping();
                SoundBtn.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\Sound-on-icon.png");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SoundBtn.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\Sound-on-icon.png");
            music.PlayLooping();
            musicState = true;
            


        }
    }
}
