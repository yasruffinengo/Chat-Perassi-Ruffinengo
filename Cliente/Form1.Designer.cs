using System;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Cliente
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NetworkStream salida; //flujo para recibir datos

        ////hasta aqui hoy es viernes 29/ñoquis

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entradaTextbox = new System.Windows.Forms.TextBox();
            this.mostrarTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entradaTextbox
            // 
            this.entradaTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaTextbox.Location = new System.Drawing.Point(96, 229);
            this.entradaTextbox.Multiline = true;
            this.entradaTextbox.Name = "entradaTextbox";
            this.entradaTextbox.Size = new System.Drawing.Size(252, 111);
            this.entradaTextbox.TabIndex = 2;
            // 
            // mostrarTextbox
            // 
            this.mostrarTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarTextbox.Location = new System.Drawing.Point(96, 96);
            this.mostrarTextbox.Multiline = true;
            this.mostrarTextbox.Name = "mostrarTextbox";
            this.mostrarTextbox.Size = new System.Drawing.Size(252, 91);
            this.mostrarTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entradaTextbox);
            this.Controls.Add(this.mostrarTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox mostrarTextbox;
    }
}
