using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Граф
{
    public partial class AddNode : Form
    {
        public MyNode AddedNode()
        {
            MyNode node = new MyNode();

            node.x = 35;
            node.y = 25;
            node.name = tb_Input.Text;

            return node;
        }

        public AddNode()
        {
            InitializeComponent();
        }

        private void btn_AddNode_Click(object sender, EventArgs e)
        {
            string name = tb_Input.Text;
            Close();
        }        
    }
}
