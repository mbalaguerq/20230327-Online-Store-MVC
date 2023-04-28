namespace Online_Store_Windows_Forms.vista
{
    partial class EliminarComanda
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
            this.listBoxResultats = new System.Windows.Forms.ListBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtNifoComanda = new System.Windows.Forms.TextBox();
            this.lblNifClient = new System.Windows.Forms.Label();
            this.btAcceptar = new System.Windows.Forms.Button();
            this.btEsborrar = new System.Windows.Forms.Button();
            this.lblNumComanda = new System.Windows.Forms.Label();
            this.btTancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.rBComanda = new System.Windows.Forms.RadioButton();
            this.rBNifClient = new System.Windows.Forms.RadioButton();
            this.lblBuscarPer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxResultats
            // 
            this.listBoxResultats.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultats.FormattingEnabled = true;
            this.listBoxResultats.ItemHeight = 16;
            this.listBoxResultats.Location = new System.Drawing.Point(252, 198);
            this.listBoxResultats.Name = "listBoxResultats";
            this.listBoxResultats.Size = new System.Drawing.Size(426, 164);
            this.listBoxResultats.TabIndex = 83;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.Location = new System.Drawing.Point(521, 149);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(81, 21);
            this.btBuscar.TabIndex = 82;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtNifoComanda
            // 
            this.txtNifoComanda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNifoComanda.Location = new System.Drawing.Point(395, 149);
            this.txtNifoComanda.Name = "txtNifoComanda";
            this.txtNifoComanda.Size = new System.Drawing.Size(103, 25);
            this.txtNifoComanda.TabIndex = 80;
            // 
            // lblNifClient
            // 
            this.lblNifClient.AutoSize = true;
            this.lblNifClient.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNifClient.Location = new System.Drawing.Point(251, 147);
            this.lblNifClient.Name = "lblNifClient";
            this.lblNifClient.Size = new System.Drawing.Size(82, 21);
            this.lblNifClient.TabIndex = 76;
            this.lblNifClient.Text = "Nif Client";
            // 
            // btAcceptar
            // 
            this.btAcceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAcceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcceptar.Location = new System.Drawing.Point(252, 389);
            this.btAcceptar.Name = "btAcceptar";
            this.btAcceptar.Size = new System.Drawing.Size(81, 33);
            this.btAcceptar.TabIndex = 71;
            this.btAcceptar.Text = "Acceptar";
            this.btAcceptar.UseVisualStyleBackColor = false;
            // 
            // btEsborrar
            // 
            this.btEsborrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEsborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEsborrar.Location = new System.Drawing.Point(417, 389);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(81, 33);
            this.btEsborrar.TabIndex = 70;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = false;
            this.btEsborrar.Click += new System.EventHandler(this.btEsborrar_Click);
            // 
            // lblNumComanda
            // 
            this.lblNumComanda.AutoSize = true;
            this.lblNumComanda.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumComanda.Location = new System.Drawing.Point(248, 147);
            this.lblNumComanda.Name = "lblNumComanda";
            this.lblNumComanda.Size = new System.Drawing.Size(131, 21);
            this.lblNumComanda.TabIndex = 67;
            this.lblNumComanda.Text = "Num. Comanda";
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Location = new System.Drawing.Point(588, 389);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(81, 33);
            this.btTancar.TabIndex = 66;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 65;
            this.label1.Text = "Eliminar Comanda";
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(82, 24);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 64;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // rBComanda
            // 
            this.rBComanda.AutoSize = true;
            this.rBComanda.Location = new System.Drawing.Point(395, 109);
            this.rBComanda.Name = "rBComanda";
            this.rBComanda.Size = new System.Drawing.Size(82, 17);
            this.rBComanda.TabIndex = 84;
            this.rBComanda.TabStop = true;
            this.rBComanda.Text = "NºComanda";
            this.rBComanda.UseVisualStyleBackColor = true;
            this.rBComanda.CheckedChanged += new System.EventHandler(this.rBComanda_CheckedChanged);
            // 
            // rBNifClient
            // 
            this.rBNifClient.AutoSize = true;
            this.rBNifClient.Location = new System.Drawing.Point(521, 109);
            this.rBNifClient.Name = "rBNifClient";
            this.rBNifClient.Size = new System.Drawing.Size(67, 17);
            this.rBNifClient.TabIndex = 85;
            this.rBNifClient.TabStop = true;
            this.rBNifClient.Text = "Nif Client";
            this.rBNifClient.UseVisualStyleBackColor = true;
            this.rBNifClient.CheckedChanged += new System.EventHandler(this.rBNifClient_CheckedChanged);
            // 
            // lblBuscarPer
            // 
            this.lblBuscarPer.AutoSize = true;
            this.lblBuscarPer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPer.Location = new System.Drawing.Point(248, 109);
            this.lblBuscarPer.Name = "lblBuscarPer";
            this.lblBuscarPer.Size = new System.Drawing.Size(90, 21);
            this.lblBuscarPer.TabIndex = 86;
            this.lblBuscarPer.Text = "Buscar per";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(86, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBuscarPer);
            this.Controls.Add(this.rBNifClient);
            this.Controls.Add(this.rBComanda);
            this.Controls.Add(this.listBoxResultats);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtNifoComanda);
            this.Controls.Add(this.lblNifClient);
            this.Controls.Add(this.btAcceptar);
            this.Controls.Add(this.btEsborrar);
            this.Controls.Add(this.lblNumComanda);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbOnlineStore);
            this.Name = "EliminarComanda";
            this.Text = "EliminarComanda";
            this.Load += new System.EventHandler(this.EliminarComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxResultats;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtNifoComanda;
        private System.Windows.Forms.Label lblNifClient;
        private System.Windows.Forms.Button btAcceptar;
        private System.Windows.Forms.Button btEsborrar;
        private System.Windows.Forms.Label lblNumComanda;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.RadioButton rBComanda;
        private System.Windows.Forms.RadioButton rBNifClient;
        private System.Windows.Forms.Label lblBuscarPer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}