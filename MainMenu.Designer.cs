namespace Practic5
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnterNewArticle = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.FindArticles = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(399, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Список статей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 614);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Статья";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Условия";
            this.columnHeader3.Width = 205;
            // 
            // EnterNewArticle
            // 
            this.EnterNewArticle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterNewArticle.Location = new System.Drawing.Point(399, 81);
            this.EnterNewArticle.Name = "EnterNewArticle";
            this.EnterNewArticle.Size = new System.Drawing.Size(355, 76);
            this.EnterNewArticle.TabIndex = 3;
            this.EnterNewArticle.Text = "Добавить новую статью";
            this.EnterNewArticle.UseVisualStyleBackColor = true;
            this.EnterNewArticle.Click += new System.EventHandler(this.EnterNewArticle_Click);
            // 
            // NewUser
            // 
            this.NewUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUser.Location = new System.Drawing.Point(399, 524);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(355, 76);
            this.NewUser.TabIndex = 4;
            this.NewUser.Text = "Добавить нового пользователя";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // FindArticles
            // 
            this.FindArticles.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindArticles.Location = new System.Drawing.Point(399, 163);
            this.FindArticles.Name = "FindArticles";
            this.FindArticles.Size = new System.Drawing.Size(355, 76);
            this.FindArticles.TabIndex = 5;
            this.FindArticles.Text = "Поиск статьи";
            this.FindArticles.UseVisualStyleBackColor = true;
            this.FindArticles.Click += new System.EventHandler(this.FindArticles_Click);
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Print.Location = new System.Drawing.Point(399, 245);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(355, 76);
            this.Print.TabIndex = 6;
            this.Print.Text = "Печать";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 612);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.FindArticles);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.EnterNewArticle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button EnterNewArticle;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button FindArticles;
        private System.Windows.Forms.Button Print;
    }
}