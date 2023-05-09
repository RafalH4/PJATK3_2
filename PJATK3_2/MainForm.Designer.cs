namespace PJATK3_2
{
    partial class MainForm
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
            label1 = new Label();
            loginLabel = new Label();
            groupBox1 = new GroupBox();
            usunButton = new Button();
            edytujButton = new Button();
            dodajButton = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Zalogowano jako:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(146, 42);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(50, 20);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usunButton);
            groupBox1.Controls.Add(edytujButton);
            groupBox1.Controls.Add(dodajButton);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edycja pracownika";
            // 
            // usunButton
            // 
            usunButton.Location = new Point(286, 35);
            usunButton.Name = "usunButton";
            usunButton.Size = new Size(130, 48);
            usunButton.TabIndex = 2;
            usunButton.Text = "Usuń";
            usunButton.UseVisualStyleBackColor = true;
            usunButton.Click += usunButton_Click;
            // 
            // edytujButton
            // 
            edytujButton.Location = new Point(150, 35);
            edytujButton.Name = "edytujButton";
            edytujButton.Size = new Size(130, 48);
            edytujButton.TabIndex = 1;
            edytujButton.Text = "Edytuj";
            edytujButton.UseVisualStyleBackColor = true;
            edytujButton.Click += edytujButton_Click;
            // 
            // dodajButton
            // 
            dodajButton.Location = new Point(14, 35);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(130, 48);
            dodajButton.TabIndex = 0;
            dodajButton.Text = "Dodaj";
            dodajButton.UseVisualStyleBackColor = true;
            dodajButton.Click += dodajButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 318);
            dataGridView1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zamknijToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(145, 26);
            zamknijToolStripMenuItem.Text = "Zamknij";
            zamknijToolStripMenuItem.Click += zamknijToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(loginLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label loginLabel;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private Button usunButton;
        private Button edytujButton;
        private Button dodajButton;
    }
}