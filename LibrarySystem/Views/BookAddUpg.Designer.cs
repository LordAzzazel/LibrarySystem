
namespace LibrarySystem.Views
{
    partial class BookAddUpg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddUpg));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddUpg = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.PublishHouseLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExit.Location = new System.Drawing.Point(254, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddUpg
            // 
            this.btnAddUpg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddUpg.FlatAppearance.BorderSize = 0;
            this.btnAddUpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUpg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddUpg.ForeColor = System.Drawing.Color.White;
            this.btnAddUpg.Location = new System.Drawing.Point(12, 384);
            this.btnAddUpg.Name = "btnAddUpg";
            this.btnAddUpg.Size = new System.Drawing.Size(268, 36);
            this.btnAddUpg.TabIndex = 9;
            this.btnAddUpg.Text = "Добавить";
            this.btnAddUpg.UseVisualStyleBackColor = false;
            this.btnAddUpg.Click += new System.EventHandler(this.btnAddUpg_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormNameLabel.Location = new System.Drawing.Point(4, 119);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(285, 36);
            this.FormNameLabel.TabIndex = 11;
            this.FormNameLabel.Text = "Добавление книги";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySystem.Properties.Resources.booklet;
            this.pictureBox1.Location = new System.Drawing.Point(99, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox1.Location = new System.Drawing.Point(111, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 21);
            this.textBox1.TabIndex = 12;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.BookNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BookNameLabel.Location = new System.Drawing.Point(7, 176);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(98, 15);
            this.BookNameLabel.TabIndex = 17;
            this.BookNameLabel.Text = "Название книги:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.AuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AuthorLabel.Location = new System.Drawing.Point(7, 216);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(44, 15);
            this.AuthorLabel.TabIndex = 18;
            this.AuthorLabel.Text = "Автор:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.YearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.YearLabel.Location = new System.Drawing.Point(7, 254);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 15);
            this.YearLabel.TabIndex = 19;
            this.YearLabel.Text = "Год:";
            // 
            // PublishHouseLabel
            // 
            this.PublishHouseLabel.AutoSize = true;
            this.PublishHouseLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.PublishHouseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PublishHouseLabel.Location = new System.Drawing.Point(7, 294);
            this.PublishHouseLabel.Name = "PublishHouseLabel";
            this.PublishHouseLabel.Size = new System.Drawing.Size(88, 15);
            this.PublishHouseLabel.TabIndex = 20;
            this.PublishHouseLabel.Text = "Издательство:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.NumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.NumberLabel.Location = new System.Drawing.Point(7, 330);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(76, 15);
            this.NumberLabel.TabIndex = 21;
            this.NumberLabel.Text = "Количество:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBox5.Location = new System.Drawing.Point(111, 327);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 21);
            this.textBox5.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 292);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 23);
            this.comboBox2.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 251);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(169, 21);
            this.maskedTextBox1.TabIndex = 37;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // BookAddUpg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.PublishHouseLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FormNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddUpg);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookAddUpg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAddUpg";
            this.Activated += new System.EventHandler(this.BookAddUpg_Activated);
            this.Load += new System.EventHandler(this.BookAddUpg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddUpg;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label PublishHouseLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}