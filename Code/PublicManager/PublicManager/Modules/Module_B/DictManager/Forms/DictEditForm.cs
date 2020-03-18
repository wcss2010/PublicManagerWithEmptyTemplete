﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PublicManager.Modules.Module_B.DictManager.Forms
{
    public partial class DictEditForm : Form
    {
        public DictEditForm()
        {
            InitializeComponent();
        }

        public string ProfessionName
        {
            get
            {
                return txtProfessionName.Text;
            }
            set
            {
                txtProfessionName.Text = value;
            }
        }

        public bool IsAcceptModify
        {
            get
            {
                return cbIsAcceptModify.Checked;
            }
            set
            {
                cbIsAcceptModify.Checked = value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}