// MainForm.Designer.cs
namespace pos
{
    // MainForm.Designer.cs
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ToolStripMenuItem menuCategory;

        private void InitializeComponent()
        {
            menuCategory = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            TotalPrice = new Label();
            Pay = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ManagerPanel = new Panel();
            categoryPanel = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel8 = new Panel();
            UName = new Label();
            SearchButton = new Button();
            searchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // menuCategory
            // 
            menuCategory.Name = "menuCategory";
            menuCategory.Size = new Size(32, 19);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(panel7);
            splitContainer1.Panel1.Controls.Add(Pay);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ManagerPanel);
            splitContainer1.Panel2.Controls.Add(categoryPanel);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(panel8);
            splitContainer1.Size = new Size(2008, 1207);
            splitContainer1.SplitterDistance = 902;
            splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(902, 978);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(TotalPrice);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 1037);
            panel7.Name = "panel7";
            panel7.Size = new Size(902, 83);
            panel7.TabIndex = 2;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Dock = DockStyle.Fill;
            TotalPrice.Font = new Font("Segoe UI", 15F);
            TotalPrice.Location = new Point(0, 0);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Padding = new Padding(200, 10, 0, 0);
            TotalPrice.Size = new Size(401, 64);
            TotalPrice.TabIndex = 0;
            TotalPrice.Text = "TotalPrice:";
            // 
            // Pay
            // 
            Pay.Dock = DockStyle.Bottom;
            Pay.Location = new Point(0, 1120);
            Pay.Name = "Pay";
            Pay.Size = new Size(902, 87);
            Pay.TabIndex = 1;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = true;
            Pay.Click += Pay_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 59);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(716, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(186, 59);
            panel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(40, 7);
            label5.Name = "label5";
            label5.Size = new Size(88, 45);
            label5.TabIndex = 3;
            label5.Text = "Total";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(622, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(94, 59);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1, 7);
            label4.Name = "label4";
            label4.Size = new Size(90, 45);
            label4.TabIndex = 3;
            label4.Text = "Dis%";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(476, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 59);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 7);
            label3.Name = "label3";
            label3.Size = new Size(123, 45);
            label3.TabIndex = 2;
            label3.Text = "U/Price";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(234, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 59);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(63, 7);
            label2.Name = "label2";
            label2.Size = new Size(141, 45);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 59);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 7);
            label1.Name = "label1";
            label1.Size = new Size(179, 45);
            label1.TabIndex = 0;
            label1.Text = "Item Name";
            // 
            // ManagerPanel
            // 
            ManagerPanel.Dock = DockStyle.Right;
            ManagerPanel.Location = new Point(477, 1054);
            ManagerPanel.Name = "ManagerPanel";
            ManagerPanel.Size = new Size(625, 153);
            ManagerPanel.TabIndex = 4;
            // 
            // categoryPanel
            // 
            categoryPanel.Dock = DockStyle.Top;
            categoryPanel.Location = new Point(0, 854);
            categoryPanel.Name = "categoryPanel";
            categoryPanel.Size = new Size(1102, 200);
            categoryPanel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 59);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1102, 795);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(UName);
            panel8.Controls.Add(SearchButton);
            panel8.Controls.Add(searchBox);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1102, 59);
            panel8.TabIndex = 1;
            // 
            // UName
            // 
            UName.AutoSize = true;
            UName.Font = new Font("Segoe UI", 12F);
            UName.Location = new Point(655, 9);
            UName.Name = "UName";
            UName.Size = new Size(0, 45);
            UName.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(383, 0);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(111, 59);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(162, 10);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Product";
            searchBox.Size = new Size(200, 39);
            searchBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2008, 1207);
            Controls.Add(splitContainer1);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "POS";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button Pay;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
        private Label TotalPrice;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel8;
        private FlowLayoutPanel categoryPanel;
        private TextBox searchBox;
        private Button SearchButton;
        private Panel ManagerPanel;
        private Label UName;
    }

}
