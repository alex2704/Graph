using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Граф
{
    public class Utils
    {       
        public static MyNode AddNodeFromFile (string st)
        {
            MyNode node = new MyNode();
            
            string[] xx = st.Split();
            node.x = int.Parse(xx[0]);
            node.y = int.Parse(xx[1]);
            node.name = xx[2];

            return node;
        }

        public static int[,] LoadMatrix(string fname, out string[] lines)
        {
            lines = File.ReadAllLines(fname);
            int a = lines.Length;
            for (int i = 0; i < lines.Length; i++)
            {
                MakeStringClear(lines[i]);
            }
            int b = lines[0].Length;
            int[,] matrix = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = int.Parse(lines[i][j].ToString());
                }
            }
            return matrix;
        }

        public static int[] LoadMat(string filename, string line, int N)
        {           
            int[] matrix = new int[N];

            string[] yy = line.Split();

            for (int j = 0; j < N; j++)
            {
                matrix[j] = Convert.ToInt32(yy[j]);
            }            

            return matrix;
        }

        public static void MakeStringClear(string inputString)
        {
            inputString = inputString.Replace("  ", string.Empty);
            inputString = inputString.Trim().Replace(" ", string.Empty);
            inputString = inputString.Replace(",", string.Empty);
        }

        private static void Help0(MyNode node)
        {
            node.flag = true;

            for(int i = 0; i < node.neighbours.Count; i++)
            {
                node.neighbours[i].end.Trek = true;
            }
        }

        private static void Help(MyGraph graph)
        {
            Help0(graph.nodes[0]);
            
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                if(graph.nodes[i].Trek && !graph.nodes[i].flag)
                {
                    Help0(graph.nodes[i]);
                    i = 0;
                }
            }
        }


        /*private void Help3(MyNode n)
        {
            if (n == null || n.flag)
                return;
            n.flag = true;
            for (int i = 0; i < n.neighbours.Count; i++)
            {
                Help3(n.neighbours[i].end);
                Help3(n.neighbours[i].start);
            }
        }*/

        public static bool CheckOposredovan(MyGraph graph)
        {
            for(int n = 0; n < graph.nodes.Count; n++)
            {
                graph.nodes[n].flag = false;
                graph.nodes[n].Trek = false;
            }
            Help(graph);

            bool YesOrNo = true;

            for (int i = 0; i < graph.nodes.Count; i++)
            {
                if(!graph.nodes[i].flag)
                {
                    YesOrNo = false;
                }
            }
            return YesOrNo;
        }
    }
}
