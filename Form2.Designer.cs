namespace Practic5
{
    partial class Form2
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
            this.NewArticles = new System.Windows.Forms.TextBox();
            this.NewArticle = new System.Windows.Forms.Button();
            this.Conditions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewArticles
            // 
            this.NewArticles.Location = new System.Drawing.Point(12, 12);
            this.NewArticles.Multiline = true;
            this.NewArticles.Name = "NewArticles";
            this.NewArticles.Size = new System.Drawing.Size(478, 415);
            this.NewArticles.TabIndex = 0;
            // 
            // NewArticle
            // 
            this.NewArticle.Location = new System.Drawing.Point(539, 316);
            this.NewArticle.Name = "NewArticle";
            this.NewArticle.Size = new System.Drawing.Size(214, 111);
            this.NewArticle.TabIndex = 1;
            this.NewArticle.Text = "Добавить";
            this.NewArticle.UseVisualStyleBackColor = true;
            this.NewArticle.Click += new System.EventHandler(this.NewArticle_Click);
            // 
            // Conditions
            // 
            this.Conditions.Location = new System.Drawing.Point(516, 12);
            this.Conditions.Multiline = true;
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(112, 46);
            this.Conditions.TabIndex = 2;
            this.Conditions.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите Условие";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Conditions);
            this.Controls.Add(this.NewArticle);
            this.Controls.Add(this.NewArticles);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewArticles;
        private System.Windows.Forms.Button NewArticle;
        private System.Windows.Forms.TextBox Conditions;
        private System.Windows.Forms.Label label1;
    }
}