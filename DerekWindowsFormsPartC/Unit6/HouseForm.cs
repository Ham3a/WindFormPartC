using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamzaWindowsFormsPartC.Unit6
{
    public partial class HouseForm : Form
    {
        public HouseForm()
        {
            InitializeComponent();
        }

        private void PaintHouse(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen myPen = new Pen(Brushes.Red, 8);
            g.DrawRectangle(myPen, 300, 200, 300, 200);

            myPen = new Pen(Brushes.Blue, 8);
            g.DrawRectangle(myPen, 440, 320, 30, 80);

            myPen = new Pen(Brushes.Blue, 8);
            g.DrawRectangle(myPen, 350, 290, 40, 40);

            myPen = new Pen(Brushes.Blue, 8);
            g.DrawRectangle(myPen, 500, 290, 40, 40);

            drawHexagon(g);
        }
        private void drawHexagon(Graphics g)
        {
            int x = 300; int y = 200; int size = 100;

            Pen myPen = new Pen(Color.GreenYellow, 10);

            Point[] hexagon = new Point[]
            {
                new Point(x, y),
                new Point(x + size, y - size),
                new Point(x + 2 * size, y - size),
                new Point(x + 3 * size, y),
               // new Point(x + 2 * size, y + size),
                //new Point(x + size, y + size)
            };

            g.DrawPolygon(myPen, hexagon);
            g.FillPolygon(Brushes.Yellow, hexagon);

            Font myFont = new Font("Courier", 30);
            g.DrawString("Hamza's House", myFont, Brushes.Red, 120, 420);
        }
    }
}
