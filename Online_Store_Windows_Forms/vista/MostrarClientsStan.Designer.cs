namespace Online_Store_Windows_Forms.vista
{
    partial class MostrarClientsStan
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
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.btTancar = new System.Windows.Forms.Button();
            this.tbMostrarClientsVip = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Llistat de Clients STANDARD";
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(85, 23);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 10;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Location = new System.Drawing.Point(327, 337);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(112, 33);
            this.btTancar.TabIndex = 9;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // tbMostrarClientsVip
            // 
            this.tbMostrarClientsVip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMostrarClientsVip.FormattingEnabled = true;
            this.tbMostrarClientsVip.Location = new System.Drawing.Point(89, 105);
            this.tbMostrarClientsVip.MultiColumn = true;
            this.tbMostrarClientsVip.Name = "tbMostrarClientsVip";
            this.tbMostrarClientsVip.Size = new System.Drawing.Size(576, 212);
            this.tbMostrarClientsVip.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(89, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarClientsStan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbOnlineStore);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.tbMostrarClientsVip);
            this.Name = "MostrarClientsStan";
            this.Text = "MostrarClientsStand";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.ListBox tbMostrarClientsVip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}