﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Store_Windows_Forms.controlador;


namespace Online_Store_Windows_Forms
{
    partial class MenuPrincipal : Form
    {        

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbOnlineStore = new System.Windows.Forms.Label();
            this.BtGArticles = new System.Windows.Forms.Button();
            this.BtGClients = new System.Windows.Forms.Button();
            this.BtGComandes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbOnlineStore
            // 
            this.LbOnlineStore.AutoSize = true;
            this.LbOnlineStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOnlineStore.Location = new System.Drawing.Point(84, 23);
            this.LbOnlineStore.Name = "LbOnlineStore";
            this.LbOnlineStore.Size = new System.Drawing.Size(104, 20);
            this.LbOnlineStore.TabIndex = 0;
            this.LbOnlineStore.Text = "OnlineStore";
            // 
            // BtGArticles
            // 
            this.BtGArticles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtGArticles.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGArticles.Location = new System.Drawing.Point(300, 173);
            this.BtGArticles.Name = "BtGArticles";
            this.BtGArticles.Size = new System.Drawing.Size(181, 26);
            this.BtGArticles.TabIndex = 1;
            this.BtGArticles.Text = "Gestió d\'Articles";
            this.BtGArticles.UseVisualStyleBackColor = false;
            this.BtGArticles.Click += new System.EventHandler(this.BtGArticles_Click);
            // 
            // BtGClients
            // 
            this.BtGClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtGClients.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGClients.Location = new System.Drawing.Point(300, 230);
            this.BtGClients.Name = "BtGClients";
            this.BtGClients.Size = new System.Drawing.Size(181, 29);
            this.BtGClients.TabIndex = 2;
            this.BtGClients.Text = "Gestió de Clients";
            this.BtGClients.UseVisualStyleBackColor = false;
            this.BtGClients.Click += new System.EventHandler(this.BtGClients_Click);
            // 
            // BtGComandes
            // 
            this.BtGComandes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtGComandes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGComandes.Location = new System.Drawing.Point(300, 290);
            this.BtGComandes.Name = "BtGComandes";
            this.BtGComandes.Size = new System.Drawing.Size(181, 28);
            this.BtGComandes.TabIndex = 3;
            this.BtGComandes.Text = "Gestió de Comandes";
            this.BtGComandes.UseVisualStyleBackColor = false;
            this.BtGComandes.Click += new System.EventHandler(this.BtGComandes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Online_Store_Windows_Forms.Properties.Resources.Captura_de_pantalla_2023_04_28_090306;
            this.pictureBox1.Location = new System.Drawing.Point(88, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtGComandes);
            this.Controls.Add(this.BtGClients);
            this.Controls.Add(this.BtGArticles);
            this.Controls.Add(this.LbOnlineStore);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbOnlineStore;
        private System.Windows.Forms.Button BtGArticles;
        private System.Windows.Forms.Button BtGClients;
        private System.Windows.Forms.Button BtGComandes;
        private PictureBox pictureBox1;
    }
}

