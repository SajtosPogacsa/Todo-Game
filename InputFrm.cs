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
    public partial class InputFrm : Form
    {
        public Information inf = new();

        public InputFrm()
        {
            InitializeComponent();
            okBtn.Click += OkBtnClick;
        }

        private void OkBtnClick(object? sender, EventArgs e)
        {

            inf.Name = nameTbx.Text;
            inf.Complexity = compCb.SelectedItem.ToString();
            inf.Time = timeCb.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
