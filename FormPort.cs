using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoats
{
    public partial class FormPort : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Port<IBoat> parking;
        public FormPort()
        {
            InitializeComponent();
            parking = new Port<IBoat>(20, pictureBoxPort.Width, pictureBoxPort.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки гавани
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxPort.Image = bmp;
        }

        private void buttonPortSail_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var sail = new Sail (100, 1000, dialog.Color);
                int place = parking + sail;
                Draw();
            }
        }

        private void buttonPortBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var sail = new Boat (100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + sail;
                    Draw();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var boat = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (boat != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBoat.Width, pictureBoxTakeBoat.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    boat.SetPosition(5, 5, pictureBoxTakeBoat.Width, pictureBoxTakeBoat.Height);
                    boat.DrawBoat(gr);
                    pictureBoxTakeBoat.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBoat.Width, pictureBoxTakeBoat.Height);
                    pictureBoxTakeBoat.Image = bmp;
                }
                Draw();
            }
        }
    } 
}
