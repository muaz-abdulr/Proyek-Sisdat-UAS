
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
            this.highLight = new System.Windows.Forms.Panel();
            this.searchForGenre = new System.Windows.Forms.Button();
            this.searchForDirector = new System.Windows.Forms.Button();
            this.searchForActor = new System.Windows.Forms.Button();
            this.searchForMovie = new System.Windows.Forms.Button();
            this.topLeft = new System.Windows.Forms.Panel();
            this.topRight = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entityID = new System.Windows.Forms.ListBox();
            this.DescTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.minimizeBttn = new System.Windows.Forms.Button();
            this.maximizeBttn = new System.Windows.Forms.Button();
            this.closeBttn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelsearch = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.sideMenu.SuspendLayout();
            this.topRight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.borderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
            this.sideMenu.Controls.Add(this.highLight);
            this.sideMenu.Controls.Add(this.searchForGenre);
            this.sideMenu.Controls.Add(this.searchForDirector);
            this.sideMenu.Controls.Add(this.searchForActor);
            this.sideMenu.Controls.Add(this.searchForMovie);
            this.sideMenu.Controls.Add(this.topLeft);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 21);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(261, 675);
            this.sideMenu.TabIndex = 0;
            // 
            // highLight
            // 
            this.highLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.highLight.Location = new System.Drawing.Point(0, 218);
            this.highLight.Name = "highLight";
            this.highLight.Size = new System.Drawing.Size(10, 88);
            this.highLight.TabIndex = 6;
            this.highLight.Visible = false;
            // 
            // searchForGenre
            // 
            this.searchForGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForGenre.FlatAppearance.BorderSize = 0;
            this.searchForGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForGenre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.searchForGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForGenre.Location = new System.Drawing.Point(0, 394);
            this.searchForGenre.Margin = new System.Windows.Forms.Padding(0);
            this.searchForGenre.Name = "searchForGenre";
            this.searchForGenre.Size = new System.Drawing.Size(261, 88);
            this.searchForGenre.TabIndex = 5;
            this.searchForGenre.Text = "Genre";
            this.searchForGenre.UseVisualStyleBackColor = true;
            this.searchForGenre.Click += new System.EventHandler(this.searchForGenre_Click);
            this.searchForGenre.Leave += new System.EventHandler(this.searchForGenre_Leave);
            // 
            // searchForDirector
            // 
            this.searchForDirector.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForDirector.FlatAppearance.BorderSize = 0;
            this.searchForDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForDirector.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.searchForDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForDirector.Location = new System.Drawing.Point(0, 306);
            this.searchForDirector.Margin = new System.Windows.Forms.Padding(0);
            this.searchForDirector.Name = "searchForDirector";
            this.searchForDirector.Size = new System.Drawing.Size(261, 88);
            this.searchForDirector.TabIndex = 4;
            this.searchForDirector.Text = "Director";
            this.searchForDirector.UseVisualStyleBackColor = true;
            this.searchForDirector.Click += new System.EventHandler(this.searchForDirector_Click);
            this.searchForDirector.Leave += new System.EventHandler(this.searchForDirector_Leave);
            // 
            // searchForActor
            // 
            this.searchForActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForActor.FlatAppearance.BorderSize = 0;
            this.searchForActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForActor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForActor.Location = new System.Drawing.Point(0, 218);
            this.searchForActor.Margin = new System.Windows.Forms.Padding(0);
            this.searchForActor.Name = "searchForActor";
            this.searchForActor.Size = new System.Drawing.Size(261, 88);
            this.searchForActor.TabIndex = 3;
            this.searchForActor.Text = "Actor";
            this.searchForActor.UseVisualStyleBackColor = true;
            this.searchForActor.Click += new System.EventHandler(this.searchForActor_Click);
            this.searchForActor.Leave += new System.EventHandler(this.searchForActor_Leave);
            // 
            // searchForMovie
            // 
            this.searchForMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForMovie.FlatAppearance.BorderSize = 0;
            this.searchForMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForMovie.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchForMovie.Location = new System.Drawing.Point(0, 130);
            this.searchForMovie.Name = "searchForMovie";
            this.searchForMovie.Size = new System.Drawing.Size(261, 88);
            this.searchForMovie.TabIndex = 2;
            this.searchForMovie.Text = "Movie";
            this.searchForMovie.UseVisualStyleBackColor = true;
            this.searchForMovie.Click += new System.EventHandler(this.searchForMovie_Click);
            this.searchForMovie.Leave += new System.EventHandler(this.searchForMovie_Leave);
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
            this.topRight.Location = new System.Drawing.Point(261, 21);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(944, 130);
            this.topRight.TabIndex = 2;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.title.Location = new System.Drawing.Point(318, 41);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(361, 47);
            this.title.TabIndex = 0;
            this.title.Text = "MOVIE DATABASE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.searchText.Location = new System.Drawing.Point(0, 3);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(656, 24);
            this.searchText.TabIndex = 6;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.search.Dock = System.Windows.Forms.DockStyle.Right;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(742, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(133, 29);
            this.search.TabIndex = 7;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.searchText);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(303, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 29);
            this.panel2.TabIndex = 9;
            // 
            // entityID
            // 
            this.entityID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entityID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.entityID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entityID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityID.ForeColor = System.Drawing.Color.White;
            this.entityID.FormattingEnabled = true;
            this.entityID.ItemHeight = 22;
            this.entityID.Location = new System.Drawing.Point(313, 257);
            this.entityID.Name = "entityID";
            this.entityID.Size = new System.Drawing.Size(854, 132);
            this.entityID.TabIndex = 3;
            this.entityID.SelectedIndexChanged += new System.EventHandler(this.entityID_SelectedIndexChanged);
            // 
            // DescTextBox
            // 
            this.DescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.DescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTextBox.ForeColor = System.Drawing.Color.White;
            this.DescTextBox.Location = new System.Drawing.Point(313, 415);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(854, 246);
            this.DescTextBox.TabIndex = 5;
            this.DescTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.panel1.Location = new System.Drawing.Point(303, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 5);
            this.panel1.TabIndex = 10;
            // 
            // borderPanel
            // 
            this.borderPanel.Controls.Add(this.minimizeBttn);
            this.borderPanel.Controls.Add(this.maximizeBttn);
            this.borderPanel.Controls.Add(this.closeBttn);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel.Location = new System.Drawing.Point(0, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(1205, 21);
            this.borderPanel.TabIndex = 11;
            this.borderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseDown);
            this.borderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseMove);
            this.borderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderPanel_MouseUp);
            // 
            // minimizeBttn
            // 
            this.minimizeBttn.BackgroundImage = global::Sisdat_Movie_List.Properties.Resources.minimizeRect;
            this.minimizeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBttn.FlatAppearance.BorderSize = 0;
            this.minimizeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBttn.Location = new System.Drawing.Point(980, 0);
            this.minimizeBttn.Name = "minimizeBttn";
            this.minimizeBttn.Size = new System.Drawing.Size(75, 21);
            this.minimizeBttn.TabIndex = 1;
            this.minimizeBttn.UseVisualStyleBackColor = true;
            this.minimizeBttn.Click += new System.EventHandler(this.minimizeBttn_Click);
            // 
            // maximizeBttn
            // 
            this.maximizeBttn.BackgroundImage = global::Sisdat_Movie_List.Properties.Resources.resizeRect;
            this.maximizeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximizeBttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeBttn.FlatAppearance.BorderSize = 0;
            this.maximizeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeBttn.Location = new System.Drawing.Point(1055, 0);
            this.maximizeBttn.Name = "maximizeBttn";
            this.maximizeBttn.Size = new System.Drawing.Size(75, 21);
            this.maximizeBttn.TabIndex = 2;
            this.maximizeBttn.UseVisualStyleBackColor = true;
            this.maximizeBttn.Click += new System.EventHandler(this.maximizeBttn_Click);
            // 
            // closeBttn
            // 
            this.closeBttn.BackgroundImage = global::Sisdat_Movie_List.Properties.Resources.X;
            this.closeBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBttn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBttn.FlatAppearance.BorderSize = 0;
            this.closeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBttn.Location = new System.Drawing.Point(1130, 0);
            this.closeBttn.Name = "closeBttn";
            this.closeBttn.Size = new System.Drawing.Size(75, 21);
            this.closeBttn.TabIndex = 0;
            this.closeBttn.UseVisualStyleBackColor = true;
            this.closeBttn.Click += new System.EventHandler(this.closeBttn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.panel4.Location = new System.Drawing.Point(303, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 423);
            this.panel4.TabIndex = 12;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelsearch.Location = new System.Drawing.Point(299, 165);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(91, 21);
            this.labelsearch.TabIndex = 7;
            this.labelsearch.Text = "Search For";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblvalue.Location = new System.Drawing.Point(386, 165);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(22, 21);
            this.lblvalue.TabIndex = 13;
            this.lblvalue.Text = "...";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1205, 696);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entityID);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.borderPanel);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1205, 696);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Search Query";
            this.sideMenu.ResumeLayout(false);
            this.topRight.ResumeLayout(false);
            this.topRight.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.borderPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox entityID;
        private System.Windows.Forms.RichTextBox DescTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Button minimizeBttn;
        private System.Windows.Forms.Button maximizeBttn;
        private System.Windows.Forms.Button closeBttn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel highLight;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.Label lblvalue;
    }
}

