using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Bitmap HandlerTexure = Resource1.Handler,
            TargetTexture = Resource1.Target;
        private Point _targetPosition = new Point(300, 300);
        private Point _direction = Point.Empty;
        private int _score = 0;


        private void tmer1_Tick(object sender, EventArgs e)
        {
            Refresh();

        }

        private void tmer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            tmer2.Interval = r.Next(25, 1000);
            _direction.X = r.Next(-1, 2);
            _direction.Y = r.Next(-1, 2);
        }
    }
}
