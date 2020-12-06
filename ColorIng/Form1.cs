using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorIng
{
    public partial class frmMain : Form
    {
        List<Color> colorsList = new List<Color>();
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            pnlChoosedColor.BackColor = color.Color;
        }

        private void btnAddColorToList_Click(object sender, EventArgs e)
        {
            
            colorsList.Add(pnlChoosedColor.BackColor);
            for (int i = 0; i < colorsList.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(10, 10);
                panel.Location = new Point(15 * i, 20);
                panel.BackColor = colorsList[i];
                gbColorsInList.Controls.Add(panel);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            if(colorsList.Count > 0)
            {
                pnlColor.BackColor = colorsList[r.Next(colorsList.Count)];
            }
        }
    }
}
