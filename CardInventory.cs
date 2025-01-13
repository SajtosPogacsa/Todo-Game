using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class CardInventory : Form
    {
        const string PATH = @"Properties\\Resources\\";
        FrmMain main = (FrmMain)Application.OpenForms["FrmMain"];
        Random rnd = new();
        int[] counts = [0, 0, 0, 0, 0, 0];


        public CardInventory()
        {
            InitializeComponent();
            this.Load += CardInventoryLoad;
            StatRefresh();
            rollBtn.Click += RollBtnClick;
            this.FormClosing += CardInventoryFormClosing;
        }



        private void RollBtnClick(object? sender, EventArgs e)
        {
            if (main.user.Money - 100 < 0)
            {
                MessageBox.Show("You don't have enough money!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            main.user.Money -= 100;
            StatRefresh();
            rollBtn.Enabled = false;
            int rndNum = rnd.Next(0, 101);

            switch (rndNum)
            {
                case 1:
                    MessageBox.Show("!!!You found a Cat!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[0] += 1;
                    label1.Text = $"{counts[0]} Cat";
                    break;
                case < 5:
                    MessageBox.Show("!!!You found a Fox!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[1] += 1;
                    label2.Text = $"{counts[1]} Fox";
                    break;
                case < 15:
                    MessageBox.Show("!!!You found a Furry!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[2] += 1;
                    label3.Text = $"{counts[2]} Furry";
                    break;
                case < 30:
                    MessageBox.Show("!!!You found a Cat 2!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[3] += 1;
                    label4.Text = $"{counts[3]} Cat2";
                    break;
                case < 50:
                    MessageBox.Show("!!!You found a Pig!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[4] += 1;
                    label5.Text = $"{counts[4]} Pig";
                    break;
                case < 75:
                    MessageBox.Show("!!!You found a Dog!!!!", "CONGRATS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counts[5] += 1;
                    label6.Text = $"{counts[5]} Dog";
                    break;
                default:
                    MessageBox.Show("!!!You didn't find anything!!!", "😥!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            Thread.Sleep(1000);
            rollBtn.Enabled = true;
        }

        private void CardInventoryLoad(object? sender, EventArgs e)
        {
            FileStream fs = new("carddata.bin", FileMode.OpenOrCreate);

            if (fs.Length != 0)
            {
                {
                    using (BinaryReader br = new(fs))
                    {

                        for (int i = 0; i < counts.Length; i++)
                        {
                            counts[i] = br.ReadInt32();
                        }
                    }
                }
            }

            int j = 1;
            foreach (var item in this.Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox pbx = item as PictureBox;

                    pbx.ImageLocation = @$"{PATH}\\pic{j}.jpg";
                    j += 1;
                }
            }

            label1.Text = $"{counts[0]} Cat";
            label2.Text = $"{counts[1]} Fox";
            label3.Text = $"{counts[2]} Furry";
            label4.Text = $"{counts[3]} Cat 2";
            label5.Text = $"{counts[4]} Pig";
            label6.Text = $"{counts[5]} Dog";

            fs.Close();
        }

        private void CardInventoryFormClosing(object? sender, FormClosingEventArgs e)
        {
            FileStream fs = new("carddata.bin", FileMode.OpenOrCreate);

            using (BinaryWriter bw = new(fs))
            {
                for (int i = 0; i < counts.Length; i++)
                {
                    bw.Write(counts[i]);
                }
            }

            fs.Close();
        }

        private void StatRefresh()
        {
            lvlLbl.Text = $"Level {main.user.Lvl.ToString()}";
            xpLbl.Text = $"{main.user.Xp.ToString()}/{main.user.XpNeeded} XP";
            goldLbl.Text = $"{main.user.Money.ToString()}G";
        }
    }
}
