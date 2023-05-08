namespace Online_Store_Windows_Forms.vista
{
    partial class ComandaView
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
            this.BtmenuPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BteliminarComanda = new System.Windows.Forms.Button();
            this.BtafegirComanda = new System.Windows.Forms.Button();
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtmenuPrincipal
            // 
            this.BtmenuPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmenuPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmenuPrincipal.Location = new System.Drawing.Point(286, 238);
            this.BtmenuPrincipal.Name = "BtmenuPrincipal";
            this.BtmenuPrincipal.Size = new System.Drawing.Size(247, 28);
            this.BtmenuPrincipal.TabIndex = 21;
            this.BtmenuPrincipal.Text = "Menú Principal";
            this.BtmenuPrincipal.UseVisualStyleBackColor = false;
            this.BtmenuPrincipal.Click += new System.EventHandler(this.BtmenuPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gestió de Comandes";
            // 
            // BteliminarComanda
            // 
            this.BteliminarComanda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BteliminarComanda.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BteliminarComanda.Location = new System.Drawing.Point(286, 182);
            this.BteliminarComanda.Name = "BteliminarComanda";
            this.BteliminarComanda.Size = new System.Drawing.Size(247, 29);
            this.BteliminarComanda.TabIndex = 17;
            this.BteliminarComanda.Text = "Eliminar Comanda";
            this.BteliminarComanda.UseVisualStyleBackColor = false;
            this.BteliminarComanda.Click += new System.EventHandler(this.BteliminarComanda_Click);
            // 
            // BtafegirComanda
            // 
            this.BtafegirComanda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtafegirComanda.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtafegirComanda.Location = new System.Drawing.Point(286, 125);
            this.BtafegirComanda.Name = "BtafegirComanda";
            this.BtafegirComanda.Size = new System.Drawing.Size(247, 26);
            this.BtafegirComanda.TabIndex = 16;
            this.BtafegirComanda.Text = "Afegir Comandes";
            this.BtafegirComanda.UseVisualStyleBackColor = false;
            this.BtafegirComanda.Click += new System.EventHandler(this.BtafegirComanda_Click);
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(84, 23);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 15;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(88, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // ComandaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtmenuPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BteliminarComanda);
            this.Controls.Add(this.BtafegirComanda);
            this.Controls.Add(this.LbOnlineStore);
            this.Name = "ComandaView";
            this.Text = "ComandaView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtmenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BteliminarComanda;
        private System.Windows.Forms.Button BtafegirComanda;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}