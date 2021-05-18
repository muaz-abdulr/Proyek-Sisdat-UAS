
namespace Sisdat_Movie_List
{
    partial class Dashboard
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
            this.sideMenu = new System.Windows.Forms.Panel();
            this.searchForGenre = new System.Windows.Forms.Button();
            this.searchForDirector = new System.Windows.Forms.Button();
            this.searchForActor = new System.Windows.Forms.Button();
            this.searchForMovie = new System.Windows.Forms.Button();
            this.topLeft = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.entityID = new System.Windows.Forms.ListBox();
            this.DescTextBox = new System.Windows.Forms.RichTextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.sideMenu.SuspendLayout();
            this.topRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.sideMenu.Controls.Add(this.searchForGenre);
            this.sideMenu.Controls.Add(this.searchForDirector);
            this.sideMenu.Controls.Add(this.searchForActor);
            this.sideMenu.Controls.Add(this.searchForMovie);
            this.sideMenu.Controls.Add(this.topLeft);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(261, 657);
            this.sideMenu.TabIndex = 0;
            // 
            // searchForGenre
            // 
            this.searchForGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForGenre.FlatAppearance.BorderSize = 0;
            this.searchForGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.searchForGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForGenre.Location = new System.Drawing.Point(0, 394);
            this.searchForGenre.Margin = new System.Windows.Forms.Padding(0);
            this.searchForGenre.Name = "searchForGenre";
            this.searchForGenre.Size = new System.Drawing.Size(261, 88);
            this.searchForGenre.TabIndex = 5;
            this.searchForGenre.Text = "Genre";
            this.searchForGenre.UseVisualStyleBackColor = true;
            this.searchForGenre.Click += new System.EventHandler(this.searchForGenre_Click);
            // 
            // searchForDirector
            // 
            this.searchForDirector.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForDirector.FlatAppearance.BorderSize = 0;
            this.searchForDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.searchForDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForDirector.Location = new System.Drawing.Point(0, 306);
            this.searchForDirector.Margin = new System.Windows.Forms.Padding(0);
            this.searchForDirector.Name = "searchForDirector";
            this.searchForDirector.Size = new System.Drawing.Size(261, 88);
            this.searchForDirector.TabIndex = 4;
            this.searchForDirector.Text = "Director";
            this.searchForDirector.UseVisualStyleBackColor = true;
            this.searchForDirector.Click += new System.EventHandler(this.searchForDirector_Click);
            // 
            // searchForActor
            // 
            this.searchForActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForActor.FlatAppearance.BorderSize = 0;
            this.searchForActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.searchForActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForActor.Location = new System.Drawing.Point(0, 218);
            this.searchForActor.Margin = new System.Windows.Forms.Padding(0);
            this.searchForActor.Name = "searchForActor";
            this.searchForActor.Size = new System.Drawing.Size(261, 88);
            this.searchForActor.TabIndex = 3;
            this.searchForActor.Text = "Actor";
            this.searchForActor.UseVisualStyleBackColor = true;
            this.searchForActor.Click += new System.EventHandler(this.searchForActor_Click);
            // 
            // searchForMovie
            // 
            this.searchForMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForMovie.FlatAppearance.BorderSize = 0;
            this.searchForMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForMovie.Location = new System.Drawing.Point(0, 130);
            this.searchForMovie.Name = "searchForMovie";
            this.searchForMovie.Size = new System.Drawing.Size(261, 88);
            this.searchForMovie.TabIndex = 2;
            this.searchForMovie.Text = "Movie";
            this.searchForMovie.UseVisualStyleBackColor = true;
            this.searchForMovie.Click += new System.EventHandler(this.searchForMovie_Click);
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.topLeft.BackgroundImage = global::Sisdat_Movie_List.Properties.Resources.clapperboardIcon;
            this.topLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLeft.Location = new System.Drawing.Point(0, 0);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(261, 130);
            this.topLeft.TabIndex = 1;
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.topRight.Controls.Add(this.title);
            this.topRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRight.Location = new System.Drawing.Point(261, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(928, 130);
            this.topRight.TabIndex = 2;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.title.Location = new System.Drawing.Point(310, 41);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(388, 46);
            this.title.TabIndex = 0;
            this.title.Text = "MOVIE DATABASE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entityID
            // 
            this.entityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityID.FormattingEnabled = true;
            this.entityID.ItemHeight = 24;
            this.entityID.Location = new System.Drawing.Point(330, 208);
            this.entityID.Name = "entityID";
            this.entityID.Size = new System.Drawing.Size(809, 196);
            this.entityID.TabIndex = 3;
            this.entityID.SelectedIndexChanged += new System.EventHandler(this.entityID_SelectedIndexChanged);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DescTextBox.Location = new System.Drawing.Point(330, 427);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(809, 204);
            this.DescTextBox.TabIndex = 5;
            this.DescTextBox.Text = "";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(330, 171);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(407, 20);
            this.searchText.TabIndex = 6;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(757, 169);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 7;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1189, 657);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.entityID);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.sideMenu);
            this.MinimumSize = new System.Drawing.Size(1205, 696);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Search Query";
            this.sideMenu.ResumeLayout(false);
            this.topRight.ResumeLayout(false);
            this.topRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel topLeft;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button searchForActor;
        private System.Windows.Forms.Button searchForMovie;
        private System.Windows.Forms.Button searchForGenre;
        private System.Windows.Forms.Button searchForDirector;
        private System.Windows.Forms.ListBox entityID;
        private System.Windows.Forms.RichTextBox DescTextBox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button search;
    }
}

