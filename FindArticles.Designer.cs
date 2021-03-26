namespace Practic5
{
    partial class FindArticles
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
            this.FindArticlesBox = new System.Windows.Forms.TextBox();
            this.FindArticle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descript = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindArticlesBox
            // 
            this.FindArticlesBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindArticlesBox.Location = new System.Drawing.Point(443, 39);
            this.FindArticlesBox.Multiline = true;
            this.FindArticlesBox.Name = "FindArticlesBox";
            this.FindArticlesBox.Size = new System.Drawing.Size(264, 46);
            this.FindArticlesBox.TabIndex = 0;
            // 
            // FindArticle
            // 
            this.FindArticle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindArticle.Location = new System.Drawing.Point(485, 91);
            this.FindArticle.Name = "FindArticle";
            this.FindArticle.Size = new System.Drawing.Size(188, 44);
            this.FindArticle.TabIndex = 1;
            this.FindArticle.Text = "Найти";
            this.FindArticle.UseVisualStyleBackColor = true;
            this.FindArticle.Click += new System.EventHandler(this.FindArticle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 123);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Статья";
            this.columnHeader1.Width = 257;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата";
            this.columnHeader2.Width = 115;
            // 
            // Descript
            // 
            this.Descript.AutoSize = true;
            this.Descript.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Descript.Location = new System.Drawing.Point(458, 9);
            this.Descript.Name = "Descript";
            this.Descript.Size = new System.Drawing.Size(249, 27);
            this.Descript.TabIndex = 3;
            this.Descript.Text = "Введите название статьи";
            // 
            // FindArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 158);
            this.Controls.Add(this.Descript);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FindArticle);
            this.Controls.Add(this.FindArticlesBox);
            this.Name = "FindArticles";
            this.Text = "FindArticles";
            this.Load += new System.EventHandler(this.FindArticles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindArticlesBox;
        private System.Windows.Forms.Button FindArticle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label Descript;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}