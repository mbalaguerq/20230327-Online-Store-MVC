namespace Online_Store_Windows_Forms.vista
{
    partial class ArticleView
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
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.BtmenuPrincipal = new System.Windows.Forms.Button();
            this.BtmostrarArticles = new System.Windows.Forms.Button();
            this.BtafegirArticles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(84, 23);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 1;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // BtmenuPrincipal
            // 
            this.BtmenuPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmenuPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmenuPrincipal.Location = new System.Drawing.Point(310, 270);
            this.BtmenuPrincipal.Name = "BtmenuPrincipal";
            this.BtmenuPrincipal.Size = new System.Drawing.Size(181, 28);
            this.BtmenuPrincipal.TabIndex = 6;
            this.BtmenuPrincipal.Text = "Menú Principal";
            this.BtmenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // BtmostrarArticles
            // 
            this.BtmostrarArticles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmostrarArticles.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmostrarArticles.Location = new System.Drawing.Point(310, 210);
            this.BtmostrarArticles.Name = "BtmostrarArticles";
            this.BtmostrarArticles.Size = new System.Drawing.Size(181, 29);
            this.BtmostrarArticles.TabIndex = 5;
            this.BtmostrarArticles.Text = "Mostrar Articles";
            this.BtmostrarArticles.UseVisualStyleBackColor = false;
            // 
            // BtafegirArticles
            // 
            this.BtafegirArticles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtafegirArticles.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtafegirArticles.Location = new System.Drawing.Point(310, 153);
            this.BtafegirArticles.Name = "BtafegirArticles";
            this.BtafegirArticles.Size = new System.Drawing.Size(181, 26);
            this.BtafegirArticles.TabIndex = 4;
            this.BtafegirArticles.Text = "Afegir Articles";
            this.BtafegirArticles.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestió d\'Articles";
            // 
            // ArticleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtmenuPrincipal);
            this.Controls.Add(this.BtmostrarArticles);
            this.Controls.Add(this.BtafegirArticles);
            this.Controls.Add(this.LbOnlineStore);
            this.Name = "ArticleView";
            this.Text = "ArticleView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button BtmenuPrincipal;
        private System.Windows.Forms.Button BtmostrarArticles;
        private System.Windows.Forms.Button BtafegirArticles;
        private System.Windows.Forms.Label label1;
    }
}