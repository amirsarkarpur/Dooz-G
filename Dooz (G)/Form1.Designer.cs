namespace Dooz__G_
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
            OK = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // OK
            // 
            OK.BackColor = Color.FromArgb(255, 186, 8);
            OK.FlatAppearance.BorderColor = Color.FromArgb(63, 136, 197);
            OK.FlatAppearance.BorderSize = 5;
            OK.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 136, 197);
            OK.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 136, 197);
            OK.FlatStyle = FlatStyle.Flat;
            OK.Font = new Font("MS Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            OK.Location = new Point(89, 232);
            OK.Name = "OK";
            OK.Size = new Size(150, 84);
            OK.TabIndex = 19;
            OK.Text = "3*3";
            OK.UseVisualStyleBackColor = false;
            OK.Click += OK_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 186, 8);
            button1.FlatAppearance.BorderColor = Color.FromArgb(63, 136, 197);
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 136, 197);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 136, 197);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Gothic", 18F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(319, 232);
            button1.Name = "button1";
            button1.Size = new Size(150, 84);
            button1.TabIndex = 20;
            button1.Text = "4*4";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 186, 8);
            button2.FlatAppearance.BorderColor = Color.FromArgb(63, 136, 197);
            button2.FlatAppearance.BorderSize = 5;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 136, 197);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(63, 136, 197);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(543, 232);
            button2.Name = "button2";
            button2.Size = new Size(150, 84);
            button2.TabIndex = 20;
            button2.Text = "5*5";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 186, 8);
            label1.Location = new Point(110, 45);
            label1.Name = "label1";
            label1.Size = new Size(572, 115);
            label1.TabIndex = 21;
            label1.Text = "tick take two";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 43, 67);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(OK);
            ForeColor = Color.FromArgb(208, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5*5";
            ResumeLayout(false);
        }

        #endregion

        private Button OK;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
