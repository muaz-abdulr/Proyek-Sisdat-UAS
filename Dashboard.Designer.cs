
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.ActorLabel = new System.Windows.Forms.Label();
            this.ActorFound = new System.Windows.Forms.ListBox();
            this.ActorSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(214, 137);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(349, 32);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ActorLabel
            // 
            this.ActorLabel.AutoSize = true;
            this.ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorLabel.Location = new System.Drawing.Point(119, 96);
            this.ActorLabel.Name = "ActorLabel";
            this.ActorLabel.Size = new System.Drawing.Size(47, 20);
            this.ActorLabel.TabIndex = 1;
            this.ActorLabel.Text = "Actor";
            // 
            // ActorFound
            // 
            this.ActorFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorFound.FormattingEnabled = true;
            this.ActorFound.ItemHeight = 20;
            this.ActorFound.Location = new System.Drawing.Point(123, 175);
            this.ActorFound.Name = "ActorFound";
            this.ActorFound.Size = new System.Drawing.Size(536, 144);
            this.ActorFound.TabIndex = 2;
            // 
            // ActorSearchBox
            // 
            this.ActorSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorSearchBox.Location = new System.Drawing.Point(226, 93);
            this.ActorSearchBox.Name = "ActorSearchBox";
            this.ActorSearchBox.Size = new System.Drawing.Size(433, 26);
            this.ActorSearchBox.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 440);
            this.Controls.Add(this.ActorSearchBox);
            this.Controls.Add(this.ActorFound);
            this.Controls.Add(this.ActorLabel);
            this.Controls.Add(this.SearchButton);
            this.Name = "Dashboard";
            this.Text = "Simple Search Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ActorLabel;
        private System.Windows.Forms.ListBox ActorFound;
        private System.Windows.Forms.TextBox ActorSearchBox;
    }
}

