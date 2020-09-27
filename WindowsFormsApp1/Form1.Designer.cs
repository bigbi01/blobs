namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInput = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DivBouton = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMoins = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnEgale = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(12, 12);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(632, 20);
            this.UserInput.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.Location = new System.Drawing.Point(12, 35);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(632, 28);
            this.Results.TabIndex = 1;
            this.Results.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.DeleteButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.DivBouton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.Btn7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Btn8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Btn9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.BtnX, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Btn4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.Btn5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Btn6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.BtnMoins, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Btn1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Btn2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Btn3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.BtnPlus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Btn0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.BtnDot, 2, 4);
            this.ButtonsPanel.Controls.Add(this.BtnEgale, 3, 4);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 66);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(632, 433);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(152, 80);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(319, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(152, 80);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Del";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DivBouton
            // 
            this.DivBouton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivBouton.Location = new System.Drawing.Point(477, 3);
            this.DivBouton.Name = "DivBouton";
            this.DivBouton.Size = new System.Drawing.Size(152, 80);
            this.DivBouton.TabIndex = 3;
            this.DivBouton.Text = "%";
            this.DivBouton.UseVisualStyleBackColor = true;
            this.DivBouton.Click += new System.EventHandler(this.DivBouton_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn7.Location = new System.Drawing.Point(3, 89);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(152, 80);
            this.Btn7.TabIndex = 4;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn8.Location = new System.Drawing.Point(161, 89);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(152, 80);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn9.Location = new System.Drawing.Point(319, 89);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(152, 80);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnX
            // 
            this.BtnX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnX.Location = new System.Drawing.Point(477, 89);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(152, 80);
            this.BtnX.TabIndex = 7;
            this.BtnX.Text = "X";
            this.BtnX.UseVisualStyleBackColor = true;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn4.Location = new System.Drawing.Point(3, 175);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(152, 80);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn5.Location = new System.Drawing.Point(161, 175);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(152, 80);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn6.Location = new System.Drawing.Point(319, 175);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(152, 80);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnMoins
            // 
            this.BtnMoins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMoins.Location = new System.Drawing.Point(477, 175);
            this.BtnMoins.Name = "BtnMoins";
            this.BtnMoins.Size = new System.Drawing.Size(152, 80);
            this.BtnMoins.TabIndex = 11;
            this.BtnMoins.Text = "-";
            this.BtnMoins.UseVisualStyleBackColor = true;
            this.BtnMoins.Click += new System.EventHandler(this.BtnMoins_Click);
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn1.Location = new System.Drawing.Point(3, 261);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(152, 80);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn2.Location = new System.Drawing.Point(161, 261);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(152, 80);
            this.Btn2.TabIndex = 13;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn3.Location = new System.Drawing.Point(319, 261);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(152, 80);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPlus.Location = new System.Drawing.Point(477, 261);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(152, 80);
            this.BtnPlus.TabIndex = 15;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn0.Location = new System.Drawing.Point(161, 347);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(152, 83);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDot.Location = new System.Drawing.Point(319, 347);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(152, 83);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // BtnEgale
            // 
            this.BtnEgale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEgale.Location = new System.Drawing.Point(477, 347);
            this.BtnEgale.Name = "BtnEgale";
            this.BtnEgale.Size = new System.Drawing.Size(152, 83);
            this.BtnEgale.TabIndex = 19;
            this.BtnEgale.Text = "=";
            this.BtnEgale.UseVisualStyleBackColor = true;
            this.BtnEgale.Click += new System.EventHandler(this.BtnEgale_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnEgale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(656, 511);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.UserInput);
            this.Name = "Form1";
            this.Text = "Basic Caculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DivBouton;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnMoins;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnEgale;
    }
}

