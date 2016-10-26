using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using P8Coder.Core;

namespace P8Coder
{
    public partial class FunctionForm : Form
    {
        public string FunctionName { get { return nameInput.Text; } }

        private Function func;

        public FunctionForm(Function func)
        {
            InitializeComponent();
            this.func = func;
            nameInput.Text = func.Name;
            nameInput.Focus();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            func.Name = nameInput.Text;
            Close();
        }

    }
}
