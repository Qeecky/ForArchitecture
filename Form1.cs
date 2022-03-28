using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForArchitecture
{
    public partial class Form1 : Form, IView
    {
        IModel iModel;
        public Form1(IModel model)
        {
            InitializeComponent();
            this.iModel = model;
            
        }

        public void show()
        {
            //throw new NotImplementedException();
            //List<List<int>> matrix; 
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            
            //Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
