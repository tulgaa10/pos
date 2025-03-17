namespace pos
{
    partial class SelectedProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 78);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 78);
            textBox1.TabIndex = 0;
            textBox1.Text = "Product 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(679, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 78);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 78);
            textBox2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 78);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(464, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 78);
            panel4.TabIndex = 3;
            // 
            // SelectedProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 1198);
            Controls.Add(panel1);
            Name = "SelectedProduct";
            Text = "SelectedProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private Panel panel3;
        private Panel panel4;
    }
}