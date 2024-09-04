using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace Minotaurus
{
    class Match
    {
        public int Index { get; set; }
        public bool New { get; set; }
        public DateTime Date { get; set; }
        public string[] Players { get; set; }
        public string[] PlayersCopy { get; set; }
        public string GameSequence { get; set; }
        public string[] Teams { get; set; }
        public int MinotaurusStepsNum { get; set; }
        public string SelectedPlayer { get; set; }
        public string EntityLocation { get; set; }
        public string[] BlueLocation { get; set; }
        public string[] RedLocation { get; set; }
        public string[] YellowLocation { get; set; }
        public string[] WhiteLocation { get; set; }
        public string MinotaurusLocation { get; set; }
        public string Base { get; set; }
        public string Field { get; set; }
        public string Temple { get; set; }
        public string Step { get; set; }
        public string TotalSteps { get; set; } 
        public string[] Walls { get; set; }
        public string LastWallMoved { get; set; }
        public bool SequenceControl { get; set; }
        public bool MinotaurusControl { get; set; }
        public bool WallControl { get; set; }
        public bool UndoControl { get; set; }
        public bool UpControl { get; set; }
        public bool RightControl { get; set; }
        public bool DownControl { get; set; }
        public bool LeftControl { get; set; }
        public bool SkipControl { get; set; }
        public bool SaveQuitControl { get; set; }
        public bool DiceControl { get; set; }
        public string IconPlayer { get; set; }
        public string IconColor { get; set; }
        public string DiceDisplayImage { get; set; }
        public string DiceColor { get; set; }
        public bool EatBtnControl { get; set; }
        public bool E1Control { get; set; }
        public bool E2Control { get; set; }
        public bool E3Control { get; set; }
        public string EntitySelected { get; set; }
        public int PlayerIndex { get; set; }
        

    }
}
