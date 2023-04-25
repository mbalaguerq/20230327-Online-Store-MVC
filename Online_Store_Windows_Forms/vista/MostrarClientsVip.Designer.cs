namespace Online_Store_Windows_Forms.vista
{
    partial class MostrarClientsVip
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Llistat de Clients STANDARD";
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(86, 24);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 14;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Location = new System.Drawing.Point(328, 338);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(112, 33);
            this.btTancar.TabIndex = 13;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // tbMostrarClientsVip
            // 
            this.tbMostrarClientsVip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMostrarClientsVip.FormattingEnabled = true;
            this.tbMostrarClientsVip.Location = new System.Drawing.Point(90, 106);
            this.tbMostrarClientsVip.MultiColumn = true;
            this.tbMostrarClientsVip.Name = "tbMostrarClientsVip";
            this.tbMostrarClientsVip.Size = new System.Drawing.Size(576, 212);
            this.tbMostrarClientsVip.TabIndex = 12;
            // 
            // MostrarClientsVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbOnlineStore);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.tbMostrarClientsVip);
            this.Name = "MostrarClientsVip";
            this.Text = "MostrarClientsVip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.ListBox tbMostrarClientsVip;
    }
}