using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Nhom9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UD_btn_Click(object sender, EventArgs e)
        {
            Process.Start("QLSV9");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Info Form2 = new Frm_Info();
            Form2.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void DN_btn_Click(object sender, EventArgs e)
        {
            Frm_Dn Form2 = new Frm_Dn();
            Form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Frm = new Form2();
            Frm.Show();
        }
    }
}
