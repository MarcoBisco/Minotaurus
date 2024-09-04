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
    public partial class Form5 : System.Windows.Forms.Form
    {
        int id,stepsHistoryIndex;
        Match match;
        string[] stepsHistory;

        public Form5(int index)
        {
            InitializeComponent();
            id = index;
            match = JsonSerializer.Deserialize<Match>(File.ReadAllText(Environment.CurrentDirectory + $"\\JSON\\P{Convert.ToString(id)}.json"));
        }
        private void CleanField()
        {
            //Blue
            x30y02.BackgroundImage=null;
            x30y02.BackColor = Color.Blue;
            x30y01.BackgroundImage = null;
            x30y01.BackColor = Color.Blue;
            x29y01.BackgroundImage = null;
            x29y01.BackColor = Color.Blue;
            //red
            x01y29.BackgroundImage = null;
            x01y29.BackColor = Color.Red;
            x01y30.BackgroundImage = null;
            x01y30.BackColor = Color.Red;
            x02y30.BackgroundImage = null;
            x02y30.BackColor = Color.Red;
            //yellow
            x01y02.BackgroundImage = null;
            x01y02.BackColor = Color.Yellow;
            x01y01.BackgroundImage = null;
            x01y01.BackColor = Color.Yellow;
            x02y01.BackgroundImage = null;
            x02y01.BackColor = Color.Yellow;
            //white
            x30y29.BackgroundImage=null;
            x30y29.BackColor = Color.White;
            x30y30.BackgroundImage = null;
            x30y30.BackColor = Color.White;
            x29y30.BackgroundImage = null;
            x29y30.BackColor = Color.White;
            //walls
            x00y17.BackgroundImage = null;
            x00y17.BackColor = Color.Transparent;
            x00y18.BackgroundImage = null;
            x00y18.BackColor = Color.Transparent;

            x00y13.BackgroundImage = null;
            x00y13.BackColor = Color.Transparent;
            x00y14.BackgroundImage = null;
            x00y14.BackColor = Color.Transparent;

            x04y03.BackgroundImage = null;
            x04y03.BackColor = Color.Transparent;
            x05y03.BackgroundImage = null;
            x05y03.BackColor = Color.Transparent;

            x09y21.BackgroundImage = null;
            x09y21.BackColor = Color.Transparent;
            x09y22.BackgroundImage = null;
            x09y22.BackColor = Color.Transparent;

            x09y09.BackgroundImage = null;
            x09y09.BackColor = Color.Transparent;
            x09y10.BackgroundImage = null;
            x09y10.BackColor = Color.Transparent;

            x13y31.BackgroundImage = null;
            x13y31.BackColor = Color.Transparent;
            x14y31.BackgroundImage = null;
            x14y31.BackColor = Color.Transparent;

            x13y00.BackgroundImage = null;
            x13y00.BackColor = Color.Transparent;
            x14y00.BackgroundImage = null;
            x14y00.BackColor = Color.Transparent;

            x17y31.BackgroundImage = null;
            x17y31.BackColor = Color.Transparent;
            x18y31.BackgroundImage = null;
            x18y31.BackColor = Color.Transparent;

            x17y00.BackgroundImage = null;
            x17y00.BackColor = Color.Transparent;
            x18y00.BackgroundImage = null;
            x18y00.BackColor = Color.Transparent;

            x22y22.BackgroundImage = null;
            x22y22.BackColor = Color.Transparent;
            x22y21.BackgroundImage = null;
            x22y21.BackColor = Color.Transparent;

            x22y09.BackgroundImage = null;
            x22y09.BackColor = Color.Transparent;
            x22y10.BackgroundImage = null;
            x22y10.BackColor = Color.Transparent;

            x26y28.BackgroundImage = null;
            x26y28.BackColor = Color.Transparent;
            x27y28.BackgroundImage = null;
            x27y28.BackColor = Color.Transparent;

            x26y03.BackgroundImage = null;
            x26y03.BackColor = Color.Transparent;
            x27y03.BackgroundImage = null;
            x27y03.BackColor = Color.Transparent;

            x31y17.BackgroundImage = null;
            x31y17.BackColor = Color.Transparent;
            x31y18.BackgroundImage = null;
            x31y18.BackColor = Color.Transparent;

            x31y13.BackgroundImage = null;
            x31y13.BackColor = Color.Transparent;
            x31y14.BackgroundImage = null;
            x31y14.BackColor = Color.Transparent;

        }
        private void Locate(string entityLocation, Image entity, Color entityColour, ImageLayout entityLayout)
        {
            switch (entityLocation)
            {
                case "x13y00":
                    if (x13y00.BackColor == Color.Transparent)
                    {
                        x13y00.BackgroundImage = entity;
                        x13y00.BackColor = entityColour;
                        x13y00.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y00":
                    if (x14y00.BackColor == Color.Transparent)
                    {
                        x14y00.BackgroundImage = entity;
                        x14y00.BackColor = entityColour;
                        x14y00.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y00":
                    if (x17y00.BackColor == Color.Transparent)
                    {
                        x17y00.BackgroundImage = entity;
                        x17y00.BackColor = entityColour;
                        x17y00.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y00":
                    if (x18y00.BackColor == Color.Transparent)
                    {
                        x18y00.BackgroundImage = entity;
                        x18y00.BackColor = entityColour;
                        x18y00.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y01":
                    if ((x01y01.BackColor == Color.Yellow && entityColour==Color.Yellow)||(x01y01.BackColor==Color.Yellow && entityColour==Color.Orange))
                    {
                        x01y01.BackgroundImage = entity;
                        x01y01.BackColor = entityColour;
                        x01y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y01":
                    if ((x02y01.BackColor == Color.Yellow && entityColour==Color.Yellow)|| (x02y01.BackColor == Color.Yellow && entityColour == Color.Orange))
                    {
                        x02y01.BackgroundImage = entity;
                        x02y01.BackColor = entityColour;
                        x02y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y01":
                    if (x03y01.BackColor == Color.Transparent)
                    {
                        x03y01.BackgroundImage = entity;
                        x03y01.BackColor = entityColour;
                        x03y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y01":
                    if (x04y01.BackColor == Color.Transparent)
                    {
                        x04y01.BackgroundImage = entity;
                        x04y01.BackColor = entityColour;
                        x04y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y01":
                    if (x05y01.BackColor == Color.Transparent)
                    {
                        x05y01.BackgroundImage = entity;
                        x05y01.BackColor = entityColour;
                        x05y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y01":
                    if (x06y01.BackColor == Color.Transparent)
                    {
                        x06y01.BackgroundImage = entity;
                        x06y01.BackColor = entityColour;
                        x06y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y01":
                    if (x07y01.BackColor == Color.Transparent)
                    {
                        x07y01.BackgroundImage = entity;
                        x07y01.BackColor = entityColour;
                        x07y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y01":
                    if (x08y01.BackColor == Color.Transparent)
                    {
                        x08y01.BackgroundImage = entity;
                        x08y01.BackColor = entityColour;
                        x08y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y01":
                    if (x09y01.BackColor == Color.Transparent)
                    {
                        x09y01.BackgroundImage = entity;
                        x09y01.BackColor = entityColour;
                        x09y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y01":
                    if (x10y01.BackColor == Color.Transparent)
                    {
                        x10y01.BackgroundImage = entity;
                        x10y01.BackColor = entityColour;
                        x10y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y01":
                    if (x11y01.BackColor == Color.Transparent)
                    {
                        x11y01.BackgroundImage = entity;
                        x11y01.BackColor = entityColour;
                        x11y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y01":
                    if (x12y01.BackColor == Color.Transparent)
                    {
                        x12y01.BackgroundImage = entity;
                        x12y01.BackColor = entityColour;
                        x12y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y01":
                    if (x13y01.BackColor == Color.Transparent)
                    {
                        x13y01.BackgroundImage = entity;
                        x13y01.BackColor = entityColour;
                        x13y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y01":
                    if (x14y01.BackColor == Color.Transparent)
                    {
                        x14y01.BackgroundImage = entity;
                        x14y01.BackColor = entityColour;
                        x14y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y01":
                    if (x15y01.BackColor == Color.Transparent)
                    {
                        x15y01.BackgroundImage = entity;
                        x15y01.BackColor = entityColour;
                        x15y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y01":
                    if (x16y01.BackColor == Color.Transparent)
                    {
                        x16y01.BackgroundImage = entity;
                        x16y01.BackColor = entityColour;
                        x16y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y01":
                    if (x17y01.BackColor == Color.Transparent)
                    {
                        x17y01.BackgroundImage = entity;
                        x17y01.BackColor = entityColour;
                        x17y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y01":
                    if (x18y01.BackColor == Color.Transparent)
                    {
                        x18y01.BackgroundImage = entity;
                        x18y01.BackColor = entityColour;
                        x18y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y01":
                    if (x19y01.BackColor == Color.Transparent)
                    {
                        x19y01.BackgroundImage = entity;
                        x19y01.BackColor = entityColour;
                        x19y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y01":
                    if (x20y01.BackColor == Color.Transparent)
                    {
                        x20y01.BackgroundImage = entity;
                        x20y01.BackColor = entityColour;
                        x20y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y01":
                    if (x21y01.BackColor == Color.Transparent)
                    {
                        x21y01.BackgroundImage = entity;
                        x21y01.BackColor = entityColour;
                        x21y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y01":
                    if (x22y01.BackColor == Color.Transparent)
                    {
                        x22y01.BackgroundImage = entity;
                        x22y01.BackColor = entityColour;
                        x22y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y01":
                    if (x23y01.BackColor == Color.Transparent)
                    {
                        x23y01.BackgroundImage = entity;
                        x23y01.BackColor = entityColour;
                        x23y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y01":
                    if (x24y01.BackColor == Color.Transparent)
                    {
                        x24y01.BackgroundImage = entity;
                        x24y01.BackColor = entityColour;
                        x24y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y01":
                    if (x25y01.BackColor == Color.Transparent)
                    {
                        x25y01.BackgroundImage = entity;
                        x25y01.BackColor = entityColour;
                        x25y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y01":
                    if (x26y01.BackColor == Color.Transparent)
                    {
                        x26y01.BackgroundImage = entity;
                        x26y01.BackColor = entityColour;
                        x26y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y01":
                    if (x27y01.BackColor == Color.Transparent)
                    {
                        x27y01.BackgroundImage = entity;
                        x27y01.BackColor = entityColour;
                        x27y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y01":
                    if (x28y01.BackColor == Color.Transparent)
                    {
                        x28y01.BackgroundImage = entity;
                        x28y01.BackColor = entityColour;
                        x28y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y01":
                    if ((x29y01.BackColor == Color.Blue && entityColour == Color.Blue) || (x29y01.BackColor == Color.Blue && entityColour == Color.DarkBlue))
                    {
                        x29y01.BackgroundImage = entity;
                        x29y01.BackColor = entityColour;
                        x29y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y01":
                    if ((x30y01.BackColor == Color.Blue && entityColour == Color.Blue) || (x30y01.BackColor == Color.Blue && entityColour == Color.DarkBlue))
                    {
                        x30y01.BackgroundImage = entity;
                        x30y01.BackColor = entityColour;
                        x30y01.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y02":
                    if ((x01y02.BackColor == Color.Yellow && x01y02.BackColor==Color.Yellow) || (x01y02.BackColor == Color.Yellow && entityColour == Color.Orange))
                    {
                        x01y02.BackgroundImage = entity;
                        x01y02.BackColor = entityColour;
                        x01y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y02":
                    if (x02y02.BackColor == Color.Transparent)
                    {
                        x02y02.BackgroundImage = entity;
                        x02y02.BackColor = entityColour;
                        x02y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y02":
                    if (x03y02.BackColor == Color.Transparent)
                    {
                        x03y02.BackgroundImage = entity;
                        x03y02.BackColor = entityColour;
                        x03y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y02":
                    if (x04y02.BackColor == Color.Transparent)
                    {
                        x04y02.BackgroundImage = entity;
                        x04y02.BackColor = entityColour;
                        x04y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y02":
                    if (x05y02.BackColor == Color.Transparent)
                    {
                        x05y02.BackgroundImage = entity;
                        x05y02.BackColor = entityColour;
                        x05y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y02":
                    if (x06y02.BackColor == Color.Transparent)
                    {
                        x06y02.BackgroundImage = entity;
                        x06y02.BackColor = entityColour;
                        x06y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y02":
                    if (x07y02.BackColor == Color.Transparent)
                    {
                        x07y02.BackgroundImage = entity;
                        x07y02.BackColor = entityColour;
                        x07y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y02":
                    if (x08y02.BackColor == Color.Transparent)
                    {
                        x08y02.BackgroundImage = entity;
                        x08y02.BackColor = entityColour;
                        x08y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y02":
                    if (x09y02.BackColor == Color.Transparent)
                    {
                        x09y02.BackgroundImage = entity;
                        x09y02.BackColor = entityColour;
                        x09y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y02":
                    if (x10y02.BackColor == Color.Transparent)
                    {
                        x10y02.BackgroundImage = entity;
                        x10y02.BackColor = entityColour;
                        x10y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y02":
                    if (x11y02.BackColor == Color.Transparent)
                    {
                        x11y02.BackgroundImage = entity;
                        x11y02.BackColor = entityColour;
                        x11y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y02":
                    if (x12y02.BackColor == Color.Transparent)
                    {
                        x12y02.BackgroundImage = entity;
                        x12y02.BackColor = entityColour;
                        x12y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y02":
                    if (x13y02.BackColor == Color.Transparent)
                    {
                        x13y02.BackgroundImage = entity;
                        x13y02.BackColor = entityColour;
                        x13y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y02":
                    if (x14y02.BackColor == Color.Transparent)
                    {
                        x14y02.BackgroundImage = entity;
                        x14y02.BackColor = entityColour;
                        x14y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y02":
                    if (x15y02.BackColor == Color.Transparent)
                    {
                        x15y02.BackgroundImage = entity;
                        x15y02.BackColor = entityColour;
                        x15y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y02":
                    if (x16y02.BackColor == Color.Transparent)
                    {
                        x16y02.BackgroundImage = entity;
                        x16y02.BackColor = entityColour;
                        x16y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y02":
                    if (x17y02.BackColor == Color.Transparent)
                    {
                        x17y02.BackgroundImage = entity;
                        x17y02.BackColor = entityColour;
                        x17y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y02":
                    if (x18y02.BackColor == Color.Transparent)
                    {
                        x18y02.BackgroundImage = entity;
                        x18y02.BackColor = entityColour;
                        x18y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y02":
                    if (x19y02.BackColor == Color.Transparent)
                    {
                        x19y02.BackgroundImage = entity;
                        x19y02.BackColor = entityColour;
                        x19y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y02":
                    if (x20y02.BackColor == Color.Transparent)
                    {
                        x20y02.BackgroundImage = entity;
                        x20y02.BackColor = entityColour;
                        x20y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y02":
                    if (x21y02.BackColor == Color.Transparent)
                    {
                        x21y02.BackgroundImage = entity;
                        x21y02.BackColor = entityColour;
                        x21y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y02":
                    if (x22y02.BackColor == Color.Transparent)
                    {
                        x22y02.BackgroundImage = entity;
                        x22y02.BackColor = entityColour;
                        x22y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y02":
                    if (x23y02.BackColor == Color.Transparent)
                    {
                        x23y02.BackgroundImage = entity;
                        x23y02.BackColor = entityColour;
                        x23y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y02":
                    if (x24y02.BackColor == Color.Transparent)
                    {
                        x24y02.BackgroundImage = entity;
                        x24y02.BackColor = entityColour;
                        x24y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y02":
                    if (x25y02.BackColor == Color.Transparent)
                    {
                        x25y02.BackgroundImage = entity;
                        x25y02.BackColor = entityColour;
                        x25y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y02":
                    if (x26y02.BackColor == Color.Transparent)
                    {
                        x26y02.BackgroundImage = entity;
                        x26y02.BackColor = entityColour;
                        x26y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y02":
                    if (x27y02.BackColor == Color.Transparent)
                    {
                        x27y02.BackgroundImage = entity;
                        x27y02.BackColor = entityColour;
                        x27y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y02":
                    if (x28y02.BackColor == Color.Transparent)
                    {
                        x28y02.BackgroundImage = entity;
                        x28y02.BackColor = entityColour;
                        x28y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y02":
                    if (x29y02.BackColor == Color.Transparent)
                    {
                        x29y02.BackgroundImage = entity;
                        x29y02.BackColor = entityColour;
                        x29y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y02":
                    if ((x30y02.BackColor == Color.Blue && entityColour == Color.Blue) || (x30y02.BackColor == Color.Blue && entityColour == Color.DarkBlue))
                    {
                        x30y02.BackgroundImage = entity;
                        x30y02.BackColor = entityColour;
                        x30y02.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y03":
                    if (x01y03.BackColor == Color.Transparent)
                    {
                        x01y03.BackgroundImage = entity;
                        x01y03.BackColor = entityColour;
                        x01y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y03":
                    if (x02y03.BackColor == Color.Transparent)
                    {
                        x02y03.BackgroundImage = entity;
                        x02y03.BackColor = entityColour;
                        x02y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y03":
                    if (x03y03.BackColor == Color.Transparent)
                    {
                        x03y03.BackgroundImage = entity;
                        x03y03.BackColor = entityColour;
                        x03y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y03":
                    if (x04y03.BackColor == Color.Transparent)
                    {
                        x04y03.BackgroundImage = entity;
                        x04y03.BackColor = entityColour;
                        x04y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y03":
                    if (x05y03.BackColor == Color.Transparent)
                    {
                        x05y03.BackgroundImage = entity;
                        x05y03.BackColor = entityColour;
                        x05y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y03":
                    if (x06y03.BackColor == Color.Transparent)
                    {
                        x06y03.BackgroundImage = entity;
                        x06y03.BackColor = entityColour;
                        x06y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y03":
                    if (x07y03.BackColor == Color.Transparent)
                    {
                        x07y03.BackgroundImage = entity;
                        x07y03.BackColor = entityColour;
                        x07y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y03":
                    if (x09y03.BackColor == Color.Transparent)
                    {
                        x09y03.BackgroundImage = entity;
                        x09y03.BackColor = entityColour;
                        x09y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y03":
                    if (x10y03.BackColor == Color.Transparent)
                    {
                        x10y03.BackgroundImage = entity;
                        x10y03.BackColor = entityColour;
                        x10y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y03":
                    if (x11y03.BackColor == Color.Transparent)
                    {
                        x11y03.BackgroundImage = entity;
                        x11y03.BackColor = entityColour;
                        x11y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y03":
                    if (x15y03.BackColor == Color.Transparent)
                    {
                        x15y03.BackgroundImage = entity;
                        x15y03.BackColor = entityColour;
                        x15y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y03":
                    if (x16y03.BackColor == Color.Transparent)
                    {
                        x16y03.BackgroundImage = entity;
                        x16y03.BackColor = entityColour;
                        x16y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y03":
                    if (x20y03.BackColor == Color.Transparent)
                    {
                        x20y03.BackgroundImage = entity;
                        x20y03.BackColor = entityColour;
                        x20y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y03":
                    if (x21y03.BackColor == Color.Transparent)
                    {
                        x21y03.BackgroundImage = entity;
                        x21y03.BackColor = entityColour;
                        x21y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y03":
                    if (x22y03.BackColor == Color.Transparent)
                    {
                        x22y03.BackgroundImage = entity;
                        x22y03.BackColor = entityColour;
                        x22y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y03":
                    if (x24y03.BackColor == Color.Transparent)
                    {
                        x24y03.BackgroundImage = entity;
                        x24y03.BackColor = entityColour;
                        x24y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y03":
                    if (x25y03.BackColor == Color.Transparent)
                    {
                        x25y03.BackgroundImage = entity;
                        x25y03.BackColor = entityColour;
                        x25y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y03":
                    if (x26y03.BackColor == Color.Transparent)
                    {
                        x26y03.BackgroundImage = entity;
                        x26y03.BackColor = entityColour;
                        x26y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y03":
                    if (x27y03.BackColor == Color.Transparent)
                    {
                        x27y03.BackgroundImage = entity;
                        x27y03.BackColor = entityColour;
                        x27y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y03":
                    if (x28y03.BackColor == Color.Transparent)
                    {
                        x28y03.BackgroundImage = entity;
                        x28y03.BackColor = entityColour;
                        x28y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y03":
                    if (x29y03.BackColor == Color.Transparent)
                    {
                        x29y03.BackgroundImage = entity;
                        x29y03.BackColor = entityColour;
                        x29y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y03":
                    if (x30y03.BackColor == Color.Transparent)
                    {
                        x30y03.BackgroundImage = entity;
                        x30y03.BackColor = entityColour;
                        x30y03.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y04":
                    if (x01y04.BackColor == Color.Transparent)
                    {
                        x01y04.BackgroundImage = entity;
                        x01y04.BackColor = entityColour;
                        x01y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y04":
                    if (x02y04.BackColor == Color.Transparent)
                    {
                        x02y04.BackgroundImage = entity;
                        x02y04.BackColor = entityColour;
                        x02y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y04":
                    if (x03y04.BackColor == Color.Transparent)
                    {
                        x03y04.BackgroundImage = entity;
                        x03y04.BackColor = entityColour;
                        x03y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y04":
                    if (x04y04.BackColor == Color.Transparent)
                    {
                        x04y04.BackgroundImage = entity;
                        x04y04.BackColor = entityColour;
                        x04y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y04":
                    if (x05y04.BackColor == Color.Transparent)
                    {
                        x05y04.BackgroundImage = entity;
                        x05y04.BackColor = entityColour;
                        x05y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y04":
                    if (x06y04.BackColor == Color.Transparent)
                    {
                        x06y04.BackgroundImage = entity;
                        x06y04.BackColor = entityColour;
                        x06y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y04":
                    if (x07y04.BackColor == Color.Transparent)
                    {
                        x07y04.BackgroundImage = entity;
                        x07y04.BackColor = entityColour;
                        x07y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y04":
                    if (x09y04.BackColor == Color.Transparent)
                    {
                        x09y04.BackgroundImage = entity;
                        x09y04.BackColor = entityColour;
                        x09y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y04":
                    if (x10y04.BackColor == Color.Transparent)
                    {
                        x10y04.BackgroundImage = entity;
                        x10y04.BackColor = entityColour;
                        x10y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y04":
                    if (x11y04.BackColor == Color.Transparent)
                    {
                        x11y04.BackgroundImage = entity;
                        x11y04.BackColor = entityColour;
                        x11y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y04":
                    if (x13y04.BackColor == Color.Transparent)
                    {
                        x13y04.BackgroundImage = entity;
                        x13y04.BackColor = entityColour;
                        x13y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y04":
                    if (x14y04.BackColor == Color.Transparent)
                    {
                        x14y04.BackgroundImage = entity;
                        x14y04.BackColor = entityColour;
                        x14y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y04":
                    if (x15y04.BackColor == Color.Transparent)
                    {
                        x15y04.BackgroundImage = entity;
                        x15y04.BackColor = entityColour;
                        x15y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y04":
                    if (x16y04.BackColor == Color.Transparent)
                    {
                        x16y04.BackgroundImage = entity;
                        x16y04.BackColor = entityColour;
                        x16y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y04":
                    if (x17y04.BackColor == Color.Transparent)
                    {
                        x17y04.BackgroundImage = entity;
                        x17y04.BackColor = entityColour;
                        x17y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y04":
                    if (x18y04.BackColor == Color.Transparent)
                    {
                        x18y04.BackgroundImage = entity;
                        x18y04.BackColor = entityColour;
                        x18y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y04":
                    if (x20y04.BackColor == Color.Transparent)
                    {
                        x20y04.BackgroundImage = entity;
                        x20y04.BackColor = entityColour;
                        x20y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y04":
                    if (x21y04.BackColor == Color.Transparent)
                    {
                        x21y04.BackgroundImage = entity;
                        x21y04.BackColor = entityColour;
                        x21y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y04":
                    if (x22y04.BackColor == Color.Transparent)
                    {
                        x22y04.BackgroundImage = entity;
                        x22y04.BackColor = entityColour;
                        x22y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y04":
                    if (x24y04.BackColor == Color.Transparent)
                    {
                        x24y04.BackgroundImage = entity;
                        x24y04.BackColor = entityColour;
                        x24y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y04":
                    if (x25y04.BackColor == Color.Transparent)
                    {
                        x25y04.BackgroundImage = entity;
                        x25y04.BackColor = entityColour;
                        x25y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y04":
                    if(x26y04.BackColor == Color.Transparent)
                    {
                        x26y04.BackgroundImage = entity;
                        x26y04.BackColor = entityColour;
                        x26y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y04":
                    if (x27y04.BackColor == Color.Transparent)
                    {
                        x27y04.BackgroundImage = entity;
                        x27y04.BackColor = entityColour;
                        x27y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y04":
                    if (x28y04.BackColor == Color.Transparent)
                    {
                        x28y04.BackgroundImage = entity;
                        x28y04.BackColor = entityColour;
                        x28y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y04":
                    if (x29y04.BackColor == Color.Transparent)
                    {
                        x29y04.BackgroundImage = entity;
                        x29y04.BackColor = entityColour;
                        x29y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y04":
                    if (x30y04.BackColor == Color.Transparent)
                    {
                        x30y04.BackgroundImage = entity;
                        x30y04.BackColor = entityColour;
                        x30y04.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y05":
                    if (x01y05.BackColor == Color.Transparent)
                    {
                        x01y05.BackgroundImage = entity;
                        x01y05.BackColor = entityColour;
                        x01y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y05":
                    if (x02y05.BackColor == Color.Transparent)
                    {
                        x02y05.BackgroundImage = entity;
                        x02y05.BackColor = entityColour;
                        x02y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y05":
                    if (x03y05.BackColor == Color.Transparent)
                    {
                        x03y05.BackgroundImage = entity;
                        x03y05.BackColor = entityColour;
                        x03y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y05":
                    if (x04y05.BackColor == Color.Transparent)
                    {
                        x04y05.BackgroundImage = entity;
                        x04y05.BackColor = entityColour;
                        x04y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y05":
                    if (x05y05.BackColor == Color.Transparent)
                    {
                        x05y05.BackgroundImage = entity;
                        x05y05.BackColor = entityColour;
                        x05y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y05":
                    if (x06y05.BackColor == Color.Transparent)
                    {
                        x06y05.BackgroundImage = entity;
                        x06y05.BackColor = entityColour;
                        x06y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y05":
                    if (x07y05.BackColor == Color.Transparent)
                    {
                        x07y05.BackgroundImage = entity;
                        x07y05.BackColor = entityColour;
                        x07y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y05":
                    if (x09y05.BackColor == Color.Transparent)
                    {
                        x09y05.BackgroundImage = entity;
                        x09y05.BackColor = entityColour;
                        x09y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y05":
                    if (x10y05.BackColor == Color.Transparent)
                    {
                        x10y05.BackgroundImage = entity;
                        x10y05.BackColor = entityColour;
                        x10y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "11y05":
                    if (x11y05.BackColor == Color.Transparent)
                    {
                        x11y05.BackgroundImage = entity;
                        x11y05.BackColor = entityColour;
                        x11y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y05":
                    if (x13y05.BackColor == Color.Transparent)
                    {
                        x13y05.BackgroundImage = entity;
                        x13y05.BackColor = entityColour;
                        x13y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y05":
                    if (x14y05.BackColor == Color.Transparent)
                    {
                        x14y05.BackgroundImage = entity;
                        x14y05.BackColor = entityColour;
                        x14y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y05":
                    if (x15y05.BackColor == Color.Transparent)
                    {
                        x15y05.BackgroundImage = entity;
                        x15y05.BackColor = entityColour;
                        x15y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y05":
                    if (x16y05.BackColor == Color.Transparent)
                    {
                        x16y05.BackgroundImage = entity;
                        x16y05.BackColor = entityColour;
                        x16y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y05":
                    if (x17y05.BackColor == Color.Transparent)
                    {
                        x17y05.BackgroundImage = entity;
                        x17y05.BackColor = entityColour;
                        x17y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y05":
                    if (x18y05.BackColor == Color.Transparent)
                    {
                        x18y05.BackgroundImage = entity;
                        x18y05.BackColor = entityColour;
                        x18y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y05":
                    if (x20y05.BackColor == Color.Transparent)
                    {
                        x20y05.BackgroundImage = entity;
                        x20y05.BackColor = entityColour;
                        x20y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y05":
                    if (x21y05.BackColor == Color.Transparent)
                    {
                        x21y05.BackgroundImage = entity;
                        x21y05.BackColor = entityColour;
                        x21y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y05":
                    if (x22y05.BackColor == Color.Transparent)
                    {
                        x22y05.BackgroundImage = entity;
                        x22y05.BackColor = entityColour;
                        x22y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y05":
                    if (x24y05.BackColor == Color.Transparent)
                    {
                        x24y05.BackgroundImage = entity;
                        x24y05.BackColor = entityColour;
                        x24y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y05":
                    if (x25y05.BackColor == Color.Transparent)
                    {
                        x25y05.BackgroundImage = entity;
                        x25y05.BackColor = entityColour;
                        x25y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y05":
                    if (x26y05.BackColor == Color.Transparent)
                    {
                        x26y05.BackgroundImage = entity;
                        x26y05.BackColor = entityColour;
                        x26y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y05":
                    if (x27y05.BackColor == Color.Transparent)
                    {
                        x27y05.BackgroundImage = entity;
                        x27y05.BackColor = entityColour;
                        x27y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y05":
                    if (x28y05.BackColor == Color.Transparent)
                    {
                        x28y05.BackgroundImage = entity;
                        x28y05.BackColor = entityColour;
                        x28y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y05":
                    if (x29y05.BackColor == Color.Transparent)
                    {
                        x29y05.BackgroundImage = entity;
                        x29y05.BackColor = entityColour;
                        x29y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y05":
                    if (x30y05.BackColor == Color.Transparent)
                    {
                        x30y05.BackgroundImage = entity;
                        x30y05.BackColor = entityColour;
                        x30y05.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y06":
                    if (x01y06.BackColor == Color.Transparent)
                    {
                        x01y06.BackgroundImage = entity;
                        x01y06.BackColor = entityColour;
                        x01y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y06":
                    if (x02y06.BackColor == Color.Transparent)
                    {
                        x02y06.BackgroundImage = entity;
                        x02y06.BackColor = entityColour;
                        x02y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y06":
                    if (x05y06.BackColor == Color.Transparent)
                    {
                        x05y06.BackgroundImage = entity;
                        x05y06.BackColor = entityColour;
                        x05y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y06":
                    if (x06y06.BackColor == Color.Transparent)
                    {
                        x06y06.BackgroundImage = entity;
                        x06y06.BackColor = entityColour;
                        x06y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y06":
                    if (x10y06.BackColor == Color.Transparent)
                    {
                        x10y06.BackgroundImage = entity;
                        x10y06.BackColor = entityColour;
                        x10y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y06":
                    if (x11y06.BackColor == Color.Transparent)
                    {
                        x11y06.BackgroundImage = entity;
                        x11y06.BackColor = entityColour;
                        x11y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y06":
                    if (x15y06.BackColor == Color.Transparent)
                    {
                        x15y06.BackgroundImage = entity;
                        x15y06.BackColor = entityColour;
                        x15y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y06":
                    if (x16y06.BackColor == Color.Transparent)
                    {
                        x16y06.BackgroundImage = entity;
                        x16y06.BackColor = entityColour;
                        x16y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y06":
                    if (x20y06.BackColor == Color.Transparent)
                    {
                        x20y06.BackgroundImage = entity;
                        x20y06.BackColor = entityColour;
                        x20y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y06":
                    if (x21y06.BackColor == Color.Transparent)
                    {
                        x21y06.BackgroundImage = entity;
                        x21y06.BackColor = entityColour;
                        x21y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y06":
                    if (x25y06.BackColor == Color.Transparent)
                    {
                        x25y06.BackgroundImage = entity;
                        x25y06.BackColor = entityColour;
                        x25y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y06":
                    if (x26y06.BackColor == Color.Transparent)
                    {
                        x26y06.BackgroundImage = entity;
                        x26y06.BackColor = entityColour;
                        x26y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y06":
                    if (x29y06.BackColor == Color.Transparent)
                    {
                        x29y06.BackgroundImage = entity;
                        x29y06.BackColor = entityColour;
                        x29y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y06":
                    if (x30y06.BackColor == Color.Transparent)
                    {
                        x30y06.BackgroundImage = entity;
                        x30y06.BackColor = entityColour;
                        x30y06.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y07":
                    if (x01y07.BackColor == Color.Transparent)
                    {
                        x01y07.BackgroundImage = entity;
                        x01y07.BackColor = entityColour;
                        x01y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y07":
                    if (x02y07.BackColor == Color.Transparent)
                    {
                        x02y07.BackgroundImage = entity;
                        x02y07.BackColor = entityColour;
                        x02y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y07":
                    if (x04y07.BackColor == Color.Transparent)
                    {
                        x04y07.BackgroundImage = entity;
                        x04y07.BackColor = entityColour;
                        x04y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y07":
                    if (x05y07.BackColor == Color.Transparent)
                    {
                        x05y07.BackgroundImage = entity;
                        x05y07.BackColor = entityColour;
                        x05y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y07":
                    if (x06y07.BackColor == Color.Transparent)
                    {
                        x06y07.BackgroundImage = entity;
                        x06y07.BackColor = entityColour;
                        x06y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y07":
                    if (x07y07.BackColor == Color.Transparent)
                    {
                        x07y07.BackgroundImage = entity;
                        x07y07.BackColor = entityColour;
                        x07y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y07":
                    if (x08y07.BackColor == Color.Transparent)
                    {
                        x08y07.BackgroundImage = entity;
                        x08y07.BackColor = entityColour;
                        x08y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y07":
                    if (x09y07.BackColor == Color.Transparent)
                    {
                        x09y07.BackgroundImage = entity;
                        x09y07.BackColor = entityColour;
                        x09y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y07":
                    if (x10y07.BackColor == Color.Transparent)
                    {
                        x10y07.BackgroundImage = entity;
                        x10y07.BackColor = entityColour;
                        x10y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y07":
                    if (x11y07.BackColor == Color.Transparent)
                    {
                        x11y07.BackgroundImage = entity;
                        x11y07.BackColor = entityColour;
                        x11y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y07":
                    if (x12y07.BackColor == Color.Transparent)
                    {
                        x12y07.BackgroundImage = entity;
                        x12y07.BackColor = entityColour;
                        x12y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y07":
                    if (x13y07.BackColor == Color.Transparent)
                    {
                        x13y07.BackgroundImage = entity;
                        x13y07.BackColor = entityColour;
                        x13y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y07":
                    if (x14y07.BackColor == Color.Transparent)
                    {
                        x14y07.BackgroundImage = entity;
                        x14y07.BackColor = entityColour;
                        x14y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y07":
                    if (x15y07.BackColor == Color.Transparent)
                    {
                        x15y07.BackgroundImage = entity;
                        x15y07.BackColor = entityColour;
                        x15y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y07":
                    if (x16y07.BackColor == Color.Transparent)
                    {
                        x16y07.BackgroundImage = entity;
                        x16y07.BackColor = entityColour;
                        x16y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y07":
                    if (x17y07.BackColor == Color.Transparent)
                    {
                        x17y07.BackgroundImage = entity;
                        x17y07.BackColor = entityColour;
                        x17y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y07":
                    if (x18y07.BackColor == Color.Transparent)
                    {
                        x18y07.BackgroundImage = entity;
                        x18y07.BackColor = entityColour;
                        x18y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y07":
                    if (x19y07.BackColor == Color.Transparent)
                    {
                        x19y07.BackgroundImage = entity;
                        x19y07.BackColor = entityColour;
                        x19y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y07":
                    if (x20y07.BackColor == Color.Transparent)
                    {
                        x20y07.BackgroundImage = entity;
                        x20y07.BackColor = entityColour;
                        x20y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y07":
                    if (x21y07.BackColor == Color.Transparent)
                    {
                        x21y07.BackgroundImage = entity;
                        x21y07.BackColor = entityColour;
                        x21y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y07":
                    if (x22y07.BackColor == Color.Transparent)
                    {
                        x22y07.BackgroundImage = entity;
                        x22y07.BackColor = entityColour;
                        x22y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y07":
                    if (x23y07.BackColor == Color.Transparent)
                    {
                        x23y07.BackgroundImage = entity;
                        x23y07.BackColor = entityColour;
                        x23y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y07":
                    if (x24y07.BackColor == Color.Transparent)
                    {
                        x24y07.BackgroundImage = entity;
                        x24y07.BackColor = entityColour;
                        x24y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y07":
                    if (x25y07.BackColor == Color.Transparent)
                    {
                        x25y07.BackgroundImage = entity;
                        x25y07.BackColor = entityColour;
                        x25y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y07":
                    if (x26y07.BackColor == Color.Transparent)
                    {
                        x26y07.BackgroundImage = entity;
                        x26y07.BackColor = entityColour;
                        x26y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y07":
                    if (x27y07.BackColor == Color.Transparent)
                    {
                        x27y07.BackgroundImage = entity;
                        x27y07.BackColor = entityColour;
                        x27y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y07":
                    if (x29y07.BackColor == Color.Transparent)
                    {
                        x29y07.BackgroundImage = entity;
                        x29y07.BackColor = entityColour;
                        x29y07.BackgroundImageLayout = entityLayout;
                    }
                    break; ;
                case "x30y07":
                    if (x30y07.BackColor == Color.Transparent)
                    {
                        x30y07.BackgroundImage = entity;
                        x30y07.BackColor = entityColour;
                        x30y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y08":
                    if (x01y08.BackColor == Color.Transparent)
                    {
                        x01y08.BackgroundImage = entity;
                        x01y08.BackColor = entityColour;
                        x01y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y08":
                    if (x02y08.BackColor == Color.Transparent)
                    {
                        x02y08.BackgroundImage = entity;
                        x02y08.BackColor = entityColour;
                        x02y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y08":
                    if (x04y08.BackColor == Color.Transparent)
                    {
                        x04y08.BackgroundImage = entity;
                        x04y08.BackColor = entityColour;
                        x04y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y08":
                    if (x05y08.BackColor == Color.Transparent)
                    {
                        x05y08.BackgroundImage = entity;
                        x05y08.BackColor = entityColour;
                        x05y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y08":
                    if (x06y08.BackColor == Color.Transparent)
                    {
                        x06y08.BackgroundImage = entity;
                        x06y08.BackColor = entityColour;
                        x06y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y08":
                    if (x07y08.BackColor == Color.Transparent)
                    {
                        x07y08.BackgroundImage = entity;
                        x07y08.BackColor = entityColour;
                        x07y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y08":
                    if (x08y08.BackColor == Color.Transparent)
                    {
                        x08y08.BackgroundImage = entity;
                        x08y08.BackColor = entityColour;
                        x08y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y08":
                    if (x09y08.BackColor == Color.Transparent)
                    {
                        x09y08.BackgroundImage = entity;
                        x09y08.BackColor = entityColour;
                        x09y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y08":
                    if (x10y08.BackColor == Color.Transparent)
                    {
                        x10y08.BackgroundImage = entity;
                        x10y08.BackColor = entityColour;
                        x10y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y08":
                    if (x11y08.BackColor == Color.Transparent)
                    {
                        x11y08.BackgroundImage = entity;
                        x11y08.BackColor = entityColour;
                        x11y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y08":
                    if (x12y08.BackColor == Color.Transparent)
                    {
                        x12y08.BackgroundImage = entity;
                        x12y08.BackColor = entityColour;
                        x12y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y08":
                    if (x13y08.BackColor == Color.Transparent)
                    {
                        x13y08.BackgroundImage = entity;
                        x13y08.BackColor = entityColour;
                        x13y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y08":
                    if (x14y08.BackColor == Color.Transparent)
                    {
                        x14y08.BackgroundImage = entity;
                        x14y08.BackColor = entityColour;
                        x14y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y08":
                    if (x15y08.BackColor == Color.Transparent)
                    {
                        x15y08.BackgroundImage = entity;
                        x15y08.BackColor = entityColour;
                        x15y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y08":
                    if (x16y08.BackColor == Color.Transparent)
                    {
                        x16y08.BackgroundImage = entity;
                        x16y08.BackColor = entityColour;
                        x16y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y08":
                    if (x17y08.BackColor == Color.Transparent)
                    {
                        x17y08.BackgroundImage = entity;
                        x17y08.BackColor = entityColour;
                        x17y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y08":
                    if (x18y08.BackColor == Color.Transparent)
                    {
                        x18y08.BackgroundImage = entity;
                        x18y08.BackColor = entityColour;
                        x18y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y08":
                    if (x19y08.BackColor == Color.Transparent)
                    {
                        x19y08.BackgroundImage = entity;
                        x19y08.BackColor = entityColour;
                        x19y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y08":
                    if (x20y08.BackColor == Color.Transparent)
                    {
                        x20y08.BackgroundImage = entity;
                        x20y08.BackColor = entityColour;
                        x20y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y08":
                    if (x21y08.BackColor == Color.Transparent)
                    {
                        x21y08.BackgroundImage = entity;
                        x21y08.BackColor = entityColour;
                        x21y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y08":
                    if (x22y08.BackColor == Color.Transparent)
                    {
                        x22y08.BackgroundImage = entity;
                        x22y08.BackColor = entityColour;
                        x22y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y08":
                    if (x23y08.BackColor == Color.Transparent)
                    {
                        x23y08.BackgroundImage = entity;
                        x23y08.BackColor = entityColour;
                        x23y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y08":
                    if (x24y08.BackColor == Color.Transparent)
                    {
                        x24y08.BackgroundImage = entity;
                        x24y08.BackColor = entityColour;
                        x24y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y08":
                    if (x25y08.BackColor == Color.Transparent)
                    {
                        x25y08.BackgroundImage = entity;
                        x25y08.BackColor = entityColour;
                        x25y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y08":
                    if (x26y08.BackColor == Color.Transparent)
                    {
                        x26y08.BackgroundImage = entity;
                        x26y08.BackColor = entityColour;
                        x26y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y08":
                    if (x27y08.BackColor == Color.Transparent)
                    {
                        x27y08.BackgroundImage = entity;
                        x27y08.BackColor = entityColour;
                        x27y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y08":
                    if (x29y08.BackColor == Color.Transparent)
                    {
                        x29y08.BackgroundImage = entity;
                        x29y08.BackColor = entityColour;
                        x29y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y08":
                    if (x30y08.BackColor == Color.Transparent)
                    {
                        x30y08.BackgroundImage = entity;
                        x30y08.BackColor = entityColour;
                        x30y08.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y09":
                    if (x01y09.BackColor == Color.Transparent)
                    {
                        x01y09.BackgroundImage = entity;
                        x01y09.BackColor = entityColour;
                        x01y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y09":
                    if (x02y09.BackColor == Color.Transparent)
                    {
                        x02y09.BackgroundImage = entity;
                        x02y09.BackColor = entityColour;
                        x02y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y09":
                    if (x07y09.BackColor == Color.Transparent)
                    {
                        x03y09.BackgroundImage = entity;
                        x03y09.BackColor = entityColour;
                        x03y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y09":
                    if (x04y09.BackColor == Color.Transparent)
                    {
                        x04y09.BackgroundImage = entity;
                        x04y09.BackColor = entityColour;
                        x04y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y09":
                    if (x05y09.BackColor == Color.Transparent)
                    {
                        x05y09.BackgroundImage = entity;
                        x05y09.BackColor = entityColour;
                        x05y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y09":
                    if (x07y09.BackColor == Color.Transparent)
                    {
                        x07y09.BackgroundImage = entity;
                        x07y09.BackColor = entityColour;
                        x07y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y09":
                    if (x08y09.BackColor == Color.Transparent)
                    {
                        x08y09.BackgroundImage = entity;
                        x08y09.BackColor = entityColour;
                        x08y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y09":
                    if (x09y09.BackColor == Color.Transparent)
                    {
                        x09y09.BackgroundImage = entity;
                        x09y09.BackColor = entityColour;
                        x09y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y09":
                    if (x10y09.BackColor == Color.Transparent)
                    {
                        x10y09.BackgroundImage = entity;
                        x10y09.BackColor = entityColour;
                        x10y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y09":
                    if (x11y09.BackColor == Color.Transparent)
                    {
                        x11y09.BackgroundImage = entity;
                        x11y09.BackColor = entityColour;
                        x11y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y09":
                    if (x15y09.BackColor == Color.Transparent)
                    {
                        x15y09.BackgroundImage = entity;
                        x15y09.BackColor = entityColour;
                        x15y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y09":
                    if (x16y09.BackColor == Color.Transparent)
                    {
                        x16y09.BackgroundImage = entity;
                        x16y09.BackColor = entityColour;
                        x16y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y09":
                    if (x20y09.BackColor == Color.Transparent)
                    {
                        x20y09.BackgroundImage = entity;
                        x20y09.BackColor = entityColour;
                        x20y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y09":
                    if (x21y09.BackColor == Color.Transparent)
                    {
                        x21y09.BackgroundImage = entity;
                        x21y09.BackColor = entityColour;
                        x21y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y09":
                    if (x22y09.BackColor == Color.Transparent)
                    {
                        x22y09.BackgroundImage = entity;
                        x22y09.BackColor = entityColour;
                        x22y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y09":
                    if (x23y09.BackColor == Color.Transparent)
                    {
                        x23y09.BackgroundImage = entity;
                        x23y09.BackColor = entityColour;
                        x23y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y09":
                    if (x24y09.BackColor == Color.Transparent)
                    {
                        x24y09.BackgroundImage = entity;
                        x24y09.BackColor = entityColour;
                        x24y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y09":
                    if (x26y09.BackColor == Color.Transparent)
                    {
                        x26y09.BackgroundImage = entity;
                        x26y09.BackColor = entityColour;
                        x26y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y09":
                    if (x27y09.BackColor == Color.Transparent)
                    {
                        x27y09.BackgroundImage = entity;
                        x27y09.BackColor = entityColour;
                        x27y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y09":
                    if (x28y09.BackColor == Color.Transparent)
                    {
                        x28y09.BackgroundImage = entity;
                        x28y09.BackColor = entityColour;
                        x28y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y09":
                    if (x29y10.BackColor == Color.Transparent)
                    {
                        x29y07.BackgroundImage = entity;
                        x29y07.BackColor = entityColour;
                        x29y07.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y09":
                    if (x30y09.BackColor == Color.Transparent)
                    {
                        x30y09.BackgroundImage = entity;
                        x30y09.BackColor = entityColour;
                        x30y09.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y10":
                    if (x01y10.BackColor == Color.Transparent)
                    {
                        x01y10.BackgroundImage = entity;
                        x01y10.BackColor = entityColour;
                        x01y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y10":
                    if (x02y10.BackColor == Color.Transparent)
                    {
                        x02y10.BackgroundImage = entity;
                        x02y10.BackColor = entityColour;
                        x02y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y10":
                    if (x03y10.BackColor == Color.Transparent)
                    {
                        x03y10.BackgroundImage = entity;
                        x03y10.BackColor = entityColour;
                        x03y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y10":
                    if (x04y10.BackColor == Color.Transparent)
                    {
                        x04y10.BackgroundImage = entity;
                        x04y10.BackColor = entityColour;
                        x04y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y10":
                    if (x05y10.BackColor == Color.Transparent)
                    {
                        x05y10.BackgroundImage = entity;
                        x05y10.BackColor = entityColour;
                        x05y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y10":
                    if (x07y10.BackColor == Color.Transparent)
                    {
                        x07y10.BackgroundImage = entity;
                        x07y10.BackColor = entityColour;
                        x07y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y10":
                    if (x08y10.BackColor == Color.Transparent)
                    {
                        x08y10.BackgroundImage = entity;
                        x08y10.BackColor = entityColour;
                        x08y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y10":
                    if (x09y10.BackColor == Color.Transparent)
                    {
                        x09y10.BackgroundImage = entity;
                        x09y10.BackColor = entityColour;
                        x09y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y10":
                    if (x10y10.BackColor == Color.Transparent)
                    {
                        x10y10.BackgroundImage = entity;
                        x10y10.BackColor = entityColour;
                        x10y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y10":
                    if (x12y10.BackColor == Color.Transparent)
                    {
                        x12y10.BackgroundImage = entity;
                        x12y10.BackColor = entityColour;
                        x12y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y10":
                    if (x13y10.BackColor == Color.Transparent)
                    {
                        x13y10.BackgroundImage = entity;
                        x13y10.BackColor = entityColour;
                        x13y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y10":
                    if (x14y10.BackColor == Color.Transparent)
                    {
                        x14y10.BackgroundImage = entity;
                        x14y10.BackColor = entityColour;
                        x14y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y10":
                    if (x15y10.BackColor == Color.Transparent)
                    {
                        x15y10.BackgroundImage = entity;
                        x15y10.BackColor = entityColour;
                        x15y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y10":
                    if (x16y10.BackColor == Color.Transparent)
                    {
                        x16y10.BackgroundImage = entity;
                        x16y10.BackColor = entityColour;
                        x16y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y10":
                    if (x17y10.BackColor == Color.Transparent)
                    {
                        x17y10.BackgroundImage = entity;
                        x17y10.BackColor = entityColour;
                        x17y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y10":
                    if (x18y10.BackColor == Color.Transparent)
                    {
                        x18y10.BackgroundImage = entity;
                        x18y10.BackColor = entityColour;
                        x18y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y10":
                    if (x20y10.BackColor == Color.Transparent)
                    {
                        x20y10.BackgroundImage = entity;
                        x20y10.BackColor = entityColour;
                        x20y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y10":
                    if (x21y10.BackColor == Color.Transparent)
                    {
                        x21y10.BackgroundImage = entity;
                        x21y10.BackColor = entityColour;
                        x21y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y10":
                    if (x22y10.BackColor == Color.Transparent)
                    {
                        x22y10.BackgroundImage = entity;
                        x22y10.BackColor = entityColour;
                        x22y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y10":
                    if (x23y10.BackColor == Color.Transparent)
                    {
                        x23y10.BackgroundImage = entity;
                        x23y10.BackColor = entityColour;
                        x23y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y10":
                    if (x24y10.BackColor == Color.Transparent)
                    {
                        x24y10.BackgroundImage = entity;
                        x24y10.BackColor = entityColour;
                        x24y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y10":
                    if (x26y10.BackColor == Color.Transparent)
                    {
                        x26y10.BackgroundImage = entity;
                        x26y10.BackColor = entityColour;
                        x26y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y10":
                    if (x27y10.BackColor == Color.Transparent)
                    {
                        x27y10.BackgroundImage = entity;
                        x27y10.BackColor = entityColour;
                        x27y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y10":
                    if (x28y10.BackColor == Color.Transparent)
                    {
                        x28y10.BackgroundImage = entity;
                        x28y10.BackColor = entityColour;
                        x28y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y10":
                    if (x29y10.BackColor == Color.Transparent)
                    {
                        x29y10.BackgroundImage = entity;
                        x29y10.BackColor = entityColour;
                        x29y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y10":
                    if (x30y10.BackColor == Color.Transparent)
                    {
                        x30y10.BackgroundImage = entity;
                        x30y10.BackColor = entityColour;
                        x30y10.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y11":
                    if (x01y11.BackColor == Color.Transparent)
                    {
                        x01y11.BackgroundImage = entity;
                        x01y11.BackColor = entityColour;
                        x01y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y11":
                    if (x02y11.BackColor == Color.Transparent)
                    {
                        x02y11.BackgroundImage = entity;
                        x02y11.BackColor = entityColour;
                        x02y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y11":
                    if (x07y11.BackColor == Color.Transparent)
                    {
                        x07y11.BackgroundImage = entity;
                        x07y11.BackColor = entityColour;
                        x07y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y11":
                    if (x08y11.BackColor == Color.Transparent)
                    {
                        x08y11.BackgroundImage = entity;
                        x08y11.BackColor = entityColour;
                        x08y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y11":
                    if (x09y11.BackColor == Color.Transparent)
                    {
                        x09y11.BackgroundImage = entity;
                        x09y11.BackColor = entityColour;
                        x09y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y11":
                    if (x10y11.BackColor == Color.Transparent)
                    {
                        x10y11.BackgroundImage = entity;
                        x10y11.BackColor = entityColour;
                        x10y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y11":
                    if (x11y11.BackColor == Color.Transparent)
                    {
                        x11y11.BackgroundImage = entity;
                        x11y11.BackColor = entityColour;
                        x11y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y11":
                    if (x13y11.BackColor == Color.Transparent)
                    {
                        x13y11.BackgroundImage = entity;
                        x13y11.BackColor = entityColour;
                        x13y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y11":
                    if (x14y11.BackColor == Color.Transparent)
                    {
                        x14y11.BackgroundImage = entity;
                        x14y11.BackColor = entityColour;
                        x14y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y11":
                    if (x15y11.BackColor == Color.Transparent)
                    {
                        x15y11.BackgroundImage = entity;
                        x15y11.BackColor = entityColour;
                        x15y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y11":
                    if (x16y11.BackColor == Color.Transparent)
                    {
                        x16y11.BackgroundImage = entity;
                        x16y11.BackColor = entityColour;
                        x16y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y11":
                    if (x17y11.BackColor == Color.Transparent)
                    {
                        x17y11.BackgroundImage = entity;
                        x17y11.BackColor = entityColour;
                        x17y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y11":
                    if (x18y11.BackColor == Color.Transparent)
                    {
                        x18y11.BackgroundImage = entity;
                        x18y11.BackColor = entityColour;
                        x18y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y11":
                    if (x19y11.BackColor == Color.Transparent)
                    {
                        x19y11.BackgroundImage = entity;
                        x19y11.BackColor = entityColour;
                        x19y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y11":
                    if (x20y11.BackColor == Color.Transparent)
                    {
                        x20y11.BackgroundImage = entity;
                        x20y11.BackColor = entityColour;
                        x20y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y11":
                    if (x21y11.BackColor == Color.Transparent)
                    {
                        x21y11.BackgroundImage = entity;
                        x21y11.BackColor = entityColour;
                        x21y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y11":
                    if (x22y11.BackColor == Color.Transparent)
                    {
                        x22y11.BackgroundImage = entity;
                        x22y11.BackColor = entityColour;
                        x22y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y11":
                    if (x23y11.BackColor == Color.Transparent)
                    {
                        x23y11.BackgroundImage = entity;
                        x23y11.BackColor = entityColour;
                        x23y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y11":
                    if (x24y11.BackColor == Color.Transparent)
                    {
                        x24y11.BackgroundImage = entity;
                        x24y11.BackColor = entityColour;
                        x24y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y11":
                    if (x29y11.BackColor == Color.Transparent)
                    {
                        x29y11.BackgroundImage = entity;
                        x29y11.BackColor = entityColour;
                        x29y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y11":
                    if (x30y11.BackColor == Color.Transparent)
                    {
                        x30y11.BackgroundImage = entity;
                        x30y11.BackColor = entityColour;
                        x30y11.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y12":
                    if (x01y12.BackColor == Color.Transparent)
                    {
                        x01y12.BackgroundImage = entity;
                        x01y12.BackColor = entityColour;
                        x01y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y12":
                    if (x02y12.BackColor == Color.Transparent)
                    {
                        x02y12.BackgroundImage = entity;
                        x02y12.BackColor = entityColour;
                        x02y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y12":
                    if (x25y12.BackColor == Color.Transparent)
                    {
                        x03y12.BackgroundImage = entity;
                        x03y12.BackColor = entityColour;
                        x03y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y12":
                    if (x04y12.BackColor == Color.Transparent)
                    {
                        x04y12.BackgroundImage = entity;
                        x04y12.BackColor = entityColour;
                        x04y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y12":
                    if (x05y12.BackColor == Color.Transparent)
                    {
                        x05y12.BackgroundImage = entity;
                        x05y12.BackColor = entityColour;
                        x05y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y12":
                    if (x06y12.BackColor == Color.Transparent)
                    {
                        x06y12.BackgroundImage = entity;
                        x06y12.BackColor = entityColour;
                        x06y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y12":
                    if (x07y12.BackColor == Color.Transparent)
                    {
                        x07y12.BackgroundImage = entity;
                        x07y12.BackColor = entityColour;
                        x07y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y12":
                    if (x08y12.BackColor == Color.Transparent)
                    {
                        x08y12.BackgroundImage = entity;
                        x08y12.BackColor = entityColour;
                        x08y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y12":
                    if (x09y12.BackColor == Color.Transparent)
                    {
                        x09y12.BackgroundImage = entity;
                        x09y12.BackColor = entityColour;
                        x09y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y12":
                    if (x10y12.BackColor == Color.Transparent)
                    {
                        x10y12.BackgroundImage = entity;
                        x10y12.BackColor = entityColour;
                        x10y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y12":
                    if (x11y12.BackColor == Color.Transparent)
                    {
                        x11y12.BackgroundImage = entity;
                        x11y12.BackColor = entityColour;
                        x11y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y12":
                    if (x13y12.BackColor == Color.Transparent)
                    {
                        x13y12.BackgroundImage = entity;
                        x13y12.BackColor = entityColour;
                        x13y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y12":
                    if (x14y12.BackColor == Color.Transparent)
                    {
                        x14y12.BackgroundImage = entity;
                        x14y12.BackColor = entityColour;
                        x14y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y12":
                    if (x17y12.BackColor == Color.Transparent)
                    {
                        x17y12.BackgroundImage = entity;
                        x17y12.BackColor = entityColour;
                        x17y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y12":
                    if (x18y12.BackColor == Color.Transparent)
                    {
                        x18y12.BackgroundImage = entity;
                        x18y12.BackColor = entityColour;
                        x18y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y12":
                    if (x20y12.BackColor == Color.Transparent)
                    {
                        x20y12.BackgroundImage = entity;
                        x20y12.BackColor = entityColour;
                        x20y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y12":
                    if (x21y12.BackColor == Color.Transparent)
                    {
                        x21y12.BackgroundImage = entity;
                        x21y12.BackColor = entityColour;
                        x21y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y12":
                    if (x22y12.BackColor == Color.Transparent)
                    {
                        x22y12.BackgroundImage = entity;
                        x22y12.BackColor = entityColour;
                        x22y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y12":
                    if (x23y12.BackColor == Color.Transparent)
                    {
                        x23y12.BackgroundImage = entity;
                        x23y12.BackColor = entityColour;
                        x23y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y12":
                    if (x24y12.BackColor == Color.Transparent)
                    {
                        x24y12.BackgroundImage = entity;
                        x24y12.BackColor = entityColour;
                        x24y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y12":
                    if (x25y12.BackColor == Color.Transparent)
                    {
                        x25y12.BackgroundImage = entity;
                        x25y12.BackColor = entityColour;
                        x25y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y12":
                    if (x26y12.BackColor == Color.Transparent)
                    {
                        x26y12.BackgroundImage = entity;
                        x26y12.BackColor = entityColour;
                        x26y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y12":
                    if (x27y12.BackColor == Color.Transparent)
                    {
                        x27y12.BackgroundImage = entity;
                        x27y12.BackColor = entityColour;
                        x27y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y12":
                    if (x29y12.BackColor == Color.Transparent)
                    {
                        x29y12.BackgroundImage = entity;
                        x29y12.BackColor = entityColour;
                        x29y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y12":
                    if (x30y12.BackColor == Color.Transparent)
                    {
                        x30y12.BackgroundImage = entity;
                        x30y12.BackColor = entityColour;
                        x30y12.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x00y13":
                    if(x00y13.BackColor==Color.Transparent)
                    {
                        x00y13.BackgroundImage = entity;
                        x00y13.BackColor = entityColour;
                        x00y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y13":
                    if(x01y13.BackColor==Color.Transparent)
                    {
                        x01y13.BackgroundImage = entity;
                        x01y13.BackColor = entityColour;
                        x01y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y13":
                    if(x02y13.BackColor==Color.Transparent)
                    {
                        x02y13.BackgroundImage = entity;
                        x02y13.BackColor = entityColour;
                        x02y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y13":
                    if (x04y13.BackColor == Color.Transparent)
                    {
                        x04y13.BackgroundImage = entity;
                        x04y13.BackColor = entityColour;
                        x04y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y13":
                    if (x05y13.BackColor == Color.Transparent)
                    {
                        x05y13.BackgroundImage = entity;
                        x05y13.BackColor = entityColour;
                        x05y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y13":
                    if (x06y13.BackColor == Color.Transparent)
                    {
                        x05y13.BackgroundImage = entity;
                        x05y13.BackColor = entityColour;
                        x05y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y13":
                    if (x07y13.BackColor == Color.Transparent)
                    {
                        x07y13.BackgroundImage = entity;
                        x07y13.BackColor = entityColour;
                        x07y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y13":
                    if (x08y13.BackColor == Color.Transparent)
                    {
                        x08y13.BackgroundImage = entity;
                        x08y13.BackColor = entityColour;
                        x08y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y13":
                    if(x10y13.BackColor==Color.Transparent)
                    {
                        x10y13.BackgroundImage = entity;
                        x10y13.BackColor = entityColour;
                        x10y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y13":
                    if(x11y13.BackColor==Color.Transparent)
                    {
                        x11y13.BackgroundImage = entity;
                        x11y13.BackColor = entityColour;
                        x11y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y13":
                    if(x12y13.BackColor == Color.Transparent)
                    {
                        x12y13.BackgroundImage = entity;
                        x12y13.BackColor = entityColour;
                        x12y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y13":
                    if(x13y13.BackColor==Color.Transparent)
                    {
                        x13y13.BackgroundImage = entity;
                        x13y13.BackColor = entityColour;
                        x13y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y13":
                    if(x14y13.BackColor==Color.Transparent)
                    {
                        x14y13.BackgroundImage = entity;
                        x14y13.BackColor = entityColour;
                        x14y13.BackgroundImageLayout = entityLayout;
                    }                    
                    break;
                case "x15y13":
                    if(x15y13.BackColor==Color.Transparent)
                    {
                        x15y13.BackgroundImage = entity;
                        x15y13.BackColor = entityColour;
                        x15y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y13":
                    if(x16y13.BackColor==Color.Transparent)
                    {
                        x16y13.BackgroundImage = entity;
                        x16y13.BackColor = entityColour;
                        x16y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y13":
                    if(x17y13.BackColor==Color.Transparent)
                    {
                        x17y13.BackgroundImage = entity;
                        x17y13.BackColor = entityColour;
                        x17y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y13":
                    if(x18y13.BackColor==Color.Transparent)
                    {
                        x18y13.BackgroundImage = entity;
                        x18y13.BackColor = entityColour;
                        x18y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y13":
                    if(x19y13.BackColor==Color.Transparent)
                    {
                        x19y13.BackgroundImage = entity;
                        x19y13.BackColor = entityColour;
                        x19y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y13":
                    if(x20y13.BackColor==Color.Transparent)
                    {
                        x20y13.BackgroundImage = entity;
                        x20y13.BackColor = entityColour;
                        x20y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y13":
                    if(x21y13.BackColor==Color.Transparent)
                    {
                        x21y13.BackgroundImage = entity;
                        x21y13.BackColor = entityColour;
                        x21y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y13":
                    if (x23y13.BackColor == Color.Transparent)
                    {
                        x23y13.BackgroundImage = entity;
                        x23y13.BackColor = entityColour;
                        x23y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y13":
                    if (x24y13.BackColor == Color.Transparent)
                    {
                        x24y13.BackgroundImage = entity;
                        x24y13.BackColor = entityColour;
                        x24y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y13":
                    if(x25y13.BackColor==Color.Transparent)
                    {
                        x25y13.BackgroundImage = entity;
                        x25y13.BackColor = entityColour;
                        x25y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y13":
                    if(x26y13.BackColor==Color.Transparent)
                    {
                        x26y13.BackgroundImage = entity;
                        x26y13.BackColor = entityColour;
                        x26y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y13":
                    if(x27y13.BackColor==Color.Transparent)
                    {
                        x27y13.BackgroundImage = entity;
                        x27y13.BackColor = entityColour;
                        x27y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y13":
                    if(x29y13.BackColor == Color.Transparent)
                    {
                        x29y13.BackgroundImage = entity;
                        x29y13.BackColor = entityColour;
                        x29y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y13":
                    if(x30y13.BackColor==Color.Transparent)
                    {
                        x30y13.BackgroundImage = entity;
                        x30y13.BackColor = entityColour;
                        x30y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x31y13":
                    if(x31y13.BackColor==Color.Transparent)
                    {
                        x31y13.BackgroundImage = entity;
                        x31y13.BackColor = entityColour;
                        x31y13.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x00y14":
                    if(x00y14.BackColor==Color.Transparent)
                    {
                        x00y14.BackgroundImage = entity;
                        x00y14.BackColor = entityColour;
                        x00y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y14":
                    if(x01y14.BackColor==Color.Transparent)
                    {
                        x01y14.BackgroundImage = entity;
                        x01y14.BackColor = entityColour;
                        x01y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y14":
                    if(x02y14.BackColor==Color.Transparent)
                    {
                        x02y14.BackgroundImage = entity;
                        x02y14.BackColor = entityColour;
                        x02y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y14":
                    if(x04y14.BackColor==Color.Transparent)
                    {
                        x04y14.BackgroundImage = entity;
                        x04y14.BackColor = entityColour;
                        x04y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y14":
                    if(x05y14.BackColor==Color.Transparent)
                    {
                        x05y14.BackgroundImage = entity;
                        x05y14.BackColor = entityColour;
                        x05y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y14":
                    if(x06y14.BackColor == Color.Transparent)
                    {
                        x06y14.BackgroundImage = entity;
                        x06y14.BackColor = entityColour;
                        x06y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y14":
                    if(x10y14.BackColor == Color.Transparent)
                    {
                        x10y14.BackgroundImage = entity;
                        x10y14.BackColor = entityColour;
                        x10y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y14":
                    if(x11y14.BackColor == Color.Transparent)
                    {
                        x11y14.BackgroundImage = entity;
                        x11y14.BackColor = entityColour;
                        x11y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y14":
                    if(x12y14.BackColor == Color.Transparent)
                    {
                        x12y14.BackgroundImage = entity;
                        x12y14.BackColor = entityColour;
                        x12y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y14":
                    if(x13y14.BackColor==Color.Transparent)
                    {
                                x13y14.BackgroundImage = entity;
                        x13y14.BackColor = entityColour;
                        x13y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y14":
                    if(x14y14.BackgroundImage==null)
                    {
                        x14y14.BackgroundImage = entity;
                        x14y14.BackColor = entityColour;
                        x14y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y14":
                    if(x15y14.BackgroundImage==null)
                    {
                        x15y14.BackgroundImage = entity;
                        x15y14.BackColor = entityColour;
                        x15y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y14":
                    if(x16y14.BackgroundImage==null)
                    {
                        x16y14.BackgroundImage = entity;
                        x16y14.BackColor = entityColour;
                        x16y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y14":
                    if(x17y14.BackgroundImage==null)
                    {
                        x17y14.BackgroundImage = entity;
                        x17y14.BackColor = entityColour;
                        x17y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y14":
                    if(x18y14.BackColor==Color.Transparent)
                    {
                        x18y14.BackgroundImage = entity;
                        x18y14.BackColor = entityColour;
                        x18y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y14":
                    if(x19y14.BackColor==Color.Transparent)
                    {
                        x19y14.BackgroundImage = entity;
                        x19y14.BackColor = entityColour;
                        x19y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y14":
                    if(x20y14.BackColor==Color.Transparent)
                    {
                        x20y14.BackgroundImage = entity;
                        x20y14.BackColor = entityColour;
                        x20y14.BackgroundImageLayout = entityLayout;
                    }                 
                    break;
                case "x21y14":
                    if(x21y14.BackColor==Color.Transparent)
                    {
                        x21y14.BackgroundImage = entity;
                        x21y14.BackColor = entityColour;
                        x21y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y14":
                    if(x24y14.BackColor==Color.Transparent)
                    {
                        x25y14.BackgroundImage = entity;
                        x25y14.BackColor = entityColour;
                        x25y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y14":
                    if(x26y14.BackColor==Color.Transparent)
                    {
                        x26y14.BackgroundImage = entity;
                        x26y14.BackColor = entityColour;
                        x26y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y14":
                    if(x27y14.BackColor==Color.Transparent)
                    {
                        x27y14.BackgroundImage = entity;
                        x27y14.BackColor = entityColour;
                        x27y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y14":
                    if(x29y14.BackColor==Color.Transparent)
                    {
                        x29y14.BackgroundImage = entity;
                        x29y14.BackColor = entityColour;
                        x29y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y14":  
                    if(x30y14.BackColor==Color.Transparent)
                    {
                        x30y14.BackgroundImage = entity;
                        x30y14.BackColor = entityColour;
                        x30y14.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x31y14":
                    if(x31y14.BackColor==Color.Transparent)
                    {
                        x31y14.BackgroundImage = entity;
                        x31y14.BackColor = entityColour;
                        x31y14.BackgroundImageLayout = entityLayout;
                    } 
                    break;
                case "x01y15":
                    if(x01y15.BackColor==Color.Transparent)
                    {
                        x01y15.BackgroundImage = entity;
                        x01y15.BackColor = entityColour;
                        x01y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y15":
                    if(x02y15.BackColor==Color.Transparent)
                    {
                        x02y15.BackgroundImage = entity;
                        x02y15.BackColor = entityColour;
                        x02y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y15":
                    if(x03y15.BackColor==Color.Transparent)
                    {
                        x03y15.BackgroundImage = entity;
                        x03y15.BackColor = entityColour;
                        x03y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y15":
                    if(x04y15.BackColor==Color.Transparent)
                    {
                        x04y15.BackgroundImage = entity;
                        x04y15.BackColor = entityColour;
                        x04y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y15":
                    if(x05y15.BackColor==Color.Transparent)
                    {
                        x05y15.BackgroundImage = entity;
                        x05y15.BackColor = entityColour;
                        x05y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y15":
                    if(x06y15.BackColor==Color.Transparent)
                    {
                        x06y15.BackgroundImage = entity;
                        x06y15.BackColor = entityColour;
                        x06y15.BackgroundImageLayout = entityLayout;
                    }                 
                    break;
                case "x07y15":
                    if(x07y15.BackColor==Color.Transparent)
                    {
                        x07y15.BackgroundImage = entity;
                        x07y15.BackColor = entityColour;
                        x07y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y15":
                    if(x08y15.BackColor==Color.Transparent)
                    {
                        x08y15.BackgroundImage = entity;
                        x08y15.BackColor = entityColour;
                        x08y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y15":
                    if(x09y15.BackColor==Color.Transparent)
                    {
                        x09y15.BackgroundImage = entity;
                        x09y15.BackColor = entityColour;
                        x09y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y15":
                    if(x10y15.BackColor==Color.Transparent)
                    {
                        x10y15.BackgroundImage = entity;
                        x10y15.BackColor = entityColour;
                        x10y15.BackgroundImageLayout = entityLayout; 
                    }
                    break;
                case "x11y15":
                    if(x11y15.BackColor==Color.Transparent)
                    {
                        x11y15.BackgroundImage = entity;
                        x11y15.BackColor = entityColour;
                        x11y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y15":
                    if(x13y15.BackColor==Color.Transparent)
                    {
                        x13y15.BackgroundImage = entity;
                        x13y15.BackColor = entityColour;
                        x13y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y15":
                    if(x14y15.BackgroundImage==null)
                    {
                        x14y15.BackgroundImage = entity;
                        x14y15.BackColor = entityColour;
                        x14y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y15":
                    if(x17y15.BackgroundImage==null)
                    {
                        x17y15.BackgroundImage = entity;
                        x17y15.BackColor = entityColour;
                        x17y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y15":
                    if(x18y15.BackColor == Color.Transparent)
                    {
                        x18y15.BackgroundImage = entity;
                        x18y15.BackColor = entityColour;
                        x18y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y15":
                    if(x20y15.BackColor==Color.Transparent)
                    {
                        x20y15.BackgroundImage = entity;
                        x20y15.BackColor = entityColour;
                        x20y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y15":
                    if(x21y15.BackColor==Color.Transparent)
                    {
                        x21y15.BackgroundImage = entity;
                        x21y15.BackColor = entityColour;
                        x21y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y15":
                    if(x22y15.BackColor==Color.Transparent)
                    {
                        x22y15.BackgroundImage = entity;
                        x22y15.BackColor = entityColour;
                        x22y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y15":
                    if(x23y15.BackColor==Color.Transparent)
                    {
                        x23y15.BackgroundImage = entity;
                        x23y15.BackColor = entityColour;
                        x23y15.BackgroundImageLayout = entityLayout;
                    }                                    
                    break;
                case "x24y15":
                    if(x24y15.BackColor==Color.Transparent)
                    {
                        x24y15.BackgroundImage = entity;
                        x24y15.BackColor = entityColour;
                        x24y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y15":
                    if(x25y15.BackColor == Color.Transparent)
                    {
                        x25y15.BackgroundImage = entity;
                        x25y15.BackColor = entityColour;
                        x25y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y15":
                    if(x26y15.BackColor==Color.Transparent)
                    {
                        x26y15.BackgroundImage = entity;
                        x26y15.BackColor = entityColour;
                        x26y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y15":
                    if(x27y15.BackColor == Color.Transparent)
                    {
                        x27y15.BackgroundImage = entity;
                        x27y15.BackColor = entityColour;
                        x27y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y15":
                    if(x28y15.BackColor==Color.Transparent)
                    {
                        x28y15.BackgroundImage = entity;
                        x28y15.BackColor = entityColour;
                        x28y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y15":
                    if(x29y15.BackColor==Color.Transparent)
                    {
                        x29y15.BackgroundImage = entity;
                        x29y15.BackColor = entityColour;
                        x29y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y15":
                    if(x30y15.BackColor==Color.Transparent)
                    {
                        x30y15.BackgroundImage = entity;
                        x30y15.BackColor = entityColour;
                        x30y15.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y16":
                    if(x01y16.BackColor==Color.Transparent)
                    {
                        x01y16.BackgroundImage = entity;
                        x01y16.BackColor = entityColour;
                        x01y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y16":
                    if(x02y16.BackColor==Color.Transparent)
                    {
                        x02y16.BackgroundImage = entity;
                        x02y16.BackColor = entityColour;
                        x02y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y16":
                    if(x03y16.BackColor==Color.Transparent)
                    {
                        x03y16.BackgroundImage = entity;
                        x03y16.BackColor = entityColour;
                        x03y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y16":
                    if(x04y16.BackColor==Color.Transparent)
                    {
                        x04y16.BackgroundImage = entity;
                        x04y16.BackColor = entityColour;
                        x04y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y16":
                    if(x05y16.BackColor==Color.Transparent)
                    {
                        x05y16.BackgroundImage = entity;
                        x05y16.BackColor = entityColour;
                        x05y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y16":
                    if(x06y16.BackColor==Color.Transparent)
                    {
                        x06y16.BackgroundImage = entity;
                        x06y16.BackColor = entityColour;
                        x06y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y16":
                    if(x07y16.BackColor==Color.Transparent)
                    {
                        x07y16.BackgroundImage = entity;
                        x07y16.BackColor = entityColour;
                        x07y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y16":
                    if(x08y16.BackColor==Color.Transparent)
                    {
                        x08y16.BackgroundImage = entity;
                        x08y16.BackColor = entityColour;
                        x08y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y16":
                    if(x09y16.BackColor==Color.Transparent)
                    {
                        x09y16.BackgroundImage = entity;
                        x09y16.BackColor = entityColour;
                        x09y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y16":
                    if(x10y16.BackColor==Color.Transparent)
                    {
                        x10y16.BackgroundImage = entity;
                        x10y16.BackColor = entityColour;
                        x10y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y16":
                    if(x11y16.BackColor == Color.Transparent)
                    {
                        x11y16.BackgroundImage = entity;
                        x11y16.BackColor = entityColour;
                        x11y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y16":
                    if(x13y16.BackColor==Color.Transparent)
                    {
                        x13y16.BackgroundImage = entity;
                        x13y16.BackColor = entityColour;
                        x13y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y16":
                    if(x14y16.BackgroundImage==null)
                    {
                        x14y16.BackgroundImage = entity;
                        x14y16.BackColor = entityColour;
                        x14y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y16":
                    if(x17y16.BackgroundImage==null)
                    {
                        x17y16.BackgroundImage = entity;
                        x17y16.BackColor = entityColour;
                        x17y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y16":
                    if(x18y16.BackColor==Color.Transparent)
                    {
                        x18y16.BackgroundImage = entity;
                        x18y16.BackColor = entityColour;
                        x18y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y16":
                    if(x20y16.BackColor==Color.Transparent)
                    {
                        x20y16.BackgroundImage = entity;
                        x20y16.BackColor = entityColour;
                        x20y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y16":
                    if(x21y16.BackColor==Color.Transparent)
                    {
                        x21y16.BackgroundImage = entity;
                        x21y16.BackColor = entityColour;
                        x21y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y16":
                    if(x22y16.BackColor==Color.Transparent)
                    {
                        x22y16.BackgroundImage = entity;
                        x22y16.BackColor = entityColour;
                        x22y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y16":
                    if(x23y16.BackColor == Color.Transparent)
                    {
                        x23y16.BackgroundImage = entity;
                        x23y16.BackColor = entityColour;
                        x23y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y16":
                    if(x24y16.BackColor == Color.Transparent)
                    {
                        x24y16.BackgroundImage = entity;
                        x24y16.BackColor = entityColour;
                        x24y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y16":
                    if(x25y16.BackColor==Color.Transparent)
                    {
                        x25y16.BackgroundImage = entity;
                        x25y16.BackColor = entityColour;
                        x25y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y16":
                    if(x26y16.BackColor==Color.Transparent)
                    {
                        x26y16.BackgroundImage = entity;
                        x26y16.BackColor = entityColour;
                        x26y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y16":
                    if(x27y16.BackColor==Color.Transparent)
                    {
                        x27y16.BackgroundImage = entity;
                        x27y16.BackColor = entityColour;
                        x27y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y16":
                    if(x28y16.BackColor == Color.Transparent)
                    {
                        x28y16.BackgroundImage = entity;
                        x28y16.BackColor = entityColour;
                        x28y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y16":
                    if(x29y16.BackColor==Color.Transparent)
                    {
                        x29y16.BackgroundImage = entity;
                        x29y16.BackColor = entityColour;
                        x29y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y16":
                    if(x30y16.BackColor==Color.Transparent)
                    {
                        x30y16.BackgroundImage = entity;
                        x30y16.BackColor = entityColour;
                        x30y16.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x00y17":
                    if(x00y17.BackColor==Color.Transparent)
                    {
                        x00y17.BackgroundImage = entity;
                        x00y17.BackColor = entityColour;
                        x00y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y17":
                    if(x01y17.BackColor==Color.Transparent)
                    {
                        x01y17.BackgroundImage = entity;
                        x01y17.BackColor = entityColour;
                        x01y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y17":
                    if(x02y17.BackColor==Color.Transparent)
                    {
                        x02y17.BackgroundImage = entity;
                        x02y17.BackColor = entityColour;
                        x02y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y17":
                    if(x04y17.BackColor==Color.Transparent)
                    {
                        x04y17.BackgroundImage = entity;
                        x04y17.BackColor = entityColour;
                        x04y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y17":
                    if(x05y17.BackColor==Color.Transparent)
                    {
                        x05y17.BackgroundImage = entity;
                        x05y17.BackColor = entityColour;
                        x05y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y17":
                    if(x06y17.BackColor==Color.Transparent)
                    {
                        x06y17.BackgroundImage = entity;
                        x06y17.BackColor = entityColour;
                        x06y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y17":
                    if(x10y17.BackColor==Color.Transparent)
                    {
                        x10y17.BackgroundImage = entity;
                        x10y17.BackColor = entityColour;
                        x10y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y17":
                    if(x11y17.BackColor==Color.Transparent)
                    {
                        x11y17.BackgroundImage = entity;
                        x11y17.BackColor = entityColour;
                        x11y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y17":
                    if(x12y17.BackColor==Color.Transparent)
                    {
                        x12y17.BackgroundImage = entity;
                        x12y17.BackColor = entityColour;
                        x12y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y17":
                    if(x13y17.BackColor==Color.Transparent)
                    {
                        x13y17.BackgroundImage = entity;
                        x13y17.BackColor = entityColour;
                        x13y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y17":
                    if(x14y17.BackgroundImage==null)
                    {
                        x14y17.BackgroundImage = entity;
                        x14y17.BackColor = entityColour;
                        x14y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y17":
                    if(x15y17.BackgroundImage==null)
                    {
                        x15y17.BackgroundImage = entity;
                        x15y17.BackColor = entityColour;
                        x15y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y17":
                    if(x16y17.BackgroundImage==null)
                    {
                        x16y17.BackgroundImage = entity;
                        x16y17.BackColor = entityColour;
                        x16y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y17":
                    if(x17y17.BackgroundImage==null)
                    {
                        x17y17.BackgroundImage = entity;
                        x17y17.BackColor = entityColour;
                        x17y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y17":
                    if(x18y17.BackColor==Color.Transparent)
                    {
                        x18y17.BackgroundImage = entity;
                        x18y17.BackColor = entityColour;
                        x18y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y17":
                    if(x19y17.BackColor == Color.Transparent)
                    {
                        x19y17.BackgroundImage = entity;
                        x19y17.BackColor = entityColour;
                        x19y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y17":
                    if(x20y17.BackColor==Color.Transparent)
                    {
                        x20y17.BackgroundImage = entity;
                        x20y17.BackColor = entityColour;
                        x20y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y17":
                    if(x21y18.BackColor==Color.Transparent)
                    {
                        x21y17.BackgroundImage = entity;
                        x21y17.BackColor = entityColour;
                        x21y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y17":
                    if(x25y17.BackColor==Color.Transparent)
                    {
                        x25y17.BackgroundImage = entity;
                        x25y17.BackColor = entityColour;
                        x25y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y17":
                    if(x26y17.BackColor == Color.Transparent)
                    {
                        x26y17.BackgroundImage = entity;
                        x26y17.BackColor = entityColour;
                        x26y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y17":
                    if(x27y17.BackColor==Color.Transparent)
                    {
                        x27y17.BackgroundImage = entity;
                        x27y17.BackColor = entityColour;
                        x27y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y17":
                    if(x29y17.BackColor==Color.Transparent)
                    {
                        x29y17.BackgroundImage = entity;
                        x29y17.BackColor = entityColour;
                        x29y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y17":
                    if(x30y17.BackColor==Color.Transparent)
                    {
                        x30y17.BackgroundImage = entity;
                        x30y17.BackColor = entityColour;
                        x30y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x31y17":
                    if(x31y17.BackColor==Color.Transparent)
                    {
                        x31y17.BackgroundImage = entity;
                        x31y17.BackColor = entityColour;
                        x31y17.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x00y18":
                    if(x00y18.BackColor==Color.Transparent)
                    {
                        x00y18.BackgroundImage = entity;
                        x00y18.BackColor = entityColour;
                        x00y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y18":
                    if(x01y18.BackColor==Color.Transparent)
                    {
                        x01y18.BackgroundImage = entity;
                        x01y18.BackColor = entityColour;
                        x01y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y18":
                    if(x02y18.BackColor==Color.Transparent)
                    {
                        x02y18.BackgroundImage = entity;
                        x02y18.BackColor = entityColour;
                        x02y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y18":
                    if(x04y18.BackColor==Color.Transparent)
                    {
                        x04y18.BackgroundImage = entity;
                        x04y18.BackColor = entityColour;
                        x04y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y18":
                    if(x05y18.BackColor==Color.Transparent)
                    {
                        x05y18.BackgroundImage = entity;
                        x05y18.BackColor = entityColour;
                        x05y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y18":
                    if(x06y18.BackColor==Color.Transparent)
                    {
                        x06y18.BackgroundImage = entity;
                        x06y18.BackColor = entityColour;
                        x06y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y18":
                    if(x07y18.BackColor==Color.Transparent)
                    {
                        x07y18.BackgroundImage = entity;
                        x07y18.BackColor = entityColour;
                        x07y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y18":
                    if(x08y18.BackColor==Color.Transparent)
                    {
                        x08y18.BackgroundImage = entity;
                        x08y18.BackColor = entityColour;
                        x08y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y18":
                    if(x10y18.BackColor==Color.Transparent)
                    {
                        x10y18.BackgroundImage = entity;
                        x10y18.BackColor = entityColour;
                        x10y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y18":
                    if(x11y18.BackColor==Color.Transparent)
                    {
                        x11y18.BackgroundImage = entity;
                        x11y18.BackColor = entityColour;
                        x11y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y18":
                    if(x12y18.BackColor==Color.Transparent)
                    {
                        x12y18.BackgroundImage = entity;
                        x12y18.BackColor = entityColour;
                        x12y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y18":
                    if(x13y18.BackColor==Color.Transparent)
                    {
                        x13y18.BackgroundImage = entity;
                        x13y18.BackColor = entityColour;
                        x13y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y18":
                    if(x14y18.BackColor==Color.Transparent)
                    {
                        x14y18.BackgroundImage = entity;
                        x14y18.BackColor = entityColour;
                        x14y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y18":
                    if(x15y18.BackColor==Color.Transparent)
                    {
                        x15y18.BackgroundImage = entity;
                        x15y18.BackColor = entityColour;
                        x15y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y18":
                    if(x16y18.BackColor==Color.Transparent)
                    {
                        x16y18.BackgroundImage = entity;
                        x16y18.BackColor = entityColour;
                        x16y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y18":
                    if(x17y18.BackColor==Color.Transparent)
                    {
                        x17y18.BackgroundImage = entity;
                        x17y18.BackColor = entityColour;
                        x17y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y18":
                    if(x18y18.BackColor==Color.Transparent)
                    {
                        x18y18.BackgroundImage = entity;
                        x18y18.BackColor = entityColour;
                        x18y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y18":
                    if(x19y18.BackColor==Color.Transparent)
                    {
                        x19y18.BackgroundImage = entity;
                        x19y18.BackColor = entityColour;
                        x19y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y18":
                    if(x20y18.BackColor == Color.Transparent)
                    {
                        x20y18.BackgroundImage = entity;
                        x20y18.BackColor = entityColour;
                        x20y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y18":
                    if(x21y18.BackColor==Color.Transparent)
                    {
                        x21y18.BackgroundImage = entity;
                        x21y18.BackColor = entityColour;
                        x21y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y18":
                    if(x23y18.BackColor==Color.Transparent)
                    {
                        x23y18.BackgroundImage = entity;
                        x23y18.BackColor = entityColour;
                        x23y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y18":
                    if(x24y18.BackColor==Color.Transparent)
                    {
                        x24y18.BackgroundImage = entity;
                        x24y18.BackColor = entityColour;
                        x24y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y18":
                    if(x25y18.BackColor==Color.Transparent)
                    {
                        x25y18.BackgroundImage = entity;
                        x25y18.BackColor = entityColour;
                        x25y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y18":
                    if(x26y18.BackColor==Color.Transparent)
                    {
                        x26y18.BackgroundImage = entity;
                        x26y18.BackColor = entityColour;
                        x26y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y18":
                    if(x27y18.BackColor==Color.Transparent)
                    {
                        x27y18.BackgroundImage = entity;
                        x27y18.BackColor = entityColour;
                        x27y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y18":
                    if(x29y18.BackColor==Color.Transparent)
                    {
                        x29y18.BackgroundImage = entity;
                        x29y18.BackColor = entityColour;
                        x29y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y18":
                    if(x30y18.BackColor == Color.Transparent)
                    {
                        x30y18.BackgroundImage = entity;
                        x30y18.BackColor = entityColour;
                        x30y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x31y18":
                    if (x31y18.BackColor == Color.Transparent)
                    {
                        x31y18.BackgroundImage = entity;
                        x31y18.BackColor = entityColour;
                        x31y18.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y19":
                    if(x01y19.BackColor==Color.Transparent)
                    {
                        x01y19.BackgroundImage = entity;
                        x01y19.BackColor = entityColour;
                        x01y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y19":
                    if(x02y19.BackColor==Color.Transparent)
                    {
                        x02y19.BackgroundImage = entity;
                        x02y19.BackColor = entityColour;
                        x02y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y19":
                    if(x04y19.BackColor==Color.Transparent)
                    {
                        x04y19.BackgroundImage = entity;
                        x04y19.BackColor = entityColour;
                        x04y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y19":
                    if(x05y19.BackColor==Color.Transparent)
                    {
                        x05y19.BackgroundImage = entity;
                        x05y19.BackColor = entityColour;
                        x05y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y19":
                    if(x06y19.BackColor==Color.Transparent)
                    {
                        x06y19.BackgroundImage = entity;
                        x06y19.BackColor = entityColour;
                        x06y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y19":
                    if(x07y19.BackColor==Color.Transparent)
                    {
                        x07y19.BackgroundImage = entity;
                        x07y19.BackColor = entityColour;
                        x07y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y19":
                    if(x08y19.BackColor==Color.Transparent)
                    {
                        x08y19.BackgroundImage = entity;
                        x08y19.BackColor = entityColour;
                        x08y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y19":
                    if(x09y19.BackColor==Color.Transparent)
                    {
                        x09y19.BackgroundImage = entity;
                        x09y19.BackColor = entityColour;
                        x09y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y19":
                    if(x10y19.BackColor==Color.Transparent)
                    {
                        x10y19.BackgroundImage = entity;
                        x10y19.BackColor = entityColour;
                        x10y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y19":
                    if(x11y19.BackColor==Color.Transparent)
                    {
                        x11y19.BackgroundImage = entity;
                        x11y19.BackColor = entityColour;
                        x11y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y19":
                    if(x13y19.BackColor==Color.Transparent)
                    {
                        x13y19.BackgroundImage = entity;
                        x13y19.BackColor = entityColour;
                        x13y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y19":
                    if(x14y19.BackColor==Color.Transparent)
                    {
                        x14y19.BackgroundImage = entity;
                        x14y19.BackColor = entityColour;
                        x14y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y19":
                    if(x17y19.BackColor==Color.Transparent)
                    {
                        x17y19.BackgroundImage = entity;
                        x17y19.BackColor = entityColour;
                        x17y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y19":
                    if(x18y19.BackColor==Color.Transparent)
                    {
                        x18y19.BackgroundImage = entity;
                        x18y19.BackColor = entityColour;
                        x18y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y19":
                    if(x20y19.BackColor == Color.Transparent)
                    {
                        x20y19.BackgroundImage = entity;
                        x20y19.BackColor = entityColour;
                        x20y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y19":
                    if(x21y19.BackColor==Color.Transparent)
                    {
                        x21y19.BackgroundImage = entity;
                        x21y19.BackColor = entityColour;
                        x21y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y19":
                    if(x22y19.BackColor==Color.Transparent)
                    {
                        x22y19.BackgroundImage = entity;
                        x22y19.BackColor = entityColour;
                        x22y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y19":
                    if(x23y19.BackColor == Color.Transparent)
                    {
                        x23y19.BackgroundImage = entity;
                        x23y19.BackColor = entityColour;
                        x23y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y19":
                    if(x24y19.BackColor==Color.Transparent)
                    {
                        x24y19.BackgroundImage = entity;
                        x24y19.BackColor = entityColour;
                        x24y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y19":
                    if(x25y19.BackColor==Color.Transparent)
                    {
                        x25y19.BackgroundImage = entity;
                        x25y19.BackColor = entityColour;
                        x25y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y19":
                    if(x26y19.BackColor==Color.Transparent)
                    {
                        x26y19.BackgroundImage = entity;
                        x26y19.BackColor = entityColour;
                        x26y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y19":
                    if(x27y19.BackColor==Color.Transparent)
                    {
                        x27y19.BackgroundImage = entity;
                        x27y19.BackColor = entityColour;
                        x27y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y19":
                    if(x29y19.BackColor==Color.Transparent)
                    {
                        x29y19.BackgroundImage = entity;
                        x29y19.BackColor = entityColour;
                        x29y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y19":
                    if(x30y19.BackColor==Color.Transparent)
                    {
                        x30y19.BackgroundImage = entity;
                        x30y19.BackColor = entityColour;
                        x30y19.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y20":
                    if(x01y20.BackColor==Color.Transparent)
                    {
                        x01y20.BackgroundImage = entity;
                        x01y20.BackColor = entityColour;
                        x01y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y20":
                    if(x02y20.BackColor==Color.Transparent)
                    {
                        x02y20.BackgroundImage = entity;
                        x02y20.BackColor = entityColour;
                        x02y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y20":
                    if(x07y20.BackColor==Color.Transparent)
                    {
                        x07y20.BackgroundImage = entity;
                        x07y20.BackColor = entityColour;
                        x07y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y20":
                    if(x08y20.BackColor==Color.Transparent)
                    {
                        x08y20.BackgroundImage = entity;
                        x08y20.BackColor = entityColour;
                        x08y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y20":
                    if(x09y21.BackColor == Color.Transparent)
                    {
                        x09y20.BackgroundImage = entity;
                        x09y20.BackColor = entityColour;
                        x09y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y20":
                    if(x10y20.BackColor==Color.Transparent)
                    {
                        x10y20.BackgroundImage = entity;
                        x10y20.BackColor = entityColour;
                        x10y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y20":
                    if(x11y20.BackColor==Color.Transparent)
                    {
                        x11y20.BackgroundImage = entity;
                        x11y20.BackColor = entityColour;
                        x11y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y20":
                    if(x13y20.BackColor==Color.Transparent)
                    {
                        x13y20.BackgroundImage = entity;
                        x13y20.BackColor = entityColour;
                        x13y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y20":
                    if(x14y20.BackColor==Color.Transparent)
                    {
                        x14y20.BackgroundImage = entity;
                        x14y20.BackColor = entityColour;
                        x14y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y20":
                    if(x15y20.BackColor==Color.Transparent)
                    {
                        x15y20.BackgroundImage = entity;
                        x15y20.BackColor = entityColour;
                        x15y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y20":
                    if(x16y20.BackColor==Color.Transparent)
                    {
                        x16y20.BackgroundImage = entity;
                        x16y20.BackColor = entityColour;
                        x16y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y20":
                    if(x17y20.BackColor==Color.Transparent)
                    {
                        x17y20.BackgroundImage = entity;
                        x17y20.BackColor = entityColour;
                        x17y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y20":
                    if(x18y20.BackColor==Color.Transparent)
                    {
                        x18y20.BackgroundImage = entity;
                        x18y20.BackColor = entityColour;
                        x18y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y20":
                    if(x20y20.BackColor==Color.Transparent)
                    {
                        x20y20.BackgroundImage = entity;
                        x20y20.BackColor = entityColour;
                        x20y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y20":
                    if(x21y20.BackColor == Color.Transparent)
                    {
                        x21y20.BackgroundImage = entity;
                        x21y20.BackColor = entityColour;
                        x21y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y20":
                    if(x22y20.BackColor==Color.Transparent)
                    {
                        x22y20.BackgroundImage = entity;
                        x22y20.BackColor = entityColour;
                        x22y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y20":
                    if(x23y20.BackColor==Color.Transparent)
                    {
                        x23y20.BackgroundImage = entity;
                        x23y20.BackColor = entityColour;
                        x23y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y20":
                    if(x24y20.BackColor==Color.Transparent)
                    {
                        x24y20.BackgroundImage = entity;
                        x24y20.BackColor = entityColour;
                        x24y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y20":
                    if(x29y20.BackColor==Color.Transparent)
                    {
                        x29y20.BackgroundImage = entity;
                        x29y20.BackColor = entityColour;
                        x29y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y20":
                    if(x30y20.BackColor==Color.Transparent)
                    {
                        x30y20.BackgroundImage = entity;
                        x30y20.BackColor = entityColour;
                        x30y20.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y21":
                    if(x01y21.BackColor==Color.Transparent)
                    {
                        x01y21.BackgroundImage = entity;
                        x01y21.BackColor = entityColour;
                        x01y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y21":
                    if(x02y21.BackColor==Color.Transparent)
                    {
                        x02y21.BackgroundImage = entity;
                        x02y21.BackColor = entityColour;
                        x02y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y21":
                    if(x03y21.BackColor==Color.Transparent)
                    {
                        x03y21.BackgroundImage = entity;
                        x03y21.BackColor = entityColour;
                        x03y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y21":
                    if(x04y21.BackColor==Color.Transparent)
                    {
                        x04y21.BackgroundImage = entity;
                        x04y21.BackColor = entityColour;
                        x04y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y21":
                    if(x05y21.BackColor==Color.Transparent)
                    {
                        x05y21.BackgroundImage = entity;
                        x05y21.BackColor = entityColour;
                        x05y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y21":
                    if(x07y21.BackColor==Color.Transparent)
                    {
                        x07y21.BackgroundImage = entity;
                        x07y21.BackColor = entityColour;
                        x07y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y21":
                    if(x08y21.BackColor==Color.Transparent)
                    {
                        x08y21.BackgroundImage = entity;
                        x08y21.BackColor = entityColour;
                        x08y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y21":
                    if(x09y21.BackColor==Color.Transparent)
                    {
                        x09y21.BackgroundImage = entity;
                        x09y21.BackColor = entityColour;
                        x09y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y21":
                    if(x10y21.BackColor==Color.Transparent)
                    {
                        x10y21.BackgroundImage = entity;
                        x10y21.BackColor = entityColour;
                        x10y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y21":
                    if(x11y21.BackColor==Color.Transparent)
                    {
                        x11y21.BackgroundImage = entity;
                        x11y21.BackColor = entityColour;
                        x11y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y21":
                    if(x13y21.BackColor==Color.Transparent)
                    {
                        x13y21.BackgroundImage = entity;
                        x13y21.BackColor = entityColour;
                        x13y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y21":
                    if(x14y21.BackColor==Color.Transparent)
                    {
                        x14y21.BackgroundImage = entity;
                        x14y21.BackColor = entityColour;
                        x14y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y21":
                    if(x15y21.BackColor==Color.Transparent)
                    {
                        x15y21.BackgroundImage = entity;
                        x15y21.BackColor = entityColour;
                        x15y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y21":
                    if(x16y21.BackColor==Color.Transparent)
                    {
                        x16y21.BackgroundImage = entity;
                        x16y21.BackColor = entityColour;
                        x16y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y21":
                    if(x17y21.BackColor==Color.Transparent)
                    {
                        x17y21.BackgroundImage = entity;
                        x17y21.BackColor = entityColour;
                        x17y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y21":
                    if(x18y21.BackColor==Color.Transparent)
                    {
                        x18y21.BackgroundImage = entity;
                        x18y21.BackColor = entityColour;
                        x18y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y21":
                    if(x20y21.BackColor==Color.Transparent)
                    {
                        x20y21.BackgroundImage = entity;
                        x20y21.BackColor = entityColour;
                        x20y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y21":
                    if(x21y21.BackColor==Color.Transparent)
                    {
                        x21y21.BackgroundImage = entity;
                        x21y21.BackColor = entityColour;
                        x21y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y21":
                    if(x22y21.BackColor==Color.Transparent)
                    {
                        x22y21.BackgroundImage = entity;
                        x22y21.BackColor = entityColour;
                        x22y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y21":
                    if(x23y21.BackColor==Color.Transparent)
                    {
                        x23y21.BackgroundImage = entity;
                        x23y21.BackColor = entityColour;
                        x23y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y21":
                    if(x24y21.BackColor==Color.Transparent)
                    {
                        x24y21.BackgroundImage = entity;
                        x24y21.BackColor = entityColour;
                        x24y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y21":
                    if(x26y21.BackColor==Color.Transparent)
                    {
                        x26y21.BackgroundImage = entity;
                        x26y21.BackColor = entityColour;
                        x26y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y21":
                    if(x27y21.BackColor==Color.Transparent)
                    {
                        x27y21.BackgroundImage = entity;
                        x27y21.BackColor = entityColour;
                        x27y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y21":
                    if(x28y21.BackColor==Color.Transparent)
                    {
                        x28y21.BackgroundImage = entity;
                        x28y21.BackColor = entityColour;
                        x28y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y21":
                    if(x29y21.BackColor==Color.Transparent)
                    {
                        x29y21.BackgroundImage = entity;
                        x29y21.BackColor = entityColour;
                        x29y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y21":
                    if(x30y21.BackColor==Color.Transparent)
                    {
                        x30y21.BackgroundImage = entity;
                        x30y21.BackColor = entityColour;
                        x30y21.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y22":
                    if(x01y22.BackColor==Color.Transparent)
                    {
                        x01y22.BackgroundImage = entity;
                        x01y22.BackColor = entityColour;
                        x01y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y22":
                    if(x02y22.BackColor==Color.Transparent)
                    {
                        x02y22.BackgroundImage = entity;
                        x02y22.BackColor = entityColour;
                        x02y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y22":
                    if(x03y22.BackColor==Color.Transparent)
                    {
                        x03y22.BackgroundImage = entity;
                        x03y22.BackColor = entityColour;
                        x03y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y22":
                    if(x04y22.BackColor==Color.Transparent)
                    {
                        x04y22.BackgroundImage = entity;
                        x04y22.BackColor = entityColour;
                        x04y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y22":
                    if(x05y22.BackColor==Color.Transparent)
                    {
                        x05y22.BackgroundImage = entity;
                        x05y22.BackColor = entityColour;
                        x05y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y22":
                    if(x07y22.BackColor==Color.Transparent)
                    {
                        x07y22.BackgroundImage = entity;
                        x07y22.BackColor = entityColour;
                        x07y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y22":
                    if(x08y22.BackColor==Color.Transparent)
                    {
                        x08y22.BackgroundImage = entity;
                        x08y22.BackColor = entityColour;
                        x08y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y22":
                    if(x09y22.BackColor==Color.Transparent)
                    {
                        x09y22.BackgroundImage = entity;
                        x09y22.BackColor = entityColour;
                        x09y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y22":
                    if(x10y22.BackColor==Color.Transparent)
                    {
                        x00y22.BackgroundImage = entity;
                        x00y22.BackColor = entityColour;
                        x10y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y22":
                    if(x11y22.BackColor==Color.Transparent)
                    {
                        x11y22.BackgroundImage = entity;
                        x11y22.BackColor = entityColour;
                        x11y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y22":
                    if(x15y22.BackColor==Color.Transparent)
                    {
                        x15y22.BackgroundImage = entity;
                        x15y22.BackColor = entityColour;
                        x15y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y22":
                    if(x16y22.BackColor==Color.Transparent)
                    {
                        x16y22.BackgroundImage = entity;
                        x16y22.BackColor = entityColour;
                        x16y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y22":
                    if(x20y22.BackColor==Color.Transparent)
                    {
                        x20y22.BackgroundImage = entity;
                        x20y22.BackColor = entityColour;
                        x20y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y22":
                    if(x21y22.BackColor==Color.Transparent)
                    {
                        x21y22.BackgroundImage = entity;
                        x21y22.BackColor = entityColour;
                        x21y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y22":
                    if(x22y22.BackColor==Color.Transparent)
                    {
                        x22y22.BackgroundImage = entity;
                        x22y22.BackColor = entityColour;
                        x22y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y22":
                    if(x23y22.BackColor == Color.Transparent)
                    {
                        x23y22.BackgroundImage = entity;
                        x23y22.BackColor = entityColour;
                        x23y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y22":
                    if(x24y22.BackColor==Color.Transparent)
                    {
                        x24y22.BackgroundImage = entity;
                        x24y22.BackColor = entityColour;
                        x24y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y22":
                    if(x26y22.BackColor==Color.Transparent)
                    {
                        x26y22.BackgroundImage = entity;
                        x26y22.BackColor = entityColour;
                        x26y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y22":
                    if(x27y22.BackColor==Color.Transparent)
                    {
                        x27y22.BackgroundImage = entity;
                        x27y22.BackColor = entityColour;
                        x27y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y22":
                    if(x28y22.BackColor==Color.Transparent)
                    {
                        x28y22.BackgroundImage = entity;
                        x28y22.BackColor = entityColour;
                        x28y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y22":
                    if(x29y22.BackColor == Color.Transparent)
                    {
                        x29y22.BackgroundImage = entity;
                        x29y22.BackColor = entityColour;
                        x29y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y22":
                    if(x30y22.BackColor==Color.Transparent)
                    {
                        x30y22.BackgroundImage = entity;
                        x30y22.BackColor = entityColour;
                        x30y22.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y23":
                    if(x01y23.BackColor==Color.Transparent)
                    {
                        x01y23.BackgroundImage = entity;
                        x01y23.BackColor = entityColour;
                        x01y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y23":
                    if(x02y23.BackColor == Color.Transparent)
                    {
                        x02y23.BackgroundImage = entity;
                        x02y23.BackColor = entityColour;
                        x02y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y23":
                    if(x04y23.BackColor == Color.Transparent)
                    {
                        x04y23.BackgroundImage = entity;
                        x04y23.BackColor = entityColour;
                        x04y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y23":
                    if(x05y23.BackColor==Color.Transparent)
                    {
                        x05y23.BackgroundImage = entity;
                        x05y23.BackColor = entityColour;
                        x05y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y23":
                    if(x06y23.BackColor==Color.Transparent)
                    {
                        x06y23.BackgroundImage = entity;
                        x06y23.BackColor = entityColour;
                        x06y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y23":
                    if(x07y23.BackColor==Color.Transparent)
                    {
                        x07y23.BackgroundImage = entity;
                        x07y23.BackColor = entityColour;
                        x07y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y23":
                    if(x08y24.BackColor==Color.Transparent)
                    {
                        x08y23.BackgroundImage = entity;
                        x08y23.BackColor = entityColour;
                        x08y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y23":
                    if(x09y24.BackColor==Color.Transparent)
                    {
                        x09y23.BackgroundImage = entity;
                        x09y23.BackColor = entityColour;
                        x09y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y23":
                    if(x10y23.BackColor==Color.Transparent)
                    {
                        x10y23.BackgroundImage = entity;
                        x10y23.BackColor = entityColour;
                        x10y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y23":
                    if(x11y23.BackColor==Color.Transparent)
                    {
                        x11y23.BackgroundImage = entity;
                        x11y23.BackColor = entityColour;
                        x11y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y23":
                    if(x12y23.BackColor==Color.Transparent)
                    {
                        x12y23.BackgroundImage = entity;
                        x12y23.BackColor = entityColour;
                        x12y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y23":
                    if(x13y23.BackColor==Color.Transparent)
                    {
                        x13y23.BackgroundImage = entity;
                        x13y23.BackColor = entityColour;
                        x13y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y23":
                    if(x14y23.BackColor==Color.Transparent)
                    {
                        x14y23.BackgroundImage = entity;
                        x14y23.BackColor = entityColour;
                        x14y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y23":
                    if(x15y23.BackColor==Color.Transparent)
                    {
                        x15y23.BackgroundImage = entity;
                        x15y23.BackColor = entityColour;
                        x15y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y23":
                    if(x16y23.BackColor==Color.Transparent)
                    {
                        x16y23.BackgroundImage = entity;
                        x16y23.BackColor = entityColour;
                        x16y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y23":
                    if(x17y23.BackColor==Color.Transparent)
                    {
                        x17y23.BackgroundImage = entity;
                        x17y23.BackColor = entityColour;
                        x17y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y23":
                    if(x18y23.BackColor==Color.Transparent)
                    {
                        x18y23.BackgroundImage = entity;
                        x18y23.BackColor = entityColour;
                        x18y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y23":
                    if(x19y23.BackColor==Color.Transparent)
                    {
                        x19y23.BackgroundImage = entity;
                        x19y23.BackColor = entityColour;
                        x19y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y23":
                    if(x20y23.BackColor==Color.Transparent)
                    {
                        x20y23.BackgroundImage = entity;
                        x20y23.BackColor = entityColour;
                        x20y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y23":
                    if(x21y23.BackColor==Color.Transparent)
                    {
                        x21y23.BackgroundImage = entity;
                        x21y23.BackColor = entityColour;
                        x21y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y23":
                    if (x22y23.BackColor == Color.Transparent)
                    {
                        x22y23.BackgroundImage = entity;
                        x22y23.BackColor = entityColour;
                        x22y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y23":
                    if(x23y23.BackColor==Color.Transparent)
                    {
                        x23y23.BackgroundImage = entity;
                        x23y23.BackColor = entityColour;
                        x23y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y23":
                    if(x24y23.BackColor==Color.Transparent)
                    {
                        x24y23.BackgroundImage = entity;
                        x24y23.BackColor = entityColour;
                        x24y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y23":
                    if(x25y23.BackColor==Color.Transparent)
                    {
                        x25y23.BackgroundImage = entity;
                        x25y23.BackColor = entityColour;
                        x25y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y23":
                    if(x26y23.BackColor==Color.Transparent)
                    {
                        x26y23.BackgroundImage = entity;
                        x26y23.BackColor = entityColour;
                        x26y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y23":
                    if(x27y23.BackColor == Color.Transparent)
                    {
                        x27y23.BackgroundImage = entity;
                        x27y23.BackColor = entityColour;
                        x27y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y23":
                    if(x29y23.BackColor==Color.Transparent)
                    {
                        x29y23.BackgroundImage = entity;
                        x29y23.BackColor = entityColour;
                        x29y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y23":
                    if(x30y23.BackColor==Color.Transparent)
                    {
                        x30y23.BackgroundImage = entity;
                        x30y23.BackColor = entityColour;
                        x30y23.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y24":
                    if(x01y24.BackColor==Color.Transparent)
                    {
                        x01y24.BackgroundImage = entity;
                        x01y24.BackColor = entityColour;
                        x01y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y24":
                    if(x02y24.BackColor==Color.Transparent)
                    {
                        x02y24.BackgroundImage = entity;
                        x02y24.BackColor = entityColour;
                        x02y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y24":
                    if(x04y24.BackColor==Color.Transparent)
                    {
                        x04y24.BackgroundImage = entity;
                        x04y24.BackColor = entityColour;
                        x04y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y24":
                    if(x05y24.BackColor==Color.Transparent)
                    {
                        x05y24.BackgroundImage = entity;
                        x05y24.BackColor = entityColour;
                        x05y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y24":
                    if(x06y24.BackColor==Color.Transparent)
                    {
                        x06y24.BackgroundImage = entity;
                        x06y24.BackColor = entityColour;
                        x06y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y24":
                    if(x07y24.BackColor==Color.Transparent)
                    {
                        x07y24.BackgroundImage = entity;
                        x07y24.BackColor = entityColour;
                        x07y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y24":
                    if(x08y24.BackColor==Color.Transparent)
                    {
                        x08y24.BackgroundImage = entity;
                        x08y24.BackColor = entityColour;
                        x08y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y24":
                    if(x09y24.BackColor==Color.Transparent)
                    {
                        x09y24.BackgroundImage = entity;
                        x09y24.BackColor = entityColour;
                        x09y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y24":
                    if(x10y24.BackColor==Color.Transparent)
                    {
                        x10y24.BackgroundImage = entity;
                        x10y24.BackColor = entityColour;
                        x10y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y24":
                    if(x11y24.BackColor==Color.Transparent)
                    {
                        x11y24.BackgroundImage = entity;
                        x11y24.BackColor = entityColour;
                        x11y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y24":
                    if(x12y24.BackColor==Color.Transparent)
                    {
                        x12y24.BackgroundImage = entity;
                        x12y24.BackColor = entityColour;
                        x12y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y24":
                    if(x13y24.BackColor == Color.Transparent)
                    {
                        x13y24.BackgroundImage = entity;
                        x13y24.BackColor = entityColour;
                        x13y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y24":
                    if(x14y24.BackColor==Color.Transparent)
                    {
                        x14y24.BackgroundImage = entity;
                        x14y24.BackColor = entityColour;
                        x14y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y24":
                    if(x15y24.BackColor==Color.Transparent)
                    {
                        x15y24.BackgroundImage = entity;
                        x15y24.BackColor = entityColour;
                        x15y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y24":
                    if(x16y24.BackColor==Color.Transparent)
                    {
                        x16y24.BackgroundImage = entity;
                        x16y24.BackColor = entityColour;
                        x16y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y24":
                    if(x17y24.BackColor==Color.Transparent)
                    {
                        x17y24.BackgroundImage = entity;
                        x17y24.BackColor = entityColour;
                        x17y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y24":
                    if(x18y24.BackColor==Color.Transparent)
                    {
                        x18y24.BackgroundImage = entity;
                        x18y24.BackColor = entityColour;
                        x18y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y24":
                    if(x19y24.BackColor==Color.Transparent)
                    {
                        x19y24.BackgroundImage = entity;
                        x19y24.BackColor = entityColour;
                        x19y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y24":
                    if(x20y24.BackColor==Color.Transparent)
                    {
                        x20y24.BackgroundImage = entity;
                        x20y24.BackColor = entityColour;
                        x20y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y24":
                    if(x21y24.BackColor==Color.Transparent)
                    {
                        x21y24.BackgroundImage = entity;
                        x21y24.BackColor = entityColour;
                        x21y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y24":
                    if(x22y24.BackColor==Color.Transparent)
                    {
                        x22y24.BackgroundImage = entity;
                        x22y24.BackColor = entityColour;
                        x22y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y24":
                    if(x23y24.BackColor==Color.Transparent)
                    {
                        x23y24.BackgroundImage = entity;
                        x23y24.BackColor = entityColour;
                        x23y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y24":
                    if(x24y24.BackColor==Color.Transparent)
                    {
                        x24y24.BackgroundImage = entity;
                        x24y24.BackColor = entityColour;
                        x24y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y24":
                    if(x25y24.BackColor==Color.Transparent)
                    {
                        x25y24.BackgroundImage = entity;
                        x25y24.BackColor = entityColour;
                        x25y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y24":
                    if(x26y24.BackColor==Color.Transparent)
                    {
                        x26y24.BackgroundImage = entity;
                        x26y24.BackColor = entityColour;
                        x26y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y24":
                    if(x27y24.BackColor==Color.Transparent)
                    {
                        x27y24.BackgroundImage = entity;
                        x27y24.BackColor = entityColour;
                        x27y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y24":
                    if(x29y24.BackColor==Color.Transparent)
                    {
                        x29y24.BackgroundImage = entity;
                        x29y24.BackColor = entityColour;
                        x29y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y24":
                    if(x30y24.BackColor==Color.Transparent)
                    { 
                        x30y24.BackgroundImage = entity;
                        x30y24.BackColor = entityColour;
                        x30y24.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y25":
                    if(x01y25.BackColor==Color.Transparent)
                    {
                        x01y25.BackgroundImage = entity;
                        x01y25.BackColor = entityColour;
                        x01y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y25":
                    if(x02y25.BackColor == Color.Transparent)
                    {
                        x02y25.BackgroundImage = entity;
                        x02y25.BackColor = entityColour;
                        x02y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y25":
                    if(x05y25.BackColor==Color.Transparent)
                    {
                        x05y25.BackgroundImage = entity;
                        x05y25.BackColor = entityColour;
                        x05y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y25":
                    if(x06y25.BackColor==Color.Transparent)
                    {
                        x06y25.BackgroundImage = entity;
                        x06y25.BackColor = entityColour;
                        x06y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y25":
                    if(x10y25.BackColor==Color.Transparent)
                    {
                        x10y25.BackgroundImage = entity;
                        x10y25.BackColor = entityColour;
                        x10y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y25":
                    if(x11y25.BackColor == Color.Transparent)
                    {
                        x11y25.BackgroundImage = entity;
                        x11y25.BackColor = entityColour;
                        x11y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y25":
                    if(x15y25.BackColor==Color.Transparent)
                    {
                        x15y25.BackgroundImage = entity;
                        x15y25.BackColor = entityColour;
                        x15y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y25":
                    if(x16y25.BackColor==Color.Transparent)
                    {
                        x16y25.BackgroundImage = entity;
                        x16y25.BackColor = entityColour;
                        x16y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y25":
                    if(x20y25.BackColor==Color.Transparent)
                    {
                        x20y25.BackgroundImage = entity;
                        x20y25.BackColor = entityColour;
                        x20y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y25":
                    if(x21y25.BackColor==Color.Transparent)
                    {
                        x21y25.BackgroundImage = entity;
                        x21y25.BackColor = entityColour;
                        x21y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y25":
                    if(x25y25.BackColor == Color.Transparent)
                    {
                        x25y25.BackgroundImage = entity;
                        x25y25.BackColor = entityColour;
                        x25y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y25":
                    if(x26y25.BackColor==Color.Transparent)
                    {
                        x26y25.BackgroundImage = entity;
                        x26y25.BackColor = entityColour;
                        x26y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y25":
                    if(x29y25.BackColor==Color.Transparent)
                    {
                        x29y25.BackgroundImage = entity;
                        x29y25.BackColor = entityColour;
                        x29y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y25":
                    if(x30y25.BackColor==Color.Transparent)
                    {
                        x30y25.BackgroundImage = entity;
                        x30y25.BackColor = entityColour;
                        x30y25.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y26":
                    if(x01y26.BackColor==Color.Transparent)
                    {
                        x01y26.BackgroundImage = entity;
                        x01y26.BackColor = entityColour;
                        x01y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y26":
                    if(x02y26.BackColor==Color.Transparent)
                    {
                        x02y26.BackgroundImage = entity;
                        x02y26.BackColor = entityColour;
                        x02y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y26":
                    if(x03y26.BackColor==Color.Transparent)
                    {
                        x03y26.BackgroundImage = entity;
                        x03y26.BackColor = entityColour;
                        x03y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y26":
                    if(x04y26.BackColor==Color.Transparent)
                    {
                        x04y26.BackgroundImage = entity;
                        x04y26.BackColor = entityColour;
                        x04y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y26":
                    if(x05y26.BackColor==Color.Transparent)
                    {
                        x05y26.BackgroundImage = entity;
                        x05y26.BackColor = entityColour;
                        x05y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y26":
                    if(x06y26.BackColor==Color.Transparent)
                    {
                        x06y26.BackgroundImage = entity;
                        x06y26.BackColor = entityColour;
                        x06y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y26":
                    if(x07y26.BackColor==Color.Transparent)
                    {
                        x07y26.BackgroundImage = entity;
                        x07y26.BackColor = entityColour;
                        x07y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y26":
                    if(x09y26.BackColor==Color.Transparent)
                    {
                        x09y26.BackgroundImage = entity;
                        x09y26.BackColor = entityColour;
                        x09y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y26":
                    if(x10y26.BackColor==Color.Transparent)
                    {
                        x10y26.BackgroundImage = entity;
                        x10y26.BackColor = entityColour;
                        x10y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y26":
                    if(x11y26.BackColor==Color.Transparent)
                    {
                        x11y26.BackgroundImage = entity;
                        x11y26.BackColor = entityColour;
                        x11y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y26":
                    if(x13y26.BackColor==Color.Transparent)
                    {
                        x13y26.BackgroundImage = entity;
                        x13y26.BackColor = entityColour;
                        x13y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y26":
                    if(x14y26.BackColor==Color.Transparent)
                    {
                        x14y26.BackgroundImage = entity;
                        x14y26.BackColor = entityColour;
                        x14y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y26":
                    if(x15y26.BackColor==Color.Transparent)
                    {
                        x15y26.BackgroundImage = entity;
                        x15y26.BackColor = entityColour;
                        x15y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y26":
                    if(x16y26.BackColor == Color.Transparent)
                    {
                        x16y26.BackgroundImage = entity;
                        x16y26.BackColor = entityColour;
                        x16y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y26":
                    if(x17y26.BackColor==Color.Transparent)
                    {
                        x17y26.BackgroundImage = entity;
                        x17y26.BackColor = entityColour;
                        x17y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y26":
                    if(x18y26.BackColor==Color.Transparent)
                    {
                        x18y26.BackgroundImage = entity;
                        x18y26.BackColor = entityColour;
                        x18y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y26":
                    if(x20y26.BackColor==Color.Transparent)
                    {
                        x20y26.BackgroundImage = entity;
                        x20y26.BackColor = entityColour;
                        x20y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y26":
                    if(x20y26.BackColor == Color.Transparent)
                    {
                        x21y26.BackgroundImage = entity;
                        x21y26.BackColor = entityColour;
                        x21y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y26":
                    if(x22y26.BackColor==Color.Transparent)
                    {
                        x22y26.BackgroundImage = entity;
                        x22y26.BackColor = entityColour;
                        x22y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y26":
                    if(x24y26.BackColor==Color.Transparent)
                    {
                        x24y26.BackgroundImage = entity;
                        x24y26.BackColor = entityColour;
                        x24y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y26":
                    if(x25y26.BackColor==Color.Transparent)
                    {
                        x25y26.BackgroundImage = entity;
                        x25y26.BackColor = entityColour;
                        x25y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y26":
                    if(x26y26.BackColor==Color.Transparent)
                    {
                        x26y26.BackgroundImage = entity;
                        x26y26.BackColor = entityColour;
                        x26y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y26":
                    if(x27y26.BackColor==Color.Transparent)
                    {
                        x27y26.BackgroundImage = entity;
                        x27y26.BackColor = entityColour;
                        x27y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y26":
                    if(x28y26.BackColor==Color.Transparent)
                    {
                        x28y26.BackgroundImage = entity;
                        x28y26.BackColor = entityColour;
                        x28y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y26":
                    if(x29y26.BackColor==Color.Transparent)
                    {
                        x29y26.BackgroundImage = entity;
                        x29y26.BackColor = entityColour;
                        x29y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y26":
                    if(x30y26.BackColor==Color.Transparent)
                    {
                        x30y26.BackgroundImage = entity;
                        x30y26.BackColor = entityColour;
                        x30y26.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y27":
                    if(x01y27.BackColor==Color.Transparent)
                    {
                        x01y27.BackgroundImage = entity;
                        x01y27.BackColor = entityColour;
                        x01y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y27":
                    if(x02y27.BackColor==Color.Transparent)
                    {  
                        x02y27.BackgroundImage = entity;
                        x02y27.BackColor = entityColour;
                        x02y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y27":
                    if(x03y27.BackColor==Color.Transparent)
                    {
                        x03y27.BackgroundImage = entity;
                        x03y27.BackColor = entityColour;
                        x03y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y27":
                    if(x04y27.BackColor==Color.Transparent)
                    {
                        x04y27.BackgroundImage = entity;
                        x04y27.BackColor = entityColour;
                        x04y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y27":
                    if(x05y27.BackColor==Color.Transparent)
                    {
                        x05y27.BackgroundImage = entity;
                        x05y27.BackColor = entityColour;
                        x05y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y27":
                    if(x06y27.BackColor==Color.Transparent)
                    {
                        x06y27.BackgroundImage = entity;
                        x06y27.BackColor = entityColour;
                        x06y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y27":
                    if(x07y27.BackColor==Color.Transparent)
                    {
                        x07y27.BackgroundImage = entity;
                        x07y27.BackColor = entityColour;
                        x07y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y27":
                    if(x09y27.BackColor==Color.Transparent)
                    {
                        x09y27.BackgroundImage = entity;
                        x09y27.BackColor = entityColour;
                        x09y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y27":
                    if(x10y27.BackColor == Color.Transparent)
                    {
                        x10y27.BackgroundImage = entity;
                        x10y27.BackColor = entityColour;
                        x10y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y27":
                    if(x11y27.BackColor == Color.Transparent)
                    {
                        x11y27.BackgroundImage = entity;
                        x11y27.BackColor = entityColour;
                        x11y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y27":
                    if(x13y27.BackColor==Color.Transparent)
                    {
                        x13y27.BackgroundImage = entity;
                        x13y27.BackColor = entityColour;
                        x13y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y27":
                    if(x14y27.BackColor == Color.Transparent)
                    {
                        x14y27.BackgroundImage = entity;
                        x14y27.BackColor = entityColour;
                        x14y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y27":
                    if(x15y27.BackColor==Color.Transparent)
                    {
                        x15y27.BackgroundImage = entity;
                        x15y27.BackColor = entityColour;
                        x15y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y27":
                    if(x16y27.BackColor==Color.Transparent)
                    {
                        x16y27.BackgroundImage = entity;
                        x16y27.BackColor = entityColour;
                        x16y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y27":
                    if(x17y27.BackColor==Color.Transparent)
                    {
                        x17y27.BackgroundImage = entity;
                        x17y27.BackColor = entityColour;
                        x17y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y27":
                    if(x18y27.BackColor==Color.Transparent)
                    {
                        x18y27.BackgroundImage = entity;
                        x18y27.BackColor = entityColour;
                        x18y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y27":
                    if(x20y27.BackColor == Color.Transparent)
                    {
                        x20y27.BackgroundImage = entity;
                        x20y27.BackColor = entityColour;
                        x20y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y27":
                    if(x21y27.BackColor==Color.Transparent)
                    {
                        x21y27.BackgroundImage = entity;
                        x21y27.BackColor = entityColour;
                        x21y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y27":
                    if(x22y27.BackColor==Color.Transparent)
                    {
                        x22y27.BackgroundImage = entity;
                        x22y27.BackColor = entityColour;
                        x22y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y27":
                    if(x24y27.BackColor==Color.Transparent)
                    {
                        x24y27.BackgroundImage = entity;
                        x24y27.BackColor = entityColour;
                        x24y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y27":
                    if(x25y27.BackColor==Color.Transparent)
                    {
                        x25y27.BackgroundImage = entity;
                        x25y27.BackColor = entityColour;
                        x25y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y27":
                    if(x26y27.BackColor==Color.Transparent)
                    {
                        x26y27.BackgroundImage = entity;
                        x26y27.BackColor = entityColour;
                        x26y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y27":
                    if(x27y27.BackColor==Color.Transparent)
                    { 
                        x27y27.BackgroundImage = entity;
                        x27y27.BackColor = entityColour;
                        x27y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y27":
                    if (x28y27.BackColor == Color.Transparent)
                    {
                        x28y27.BackgroundImage = entity;
                        x28y27.BackColor = entityColour;
                        x28y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y27":
                    if (x29y27.BackColor == Color.Transparent)
                    {
                        x29y27.BackgroundImage = entity;
                        x29y27.BackColor = entityColour;
                        x29y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y27":
                    if (x30y27.BackColor == Color.Transparent)
                    {
                        x30y27.BackgroundImage = entity;
                        x30y27.BackColor = entityColour;
                        x30y27.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y28":
                    if (x01y28.BackColor == Color.Transparent)
                    {
                        x01y28.BackgroundImage = entity;
                        x01y28.BackColor = entityColour;
                        x01y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y28":
                    if (x02y28.BackColor == Color.Transparent)
                    {
                        x02y28.BackgroundImage = entity;
                        x02y28.BackColor = entityColour;
                        x02y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y28":
                    if (x03y28.BackColor == Color.Transparent)
                    {
                        x03y28.BackgroundImage = entity;
                        x03y28.BackColor = entityColour;
                        x03y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y28":
                    if (x04y28.BackColor == Color.Transparent)
                    {
                        x04y28.BackgroundImage = entity;
                        x04y28.BackColor = entityColour;
                        x04y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y28":
                    if(x05y28.BackColor==Color.Transparent)
                    { 
                        x05y28.BackgroundImage = entity;
                        x05y28.BackColor = entityColour;
                        x05y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y28":
                    if(x06y28.BackColor==Color.Transparent)
                    { 
                        x06y28.BackgroundImage = entity;
                        x06y28.BackColor = entityColour;
                        x06y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y28":
                    if(x07y28.BackColor==Color.Transparent)
                    { 
                        x07y28.BackgroundImage = entity;
                        x07y28.BackColor = entityColour;
                        x07y28.BackgroundImageLayout = entityLayout;
                    }
                    break;

                case "x09y28":
                    { 
                        x09y28.BackgroundImage = entity;
                        x09y28.BackColor = entityColour;
                        x09y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y28":
                    if(x10y28.BackColor==Color.Transparent)
                    { 
                        x10y28.BackgroundImage = entity;
                        x10y28.BackColor = entityColour;
                        x10y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y28":
                    if(x11y28.BackColor==Color.Transparent)
                    { 
                        x11y28.BackgroundImage = entity;
                        x11y28.BackColor = entityColour;
                        x11y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y28":
                    if(x15y28.BackColor==Color.Transparent)
                    { 
                        x15y28.BackgroundImage = entity;
                        x15y28.BackColor = entityColour;
                        x15y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y28":
                    if(x16y28.BackColor==Color.Transparent)
                    {     
                        x16y28.BackgroundImage = entity;
                        x16y28.BackColor = entityColour;
                        x16y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y28":
                    if(x20y28.BackColor==Color.Transparent)
                    { 
                        x20y28.BackgroundImage = entity;
                        x20y28.BackColor = entityColour;
                        x20y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y28":
                    if(x21y28.BackColor==Color.Transparent)
                    {
                        x21y28.BackgroundImage = entity;
                        x21y28.BackColor = entityColour;
                        x21y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y28":
                    if(x22y28.BackColor==Color.Transparent)
                    { 
                        x22y28.BackgroundImage = entity;
                        x22y28.BackColor = entityColour;
                        x22y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y28":
                    if(x24y28.BackColor==Color.Transparent)
                    { 
                        x24y28.BackgroundImage = entity;
                        x24y28.BackColor = entityColour;
                        x24y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y28":
                    if(x25y28.BackColor==Color.Transparent)
                    { 
                        x25y28.BackgroundImage = entity;
                        x25y28.BackColor = entityColour;
                        x25y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y28":
                    if(x26y28.BackColor==Color.Transparent)
                    { 
                        x26y28.BackgroundImage = entity;
                        x26y28.BackColor = entityColour;
                        x26y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y28":
                    if(x27y28.BackColor==Color.Transparent)
                    { 
                        x27y28.BackgroundImage = entity;
                        x27y28.BackColor = entityColour;
                        x27y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y28":
                    if(x28y28.BackColor==Color.Transparent)
                    { 
                        x28y28.BackgroundImage = entity;
                        x28y28.BackColor = entityColour;
                        x28y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y28":
                    x29y28.BackgroundImage = entity;
                    x29y28.BackColor = entityColour;
                    x29y28.BackgroundImageLayout = entityLayout;
              
                    break;
                case "x30y28":
                    if(x30y28.BackColor==Color.Transparent)
                    {
                        x30y28.BackgroundImage = entity;
                        x30y28.BackColor = entityColour;
                        x30y28.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y29":
                    if ((x01y29.BackColor == Color.Red && entityColour == Color.Red) || (x01y29.BackColor == Color.Red && entityColour == Color.DarkRed))
                    {
                        x01y29.BackgroundImage = entity;
                        x01y29.BackColor = entityColour;
                        x01y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y29":
                    if (x02y29.BackColor == Color.Transparent)
                    {
                        x02y29.BackgroundImage = entity;
                        x02y29.BackColor = entityColour;
                        x02y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y29":
                    if (x03y29.BackColor == Color.Transparent)
                    {
                        x03y29.BackgroundImage = entity;
                        x03y29.BackColor = entityColour;
                        x03y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y29":
                    if (x04y29.BackColor == Color.Transparent)
                    {
                        x04y29.BackgroundImage = entity;
                        x04y29.BackColor = entityColour;
                        x04y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y29":
                    if (x05y29.BackColor == Color.Transparent)
                    {
                        x05y29.BackgroundImage = entity;
                        x05y29.BackColor = entityColour;
                        x05y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y29":
                    if (x06y29.BackColor == Color.Transparent)
                    {
                        x06y29.BackgroundImage = entity;
                        x06y29.BackColor = entityColour;
                        x06y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x07y29":
                    if (x07y29.BackColor == Color.Transparent)
                    {
                        x07y29.BackgroundImage = entity;
                        x07y29.BackColor = entityColour;
                        x07y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y29":
                    if (x08y29.BackColor == Color.Transparent)
                    {
                        x08y29.BackgroundImage = entity;
                        x08y29.BackColor = entityColour;
                        x08y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y29":
                    if (x09y29.BackColor == Color.Transparent)
                    {
                        x09y29.BackgroundImage = entity;
                        x09y29.BackColor = entityColour;
                        x09y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y29":
                    if (x10y29.BackColor == Color.Transparent)
                    {
                        x10y29.BackgroundImage = entity;
                        x10y29.BackColor = entityColour;
                        x10y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y29":
                    if(x11y29.BackColor==Color.Transparent)
                    { 
                        x11y29.BackgroundImage = entity;
                        x11y29.BackColor = entityColour;
                        x11y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y29":
                    if(x12y29.BackColor==Color.Transparent)
                    {
                        x12y29.BackgroundImage = entity;
                        x12y29.BackColor = entityColour;
                        x12y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y29":
                    if(x13y29.BackColor==Color.Transparent)
                    {
                        x13y29.BackgroundImage = entity;
                        x13y29.BackColor = entityColour;
                        x13y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y29":
                    if(x14y29.BackColor==Color.Transparent)
                    {
                        x14y29.BackgroundImage = entity;
                        x14y29.BackColor = entityColour;
                        x14y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x15y29":
                    if(x15y29.BackColor==Color.Transparent)
                    {
                        x15y29.BackgroundImage = entity;
                        x15y29.BackColor = entityColour;
                        x15y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y29":
                    if(x16y29.BackColor==Color.Transparent)
                    {
                        x16y29.BackgroundImage = entity;
                        x16y29.BackColor = entityColour;
                        x16y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y29":
                    if(x17y29.BackColor==Color.Transparent)
                    {
                        x17y29.BackgroundImage = entity;
                        x17y29.BackColor = entityColour;
                        x17y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y29":
                    if(x18y29.BackColor==Color.Transparent)
                    {
                        x18y29.BackgroundImage = entity;
                        x18y29.BackColor = entityColour;
                        x18y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y29":
                    if(x19y29.BackColor==Color.Transparent)
                    {
                        x19y29.BackgroundImage = entity;
                        x19y29.BackColor = entityColour;
                        x19y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y29":
                    if(x20y29.BackColor==Color.Transparent)
                    { 
                        x20y29.BackgroundImage = entity;
                        x20y29.BackColor = entityColour;
                        x20y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x21y29":
                    if(x21y29.BackColor==Color.Transparent)
                    {
                        x21y29.BackgroundImage = entity;
                        x21y29.BackColor = entityColour;
                        x21y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y29":
                    if(x22y29.BackColor==Color.Transparent)
                    {
                        x22y29.BackgroundImage = entity;
                        x22y29.BackColor = entityColour;
                        x22y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y29":
                    if(x23y29.BackColor==Color.Transparent)
                    {
                        x23y29.BackgroundImage = entity;
                        x23y29.BackColor = entityColour;
                        x23y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y29":
                    if(x24y29.BackColor==Color.Transparent)
                    { 
                        x24y29.BackgroundImage = entity;
                        x24y29.BackColor = entityColour;
                        x24y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y29":
                    if(x25y29.BackColor==Color.Transparent)
                    { 
                        x25y29.BackgroundImage = entity;
                        x25y29.BackColor = entityColour;
                        x25y29.BackgroundImageLayout = entityLayout;
                    } 
                    break;
                case "x26y29":
                    if(x26y29.BackColor==Color.Transparent)
                    {
                        x26y29.BackgroundImage = entity;
                        x26y29.BackColor = entityColour;
                        x26y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y29":
                    if(x27y29.BackColor==Color.Transparent)
                    { 
                        x27y29.BackgroundImage = entity;
                        x27y29.BackColor = entityColour;
                        x27y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y29":
                    if(x28y29.BackColor==Color.Transparent)
                    {
                        x28y29.BackgroundImage = entity;
                        x28y29.BackColor = entityColour;
                        x28y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y29":
                    if(x29y29.BackColor==Color.Transparent)
                    { 
                        x29y29.BackgroundImage = entity;
                        x29y29.BackColor = entityColour;
                        x29y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y29":
                    if((x30y29.BackColor == Color.White && entityColour == Color.White) || (x30y29.BackColor == Color.White && entityColour == Color.DarkGray))
                    {
                        x30y29.BackgroundImage = entity;
                        x30y29.BackColor = entityColour;
                        x30y29.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x01y30":
                    if((x01y30.BackColor == Color.Red && entityColour == Color.Red) || (x01y30.BackColor == Color.Red && entityColour == Color.DarkRed))
                    { 
                        x01y30.BackgroundImage = entity;
                        x01y30.BackColor = entityColour;
                        x01y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x02y30":
                    if((x02y30.BackColor == Color.Red && entityColour == Color.Red) || (x02y30.BackColor == Color.Red && entityColour == Color.DarkRed))
                    { 
                        x02y30.BackgroundImage = entity;
                        x02y30.BackColor = entityColour;
                        x02y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x03y30":
                    if(x03y30.BackColor==Color.Transparent)
                    { 
                        x03y30.BackgroundImage = entity;
                        x03y30.BackColor = entityColour;
                        x03y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x04y30":
                    if(x04y30.BackColor==Color.Transparent)
                    { 
                        x04y30.BackgroundImage = entity;
                        x04y30.BackColor = entityColour;
                        x04y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x05y30":
                    if(x05y30.BackColor==Color.Transparent)
                    { 
                        x05y30.BackgroundImage = entity;
                        x05y30.BackColor = entityColour;
                        x05y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x06y30":
                    if(x06y30.BackColor==Color.Transparent) 
                    { 
                        x06y30.BackgroundImage = entity;
                        x06y30.BackColor = entityColour;
                        x06y30.BackgroundImageLayout = entityLayout;
                    }   
                    break;
                case "x07y30":
                    if(x07y30.BackColor==Color.Transparent)
                    {
                        x07y30.BackgroundImage = entity;
                        x07y30.BackColor = entityColour;
                        x07y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x08y30":
                    if(x08y30.BackColor == Color.Transparent)
                    {
                        x08y30.BackgroundImage = entity;
                        x08y30.BackColor = entityColour;
                        x08y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x09y30":
                    if(x09y30.BackColor==Color.Transparent)
                    {
                        x09y30.BackgroundImage = entity;
                        x09y30.BackColor = entityColour;
                        x09y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x10y30":
                    if(x10y30.BackColor==Color.Transparent)
                    {
                        x10y30.BackgroundImage = entity;
                        x10y30.BackColor = entityColour;
                        x10y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x11y30":
                    if(x11y30.BackColor==Color.Transparent)
                    {
                        x11y30.BackgroundImage = entity;
                        x11y30.BackColor = entityColour;
                        x11y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x12y30":
                    if(x12y30.BackColor==Color.Transparent)
                    {
                        x12y30.BackgroundImage = entity;
                        x12y30.BackColor = entityColour;
                        x12y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y30":
                    if(x13y30.BackColor==Color.Transparent)
                    { 
                        x13y30.BackgroundImage = entity;
                        x13y30.BackColor = entityColour;
                        x13y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y30":
                    if(x14y30.BackColor==Color.Transparent)
                    {
                        x14y30.BackgroundImage = entity;
                        x14y30.BackColor = entityColour;
                        x14y30.BackgroundImageLayout = entityLayout;

                    }
                    break;
                case "x15y30":
                    if(x15y30.BackColor==Color.Transparent)
                    {
                        x15y30.BackgroundImage = entity;
                        x15y30.BackColor = entityColour;
                        x15y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x16y30":
                    if(x16y30.BackColor==Color.Transparent)
                    { 
                        x16y30.BackgroundImage = entity;
                        x16y30.BackColor = entityColour;
                        x16y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y30":
                    if(x17y30.BackColor==Color.Transparent)
                    {
                        x17y30.BackgroundImage = entity;
                        x17y30.BackColor = entityColour;
                        x17y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y30":
                    if(x18y30.BackColor==Color.Transparent)
                    {
                        x18y30.BackgroundImage = entity;
                        x18y30.BackColor = entityColour;
                        x18y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x19y30":
                    if(x19y30.BackColor==Color.Transparent)
                    {
                        x19y30.BackgroundImage = entity;
                        x19y30.BackColor = entityColour;
                        x19y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x20y30":
                    if(x20y30.BackColor==Color.Transparent)
                    {
                        x20y30.BackgroundImage = entity;
                        x20y30.BackColor = entityColour;
                        x20y30.BackgroundImageLayout = entityLayout;
                    }
                    
                    break;
                case "x21y30":
                    if(x21y30.BackColor==Color.Transparent)
                    {
                        x21y30.BackgroundImage = entity;
                        x21y30.BackColor = entityColour;
                        x21y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x22y30":
                    if(x22y30.BackColor==Color.Transparent)
                    {
                        x22y30.BackgroundImage = entity;
                        x22y30.BackColor = entityColour;
                        x22y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x23y30":
                    if(x23y30.BackColor==Color.Transparent)
                    {
                        x23y30.BackgroundImage = entity;
                        x23y30.BackColor = entityColour;
                        x23y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x24y30":
                    if(x24y30.BackColor==Color.Transparent) 
                    { 
                        x24y30.BackgroundImage = entity;
                        x24y30.BackColor = entityColour;
                        x24y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x25y30":
                    if(x25y30.BackColor==Color.Transparent)
                    { 
                        x25y30.BackgroundImage = entity;
                        x25y30.BackColor = entityColour;
                        x25y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x26y30":
                    if(x26y30.BackColor==Color.Transparent)
                    {
                        x26y30.BackgroundImage = entity;
                        x26y30.BackColor = entityColour;
                        x26y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x27y30":
                    if(x27y30.BackColor == Color.Transparent)
                    {
                        x27y30.BackgroundImage = entity;
                        x27y30.BackColor = entityColour;
                        x27y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x28y30":
                    if(x28y30.BackColor==Color.Transparent)
                    {
                        x28y30.BackgroundImage = entity;
                        x28y30.BackColor = entityColour;
                        x28y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x29y30":
                    if((x29y30.BackColor == Color.White && entityColour == Color.White) || (x29y30.BackColor == Color.White && entityColour == Color.DarkGray))
                    {
                        x29y30.BackgroundImage = entity;
                        x29y30.BackColor = entityColour;
                        x29y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x30y30":
                    if((x30y30.BackColor == Color.White && entityColour == Color.White) || (x30y30.BackColor == Color.White && entityColour == Color.DarkGray))
                    {
                        x30y30.BackgroundImage = entity;
                        x30y30.BackColor = entityColour;
                        x30y30.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x13y31":
                    if(x13y31.BackColor==Color.Transparent)
                    {
                        x13y31.BackgroundImage = entity;
                        x13y31.BackColor = entityColour;
                        x13y31.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x14y31":
                    if(x14y31.BackColor==Color.Transparent)
                    {
                        x14y31.BackgroundImage = entity;
                        x14y31.BackColor = entityColour;
                        x14y31.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x17y31":
                    if(x17y31.BackColor==Color.Transparent)
                    {
                        x17y31.BackgroundImage = entity;
                        x17y31.BackColor = entityColour;
                        x17y31.BackgroundImageLayout = entityLayout;
                    }
                    break;
                case "x18y31":
                    if(x18y31.BackColor==Color.Transparent)
                    {
                        x18y31.BackgroundImage = entity;
                        x18y31.BackColor = entityColour;
                        x18y31.BackgroundImageLayout = entityLayout;
                    }
                    break;
                default:
                    Locate(stepsHistory[Convert.ToInt32(StepL.Text) - 1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
                    EntityLocationTB.Text = stepsHistory[Convert.ToInt32(StepL.Text) - 1];
                    StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) - 1);
                    break;
            }
        }
        private void RemoveEntity(string entityLocation)
        {
            switch (entityLocation)
            {
                case "x13y00":
                    x13y00.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x13y00.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x14y00":
                    x14y00.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x14y00.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x17y00":
                    x17y00.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x17y00.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x18y00":
                    x18y00.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x18y00.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y01":
                    x01y01.BackgroundImage = null;
                    x01y01.BackColor = Color.Yellow;
                    break;
                case "x02y01":
                    x02y01.BackgroundImage = null;
                    x02y01.BackColor = Color.Yellow;
                    break;
                case "x03y01":
                    x03y01.BackgroundImage = null;
                    x03y01.BackColor = Color.Transparent;
                    break;
                case "x04y01":
                    x04y01.BackgroundImage = null;
                    x04y01.BackColor = Color.Transparent;
                    break;
                case "x05y01":
                    x05y01.BackgroundImage = null;
                    x05y01.BackColor = Color.Transparent;
                    break;
                case "x06y01":
                    x06y01.BackgroundImage = null;
                    x06y01.BackColor = Color.Transparent;
                    break;
                case "x07y01":
                    x07y01.BackgroundImage = null;
                    x07y01.BackColor = Color.Transparent;
                    break;
                case "x08y01":
                    x08y01.BackgroundImage = null;
                    x08y01.BackColor = Color.Transparent;
                    break;
                case "x09y01":
                    x09y01.BackgroundImage = null;
                    x09y01.BackColor = Color.Transparent;
                    break;
                case "x10y01":
                    x10y01.BackgroundImage = null;
                    x10y01.BackColor = Color.Transparent;
                    break;
                case "x11y01":
                    x11y01.BackgroundImage = null;
                    x11y01.BackColor = Color.Transparent;
                    break;
                case "x12y01":
                    x12y01.BackgroundImage = null;
                    x12y01.BackColor = Color.Transparent;
                    break;
                case "x13y01":
                    x13y01.BackgroundImage = null;
                    x13y01.BackColor = Color.Transparent;
                    break;
                case "x14y01":
                    x14y01.BackgroundImage = null;
                    x14y01.BackColor = Color.Transparent;
                    break;
                case "x15y01":
                    x15y01.BackgroundImage = null;
                    x15y01.BackColor = Color.Transparent;
                    break;
                case "x16y01":
                    x16y01.BackgroundImage = null;
                    x16y01.BackColor = Color.Transparent;
                    break;
                case "x17y01":
                    x17y01.BackgroundImage = null;
                    x17y01.BackColor = Color.Transparent;
                    break;
                case "x18y01":
                    x18y01.BackgroundImage = null;
                    x18y01.BackColor = Color.Transparent;
                    break;
                case "x19y01":
                    x19y01.BackgroundImage = null;
                    x19y01.BackColor = Color.Transparent;
                    break;
                case "x20y01":
                    x20y01.BackgroundImage = null;
                    x20y01.BackColor = Color.Transparent;
                    break;
                case "x21y01":
                    x21y01.BackgroundImage = null;
                    x21y01.BackColor = Color.Transparent;
                    break;
                case "x22y01":
                    x22y01.BackgroundImage = null;
                    x22y01.BackColor = Color.Transparent;
                    break;
                case "x23y01":
                    x23y01.BackgroundImage = null;
                    x23y01.BackColor = Color.Transparent;
                    break;
                case "x24y01":
                    x24y01.BackgroundImage = null;
                    x24y01.BackColor = Color.Transparent;
                    break;
                case "x25y01":
                    x25y01.BackgroundImage = null;
                    x25y01.BackColor = Color.Transparent;
                    break;
                case "x26y01":
                    x26y01.BackgroundImage = null;
                    x26y01.BackColor = Color.Transparent;
                    break;
                case "x27y01":
                    x27y01.BackgroundImage = null;
                    x27y01.BackColor = Color.Transparent;
                    break;
                case "x28y01":
                    x28y01.BackgroundImage = null;
                    x28y01.BackColor = Color.Transparent;
                    break;
                case "x29y01":
                    x29y01.BackgroundImage = null; 
                    x29y01.BackColor = Color.Blue;
                    break;
                case "x30y01":
                    x30y01.BackgroundImage = null;
                    x30y01.BackColor = Color.Blue;
                    break;
                case "x01y02":
                    x01y02.BackgroundImage = null;
                    x01y02.BackColor = Color.Yellow;
                    break;
                case "x02y02":
                    x02y02.BackgroundImage = null;
                    x02y02.BackColor = Color.Transparent;
                    break;
                case "x03y02":
                    x03y02.BackgroundImage = null;
                    x03y02.BackColor = Color.Transparent;
                    break;
                case "x04y02":
                    x04y02.BackgroundImage = null;
                    x04y02.BackColor = Color.Transparent;
                    break;
                case "x05y02":
                    x05y02.BackgroundImage = null;
                    x05y02.BackColor = Color.Transparent;
                    break;
                case "x06y02":
                    x06y02.BackgroundImage = null;
                    x06y02.BackColor = Color.Transparent;
                    break;
                case "x07y02":
                    x07y02.BackgroundImage = null;
                    x07y02.BackColor = Color.Transparent;
                    break;
                case "x08y02":
                    x08y02.BackgroundImage = null;
                    x08y02.BackColor = Color.Transparent;
                    break;
                case "x09y02":
                    x09y02.BackgroundImage = null;
                    x09y02.BackColor = Color.Transparent;
                    break;
                case "x10y02":
                    x10y02.BackgroundImage = null;
                    x10y02.BackColor = Color.Transparent;
                    break;
                case "x11y02":
                    x11y02.BackgroundImage = null;
                    x11y02.BackColor = Color.Transparent;
                    break;
                case "x12y02":
                    x12y02.BackgroundImage = null;
                    x12y02.BackColor = Color.Transparent;
                    break;
                case "x13y02":
                    x13y02.BackgroundImage = null;
                    x13y02.BackColor = Color.Transparent;
                    break;
                case "x14y02":
                    x14y02.BackgroundImage = null;
                    x14y02.BackColor = Color.Transparent;
                    break;
                case "x15y02":
                    x15y02.BackgroundImage = null;
                    x15y02.BackColor = Color.Transparent;
                    break;
                case "x16y02":
                    x16y02.BackgroundImage = null;
                    x16y02.BackColor = Color.Transparent;
                    break;
                case "x17y02":
                    x17y02.BackgroundImage = null;
                    x17y02.BackColor = Color.Transparent;
                    break;
                case "x18y02":
                    x18y02.BackgroundImage = null;
                    x18y02.BackColor = Color.Transparent;
                    break;
                case "x19y02":
                    x19y02.BackgroundImage = null;
                    x19y02.BackColor = Color.Transparent;
                    break;
                case "x20y02":
                    x20y02.BackgroundImage = null;
                    x20y02.BackColor = Color.Transparent;
                    break;
                case "x21y02":
                    x21y02.BackgroundImage = null;
                    x21y02.BackColor = Color.Transparent;
                    break;
                case "x22y02":
                    x22y02.BackgroundImage = null;
                    x22y02.BackColor = Color.Transparent;
                    break;
                case "x23y02":
                    x23y02.BackgroundImage = null;
                    x23y02.BackColor = Color.Transparent;
                    break;
                case "x24y02":
                    x24y02.BackgroundImage = null;
                    x24y02.BackColor = Color.Transparent;
                    break;
                case "x25y02":
                    x25y02.BackgroundImage = null;
                    x25y02.BackColor = Color.Transparent;
                    break;
                case "x26y02":
                    x26y02.BackgroundImage = null;
                    x26y02.BackColor = Color.Transparent;
                    break;
                case "x27y02":
                    x27y02.BackgroundImage = null;
                    x27y02.BackColor = Color.Transparent;
                    break;
                case "x28y02":
                    x28y02.BackgroundImage = null;
                    x28y02.BackColor = Color.Transparent;
                    break;
                case "x29y02":
                    x29y02.BackgroundImage = null;
                    x29y02.BackColor = Color.Transparent;
                    break;
                case "x30y02":
                    x30y02.BackgroundImage = null;
                    x30y02.BackColor = Color.Blue;
                    break;
                case "x01y03":
                    x01y03.BackgroundImage = null;
                    x01y03.BackColor = Color.Transparent;
                    break;
                case "x02y03":
                    x02y03.BackgroundImage = null;
                    x02y03.BackColor = Color.Transparent;
                    break;
                case "x03y03":
                    x03y03.BackgroundImage = null;
                    x03y03.BackColor = Color.Transparent;
                    break;
                case "x04y03":
                    x04y03.BackgroundImage = null;
                    x04y03.BackColor = Color.Transparent;
                    break;
                case "x05y03":
                    x05y03.BackgroundImage = null;
                    x05y03.BackColor = Color.Transparent;
                    break;
                case "x06y03":
                    x06y03.BackgroundImage = null;
                    x06y03.BackColor = Color.Transparent;
                    break;
                case "x07y03":
                    x07y03.BackgroundImage = null;
                    x07y03.BackColor = Color.Transparent;
                    break;
                case "x09y03":
                    x09y03.BackgroundImage = null;
                    x09y03.BackColor = Color.Transparent;
                    break;
                case "x10y03":
                    x10y03.BackgroundImage = null;
                    x10y03.BackColor = Color.Transparent;
                    break;
                case "x11y03":
                    x11y03.BackgroundImage = null;
                    x11y03.BackColor = Color.Transparent;
                    break;
                case "x15y03":
                    x15y03.BackgroundImage = null;
                    x15y03.BackColor = Color.Transparent;
                    break;
                case "x16y03":
                    x16y03.BackgroundImage = null;
                    x16y03.BackColor = Color.Transparent;
                    break;
                case "x20y03":
                    x20y03.BackgroundImage = null;
                    x20y03.BackColor = Color.Transparent;
                    break;
                case "x21y03":
                    x21y03.BackgroundImage = null;
                    x21y03.BackColor = Color.Transparent;
                    break;
                case "x22y03":
                    x22y03.BackgroundImage = null;
                    x22y03.BackColor = Color.Transparent;
                    break;
                case "x24y03":
                    x24y03.BackgroundImage = null;
                    x24y03.BackColor = Color.Transparent;
                    break;
                case "x25y03":
                    x25y03.BackgroundImage = null;
                    x25y03.BackColor = Color.Transparent;
                    break;
                case "x26y03":
                    x26y03.BackgroundImage = null;
                    x26y03.BackColor = Color.Transparent;
                    break;
                case "x27y03":
                    x27y03.BackgroundImage = null;
                    x27y03.BackColor = Color.Transparent;
                    break;
                case "x28y03":
                    x28y03.BackgroundImage = null;
                    x28y03.BackColor = Color.Transparent;
                    break;
                case "x29y03":
                    x29y03.BackgroundImage = null;
                    x29y03.BackColor = Color.Transparent;
                    break;
                case "x30y03":
                    x30y03.BackgroundImage = null;
                    x30y03.BackColor = Color.Transparent;
                    break;
                case "x01y04":
                    x01y04.BackgroundImage = null;
                    x01y04.BackColor = Color.Transparent;
                    break;
                case "x02y04":
                    x02y04.BackgroundImage = null;
                    x02y04.BackColor = Color.Transparent;
                    break;
                case "x03y04":
                    x03y04.BackgroundImage = null;
                    x03y04.BackColor = Color.Transparent;
                    break;
                case "x04y04":
                    x04y04.BackgroundImage = null;
                    x04y04.BackColor = Color.Transparent;
                    break;
                case "x05y04":
                    x05y04.BackgroundImage = null;
                    x05y04.BackColor = Color.Transparent;
                    break;
                case "x06y04":
                    x06y04.BackgroundImage = null;
                    x06y04.BackColor = Color.Transparent;
                    break;
                case "x07y04":
                    x07y04.BackgroundImage = null;
                    x07y04.BackColor = Color.Transparent;
                    break;
                case "x09y04":
                    x09y04.BackgroundImage = null;
                    x09y04.BackColor = Color.Transparent;
                    break;
                case "x10y04":
                    x10y04.BackgroundImage = null;
                    x10y04.BackColor = Color.Transparent;
                    break;
                case "x11y04":
                    x11y04.BackgroundImage = null;
                    x11y04.BackColor = Color.Transparent;
                    break;
                case "x13y04":
                    x13y04.BackgroundImage = null;
                    x13y04.BackColor = Color.Transparent;
                    break;
                case "x14y04":
                    x14y04.BackgroundImage = null;
                    x14y04.BackColor = Color.Transparent;
                    break;
                case "x15y04":
                    x15y04.BackgroundImage = null;
                    x15y04.BackColor = Color.Transparent;
                    break;
                case "x16y04":
                    x16y04.BackgroundImage = null;
                    x16y04.BackColor = Color.Transparent;
                    break;
                case "x17y04":
                    x17y04.BackgroundImage = null;
                    x17y04.BackColor = Color.Transparent;
                    break;
                case "x18y04":
                    x18y04.BackgroundImage = null;
                    x18y04.BackColor = Color.Transparent;
                    break;
                case "x20y04":
                    x20y04.BackgroundImage = null;
                    x20y04.BackColor = Color.Transparent;
                    break;
                case "x21y04":
                    x21y04.BackgroundImage = null;
                    x21y04.BackColor = Color.Transparent;
                    break;
                case "x22y04":
                    x22y04.BackgroundImage = null;
                    x22y04.BackColor = Color.Transparent;
                    break;
                case "x24y04":
                    x24y04.BackgroundImage = null;
                    x24y04.BackColor = Color.Transparent;
                    break;
                case "x25y04":
                    x25y04.BackgroundImage = null;
                    x25y04.BackColor = Color.Transparent;
                    break;
                case "x26y04":
                    x26y04.BackgroundImage = null;
                    x26y04.BackColor = Color.Transparent;
                    break;
                case "x27y04":
                    x27y04.BackgroundImage = null;
                    x27y04.BackColor = Color.Transparent;
                    break;
                case "x28y04":
                    x28y04.BackgroundImage = null;
                    x28y04.BackColor = Color.Transparent;
                    break;
                case "x29y04":
                    x29y04.BackgroundImage = null;
                    x29y04.BackColor = Color.Transparent;
                    break;
                case "x30y04":
                    x30y04.BackgroundImage = null;
                    x30y04.BackColor = Color.Transparent;
                    break;
                case "x01y05":
                    x01y05.BackgroundImage = null;
                    x01y05.BackColor = Color.Transparent;
                    break;
                case "x02y05":
                    x02y05.BackgroundImage = null;
                    x02y05.BackColor = Color.Transparent;
                    break;
                case "x03y05":
                    x03y05.BackgroundImage = null;
                    x03y05.BackColor = Color.Transparent;
                    break;
                case "x04y05":
                    x04y05.BackgroundImage = null;
                    x04y05.BackColor = Color.Transparent;
                    break;
                case "x05y05":
                    x05y05.BackgroundImage = null;
                    x05y05.BackColor = Color.Transparent;
                    break;
                case "x06y05":
                    x06y05.BackgroundImage = null;
                    x06y05.BackColor = Color.Transparent;
                    break;
                case "x07y05":
                    x07y05.BackgroundImage = null;
                    x07y05.BackColor = Color.Transparent;
                    break;
                case "x09y05":
                    x09y05.BackgroundImage = null;
                    x09y05.BackColor = Color.Transparent;
                    break;
                case "x10y05":
                    x10y05.BackgroundImage = null;
                    x10y05.BackColor = Color.Transparent;
                    break;
                case "x11y05":
                    x11y05.BackgroundImage = null;
                    x11y05.BackColor = Color.Transparent;
                    break;
                case "x13y05":
                    x13y05.BackgroundImage = null;
                    x13y05.BackColor = Color.Transparent;
                    break;
                case "x14y05":
                    x14y05.BackgroundImage = null;
                    x14y05.BackColor = Color.Transparent;
                    break;
                case "x15y05":
                    x15y05.BackgroundImage = null;
                    x15y05.BackColor = Color.Transparent;
                    break;
                case "x16y05":
                    x16y05.BackgroundImage = null;
                    x16y05.BackColor = Color.Transparent;
                    break;
                case "x17y05":
                    x17y05.BackgroundImage = null;
                    x17y05.BackColor = Color.Transparent;
                    break;
                case "x18y05":
                    x18y05.BackgroundImage = null;
                    x18y05.BackColor = Color.Transparent;
                    break;
                case "x20y05":
                    x20y05.BackgroundImage = null;
                    x20y05.BackColor = Color.Transparent;
                    break;
                case "x21y05":
                    x21y05.BackgroundImage = null;
                    x21y05.BackColor = Color.Transparent;
                    break;
                case "x22y05":
                    x22y05.BackgroundImage = null;
                    x22y05.BackColor = Color.Transparent;
                    break;
                case "x24y05":
                    x24y05.BackgroundImage = null;
                    x24y05.BackColor = Color.Transparent;
                    break;
                case "x25y05":
                    x25y05.BackgroundImage = null;
                    x25y05.BackColor = Color.Transparent;
                    break;
                case "x26y05":
                    x26y05.BackgroundImage = null;
                    x26y05.BackColor = Color.Transparent;
                    break;
                case "x27y05":
                    x27y05.BackgroundImage = null;
                    x27y05.BackColor = Color.Transparent;
                    break;
                case "x28y05":
                    x28y05.BackgroundImage = null;
                    x28y05.BackColor = Color.Transparent;
                    break;
                case "x29y05":
                    x29y05.BackgroundImage = null;
                    x29y05.BackColor = Color.Transparent;
                    break;
                case "x30y05":
                    x30y05.BackgroundImage = null;
                    x30y05.BackColor = Color.Transparent;
                    break;
                case "x01y06":
                    x01y06.BackgroundImage = null;
                    x01y06.BackColor = Color.Transparent;
                    break;
                case "x02y06":
                    x02y06.BackgroundImage = null;
                    x02y06.BackColor = Color.Transparent;
                    break;
                case "x05y06":
                    x05y06.BackgroundImage = null;
                    x05y06.BackColor = Color.Transparent;
                    break;
                case "x06y06":
                    x06y06.BackgroundImage = null;
                    x06y06.BackColor = Color.Transparent;
                    break;
                case "x10y06":
                    x10y06.BackgroundImage = null;
                    x10y06.BackColor = Color.Transparent;
                    break;
                case "x11y06":
                    x11y06.BackgroundImage = null;
                    x11y06.BackColor = Color.Transparent;
                    break;
                case "x15y06":
                    x15y06.BackgroundImage = null;
                    x15y06.BackColor = Color.Transparent;
                    break;
                case "x16y06":
                    x16y06.BackgroundImage = null;
                    x16y06.BackColor = Color.Transparent;
                    break;
                case "x20y06":
                    x20y06.BackgroundImage = null;
                    x20y06.BackColor = Color.Transparent;
                    break;
                case "x21y06":
                    x21y06.BackgroundImage = null;
                    x21y06.BackColor = Color.Transparent;
                    break;
                case "x25y06":
                    x25y06.BackgroundImage = null;
                    x25y06.BackColor = Color.Transparent;
                    break;
                case "x26y06":
                    x26y06.BackgroundImage = null;
                    x26y06.BackColor = Color.Transparent;
                    break;
                case "x29y06":
                    x29y06.BackgroundImage = null;
                    x29y06.BackColor = Color.Transparent;
                    break;
                case "x30y06":
                    x30y06.BackgroundImage = null;
                    x30y06.BackColor = Color.Transparent;
                    break;
                case "x01y07":
                    x01y07.BackgroundImage = null;
                    x01y07.BackColor = Color.Transparent;
                    break;
                case "x02y07":
                    x02y07.BackgroundImage = null;
                    x02y07.BackColor = Color.Transparent;
                    break;
                case "x04y07":
                    x04y07.BackgroundImage = null;
                    x04y07.BackColor = Color.Transparent;
                    break;
                case "x05y07":
                    x05y07.BackgroundImage = null;
                    x05y07.BackColor = Color.Transparent;
                    break;
                case "x06y07":
                    x06y07.BackgroundImage = null;
                    x06y07.BackColor = Color.Transparent;
                    break;
                case "x07y07":
                    x07y07.BackgroundImage = null;
                    x07y07.BackColor = Color.Transparent;
                    break;
                case "x08y07":
                    x08y07.BackgroundImage = null;
                    x08y07.BackColor = Color.Transparent;
                    break;
                case "x09y07":
                    x09y07.BackgroundImage = null;
                    x09y07.BackColor = Color.Transparent;
                    break;
                case "x10y07":
                    x10y07.BackgroundImage = null;
                    x10y07.BackColor = Color.Transparent;
                    break;
                case "x11y07":
                    x11y07.BackgroundImage = null;
                    x11y07.BackColor = Color.Transparent;
                    break;
                case "x12y07":
                    x12y07.BackgroundImage = null;
                    x12y07.BackColor = Color.Transparent;
                    break;
                case "x13y07":
                    x13y07.BackgroundImage = null;
                    x13y07.BackColor = Color.Transparent;
                    break;
                case "x14y07":
                    x14y07.BackgroundImage = null;
                    x14y07.BackColor = Color.Transparent;
                    break;
                case "x15y07":
                    x15y07.BackgroundImage = null;
                    x15y07.BackColor = Color.Transparent;
                    break;
                case "x16y07":
                    x16y07.BackgroundImage = null;
                    x16y07.BackColor = Color.Transparent;
                    break;
                case "x17y07":
                    x17y07.BackgroundImage = null;
                    x17y07.BackColor = Color.Transparent;
                    break;
                case "x18y07":
                    x18y07.BackgroundImage = null;
                    x18y07.BackColor = Color.Transparent;
                    break;
                case "x19y07":
                    x19y07.BackgroundImage = null;
                    x19y07.BackColor = Color.Transparent;
                    break;
                case "x20y07":
                    x20y07.BackgroundImage = null;
                    x20y07.BackColor = Color.Transparent;
                    break;
                case "x21y07":
                    x21y07.BackgroundImage = null;
                    x21y07.BackColor = Color.Transparent;
                    break;
                case "x22y07":
                    x22y07.BackgroundImage = null;
                    x22y07.BackColor = Color.Transparent;
                    break;
                case "x23y07":
                    x23y07.BackgroundImage = null;
                    x23y07.BackColor = Color.Transparent;
                    break;
                case "x24y07":
                    x24y07.BackgroundImage = null;
                    x24y07.BackColor = Color.Transparent;
                    break;
                case "x25y07":
                    x25y07.BackgroundImage = null;
                    x25y07.BackColor = Color.Transparent;
                    break;
                case "x26y07":
                    x26y07.BackgroundImage = null;
                    x26y07.BackColor = Color.Transparent;
                    break;
                case "x27y07":
                    x27y07.BackgroundImage = null;
                    x27y07.BackColor = Color.Transparent;
                    break;
                case "x29y07":
                    x29y07.BackgroundImage = null;
                    x29y07.BackColor = Color.Transparent;
                    break;
                case "x30y07":
                    x30y07.BackgroundImage = null;
                    x30y07.BackColor = Color.Transparent;
                    break;
                case "x01y08":
                    x01y08.BackgroundImage = null;
                    x01y08.BackColor = Color.Transparent;
                    break;
                case "x02y08":
                    x02y08.BackgroundImage = null;
                    x02y08.BackColor = Color.Transparent;
                    break;
                case "x04y08":
                    x04y08.BackgroundImage = null;
                    x04y08.BackColor = Color.Transparent;
                    break;
                case "x05y08":
                    x05y08.BackgroundImage = null;
                    x05y08.BackColor = Color.Transparent;
                    break;
                case "x06y08":
                    x06y08.BackgroundImage = null;
                    x06y08.BackColor = Color.Transparent;
                    break;
                case "x07y08":
                    x07y08.BackgroundImage = null;
                    x07y08.BackColor = Color.Transparent;
                    break;
                case "x08y08":
                    x08y08.BackgroundImage = null;
                    x08y08.BackColor = Color.Transparent;
                    break;
                case "x09y08":
                    x09y08.BackgroundImage = null;
                    x09y08.BackColor = Color.Transparent;
                    break;
                case "x10y08":
                    x10y08.BackgroundImage = null;
                    x10y08.BackColor = Color.Transparent;
                    break;
                case "x11y08":
                    x11y08.BackgroundImage = null;
                    x11y08.BackColor = Color.Transparent;
                    break;
                case "x12y08":
                    x12y08.BackgroundImage = null;
                    x12y08.BackColor = Color.Transparent;
                    break;
                case "x13y08":
                    x13y08.BackgroundImage = null;
                    x13y08.BackColor = Color.Transparent;
                    break;
                case "x14y08":
                    x14y08.BackgroundImage = null;
                    x14y08.BackColor = Color.Transparent;
                    break;
                case "x15y08":
                    x15y08.BackgroundImage = null;
                    x15y08.BackColor = Color.Transparent;
                    break;
                case "x16y08":
                    x16y08.BackgroundImage = null;
                    x16y08.BackColor = Color.Transparent;
                    break;
                case "x17y08":
                    x17y08.BackgroundImage = null;
                    x17y08.BackColor = Color.Transparent;
                    break;
                case "x18y08":
                    x18y08.BackgroundImage = null;
                    x18y08.BackColor = Color.Transparent;
                    break;
                case "x19y08":
                    x19y08.BackgroundImage = null;
                    x19y08.BackColor = Color.Transparent;
                    break;
                case "x20y08":
                    x20y08.BackgroundImage = null;
                    x20y08.BackColor = Color.Transparent;
                    break;
                case "x21y08":
                    x21y08.BackgroundImage = null;
                    x21y08.BackColor = Color.Transparent;
                    break;
                case "x22y08":
                    x22y08.BackgroundImage = null;
                    x22y08.BackColor = Color.Transparent;
                    break;
                case "x23y08":
                    x23y08.BackgroundImage = null;
                    x23y08.BackColor = Color.Transparent;
                    break;
                case "x24y08":
                    x24y08.BackgroundImage = null;
                    x24y08.BackColor = Color.Transparent;
                    break;
                case "x25y08":
                    x25y08.BackgroundImage = null;
                    x25y08.BackColor = Color.Transparent;
                    break;
                case "x26y08":
                    x26y08.BackgroundImage = null;
                    x26y08.BackColor = Color.Transparent;
                    break;
                case "x27y08":
                    x27y08.BackgroundImage = null;
                    x27y08.BackColor = Color.Transparent;
                    break;
                case "x29y08":
                    x29y08.BackgroundImage = null;
                    x29y08.BackColor = Color.Transparent;
                    break;
                case "x30y08":
                    x30y08.BackgroundImage = null;
                    x30y08.BackColor = Color.Transparent;
                    break;
                case "x01y09":
                    x01y09.BackgroundImage = null;
                    x01y09.BackColor = Color.Transparent;
                    break;
                case "x02y09":
                    x02y09.BackgroundImage = null;
                    x02y09.BackColor = Color.Transparent;
                    break;
                case "x03y09":
                    x03y09.BackgroundImage = null;
                    x03y09.BackColor = Color.Transparent;
                    break;
                case "x04y09":
                    x04y09.BackgroundImage = null;
                    x04y09.BackColor = Color.Transparent;
                    break;
                case "x05y09":
                    x05y09.BackgroundImage = null;
                    x05y09.BackColor = Color.Transparent;
                    break;
                case "x07y09":
                    x07y09.BackgroundImage = null;
                    x07y09.BackColor = Color.Transparent;
                    break;
                case "x08y09":
                    x08y09.BackgroundImage = null;
                    x08y09.BackColor = Color.Transparent;
                    break;
                case "x09y09":
                    x09y09.BackgroundImage = null;
                    x09y09.BackColor = Color.Transparent;
                    break;
                case "x10y09":
                    x10y09.BackgroundImage = null;
                    x10y09.BackColor = Color.Transparent;
                    break;
                case "x11y09":
                    x11y09.BackgroundImage = null;
                    x11y09.BackColor = Color.Transparent;
                    break;
                case "x15y09":
                    x15y09.BackgroundImage = null;
                    x15y09.BackColor = Color.Transparent;
                    break;
                case "x16y09":
                    x16y09.BackgroundImage = null;
                    x16y09.BackColor = Color.Transparent;
                    break;
                case "x20y09":
                    x20y09.BackgroundImage = null;
                    x20y09.BackColor = Color.Transparent;
                    break;
                case "x21y09":
                    x21y09.BackgroundImage = null;
                    x21y09.BackColor = Color.Transparent;
                    break;
                case "x22y09":
                    x22y09.BackgroundImage = null;
                    x22y09.BackColor = Color.Transparent;
                    break;
                case "x23y09":
                    x23y09.BackgroundImage = null;
                    x23y09.BackColor = Color.Transparent;
                    break;
                case "x24y09":
                    x24y09.BackgroundImage = null;
                    x24y09.BackColor = Color.Transparent;
                    break;
                case "x26y09":
                    x26y09.BackgroundImage = null;
                    x26y09.BackColor = Color.Transparent;
                    break;
                case "x27y09":
                    x27y09.BackgroundImage = null;
                    x27y09.BackColor = Color.Transparent;
                    break;
                case "x28y09":
                    x28y09.BackgroundImage = null;
                    x28y09.BackColor = Color.Transparent;
                    break;
                case "x29y09":
                    x29y09.BackgroundImage = null;
                    x29y09.BackColor = Color.Transparent;
                    break;
                case "x30y09":
                    x30y09.BackgroundImage = null;
                    x30y09.BackColor = Color.Transparent;
                    break;
                case "x01y10":
                    x01y10.BackgroundImage = null;
                    x01y10.BackColor = Color.Transparent;
                    break;
                case "x02y10":
                    x02y10.BackgroundImage = null;
                    x02y10.BackColor = Color.Transparent;
                    break;
                case "x03y10":
                    x03y10.BackgroundImage = null;
                    x03y10.BackColor = Color.Transparent;
                    break;
                case "x04y10":
                    x04y10.BackgroundImage = null;
                    x04y10.BackColor = Color.Transparent;
                    break;
                case "x05y10":
                    x05y10.BackgroundImage = null;
                    x05y10.BackColor = Color.Transparent;
                    break;
                case "x07y10":
                    x07y10.BackgroundImage = null;
                    x07y10.BackColor = Color.Transparent;
                    break;
                case "x08y10":
                    x08y10.BackgroundImage = null;
                    x08y10.BackColor = Color.Transparent;
                    break;
                case "x09y10":
                    x09y10.BackgroundImage = null;
                    x09y10.BackColor = Color.Transparent;
                    break;
                case "x10y10":
                    x10y10.BackgroundImage = null;
                    x10y10.BackColor = Color.Transparent;
                    break;
                case "x11y10":
                    x11y10.BackgroundImage = null;
                    x11y10.BackColor = Color.Transparent;
                    break;
                case "x13y10":
                    x13y10.BackgroundImage = null;
                    x13y10.BackColor = Color.Transparent;
                    break;
                case "x14y10":
                    x14y10.BackgroundImage = null;
                    x14y10.BackColor = Color.Transparent;
                    break;
                case "x15y10":
                    x15y10.BackgroundImage = null;
                    x15y10.BackColor = Color.Transparent;
                    break;
                case "x16y10":
                    x16y10.BackgroundImage = null;
                    x16y10.BackColor = Color.Transparent;
                    break;
                case "x17y10":
                    x17y10.BackgroundImage = null;
                    x17y10.BackColor = Color.Transparent;
                    break;
                case "x18y10":
                    x18y10.BackgroundImage = null;
                    x18y10.BackColor = Color.Transparent;
                    break;
                case "x20y10":
                    x20y10.BackgroundImage = null;
                    x20y10.BackColor = Color.Transparent;
                    break;
                case "x21y10":
                    x21y10.BackgroundImage = null;
                    x21y10.BackColor = Color.Transparent;
                    break;
                case "x22y10":
                    x22y10.BackgroundImage = null;
                    x22y10.BackColor = Color.Transparent;
                    break;
                case "x23y10":
                    x23y10.BackgroundImage = null;
                    x23y10.BackColor = Color.Transparent;
                    break;
                case "x24y10":
                    x24y10.BackgroundImage = null;
                    x24y10.BackColor = Color.Transparent;
                    break;
                case "x26y10":
                    x26y10.BackgroundImage = null;
                    x26y10.BackColor = Color.Transparent;
                    break;
                case "x27y10":
                    x27y10.BackgroundImage = null;
                    x27y10.BackColor = Color.Transparent;
                    break;
                case "x28y10":
                    x28y10.BackgroundImage = null;
                    x28y10.BackColor = Color.Transparent;
                    break;
                case "x29y10":
                    x29y10.BackgroundImage = null;
                    x29y10.BackColor = Color.Transparent;
                    break;
                case "x30y10":
                    x30y10.BackgroundImage = null;
                    x30y10.BackColor = Color.Transparent;
                    break;
                case "x01y11":
                    x01y11.BackgroundImage = null;
                    x01y11.BackColor = Color.Transparent;
                    break;
                case "x02y11":
                    x02y11.BackgroundImage = null;
                    x02y11.BackColor = Color.Transparent;
                    break;
                case "x07y11":
                    x07y11.BackgroundImage = null;
                    x07y11.BackColor = Color.Transparent;
                    break;
                case "x08y11":
                    x08y11.BackgroundImage = null;
                    x08y11.BackColor = Color.Transparent;
                    break;
                case "x09y11":
                    x09y11.BackgroundImage = null;
                    x09y11.BackColor = Color.Transparent;
                    break;
                case "x10y11":
                    x10y11.BackgroundImage = null;
                    x10y11.BackColor = Color.Transparent;
                    break;
                case "x11y11":
                    x11y11.BackgroundImage = null;
                    x11y11.BackColor = Color.Transparent;
                    break;
                case "x13y11":
                    x13y11.BackgroundImage = null;
                    x13y11.BackColor = Color.Transparent;
                    break;
                case "x14y11":
                    x14y11.BackgroundImage = null;
                    x14y11.BackColor = Color.Transparent;
                    break;
                case "x15y11":
                    x15y11.BackgroundImage = null;
                    x15y11.BackColor = Color.Transparent;
                    break;
                case "x16y11":
                    x16y11.BackgroundImage = null;
                    x16y11.BackColor = Color.Transparent;
                    break;
                case "x17y11":
                    x17y11.BackgroundImage = null;
                    x17y11.BackColor = Color.Transparent;
                    break;
                case "x18y11":
                    x18y11.BackgroundImage = null;
                    x18y11.BackColor = Color.Transparent;
                    break;
                case "x20y11":
                    x20y11.BackgroundImage = null;
                    x20y11.BackColor = Color.Transparent;
                    break;
                case "x21y11":
                    x21y11.BackgroundImage = null;
                    x21y11.BackColor = Color.Transparent;
                    break;
                case "x22y11":
                    x22y11.BackgroundImage = null;
                    x22y11.BackColor = Color.Transparent;
                    break;
                case "x23y11":
                    x23y11.BackgroundImage = null;
                    x23y11.BackColor = Color.Transparent;
                    break;
                case "x24y11":
                    x24y11.BackgroundImage = null;
                    x24y11.BackColor = Color.Transparent;
                    break;
                case "x29y11":
                    x29y11.BackgroundImage = null;
                    x29y11.BackColor = Color.Transparent;
                    break;
                case "x30y11":
                    x30y11.BackgroundImage = null;
                    x30y11.BackColor = Color.Transparent;
                    break;
                case "x01y12":
                    x01y12.BackgroundImage = null;
                    x01y12.BackColor = Color.Transparent;
                    break;
                case "x02y12":
                    x02y12.BackgroundImage = null;
                    x02y12.BackColor = Color.Transparent;
                    break;
                case "x04y12":
                    x04y12.BackgroundImage = null;
                    x04y12.BackColor = Color.Transparent;
                    break;
                case "x05y12":
                    x05y12.BackgroundImage = null;
                    x05y12.BackColor = Color.Transparent;
                    break;
                case "x06y12":
                    x06y12.BackgroundImage = null;
                    x06y12.BackColor = Color.Transparent;
                    break;
                case "x07y12":
                    x07y12.BackgroundImage = null;
                    x07y12.BackColor = Color.Transparent;
                    break;
                case "x08y12":
                    x08y12.BackgroundImage = null;
                    x08y12.BackColor = Color.Transparent;
                    break;
                case "x09y12":
                    x09y12.BackgroundImage = null;
                    x09y12.BackColor = Color.Transparent;
                    break;
                case "x10y12":
                    x10y12.BackgroundImage = null;
                    x10y12.BackColor = Color.Transparent;
                    break;
                case "x11y12":
                    x11y12.BackgroundImage = null;
                    x11y12.BackColor = Color.Transparent;
                    break;
                case "x13y12":
                    x13y12.BackgroundImage = null;
                    x13y12.BackColor = Color.Transparent;
                    break;
                case "x14y12":
                    x14y12.BackgroundImage = null;
                    x14y12.BackColor = Color.Transparent;
                    break;
                case "x17y12":
                    x17y12.BackgroundImage = null;
                    x17y12.BackColor = Color.Transparent;
                    break;
                case "x18y12":
                    x18y12.BackgroundImage = null;
                    x18y12.BackColor = Color.Transparent;
                    break;
                case "x20y12":
                    x20y12.BackgroundImage = null;
                    x20y12.BackColor = Color.Transparent;
                    break;
                case "x21y12":
                    x21y12.BackgroundImage = null;
                    x21y12.BackColor = Color.Transparent;
                    break;
                case "x22y12":
                    x22y12.BackgroundImage = null;
                    x22y12.BackColor = Color.Transparent;
                    break;
                case "x23y12":
                    x23y12.BackgroundImage = null;
                    x23y12.BackColor = Color.Transparent;
                    break;
                case "x24y12":
                    x24y12.BackgroundImage = null;
                    x24y12.BackColor = Color.Transparent;
                    break;
                case "x25y12":
                    x25y12.BackgroundImage = null;
                    x25y12.BackColor = Color.Transparent;
                    break;
                case "x26y12":
                    x26y12.BackgroundImage = null;
                    x26y12.BackColor = Color.Transparent;
                    break;
                case "x27y12":
                    x27y12.BackgroundImage = null;
                    x27y12.BackColor = Color.Transparent;
                    break;
                case "x29y12":
                    x29y12.BackgroundImage = null;
                    x29y12.BackColor = Color.Transparent;
                    break;
                case "x30y12":
                    x30y12.BackgroundImage = null;
                    x30y12.BackColor = Color.Transparent;
                    break;
                case "x00y13":
                    x00y13.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x00y13.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y13":
                    x01y13.BackgroundImage = null;
                    x01y13.BackColor = Color.Transparent;
                    break;
                case "x02y13":
                    x02y13.BackgroundImage = null;
                    x02y13.BackColor = Color.Transparent;
                    break;
                case "x04y13":
                    x04y13.BackgroundImage = null;
                    x04y13.BackColor = Color.Transparent;
                    break;
                case "x05y13":
                    x05y13.BackgroundImage = null;
                    x05y13.BackColor = Color.Transparent;
                    break;
                case "x06y13":
                    x06y13.BackgroundImage = null;
                    x06y13.BackColor = Color.Transparent;
                    break;
                case "x07y13":
                    x07y13.BackgroundImage = null;
                    x07y13.BackColor = Color.Transparent;
                    break;
                case "x08y13":
                    x08y13.BackgroundImage = null;
                    x08y13.BackColor = Color.Transparent;
                    break;
                case "x10y13":
                    x10y13.BackgroundImage = null;
                    x10y13.BackColor = Color.Transparent;
                    break;
                case "x11y13":
                    x11y13.BackgroundImage = null;
                    x11y13.BackColor = Color.Transparent;
                    break;
                case "x12y13":
                    x12y13.BackgroundImage = null;
                    x12y13.BackColor = Color.Transparent;
                    break;
                case "x13y13":
                    x13y13.BackgroundImage = null;
                    x13y13.BackColor = Color.Transparent;
                    break;
                case "x14y13":
                    x14y13.BackgroundImage = null;
                    x14y13.BackColor = Color.Transparent;
                    break;
                case "x15y13":
                    x15y13.BackgroundImage = null;
                    x15y13.BackColor = Color.Transparent;
                    break;
                case "x16y13":
                    x16y13.BackgroundImage = null;
                    x16y13.BackColor = Color.Transparent;
                    break;
                case "x17y13":
                    x17y13.BackgroundImage = null;
                    x17y13.BackColor = Color.Transparent;
                    break;
                case "x18y13":
                    x18y13.BackgroundImage = null;
                    x18y13.BackColor = Color.Transparent;
                    break;
                case "x19y13":
                    x19y13.BackgroundImage = null;
                    x19y13.BackColor = Color.Transparent;
                    break;
                case "x20y13":
                    x20y13.BackgroundImage = null;
                    x20y13.BackColor = Color.Transparent;
                    break;
                case "x21y13":
                    x21y13.BackgroundImage = null;
                    x21y13.BackColor = Color.Transparent;
                    break;
                case "x23y13":
                    x23y13.BackgroundImage = null;
                    x23y13.BackColor = Color.Transparent;
                    break;
                case "x24y13":
                    x24y13.BackgroundImage = null;
                    x24y13.BackColor = Color.Transparent;
                    break;
                case "x25y13":
                    x25y13.BackgroundImage = null;
                    x25y13.BackColor = Color.Transparent;
                    break;
                case "x26y13":
                    x26y13.BackgroundImage = null;
                    x26y13.BackColor = Color.Transparent;
                    break;
                case "x27y13":
                    x27y13.BackgroundImage = null;
                    x27y13.BackColor = Color.Transparent;
                    break;
                case "x29y13":
                    x29y13.BackgroundImage = null;
                    x29y13.BackColor = Color.Transparent;
                    break;
                case "x30y13":
                    x30y13.BackgroundImage = null;
                    x30y13.BackColor = Color.Transparent;
                    break;
                case "x31y13":
                    x31y13.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x31y13.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x00y14":
                    x00y14.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x00y14.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y14":
                    x01y14.BackgroundImage = null;
                    x01y14.BackColor = Color.Transparent;
                    break;
                case "x02y14":
                    x02y14.BackgroundImage = null;
                    x02y14.BackColor = Color.Transparent;
                    break;
                case "x04y14":
                    x04y14.BackgroundImage = null;
                    x04y14.BackColor = Color.Transparent;
                    break;
                case "x05y14":
                    x05y14.BackgroundImage = null;
                    x05y14.BackColor = Color.Transparent;
                    break;
                case "x06y14":
                    x06y14.BackgroundImage = null;
                    x06y14.BackColor = Color.Transparent;
                    break;
                case "x10y14":
                    x10y14.BackgroundImage = null;
                    x10y14.BackColor = Color.Transparent;
                    break;
                case "x11y14":
                    x11y14.BackgroundImage = null;
                    x11y14.BackColor = Color.Transparent;
                    break;
                case "x12y14":
                    x12y14.BackgroundImage = null;
                    x12y14.BackColor = Color.Transparent;
                    break;
                case "x13y14":
                    x13y14.BackgroundImage = null;
                    x13y14.BackColor = Color.Transparent;
                    break;
                case "x14y14":
                    x14y14.BackgroundImage = null;
                    x14y14.BackColor = Color.Yellow;
                    break;
                case "x15y14":
                    x15y14.BackgroundImage = null;
                    x15y14.BackColor = Color.Yellow;
                    break;
                case "x16y14":
                    x16y14.BackgroundImage = null;
                    x16y14.BackColor = Color.Blue;
                    break;
                case "x17y14":
                    x17y14.BackgroundImage = null;
                    x17y14.BackColor = Color.Transparent;
                    break;
                case "x18y14":
                    x18y14.BackgroundImage = null;
                    x18y14.BackColor = Color.Transparent;
                    break;
                case "x19y14":
                    x19y14.BackgroundImage = null;
                    x19y14.BackColor = Color.Transparent;
                    break;
                case "x20y14":
                    x20y14.BackgroundImage = null;
                    x20y14.BackColor = Color.Transparent;
                    break;
                case "x21y14":
                    x21y14.BackgroundImage = null;
                    x21y14.BackColor = Color.Transparent;
                    break;
                case "x25y14":
                    x25y14.BackgroundImage = null;
                    x25y14.BackColor = Color.Transparent;
                    break;
                case "x26y14":
                    x26y14.BackgroundImage = null;
                    x26y14.BackColor = Color.Transparent;
                    break;
                case "x27y14":
                    x27y14.BackgroundImage = null;
                    x27y14.BackColor = Color.Transparent;
                    break;
                case "x29y14":
                    x29y14.BackgroundImage = null;
                    x29y14.BackColor = Color.Transparent;
                    break;
                case "x30y14":
                    x30y14.BackgroundImage = null;
                    x30y14.BackColor = Color.Transparent;
                    break;
                case "x31y14":
                    x31y14.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x31y14.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y15":
                    x01y15.BackgroundImage = null;
                    x01y15.BackColor = Color.Transparent;
                    break;
                case "x02y15":
                    x02y15.BackgroundImage = null;
                    x02y15.BackColor = Color.Transparent;
                    break;
                case "x03y15":
                    x03y15.BackgroundImage = null;
                    x03y15.BackColor = Color.Transparent;
                    break;
                case "x04y15":
                    x04y15.BackgroundImage = null;
                    x04y15.BackColor = Color.Transparent;
                    break;
                case "x05y15":
                    x05y15.BackgroundImage = null;
                    x05y15.BackColor = Color.Transparent;
                    break;
                case "x06y15":
                    x06y15.BackgroundImage = null;
                    x06y15.BackColor = Color.Transparent;
                    break;
                case "x07y15":
                    x07y15.BackgroundImage = null;
                    x07y15.BackColor = Color.Transparent;
                    break;
                case "x08y15":
                    x08y15.BackgroundImage = null;
                    x08y15.BackColor = Color.Transparent;
                    break;
                case "x09y15":
                    x09y15.BackgroundImage = null;
                    x09y15.BackColor = Color.Transparent;
                    break;
                case "x10y15":
                    x10y15.BackgroundImage = null;
                    x10y15.BackColor = Color.Transparent;
                    break;
                case "x11y15":
                    x11y15.BackgroundImage = null;
                    x11y15.BackColor = Color.Transparent;
                    break;
                case "x13y15":
                    x13y15.BackgroundImage = null;
                    x13y15.BackColor = Color.Transparent;
                    break;
                case "x14y15":
                    x14y15.BackgroundImage = null;
                    x14y15.BackColor = Color.Yellow;
                    break;
                case "x17y15":
                    x17y15.BackgroundImage = null;
                    x17y15.BackColor = Color.Blue;
                    break;
                case "x18y15":
                    x18y15.BackgroundImage = null;
                    x18y15.BackColor = Color.Transparent;
                    break;
                case "x20y15":
                    x20y15.BackgroundImage = null;
                    x20y15.BackColor = Color.Transparent;
                    break;
                case "x21y15":
                    x21y15.BackgroundImage = null;
                    x21y15.BackColor = Color.Transparent;
                    break;
                case "x22y15":
                    x22y15.BackgroundImage = null;
                    x22y15.BackColor = Color.Transparent;
                    break;
                case "x23y15":
                    x23y15.BackgroundImage = null;
                    x23y15.BackColor = Color.Transparent;
                    break;
                case "x24y15":
                    x24y15.BackgroundImage = null;
                    x24y15.BackColor = Color.Transparent;
                    break;
                case "x25y15":
                    x25y15.BackgroundImage = null;
                    x25y15.BackColor = Color.Transparent;
                    break;
                case "x26y15":
                    x26y15.BackgroundImage = null;
                    x26y15.BackColor = Color.Transparent;
                    break;
                case "x27y15":
                    x27y15.BackgroundImage = null;
                    x27y15.BackColor = Color.Transparent;
                    break;
                case "x28y15":
                    x28y15.BackgroundImage = null;
                    x28y15.BackColor = Color.Transparent;
                    break;
                case "x29y15":
                    x29y15.BackgroundImage = null;
                    x29y15.BackColor = Color.Transparent;
                    break;
                case "x30y15":
                    x30y15.BackgroundImage = null;
                    x30y15.BackColor = Color.Transparent;
                    break;
                case "x01y16":
                    x01y16.BackgroundImage = null;
                    x01y16.BackColor = Color.Transparent;
                    break;
                case "x02y16":
                    x02y16.BackgroundImage = null;
                    x02y16.BackColor = Color.Transparent;
                    break;
                case "x03y16":
                    x03y16.BackgroundImage = null;
                    x03y16.BackColor = Color.Transparent;
                    break;
                case "x04y16":
                    x04y16.BackgroundImage = null;
                    x04y16.BackColor = Color.Transparent;
                    break;
                case "x05y16":
                    x05y16.BackgroundImage = null;
                    x05y16.BackColor = Color.Transparent;
                    break;
                case "x06y16":
                    x06y16.BackgroundImage = null;
                    x06y16.BackColor = Color.Transparent;
                    break;
                case "x07y16":
                    x07y16.BackgroundImage = null;
                    x07y16.BackColor = Color.Transparent;
                    break;
                case "x08y16":
                    x08y16.BackgroundImage = null;
                    x08y16.BackColor = Color.Transparent;
                    break;
                case "x09y16":
                    x09y16.BackgroundImage = null;
                    x09y16.BackColor = Color.Transparent;
                    break;
                case "x10y16":
                    x10y16.BackgroundImage = null;
                    x10y16.BackColor = Color.Transparent;
                    break;
                case "x11y16":
                    x11y16.BackgroundImage = null;
                    x11y16.BackColor = Color.Transparent;
                    break;
                case "x13y16":
                    x13y16.BackgroundImage = null;
                    x13y16.BackColor = Color.Transparent;
                    break;
                case "x14y16":
                    x14y16.BackgroundImage = null;
                    x14y16.BackColor = Color.Red;
                    break;
                case "x17y16":
                    x17y16.BackgroundImage = null;
                    x17y16.BackColor = Color.White;
                    break;
                case "x18y16":
                    x18y16.BackgroundImage = null;
                    x18y16.BackColor = Color.Transparent;
                    break;
                case "x20y16":
                    x20y16.BackgroundImage = null;
                    x20y16.BackColor = Color.Transparent;
                    break;
                case "x21y16":
                    x21y16.BackgroundImage = null;
                    x21y16.BackColor = Color.Transparent;
                    break;
                case "x22y16":
                    x22y16.BackgroundImage = null;
                    x22y16.BackColor = Color.Transparent;
                    break;
                case "x23y16":
                    x23y16.BackgroundImage = null;
                    x23y16.BackColor = Color.Transparent;
                    break;
                case "x24y16":
                    x24y16.BackgroundImage = null;
                    x24y16.BackColor = Color.Transparent;
                    break;
                case "x25y16":
                    x25y16.BackgroundImage = null;
                    x25y16.BackColor = Color.Transparent;
                    break;
                case "x26y16":
                    x26y16.BackgroundImage = null;
                    x26y16.BackColor = Color.Transparent;
                    break;
                case "x27y16":
                    x27y16.BackgroundImage = null;
                    x27y16.BackColor = Color.Transparent;
                    break;
                case "x28y16":
                    x28y16.BackgroundImage = null;
                    x28y16.BackColor = Color.Transparent;
                    break;
                case "x29y16":
                    x29y16.BackgroundImage = null;
                    x29y16.BackColor = Color.Transparent;
                    break;
                case "x30y16":
                    x30y16.BackgroundImage = null;
                    x30y16.BackColor = Color.Transparent;
                    break;
                case "x00y17":
                    x00y17.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x00y17.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y17":
                    x01y17.BackgroundImage = null;
                    x01y17.BackColor = Color.Transparent;
                    break;
                case "x02y17":
                    x02y17.BackgroundImage = null;
                    x02y17.BackColor = Color.Transparent;
                    break;
                case "x04y17":
                    x04y17.BackgroundImage = null;
                    x04y17.BackColor = Color.Transparent;
                    break;
                case "x05y17":
                    x05y17.BackgroundImage = null;
                    x05y17.BackColor = Color.Transparent;
                    break;
                case "x06y17":
                    x06y17.BackgroundImage = null;
                    x06y17.BackColor = Color.Transparent;
                    break;
                case "x10y17":
                    x10y17.BackgroundImage = null;
                    x10y17.BackColor = Color.Transparent;
                    break;
                case "x11y17":
                    x11y17.BackgroundImage = null;
                    x11y17.BackColor = Color.Transparent;
                    break;
                case "x12y17":
                    x12y17.BackgroundImage = null;
                    x12y17.BackColor = Color.Transparent;
                    break;
                case "x13y17":
                    x13y17.BackgroundImage = null;
                    x13y17.BackColor = Color.Transparent;
                    break;
                case "x14y17":
                    x14y17.BackgroundImage = null;
                    x14y17.BackColor = Color.Red;
                    break;
                case "x15y17":
                    x15y17.BackgroundImage = null;
                    x15y17.BackColor = Color.Red;
                    break;
                case "x16y17":
                    x16y17.BackgroundImage = null;
                    x16y17.BackColor = Color.White;
                    break;
                case "x17y17":
                    x17y17.BackgroundImage = null;
                    x17y17.BackColor = Color.White;
                    break;
                case "x18y17":
                    x18y17.BackgroundImage = null;
                    x18y17.BackColor = Color.Transparent;
                    break;
                case "x19y17":
                    x19y17.BackgroundImage = null;
                    x19y17.BackColor = Color.Transparent;
                    break;
                case "x20y17":
                    x20y17.BackgroundImage = null;
                    x20y17.BackColor = Color.Transparent;
                    break;
                case "x21y17":
                    x21y17.BackgroundImage = null;
                    x21y17.BackColor = Color.Transparent;
                    break;
                case "x25y17":
                    x25y17.BackgroundImage = null;
                    x25y17.BackColor = Color.Transparent;
                    break;
                case "x26y17":
                    x26y17.BackgroundImage = null;
                    x26y17.BackColor = Color.Transparent;
                    break;
                case "x27y17":
                    x27y17.BackgroundImage = null;
                    x27y17.BackColor = Color.Transparent;
                    break;
                case "x29y17":
                    x29y17.BackgroundImage = null;
                    x29y17.BackColor = Color.Transparent;
                    break;
                case "x30y17":
                    x30y17.BackgroundImage = null;
                    x30y17.BackColor = Color.Transparent;
                    break;
                case "x31y17":
                    x31y17.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x31y17.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x00y18":
                    x00y18.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x00y18.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y18":
                    x01y18.BackgroundImage = null;
                    x01y18.BackColor = Color.Transparent;
                    break;
                case "x02y18":
                    x02y18.BackgroundImage = null;
                    x02y18.BackColor = Color.Transparent;
                    break;
                case "x04y18":
                    x04y18.BackgroundImage = null;
                    x04y18.BackColor = Color.Transparent;
                    break;
                case "x05y18":
                    x05y18.BackgroundImage = null;
                    x05y18.BackColor = Color.Transparent;
                    break;
                case "x06y18":
                    x06y18.BackgroundImage = null;
                    x06y18.BackColor = Color.Transparent;
                    break;
                case "x07y18":
                    x07y18.BackgroundImage = null;
                    x07y18.BackColor = Color.Transparent;
                    break;
                case "x08y18":
                    x08y18.BackgroundImage = null;
                    x08y18.BackColor = Color.Transparent;
                    break;
                case "x10y18":
                    x10y18.BackgroundImage = null;
                    x10y18.BackColor = Color.Transparent;
                    break;
                case "x11y18":
                    x11y18.BackgroundImage = null;
                    x11y18.BackColor = Color.Transparent;
                    break;
                case "x12y18":
                    x12y18.BackgroundImage = null;
                    x12y18.BackColor = Color.Transparent;
                    break;
                case "x13y18":
                    x13y18.BackgroundImage = null;
                    x13y18.BackColor = Color.Transparent;
                    break;
                case "x14y18":
                    x14y18.BackgroundImage = null;
                    x14y18.BackColor = Color.Transparent;
                    break;
                case "x15y18":
                    x15y18.BackgroundImage = null;
                    x15y18.BackColor = Color.Transparent;
                    break;
                case "x16y18":
                    x16y18.BackgroundImage = null;
                    x16y18.BackColor = Color.Transparent;
                    break;
                case "x17y18":
                    x17y18.BackgroundImage = null;
                    x17y18.BackColor = Color.Transparent;
                    break;
                case "x18y18":
                    x18y18.BackgroundImage = null;
                    x18y18.BackColor = Color.Transparent;
                    break;
                case "x19y18":
                    x19y18.BackgroundImage = null;
                    x19y18.BackColor = Color.Transparent;
                    break;
                case "x20y18":
                    x20y18.BackgroundImage = null;
                    x20y18.BackColor = Color.Transparent;
                    break;
                case "x21y18":
                    x21y18.BackgroundImage = null;
                    x21y18.BackColor = Color.Transparent;
                    break;
                case "x23y18":
                    x23y18.BackgroundImage = null;
                    x23y18.BackColor = Color.Transparent;
                    break;
                case "x24y18":
                    x24y18.BackgroundImage = null;
                    x24y18.BackColor = Color.Transparent;
                    break;
                case "x25y18":
                    x25y18.BackgroundImage = null;
                    x25y18.BackColor = Color.Transparent;
                    break;
                case "x26y18":
                    x26y18.BackgroundImage = null;
                    x26y18.BackColor = Color.Transparent;
                    break;
                case "x27y18":
                    x27y18.BackgroundImage = null;
                    x27y18.BackColor = Color.Transparent;
                    break;
                case "x29y18":
                    x29y18.BackgroundImage = null;
                    x29y18.BackColor = Color.Transparent;
                    break;
                case "x30y18":
                    x30y18.BackgroundImage = null;
                    x30y18.BackColor = Color.Transparent;
                    break;
                case "x31y18":
                    x31y18.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x31y18.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x01y19":
                    x01y19.BackgroundImage = null;
                    x01y19.BackColor = Color.Transparent;
                    break;
                case "x02y19":
                    x02y19.BackgroundImage = null;
                    x02y19.BackColor = Color.Transparent;
                    break;
                case "x04y19":
                    x04y19.BackgroundImage = null;
                    x04y19.BackColor = Color.Transparent;
                    break;
                case "x05y19":
                    x05y19.BackgroundImage = null;
                    x05y19.BackColor = Color.Transparent;
                    break;
                case "x06y19":
                    x06y19.BackgroundImage = null;
                    x06y19.BackColor = Color.Transparent;
                    break;
                case "x07y19":
                    x07y19.BackgroundImage = null;
                    x07y19.BackColor = Color.Transparent;
                    break;
                case "x08y19":
                    x08y19.BackgroundImage = null;
                    x08y19.BackColor = Color.Transparent;
                    break;
                case "x09y19":
                    x09y19.BackgroundImage = null;
                    x09y19.BackColor = Color.Transparent;
                    break;
                case "x10y19":
                    x10y19.BackgroundImage = null;
                    x10y19.BackColor = Color.Transparent;
                    break;
                case "x11y19":
                    x11y19.BackgroundImage = null;
                    x11y19.BackColor = Color.Transparent;
                    break;
                case "x13y19":
                    x13y19.BackgroundImage = null;
                    x13y19.BackColor = Color.Transparent;
                    break;
                case "x14y19":
                    x14y19.BackgroundImage = null;
                    x14y19.BackColor = Color.Transparent;
                    break;
                case "x17y19":
                    x17y19.BackgroundImage = null;
                    x17y19.BackColor = Color.Transparent;
                    break;
                case "x18y19":
                    x18y19.BackgroundImage = null;
                    x18y19.BackColor = Color.Transparent;
                    break;
                case "x20y19":
                    x20y19.BackgroundImage = null;
                    x20y19.BackColor = Color.Transparent;
                    break;
                case "x21y19":
                    x21y19.BackgroundImage = null;
                    x21y19.BackColor = Color.Transparent;
                    break;
                case "x22y19":
                    x22y19.BackgroundImage = null;
                    x22y19.BackColor = Color.Transparent;
                    break;
                case "x23y19":
                    x23y19.BackgroundImage = null;
                    x23y19.BackColor = Color.Transparent;
                    break;
                case "x24y19":
                    x24y19.BackgroundImage = null;
                    x24y19.BackColor = Color.Transparent;
                    break;
                case "x25y19":
                    x25y19.BackgroundImage = null;
                    x25y19.BackColor = Color.Transparent;
                    break;
                case "x26y19":
                    x26y19.BackgroundImage = null;
                    x26y19.BackColor = Color.Transparent;
                    break;
                case "x27y19":
                    x27y19.BackgroundImage = null;
                    x27y19.BackColor = Color.Transparent;
                    break;
                case "x29y19":
                    x29y19.BackgroundImage = null;
                    x29y19.BackColor = Color.Transparent;
                    break;
                case "x30y19":
                    x30y19.BackgroundImage = null;
                    x30y19.BackColor = Color.Transparent;
                    break;
                case "x01y20":
                    x01y20.BackgroundImage = null;
                    x01y20.BackColor = Color.Transparent;
                    break;
                case "x02y20":
                    x02y20.BackgroundImage = null;
                    x02y20.BackColor = Color.Transparent;
                    break;
                case "x07y20":
                    x07y20.BackgroundImage = null;
                    x07y20.BackColor = Color.Transparent;
                    break;
                case "x08y20":
                    x08y20.BackgroundImage = null;
                    x08y20.BackColor = Color.Transparent;
                    break;
                case "x09y20":
                    x09y20.BackgroundImage = null;
                    x09y20.BackColor = Color.Transparent;
                    break;
                case "x10y20":
                    x10y20.BackgroundImage = null;
                    x10y20.BackColor = Color.Transparent;
                    break;
                case "x11y20":
                    x11y20.BackgroundImage = null;
                    x11y20.BackColor = Color.Transparent;
                    break;
                case "x13y20":
                    x13y20.BackgroundImage = null;
                    x13y20.BackColor = Color.Transparent;
                    break;
                case "x14y20":
                    x14y20.BackgroundImage = null;
                    x14y20.BackColor = Color.Transparent;
                    break;
                case "x15y20":
                    x15y20.BackgroundImage = null;
                    x15y20.BackColor = Color.Transparent;
                    break;
                case "x16y20":
                    x16y20.BackgroundImage = null;
                    x16y20.BackColor = Color.Transparent;
                    break;
                case "x17y20":
                    x17y20.BackgroundImage = null;
                    x17y20.BackColor = Color.Transparent;
                    break;
                case "x18y20":
                    x18y20.BackgroundImage = null;
                    x18y20.BackColor = Color.Transparent;
                    break;
                case "x20y20":
                    x20y20.BackgroundImage = null;
                    x20y20.BackColor = Color.Transparent;
                    break;
                case "x21y20":
                    x21y20.BackgroundImage = null;
                    x21y20.BackColor = Color.Transparent;
                    break;
                case "x22y20":
                    x22y20.BackgroundImage = null;
                    x22y20.BackColor = Color.Transparent;
                    break;
                case "x23y20":
                    x23y20.BackgroundImage = null;
                    x23y20.BackColor = Color.Transparent;
                    break;
                case "x24y20":
                    x24y20.BackgroundImage = null;
                    x24y20.BackColor = Color.Transparent;
                    break;
                case "x29y20":
                    x29y20.BackgroundImage = null;
                    x29y20.BackColor = Color.Transparent;
                    break;
                case "x30y20":
                    x30y20.BackgroundImage = null;
                    x30y20.BackColor = Color.Transparent;
                    break;
                case "x01y21":
                    x01y21.BackgroundImage = null;
                    x01y21.BackColor = Color.Transparent;
                    break;
                case "x02y21":
                    x02y21.BackgroundImage = null;
                    x02y21.BackColor = Color.Transparent;
                    break;
                case "x03y21":
                    x03y21.BackgroundImage = null;
                    x03y21.BackColor = Color.Transparent;
                    break;
                case "x04y21":
                    x04y21.BackgroundImage = null;
                    x04y21.BackColor = Color.Transparent;
                    break;
                case "x05y21":
                    x05y21.BackgroundImage = null;
                    x05y21.BackColor = Color.Transparent;
                    break;
                case "x07y21":
                    x07y21.BackgroundImage = null;
                    x07y21.BackColor = Color.Transparent;
                    break;
                case "x08y21":
                    x08y21.BackgroundImage = null;
                    x08y21.BackColor = Color.Transparent;
                    break;
                case "x09y21":
                    x09y21.BackgroundImage = null;
                    x09y21.BackColor = Color.Transparent;
                    break;
                case "x10y21":
                    x10y21.BackgroundImage = null;
                    x10y21.BackColor = Color.Transparent;
                    break;
                case "x11y21":
                    x11y21.BackgroundImage = null;
                    x11y21.BackColor = Color.Transparent;
                    break;
                case "x13y21":
                    x13y21.BackgroundImage = null;
                    x13y21.BackColor = Color.Transparent;
                    break;
                case "x14y21":
                    x14y21.BackgroundImage = null;
                    x14y21.BackColor = Color.Transparent;
                    break;
                case "x15y21":
                    x15y21.BackgroundImage = null;
                    x15y21.BackColor = Color.Transparent;
                    break;
                case "x16y21":
                    x16y21.BackgroundImage = null;
                    x16y21.BackColor = Color.Transparent;
                    break;
                case "x17y21":
                    x17y21.BackgroundImage = null;
                    x17y21.BackColor = Color.Transparent;
                    break;
                case "x18y21":
                    x18y21.BackgroundImage = null;
                    x18y21.BackColor = Color.Transparent;
                    break;
                case "x20y21":
                    x20y21.BackgroundImage = null;
                    x20y21.BackColor = Color.Transparent;
                    break;
                case "x21y21":
                    x21y21.BackgroundImage = null;
                    x21y21.BackColor = Color.Transparent;
                    break;
                case "x22y21":
                    x22y21.BackgroundImage = null;
                    x22y21.BackColor = Color.Transparent;
                    break;
                case "x23y21":
                    x23y21.BackgroundImage = null;
                    x23y21.BackColor = Color.Transparent;
                    break;
                case "x24y21":
                    x24y21.BackgroundImage = null;
                    x24y21.BackColor = Color.Transparent;
                    break;
                case "x26y21":
                    x26y21.BackgroundImage = null;
                    x26y21.BackColor = Color.Transparent;
                    break;
                case "x27y21":
                    x27y21.BackgroundImage = null;
                    x27y21.BackColor = Color.Transparent;
                    break;
                case "x28y21":
                    x28y21.BackgroundImage = null;
                    x28y21.BackColor = Color.Transparent;
                    break;
                case "x29y21":
                    x29y21.BackgroundImage = null;
                    x29y21.BackColor = Color.Transparent;
                    break;
                case "x30y21":
                    x30y21.BackgroundImage = null;
                    x30y21.BackColor = Color.Transparent;
                    break;
                case "x01y22":
                    x01y22.BackgroundImage = null;
                    x01y22.BackColor = Color.Transparent;
                    break;
                case "x02y22":
                    x02y22.BackgroundImage = null;
                    x02y22.BackColor = Color.Transparent;
                    break;
                case "x03y22":
                    x03y22.BackgroundImage = null;
                    x03y22.BackColor = Color.Transparent;
                    break;
                case "x04y22":
                    x04y22.BackgroundImage = null;
                    x04y22.BackColor = Color.Transparent;
                    break;
                case "x05y22":
                    x05y22.BackgroundImage = null;
                    x05y22.BackColor = Color.Transparent;
                    break;
                case "x07y22":
                    x07y22.BackgroundImage = null;
                    x07y22.BackColor = Color.Transparent;
                    break;
                case "x08y22":
                    x08y22.BackgroundImage = null;
                    x08y22.BackColor = Color.Transparent;
                    break;
                case "x09y22":
                    x09y22.BackgroundImage = null;
                    x09y22.BackColor = Color.Transparent;
                    break;
                case "x10y22":
                    x10y22.BackgroundImage = null;
                    x10y22.BackColor = Color.Transparent;
                    break;
                case "x11y22":
                    x11y22.BackgroundImage = null;
                    x11y22.BackColor = Color.Transparent;
                    break;
                case "x15y22":
                    x15y22.BackgroundImage = null;
                    x15y22.BackColor = Color.Transparent;
                    break;
                case "x16y22":
                    x16y22.BackgroundImage = null;
                    x16y22.BackColor = Color.Transparent;
                    break;
                case "x20y22":
                    x20y22.BackgroundImage = null;
                    x20y22.BackColor = Color.Transparent;
                    break;
                case "x21y22":
                    x21y22.BackgroundImage = null;
                    x21y22.BackColor = Color.Transparent;
                    break;
                case "x22y22":
                    x22y22.BackgroundImage = null;
                    x22y22.BackColor = Color.Transparent;
                    break;
                case "x23y22":
                    x23y22.BackgroundImage = null;
                    x23y22.BackColor = Color.Transparent;
                    break;
                case "x24y22":
                    x24y22.BackgroundImage = null;
                    x24y22.BackColor = Color.Transparent;
                    break;
                case "x26y22":
                    x26y22.BackgroundImage = null;
                    x26y22.BackColor = Color.Transparent;
                    break;
                case "x27y22":
                    x27y22.BackgroundImage = null;
                    x27y22.BackColor = Color.Transparent;
                    break;
                case "x28y22":
                    x28y22.BackgroundImage = null;
                    x28y22.BackColor = Color.Transparent;
                    break;
                case "x29y22":
                    x29y22.BackgroundImage = null;
                    x29y22.BackColor = Color.Transparent;
                    x29y22.Focus();
                    break;
                case "x30y22":
                    x30y22.BackgroundImage = null;
                    x30y22.BackColor = Color.Transparent;
                    break;
                case "x01y23":
                    x01y23.BackgroundImage = null;
                    x01y23.BackColor = Color.Transparent;
                    break;
                case "x02y23":
                    x02y23.BackgroundImage = null;
                    x02y23.BackColor = Color.Transparent;
                    break;
                case "x04y23":
                    x04y23.BackgroundImage = null;
                    x04y23.BackColor = Color.Transparent;
                    break;
                case "x05y23":
                    x05y23.BackgroundImage = null;
                    x05y23.BackColor = Color.Transparent;
                    break;
                case "x06y23":
                    x06y23.BackgroundImage = null;
                    x06y23.BackColor = Color.Transparent;
                    break;
                case "x07y23":
                    x07y23.BackgroundImage = null;
                    x07y23.BackColor = Color.Transparent;
                    break;
                case "x08y23":
                    x08y23.BackgroundImage = null;
                    x08y23.BackColor = Color.Transparent;
                    break;
                case "x09y23":
                    x09y23.BackgroundImage = null;
                    x09y23.BackColor = Color.Transparent;
                    break;
                case "x10y23":
                    x10y23.BackgroundImage = null;
                    x10y23.BackColor = Color.Transparent;
                    break;
                case "x11y23":
                    x11y23.BackgroundImage = null;
                    x11y23.BackColor = Color.Transparent;
                    break;
                case "x12y23":
                    x12y23.BackgroundImage = null;
                    x12y23.BackColor = Color.Transparent;
                    break;
                case "x13y23":
                    x13y23.BackgroundImage = null;
                    x13y23.BackColor = Color.Transparent;
                    break;
                case "x14y23":
                    x14y23.BackgroundImage = null;
                    x14y23.BackColor = Color.Transparent;
                    break;
                case "x15y23":
                    x15y23.BackgroundImage = null;
                    x15y23.BackColor = Color.Transparent;
                    break;
                case "x16y23":
                    x16y23.BackgroundImage = null;
                    x16y23.BackColor = Color.Transparent;
                    break;
                case "x17y23":
                    x17y23.BackgroundImage = null;
                    x17y23.BackColor = Color.Transparent;
                    break;
                case "x18y23":
                    x18y23.BackgroundImage = null;
                    x18y23.BackColor = Color.Transparent;
                    break;
                case "x19y23":
                    x19y23.BackgroundImage = null;
                    x19y23.BackColor = Color.Transparent;
                    break;
                case "x20y23":
                    x20y23.BackgroundImage = null;
                    x20y23.BackColor = Color.Transparent;
                    break;
                case "x21y23":
                    x21y23.BackgroundImage = null;
                    x21y23.BackColor = Color.Transparent;
                    break;
                case "x22y23":
                    x22y23.BackgroundImage = null;
                    x22y23.BackColor = Color.Transparent;
                    break;
                case "x23y23":
                    x23y23.BackgroundImage = null;
                    x23y23.BackColor = Color.Transparent;
                    break;
                case "x24y23":
                    x24y23.BackgroundImage = null;
                    x24y23.BackColor = Color.Transparent;
                    break;
                case "x25y23":
                    x25y23.BackgroundImage = null;
                    x25y23.BackColor = Color.Transparent;
                    break;
                case "x26y23":
                    x26y23.BackgroundImage = null;
                    x26y23.BackColor = Color.Transparent;
                    break;
                case "x27y23":
                    x27y23.BackgroundImage = null;
                    x27y23.BackColor = Color.Transparent;
                    break;
                case "x29y23":
                    x29y23.BackgroundImage = null;
                    x29y23.BackColor = Color.Transparent;
                    break;
                case "x30y23":
                    x30y23.BackgroundImage = null;
                    x30y23.BackColor = Color.Transparent;
                    break;
                case "x01y24":
                    x01y24.BackgroundImage = null;
                    x01y24.BackColor = Color.Transparent;
                    break;
                case "x02y24":
                    x02y24.BackgroundImage = null;
                    x02y24.BackColor = Color.Transparent;
                    break;
                case "x04y24":
                    x04y24.BackgroundImage = null;
                    x04y24.BackColor = Color.Transparent;
                    break;
                case "x05y24":
                    x05y24.BackgroundImage = null;
                    x05y24.BackColor = Color.Transparent;
                    break;
                case "x06y24":
                    x06y24.BackgroundImage = null;
                    x06y24.BackColor = Color.Transparent;
                    break;
                case "x07y24":
                    x07y24.BackgroundImage = null;
                    x07y24.BackColor = Color.Transparent;
                    break;
                case "x08y24":
                    x08y24.BackgroundImage = null;
                    x08y24.BackColor = Color.Transparent;
                    break;
                case "x09y24":
                    x09y24.BackgroundImage = null;
                    x09y24.BackColor = Color.Transparent;
                    break;
                case "x10y24":
                    x10y24.BackgroundImage = null;
                    x10y24.BackColor = Color.Transparent;
                    break;
                case "x11y24":
                    x11y24.BackgroundImage = null;
                    x11y24.BackColor = Color.Transparent;
                    break;
                case "x12y24":
                    x12y24.BackgroundImage = null;
                    x12y24.BackColor = Color.Transparent;
                    break;
                case "x13y24":
                    x13y24.BackgroundImage = null;
                    x13y24.BackColor = Color.Transparent;
                    break;
                case "x14y24":
                    x14y24.BackgroundImage = null;
                    x14y24.BackColor = Color.Transparent;
                    break;
                case "x15y24":
                    x15y24.BackgroundImage = null;
                    x15y24.BackColor = Color.Transparent;
                    break;
                case "x16y24":
                    x16y24.BackgroundImage = null;
                    x16y24.BackColor = Color.Transparent;
                    break;
                case "x17y24":
                    x17y24.BackgroundImage = null;
                    x17y24.BackColor = Color.Transparent;
                    break;
                case "x18y24":
                    x18y24.BackgroundImage = null;
                    x18y24.BackColor = Color.Transparent;
                    break;
                case "x19y24":
                    x19y24.BackgroundImage = null;
                    x19y24.BackColor = Color.Transparent;
                    break;
                case "x20y24":
                    x20y24.BackgroundImage = null;
                    x20y24.BackColor = Color.Transparent;
                    break;
                case "x21y24":
                    x21y24.BackgroundImage = null;
                    x21y24.BackColor = Color.Transparent;
                    break;
                case "x22y24":
                    x22y24.BackgroundImage = null;
                    x22y24.BackColor = Color.Transparent;
                    break;
                case "x23y24":
                    x23y24.BackgroundImage = null;
                    x23y24.BackColor = Color.Transparent;
                    break;
                case "x24y24":
                    x24y24.BackgroundImage = null;
                    x24y24.BackColor = Color.Transparent;
                    break;
                case "x25y24":
                    x25y24.BackgroundImage = null;
                    x25y24.BackColor = Color.Transparent;
                    break;
                case "x26y24":
                    x26y24.BackgroundImage = null;
                    x26y24.BackColor = Color.Transparent;
                    break;
                case "x27y24":
                    x27y24.BackgroundImage = null;
                    x27y24.BackColor = Color.Transparent;
                    break;
                case "x29y24":
                    x29y24.BackgroundImage = null;
                    x29y24.BackColor = Color.Transparent;
                    break;
                case "x30y24":
                    x30y24.BackgroundImage = null;
                    x30y24.BackColor = Color.Transparent;
                    break;
                case "x01y25":
                    x01y25.BackgroundImage = null;
                    x01y25.BackColor = Color.Transparent;
                    break;
                case "x02y25":
                    x02y25.BackgroundImage = null;
                    x02y25.BackColor = Color.Transparent;
                    break;
                case "x05y25":
                    x05y25.BackgroundImage = null;
                    x05y25.BackColor = Color.Transparent;
                    break;
                case "x06y25":
                    x06y25.BackgroundImage = null;
                    x06y25.BackColor = Color.Transparent;
                    break;
                case "x10y25":
                    x10y25.BackgroundImage = null;
                    x10y25.BackColor = Color.Transparent;
                    break;
                case "x11y25":
                    x11y25.BackgroundImage = null;
                    x11y25.BackColor = Color.Transparent;
                    break;
                case "x15y25":
                    x15y25.BackgroundImage = null;
                    x15y25.BackColor = Color.Transparent;
                    break;
                case "x16y25":
                    x16y25.BackgroundImage = null;
                    x16y25.BackColor = Color.Transparent;
                    break;
                case "x20y25":
                    x20y25.BackgroundImage = null;
                    x20y25.BackColor = Color.Transparent;
                    break;
                case "x21y25":
                    x21y25.BackgroundImage = null;
                    x21y25.BackColor = Color.Transparent;
                    break;
                case "x25y25":
                    x25y25.BackgroundImage = null;
                    x25y25.BackColor = Color.Transparent;
                    break;
                case "x26y25":
                    x26y25.BackgroundImage = null;
                    x26y25.BackColor = Color.Transparent;
                    break;
                case "x29y25":
                    x29y25.BackgroundImage = null;
                    x29y25.BackColor = Color.Transparent;
                    break;
                case "x30y25":
                    x30y25.BackgroundImage = null;
                    x30y25.BackColor = Color.Transparent;
                    break;
                case "x01y26":
                    x01y26.BackgroundImage = null;
                    x01y26.BackColor = Color.Transparent;
                    break;
                case "x02y26":
                    x02y26.BackgroundImage = null;
                    x02y26.BackColor = Color.Transparent;
                    break;
                case "x03y26":
                    x03y26.BackgroundImage = null;
                    x03y26.BackColor = Color.Transparent;
                    break;
                case "x04y26":
                    x04y26.BackgroundImage = null;
                    x04y26.BackColor = Color.Transparent;
                    break;
                case "x05y26":
                    x05y26.BackgroundImage = null;
                    x05y26.BackColor = Color.Transparent;
                    break;
                case "x06y26":
                    x06y26.BackgroundImage = null;
                    x06y26.BackColor = Color.Transparent;
                    break;
                case "x07y26":
                    x07y26.BackgroundImage = null;
                    x07y26.BackColor = Color.Transparent;
                    break;
                case "x09y26":
                    x09y26.BackgroundImage = null;
                    x09y26.BackColor = Color.Transparent;
                    break;
                case "x10y26":
                    x10y26.BackgroundImage = null;
                    x10y26.BackColor = Color.Transparent;
                    break;
                case "x11y26":
                    x11y26.BackgroundImage = null;
                    x11y26.BackColor = Color.Transparent;
                    break;
                case "x13y26":
                    x13y26.BackgroundImage = null;
                    x13y26.BackColor = Color.Transparent;
                    break;
                case "x14y26":
                    x14y26.BackgroundImage = null;
                    x14y26.BackColor = Color.Transparent;
                    break;
                case "x15y26":
                    x15y26.BackgroundImage = null;
                    x15y26.BackColor = Color.Transparent;
                    break;
                case "x16y26":
                    x16y26.BackgroundImage = null;
                    x16y26.BackColor = Color.Transparent;
                    break;
                case "x17y26":
                    x17y26.BackgroundImage = null;
                    x17y26.BackColor = Color.Transparent;
                    break;
                case "x18y26":
                    x18y26.BackgroundImage = null;
                    x18y26.BackColor = Color.Transparent;
                    break;
                case "x20y26":
                    x20y26.BackgroundImage = null;
                    x20y26.BackColor = Color.Transparent;
                    break;
                case "x21y26":
                    x21y26.BackgroundImage = null;
                    x21y26.BackColor = Color.Transparent;
                    break;
                case "x22y26":
                    x22y26.BackgroundImage = null;
                    x22y26.BackColor = Color.Transparent;
                    break;
                case "x24y26":
                    x24y26.BackgroundImage = null;
                    x24y26.BackColor = Color.Transparent;
                    break;
                case "x25y26":
                    x25y26.BackgroundImage = null;
                    x25y26.BackColor = Color.Transparent;
                    break;
                case "x26y26":
                    x26y26.BackgroundImage = null;
                    x26y26.BackColor = Color.Transparent;
                    break;
                case "x27y26":
                    x27y26.BackgroundImage = null;
                    x27y26.BackColor = Color.Transparent;
                    break;
                case "x28y26":
                    x28y26.BackgroundImage = null;
                    x28y26.BackColor = Color.Transparent;
                    break;
                case "x29y26":
                    x29y26.BackgroundImage = null;
                    x29y26.BackColor = Color.Transparent;
                    break;
                case "x30y26":
                    x30y26.BackgroundImage = null;
                    x30y26.BackColor = Color.Transparent;
                    break;
                case "x01y27":
                    x01y27.BackgroundImage = null;
                    x01y27.BackColor = Color.Transparent;
                    break;
                case "x02y27":
                    x02y27.BackgroundImage = null;
                    x02y27.BackColor = Color.Transparent;
                    break;
                case "x03y27":
                    x03y27.BackgroundImage = null;
                    x03y27.BackColor = Color.Transparent;
                    break;
                case "x04y27":
                    x04y27.BackgroundImage = null;
                    x04y27.BackColor = Color.Transparent;
                    break;
                case "x05y27":
                    x05y27.BackgroundImage = null;
                    x05y27.BackColor = Color.Transparent;
                    break;
                case "x06y27":
                    x06y27.BackgroundImage = null;
                    x06y27.BackColor = Color.Transparent;
                    break;
                case "x07y27":
                    x07y27.BackgroundImage = null;
                    x07y27.BackColor = Color.Transparent;
                    break;
                case "x09y27":
                    x09y27.BackgroundImage = null;
                    x09y27.BackColor = Color.Transparent;
                    break;
                case "x10y27":
                    x10y27.BackgroundImage = null;
                    x10y27.BackColor = Color.Transparent;
                    break;
                case "x11y27":
                    x11y27.BackgroundImage = null;
                    x11y27.BackColor = Color.Transparent;
                    break;
                case "x13y27":
                    x13y27.BackgroundImage = null;
                    x13y27.BackColor = Color.Transparent;
                    break;
                case "x14y27":
                    x14y27.BackgroundImage = null;
                    x14y27.BackColor = Color.Transparent;
                    break;
                case "x15y27":
                    x15y27.BackgroundImage = null;
                    x15y27.BackColor = Color.Transparent;
                    break;
                case "x16y27":
                    x16y27.BackgroundImage = null;
                    x16y27.BackColor = Color.Transparent;
                    break;
                case "x17y27":
                    x17y27.BackgroundImage = null;
                    x17y27.BackColor = Color.Transparent;
                    break;
                case "x18y27":
                    x18y27.BackgroundImage = null;
                    x18y27.BackColor = Color.Transparent;
                    break;
                case "x20y27":
                    x20y27.BackgroundImage = null;
                    x20y27.BackColor = Color.Transparent;
                    break;
                case "x21y27":
                    x21y27.BackgroundImage = null;
                    x21y27.BackColor = Color.Transparent;
                    break;
                case "x22y27":
                    x22y27.BackgroundImage = null;
                    x22y27.BackColor = Color.Transparent;
                    break;
                case "x24y27":
                    x24y27.BackgroundImage = null;
                    x24y27.BackColor = Color.Transparent;
                    break;
                case "x25y27":
                    x25y27.BackgroundImage = null;
                    x25y27.BackColor = Color.Transparent;
                    break;
                case "x26y27":
                    x26y27.BackgroundImage = null;
                    x26y27.BackColor = Color.Transparent;
                    break;
                case "x27y27":
                    x27y27.BackgroundImage = null;
                    x27y27.BackColor = Color.Transparent;
                    break;
                case "x28y27":
                    x28y27.BackgroundImage = null;
                    x28y27.BackColor = Color.Transparent;
                    break;
                case "x29y27":
                    x29y27.BackgroundImage = null;
                    x29y27.BackColor = Color.Transparent;
                    break;
                case "x30y27":
                    x30y27.BackgroundImage = null;
                    x30y27.BackColor = Color.Transparent;
                    break;
                case "x01y28":
                    x01y28.BackgroundImage = null;
                    x01y28.BackColor = Color.Transparent;
                    break;
                case "x02y28":
                    x02y28.BackgroundImage = null;
                    x02y28.BackColor = Color.Transparent;
                    break;
                case "x03y28":
                    x03y28.BackgroundImage = null;
                    x03y28.BackColor = Color.Transparent;
                    break;
                case "x04y28":
                    x04y28.BackgroundImage = null;
                    x04y28.BackColor = Color.Transparent;
                    break;
                case "x05y28":
                    x05y28.BackgroundImage = null;
                    x05y28.BackColor = Color.Transparent;
                    break;
                case "x06y28":
                    x06y28.BackgroundImage = null;
                    x06y28.BackColor = Color.Transparent;
                    break;
                case "x07y28":
                    x07y28.BackgroundImage = null;
                    x07y28.BackColor = Color.Transparent;
                    break;
                case "x09y28":
                    x09y28.BackgroundImage = null;
                    x09y28.BackColor = Color.Transparent;
                    break;
                case "x10y28":
                    x10y28.BackgroundImage = null;
                    x10y28.BackColor = Color.Transparent;
                    break;
                case "x11y28":
                    x11y28.BackgroundImage = null;
                    x11y28.BackColor = Color.Transparent;
                    break;
                case "x15y28":
                    x15y28.BackgroundImage = null;
                    x15y28.BackColor = Color.Transparent;
                    break;
                case "x16y28":
                    x16y28.BackgroundImage = null;
                    x16y28.BackColor = Color.Transparent;
                    break;
                case "x20y28":
                    x20y28.BackgroundImage = null;
                    x20y28.BackColor = Color.Transparent;
                    break;
                case "x21y28":
                    x21y28.BackgroundImage = null;
                    x21y28.BackColor = Color.Transparent;
                    break;
                case "x22y28":
                    x22y28.BackgroundImage = null;
                    x22y28.BackColor = Color.Transparent;
                    break;
                case "x24y28":
                    x24y28.BackgroundImage = null;
                    x24y28.BackColor = Color.Transparent;
                    break;
                case "x25y28":
                    x25y28.BackgroundImage = null;
                    x25y28.BackColor = Color.Transparent;
                    break;
                case "x26y28":
                    x26y28.BackgroundImage = null;
                    x26y28.BackColor = Color.Transparent;
                    break;
                case "x27y28":
                    x27y28.BackgroundImage = null;
                    x27y28.BackColor = Color.Transparent;
                    break;
                case "x28y28":
                    x28y28.BackgroundImage = null;
                    x28y28.BackColor = Color.Transparent;
                    break;
                case "x29y28":
                    x29y28.BackgroundImage = null;
                    x29y28.BackColor = Color.Transparent;
                    break;
                case "x30y28":
                    x30y28.BackgroundImage = null;
                    x30y28.BackColor = Color.Transparent;
                    break;
                case "x01y29":
                    x01y29.BackgroundImage = null;
                    x01y29.BackColor = Color.Red;
                    break;
                case "x02y29":
                    x02y29.BackgroundImage = null;
                    x02y29.BackColor = Color.Transparent;
                    break;
                case "x03y29":
                    x03y29.BackgroundImage = null;
                    x03y29.BackColor = Color.Transparent;
                    break;
                case "x04y29":
                    x04y29.BackgroundImage = null;
                    x04y29.BackColor = Color.Transparent;
                    break;
                case "x05y29":
                    x05y29.BackgroundImage = null;
                    x05y29.BackColor = Color.Transparent;
                    break;
                case "x06y29":
                    x06y29.BackgroundImage = null;
                    x06y29.BackColor = Color.Transparent;
                    break;
                case "x07y29":
                    x07y29.BackgroundImage = null;
                    x07y29.BackColor = Color.Transparent;
                    break;
                case "x08y29":
                    x08y29.BackgroundImage = null;
                    x08y29.BackColor = Color.Transparent;
                    break;
                case "x09y29":
                    x09y29.BackgroundImage = null;
                    x09y29.BackColor = Color.Transparent;
                    break;
                case "x10y29":
                    x10y29.BackgroundImage = null;
                    x10y29.BackColor = Color.Transparent;
                    break;
                case "x11y29":
                    x11y29.BackgroundImage = null;
                    x11y29.BackColor = Color.Transparent;
                    break;
                case "x12y29":
                    x12y29.BackgroundImage = null;
                    x12y29.BackColor = Color.Transparent;
                    break;
                case "x13y29":
                    x13y29.BackgroundImage = null;
                    x13y29.BackColor = Color.Transparent;
                    break;
                case "x14y29":
                    x14y29.BackgroundImage = null;
                    x14y29.BackColor = Color.Transparent;
                    break;
                case "x15y29":
                    x15y29.BackgroundImage = null;
                    x15y29.BackColor = Color.Transparent;
                    break;
                case "x16y29":
                    x16y29.BackgroundImage = null;
                    x16y29.BackColor = Color.Transparent;
                    break;
                case "x17y29":
                    x17y29.BackgroundImage = null;
                    x17y29.BackColor = Color.Transparent;
                    break;
                case "x18y29":
                    x18y29.BackgroundImage = null;
                    x18y29.BackColor = Color.Transparent;
                    break;
                case "x19y29":
                    x19y29.BackgroundImage = null;
                    x19y29.BackColor = Color.Transparent;
                    break;
                case "x20y29":
                    x20y29.BackgroundImage = null;
                    x20y29.BackColor = Color.Transparent;
                    break;
                case "x21y29":
                    x21y29.BackgroundImage = null;
                    x21y29.BackColor = Color.Transparent;
                    break;
                case "x22y29":
                    x22y29.BackgroundImage = null;
                    x22y29.BackColor = Color.Transparent;
                    break;
                case "x23y29":
                    x23y29.BackgroundImage = null;
                    x23y29.BackColor = Color.Transparent;
                    break;
                case "x24y29":
                    x24y29.BackgroundImage = null;
                    x24y29.BackColor = Color.Transparent;
                    break;
                case "x25y29":
                    x25y29.BackgroundImage = null;
                    x25y29.BackColor = Color.Transparent;
                    break;
                case "x26y29":
                    x26y29.BackgroundImage = null;
                    x26y29.BackColor = Color.Transparent;
                    break;
                case "x27y29":
                    x27y29.BackgroundImage = null;
                    x27y29.BackColor = Color.Transparent;
                    break;
                case "x28y29":
                    x28y29.BackgroundImage = null;
                    x28y29.BackColor = Color.Transparent;
                    break;
                case "x29y29":
                    x29y29.BackgroundImage = null;
                    x29y29.BackColor = Color.Transparent;
                    break;
                case "x30y29":
                    x30y29.BackgroundImage = null;
                    x30y29.BackColor = Color.White;
                    break;
                case "x01y30":
                    x01y30.BackgroundImage = null;
                    x01y30.BackColor = Color.Red;
                    break;
                case "x02y30":
                    x02y30.BackgroundImage = null;
                    x02y30.BackColor = Color.Red;
                    break;
                case "x03y30":
                    x03y30.BackgroundImage = null;
                    x03y30.BackColor = Color.Transparent;
                    break;
                case "x04y30":
                    x04y30.BackgroundImage = null;
                    x04y30.BackColor = Color.Transparent;
                    break;
                case "x05y30":
                    x05y30.BackgroundImage = null;
                    x05y30.BackColor = Color.Transparent;
                    break;
                case "x06y30":
                    x06y30.BackgroundImage = null;
                    x06y30.BackColor = Color.Transparent;
                    break;
                case "x07y30":
                    x07y30.BackgroundImage = null;
                    x07y30.BackColor = Color.Transparent;
                    break;
                case "x08y30":
                    x08y30.BackgroundImage = null;
                    x08y30.BackColor = Color.Transparent;
                    break;
                case "x09y30":
                    x09y30.BackgroundImage = null;
                    x09y30.BackColor = Color.Transparent;
                    break;
                case "x10y30":
                    x10y30.BackgroundImage = null;
                    x10y30.BackColor = Color.Transparent;
                    break;
                case "x11y30":
                    x11y30.BackgroundImage = null;
                    x11y30.BackColor = Color.Transparent;
                    break;
                case "x12y30":
                    x12y30.BackgroundImage = null;
                    x12y30.BackColor = Color.Transparent;
                    break;
                case "x13y30":
                    x13y30.BackgroundImage = null;
                    x13y30.BackColor = Color.Transparent;
                    break;
                case "x14y30":
                    x14y30.BackgroundImage = null;
                    x14y30.BackColor = Color.Transparent;
                    break;
                case "x15y30":
                    x15y30.BackgroundImage = null;
                    x15y30.BackColor = Color.Transparent;
                    break;
                case "x16y30":
                    x16y30.BackgroundImage = null;
                    x16y30.BackColor = Color.Transparent;
                    break;
                case "x17y30":
                    x17y30.BackgroundImage = null;
                    x17y30.BackColor = Color.Transparent;
                    break;
                case "x18y30":
                    x18y30.BackgroundImage = null;
                    x18y30.BackColor = Color.Transparent;
                    break;
                case "x19y30":
                    x19y30.BackgroundImage = null;
                    x19y30.BackColor = Color.Transparent;
                    break;
                case "x20y30":
                    x20y30.BackgroundImage = null;
                    x20y30.BackColor = Color.Transparent;
                    break;
                case "x21y30":
                    x21y30.BackgroundImage = null;
                    x21y30.BackColor = Color.Transparent;
                    break;
                case "x22y30":
                    x22y30.BackgroundImage = null;
                    x22y30.BackColor = Color.Transparent;
                    break;
                case "x23y30":
                    x23y30.BackgroundImage = null;
                    x23y30.BackColor = Color.Transparent;
                    break;
                case "x24y30":
                    x24y30.BackgroundImage = null;
                    x24y30.BackColor = Color.Transparent;
                    break;
                case "x25y30":
                    x25y30.BackgroundImage = null;
                    x25y30.BackColor = Color.Transparent;
                    break;
                case "x26y30":
                    x26y30.BackgroundImage = null;
                    x26y30.BackColor = Color.Transparent;
                    break;
                case "x27y30":
                    x27y30.BackgroundImage = null;
                    x27y30.BackColor = Color.Transparent;
                    break;
                case "x28y30":
                    x28y30.BackgroundImage = null;
                    x28y30.BackColor = Color.Transparent;
                    break;
                case "x29y30":
                    x29y30.BackgroundImage = null;
                    x29y30.BackColor = Color.White;
                    break;
                case "x30y30":
                    x30y30.BackgroundImage = null;
                    x30y30.BackColor = Color.White;
                    break;
                case "x13y31":
                    x13y31.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x13y31.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x14y31":
                    x14y31.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x14y31.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x17y31":
                    x17y31.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x17y31.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "x18y31":
                    x18y31.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\download (1).jpeg");
                    x18y31.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }

        }
        private void ChangePlayer()
        {
            int playersNumber = 0;
            for(int i=0; i< match.Players.Length; i++)
            {
                if(match.Players[i]!="")
                {
                    playersNumber++;
                }
            }
            if (match.PlayerIndex < playersNumber)
                match.PlayerIndex++;
            else
                match.PlayerIndex = 0;
        }
        private void UpdateBoard(string player)
        {
            string playerID="",colour="";
            PlayerTB.Text = player;
            match.SelectedPlayer = player;
            match.IconPlayer =Environment.CurrentDirectory +"\\images\\warrior.png";
            for (int i=0;i<match.Players.Length;i++)
            {
                if(player==match.Players[i])
                {
                    playerID = "G" + Convert.ToString(i + 1);
                }
            }
            for(int i=0;i<match.Teams.Length;i++)
            {
                if(playerID==match.Teams[i].Split(' ')[0])
                {
                    colour = match.Teams[i].Split(' ')[1];
                }
            }
            switch (colour)
            {
                case "Blue":
                    IconPlayer.BackColor = Color.Blue;
                    E1.BackColor = Color.Blue;
                    E2.BackColor = Color.Blue;
                    E3.BackColor = Color.Blue;
                    E1.Tag = match.BlueLocation[0];
                    E2.Tag = match.BlueLocation[1];
                    E3.Tag = match.BlueLocation[2];
                    CheckBase("BLUE");
                    CheckTemple("BLUE");
                    CheckBattlefield();
                    match.IconColor = "Blue";
                    if (match.EntitySelected=="E1")
                    {
                        E1.BackColor = Color.DarkBlue;
                        IconPlayer.BackColor = Color.DarkBlue;
                        EntityLocationTB.Text = match.BlueLocation[0];
                    }
                    if (match.EntitySelected == "E2")
                    {
                        E2.BackColor = Color.DarkBlue;
                        IconPlayer.BackColor = Color.DarkBlue;
                        EntityLocationTB.Text = match.BlueLocation[1];
                    }
                    if (match.EntitySelected == "E3")
                    {
                        E3.BackColor = Color.DarkBlue;
                        IconPlayer.BackColor = Color.DarkBlue;
                        EntityLocationTB.Text = match.BlueLocation[2];
                    }
                    break;
                case "Red":
                    IconPlayer.BackColor = Color.Red;
                    E1.BackColor = Color.Red;
                    E2.BackColor = Color.Red;
                    E3.BackColor = Color.Red;
                    E1.Tag = match.RedLocation[0];
                    E2.Tag = match.RedLocation[1];
                    E3.Tag = match.RedLocation[2];
                    CheckBase("RED");
                    CheckTemple("RED");
                    CheckBattlefield();
                    match.IconColor = "Red";
                    if (match.EntitySelected == "E1")
                    {
                        E1.BackColor = Color.DarkRed;
                        IconPlayer.BackColor = Color.DarkRed;
                        EntityLocationTB.Text = match.RedLocation[0];
                    }
                    if (match.EntitySelected == "E2")
                    {
                        E2.BackColor = Color.DarkRed;
                        IconPlayer.BackColor = Color.DarkRed;
                        EntityLocationTB.Text = match.RedLocation[1];
                    }
                    if (match.EntitySelected == "E3")
                    {
                        E3.BackColor = Color.DarkRed;
                        IconPlayer.BackColor = Color.DarkRed;
                        EntityLocationTB.Text = match.RedLocation[2];
                    }
                    break;
                case "Yellow":
                    IconPlayer.BackColor = Color.Yellow;
                    E1.BackColor = Color.Yellow;
                    E2.BackColor = Color.Yellow;
                    E3.BackColor = Color.Yellow;
                    E1.Tag = match.YellowLocation[0];
                    E2.Tag = match.YellowLocation[1];
                    E3.Tag = match.YellowLocation[2];
                    CheckBase("YELLOW");
                    CheckTemple("YELLOW");
                    CheckBattlefield();
                    match.IconColor = "Yellow";
                    if (match.EntitySelected == "E1")
                    {
                        E1.BackColor = Color.Orange;
                        IconPlayer.BackColor = Color.Orange;
                        EntityLocationTB.Text = match.YellowLocation[0];
                    }
                    if (match.EntitySelected == "E2")
                    {
                        E2.BackColor = Color.Orange;
                        IconPlayer.BackColor = Color.Orange;
                        EntityLocationTB.Text = match.YellowLocation[1];
                    }
                    if (match.EntitySelected == "E3")
                    {
                        E3.BackColor = Color.Orange;
                        IconPlayer.BackColor = Color.Orange;
                        EntityLocationTB.Text = match.YellowLocation[2];
                    }
                    break;
                case "White":
                    IconPlayer.BackColor = Color.White;
                    E1.BackColor = Color.White;
                    E2.BackColor = Color.White;
                    E3.BackColor = Color.White;
                    E1.Tag = match.WhiteLocation[0];
                    E2.Tag = match.WhiteLocation[1];
                    E3.Tag = match.WhiteLocation[2];
                    CheckBase("WHITE");
                    CheckTemple("WHITE");
                    CheckBattlefield();
                    match.IconColor = "White";
                    if (match.EntitySelected == "E1")
                    {
                        E1.BackColor = Color.DarkGray;
                        IconPlayer.BackColor = Color.DarkGray;
                        EntityLocationTB.Text = match.WhiteLocation[0];
                    }
                    if (match.EntitySelected == "E2")
                    {
                        E2.BackColor = Color.DarkGray;
                        IconPlayer.BackColor = Color.DarkGray;
                        EntityLocationTB.Text = match.WhiteLocation[1];
                    }
                    if (match.EntitySelected == "E3")
                    {
                        E3.BackColor = Color.DarkGray;
                        IconPlayer.BackColor = Color.DarkGray;
                        EntityLocationTB.Text = match.WhiteLocation[2];
                    }
                    break;
            }
            IconPlayer.Visible = true;
        }
        private void CheckBase(string colour)
        {

            switch (colour)
            {
                case "BLUE":
                    if ((match.BlueLocation[0] != "x30y02" && match.BlueLocation[1] == "x30y01" && match.BlueLocation[2] == "x29y01") || (match.BlueLocation[0] == "x30y02" && match.BlueLocation[1] != "x30y01" && match.BlueLocation[2] == "x29y01") || (match.BlueLocation[0] == "x30y02" && match.BlueLocation[1] == "x30y01" && match.BlueLocation[2] != "x29y01"))
                    {
                        BaseNumL.Text = "2";
                        match.Base = BaseNumL.Text;
                    }
                    else
                    {
                        if (match.BlueLocation[0] == "x30y02" && match.BlueLocation[1] == "x30y01" && match.BlueLocation[2] == "x29y01")
                        {
                            BaseNumL.Text = "3";
                            match.Base = BaseNumL.Text;
                        }
                        else 
                        { 
                            if(match.BlueLocation[0] != "x30y02" && match.BlueLocation[1] != "x30y01" && match.BlueLocation[2] != "x29y01")
                            {
                                BaseNumL.Text = "0";
                                match.Base = BaseNumL.Text;
                            }
                            else
                            {
                                BaseNumL.Text = "1";
                                match.Base = BaseNumL.Text;
                            }

                            
                        }
                        
                    }
                    break;
                case "RED":
                    if ((match.RedLocation[0] != "x01y29" && match.RedLocation[1] == "x01y30" && match.RedLocation[2] == "x02y30") || (match.RedLocation[0] == "x01y29" && match.RedLocation[1] != "x01y30" && match.RedLocation[2] == "x02y30") || (match.RedLocation[0] == "x01y29" && match.RedLocation[1] == "x01y30" && match.RedLocation[2] != "x02y30"))
                    {
                        BaseNumL.Text = "2";
                        match.Base= BaseNumL.Text;
                    }
                    else
                    {
                        if (match.RedLocation[0] == "x01y29" && match.RedLocation[1] == "x01y30" && match.RedLocation[2] == "x02y30")                       
                        {
                            BaseNumL.Text = "3";
                            match.Base = BaseNumL.Text;
                        }
                        else
                        {
                            if(match.RedLocation[0] != "x01y29" && match.RedLocation[1] != "x01y30" && match.RedLocation[2] != "x02y30")
                            {
                                BaseNumL.Text = "0";
                                match.Base = BaseNumL.Text;
                            }
                            else
                            {
                                BaseNumL.Text = "1";
                                match.Base= BaseNumL.Text;
                            }
                        }
                    }
                    break;
                case "YELLOW":
                    if ((match.YellowLocation[0] != "x01y02" && match.YellowLocation[1] == "x01y01" && match.YellowLocation[2] == "x02y01") || (match.YellowLocation[0] == "x01y02" && match.YellowLocation[1] != "x01y01" && match.YellowLocation[2] == "x02y01") || (match.YellowLocation[0] == "x01y02" && match.YellowLocation[1] == "x01y01" && match.YellowLocation[2] != "x02y01"))
                    {
                        BaseNumL.Text = "2";
                        match.Base = BaseNumL.Text;
                    }
                    else
                    {
                        if (match.YellowLocation[0] == "x01y02" && match.YellowLocation[1] == "x01y01" && match.YellowLocation[2] == "x02y01")
                        {
                            BaseNumL.Text = "3";
                            match.Base = BaseNumL.Text;
                        }
                        else
                        {
                            if (match.YellowLocation[0] != "x01y02" && match.YellowLocation[1] != "x01y01" && match.YellowLocation[2] != "x02y01")
                            {
                                BaseNumL.Text = "0";
                                match.Base = BaseNumL.Text;
                            }
                            else
                            {
                                BaseNumL.Text = "1";
                                match.Base = BaseNumL.Text;
                            }
                        }
                    }
                    break;
                case "WHITE":
                    if ((match.WhiteLocation[0] != "x30y29" && match.WhiteLocation[1] == "x30y30" && match.WhiteLocation[2] == "x29y30") || (match.WhiteLocation[0] == "x30y29" && match.WhiteLocation[1] != "x30y30" && match.WhiteLocation[2] == "x29y30") || (match.WhiteLocation[0] == "x30y29" && match.WhiteLocation[1] == "x30y30" && match.WhiteLocation[2] != "x29y01"))
                    {
                        BaseNumL.Text = "2";
                        match.Base = BaseNumL.Text;
                    }
                    else
                    {
                        if (match.WhiteLocation[0] == "x30y29" && match.WhiteLocation[1] == "x30y30" && match.WhiteLocation[2] == "x29y30")
                        {
                            BaseNumL.Text = "3";
                            match.Base = BaseNumL.Text;
                        }
                        else
                        {
                            if (match.WhiteLocation[0] != "x30y29" && match.WhiteLocation[1] != "x30y30" && match.WhiteLocation[2] != "x29y30")
                            {
                                BaseNumL.Text = "0";
                                match.Base = BaseNumL.Text;
                            }
                            else
                            {
                                BaseNumL.Text = "1";
                                match.Base = BaseNumL.Text;
                            }
                        }
                    }
                    break;
            }
          
            
            
        }
        private void CheckBattlefield()
        {
            if ((BaseNumL.Text == "2" && TempleNumL.Text == "0") || (BaseNumL.Text == "0" && TempleNumL.Text == "2") || (BaseNumL.Text=="1"&&TempleNumL.Text=="1"))
            {
                BattlefieldNumL.Text = "1";
                match.Field = BattlefieldNumL.Text;
            }
            else
            {
                if(BaseNumL.Text == "0" && TempleNumL.Text == "0")
                {
                    BattlefieldNumL.Text = "3";
                    match.Field = BattlefieldNumL.Text;
                }
                else
                {
                    if((BaseNumL.Text == "3" && TempleNumL.Text == "0") || (BaseNumL.Text == "0" && TempleNumL.Text == "3"))
                    {
                        BattlefieldNumL.Text = "0";
                        match.Field = BattlefieldNumL.Text;
                    }
                    else
                    {
                        BattlefieldNumL.Text = "2";
                        match.Field = BattlefieldNumL.Text;
                    }
                }
            }
        }
        private void CheckTemple(string colour)
        {
            switch (colour)
            {
                case "BLUE":
                    if ((match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] == "x17y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] == "x17y14"))
                    {     
                        TempleNumL.Text = "3";
                        match.Temple = TempleNumL.Text;
                    }
                    else
                    {
                        if ((match.BlueLocation[0] != "x16y14" && match.BlueLocation[1] != "x17y14" && match.BlueLocation[2] != "x17y15") || (match.BlueLocation[0] != "x17y14" && match.BlueLocation[1] != "x16y14" && match.BlueLocation[2] != "x17y15") || (match.BlueLocation[0] != "x16y14" && match.BlueLocation[1] != "x17y15" && match.BlueLocation[2] != "x17y14") || (match.BlueLocation[0] != "x17y15" && match.BlueLocation[1] != "x17y14" && match.BlueLocation[2] != "x16y14") || (match.BlueLocation[0] != "x17y14" && match.BlueLocation[1] != "x17y15" && match.BlueLocation[2] != "x16y14") || (match.BlueLocation[0] != "x17y15" && match.BlueLocation[1] != "x16y14" && match.BlueLocation[2] != "x17y14"))
                        {
                            TempleNumL.Text = "0";
                            match.Temple = TempleNumL.Text;
                        }
                        else
                        {
                            if((match.BlueLocation[0] != "x16y14" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] != "x17y14" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] != "x16y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] == "x17y14") || (match.BlueLocation[0] != "x17y15" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] != "x17y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] != "x17y15" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] == "x17y14") || (match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] != "x17y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] != "x16y14" && match.BlueLocation[2] == "x17y15") || (match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] != "x17y15" && match.BlueLocation[2] == "x17y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] != "x17y14" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] != "x17y15" && match.BlueLocation[2] == "x16y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] != "x16y14" && match.BlueLocation[2] == "x17y14") || (match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] != "x17y15") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] != "x17y15") || (match.BlueLocation[0] == "x16y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] != "x17y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] == "x17y14" && match.BlueLocation[2] != "x16y14") || (match.BlueLocation[0] == "x17y14" && match.BlueLocation[1] == "x17y15" && match.BlueLocation[2] != "x16y14") || (match.BlueLocation[0] == "x17y15" && match.BlueLocation[1] == "x16y14" && match.BlueLocation[2] != "x17y14"))
                            {
                                TempleNumL.Text = "1";
                                match.Temple = TempleNumL.Text;
                            }
                            else
                            {
                                TempleNumL.Text = "2";
                                match.Temple = TempleNumL.Text;
                            }
                            
                        }

                    }
                    break;
                case "RED":
                    if ((match.RedLocation[0] == "x14y16" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] == "x14y16" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] == "x14y16") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] == "x14y16"))
                    {
                        TempleNumL.Text = "3";
                        match.Temple = TempleNumL.Text;
                    }
                    else
                    {
                        if ((match.RedLocation[0] != "x14y16" && match.RedLocation[1] != "x14y17" && match.RedLocation[2] != "x15y17") || (match.RedLocation[0] != "x14y17" && match.RedLocation[1] != "x14y16" && match.RedLocation[2] != "x15y17") || (match.RedLocation[0] != "x14y16" && match.RedLocation[1] != "x15y17" && match.RedLocation[2] != "x14y17") || (match.RedLocation[0] != "x14y17" && match.RedLocation[1] != "x15y17" && match.RedLocation[2] != "x14y16") || (match.RedLocation[0] != "x15y17" && match.RedLocation[1] != "x14y16" && match.RedLocation[2] != "x14y17") || (match.RedLocation[0] != "x15y17" && match.RedLocation[1] != "x14y17" && match.RedLocation[2] != "x14y16"))                      
                        {
                            TempleNumL.Text = "0";
                            match.Temple = TempleNumL.Text;
                        }
                        else
                        {
                            if((match.RedLocation[0] != "x14y16" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] != "x14y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] != "x14y16" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] != "x14y17" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] == "x14y16") || (match.RedLocation[0] != "x15y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] != "x15y17" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] == "x14y16") || (match.RedLocation[0] == "x14y16" && match.RedLocation[1] != "x14y17" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] != "x14y16" && match.RedLocation[2] == "x15y17") || (match.RedLocation[0] == "x14y16" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] != "x15y17" && match.RedLocation[2] == "x14y16") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] != "x14y16" && match.RedLocation[2] == "x14y17") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] != "x14y17" && match.RedLocation[2] == "x14y16") || (match.RedLocation[0] == "x14y16" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] != "x15y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] != "x15y17") || (match.RedLocation[0] == "x14y16" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] != "x14y17") || (match.RedLocation[0] == "x14y17" && match.RedLocation[1] == "x15y17" && match.RedLocation[2] != "x14y16") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] == "x14y16" && match.RedLocation[2] != "x14y17") || (match.RedLocation[0] == "x15y17" && match.RedLocation[1] == "x14y17" && match.RedLocation[2] != "x14y16"))
                            {
                                TempleNumL.Text = "1";
                                match.Temple = TempleNumL.Text;
                            }
                            else
                            {
                                TempleNumL.Text = "2";
                                match.Temple = TempleNumL.Text;
                            }

                        }
                    }
                    break;
                case "YELLOW":
                    if ((match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] == "x14y15") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] == "x14y15"))
                    {
                        TempleNumL.Text = "3";
                        match.Temple = TempleNumL.Text;
                    }
                    else
                    {
                        if ((match.YellowLocation[0] != "x14y15" && match.YellowLocation[1] != "x14y14" && match.YellowLocation[2] != "x15y14") || (match.YellowLocation[0] != "x14y14" && match.YellowLocation[1] != "x14y15" && match.YellowLocation[2] != "x15y14") || (match.YellowLocation[0] != "x14y15" && match.YellowLocation[1] != "x15y14" && match.YellowLocation[2] != "x14y14") || (match.YellowLocation[0] != "x14y14" && match.YellowLocation[1] != "x15y14" && match.YellowLocation[2] != "x14y15") || (match.YellowLocation[0] != "x15y14" && match.YellowLocation[1] != "x14y15" && match.YellowLocation[2] != "x14y14") || (match.YellowLocation[0] != "x15y14" && match.YellowLocation[1] != "x14y14" && match.YellowLocation[2] != "x14y15"))
                        {
                            TempleNumL.Text = "0";
                            match.Temple = TempleNumL.Text;
                        }
                        else
                        {
                            if((match.YellowLocation[0] != "x14y15" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] != "x14y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] != "x14y15" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] != "x14y14" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] == "x14y15") || (match.YellowLocation[0] != "x15y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] != "x15y14" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] == "x14y15") || (match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] != "x14y14" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] != "x14y15" && match.YellowLocation[2] == "x15y14") || (match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] != "x15y14" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] != "x15y14" && match.YellowLocation[2] == "x14y15") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] != "x14y15" && match.YellowLocation[2] == "x14y14") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] != "x14y14" && match.YellowLocation[2] == "x14y15") || (match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] != "x15y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] != "x15y14") || (match.YellowLocation[0] == "x14y15" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] != "x14y14") || (match.YellowLocation[0] == "x14y14" && match.YellowLocation[1] == "x15y14" && match.YellowLocation[2] != "x14y15") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] == "x14y15" && match.YellowLocation[2] != "x14y14") || (match.YellowLocation[0] == "x15y14" && match.YellowLocation[1] == "x14y14" && match.YellowLocation[2] != "x14y15"))
                            {
                                TempleNumL.Text = "1";
                                match.Temple = TempleNumL.Text;
                            }
                            else
                            {
                                TempleNumL.Text = "2";
                                match.Temple = TempleNumL.Text;
                            }
                        }
                    }
                    break;
                case "WHITE":
                    if ((match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] == "x16y17") || (match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] == "x16y17"))
                    {
                        TempleNumL.Text = "3";
                        match.Temple = TempleNumL.Text;
                    }
                    else
                    {
                        if ((match.WhiteLocation[0] != "x16y17" && match.WhiteLocation[1] != "x17y17" && match.WhiteLocation[2] != "x17y16") || (match.WhiteLocation[0] != "x17y17" && match.WhiteLocation[1] != "x16y17" && match.WhiteLocation[2] != "x17y16") || (match.WhiteLocation[0] != "x17y17" && match.WhiteLocation[1] != "x17y16" && match.WhiteLocation[2] != "x16y17") || (match.WhiteLocation[0] != "x16y17" && match.WhiteLocation[1] != "x17y16" && match.WhiteLocation[2] != "x17y17") || (match.WhiteLocation[0] != "x17y16" && match.WhiteLocation[1] != "x16y17" && match.WhiteLocation[2] != "x17y17") || (match.WhiteLocation[0] != "x17y16" && match.WhiteLocation[1] != "x17y17" && match.WhiteLocation[2] != "x16y17"))
                        {
                            TempleNumL.Text = "0";
                            match.Temple = TempleNumL.Text;
                        }
                        else
                        {
                            if((match.WhiteLocation[0] != "x16y17" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] != "x17y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] == "x16y17") || (match.WhiteLocation[0] != "x16y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] != "x17y16" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] != "x17y16" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] == "x16y17") || (match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] != "x17y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] != "x17y16" && match.WhiteLocation[2] == "x16y17") || (match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] != "x17y16" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] != "x16y17" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] != "x17y17" && match.WhiteLocation[2] == "x16y17") || (match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] != "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] != "x17y16") || (match.WhiteLocation[0] == "x17y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] != "x16y17") || (match.WhiteLocation[0] == "x16y17" && match.WhiteLocation[1] == "x17y16" && match.WhiteLocation[2] != "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] == "x16y17" && match.WhiteLocation[2] == "x17y17") || (match.WhiteLocation[0] == "x17y16" && match.WhiteLocation[1] == "x17y17" && match.WhiteLocation[2] != "x16y17"))
                            {
                                TempleNumL.Text = "1";
                                match.Temple = TempleNumL.Text;
                            }
                            else
                            {
                                TempleNumL.Text = "2";
                                match.Temple = TempleNumL.Text;
                            }
                        }
                    }
                    break;
            }

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            if (match.New == true) 
            {
                IconPlayer.Visible = false;
                E1.Visible = false;
                match.E1Control = false;
                E2.Visible = false;
                match.E2Control = false;
                E3.Visible = false;
                match.E3Control = false;
                SequenceBtn.Enabled = false;
                MinotaurusBtn.Enabled = false;
                WallBtn.Enabled = false;
                UndoBtn.Enabled = false;
                UpBtn.Enabled = false;
                RightBtn.Enabled = false;
                DownBtn.Enabled = false;
                LeftBtn.Enabled = false;
                SkipBtn.Enabled = false;
                SaveQuitBtn.Enabled = false;
                match.DiceControl = DiceBtn.Enabled;
                match.MinotaurusControl = MinotaurusBtn.Enabled;
                match.WallControl = WallBtn.Enabled;
                match.UndoControl = UndoBtn.Enabled;
                match.UpControl = UpBtn.Enabled;
                match.RightControl = RightBtn.Enabled;
                match.DownControl = DownBtn.Enabled;
                match.LeftControl = LeftBtn.Enabled;
                match.SkipControl = SkipBtn.Enabled;
                match.EatBtnControl = EatBtn.Visible;
                match.BlueLocation = new string[] { "x30y02", "x30y01", "x29y01" };
                match.RedLocation = new string[] { "x01y29", "x01y30", "x02y30" };
                match.YellowLocation = new string[] { "x01y02", "x01y01", "x02y01" };
                match.WhiteLocation = new string[] { "x30y29", "x30y30", "x29y30" };
                match.PlayerIndex = 0;
              
                match.Walls = new string[] { "x00y17 x00y18", "x00y13 x00y14", "x04y03 x05y03", "x09y21 x09y22", "x09y09 x09y10", "x13y31 x14y31", "x13y00 x14y00", "x17y31 x18y31", "x17y00 x18y00", "x22y22 x22y21", "x22y09 x22y10", "x26y28 x27y28", "x26y03 x27y03", "x31y17 x31y18", "x31y13 x31y14" };
                MessageBox.Show("Prima di iniziare la partita è necessario stabilire l'ordine di gioco.\nOgni giocatore deve tirare il dado!", "MINOTAURUS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form6 f6 = new Form6(match.PlayersCopy);
                f6.ShowDialog();
                match.GameSequence=File.ReadAllText(Environment.CurrentDirectory + "data.txt");
                File.Delete(Environment.CurrentDirectory + "data.txt");
                SequenceBtn.Enabled = true;
                match.SequenceControl = true;
                MessageBox.Show($"E' il turno di {match.GameSequence.Split(' ')[match.PlayerIndex]}", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateBoard(match.GameSequence.Split(' ')[match.PlayerIndex]);
                MessageBox.Show("Prima di continuare, è consigliabile salvare premendo sul pulsante 'SALVA ED ESCI'.", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                match.New = false;
                SaveQuitBtn.Enabled = true;
                match.SaveQuitControl = true;







            }
            else
            {
                CleanField();
                SequenceBtn.Enabled = match.SequenceControl;
                MinotaurusBtn.Enabled = match.MinotaurusControl;
                WallBtn.Enabled = match.WallControl;
                UndoBtn.Enabled = match.UndoControl;
                UpBtn.Enabled = match.UpControl;
                RightBtn.Enabled = match.RightControl;
                DownBtn.Enabled = match.DownControl;
                LeftBtn.Enabled = match.LeftControl;
                SkipBtn.Enabled = match.SkipControl;
                DiceBtn.Enabled = match.DiceControl;
                SaveQuitBtn.Enabled = match.SaveQuitControl;
                StepL.Text = match.Step;
                TotalStepsL.Text = match.TotalSteps;
                IconPlayer.BackgroundImage = Image.FromFile(match.IconPlayer);
                EatBtn.Visible = match.EatBtnControl;
                if(match.DiceDisplayImage!=null)
                    DiceDisplay.BackgroundImage= Image.FromFile(match.DiceDisplayImage);
                PlayerTB.Text = match.SelectedPlayer;
                UpdateBoard(match.SelectedPlayer);
                if(match.MinotaurusLocation!=null)
                    Locate(match.MinotaurusLocation,Image.FromFile(Environment.CurrentDirectory+ "\\Images\\Taurus-icon.png"),Color.Black, ImageLayout.Stretch);
                if(match.EntitySelected=="E1")
                {
                    Locate(match.BlueLocation[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.DarkBlue, ImageLayout.Stretch);
                }
                else

                Locate(match.BlueLocation[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Blue, ImageLayout.Stretch);
                Locate(match.BlueLocation[2], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Blue, ImageLayout.Stretch);
                Locate(match.RedLocation[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Red, ImageLayout.Stretch);
                Locate(match.RedLocation[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Red, ImageLayout.Stretch);
                Locate(match.RedLocation[2], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Red, ImageLayout.Stretch);
                Locate(match.YellowLocation[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Yellow, ImageLayout.Stretch);
                Locate(match.YellowLocation[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Yellow, ImageLayout.Stretch);
                Locate(match.YellowLocation[2], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.Yellow, ImageLayout.Stretch);
                Locate(match.WhiteLocation[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.White, ImageLayout.Stretch);
                Locate(match.WhiteLocation[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.White, ImageLayout.Stretch);
                Locate(match.WhiteLocation[2], Image.FromFile(Environment.CurrentDirectory + "\\Images\\warrior.png"), Color.White, ImageLayout.Stretch);
                Locate(match.Walls[0].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[0].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[1].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[1].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[2].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[2].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[3].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[3].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[4].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[4].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[5].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[5].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[6].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[6].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[7].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[7].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[8].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[8].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[9].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[9].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[10].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[10].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[11].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[11].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[12].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[12].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[13].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[13].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[14].Split(' ')[0], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
                Locate(match.Walls[14].Split(' ')[1], Image.FromFile(Environment.CurrentDirectory + "\\Images\\wall-icon.png"), Color.Gray, ImageLayout.Tile);
            }
            
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire senza salvare?\n Le modifiche apportate andranno perse", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void DiceBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            switch(rnd.Next(1, 7))
            {
                case 1:
                    MessageBox.Show("E' uscita la faccia nera!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    DiceDisplay.BackgroundImage = null;
                    DiceDisplay.BackColor = Color.Black;
                    match.DiceDisplayImage = null;
                    match.DiceColor = "Black";
                    MessageBox.Show("Il Minotauro si è risvegliato!\nPremere sul pulsante del Minotauro a sinistra per prenderne il controllo!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MinotaurusBtn.Enabled = true;
                    match.MinotaurusControl = true;
                    E1.Visible = false;
                    E2.Visible = false;
                    E3.Visible = false;
                    break;
                case 2:
                    MessageBox.Show("E' uscita la faccia grigia!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackgroundImage = null;
                    DiceDisplay.BackColor = Color.Gray;
                    match.DiceDisplayImage = null;
                    match.DiceColor = "Gray";
                    MessageBox.Show("Puoi spostare un muretto!\nPremere sul pulsante del muro a sinistra per entrare nella modalità di selezione!\n(ATTENZIONE! Non puoi scegliere l'ultimo muretto che è stato spostato)", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WallBtn.Enabled = true;
                    match.WallControl = true;
                    E1.Visible = false;
                    E2.Visible = false;
                    E3.Visible = false;
                    break;
                case 3:
                    MessageBox.Show("E' uscito 3!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackColor = Color.White;
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-3-outline-icon.png");
                    match.DiceDisplayImage = Environment.CurrentDirectory + "\\images\\dice-3-outline-icon.png";
                    match.DiceColor = "White";
                    StepL.Text = "0";
                    TotalStepsL.Text = "3";
                    match.Step = "0";
                    match.TotalSteps = "3";
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    break;
                case 4:
                    MessageBox.Show("E' uscito 4!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackColor = Color.White;
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-4-outline-icon.png");
                    match.DiceDisplayImage = Environment.CurrentDirectory + "\\images\\dice-4-outline-icon.png";
                    match.DiceColor = "White";
                    StepL.Text = "0";
                    TotalStepsL.Text = "4";
                    match.Step = "0";
                    match.TotalSteps = "4";
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    break;
                case 5:
                    MessageBox.Show("E' uscito 5!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackColor = Color.White;
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-5-outline-icon.png");
                    match.DiceDisplayImage = Environment.CurrentDirectory + "\\images\\dice-5-outline-icon.png";
                    match.DiceColor = "White";
                    StepL.Text = "0";
                    TotalStepsL.Text = "5";
                    match.Step = "0";
                    match.TotalSteps = "5";
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    break;
                case 6:
                    MessageBox.Show("E' uscito 6!", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DiceDisplay.BackColor = Color.White;
                    DiceDisplay.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\dice-6-outline-icon.png");
                    match.DiceDisplayImage = Environment.CurrentDirectory + "\\images\\dice-6-outline-icon.png";
                    match.DiceColor = "White";
                    StepL.Text = "0";
                    TotalStepsL.Text = "6";
                    match.Step = "0";
                    match.TotalSteps = "6";
                    E1.Visible = true;
                    E2.Visible = true;
                    E3.Visible = true;
                    break;
            }
            DiceBtn.Enabled = false;
            match.DiceControl = DiceBtn.Enabled;
            match.E1Control = E1.Visible;
            match.E2Control = E2.Visible;
            match.E3Control = E3.Visible;
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if(EntityLocationTB.Text==E2.Tag.ToString() && E2.BackColor==Color.DarkBlue)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Blue, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkBlue)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Blue, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.DarkRed)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Red, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkRed)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Red, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.Orange)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Yellow, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.Orange)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Yellow, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.DarkGray)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.White, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkGray)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.White, E3.BackgroundImageLayout);
            if (E1.BackColor == Color.Blue)
            {
                E1.BackColor = Color.DarkBlue;
                E2.BackColor = Color.Blue;
                E3.BackColor = Color.Blue;
                IconPlayer.BackColor = Color.DarkBlue;
            }
                
            if (E1.BackColor == Color.Red)
            {
                E1.BackColor = Color.DarkRed;
                E2.BackColor = Color.Red;
                E3.BackColor = Color.Red;
                IconPlayer.BackColor = Color.DarkRed;
            }
            if (E1.BackColor == Color.Yellow)
            {
                E1.BackColor = Color.Orange;
                E2.BackColor = Color.Yellow;
                E3.BackColor = Color.Yellow;
                IconPlayer.BackColor = Color.Orange;
            }
            if (E1.BackColor == Color.White)
            {
                E1.BackColor = Color.DarkGray;
                E2.BackColor = Color.White;
                E3.BackColor = Color.White;
                IconPlayer.BackColor = Color.DarkGray;
            }
                
            Locate(E1.Tag.ToString(), E1.BackgroundImage, E1.BackColor, E1.BackgroundImageLayout);
            EntityLocationTB.Text = E1.Tag.ToString();
            match.EntityLocation = EntityLocationTB.Text;
            UpBtn.Enabled = true;
            match.UpControl = true;
            RightBtn.Enabled = true;
            match.RightControl = true;
            DownBtn.Enabled = true;
            match.DownControl = true;
            LeftBtn.Enabled = true;
            match.LeftControl = true;
            stepsHistory = new string[Convert.ToInt32(TotalStepsL.Text) - Convert.ToInt32(StepL.Text)];
            stepsHistoryIndex = 0;
            stepsHistory[stepsHistoryIndex] = EntityLocationTB.Text;
            match.EntitySelected = "E1";
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkBlue)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Blue, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkBlue)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Blue, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkRed)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Red, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkRed)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Red, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.Orange)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Yellow, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.Orange)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.Yellow, E3.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkGray)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.White, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E3.Tag.ToString() && E3.BackColor == Color.DarkGray)
                Locate(E3.Tag.ToString(), E3.BackgroundImage, Color.White, E3.BackgroundImageLayout);
            if (E2.BackColor == Color.Blue)
            {
                E1.BackColor = Color.Blue;
                E2.BackColor = Color.DarkBlue;
                E3.BackColor = Color.Blue;
                IconPlayer.BackColor = Color.DarkBlue;
            }
            if (E2.BackColor == Color.Red)
            {
                E1.BackColor = Color.Red;
                E2.BackColor = Color.DarkRed;
                E3.BackColor = Color.Red;
                IconPlayer.BackColor = Color.DarkRed;
            }
            if (E2.BackColor == Color.Yellow)
            {
                E1.BackColor = Color.Yellow;
                E2.BackColor = Color.Orange;
                E3.BackColor = Color.Yellow;
                IconPlayer.BackColor = Color.Orange;
            }
            if (E2.BackColor == Color.White)
            {
                E1.BackColor = Color.White;
                E2.BackColor = Color.DarkGray;
                E3.BackColor = Color.White;
                IconPlayer.BackColor = Color.DarkGray;
            }
            Locate(E2.Tag.ToString(), E2.BackgroundImage, E2.BackColor, E2.BackgroundImageLayout);
            EntityLocationTB.Text = E2.Tag.ToString();
            match.EntityLocation = EntityLocationTB.Text;
            UpBtn.Enabled = true;
            match.UpControl = true;
            RightBtn.Enabled = true;
            match.RightControl = true;
            DownBtn.Enabled = true;
            match.DownControl = true;
            LeftBtn.Enabled = true;
            match.LeftControl = true;
            stepsHistory = new string[Convert.ToInt32(TotalStepsL.Text) - Convert.ToInt32(StepL.Text)];
            stepsHistoryIndex = 0;
            stepsHistory[stepsHistoryIndex] = EntityLocationTB.Text;
            match.EntitySelected = "E2";
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.DarkBlue)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Blue, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkBlue)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Blue, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.DarkRed)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Red, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkRed)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Red, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.Orange)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.Yellow, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.Orange)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.Yellow, E1.BackgroundImageLayout);
            if (EntityLocationTB.Text == E2.Tag.ToString() && E2.BackColor == Color.DarkGray)
                Locate(E2.Tag.ToString(), E2.BackgroundImage, Color.White, E2.BackgroundImageLayout);
            if (EntityLocationTB.Text == E1.Tag.ToString() && E1.BackColor == Color.DarkGray)
                Locate(E1.Tag.ToString(), E1.BackgroundImage, Color.White, E1.BackgroundImageLayout);
            if (E3.BackColor == Color.Blue)
            {
                E1.BackColor = Color.Blue;
                E2.BackColor = Color.Blue;
                E3.BackColor = Color.DarkBlue;
                IconPlayer.BackColor = Color.DarkBlue;
            }
            if (E3.BackColor == Color.Red)
            {
                E1.BackColor = Color.Red;
                E2.BackColor = Color.Red;
                E3.BackColor = Color.DarkRed;
                IconPlayer.BackColor = Color.DarkRed;
            }
            if (E3.BackColor == Color.Yellow)
            {
                E1.BackColor = Color.Yellow;
                E2.BackColor = Color.Yellow;
                E3.BackColor = Color.Orange;
                IconPlayer.BackColor = Color.Orange;
            }
            if (E3.BackColor == Color.White)
            {
                E1.BackColor = Color.White;
                E2.BackColor = Color.White;
                E3.BackColor = Color.DarkGray;
                IconPlayer.BackColor = Color.DarkGray;
            }
            Locate(E3.Tag.ToString(), E3.BackgroundImage, E3.BackColor, E3.BackgroundImageLayout);
            EntityLocationTB.Text = E3.Tag.ToString();
            match.EntityLocation = EntityLocationTB.Text;
            UpBtn.Enabled = true;
            match.UpControl = true;
            RightBtn.Enabled = true;
            match.RightControl = true;
            DownBtn.Enabled = true;
            match.DownControl = true;
            LeftBtn.Enabled = true;
            match.LeftControl = true;
            stepsHistory = new string[Convert.ToInt32(TotalStepsL.Text) - Convert.ToInt32(StepL.Text)];
            stepsHistoryIndex = 0;
            stepsHistory[stepsHistoryIndex] = EntityLocationTB.Text;
            match.EntitySelected = "E3";
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            E1.Visible = false;
            match.E1Control = E1.Visible;
            E2.Visible = false;
            match.E2Control = E2.Visible;
            E3.Visible = false;
            match.E3Control = E3.Visible;
            UndoBtn.Enabled = true;
            match.UndoControl = true;
            stepsHistoryIndex++;
            StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) + 1);
            match.Step = StepL.Text;
            string location= EntityLocationTB.Text;
            int y = Convert.ToInt32(location.Split('y')[1]);
            string changing = Convert.ToString(y + 1);
            if(changing.Length==1)
            {
                EntityLocationTB.Text = location.Split('y')[0] + "y0" + changing;
                match.EntityLocation = EntityLocationTB.Text;
                Locate(location.Split('y')[0] + "y0" + changing, IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            else
            {
                EntityLocationTB.Text = location.Split('y')[0] + "y" + changing;
                match.EntityLocation = EntityLocationTB.Text;
                Locate(location.Split('y')[0]+"y"+changing, IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            RemoveEntity(location);
            switch (match.EntitySelected)
            {
                case "E1":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[0] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[0] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E2":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[1] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[1] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E3":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[2] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[2] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
            }

        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            E1.Visible = false;
            match.E1Control = E1.Visible;
            E2.Visible = false;
            match.E2Control = E2.Visible;
            E3.Visible = false;
            match.E3Control = E3.Visible;
            UndoBtn.Enabled = true;
            match.UndoControl = true;
            stepsHistoryIndex++;
            StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) + 1);
            match.Step = StepL.Text;
            string location = EntityLocationTB.Text;
            int x = Convert.ToInt32(location.Split('y')[0].Split('x')[1]);
            string changing = Convert.ToString(x + 1);
            if(changing.Length==1)
            {
                EntityLocationTB.Text = "x0" + changing + "y" + location.Split('y')[1];
                match.EntityLocation = EntityLocationTB.Text;
                Locate("x0" + changing + "y" + location.Split('y')[1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            else
            {
                EntityLocationTB.Text = "x" + changing + "y" + location.Split('y')[1];
                match.EntityLocation = EntityLocationTB.Text;
                Locate("x"+ changing + "y"+location.Split('y')[1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            RemoveEntity(location);
            if (Convert.ToInt32(StepL.Text) < Convert.ToInt32(TotalStepsL.Text))
                stepsHistory[Convert.ToInt32(StepL.Text)] = EntityLocationTB.Text;
            switch (match.EntitySelected)
            {
                case "E1":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[0] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[0] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E2":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[1] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[1] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E3":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[2] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[2] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
            }

        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            E1.Visible = false;
            match.E1Control = E1.Visible;
            E2.Visible = false;
            match.E2Control = E2.Visible;
            E3.Visible = false;
            match.E3Control = E3.Visible;
            UndoBtn.Enabled = true;
            match.UndoControl = true;
            stepsHistoryIndex++;
            StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) + 1);
            match.Step = StepL.Text;
            string location = EntityLocationTB.Text;
            int y = Convert.ToInt32(location.Split('y')[1]);
            string changing = Convert.ToString(y - 1);
            if(changing.Length==1)
            {
                EntityLocationTB.Text = location.Split('y')[0] + "y0" + changing;
                match.EntityLocation = EntityLocationTB.Text;
                Locate(location.Split('y')[0] + "y0" + changing, IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            else
            {
                EntityLocationTB.Text = location.Split('y')[0] + "y" + changing;
                match.EntityLocation = EntityLocationTB.Text;
                Locate(location.Split('y')[0]+"y"+ changing, IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            RemoveEntity(location);
            if (Convert.ToInt32(StepL.Text) < Convert.ToInt32(TotalStepsL.Text))
                stepsHistory[Convert.ToInt32(StepL.Text)] = EntityLocationTB.Text;

            switch (match.EntitySelected)
            {
                case "E1":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[0] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[0] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E2":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[1] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[1] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E3":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[2] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[2] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
            }

        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            E1.Visible = false;
            match.E1Control = E1.Visible;
            E2.Visible = false;
            match.E2Control = E2.Visible;
            E3.Visible = false;
            match.E3Control = E3.Visible;
            UndoBtn.Enabled = true;
            match.UndoControl = true;
            stepsHistoryIndex++;
            StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) + 1);
            match.Step = StepL.Text;
            string location = EntityLocationTB.Text;
            int x = Convert.ToInt32(location.Split('y')[0].Split('x')[1]);
            string changing = Convert.ToString(x - 1);
            if(changing.Length==1)
            {
                EntityLocationTB.Text = "x0" + changing + "y" + location.Split('y')[1];
                match.EntityLocation = EntityLocationTB.Text;
                Locate("x0" + changing + "y" + location.Split('y')[1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            else
            {
                EntityLocationTB.Text = "x" + changing + "y" + location.Split('y')[1];
                match.EntityLocation = EntityLocationTB.Text;
                Locate("x" + changing + "y" + location.Split('y')[1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
            }
            RemoveEntity(location);
            if (Convert.ToInt32(StepL.Text) < Convert.ToInt32(TotalStepsL.Text))
                stepsHistory[Convert.ToInt32(StepL.Text)] = EntityLocationTB.Text;
            switch (match.EntitySelected)
            {
                case "E1":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[0] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[0] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[0] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E2":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[1] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[1] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[1] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
                case "E3":
                    if (IconPlayer.BackColor == Color.DarkBlue)
                    {
                        match.BlueLocation[2] = EntityLocationTB.Text;
                        CheckBase("BLUE");
                        CheckTemple("BLUE");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkRed)
                    {
                        match.RedLocation[2] = EntityLocationTB.Text;
                        CheckBase("RED");
                        CheckTemple("RED");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.Orange)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("YELLOW");
                        CheckTemple("YELLOW");
                        CheckBattlefield();
                    }
                    if (IconPlayer.BackColor == Color.DarkGray)
                    {
                        match.YellowLocation[2] = EntityLocationTB.Text;
                        CheckBase("WHITE");
                        CheckTemple("WHITE");
                        CheckBattlefield();
                    }
                    break;
            }

        }

        private void SaveQuitBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sei sicuro di voler salvare e uscire?\n Le modifiche apportate verrano salvate in modo permanente.", "MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                match.Step = StepL.Text;
                match.TotalSteps =TotalStepsL.Text;
                match.UndoControl = false;
                if(StepL.Text!="0")
                {
                    match.E1Control = false;
                    match.E2Control = false;
                    match.E3Control = false;
                }
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
                this.Close();
            }
        }

        private void SequenceBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(match.GameSequence, "ORDINE DI GIOCO", MessageBoxButtons.OK);
        }

        private void MinotaurusBtn_Click(object sender, EventArgs e)
        {
            E1.Visible = false;
            E2.Visible = false;
            E3.Visible = false;
            match.E1Control = false;
            match.E2Control = false;
            match.E3Control = false;
            Color team = IconPlayer.BackColor;
            IconPlayer.BackColor = Color.Black;
            IconPlayer.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\images\\Taurus-icon.png");
            if (IconPlayer.BackColor == Color.Blue)
            {
                Locate("x17y14", IconPlayer.BackgroundImage, Color.Black, IconPlayer.BackgroundImageLayout);
                EntityLocationTB.Text = "x17y14";
            }
            if (IconPlayer.BackColor == Color.Red)
            {
                Locate("x14y17", IconPlayer.BackgroundImage, Color.Black, IconPlayer.BackgroundImageLayout);
                EntityLocationTB.Text = "x14y17";
            }
            if (IconPlayer.BackColor == Color.Yellow)
            {
                Locate("x14y14", IconPlayer.BackgroundImage, Color.Black, IconPlayer.BackgroundImageLayout);
                EntityLocationTB.Text = "x14y14";
            }
            if (IconPlayer.BackColor == Color.White)
            {
                Locate("x17y17", IconPlayer.BackgroundImage, Color.Black, IconPlayer.BackgroundImageLayout);
                EntityLocationTB.Text = "x17y17";
            }
            StepL.Text = "0";
            match.Step = "0";
            TotalStepsL.Text = Convert.ToString(match.MinotaurusStepsNum);
            match.MinotaurusLocation = EntityLocationTB.Text;
            MinotaurusBtn.Enabled = false;
            match.MinotaurusControl = false;
            UpBtn.Enabled = true;
            match.UpControl = true;
            RightBtn.Enabled = true;
            match.RightControl = true;
            DownBtn.Enabled = true;
            match.DownControl = true;
            LeftBtn.Enabled = true;
            match.LeftControl = true;
        }

        private void StepL_TextChanged(object sender, EventArgs e)
        {
            if(StepL.Text==TotalStepsL.Text)
            {
                if (MessageBox.Show("Hai terminato i passi, confermi questa posizione?","MINOTAURUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ChangePlayer();
                    MessageBox.Show($"E' il turno di {match.GameSequence.Split(' ')[match.PlayerIndex]}", "MINOTAURUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBoard(match.GameSequence.Split(' ')[match.PlayerIndex]);
                }
                else
                {
                    RemoveEntity(EntityLocationTB.Text);
                    Locate(stepsHistory[Convert.ToInt32(StepL.Text) - 1], IconPlayer.BackgroundImage, IconPlayer.BackColor, IconPlayer.BackgroundImageLayout);
                    EntityLocationTB.Text = stepsHistory[Convert.ToInt32(StepL.Text) - 1];
                    StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) - 1);
                }
            }

        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            RemoveEntity(EntityLocationTB.Text);
            Locate(stepsHistory[Convert.ToInt32(StepL.Text) - 1],IconPlayer.BackgroundImage,IconPlayer.BackColor,IconPlayer.BackgroundImageLayout);
            EntityLocationTB.Text = stepsHistory[Convert.ToInt32(StepL.Text) - 1];
            StepL.Text = Convert.ToString(Convert.ToInt32(StepL.Text) - 1);

        }
    }
}
