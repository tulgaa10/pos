namespace pos
{
    partial class SelectedProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ItemName = new Label();
            panel2 = new Panel();
            AddUnit = new Button();
            panel3 = new Panel();
            Quantity = new Label();
            panel4 = new Panel();
            MinusUnit = new Button();
            panel5 = new Panel();
            Uprice = new Label();
            panel6 = new Panel();
            Dis = new Label();
            panel7 = new Panel();
            Total = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ItemName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 77);
            panel1.TabIndex = 0;
            // 
            // ItemName
            // 
            ItemName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemName.AutoSize = true;
            ItemName.Font = new Font("Segoe UI", 11F);
            ItemName.Location = new Point(65, 17);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(97, 41);
            ItemName.TabIndex = 0;
            ItemName.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddUnit);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 77);
            panel2.TabIndex = 1;
            // 
            // AddUnit
            // 
            AddUnit.Dock = DockStyle.Fill;
            AddUnit.Location = new Point(0, 0);
            AddUnit.Name = "AddUnit";
            AddUnit.Size = new Size(79, 77);
            AddUnit.TabIndex = 0;
            AddUnit.Text = "+";
            AddUnit.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(Quantity);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(314, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(78, 77);
            panel3.TabIndex = 2;
            // 
            // Quantity
            // 
            Quantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Segoe UI", 11F);
            Quantity.Location = new Point(24, 18);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(34, 41);
            Quantity.TabIndex = 1;
            Quantity.Text = "1";
            // 
            // panel4
            // 
            panel4.Controls.Add(MinusUnit);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(392, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(82, 77);
            panel4.TabIndex = 3;
            // 
            // MinusUnit
            // 
            MinusUnit.Dock = DockStyle.Fill;
            MinusUnit.Location = new Point(0, 0);
            MinusUnit.Name = "MinusUnit";
            MinusUnit.Size = new Size(82, 77);
            MinusUnit.TabIndex = 1;
            MinusUnit.Text = "-";
            MinusUnit.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(Uprice);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(474, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 77);
            panel5.TabIndex = 4;
            // 
            // Uprice
            // 
            Uprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Uprice.AutoSize = true;
            Uprice.Font = new Font("Segoe UI", 11F);
            Uprice.Location = new Point(23, 18);
            Uprice.Name = "Uprice";
            Uprice.Size = new Size(97, 41);
            Uprice.TabIndex = 1;
            Uprice.Text = "label3";
            // 
            // panel6
            // 
            panel6.Controls.Add(Dis);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(606, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(98, 77);
            panel6.TabIndex = 5;
            // 
            // Dis
            // 
            Dis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dis.AutoSize = true;
            Dis.Font = new Font("Segoe UI", 11F);
            Dis.Location = new Point(16, 16);
            Dis.Name = "Dis";
            Dis.Size = new Size(34, 41);
            Dis.TabIndex = 1;
            Dis.Text = "0";
            // 
            // panel7
            // 
            panel7.Controls.Add(Total);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(704, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 77);
            panel7.TabIndex = 6;
            // 
            // Total
            // 
            Total.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Total.AutoSize = true;
            Total.Font = new Font("Segoe UI", 11F);
            Total.Location = new Point(41, 18);
            Total.Name = "Total";
            Total.Size = new Size(97, 41);
            Total.TabIndex = 1;
            Total.Text = "label5";
            // 
            // SelectedProducts
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SelectedProducts";
            Size = new Size(854, 77);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label ItemName;
        private Button AddUnit;
        private Label Quantity;
        private Button MinusUnit;
        private Label Uprice;
        private Label Dis;
        private Panel panel7;
        private Label Total;
    }
}
