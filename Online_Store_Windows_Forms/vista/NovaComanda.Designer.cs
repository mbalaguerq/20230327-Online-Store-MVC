﻿namespace Online_Store_Windows_Forms.vista
{
    partial class NovaComanda
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
            this.lbCampOblig = new System.Windows.Forms.Label();
            this.txNifClient = new System.Windows.Forms.TextBox();
            this.lbVip = new System.Windows.Forms.Label();
            this.lBEmail = new System.Windows.Forms.Label();
            this.lbCampOblig2 = new System.Windows.Forms.Label();
            this.txunitats = new System.Windows.Forms.TextBox();
            this.txArticle = new System.Windows.Forms.TextBox();
            this.txNComanda = new System.Windows.Forms.TextBox();
            this.btAcceptar = new System.Windows.Forms.Button();
            this.btEsborrar = new System.Windows.Forms.Button();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbDomicili = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.btTancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.textdata = new System.Windows.Forms.TextBox();
            this.btBuscarArticle = new System.Windows.Forms.Button();
            this.btNifClient = new System.Windows.Forms.Button();
            this.lbMostraR = new System.Windows.Forms.ListBox();
            this.lbCampOblig3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCampOblig
            // 
            this.lbCampOblig.AutoSize = true;
            this.lbCampOblig.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig.Location = new System.Drawing.Point(807, 205);
            this.lbCampOblig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCampOblig.Name = "lbCampOblig";
            this.lbCampOblig.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig.TabIndex = 57;
            this.lbCampOblig.Text = "Camp Obligatori";
            this.lbCampOblig.Visible = false;
            // 
            // txNifClient
            // 
            this.txNifClient.Location = new System.Drawing.Point(412, 200);
            this.txNifClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNifClient.Name = "txNifClient";
            this.txNifClient.Size = new System.Drawing.Size(263, 22);
            this.txNifClient.TabIndex = 56;
            this.txNifClient.TextChanged += new System.EventHandler(this.txNifClient_TextChanged);
            // 
            // lbVip
            // 
            this.lbVip.AutoSize = true;
            this.lbVip.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVip.Location = new System.Drawing.Point(407, 75);
            this.lbVip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVip.Name = "lbVip";
            this.lbVip.Size = new System.Drawing.Size(46, 21);
            this.lbVip.TabIndex = 55;
            this.lbVip.Text = "Data";
            // 
            // lBEmail
            // 
            this.lBEmail.AutoSize = true;
            this.lBEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBEmail.Location = new System.Drawing.Point(309, 196);
            this.lBEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBEmail.Name = "lBEmail";
            this.lBEmail.Size = new System.Drawing.Size(82, 21);
            this.lBEmail.TabIndex = 54;
            this.lBEmail.Text = "Nif Client";
            // 
            // lbCampOblig2
            // 
            this.lbCampOblig2.AutoSize = true;
            this.lbCampOblig2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig2.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig2.Location = new System.Drawing.Point(693, 159);
            this.lbCampOblig2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCampOblig2.Name = "lbCampOblig2";
            this.lbCampOblig2.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig2.TabIndex = 53;
            this.lbCampOblig2.Text = "Camp Obligatori";
            this.lbCampOblig2.Visible = false;
            // 
            // txunitats
            // 
            this.txunitats.Location = new System.Drawing.Point(412, 153);
            this.txunitats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txunitats.Name = "txunitats";
            this.txunitats.Size = new System.Drawing.Size(263, 22);
            this.txunitats.TabIndex = 50;
            this.txunitats.TextChanged += new System.EventHandler(this.txunitats_TextChanged);
            // 
            // txArticle
            // 
            this.txArticle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txArticle.Location = new System.Drawing.Point(412, 108);
            this.txArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txArticle.Name = "txArticle";
            this.txArticle.Size = new System.Drawing.Size(263, 22);
            this.txArticle.TabIndex = 49;
            this.txArticle.TextChanged += new System.EventHandler(this.txArticle_TextChanged);
            // 
            // txNComanda
            // 
            this.txNComanda.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNComanda.Location = new System.Drawing.Point(581, 32);
            this.txNComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNComanda.Name = "txNComanda";
            this.txNComanda.Size = new System.Drawing.Size(94, 25);
            this.txNComanda.TabIndex = 48;
            // 
            // btAcceptar
            // 
            this.btAcceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAcceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcceptar.Location = new System.Drawing.Point(294, 481);
            this.btAcceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAcceptar.Name = "btAcceptar";
            this.btAcceptar.Size = new System.Drawing.Size(94, 40);
            this.btAcceptar.TabIndex = 47;
            this.btAcceptar.Text = "Acceptar";
            this.btAcceptar.UseVisualStyleBackColor = false;
            this.btAcceptar.Click += new System.EventHandler(this.btAcceptar_Click);
            // 
            // btEsborrar
            // 
            this.btEsborrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEsborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEsborrar.Location = new System.Drawing.Point(486, 481);
            this.btEsborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEsborrar.Name = "btEsborrar";
            this.btEsborrar.Size = new System.Drawing.Size(94, 40);
            this.btEsborrar.TabIndex = 46;
            this.btEsborrar.Text = "Esborrar";
            this.btEsborrar.UseVisualStyleBackColor = false;
            this.btEsborrar.Click += new System.EventHandler(this.btEsborrar_Click);
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.Location = new System.Drawing.Point(330, 152);
            this.lbNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(64, 21);
            this.lbNif.TabIndex = 45;
            this.lbNif.Text = "Unitats";
            // 
            // lbDomicili
            // 
            this.lbDomicili.AutoSize = true;
            this.lbDomicili.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDomicili.Location = new System.Drawing.Point(290, 109);
            this.lbDomicili.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDomicili.Name = "lbDomicili";
            this.lbDomicili.Size = new System.Drawing.Size(98, 21);
            this.lbDomicili.TabIndex = 44;
            this.lbDomicili.Text = "Codi Article";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(407, 37);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(131, 21);
            this.lbNom.TabIndex = 43;
            this.lbNom.Text = "Num. Comanda";
            // 
            // btTancar
            // 
            this.btTancar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTancar.Location = new System.Drawing.Point(686, 481);
            this.btTancar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTancar.Name = "btTancar";
            this.btTancar.Size = new System.Drawing.Size(94, 40);
            this.btTancar.TabIndex = 42;
            this.btTancar.Text = "Tancar";
            this.btTancar.UseVisualStyleBackColor = false;
            this.btTancar.Click += new System.EventHandler(this.btTancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nova Comanda";
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(96, 32);
            this.LbOnlineStore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 40;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // textdata
            // 
            this.textdata.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdata.Location = new System.Drawing.Point(581, 71);
            this.textdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textdata.Name = "textdata";
            this.textdata.Size = new System.Drawing.Size(94, 25);
            this.textdata.TabIndex = 59;
            // 
            // btBuscarArticle
            // 
            this.btBuscarArticle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btBuscarArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscarArticle.Location = new System.Drawing.Point(696, 109);
            this.btBuscarArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscarArticle.Name = "btBuscarArticle";
            this.btBuscarArticle.Size = new System.Drawing.Size(94, 25);
            this.btBuscarArticle.TabIndex = 60;
            this.btBuscarArticle.Text = "Buscar";
            this.btBuscarArticle.UseVisualStyleBackColor = false;
            this.btBuscarArticle.Click += new System.EventHandler(this.btBuscarArticle_Click);
            // 
            // btNifClient
            // 
            this.btNifClient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNifClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNifClient.Location = new System.Drawing.Point(696, 200);
            this.btNifClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNifClient.Name = "btNifClient";
            this.btNifClient.Size = new System.Drawing.Size(94, 25);
            this.btNifClient.TabIndex = 61;
            this.btNifClient.Text = "Buscar";
            this.btNifClient.UseVisualStyleBackColor = false;
            this.btNifClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMostraR
            // 
            this.lbMostraR.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostraR.FormattingEnabled = true;
            this.lbMostraR.ItemHeight = 14;
            this.lbMostraR.Location = new System.Drawing.Point(294, 281);
            this.lbMostraR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMostraR.Name = "lbMostraR";
            this.lbMostraR.Size = new System.Drawing.Size(496, 172);
            this.lbMostraR.TabIndex = 62;
            // 
            // lbCampOblig3
            // 
            this.lbCampOblig3.AutoSize = true;
            this.lbCampOblig3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampOblig3.ForeColor = System.Drawing.Color.Red;
            this.lbCampOblig3.Location = new System.Drawing.Point(807, 116);
            this.lbCampOblig3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCampOblig3.Name = "lbCampOblig3";
            this.lbCampOblig3.Size = new System.Drawing.Size(96, 16);
            this.lbCampOblig3.TabIndex = 63;
            this.lbCampOblig3.Text = "Camp Obligatori";
            this.lbCampOblig3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(100, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // selData
            // 
            this.selData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selData.Location = new System.Drawing.Point(470, 243);
            this.selData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selData.MinDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.selData.Name = "selData";
            this.selData.Size = new System.Drawing.Size(205, 22);
            this.selData.TabIndex = 90;
            this.selData.Value = new System.DateTime(2023, 5, 5, 20, 30, 57, 0);
            this.selData.ValueChanged += new System.EventHandler(this.selData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 91;
            this.label2.Text = "Data d\'enviament";
            // 
            // NovaComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCampOblig3);
            this.Controls.Add(this.lbMostraR);
            this.Controls.Add(this.btNifClient);
            this.Controls.Add(this.btBuscarArticle);
            this.Controls.Add(this.textdata);
            this.Controls.Add(this.lbCampOblig);
            this.Controls.Add(this.txNifClient);
            this.Controls.Add(this.lbVip);
            this.Controls.Add(this.lBEmail);
            this.Controls.Add(this.lbCampOblig2);
            this.Controls.Add(this.txunitats);
            this.Controls.Add(this.txArticle);
            this.Controls.Add(this.txNComanda);
            this.Controls.Add(this.btAcceptar);
            this.Controls.Add(this.btEsborrar);
            this.Controls.Add(this.lbNif);
            this.Controls.Add(this.lbDomicili);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btTancar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbOnlineStore);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NovaComanda";
            this.Text = "NovaComanda";
            this.Load += new System.EventHandler(this.NovaComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCampOblig;
        private System.Windows.Forms.TextBox txNifClient;
        private System.Windows.Forms.Label lbVip;
        private System.Windows.Forms.Label lBEmail;
        private System.Windows.Forms.Label lbCampOblig2;
        private System.Windows.Forms.TextBox txunitats;
        private System.Windows.Forms.TextBox txArticle;
        private System.Windows.Forms.TextBox txNComanda;
        private System.Windows.Forms.Button btAcceptar;
        private System.Windows.Forms.Button btEsborrar;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbDomicili;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Button btTancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.TextBox textdata;
        private System.Windows.Forms.Button btBuscarArticle;
        private System.Windows.Forms.Button btNifClient;
        private System.Windows.Forms.ListBox lbMostraR;
        private System.Windows.Forms.Label lbCampOblig3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker selData;
        private System.Windows.Forms.Label label2;
    }
}