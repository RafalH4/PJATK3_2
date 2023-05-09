namespace PJATK3_2
{
    partial class AddEditPracownikDialog
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
            titleLabel = new Label();
            imieLabel = new Label();
            nazwiskoLabel = new Label();
            emailLabel = new Label();
            dataUrodzeniaLabel = new Label();
            imieTextBox = new TextBox();
            nazwiskoTextBox = new TextBox();
            emailTextBox = new TextBox();
            dataUrodzeniaPicker = new DateTimePicker();
            dodajButton = new Button();
            anulujButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(21, 16);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(185, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Dodaj studenta";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new Point(27, 76);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new Size(38, 20);
            imieLabel.TabIndex = 1;
            imieLabel.Text = "Imię";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new Point(27, 119);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new Size(72, 20);
            nazwiskoLabel.TabIndex = 2;
            nazwiskoLabel.Text = "Nazwisko";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(27, 165);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // dataUrodzeniaLabel
            // 
            dataUrodzeniaLabel.AutoSize = true;
            dataUrodzeniaLabel.Location = new Point(27, 211);
            dataUrodzeniaLabel.Name = "dataUrodzeniaLabel";
            dataUrodzeniaLabel.Size = new Size(113, 20);
            dataUrodzeniaLabel.TabIndex = 4;
            dataUrodzeniaLabel.Text = "Data Urodzenia";
            // 
            // imieTextBox
            // 
            imieTextBox.Location = new Point(144, 73);
            imieTextBox.Name = "imieTextBox";
            imieTextBox.Size = new Size(291, 27);
            imieTextBox.TabIndex = 5;
            // 
            // nazwiskoTextBox
            // 
            nazwiskoTextBox.Location = new Point(144, 116);
            nazwiskoTextBox.Name = "nazwiskoTextBox";
            nazwiskoTextBox.Size = new Size(291, 27);
            nazwiskoTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(144, 162);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(291, 27);
            emailTextBox.TabIndex = 7;
            // 
            // dataUrodzeniaPicker
            // 
            dataUrodzeniaPicker.Location = new Point(144, 204);
            dataUrodzeniaPicker.Name = "dataUrodzeniaPicker";
            dataUrodzeniaPicker.Size = new Size(291, 27);
            dataUrodzeniaPicker.TabIndex = 8;
            // 
            // dodajButton
            // 
            dodajButton.Location = new Point(144, 259);
            dodajButton.Name = "dodajButton";
            dodajButton.Size = new Size(129, 29);
            dodajButton.TabIndex = 9;
            dodajButton.Text = "OK";
            dodajButton.UseVisualStyleBackColor = true;
            dodajButton.Click += dodajButton_Click;
            // 
            // anulujButton
            // 
            anulujButton.Location = new Point(306, 259);
            anulujButton.Name = "anulujButton";
            anulujButton.Size = new Size(129, 29);
            anulujButton.TabIndex = 10;
            anulujButton.Text = "Anuluj";
            anulujButton.UseVisualStyleBackColor = true;
            anulujButton.Click += anulujButton_Click;
            // 
            // AddEditPracownikDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 301);
            Controls.Add(anulujButton);
            Controls.Add(dodajButton);
            Controls.Add(dataUrodzeniaPicker);
            Controls.Add(emailTextBox);
            Controls.Add(nazwiskoTextBox);
            Controls.Add(imieTextBox);
            Controls.Add(dataUrodzeniaLabel);
            Controls.Add(emailLabel);
            Controls.Add(nazwiskoLabel);
            Controls.Add(imieLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditPracownikDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditPracownikDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label imieLabel;
        private Label nazwiskoLabel;
        private Label emailLabel;
        private Label dataUrodzeniaLabel;
        private TextBox imieTextBox;
        private TextBox nazwiskoTextBox;
        private TextBox emailTextBox;
        private DateTimePicker dataUrodzeniaPicker;
        private Button dodajButton;
        private Button anulujButton;
    }
}