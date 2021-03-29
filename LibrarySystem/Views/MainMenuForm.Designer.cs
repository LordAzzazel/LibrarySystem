
namespace LibrarySystem.Views
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnToHomePage = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLib = new System.Windows.Forms.Button();
            this.btnPublishingHouses = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnGivenBooks = new System.Windows.Forms.Button();
            this.btnReaders = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLib);
            this.panelMenu.Controls.Add(this.btnPublishingHouses);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnAuthors);
            this.panelMenu.Controls.Add(this.btnGivenBooks);
            this.panelMenu.Controls.Add(this.btnReaders);
            this.panelMenu.Controls.Add(this.btnBooks);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(210, 484);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(210, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.btnToHomePage);
            this.panelTitle.Controls.Add(this.TitleLabel);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(210, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(698, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // btnToHomePage
            // 
            this.btnToHomePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToHomePage.FlatAppearance.BorderSize = 0;
            this.btnToHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHomePage.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToHomePage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToHomePage.Location = new System.Drawing.Point(0, 0);
            this.btnToHomePage.Name = "btnToHomePage";
            this.btnToHomePage.Size = new System.Drawing.Size(75, 80);
            this.btnToHomePage.TabIndex = 0;
            this.btnToHomePage.Text = "X";
            this.btnToHomePage.UseVisualStyleBackColor = true;
            this.btnToHomePage.Click += new System.EventHandler(this.btnToHomePage_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleLabel.Location = new System.Drawing.Point(201, 27);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(248, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Домашняя страница";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(210, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(698, 404);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibrarySystem.Properties.Resources.library;
            this.pictureBox2.Location = new System.Drawing.Point(211, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnLib
            // 
            this.btnLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLib.FlatAppearance.BorderSize = 0;
            this.btnLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLib.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLib.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLib.Image = global::LibrarySystem.Properties.Resources.librarian;
            this.btnLib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLib.Location = new System.Drawing.Point(0, 350);
            this.btnLib.Name = "btnLib";
            this.btnLib.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLib.Size = new System.Drawing.Size(210, 60);
            this.btnLib.TabIndex = 7;
            this.btnLib.Text = "Библиотекари";
            this.btnLib.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLib.UseVisualStyleBackColor = true;
            this.btnLib.Click += new System.EventHandler(this.btnLib_Click);
            // 
            // btnPublishingHouses
            // 
            this.btnPublishingHouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublishingHouses.FlatAppearance.BorderSize = 0;
            this.btnPublishingHouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishingHouses.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPublishingHouses.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPublishingHouses.Image = global::LibrarySystem.Properties.Resources.open_book;
            this.btnPublishingHouses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublishingHouses.Location = new System.Drawing.Point(0, 290);
            this.btnPublishingHouses.Name = "btnPublishingHouses";
            this.btnPublishingHouses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPublishingHouses.Size = new System.Drawing.Size(210, 60);
            this.btnPublishingHouses.TabIndex = 6;
            this.btnPublishingHouses.Text = "Издательства";
            this.btnPublishingHouses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublishingHouses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPublishingHouses.UseVisualStyleBackColor = true;
            this.btnPublishingHouses.Click += new System.EventHandler(this.btnPublishingHouses_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::LibrarySystem.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthors.FlatAppearance.BorderSize = 0;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuthors.Image = global::LibrarySystem.Properties.Resources.writer;
            this.btnAuthors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthors.Location = new System.Drawing.Point(0, 240);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAuthors.Size = new System.Drawing.Size(210, 50);
            this.btnAuthors.TabIndex = 4;
            this.btnAuthors.Text = "Авторы";
            this.btnAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnGivenBooks
            // 
            this.btnGivenBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGivenBooks.FlatAppearance.BorderSize = 0;
            this.btnGivenBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGivenBooks.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGivenBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGivenBooks.Image = global::LibrarySystem.Properties.Resources.guidebook;
            this.btnGivenBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGivenBooks.Location = new System.Drawing.Point(0, 180);
            this.btnGivenBooks.Name = "btnGivenBooks";
            this.btnGivenBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGivenBooks.Size = new System.Drawing.Size(210, 60);
            this.btnGivenBooks.TabIndex = 3;
            this.btnGivenBooks.Text = "Выданные книги";
            this.btnGivenBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGivenBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGivenBooks.UseVisualStyleBackColor = true;
            this.btnGivenBooks.Click += new System.EventHandler(this.btnGivenBooks_Click);
            // 
            // btnReaders
            // 
            this.btnReaders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReaders.FlatAppearance.BorderSize = 0;
            this.btnReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReaders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReaders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReaders.Image = global::LibrarySystem.Properties.Resources.reading;
            this.btnReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaders.Location = new System.Drawing.Point(0, 130);
            this.btnReaders.Name = "btnReaders";
            this.btnReaders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReaders.Size = new System.Drawing.Size(210, 50);
            this.btnReaders.TabIndex = 2;
            this.btnReaders.Text = "Читатели";
            this.btnReaders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReaders.UseVisualStyleBackColor = true;
            this.btnReaders.Click += new System.EventHandler(this.btnReaders_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBooks.Image = global::LibrarySystem.Properties.Resources.open_book;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 80);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(210, 50);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Книги";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibrarySystem.Properties.Resources.booklet;
            this.pictureBox1.Location = new System.Drawing.Point(52, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 484);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnGivenBooks;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Button btnPublishingHouses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button btnToHomePage;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLib;
    }
}