namespace Day_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            car = new PictureBox();
            gasButton = new Button();
            breakButton = new Button();
            leftButton = new Button();
            rightButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 678);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // car
            // 
            car.BackColor = Color.Transparent;
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(243, 455);
            car.Name = "car";
            car.Size = new Size(100, 185);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 1;
            car.TabStop = false;
            // 
            // gasButton
            // 
            gasButton.BackColor = Color.Green;
            gasButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gasButton.Location = new Point(650, 169);
            gasButton.Name = "gasButton";
            gasButton.Size = new Size(140, 115);
            gasButton.TabIndex = 2;
            gasButton.Text = "GAS";
            gasButton.UseVisualStyleBackColor = false;
            gasButton.Click += gasButton_Click;
            // 
            // breakButton
            // 
            breakButton.BackColor = Color.Red;
            breakButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            breakButton.Location = new Point(650, 383);
            breakButton.Name = "breakButton";
            breakButton.Size = new Size(140, 115);
            breakButton.TabIndex = 3;
            breakButton.Text = "BREAK";
            breakButton.UseVisualStyleBackColor = false;
            breakButton.Click += breakButton_Click;
            // 
            // leftButton
            // 
            leftButton.BackColor = Color.Yellow;
            leftButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            leftButton.ForeColor = Color.Black;
            leftButton.Location = new Point(504, 283);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(140, 115);
            leftButton.TabIndex = 4;
            leftButton.Text = "LEFT";
            leftButton.UseVisualStyleBackColor = false;
            leftButton.Click += leftButton_Click;
            // 
            // rightButton
            // 
            rightButton.BackColor = Color.Yellow;
            rightButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rightButton.Location = new Point(796, 283);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(140, 115);
            rightButton.TabIndex = 5;
            rightButton.Text = "RIGHT";
            rightButton.UseVisualStyleBackColor = false;
            rightButton.Click += rightButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 681);
            Controls.Add(rightButton);
            Controls.Add(leftButton);
            Controls.Add(breakButton);
            Controls.Add(gasButton);
            Controls.Add(car);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox car;
        private Button gasButton;
        private Button breakButton;
        private Button leftButton;
        private Button rightButton;
    }
}
