namespace WinFormsAppShortcutKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        public void MenuEventHappened(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
                toolStripStatusLabel1.Text = $"{menuItem.Text} was clicked";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEventHappened(sender, e);
        }
    }
}