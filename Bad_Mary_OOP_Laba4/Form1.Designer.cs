namespace Bad_Mary_OOP_Laba4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.comboBox_figures = new System.Windows.Forms.ComboBox();
            this.comboBox_colors = new System.Windows.Forms.ComboBox();
            this.Figures = new System.Windows.Forms.Label();
            this.labelColors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DeleteButton.Location = new System.Drawing.Point(630, 204);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(589, 43);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(173, 13);
            this.labelNumber.TabIndex = 3;
            this.labelNumber.Text = "Количество фигур в хранилище: ";
            // 
            // comboBox_figures
            // 
            this.comboBox_figures.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_figures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_figures.FormattingEnabled = true;
            this.comboBox_figures.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.comboBox_figures.Location = new System.Drawing.Point(608, 100);
            this.comboBox_figures.Name = "comboBox_figures";
            this.comboBox_figures.Size = new System.Drawing.Size(121, 21);
            this.comboBox_figures.TabIndex = 4;
            this.comboBox_figures.SelectedIndexChanged += new System.EventHandler(this.comboBox_figures_SelectedIndexChanged);
            // 
            // comboBox_colors
            // 
            this.comboBox_colors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_colors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_colors.FormattingEnabled = true;
            this.comboBox_colors.Items.AddRange(new object[] {
            "Pink",
            "Black",
            "Green",
            "Orange"});
            this.comboBox_colors.Location = new System.Drawing.Point(608, 158);
            this.comboBox_colors.Name = "comboBox_colors";
            this.comboBox_colors.Size = new System.Drawing.Size(121, 21);
            this.comboBox_colors.TabIndex = 5;
            this.comboBox_colors.SelectedIndexChanged += new System.EventHandler(this.comboBox_colors_SelectedIndexChanged);
            // 
            // Figures
            // 
            this.Figures.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Figures.AutoSize = true;
            this.Figures.Location = new System.Drawing.Point(643, 84);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(41, 13);
            this.Figures.TabIndex = 6;
            this.Figures.Text = "Figures";
            // 
            // labelColors
            // 
            this.labelColors.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelColors.AutoSize = true;
            this.labelColors.Location = new System.Drawing.Point(648, 142);
            this.labelColors.Name = "labelColors";
            this.labelColors.Size = new System.Drawing.Size(36, 13);
            this.labelColors.TabIndex = 7;
            this.labelColors.Text = "Colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelColors);
            this.Controls.Add(this.Figures);
            this.Controls.Add(this.comboBox_colors);
            this.Controls.Add(this.comboBox_figures);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.ComboBox comboBox_figures;
        private System.Windows.Forms.ComboBox comboBox_colors;
        private System.Windows.Forms.Label Figures;
        private System.Windows.Forms.Label labelColors;
    }
}

