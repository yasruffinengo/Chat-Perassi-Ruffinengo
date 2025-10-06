using System;
using System.Windows.Forms;


namespace Cliente
{
    partial class ClienteChatForm : Form
    {
        public ClienteChatForm()
        {
            InitializeComponent();
        }


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
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entradaTextbox
            // 
            this.entradaTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaTextbox.Location = new System.Drawing.Point(96, 292);
            this.entradaTextbox.Multiline = true;
            this.entradaTextbox.Name = "entradaTextbox";
            this.entradaTextbox.Size = new System.Drawing.Size(667, 39);
            this.entradaTextbox.TabIndex = 2;
            this.entradaTextbox.TextChanged += new System.EventHandler(this.entradaTextbox_TextChanged);
            this.entradaTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaTextBox_KeyDown);
            // 
            // mostrarTextbox
            // 
            this.mostrarTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarTextbox.Location = new System.Drawing.Point(96, 34);
            this.mostrarTextbox.Multiline = true;
            this.mostrarTextbox.Name = "mostrarTextbox";
            this.mostrarTextbox.Size = new System.Drawing.Size(667, 252);
            this.mostrarTextbox.TabIndex = 3;
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(96, 381);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(141, 23);
            this.IPtextbox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(637, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClienteChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.tulip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entradaTextbox);
            this.Controls.Add(this.mostrarTextbox);
            this.Name = "ClienteChatForm";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ClienteChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox mostrarTextbox;
        private TextBox IPtextbox;
        private Button button1;
    }
}
