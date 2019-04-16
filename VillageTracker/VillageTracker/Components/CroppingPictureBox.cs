using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageTracker.Components
{
    public class CroppingPictureBox : PictureBox
    {
        //Private Varibales
        private bool m_isPanning = false;
        private Point m_PanStartPosition = Point.Empty;
        private Point m_PanMovePosition = Point.Empty;
        private Point m_PanMoveOriginalPosition = Point.Empty;

        //Painting Variables
        private Size m_CroppingBounds;
        private Point m_CroppingLocation = Point.Empty;

        //Constructors
        public CroppingPictureBox()
        {
            m_CroppingBounds = new Size(750, 120);

            this.MouseDown += CroppingPictureBox_MouseDown;
            this.MouseUp += CroppingPictureBox_MouseUp;
            this.MouseMove += CroppingPictureBox_MouseMove;
            this.MouseLeave += CroppingPictureBox_MouseLeave;

            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Resize += CroppingPictureBox_Resize;
        }

        public CroppingPictureBox(int croppingWidth = 750, int croppingHeight = 120) : base()
        {
            m_CroppingBounds = new Size(croppingWidth, croppingHeight);

            this.MouseDown += CroppingPictureBox_MouseDown;
            this.MouseUp += CroppingPictureBox_MouseUp;
            this.MouseMove += CroppingPictureBox_MouseMove;
            this.MouseLeave += CroppingPictureBox_MouseLeave;
        }

        //Public Properties
        public Image CroppedImage
        {
            get
            {
                Rectangle cropRect = new Rectangle(m_CroppingLocation.X, m_CroppingLocation.Y, m_CroppingBounds.Width, m_CroppingBounds.Height);
                Bitmap src = this.Image as Bitmap;
                Bitmap croppedImage = new Bitmap(cropRect.Width, cropRect.Height);

                using (Graphics g = Graphics.FromImage(croppedImage))
                {
                    g.DrawImage(src, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }

                return (Image)croppedImage;
            }
        }

        //Private Methods
        private void PaintCroppingOverlay(Graphics e)
        {
            //create a new graphics container for painting the node
            GraphicsContainer nodeContainer = e.BeginContainer();

            //set this new container's orgin to the node's location
            e.TranslateTransform(m_CroppingLocation.X, m_CroppingLocation.Y);

            Rectangle croppingBorderRectangle = new Rectangle(0, 0, m_CroppingBounds.Width, m_CroppingBounds.Height);
            using (Pen croppingBorderPen = new Pen(Color.LightGray))
            {
                croppingBorderPen.Width = 2;
                croppingBorderPen.DashCap = DashCap.Round;
                croppingBorderPen.DashPattern = new float[2] { 4, 4 };

                e.DrawRectangle(croppingBorderPen, croppingBorderRectangle);
            }

            //end node graphics container
            e.EndContainer(nodeContainer);
        }

        //Overrides
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            PaintCroppingOverlay(pe.Graphics);
        }

        //Event Handlers
        private void CroppingPictureBox_MouseLeave(object sender, EventArgs e)
        {
            m_isPanning = false;
            m_PanStartPosition = new Point();
        }

        private void CroppingPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_isPanning)
            {
                m_PanMovePosition = new Point((e.Location.X - m_PanStartPosition.X),
                                        (e.Location.Y - m_PanStartPosition.Y));

                m_CroppingLocation = m_PanMoveOriginalPosition;
                m_CroppingLocation.Offset(m_PanMovePosition.X, m_PanMovePosition.Y);

                this.Invalidate();
            }
        }

        private void CroppingPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            m_isPanning = false;
            m_PanStartPosition = new Point();
        }

        private void CroppingPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            m_isPanning = true;
            m_PanStartPosition = new Point(e.X, e.Y);
            m_PanMoveOriginalPosition = m_CroppingLocation;
        }

        private void CroppingPictureBox_Resize(object sender, EventArgs e)
        {
        }
    }
}
