using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCamel
{
    public partial class MainForm : Form
    {
        public bool Loaded
        {
            get
            {
                return loaded;
            }
        }
        bool loaded = false;

        ABCDatabase database = new ABCDatabase();

        public MainForm()
        {
            InitializeComponent();
            try
            {
                database.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(this, 
                    e.ToString(), 
                    "Couldn't open the database!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            loaded = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
