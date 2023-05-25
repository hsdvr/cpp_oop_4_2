using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Лабораторная_работа_4_2
{
    public partial class frmMain : Form
    {
        ABC model;
        public frmMain()
        {
            InitializeComponent();

            model = new ABC();
            model.NeedUpdate += new ABC.NeedUpdateHandler(ChangeValue);
            ChangeValue(model, e: null);
        }


        private void txtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox obj = sender as TextBox;
                int Value;
                bool flag = int.TryParse(obj.Text, out Value);
                if (flag)
                {
                    model[(int)obj.Tag] = Value;
                }
                else
                {
                    ChangeValue(model, e: null);
                }
            }
        }
        private void txtBx_LostFocus(object sender, EventArgs e)
        {
            TextBox obj = sender as TextBox;
            int Value;
            bool flag = int.TryParse(obj.Text, out Value);
            if (flag)
            {
                model[(int)obj.Tag] = Value;
            }
            else
            {
                ChangeValue(model, e: null);
            }
        }
        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;
            model[(int)obj.Tag] = (int)obj.Value;
        }

        private void numUD_LostFocus(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;
            if (obj.Text == "")
            {
                obj.Text = model[(int)obj.Tag].ToString();
            }
            model[(int)obj.Tag] = (int)obj.Value;
        }

        private void trckBr_ValueChanged(object sender, EventArgs e)
        {
            TrackBar obj = sender as TrackBar;
            if (model[(int)obj.Tag] / 10 == (int)obj.Value)
            {
                return;
            }
            model[(int)obj.Tag] = (int)obj.Value * 10;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.SaveNumbers();
        }

        void ChangeValue(object sender, EventArgs e)
        {
            ABC obj = sender as ABC;
            txtBxA.Text = obj[0].ToString();
            numUDA.Value = obj[0];
            trckBrA.Value = obj[0] / 10;
            txtBxB.Text = obj[1].ToString();
            numUDB.Value = obj[1];
            trckBrB.Value = obj[1] / 10;
            txtBxC.Text = obj[2].ToString();
            numUDC.Value = obj[2];
            trckBrC.Value = obj[2] / 10;
        }
    }
}
