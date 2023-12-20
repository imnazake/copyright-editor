using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyrightEditor
{
    public partial class ErrorsForm : Form
    {
        public ErrorsForm()
        {
            InitializeComponent();
        }

        private void ErrorsForm_Load(object sender, EventArgs e)
        {
            
        }

        public void SetErrors(string Errors)
        {
            ErrorsList.Text += Errors; 
        }
    }
}
