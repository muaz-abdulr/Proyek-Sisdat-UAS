
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
            System.Windows.Forms.Button deletebutton;
            this.watchlistList = new System.Windows.Forms.ListBox();
            this.topRight = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.dateTimeWatchlist = new System.Windows.Forms.DateTimePicker();
            this.addBttn = new System.Windows.Forms.Button();
            this.filmList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelhighlight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            deletebutton = new System.Windows.Forms.Button();
            this.topRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deletebutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            deletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            deletebutton.Location = new System.Drawing.Point(276, 183);
            deletebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new System.Drawing.Size(272, 110);
            deletebutton.TabIndex = 7;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            deletebutton.MouseLeave += new System.EventHandler(this.deletebutton_MouseLeave);
            deletebutton.MouseHover += new System.EventHandler(this.deletebutton_MouseHover);
            // 
            // watchlistList
            // 
            this.watchlistList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchlistList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.watchlistList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.watchlistList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.watchlistList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.watchlistList.FormattingEnabled = true;
            this.watchlistList.ItemHeight = 21;
            this.watchlistList.Location = new System.Drawing.Point(14, 300);
            this.watchlistList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.watchlistList.Name = "watchlistList";
            this.watchlistList.Size = new System.Drawing.Size(797, 231);
            this.watchlistList.TabIndex = 4;
            this.watchlistList.SelectedIndexChanged += new System.EventHandler(this.watchlistList_SelectedIndexChanged);
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.topRight.Controls.Add(this.title);
            this.topRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRight.Location = new System.Drawing.Point(0, 0);
            this.topRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(825, 122);
            this.topRight.TabIndex = 5;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 35.45F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.title.Location = new System.Drawing.Point(197, 27);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(414, 56);
            this.title.TabIndex = 0;
            this.title.Text = "YOUR WATCHLIST";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.updatebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updatebutton.Location = new System.Drawing.Point(555, 183);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(255, 110);
            this.updatebutton.TabIndex = 6;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            this.updatebutton.MouseLeave += new System.EventHandler(this.updatebutton_MouseLeave);
            this.updatebutton.MouseHover += new System.EventHandler(this.updatebutton_MouseHover);
            // 
            // dateTimeWatchlist
            // 
            this.dateTimeWatchlist.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeWatchlist.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimeWatchlist.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimeWatchlist.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimeWatchlist.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimeWatchlist.CustomFormat = "HH:mm:ss dd-MM-yyyy";
            this.dateTimeWatchlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimeWatchlist.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimeWatchlist.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeWatchlist.Location = new System.Drawing.Point(0, 0);
            this.dateTimeWatchlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeWatchlist.Name = "dateTimeWatchlist";
            this.dateTimeWatchlist.Size = new System.Drawing.Size(210, 27);
            this.dateTimeWatchlist.TabIndex = 9;
            this.dateTimeWatchlist.Value = new System.DateTime(2021, 5, 6, 0, 0, 0, 0);
            // 
            // addBttn
            // 
            this.addBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.addBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBttn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.addBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBttn.Location = new System.Drawing.Point(14, 183);
            this.addBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(255, 110);
            this.addBttn.TabIndex = 10;
            this.addBttn.Text = "Add";
            this.addBttn.UseVisualStyleBackColor = false;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            this.addBttn.MouseLeave += new System.EventHandler(this.addBttn_MouseLeave);
            this.addBttn.MouseHover += new System.EventHandler(this.addBttn_MouseHover);
            // 
            // filmList
            // 
            this.filmList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filmList.Dock = System.Windows.Forms.DockStyle.Right;
            this.filmList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.filmList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filmList.FormattingEnabled = true;
            this.filmList.Location = new System.Drawing.Point(216, 0);
            this.filmList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filmList.Name = "filmList";
            this.filmList.Size = new System.Drawing.Size(581, 29);
            this.filmList.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeWatchlist);
            this.panel1.Controls.Add(this.filmList);
            this.panel1.Location = new System.Drawing.Point(14, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 33);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.panel3.Location = new System.Drawing.Point(14, 170);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 6);
            this.panel3.TabIndex = 13;
            // 
            // panelhighlight
            // 
            this.panelhighlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelhighlight.BackColor = System.Drawing.Color.SlateGray;
            this.panelhighlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelhighlight.Location = new System.Drawing.Point(35, 267);
            this.panelhighlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelhighlight.Name = "panelhighlight";
            this.panelhighlight.Size = new System.Drawing.Size(217, 12);
            this.panelhighlight.TabIndex = 14;
            this.panelhighlight.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(304, 267);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 12);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(576, 267);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 12);
            this.panel4.TabIndex = 16;
            this.panel4.Visible = false;
            // 
            // Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(825, 544);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelhighlight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(deletebutton);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.watchlistList);
            this.Controls.Add(this.topRight);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.DateTimePicker dateTimeWatchlist;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.ComboBox filmList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelhighlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}