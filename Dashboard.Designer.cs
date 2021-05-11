
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
            this.RecordFound = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.tableChoices = new System.Windows.Forms.ComboBox();
            this.columnChoices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(134, 146);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 32);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RecordFound
            // 
            this.RecordFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordFound.FormattingEnabled = true;
            this.RecordFound.ItemHeight = 20;
            this.RecordFound.Location = new System.Drawing.Point(134, 190);
            this.RecordFound.Name = "RecordFound";
            this.RecordFound.Size = new System.Drawing.Size(536, 144);
            this.RecordFound.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(357, 152);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(313, 26);
            this.SearchBox.TabIndex = 3;
            // 
            // tableChoices
            // 
            this.tableChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableChoices.FormattingEnabled = true;
            this.tableChoices.Items.AddRange(new object[] {
            "Actors",
            "Directors",
            "Films"});
            this.tableChoices.Location = new System.Drawing.Point(453, 61);
            this.tableChoices.Name = "tableChoices";
            this.tableChoices.Size = new System.Drawing.Size(217, 28);
            this.tableChoices.TabIndex = 4;
            this.tableChoices.SelectedIndexChanged += new System.EventHandler(this.tableChoices_SelectedIndexChanged);
            // 
            // columnChoices
            // 
            this.columnChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnChoices.FormattingEnabled = true;
            this.columnChoices.Location = new System.Drawing.Point(453, 104);
            this.columnChoices.Name = "columnChoices";
            this.columnChoices.Size = new System.Drawing.Size(217, 28);
            this.columnChoices.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 440);
            this.Controls.Add(this.columnChoices);
            this.Controls.Add(this.tableChoices);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RecordFound);
            this.Controls.Add(this.SearchButton);
            this.Name = "Dashboard";
            this.Text = "Simple Search Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //object yang ada di UI
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox RecordFound;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox tableChoices;
        private System.Windows.Forms.ComboBox columnChoices;
    }
}

