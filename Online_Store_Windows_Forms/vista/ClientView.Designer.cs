namespace Online_Store_Windows_Forms.vista
{
    partial class ClientView
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtmostrarCliStandard = new System.Windows.Forms.Button();
            this.BtmostrarClients = new System.Windows.Forms.Button();
            this.BtafegirClients = new System.Windows.Forms.Button();
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.BtmostrarCliVip = new System.Windows.Forms.Button();
            this.BtmenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestió de Clients";
            // 
            // BtmostrarCliStandard
            // 
            this.BtmostrarCliStandard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmostrarCliStandard.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmostrarCliStandard.Location = new System.Drawing.Point(285, 228);
            this.BtmostrarCliStandard.Name = "BtmostrarCliStandard";
            this.BtmostrarCliStandard.Size = new System.Drawing.Size(232, 28);
            this.BtmostrarCliStandard.TabIndex = 11;
            this.BtmostrarCliStandard.Text = "Mostrar Clients Standard";
            this.BtmostrarCliStandard.UseVisualStyleBackColor = false;
            this.BtmostrarCliStandard.Click += new System.EventHandler(this.BtmostrarCliStandard_Click);
            // 
            // BtmostrarClients
            // 
            this.BtmostrarClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmostrarClients.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmostrarClients.Location = new System.Drawing.Point(285, 169);
            this.BtmostrarClients.Name = "BtmostrarClients";
            this.BtmostrarClients.Size = new System.Drawing.Size(232, 29);
            this.BtmostrarClients.TabIndex = 10;
            this.BtmostrarClients.Text = "Mostrar Clients";
            this.BtmostrarClients.UseVisualStyleBackColor = false;
            this.BtmostrarClients.Click += new System.EventHandler(this.BtmostrarClients_Click);
            // 
            // BtafegirClients
            // 
            this.BtafegirClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtafegirClients.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtafegirClients.Location = new System.Drawing.Point(285, 112);
            this.BtafegirClients.Name = "BtafegirClients";
            this.BtafegirClients.Size = new System.Drawing.Size(232, 26);
            this.BtafegirClients.TabIndex = 9;
            this.BtafegirClients.Text = "Afegir Clients";
            this.BtafegirClients.UseVisualStyleBackColor = false;
            this.BtafegirClients.Click += new System.EventHandler(this.BtafegirClients_Click);
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(84, 23);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 8;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // BtmostrarCliVip
            // 
            this.BtmostrarCliVip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmostrarCliVip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmostrarCliVip.Location = new System.Drawing.Point(285, 279);
            this.BtmostrarCliVip.Name = "BtmostrarCliVip";
            this.BtmostrarCliVip.Size = new System.Drawing.Size(232, 28);
            this.BtmostrarCliVip.TabIndex = 13;
            this.BtmostrarCliVip.Text = "Mostrar Clients Vip";
            this.BtmostrarCliVip.UseVisualStyleBackColor = false;
            this.BtmostrarCliVip.Click += new System.EventHandler(this.BtmostrarCliVip_Click);
            // 
            // BtmenuPrincipal
            // 
            this.BtmenuPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtmenuPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmenuPrincipal.Location = new System.Drawing.Point(285, 332);
            this.BtmenuPrincipal.Name = "BtmenuPrincipal";
            this.BtmenuPrincipal.Size = new System.Drawing.Size(232, 28);
            this.BtmenuPrincipal.TabIndex = 14;
            this.BtmenuPrincipal.Text = "Menú Principal";
            this.BtmenuPrincipal.UseVisualStyleBackColor = false;
            this.BtmenuPrincipal.Click += new System.EventHandler(this.BtmenuPrincipal_Click);
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
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtmenuPrincipal);
            this.Controls.Add(this.BtmostrarCliVip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtmostrarCliStandard);
            this.Controls.Add(this.BtmostrarClients);
            this.Controls.Add(this.BtafegirClients);
            this.Controls.Add(this.LbOnlineStore);
            this.Name = "ClientView";
            this.Text = "ClientView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtmostrarCliStandard;
        private System.Windows.Forms.Button BtmostrarClients;
        private System.Windows.Forms.Button BtafegirClients;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button BtmostrarCliVip;
        private System.Windows.Forms.Button BtmenuPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}