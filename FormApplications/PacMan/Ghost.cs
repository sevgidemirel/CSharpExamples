using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    class Ghost
    {
  
        private int xPosition;
        private int yPosition;


        public int XPosition
        {
            get
            {
                return xPosition;
            }

            set
            {
                xPosition = value;
            }
        }

        public int YPosition
        {
            get
            {
                return yPosition;
            }

            set
            {
                yPosition = value;
            }
        }


        public void setPosition(PictureBox pbGhost)
        {

            pbGhost.Location = new Point(XPosition, YPosition);
            pbGhost.Size = new Size(50, 50);
        }

        public void HareketEttir(PictureBox pbGhost)
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 4))
            {
                case 0:

                    for (int i = 0; i < 20; i += 3)
                    {
                        XPosition += i;
                        if (XPosition > 586 || XPosition < 0)
                        {
                            XPosition -= i;
                        }
                        setPosition(pbGhost);
                    }
                    break;
                case 1:

                    for (int i = 0; i < 20; i += 3)
                    {
                        XPosition -= i;
                        if (XPosition > 586 || XPosition < 0)
                        {
                            XPosition += i;
                        }
                        setPosition(pbGhost);
                    }
                    break;
                case 2:

                    for (int i = 0; i < 20; i += 3)
                    {
                        YPosition += i;
                        if (YPosition > 355 || YPosition < 0)
                        {
                            YPosition -= i;
                        }
                        setPosition(pbGhost);
                    }
                    break;
                case 3:

                    for (int i = 0; i < 20; i += 3)
                    {
                        YPosition -= i;
                        if (YPosition > 355 || YPosition < 0)
                        {
                            YPosition += i;
                        }
                        setPosition(pbGhost);
                    }
                    break;
            }
        }
    }
}
