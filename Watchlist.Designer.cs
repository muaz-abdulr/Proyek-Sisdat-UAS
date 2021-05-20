
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
            this.entityID = new System.Windows.Forms.ListBox();
            this.topRight = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.topRight.SuspendLayout();
            this.SuspendLayout();
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
            this.entityID.Location = new System.Drawing.Point(165, 157);
            this.entityID.Name = "entityID";
            this.entityID.Size = new System.Drawing.Size(623, 198);
            this.entityID.TabIndex = 4;
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(83)))), ((int)(((byte)(110)))));
            this.topRight.Controls.Add(this.title);
            this.topRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.topRight.Location = new System.Drawing.Point(0, 0);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(800, 130);
            this.topRight.TabIndex = 5;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(230)))));
            this.title.Location = new System.Drawing.Point(246, 41);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(361, 47);
            this.title.TabIndex = 0;
            this.title.Text = "MOVIE DATABASE";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(61, 157);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 6;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(61, 212);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // Watchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.entityID);
            this.Controls.Add(this.topRight);
            this.Name = "Watchlist";
            this.Text = "Watchlist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Watchlist_FormClosed);
            this.Load += new System.EventHandler(this.Watchlist_Load);
            this.topRight.ResumeLayout(false);
            this.topRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox entityID;
        private System.Windows.Forms.Panel topRight;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
    }
}