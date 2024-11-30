namespace Day_6
{
    public partial class Form1 : Form
    {
        int startX = 243;
        int startY = 455;

        int maxX = 487 - 155;
        int maxY = 678 - 185;

        Point carLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void gasButton_Click(object sender, EventArgs e)
        {
            if (startY > 0)
            {
                startY -= 10;
                carLocation = new Point(startX, startY);
                car.Location = carLocation;
            }
        }

        private void breakButton_Click(object sender, EventArgs e)
        {
            if (startY < maxY)
            {
                startY += 10;
                carLocation = new Point(startX, startY);
                car.Location = carLocation;
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (startX < maxX)
            {
                startX += 10;
                carLocation = new Point(startX, startY);
                car.Location = carLocation;
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (startX > 55)
            {
                startX -= 10;
                carLocation = new Point(startX, startY);
                car.Location = carLocation;
            }
        }
    }
}
