using System.Drawing;
using System.Windows.Forms;

namespace MonacoTorch.Controls
{
    class ImageButton : Control
    {

        private bool isPressed;

        public bool IsPressed
        {
            get { return isPressed; }
            set { isPressed = value; }
        }
	

        private Bitmap pressedImage;

        public Bitmap PressedImage
        {
            get { return pressedImage; }
            set { pressedImage = value; }
        }


        private Bitmap normalImage;

        public Bitmap NormalImage
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            isPressed = true;
            this.Invalidate();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            isPressed = false;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //skip drawing the background to avoid flickering
            //base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                if (isPressed)
                {
                    if (pressedImage != null)
                    {
                        g.DrawImage(pressedImage, 
                            new Rectangle(0, 0, this.Width, this.Height), 
                            new Rectangle(0, 0, pressedImage.Width, pressedImage.Height), 
                            GraphicsUnit.Pixel);
                    }
                }
                else
                {
                    if (normalImage != null)
                    {
                        g.DrawImage(normalImage, 
                            new Rectangle(0, 0, this.Width, this.Height), 
                            new Rectangle(0, 0, normalImage.Width, normalImage.Height), 
                            GraphicsUnit.Pixel);
                    }
                }
            }
        }

    }
}
