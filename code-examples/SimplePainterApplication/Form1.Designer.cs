namespace SimplePainterApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.strokeWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.strokeColorDialog = new System.Windows.Forms.ColorDialog();
            this.strokeColorButton = new System.Windows.Forms.Button();
            this.filledCheckBox = new System.Windows.Forms.CheckBox();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.ellipseRadioButton = new System.Windows.Forms.RadioButton();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.shapeWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.shapeHeightTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeightTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(39, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // strokeWidthTrackBar
            // 
            this.strokeWidthTrackBar.Location = new System.Drawing.Point(39, 59);
            this.strokeWidthTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strokeWidthTrackBar.Minimum = 1;
            this.strokeWidthTrackBar.Name = "strokeWidthTrackBar";
            this.strokeWidthTrackBar.Size = new System.Drawing.Size(149, 45);
            this.strokeWidthTrackBar.TabIndex = 1;
            this.strokeWidthTrackBar.Value = 1;
            // 
            // strokeColorButton
            // 
            this.strokeColorButton.Location = new System.Drawing.Point(198, 32);
            this.strokeColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strokeColorButton.Name = "strokeColorButton";
            this.strokeColorButton.Size = new System.Drawing.Size(114, 26);
            this.strokeColorButton.TabIndex = 2;
            this.strokeColorButton.Text = "Stroke Color";
            this.strokeColorButton.UseVisualStyleBackColor = true;
            this.strokeColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filledCheckBox
            // 
            this.filledCheckBox.AutoSize = true;
            this.filledCheckBox.Location = new System.Drawing.Point(372, 39);
            this.filledCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filledCheckBox.Name = "filledCheckBox";
            this.filledCheckBox.Size = new System.Drawing.Size(54, 19);
            this.filledCheckBox.TabIndex = 3;
            this.filledCheckBox.Text = "Filled";
            this.filledCheckBox.UseVisualStyleBackColor = true;
            // 
            // fillColorButton
            // 
            this.fillColorButton.Location = new System.Drawing.Point(198, 62);
            this.fillColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(114, 26);
            this.fillColorButton.TabIndex = 4;
            this.fillColorButton.Text = "Fill Color";
            this.fillColorButton.UseVisualStyleBackColor = true;
            this.fillColorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stroke Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Picture";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rectangleRadioButton);
            this.groupBox1.Controls.Add(this.ellipseRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(457, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(134, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(5, 42);
            this.rectangleRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(77, 19);
            this.rectangleRadioButton.TabIndex = 1;
            this.rectangleRadioButton.Text = "Rectangle";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRadioButton
            // 
            this.ellipseRadioButton.AutoSize = true;
            this.ellipseRadioButton.Checked = true;
            this.ellipseRadioButton.Location = new System.Drawing.Point(5, 20);
            this.ellipseRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ellipseRadioButton.Name = "ellipseRadioButton";
            this.ellipseRadioButton.Size = new System.Drawing.Size(58, 19);
            this.ellipseRadioButton.TabIndex = 0;
            this.ellipseRadioButton.TabStop = true;
            this.ellipseRadioButton.Text = "Ellipse";
            this.ellipseRadioButton.UseVisualStyleBackColor = true;
            // 
            // shapeWidthTrackBar
            // 
            this.shapeWidthTrackBar.Location = new System.Drawing.Point(651, 33);
            this.shapeWidthTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapeWidthTrackBar.Maximum = 500;
            this.shapeWidthTrackBar.Minimum = 1;
            this.shapeWidthTrackBar.Name = "shapeWidthTrackBar";
            this.shapeWidthTrackBar.Size = new System.Drawing.Size(149, 45);
            this.shapeWidthTrackBar.TabIndex = 8;
            this.shapeWidthTrackBar.Value = 50;
            // 
            // shapeHeightTrackBar
            // 
            this.shapeHeightTrackBar.Location = new System.Drawing.Point(651, 76);
            this.shapeHeightTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapeHeightTrackBar.Maximum = 500;
            this.shapeHeightTrackBar.Minimum = 1;
            this.shapeHeightTrackBar.Name = "shapeHeightTrackBar";
            this.shapeHeightTrackBar.Size = new System.Drawing.Size(149, 45);
            this.shapeHeightTrackBar.TabIndex = 9;
            this.shapeHeightTrackBar.Value = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Shape Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Shape Height";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "&Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(327, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 20);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(327, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 20);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeHeightTrackBar);
            this.Controls.Add(this.shapeWidthTrackBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillColorButton);
            this.Controls.Add(this.filledCheckBox);
            this.Controls.Add(this.strokeColorButton);
            this.Controls.Add(this.strokeWidthTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeightTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TrackBar strokeWidthTrackBar;
        private ColorDialog strokeColorDialog;
        private Button strokeColorButton;
        private CheckBox filledCheckBox;
        private Button fillColorButton;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rectangleRadioButton;
        private RadioButton ellipseRadioButton;
        private ColorDialog fillColorDialog;
        private TrackBar shapeWidthTrackBar;
        private TrackBar shapeHeightTrackBar;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
    }
}