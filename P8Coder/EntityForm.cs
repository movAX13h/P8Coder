using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using P8Coder.Core;

namespace P8Coder
{
    public partial class EntityForm : Form
    {
        private Entity entity;

        public EntityForm(Entity ent)
        {
            InitializeComponent();
            entity = ent;
            fillControls();
            functionsList.SelectedIndex = 0;            
        }

        private void fillControls()
        {
            nameInput.Text = entity.Name;
            functionsList.Items.Clear();

            foreach (Function func in entity.Functions)
            {
                functionsList.Items.Add(func, func.Enabled);
            }
        }

        private void showFunctionForm(Function func)
        {
            FunctionForm form = new FunctionForm(func);
            form.ShowDialog();
            form.Dispose();
            functionsList.Invalidate();
        }

        // Event handlers

        private void renameBtn_Click(object sender, EventArgs e)
        {
            Function func = (Function)functionsList.SelectedItem;
            showFunctionForm(func);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            Function func = (Function)functionsList.SelectedItem;
            if (MessageBox.Show("Do you really want to delete function '" + func.Name + "'?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                functionsList.Items.Remove(func);
                entity.Functions.Remove(func);
            }

            if (functionsList.Items.Count == 0)
            {
                renameBtn.Enabled = false;
                delBtn.Enabled = false;
            }
            else functionsList.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            store();
            Function func = new Function("newFunction", "function newFunction"+entity.Name.ToLower()+"()\nend");
            entity.Functions.Add(func);
            fillControls();
            functionsList.SelectedItem = func;
            showFunctionForm(func);
            delBtn.Enabled = true;
            renameBtn.Enabled = true;
        }

        private void store()
        {
            entity.Name = nameInput.Text;

            var checkeds = functionsList.CheckedItems;
            foreach (Function func in entity.Functions)
            {
                func.Enabled = checkeds.Contains(func);
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (functionsList.Items.Count == 0)
            {
                MessageBox.Show("An entity must have at least 1 function!", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            store();
            Close();
        }

        private void funcUpBtn_Click(object sender, EventArgs e)
        {
            Function func = (Function)functionsList.SelectedItem;
            int index = functionsList.SelectedIndex;
            if (index > 0)
            {
                index--;
                
                entity.Functions.Remove(func);
                entity.Functions.Insert(index, func);
                
                fillControls();
                functionsList.SelectedIndex = index;
            }
        }

        private void funcDownBtn_Click(object sender, EventArgs e)
        {
            Function func = (Function)functionsList.SelectedItem;
            int index = functionsList.SelectedIndex;
            if (index < functionsList.Items.Count - 1)
            {
                index++;
                entity.Functions.Remove(func);
                entity.Functions.Insert(index, func);

                fillControls();
                functionsList.SelectedIndex = index;
            }
        }

    }
}
