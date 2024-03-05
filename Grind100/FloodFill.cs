using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind100
{
    partial class Program
    {
        public  static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            //save orig color
            int origColor = image[sr][sc];

            // create Queue
            Queue<int> row = new Queue<int>();
            Queue<int> col = new Queue<int>();
            bool[,] visited = new bool[image.Length, image[0].Length];
            row.Enqueue(sr);
            col.Enqueue(sc);
            
            while(row.Count > 0)
            {
                int r = row.Dequeue();
                int c = col.Dequeue();
                visited[r,c] = true;
                if (image[r][c] == origColor) image[r][c] = color;

                if (c - 1 >= 0 && !visited[r, c - 1] && image[r][c - 1] == origColor)
                {
                    row.Enqueue(r);
                    col.Enqueue(c - 1);
                }
                if (r-1>=0  && !visited[r - 1,c] && image[r-1][c] == origColor)
                {
                    row.Enqueue(r - 1);
                    col.Enqueue(c);
                }

                if (r + 1 < image.Length && !visited[r + 1, c] && image[r+1][c] == origColor)
                {
                    row.Enqueue(r + 1);
                    col.Enqueue(c);
                }
               
                if (c +1 < image[0].Length && !visited[r, c+1] && image[r][c+1] == origColor)
                {
                    row.Enqueue(r);
                    col.Enqueue(c +1);
                }
            }

            return image;

        }
    }
}
