using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Граф
{
    public partial class FormGraph : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        MyGraph graph;

        int sN1 = -1, 
            sN2 = -1;
        bool drawing = false;

        public FormGraph()
        {
            InitializeComponent();            
        }

        private MyNode FindNode(int x, int y)
        {
            int delta = 20;
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                if (Math.Abs(graph.nodes[i].x - x) < delta && Math.Abs(graph.nodes[i].y - y) < delta)
                {
                    return graph.nodes[i];
                }
            }
            return null;
        }

        private void btn_AddNode_Click(object sender, EventArgs e)
        {            
            AddNode form = new AddNode();
            
            form.ShowDialog();

            graph.nodes.Add(form.AddedNode());
            Draw();
        }

        private void Draw()
        {
            graph.DrawAllGraph(graph);
            pb_Graph.Image = graph.GetBitmap();
        }

        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            StreamReader str = new StreamReader(openFileDialog.FileName);

            graph.nodes.Clear();
            Draw();

            int N = Convert.ToInt32(str.ReadLine());
            int numOfLine = 0;
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N*2; i++)
            {
                string s = str.ReadLine();

                if (i < N)
                {
                    graph.nodes.Add(Utils.AddNodeFromFile(s));
                }

                if (i >= N)
                {
                    int[] helpmat = Utils.LoadMat(openFileDialog.FileName, s, N);

                    for (int m = 0; m < N; m++)
                    {
                        matrix[numOfLine, m] = helpmat[m];
                    }
                    
                    numOfLine++;
                }                
            }
            for (int k = 0; k < N; k++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[k, j] == 1)
                    {
                        graph.nodes[k].neighbours.Add(new MyEdge(graph.nodes[k], graph.nodes[j]));
                    }
                }
            }
            Draw();
        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            graph = new MyGraph(pb_Graph.Width, pb_Graph.Height);
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            bool ye = Utils.CheckOposredovan(graph);
            if(ye)
            {
                MessageBox.Show("Можно всех опосредованно перезнакомить");
            }
            else
            {
                MessageBox.Show("Нельзя всех опосредованно перезнакомить");
            }
        }

        private void pb_Graph_MouseDown(object sender, MouseEventArgs e)
        {
            graph.selectedNode = FindNode(e.X, e.Y);
            drawing = graph.selectedNode != null;
        }

        private void pb_Graph_MouseMove(object sender, MouseEventArgs e)
        {
            if(cb_GoOnNode.Checked)
            {
                if (graph.selectedNode == null)
                {
                    return;
                }
                graph.Delta(graph.selectedNode, graph.selectedNode.x - e.X, graph.selectedNode.y - e.Y + 10);
                Draw();
            }
        }

        private void pb_Graph_MouseUp(object sender, MouseEventArgs e)
        {
            graph.DeSelect();
            drawing = false;
            Draw();
        }

        private void btn_DeleteNode_Click(object sender, EventArgs e)
        {
            btn_DeleteNode.Enabled = false;
        }

        private void btn_AddEdge_Click(object sender, EventArgs e)
        {
            btn_AddEdge.Enabled = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            graph.nodes.Clear();
            Draw();
        }

        private void btn_DeleteEdge_Click(object sender, EventArgs e)
        {
            btn_DeleteEdge.Enabled = false;
            lb_Instruction.Text = "Выберете две вершины,\nмежду которыми хотите\nудалить ребро";
        }

        private void pb_Graph_MouseClick(object sender, MouseEventArgs e)
        {
            if (btn_DeleteNode.Enabled == false)
            {                
                graph.selectedNode = FindNode(e.X, e.Y);

                if (graph.selectedNode == null)
                {
                    return;
                }

                for (int i = 0; i < graph.selectedNode.neighbours.Count; i++)
                {
                    if (graph.selectedNode == null)
                    {
                        return;
                    }                    
                    graph.selectedNode.neighbours[i].end.neighbours.Remove(graph.selectedNode.neighbours[i].end.GetMyEdge(graph.selectedNode));
                }

                graph.nodes.Remove(graph.selectedNode);
                
                graph.DeSelect();
                Draw();
                btn_DeleteNode.Enabled = true;
            }  
            if (btn_AddEdge.Enabled == false)
            {
                for (int i = 0; i < graph.nodes.Count; i++)
                {
                    graph.selectedNode = FindNode(e.X, e.Y);
                    if (sN1 == -1)
                    {
                        sN1 = graph.nodes.IndexOf(graph.selectedNode);
                        graph.nodes[sN1].selectedNode = true;
                        break;
                    }
                    if (sN2 == -1)
                    {
                        sN2 = graph.nodes.IndexOf(graph.selectedNode);
                        if(sN2 == -1)
                        {
                            return;
                        }
                        graph.nodes[sN1].neighbours.Add(new MyEdge(graph.nodes[sN1], graph.nodes[sN2]));
                        graph.nodes[sN2].neighbours.Add(new MyEdge(graph.nodes[sN2], graph.nodes[sN1]));

                        sN1 = -1;
                        sN2 = -1;
                        graph.DeSelect();
                        btn_AddEdge.Enabled = true;
                        for (int n = 0; n < graph.nodes.Count; n++)
                        {
                            graph.nodes[n].selectedNode = false;
                        }
                        break;
                    }
                }
            }
            if (btn_DeleteEdge.Enabled == false)
            {
                for (int i = 0; i < graph.nodes.Count; i++)
                {
                    graph.selectedNode = FindNode(e.X, e.Y);
                    if (sN1 == -1)
                    {
                        sN1 = graph.nodes.IndexOf(graph.selectedNode);
                        graph.nodes[sN1].selectedNode = true;
                        lb_Instruction.Text = "Выберете вторую вершину";
                        break;
                    }
                    if (sN2 == -1)
                    {
                        sN2 = graph.nodes.IndexOf(graph.selectedNode);
                        if (sN2 == -1)
                        {
                            return;
                        }
                        graph.nodes[sN1].neighbours.Remove(graph.nodes[sN1].GetMyEdge(graph.nodes[sN2]));
                        graph.nodes[sN2].neighbours.Remove(graph.nodes[sN2].GetMyEdge(graph.nodes[sN1]));

                        sN1 = -1;
                        sN2 = -1;
                        graph.DeSelect();
                        btn_DeleteEdge.Enabled = true;
                        lb_Instruction.Text = null;
                        for (int n = 0; n < graph.nodes.Count; n++)
                        {
                            graph.nodes[n].selectedNode = false;
                        }
                        Draw();
                        break;
                    }
                }
            }
        }
    }
}
