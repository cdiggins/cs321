namespace SimplePainterApplication
{
    public partial class Form1 : Form
    {
        public List<Shape> Shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            strokeColorDialog.Color = Color.Black;
            fillColorDialog.Color = Color.Aquamarine;
            UpdatePanels();
        }

        private void UpdatePanels()
        {
            panel1.BackColor = strokeColorDialog.Color;
            panel2.BackColor = fillColorDialog.Color;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            strokeColorDialog.ShowDialog();
            UpdatePanels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillColorDialog.ShowDialog();
            UpdatePanels();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var point = pictureBox1.PointToScreen(new Point(0, 0));
            var x = MousePosition.X - point.X;
            var y = MousePosition.Y - point.Y;
            Shapes.Add(new Shape()
            {
                X = x,
                Y = y,
                Width = shapeWidthTrackBar.Value,
                Height = shapeHeightTrackBar.Value,
                StrokeColor = strokeColorDialog.Color,
                FillColor = fillColorDialog.Color,
                Filled = filledCheckBox.Checked,
                StrokeThickness = strokeWidthTrackBar.Value,
                Type = ellipseRadioButton.Checked ? ShapeType.Ellipse : ShapeType.Rect, 
            });
            pictureBox1.Invalidate();
        }

        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in Shapes)
            {
                using var pen = new Pen(shape.StrokeColor, shape.StrokeThickness);
                using var brush = new SolidBrush(shape.FillColor);
                if (shape.Type == ShapeType.Ellipse)
                {
                    if (shape.Filled)
                    {
                        e.Graphics.FillEllipse(brush, shape.X, shape.Y, shape.Width, shape.Height);
                    }

                    e.Graphics.DrawEllipse(pen, shape.X, shape.Y, shape.Width, shape.Height);
                }

                if (shape.Type == ShapeType.Rect)
                {
                    if (shape.Filled)
                    {
                        e.Graphics.FillRectangle(brush, shape.X, shape.Y, shape.Width, shape.Height);
                    }

                    e.Graphics.DrawRectangle(pen, shape.X, shape.Y, shape.Width, shape.Height);
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Draw five shapes here!");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Support undo here by deleting the last item in the list");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear all the shapes here");
        }
    }
}