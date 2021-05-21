
namespace Sisdat_Movie_List
{
    partial class Watchlist
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
            this.watchlistList = new System.Windows.Forms.ListBox();
            this.topRight = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.dateTimeWatchlist = new System.Windows.Forms.DateTimePicker();
            this.addBttn = new System.Windows.Forms.Button();
            this.filmList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // watchlistList
            // 
            this.watchlistList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchlistList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.watchlistList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.watchlistList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.watchlistList.ForeColor = System.Drawing.Color.White;
            this.watchlistList.FormattingEnabled = true;
            this.watchlistList.ItemHeight = 21;
            this.watchlistList.Location = new System.Drawing.Point(51, 287);
            this.watchlistList.Name = "watchlistList";
            this.watchlistList.Size = new System.Drawing.Size(610, 105);
            this.watchlistList.TabIndex = 4;
            this.watchlistList.SelectedIndexChanged += new System.EventHandler(this.watchlistList_SelectedIndexChanged);
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.topRight.Controls.Add(this.title);
            this.topRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRight.Location = new System.Drawing.Point(0, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(707, 99);
            this.topRight.TabIndex = 5;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.title.Location = new System.Drawing.Point(222, 41);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(245, 32);
            this.title.TabIndex = 0;
            this.title.Text = "MOVIE DATABASE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(288, 239);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 6;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(431, 239);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dateTimeWatchlist
            // 
            this.dateTimeWatchlist.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimeWatchlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimeWatchlist.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimeWatchlist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeWatchlist.Location = new System.Drawing.Point(0, 0);
            this.dateTimeWatchlist.Name = "dateTimeWatchlist";
            this.dateTimeWatchlist.ShowUpDown = true;
            this.dateTimeWatchlist.Size = new System.Drawing.Size(189, 27);
            this.dateTimeWatchlist.TabIndex = 9;
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(131, 239);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 10;
            this.addBttn.Text = "Add";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // filmList
            // 
            this.filmList.Dock = System.Windows.Forms.DockStyle.Right;
            this.filmList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.filmList.FormattingEnabled = true;
            this.filmList.Location = new System.Drawing.Point(212, 0);
            this.filmList.Name = "filmList";
            this.filmList.Size = new System.Drawing.Size(398, 29);
            this.filmList.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeWatchlist);
            this.panel1.Controls.Add(this.filmList);
            this.panel1.Location = new System.Drawing.Point(51, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 28);
            this.panel1.TabIndex = 12;
            // 
            // Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.watchlistList);
            this.Controls.Add(this.topRight);
            this.Name = "Watchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watchlist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Watchlist_FormClosed);
            this.Load += new System.EventHandler(this.Watchlist_Load);
            this.topRight.ResumeLayout(false);
            this.topRight.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox watchlistList;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DateTimePicker dateTimeWatchlist;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.ComboBox filmList;
        private System.Windows.Forms.Panel panel1;
    }
}