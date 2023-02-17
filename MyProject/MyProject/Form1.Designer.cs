namespace MyProject
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
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pnlSubtract = new Panel();
            txtSubtract = new TextBox();
            lblSubtract = new Label();
            btnSubtract = new Button();
            panel1.SuspendLayout();
            pnlSubtract.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 117);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 46);
            button1.TabIndex = 0;
            button1.Text = "Add 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 1;
            label1.Text = "Counter: 0";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(37, 34);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 304);
            panel1.TabIndex = 2;
            // 
            // pnlSubtract
            // 
            pnlSubtract.Controls.Add(btnSubtract);
            pnlSubtract.Controls.Add(lblSubtract);
            pnlSubtract.Controls.Add(txtSubtract);
            pnlSubtract.Location = new Point(341, 34);
            pnlSubtract.Name = "pnlSubtract";
            pnlSubtract.Size = new Size(299, 304);
            pnlSubtract.TabIndex = 3;
            // 
            // txtSubtract
            // 
            txtSubtract.Location = new Point(51, 117);
            txtSubtract.Name = "txtSubtract";
            txtSubtract.Size = new Size(200, 39);
            txtSubtract.TabIndex = 0;
            // 
            // lblSubtract
            // 
            lblSubtract.AutoSize = true;
            lblSubtract.Location = new Point(45, 34);
            lblSubtract.Name = "lblSubtract";
            lblSubtract.Size = new Size(127, 32);
            lblSubtract.TabIndex = 1;
            lblSubtract.Text = "Subtract: 0";
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(72, 191);
            btnSubtract.Margin = new Padding(5);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(153, 46);
            btnSubtract.TabIndex = 2;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 384);
            Controls.Add(pnlSubtract);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSubtract.ResumeLayout(false);
            pnlSubtract.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel1;
        private Panel pnlSubtract;
        private Button btnSubtract;
        private Label lblSubtract;
        private TextBox txtSubtract;
    }
}