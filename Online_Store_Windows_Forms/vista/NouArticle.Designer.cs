namespace Online_Store_Windows_Forms.vista
{
    partial class NouArticle
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
            this.btTancar = new System.Windows.Forms.Button();
            this.lbNouArt = new System.Windows.Forms.Label();
            this.lbCodi = new System.Windows.Forms.Label();
            this.lbPreu = new System.Windows.Forms.Label();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.btEsborrar = new System.Windows.Forms.Button();
            this.btAcceptar = new System.Windows.Forms.Button();
            this.txCodi = new System.Windows.Forms.TextBox();
            this.txPreu = new System.Windows.Forms.TextBox();
            this.txDescrip = new System.Windows.Forms.TextBox();
            this.lbCampOblig = new System.Windows.Forms.Label();
            this.lbCampOblig2 = new System.Windows.Forms.Label();
            this.lbCampOblig3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(82, 22);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(125, 26);
            this.LbOnlineStore.TabIndex = 5;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Location = new System.Drawing.Point(536, 337);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(81, 33);
            this.btTancar.TabIndex = 4;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // lbNouArt
            // 
            this.lbNouArt.AutoSize = true;
            this.lbNouArt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNouArt.Location = new System.Drawing.Point(83, 73);
            this.lbNouArt.Name = "lbNouArt";
            this.lbNouArt.Size = new System.Drawing.Size(103, 22);
            this.lbNouArt.TabIndex = 6;
            this.lbNouArt.Text = "Nou Article";
            // 
            // lbCodi
            // 
            this.lbCodi.AutoSize = true;
            this.lbCodi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodi.Location = new System.Drawing.Point(146, 175);
            this.lbCodi.Name = "lbCodi";
            this.lbCodi.Size = new System.Drawing.Size(45, 21);
            this.lbCodi.TabIndex = 7;
            this.lbCodi.Text = "Codi";
            // 
            // lbPreu
            // 
            this.lbPreu.AutoSize = true;
            this.lbPreu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreu.Location = new System.Drawing.Point(146, 224);
            this.lbPreu.Name = "lbPreu";
            this.lbPreu.Size = new System.Drawing.Size(45, 21);
            this.lbPreu.TabIndex = 10;
            this.lbPreu.Text = "Preu";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.Location = new System.Drawing.Point(146, 271);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(88, 21);
            this.lbDescrip.TabIndex = 11;
            this.lbDescrip.Text = "Descripció";
            // 
            // btEsborrar
            // 
            this.btEsborrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEsborrar.Location = new System.Drawing.Point(405, 337);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(81, 33);
            this.btEsborrar.TabIndex = 12;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = false;
            this.btEsborrar.Click += new System.EventHandler(this.btEsborrar_Click);
            // 
            // btAcceptar
            // 
            this.btAcceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAcceptar.Location = new System.Drawing.Point(269, 337);
            this.btAcceptar.Name = "btAcceptar";
            this.btAcceptar.Size = new System.Drawing.Size(81, 33);
            this.btAcceptar.TabIndex = 13;
            this.btAcceptar.Text = "Afegir";
            this.btAcceptar.UseVisualStyleBackColor = false;
            this.btAcceptar.Click += new System.EventHandler(this.btAcceptar_Click);
            // 
            // txCodi
            // 
            this.txCodi.Location = new System.Drawing.Point(269, 178);
            this.txCodi.Name = "txCodi";
            this.txCodi.Size = new System.Drawing.Size(348, 20);
            this.txCodi.TabIndex = 14;
            this.txCodi.TextChanged += new System.EventHandler(this.txCodi_TextChanged);
            // 
            // txPreu
            // 
            this.txPreu.Location = new System.Drawing.Point(269, 224);
            this.txPreu.Name = "txPreu";
            this.txPreu.Size = new System.Drawing.Size(348, 20);
            this.txPreu.TabIndex = 15;
            this.txPreu.TextChanged += new System.EventHandler(this.txPreu_TextChanged);
            // 
            // txDescrip
            // 
            this.txDescrip.Location = new System.Drawing.Point(269, 272);
            this.txDescrip.Name = "txDescrip";
            this.txDescrip.Size = new System.Drawing.Size(348, 20);
            this.txDescrip.TabIndex = 16;
            this.txDescrip.TextChanged += new System.EventHandler(this.txDescrip_TextChanged);
            // 
            // lbCampOblig
            // 
            this.lbCampOblig.AutoSize = true;
            this.lbCampOblig.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig.Location = new System.Drawing.Point(632, 182);
            this.lbCampOblig.Name = "lbCampOblig";
            this.lbCampOblig.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig.TabIndex = 17;
            this.lbCampOblig.Text = "Camp Obligatori";
            this.lbCampOblig.Visible = false;
            // 
            // lbCampOblig2
            // 
            this.lbCampOblig2.AutoSize = true;
            this.lbCampOblig2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig2.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig2.Location = new System.Drawing.Point(632, 228);
            this.lbCampOblig2.Name = "lbCampOblig2";
            this.lbCampOblig2.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig2.TabIndex = 18;
            this.lbCampOblig2.Text = "Camp Obligatori";
            this.lbCampOblig2.Visible = false;
            // 
            // lbCampOblig3
            // 
            this.lbCampOblig3.AutoSize = true;
            this.lbCampOblig3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig3.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig3.Location = new System.Drawing.Point(632, 276);
            this.lbCampOblig3.Name = "lbCampOblig3";
            this.lbCampOblig3.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig3.TabIndex = 19;
            this.lbCampOblig3.Text = "Camp Obligatori";
            this.lbCampOblig3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(87, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // NouArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCampOblig3);
            this.Controls.Add(this.lbCampOblig2);
            this.Controls.Add(this.lbCampOblig);
            this.Controls.Add(this.txDescrip);
            this.Controls.Add(this.txPreu);
            this.Controls.Add(this.txCodi);
            this.Controls.Add(this.btAcceptar);
            this.Controls.Add(this.btEsborrar);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.lbPreu);
            this.Controls.Add(this.lbCodi);
            this.Controls.Add(this.lbNouArt);
            this.Controls.Add(this.LbOnlineStore);
            this.Controls.Add(this.btTancar);
            this.Name = "NouArticle";
            this.Text = "NouArticle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.Label lbNouArt;
        private System.Windows.Forms.Label lbCodi;
        private System.Windows.Forms.Label lbPreu;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.Button btEsborrar;
        private System.Windows.Forms.Button btAcceptar;
        private System.Windows.Forms.TextBox txCodi;
        private System.Windows.Forms.TextBox txPreu;
        private System.Windows.Forms.TextBox txDescrip;
        private System.Windows.Forms.Label lbCampOblig;
        private System.Windows.Forms.Label lbCampOblig2;
        private System.Windows.Forms.Label lbCampOblig3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}