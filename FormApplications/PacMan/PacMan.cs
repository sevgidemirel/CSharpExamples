using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    class PacMan
    {

        private int xPosition;
        private int yPosition;
        private int xStart;
        private int yStart;
        private Image sagAcik;
        private Image sagKapali;
        private Image solAcik;
        private Image solKapali;
        private Image asagiAcik;
        private Image asagiKapali;
        private Image yukariAcik;
        private Image yukariKapali;
  

        public Image SagAcik
        {
            get
            {
                return sagAcik;
            }

            set
            {
                sagAcik = value;
            }
        }

        public Image SagKapali
        {
            get
            {
                return sagKapali;
            }

            set
            {
                sagKapali = value;
            }
        }

        public Image SolAcik
        {
            get
            {
                return solAcik;
            }

            set
            {
                solAcik = value;
            }
        }

        public Image SolKapali
        {
            get
            {
                return solKapali;
            }

            set
            {
                solKapali = value;
            }
        }

        public Image AsagiAcik
        {
            get
            {
                return asagiAcik;
            }

            set
            {
                asagiAcik = value;
            }
        }

        public Image AsagiKapali
        {
            get
            {
                return asagiKapali;
            }

            set
            {
                asagiKapali = value;
            }
        }

        public Image YukariAcik
        {
            get
            {
                return yukariAcik;
            }

            set
            {
                yukariAcik = value;
            }
        }

        public Image YukariKapali
        {
            get
            {
                return yukariKapali;
            }

            set
            {
                yukariKapali = value;
            }
        }

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

        public int XStart
        {
            get
            {
                return xStart;
            }

            set
            {
                xStart = value;
            }
        }

        public int YStart
        {
            get
            {
                return yStart;
            }

            set
            {
                yStart = value;
            }
        }

        public void setPacMan(PictureBox pb)
        {
            pb.Location = new Point(xStart,yStart);
            xPosition = xStart;
            yPosition = yStart;
            pb.Image = SagAcik;
            pb.Size = new Size(50,50);
        
        }

        public void SagaKay(PictureBox pb)
        {
            XPosition += 5;
            pb.Location = new Point(XPosition, YPosition);
            if (XPosition % 2 == 0)
            {
                pb.Image = Properties.Resources.openPacman;
            }
            else
            {
                pb.Image = Properties.Resources.closePacman;

            }

        }

        public void SolaKay(PictureBox pb)
        {
            XPosition -= 5;
            pb.Location = new Point(XPosition, YPosition);
            if (XPosition % 2 == 0)
            {
                pb.Image = Properties.Resources.openPacman_sag;
            }
            else
            {
                pb.Image = Properties.Resources.closePacman_sag;

            }

        }

        public void YukariKay(PictureBox pb)
        {
            YPosition -= 5;
            pb.Location = new Point(XPosition, YPosition);
            if (YPosition % 2 == 0)
            {
                pb.Image = Properties.Resources.openPacman_yukari;
            }
            else
            {
                pb.Image = Properties.Resources.closePacman_yukari;

            }

        }

        public void AsagiKay(PictureBox pb)
        {
            YPosition += 5;
            pb.Location = new Point(XPosition, YPosition);
            if (YPosition % 2 == 0)
            {
                pb.Image = Properties.Resources.openPacman_asagi;
            }
            else
            {
                pb.Image = Properties.Resources.closePacman_asagi;

            }

        }
    }
}
