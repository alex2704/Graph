using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Граф
{
    public class MyEdge
    {
        public MyNode start, end;

        public MyEdge(MyNode s, MyNode e)
        {
            start = s;
            end = e;
        }
    }

    public class MyNode
    {
        public int x, y;
        public string name;
        public List<MyEdge> neighbours;
        public bool flag = false;
        public bool Trek = false;
        public bool selectedNode = false;        

        public MyNode()
        {                    
            neighbours = new List<MyEdge>();
        }

        public MyEdge GetMyEdge(MyNode end)
        {
            for(int i = 0; i < neighbours.Count; i++)
            {
                if(neighbours[i].end == end)
                {
                    return neighbours[i];
                }
            }
            return null;
        }
    }

    public class MyGraph
    {
        public List<MyNode> nodes;
        public int R = 20;
        public MyNode selectedNode;

        Bitmap bitmap;
        Pen blackPen;
        Pen pinkPen;
        Pen bluePen;
        Pen redPen;
        Font f;
        PointF point;

        Graphics g;

        public MyGraph(int width, int height)
        {
            nodes = new List<MyNode>();

            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);
            f = new Font("Segoe UI", 15);
            redPen = new Pen(Color.Red)
            {
                Width = 2
            };
            pinkPen = new Pen(Color.DeepPink)
            {
                Width = 3/2
            };
            blackPen = new Pen(Color.Black)
            {
                Width = 3/2
            };
            bluePen = new Pen(Color.DarkBlue)
            {
                Width = 2
            };
        }

        public void Delta(MyNode N, int dx, int dy)
        {
            if (N != null)
            {
                N.x -= dx;
                N.y -= dy;
            }
            else return;
        }       

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void DeSelect()
        {
            selectedNode = null;
        }

        public void clearPictureBox()
        {
            g.Clear(Color.White);
        }

        public void DrawAllGraph(MyGraph graph)
        {
            clearPictureBox();
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                for (int j = 0; j < nodes[i].neighbours.Count; j++)
                {
                    g.DrawLine(blackPen, nodes[i].neighbours[j].start.x, nodes[i].neighbours[j].start.y, nodes[i].neighbours[j].end.x, nodes[i].neighbours[j].end.y);
                }
            }

            for (int i = 0; i < graph.nodes.Count; i++)
            {                
                if (graph.nodes[i] == graph.selectedNode)
                {
                    DrawNode(graph.nodes[i].x, graph.nodes[i].y, graph.nodes[i].name, redPen, Brushes.LightPink);
                }
                else
                {
                    DrawNode(graph.nodes[i].x, graph.nodes[i].y, graph.nodes[i].name, pinkPen, Brushes.LightPink);
                }
                if (graph.nodes[i].selectedNode)
                {
                    DrawNode(graph.nodes[i].x, graph.nodes[i].y, graph.nodes[i].name, bluePen, Brushes.LightPink);
                }
            }
        }

        public void DrawNode(int x, int y, string name, Pen pen, Brush brush)
        {
            g.FillRectangle(brush, x - R, y , name.Length * 13, R * 3/2);
            g.DrawRectangle(pen, x - R, y , name.Length * 13, R * 3/2);
            point = new PointF(x - 17, y);
            g.DrawString(name, f, Brushes.Black, point);
        }
    }
}
