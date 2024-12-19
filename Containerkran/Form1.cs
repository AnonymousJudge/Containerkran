using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containerkran
{
    public partial class Form1 : Form
    {
        // Container sind eingehakt oder nicht

        bool x1, x2, x3, x4;
    
        Point Container1, Container2, Container3, Container4, Seilpos, Kran1, Kran2, Kran3, Kran4;
        Size Seilgröße;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Container1 = new Point(panContainer1.Location.X, panContainer1.Location.Y);
            Container2 = new Point(panContainer2.Location.X, panContainer2.Location.Y);
            Container3 = new Point(panContainer3.Location.X, panContainer3.Location.Y);
            Container4 = new Point(panContainer4.Location.X, panContainer4.Location.Y);
            Seilpos = new Point(panSeil.Location.X, panSeil.Location.Y);
            Kran1 = new Point(panKran1.Location.X, panKran1.Location.Y);
            Kran2 = new Point(panKran2.Location.X, panKran2.Location.Y);
            Kran3 = new Point(panKran3.Location.X, panKran3.Location.Y);
            Kran4 = new Point(panKran4.Location.X, panKran4.Location.Y);

            Seilgröße = new Size(panSeil.Width, panSeil.Height);
        }

        //Geschwindigkeit

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Kranlinks.Interval = trackBar1.Value;
            Kranrechts.Interval = trackBar1.Value;
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Seilhoch.Interval = trackBar2.Value;
            Seilrunter.Interval = trackBar2.Value;
        }






        //Kran nach links, rechts bewegen

        private void Kranlinks_Tick(object sender, EventArgs e)
        {
            if(panKran1.Location.X == panLaufbahn.Location.X)
            {
                Kranlinks.Enabled = false;
            }
            else
            if (x1 == true)
                if ((panContainer1.Location.X == panContainer2.Location.X + panContainer2.Width && panContainer1.Location.Y > panContainer2.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer1.Location.X == panContainer3.Location.X + panContainer3.Width && panContainer1.Location.Y > panContainer3.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer1.Location.X == panContainer4.Location.X + panContainer4.Width && panContainer1.Location.Y > panContainer4.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer1.Location.X == panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer1.Location.Y > panFuehrerhaus.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X == panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer1.Location.Y > panLKWLadeflaeche.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X == panBoden.Location.X + panBoden.Width && panContainer1.Location.Y > panBoden.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X == panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer1.Location.Y > panSchiffrumpf.Location.Y - panContainer1.Height) ||
                    (panSeil.Location.X == panContainer2.Location.X + panContainer2.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X + panContainer3.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X + panContainer4.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranlinks.Enabled = false;
                }
                else
                {
                    panContainer1.Location = new Point(panContainer1.Location.X - 1, panContainer1.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X - 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X - 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X - 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X - 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X - 1, panSeil.Location.Y);
                }
            else
            if (x2 == true)
                if ((panContainer2.Location.X == panContainer1.Location.X + panContainer1.Width && panContainer2.Location.Y > panContainer1.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer2.Location.X == panContainer3.Location.X + panContainer3.Width && panContainer2.Location.Y > panContainer3.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer2.Location.X == panContainer4.Location.X + panContainer4.Width && panContainer2.Location.Y > panContainer4.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer2.Location.X == panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer2.Location.Y > panFuehrerhaus.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer2.Location.Y > panLKWLadeflaeche.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panBoden.Location.X + panBoden.Width && panContainer2.Location.Y > panBoden.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer2.Location.Y > panSchiffrumpf.Location.Y - panContainer2.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X + panContainer1.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X + panContainer3.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X + panContainer4.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranlinks.Enabled = false;
                }
                else
                {
                    panContainer2.Location = new Point(panContainer2.Location.X - 1, panContainer2.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X - 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X - 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X - 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X - 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X - 1, panSeil.Location.Y);
                }
            else
            if (x3 == true)
                if ((panContainer3.Location.X == panContainer1.Location.X + panContainer1.Width && panContainer3.Location.Y > panContainer1.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer3.Location.X == panContainer2.Location.X + panContainer2.Width && panContainer3.Location.Y > panContainer2.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer3.Location.X == panContainer4.Location.X + panContainer4.Width && panContainer3.Location.Y > panContainer4.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer3.Location.X == panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer3.Location.Y > panFuehrerhaus.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X == panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer3.Location.Y > panLKWLadeflaeche.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X == panBoden.Location.X + panBoden.Width && panContainer3.Location.Y > panBoden.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X == panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer3.Location.Y > panSchiffrumpf.Location.Y - panContainer3.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X + panContainer1.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer2.Location.X + panContainer2.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X + panContainer4.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranlinks.Enabled = false;
                }
                else
                {
                    panContainer3.Location = new Point(panContainer3.Location.X - 1, panContainer3.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X - 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X - 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X - 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X - 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X - 1, panSeil.Location.Y);
                }
            else
            if (x4 == true)
                if ((panContainer4.Location.X == panContainer1.Location.X + panContainer1.Width && panContainer4.Location.Y > panContainer1.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer4.Location.X == panContainer2.Location.X + panContainer2.Width && panContainer4.Location.Y > panContainer2.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer4.Location.X == panContainer3.Location.X + panContainer3.Width && panContainer4.Location.Y > panContainer3.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer4.Location.X == panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer4.Location.Y > panFuehrerhaus.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X == panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer4.Location.Y > panLKWLadeflaeche.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X == panBoden.Location.X + panBoden.Width && panContainer4.Location.Y > panBoden.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X == panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer4.Location.Y > panSchiffrumpf.Location.Y - panContainer4.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X + panContainer1.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer2.Location.X + panContainer2.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X + panContainer3.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y))
                {
                    Kranlinks.Enabled = false;
                }
                else
                {
                    panContainer4.Location = new Point(panContainer4.Location.X - 1, panContainer4.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X - 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X - 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X - 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X - 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X - 1, panSeil.Location.Y);

                }
            else
            if ((panSeil.Location.X == panContainer1.Location.X + panContainer1.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer2.Location.X + panContainer2.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer3.Location.X + panContainer3.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer4.Location.X + panContainer4.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panSeil.Height > panLKWLadeflaeche.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panBoden.Location.X + panBoden.Width && panSeil.Height > panBoden.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panSchiffrumpf.Location.X + panSchiffrumpf.Width && panSeil.Height > panSchiffrumpf.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panFuehrerhaus.Location.X + panFuehrerhaus.Width && panSeil.Height > panFuehrerhaus.Location.Y - panSeil.Location.Y))
            {
                Kranlinks.Enabled = false;
            }
            else
            {
                panKran1.Location = new Point(panKran1.Location.X - 1, panKran1.Location.Y);
                panKran2.Location = new Point(panKran2.Location.X - 1, panKran2.Location.Y);
                panKran3.Location = new Point(panKran3.Location.X - 1, panKran3.Location.Y);
                panKran4.Location = new Point(panKran4.Location.X - 1, panKran4.Location.Y);
                panSeil.Location = new Point(panSeil.Location.X - 1, panSeil.Location.Y);
            }

        }

        


        private void Kranrechts_Tick(object sender, EventArgs e)
        {
            if (panKran1.Location.X == panLaufbahn.Location.X + panLaufbahn.Width - panKran1.Width )
            {
                Kranrechts.Enabled = false;
            }
            else
            if (x1 == true)
                if ((panContainer1.Location.X == panContainer2.Location.X - panContainer1.Width && panContainer1.Location.Y > panContainer2.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer1.Location.X == panContainer3.Location.X - panContainer1.Width && panContainer1.Location.Y > panContainer3.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer1.Location.X == panContainer4.Location.X - panContainer1.Width && panContainer1.Location.Y > panContainer4.Location.Y - panContainer1.Height && panContainer1.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer1.Location.X == panFuehrerhaus.Location.X - panContainer1.Width && panContainer1.Location.Y > panFuehrerhaus.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X == panBoden2.Location.X - panContainer1.Width && panContainer1.Location.Y > panBoden2.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X == panSchiffrumpf.Location.X - panContainer1.Width && panContainer1.Location.Y > panSchiffrumpf.Location.Y - panContainer1.Height) ||
                    (panSeil.Location.X == panContainer2.Location.X - panSeil.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X - panSeil.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X - panSeil.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranrechts.Enabled = false;
                }
                else
                {
                    panContainer1.Location = new Point(panContainer1.Location.X + 1, panContainer1.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X + 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X + 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X + 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X + 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X + 1, panSeil.Location.Y);
                }
            else
            if (x2 == true)
                if ((panContainer2.Location.X == panContainer1.Location.X - panContainer2.Width && panContainer2.Location.Y > panContainer1.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer2.Location.X == panContainer3.Location.X - panContainer2.Width && panContainer2.Location.Y > panContainer3.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer2.Location.X == panContainer4.Location.X - panContainer2.Width && panContainer2.Location.Y > panContainer4.Location.Y - panContainer2.Height && panContainer2.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer2.Location.X == panFuehrerhaus.Location.X - panContainer2.Width && panContainer2.Location.Y > panFuehrerhaus.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panFuehrerhaus.Location.X - panContainer2.Width && panContainer2.Location.Y > panFuehrerhaus.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panBoden2.Location.X - panContainer2.Width && panContainer2.Location.Y > panBoden2.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X == panSchiffrumpf.Location.X - panContainer2.Width && panContainer2.Location.Y > panSchiffrumpf.Location.Y - panContainer2.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X - panSeil.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X - panSeil.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X - panSeil.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranrechts.Enabled = false;
                }
                else
                {
                    panContainer2.Location = new Point(panContainer2.Location.X + 1, panContainer2.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X + 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X + 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X + 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X + 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X + 1, panSeil.Location.Y);
                }
            else
            if (x3 == true)
                if ((panContainer3.Location.X == panContainer1.Location.X - panContainer3.Width && panContainer3.Location.Y > panContainer1.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer3.Location.X == panContainer2.Location.X - panContainer3.Width && panContainer3.Location.Y > panContainer2.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer3.Location.X == panContainer4.Location.X - panContainer3.Width && panContainer3.Location.Y > panContainer4.Location.Y - panContainer3.Height && panContainer3.Location.Y < panContainer4.Location.Y + panContainer4.Height) ||
                    (panContainer3.Location.X == panFuehrerhaus.Location.X - panContainer3.Width && panContainer3.Location.Y > panFuehrerhaus.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X == panBoden2.Location.X - panContainer3.Width && panContainer3.Location.Y > panBoden2.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X == panSchiffrumpf.Location.X - panContainer3.Width && panContainer3.Location.Y > panSchiffrumpf.Location.Y - panContainer3.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X - panSeil.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer2.Location.X - panSeil.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer4.Location.X - panSeil.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y))
                {
                    Kranrechts.Enabled = false;
                }
                else
                {
                    panContainer3.Location = new Point(panContainer3.Location.X + 1, panContainer3.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X + 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X + 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X + 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X + 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X + 1, panSeil.Location.Y);
                }
            else
            if (x4 == true)
                if ((panContainer4.Location.X == panContainer1.Location.X - panContainer4.Width && panContainer4.Location.Y > panContainer1.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer1.Location.Y + panContainer1.Height) ||
                    (panContainer4.Location.X == panContainer2.Location.X - panContainer4.Width && panContainer4.Location.Y > panContainer2.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer2.Location.Y + panContainer2.Height) ||
                    (panContainer4.Location.X == panContainer3.Location.X - panContainer4.Width && panContainer4.Location.Y > panContainer3.Location.Y - panContainer4.Height && panContainer4.Location.Y < panContainer3.Location.Y + panContainer3.Height) ||
                    (panContainer4.Location.X == panFuehrerhaus.Location.X - panContainer4.Width && panContainer4.Location.Y > panFuehrerhaus.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X == panBoden2.Location.X - panContainer4.Width && panContainer4.Location.Y > panBoden2.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X == panSchiffrumpf.Location.X - panContainer4.Width && panContainer4.Location.Y > panSchiffrumpf.Location.Y - panContainer4.Height) ||
                    (panSeil.Location.X == panContainer1.Location.X - panSeil.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer2.Location.X - panSeil.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                    (panSeil.Location.X == panContainer3.Location.X - panSeil.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y))
                {
                    Kranrechts.Enabled = false;
                }
                else
                {
                    panContainer4.Location = new Point(panContainer4.Location.X + 1, panContainer4.Location.Y);
                    panKran1.Location = new Point(panKran1.Location.X + 1, panKran1.Location.Y);
                    panKran2.Location = new Point(panKran2.Location.X + 1, panKran2.Location.Y);
                    panKran3.Location = new Point(panKran3.Location.X + 1, panKran3.Location.Y);
                    panKran4.Location = new Point(panKran4.Location.X + 1, panKran4.Location.Y);
                    panSeil.Location = new Point(panSeil.Location.X + 1, panSeil.Location.Y);

                }
            else
            if ((panSeil.Location.X == panContainer1.Location.X - panSeil.Width && panSeil.Height > panContainer1.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer2.Location.X - panSeil.Width && panSeil.Height > panContainer2.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer3.Location.X - panSeil.Width && panSeil.Height > panContainer3.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panContainer4.Location.X - panSeil.Width && panSeil.Height > panContainer4.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panBoden2.Location.X - panSeil.Width && panSeil.Height > panBoden2.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panSchiffrumpf.Location.X - panSeil.Width && panSeil.Height > panSchiffrumpf.Location.Y - panSeil.Location.Y) ||
                (panSeil.Location.X == panFuehrerhaus.Location.X - panSeil.Width && panSeil.Height > panFuehrerhaus.Location.Y - panSeil.Location.Y))
            {
                Kranrechts.Enabled = false;
            }
            else
            {
                panKran1.Location = new Point(panKran1.Location.X + 1, panKran1.Location.Y);
                panKran2.Location = new Point(panKran2.Location.X + 1, panKran2.Location.Y);
                panKran3.Location = new Point(panKran3.Location.X + 1, panKran3.Location.Y);
                panKran4.Location = new Point(panKran4.Location.X + 1, panKran4.Location.Y);
                panSeil.Location = new Point(panSeil.Location.X + 1, panSeil.Location.Y);
            }
        }

        





        //Seil aus,- einfahren

        private void Seilhoch_Tick(object sender, EventArgs e)
        {
            if (panSeil.Height == 60)
            {
                Seilhoch.Enabled = false;
            }
            else
           if (x1 == true)
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height - 1);
                panContainer1.Location = new Point(panContainer1.Location.X, panContainer1.Location.Y - 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
            else
           if (x2 == true)
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height - 1);
                panContainer2.Location = new Point(panContainer2.Location.X, panContainer2.Location.Y - 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
            else
           if (x3 == true)
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height - 1);
                panContainer3.Location = new Point(panContainer3.Location.X, panContainer3.Location.Y - 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
            else
           if (x4 == true)
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height - 1);
                panContainer4.Location = new Point(panContainer4.Location.X, panContainer4.Location.Y - 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
            else
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height - 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
        }

        

        private void Seilrunter_Tick(object sender, EventArgs e)
        {
            if ((x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panContainer1.Location.Y - panSeil.Location.Y && panSeil.Location.X < panContainer1.Location.X + panContainer1.Width && panSeil.Location.X > panContainer1.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panContainer2.Location.Y - panSeil.Location.Y && panSeil.Location.X < panContainer2.Location.X + panContainer2.Width && panSeil.Location.X > panContainer2.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panContainer3.Location.Y - panSeil.Location.Y && panSeil.Location.X < panContainer3.Location.X + panContainer3.Width && panSeil.Location.X > panContainer3.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panContainer4.Location.Y - panSeil.Location.Y && panSeil.Location.X < panContainer4.Location.X + panContainer4.Width && panSeil.Location.X > panContainer4.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panSchiffrumpf.Location.Y - panSeil.Location.Y && panSeil.Location.X < panSchiffrumpf.Location.X + panSchiffrumpf.Width && panSeil.Location.X > panSchiffrumpf.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panLKWLadeflaeche.Location.Y - panSeil.Location.Y && panSeil.Location.X < panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panSeil.Location.X > panLKWLadeflaeche.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panBoden.Location.Y - panSeil.Location.Y && panSeil.Location.X < panBoden.Location.X + panBoden.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panBoden2.Location.Y - panSeil.Location.Y && panSeil.Location.X > panBoden2.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panFuehrerhaus.Location.Y - panSeil.Location.Y && panSeil.Location.X < panFuehrerhaus.Location.X + panFuehrerhaus.Width && panSeil.Location.X > panFuehrerhaus.Location.X - panSeil.Width) ||
                (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Height == panLKWRadkasten.Location.Y - panSeil.Location.Y && panSeil.Location.X < panLKWRadkasten.Location.X + panLKWRadkasten.Width && panSeil.Location.X > panLKWRadkasten.Location.X - panSeil.Width))
            {
                Seilrunter.Enabled = false;
                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
            else
                if ((panSeil.Height == panWasser.Location.Y - panSeil.Location.Y) ||
                    (x1 == true && panSeil.Height == panWasser.Location.Y - panSeil.Location.Y - panContainer1.Height) || 
                    (x2 == true && panSeil.Height == panWasser.Location.Y - panSeil.Location.Y - panContainer2.Height) || 
                    (x3 == true && panSeil.Height == panWasser.Location.Y - panSeil.Location.Y - panContainer3.Height) || 
                    (x4 == true && panSeil.Height == panWasser.Location.Y - panSeil.Location.Y - panContainer4.Height))
            {
                Seilrunter.Enabled = false;
                if (panSeil.Height == panWasser.Location.Y - panSeil.Location.Y)
                {
                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m \n Seil darf nicht ins Wasser.";
                }
                else
                {
                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m \n Container darf nicht ins Wasser.";
                }
            }
            else
                        if (x1 == true)
                if ((panSeil.Height + panContainer1.Height == panContainer2.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panContainer2.Location.X + panContainer2.Width && panContainer1.Location.X > panContainer2.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panContainer3.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panContainer3.Location.X + panContainer3.Width && panContainer1.Location.X > panContainer3.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panContainer4.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panContainer4.Location.X + panContainer4.Width && panContainer1.Location.X > panContainer4.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panFuehrerhaus.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer1.Location.X > panFuehrerhaus.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panLKWLadeflaeche.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer1.Location.X > panLKWLadeflaeche.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panBoden.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panBoden.Location.X + panBoden.Width) ||
                    (panSeil.Height + panContainer1.Height == panBoden2.Location.Y - panSeil.Location.Y && panContainer1.Location.X > panBoden2.Location.X - panContainer1.Width) ||
                    (panSeil.Height + panContainer1.Height == panSchiffrumpf.Location.Y - panSeil.Location.Y && panContainer1.Location.X < panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer1.Location.X > panSchiffrumpf.Location.X - panContainer1.Width))
                {
                    Seilrunter.Enabled = false;
                }
                else
                {
                    panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height + 1);
                    panContainer1.Location = new Point(panContainer1.Location.X, panContainer1.Location.Y + 1);

                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
                }
            else
                        if (x2 == true)
                if ((panSeil.Height + panContainer2.Height == panContainer1.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panContainer1.Location.X + panContainer1.Width && panContainer2.Location.X > panContainer1.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panContainer3.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panContainer3.Location.X + panContainer3.Width && panContainer2.Location.X > panContainer3.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panContainer4.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panContainer4.Location.X + panContainer4.Width && panContainer2.Location.X > panContainer4.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panFuehrerhaus.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer2.Location.X > panFuehrerhaus.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panLKWLadeflaeche.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer2.Location.X > panLKWLadeflaeche.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panBoden.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panBoden.Location.X + panBoden.Width) ||
                    (panSeil.Height + panContainer2.Height == panBoden2.Location.Y - panSeil.Location.Y && panContainer2.Location.X > panBoden2.Location.X - panContainer2.Width) ||
                    (panSeil.Height + panContainer2.Height == panSchiffrumpf.Location.Y - panSeil.Location.Y && panContainer2.Location.X < panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer2.Location.X > panSchiffrumpf.Location.X - panContainer2.Width))
                {
                    Seilrunter.Enabled = false;
                }
                else
                {
                    panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height + 1);
                    panContainer2.Location = new Point(panContainer2.Location.X, panContainer2.Location.Y + 1);

                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
                }
            else
                        if (x3 == true)
                if ((panSeil.Height + panContainer3.Height == panContainer1.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panContainer1.Location.X + panContainer1.Width && panContainer3.Location.X > panContainer1.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panContainer2.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panContainer2.Location.X + panContainer2.Width && panContainer3.Location.X > panContainer2.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panContainer4.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panContainer4.Location.X + panContainer4.Width && panContainer3.Location.X > panContainer4.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panFuehrerhaus.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer3.Location.X > panFuehrerhaus.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panLKWLadeflaeche.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer3.Location.X > panLKWLadeflaeche.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panBoden.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panBoden.Location.X + panBoden.Width) ||
                    (panSeil.Height + panContainer3.Height == panBoden2.Location.Y - panSeil.Location.Y && panContainer3.Location.X > panBoden2.Location.X - panContainer3.Width) ||
                    (panSeil.Height + panContainer3.Height == panSchiffrumpf.Location.Y - panSeil.Location.Y && panContainer3.Location.X < panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer3.Location.X > panSchiffrumpf.Location.X - panContainer3.Width))
                {
                    Seilrunter.Enabled = false;
                }
                else
                {
                    panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height + 1);
                    panContainer3.Location = new Point(panContainer3.Location.X, panContainer3.Location.Y + 1);

                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
                }
            else
                        if (x4 == true)
                if ((panSeil.Height + panContainer4.Height == panContainer1.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panContainer1.Location.X + panContainer1.Width && panContainer4.Location.X > panContainer1.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panContainer2.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panContainer2.Location.X + panContainer2.Width && panContainer4.Location.X > panContainer2.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panContainer3.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panContainer3.Location.X + panContainer3.Width && panContainer4.Location.X > panContainer3.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panFuehrerhaus.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panFuehrerhaus.Location.X + panFuehrerhaus.Width && panContainer4.Location.X > panFuehrerhaus.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panLKWLadeflaeche.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width && panContainer4.Location.X > panLKWLadeflaeche.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panBoden.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panBoden.Location.X + panBoden.Width) ||
                    (panSeil.Height + panContainer4.Height == panBoden2.Location.Y - panSeil.Location.Y && panContainer4.Location.X > panBoden2.Location.X - panContainer4.Width) ||
                    (panSeil.Height + panContainer4.Height == panSchiffrumpf.Location.Y - panSeil.Location.Y && panContainer4.Location.X < panSchiffrumpf.Location.X + panSchiffrumpf.Width && panContainer4.Location.X > panSchiffrumpf.Location.X - panContainer4.Width))
                {
                    Seilrunter.Enabled = false;
                }
                else
                {
                    panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height + 1);
                    panContainer4.Location = new Point(panContainer4.Location.X, panContainer4.Location.Y + 1);

                    lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
                }
            else
            {
                panSeil.Size = new Size(panSeil.Size.Width, panSeil.Size.Height + 1);

                lblSeillaenge.Text = "Aktuelle Seillänge: " + panSeil.Height / 10 + " m";
            }
        }

        

        // Blinker
        private void Blinker_Tick(object sender, EventArgs e)
        {
            if (panLampe.BackColor == Color.Orange)
            {
                panLampe.BackColor = Color.OrangeRed;
            }
            else
            if (panLampe.BackColor == Color.OrangeRed)
            {
                panLampe.BackColor = Color.Yellow;
            }
            else
            {
                panLampe.BackColor = Color.Orange;
            }
        }

        

        // einhaken / loslassen 
            
        private void cmdanker_Click(object sender, EventArgs e)
        {
            // C1 einhaken
            if (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Location.X >= panContainer1.Location.X && panSeil.Location.X <= panContainer1.Location.X + panContainer1.Width - panSeil.Width && panSeil.Height == panContainer1.Location.Y - panSeil.Location.Y)
            {
                x1 = true;
                Blinker.Enabled = true;
                Kranlinks.Enabled = false;
                Kranrechts.Enabled = false;
                cmdanker.Text = "Container lösen";
                cmdhoch.Text = "Container anheben";
                cmdrunter.Text = "Container absenken";
            }
            // C1 loslassen
            else
            if (x1 == true)
                if ((panContainer1.Location.X >= panLKWLadeflaeche.Location.X && panContainer1.Location.X <= panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width - panContainer1.Width && panContainer1.Location.Y == panLKWLadeflaeche.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X >= panSchiffrumpf.Location.X && panContainer1.Location.X <= panSchiffrumpf.Location.X + panSchiffrumpf.Width - panContainer1.Width && panContainer1.Location.Y == panSchiffrumpf.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X >= panContainer2.Location.X - panContainer1.Width / 3 && panContainer1.Location.X <= panContainer2.Location.X + panContainer2.Width - panContainer1.Width / 3 * 2 && panContainer1.Location.Y == panContainer2.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X >= panContainer3.Location.X - panContainer1.Width / 3 && panContainer1.Location.X <= panContainer3.Location.X + panContainer3.Width - panContainer1.Width / 3 * 2 && panContainer1.Location.Y == panContainer3.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X >= panContainer4.Location.X - panContainer1.Width / 3 && panContainer1.Location.X <= panContainer4.Location.X + panContainer4.Width - panContainer1.Width / 3 * 2 && panContainer1.Location.Y == panContainer4.Location.Y - panContainer1.Height) ||
                    (panContainer1.Location.X >= panContainer2.Location.X && panContainer1.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer1.Location.Y == panContainer2.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer3.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer3.Location.X + panContainer3.Width && panContainer1.Location.Y == panContainer3.Location.Y - panContainer1.Height) || //2 u 3
                    (panContainer1.Location.X >= panContainer2.Location.X && panContainer1.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer1.Location.Y == panContainer2.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer4.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer4.Location.X + panContainer4.Width && panContainer1.Location.Y == panContainer4.Location.Y - panContainer1.Height) || //2 u 4
                    (panContainer1.Location.X >= panContainer3.Location.X && panContainer1.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer1.Location.Y == panContainer3.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer4.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer4.Location.X + panContainer4.Width && panContainer1.Location.Y == panContainer4.Location.Y - panContainer1.Height) || //3 u 4
                    (panContainer1.Location.X >= panContainer3.Location.X && panContainer1.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer1.Location.Y == panContainer3.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer2.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer2.Location.X + panContainer2.Width && panContainer1.Location.Y == panContainer2.Location.Y - panContainer1.Height) || //3 u 2
                    (panContainer1.Location.X >= panContainer4.Location.X && panContainer1.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer1.Location.Y == panContainer4.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer2.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer2.Location.X + panContainer2.Width && panContainer1.Location.Y == panContainer2.Location.Y - panContainer1.Height) || //4 u 2
                    (panContainer1.Location.X >= panContainer4.Location.X && panContainer1.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer1.Location.Y == panContainer4.Location.Y - panContainer1.Height &&   panContainer1.Location.X + panContainer1.Width >= panContainer3.Location.X && panContainer1.Location.X + panContainer1.Width <= panContainer3.Location.X + panContainer3.Width && panContainer1.Location.Y == panContainer3.Location.Y - panContainer1.Height)) //4 u 3
                {
                    x1 = false;
                    Blinker.Enabled = false;
                    Kranlinks.Enabled = false;
                    Kranrechts.Enabled = false;
                    cmdanker.Text = "Container verankern";
                    cmdhoch.Text = "Seil einfahren";
                    cmdrunter.Text = "Seil ausfahren";
                }
                else
                {
                    MessageBox.Show("Der Container darf nur auf den den anderen Containern und Ladeflächen des Schiffes und des LKWs abgestellt werden!", "");
                }
            // C2 einhaken
            else
                       if (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Location.X >= panContainer2.Location.X && panSeil.Location.X <= panContainer2.Location.X + panContainer2.Width - panSeil.Width && panSeil.Height == panContainer2.Location.Y - panSeil.Location.Y)
            {
                x2 = true;
                Blinker.Enabled = true;
                Kranlinks.Enabled = false;
                Kranrechts.Enabled = false;
                cmdanker.Text = "Container lösen";
                cmdhoch.Text = "Container anheben";
                cmdrunter.Text = "Container absenken";
            }
            // C2 loslassen
            else
            if (x2 == true)
                if ((panContainer2.Location.X >= panLKWLadeflaeche.Location.X && panContainer2.Location.X <= panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width - panContainer2.Width && panContainer2.Location.Y == panLKWLadeflaeche.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X >= panSchiffrumpf.Location.X && panContainer2.Location.X <= panSchiffrumpf.Location.X + panSchiffrumpf.Width - panContainer2.Width && panContainer2.Location.Y == panSchiffrumpf.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X >= panContainer1.Location.X - panContainer2.Width / 3 && panContainer2.Location.X <= panContainer1.Location.X + panContainer1.Width - panContainer2.Width / 3 * 2 && panContainer2.Location.Y == panContainer1.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X >= panContainer3.Location.X - panContainer2.Width / 3 && panContainer2.Location.X <= panContainer3.Location.X + panContainer3.Width - panContainer2.Width / 3 * 2 && panContainer2.Location.Y == panContainer3.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X >= panContainer4.Location.X - panContainer2.Width / 3 && panContainer2.Location.X <= panContainer4.Location.X + panContainer4.Width - panContainer2.Width / 3 * 2 && panContainer2.Location.Y == panContainer4.Location.Y - panContainer2.Height) ||
                    (panContainer2.Location.X >= panContainer1.Location.X && panContainer2.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer2.Location.Y == panContainer1.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer3.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer3.Location.X + panContainer3.Width && panContainer2.Location.Y == panContainer3.Location.Y - panContainer2.Height) || //1 u 3
                    (panContainer2.Location.X >= panContainer1.Location.X && panContainer2.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer2.Location.Y == panContainer1.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer4.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer4.Location.X + panContainer4.Width && panContainer2.Location.Y == panContainer4.Location.Y - panContainer2.Height) || //1 u 4
                    (panContainer2.Location.X >= panContainer3.Location.X && panContainer2.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer2.Location.Y == panContainer3.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer4.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer4.Location.X + panContainer4.Width && panContainer2.Location.Y == panContainer4.Location.Y - panContainer2.Height) || //3 u 4
                    (panContainer2.Location.X >= panContainer3.Location.X && panContainer2.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer2.Location.Y == panContainer3.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer1.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer1.Location.X + panContainer1.Width && panContainer2.Location.Y == panContainer1.Location.Y - panContainer2.Height) || //3 u 1
                    (panContainer2.Location.X >= panContainer4.Location.X && panContainer2.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer2.Location.Y == panContainer4.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer1.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer1.Location.X + panContainer1.Width && panContainer2.Location.Y == panContainer1.Location.Y - panContainer2.Height) || //4 u 1
                    (panContainer2.Location.X >= panContainer4.Location.X && panContainer2.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer2.Location.Y == panContainer4.Location.Y - panContainer2.Height &&   panContainer2.Location.X + panContainer2.Width >= panContainer3.Location.X && panContainer2.Location.X + panContainer2.Width <= panContainer3.Location.X + panContainer3.Width && panContainer2.Location.Y == panContainer3.Location.Y - panContainer2.Height )) //4 u 3        
                {
                x2 = false;
                    Blinker.Enabled = false;
                    Kranlinks.Enabled = false;
                    Kranrechts.Enabled = false;
                    cmdanker.Text = "Container verankern";
                    cmdhoch.Text = "Seil einfahren";
                    cmdrunter.Text = "Seil ausfahren";
                }
                else
                {
                    MessageBox.Show("Der Container darf nur auf den den anderen Containern und Ladeflächen des Schiffes und des LKWs abgestellt werden!", "");
                }
            // C3 einhaken
            else
                       if (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Location.X >= panContainer3.Location.X && panSeil.Location.X <= panContainer3.Location.X + panContainer3.Width - panSeil.Width && panSeil.Height == panContainer3.Location.Y - panSeil.Location.Y)
            {
                x3 = true;
                Blinker.Enabled = true;
                Kranlinks.Enabled = false;
                Kranrechts.Enabled = false;
                cmdanker.Text = "Container lösen";
                cmdhoch.Text = "Container anheben";
                cmdrunter.Text = "Container absenken";
            }
            // C3 loslassen
            else
            if (x3 == true)
                if ((panContainer3.Location.X >= panLKWLadeflaeche.Location.X && panContainer3.Location.X <= panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width - panContainer3.Width && panContainer3.Location.Y == panLKWLadeflaeche.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X >= panSchiffrumpf.Location.X && panContainer3.Location.X <= panSchiffrumpf.Location.X + panSchiffrumpf.Width - panContainer3.Width && panContainer3.Location.Y == panSchiffrumpf.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X >= panContainer1.Location.X - panContainer3.Width / 3 && panContainer3.Location.X <= panContainer1.Location.X + panContainer1.Width - panContainer3.Width / 3 * 2 && panContainer3.Location.Y == panContainer1.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X >= panContainer2.Location.X - panContainer3.Width / 3 && panContainer3.Location.X <= panContainer2.Location.X + panContainer2.Width - panContainer3.Width / 3 * 2 && panContainer3.Location.Y == panContainer2.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X >= panContainer4.Location.X - panContainer3.Width / 3 && panContainer3.Location.X <= panContainer4.Location.X + panContainer4.Width - panContainer3.Width / 3 * 2 && panContainer3.Location.Y == panContainer4.Location.Y - panContainer3.Height) ||
                    (panContainer3.Location.X >= panContainer1.Location.X && panContainer3.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer3.Location.Y == panContainer1.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer2.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer2.Location.X + panContainer2.Width && panContainer3.Location.Y == panContainer2.Location.Y - panContainer3.Height) || //1 u 2
                    (panContainer3.Location.X >= panContainer1.Location.X && panContainer3.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer3.Location.Y == panContainer1.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer4.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer4.Location.X + panContainer4.Width && panContainer3.Location.Y == panContainer4.Location.Y - panContainer3.Height) || //1 u 4
                    (panContainer3.Location.X >= panContainer2.Location.X && panContainer3.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer3.Location.Y == panContainer2.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer4.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer4.Location.X + panContainer4.Width && panContainer3.Location.Y == panContainer4.Location.Y - panContainer3.Height) || //2 u 4
                    (panContainer3.Location.X >= panContainer2.Location.X && panContainer3.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer3.Location.Y == panContainer2.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer1.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer1.Location.X + panContainer1.Width && panContainer3.Location.Y == panContainer1.Location.Y - panContainer3.Height) || //2 u 1
                    (panContainer3.Location.X >= panContainer4.Location.X && panContainer3.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer3.Location.Y == panContainer4.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer1.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer1.Location.X + panContainer1.Width && panContainer3.Location.Y == panContainer1.Location.Y - panContainer3.Height) || //4 u 1
                    (panContainer3.Location.X >= panContainer4.Location.X && panContainer3.Location.X <= panContainer4.Location.X + panContainer4.Width && panContainer3.Location.Y == panContainer4.Location.Y - panContainer3.Height &&   panContainer3.Location.X + panContainer3.Width >= panContainer2.Location.X && panContainer3.Location.X + panContainer3.Width <= panContainer2.Location.X + panContainer2.Width && panContainer3.Location.Y == panContainer2.Location.Y - panContainer3.Height)) //4 u 2
                {
                    x3 = false;
                    Blinker.Enabled = false;
                    Kranlinks.Enabled = false;
                    Kranrechts.Enabled = false;
                    cmdanker.Text = "Container verankern";
                    cmdhoch.Text = "Seil einfahren";
                    cmdrunter.Text = "Seil ausfahren";
                }
                else
                {
                    MessageBox.Show("Der Container darf nur auf den anderen Containern und den Ladeflächen des Schiffes und des LKWs abgestellt werden!", "");
                }
            // C4 einhaken
            else
                       if (x1 == false && x2 == false && x3 == false && x4 == false && panSeil.Location.X >= panContainer4.Location.X && panSeil.Location.X <= panContainer4.Location.X + panContainer4.Width - panSeil.Width && panSeil.Height == panContainer4.Location.Y - panSeil.Location.Y)
            {
                x4 = true;
                Blinker.Enabled = true;
                Kranlinks.Enabled = false;
                Kranrechts.Enabled = false;
                cmdanker.Text = "Container lösen";
                cmdhoch.Text = "Container anheben";
                cmdrunter.Text = "Container absenken";
            }
            // C4 loslassen
            else
            if (x4 == true)
                if ((panContainer4.Location.X >= panLKWLadeflaeche.Location.X && panContainer4.Location.X <= panLKWLadeflaeche.Location.X + panLKWLadeflaeche.Width - panContainer4.Width && panContainer4.Location.Y == panLKWLadeflaeche.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X >= panSchiffrumpf.Location.X && panContainer4.Location.X <= panSchiffrumpf.Location.X + panSchiffrumpf.Width - panContainer4.Width && panContainer4.Location.Y == panSchiffrumpf.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X >= panContainer1.Location.X - panContainer4.Width / 3 && panContainer4.Location.X <= panContainer1.Location.X + panContainer1.Width - panContainer4.Width / 3 * 2 && panContainer4.Location.Y == panContainer1.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X >= panContainer2.Location.X - panContainer4.Width / 3 && panContainer4.Location.X <= panContainer2.Location.X + panContainer2.Width - panContainer4.Width / 3 * 2 && panContainer4.Location.Y == panContainer2.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X >= panContainer3.Location.X - panContainer4.Width / 3 && panContainer4.Location.X <= panContainer3.Location.X + panContainer3.Width - panContainer4.Width / 3 * 2 && panContainer4.Location.Y == panContainer3.Location.Y - panContainer4.Height) ||
                    (panContainer4.Location.X >= panContainer1.Location.X && panContainer4.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer4.Location.Y == panContainer1.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer2.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer2.Location.X + panContainer2.Width && panContainer4.Location.Y == panContainer2.Location.Y - panContainer4.Height) || //1 u 2
                    (panContainer4.Location.X >= panContainer1.Location.X && panContainer4.Location.X <= panContainer1.Location.X + panContainer1.Width && panContainer4.Location.Y == panContainer1.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer3.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer3.Location.X + panContainer3.Width && panContainer4.Location.Y == panContainer3.Location.Y - panContainer4.Height) || //1 u 3
                    (panContainer4.Location.X >= panContainer2.Location.X && panContainer4.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer4.Location.Y == panContainer2.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer3.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer3.Location.X + panContainer3.Width && panContainer4.Location.Y == panContainer3.Location.Y - panContainer4.Height) || //2 u 3
                    (panContainer4.Location.X >= panContainer2.Location.X && panContainer4.Location.X <= panContainer2.Location.X + panContainer2.Width && panContainer4.Location.Y == panContainer2.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer1.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer1.Location.X + panContainer1.Width && panContainer4.Location.Y == panContainer1.Location.Y - panContainer4.Height) || //2 u 1
                    (panContainer4.Location.X >= panContainer3.Location.X && panContainer4.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer4.Location.Y == panContainer3.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer1.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer1.Location.X + panContainer1.Width && panContainer4.Location.Y == panContainer1.Location.Y - panContainer4.Height) || //3 u 1
                    (panContainer4.Location.X >= panContainer3.Location.X && panContainer4.Location.X <= panContainer3.Location.X + panContainer3.Width && panContainer4.Location.Y == panContainer3.Location.Y - panContainer4.Height &&   panContainer4.Location.X + panContainer4.Width >= panContainer2.Location.X && panContainer4.Location.X + panContainer4.Width <= panContainer2.Location.X + panContainer2.Width && panContainer4.Location.Y == panContainer2.Location.Y - panContainer4.Height)) //3 u 2
                { 
                    x4 = false;
                    Blinker.Enabled = false;
                    Kranlinks.Enabled = false;
                    Kranrechts.Enabled = false;
                    cmdanker.Text = "Container verankern";
                    cmdhoch.Text = "Seil einfahren";
                    cmdrunter.Text = "Seil ausfahren";
                }
            // fehler beim loslassen
                else
                {
                    MessageBox.Show("Der Container darf nur auf den anderen Containern und den Ladeflächen des Schiffes und des LKWs abgestellt werden!", "");
                }
            // fehler beim einhaken
            else
            {
                MessageBox.Show("Das Seil muss direkt über dem Container sein, um diesen einhacken zu können!", "ERROR");
            }
        }






         // Richtungsbuttenzuweisung

                //links
        private void cmdlinks_Click(object sender, EventArgs e)
        {
            if (Kranlinks.Enabled == false)
            {
                Kranlinks.Enabled = true;
                Kranrechts.Enabled = false;
            }
            else
            {
                Kranlinks.Enabled = false;
            }

        }

                //rechts
        private void cmdrechts_Click(object sender, EventArgs e)
        {
            if (Kranrechts.Enabled == false)
            {
                Kranrechts.Enabled = true;
                Kranlinks.Enabled = false;
            }
            else
            {
                Kranrechts.Enabled = false;
            }
        }

        //runter
        private void cmdrunter_Click(object sender, EventArgs e)
        {
            if (Seilrunter.Enabled == false)
            {
                Seilrunter.Enabled = true;
                Seilhoch.Enabled = false;
            }
            else
            {
                Seilrunter.Enabled = false;
            }
        }

                //hoch
        private void cmdhoch_Click(object sender, EventArgs e)
        {
            if (Seilhoch.Enabled == false)
            {
                Seilhoch.Enabled = true;
                Seilrunter.Enabled = false;
            }
            else
            {
                Seilhoch.Enabled = false;
            }
        }





        // Zurücksetzenbutton

        private void cmdSetzen_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sicher, das Sie alles zurücksetzen wollen?", "Warnung", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Kran
                panKran1.Location = Kran1;
                panKran2.Location = Kran2;
                panKran3.Location = Kran3;
                panKran4.Location = Kran4;
                //Seil
                panSeil.Location = Seilpos;
                panSeil.Size = Seilgröße;
                lblSeillaenge.Text = "Aktuelle Seillänge: 6 m";
                //Container
                panContainer1.Location = Container1 ;
                panContainer2.Location = Container2 ;
                panContainer3.Location = Container3 ;
                panContainer4.Location = Container4 ;
                //Bewegunstimer
                Kranlinks.Enabled = false;
                Kranrechts.Enabled = false;
                Seilhoch.Enabled = false;
                Seilrunter.Enabled = false;
                //Gechwindigkeitsregler
                trackBar1.Value = 50;
                trackBar2.Value = 50;
                //Geschwindigkeit
                Kranlinks.Interval = 50;
                Kranrechts.Interval = 50;
                Seilhoch.Interval = 50;
                Seilrunter.Interval = 50;
                //Lampe
                panLampe.BackColor = Color.Orange;
                Blinker.Enabled = false;
                //Verankerung lösen
                x1 = false;
                x2 = false;
                x3 = false;
                x4 = false;
                //Buttontext
                cmdanker.Text = "Container verankern";
                cmdhoch.Text = "Seil einfahren";
                cmdrunter.Text = "Seil ausfahren";
            }
            else
            {

            }

        }

    }
}

// folgendes ist fehlerhaft / fehlt :
//   - eventuell Tipps bzw fehlerreport
//   - Haken
//   - nach oben blockieren
//   - blockierte container nicht einhaken