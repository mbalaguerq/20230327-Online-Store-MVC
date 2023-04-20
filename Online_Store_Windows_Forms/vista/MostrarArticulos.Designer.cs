namespace Online_Store_Windows_Forms.vista
{
    partial class MostrarArticulos
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
            this.mostraArticles = new System.Windows.Forms.ListBox();
            this.btTancar = new System.Windows.Forms.Button();
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mostraArticles
            // 
            this.mostraArticles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mostraArticles.FormattingEnabled = true;
            this.mostraArticles.Location = new System.Drawing.Point(150, 115);
            this.mostraArticles.Name = "mostraArticles";
            this.mostraArticles.Size = new System.Drawing.Size(468, 186);
            this.mostraArticles.TabIndex = 0;
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Location = new System.Drawing.Point(325, 336);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(112, 33);
            this.btTancar.TabIndex = 1;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(83, 22);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 2;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // MostrarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbOnlineStore);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.mostraArticles);
            this.Name = "MostrarArticulos";
            this.Text = "MostrarArticulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mostraArticles;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.Label LbOnlineStore;
    }
}