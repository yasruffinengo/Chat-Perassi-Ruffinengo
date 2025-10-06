
namespace Chat_Perassi_Ruffinengo
{
    partial class ServidorChatForm
    {
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
            this.button1 = new System.Windows.Forms.Button();
            this.mostrarTextbox = new System.Windows.Forms.TextBox();
            this.entradaTextbox = new System.Windows.Forms.TextBox();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(599, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Obtener Ip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mostrarTextbox
            // 
            this.mostrarTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarTextbox.Location = new System.Drawing.Point(58, 38);
            this.mostrarTextbox.Multiline = true;
            this.mostrarTextbox.Name = "mostrarTextbox";
            this.mostrarTextbox.Size = new System.Drawing.Size(667, 252);
            this.mostrarTextbox.TabIndex = 6;
            // 
            // entradaTextbox
            // 
            this.entradaTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaTextbox.Location = new System.Drawing.Point(58, 306);
            this.entradaTextbox.Multiline = true;
            this.entradaTextbox.Name = "entradaTextbox";
            this.entradaTextbox.Size = new System.Drawing.Size(667, 39);
            this.entradaTextbox.TabIndex = 7;
            this.entradaTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaTextBox_KeyDown);
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(58, 380);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(141, 23);
            this.IPtextbox.TabIndex = 9;
            // 
            // ServidorChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat_Perassi_Ruffinengo.Properties.Resources.flll;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.entradaTextbox);
            this.Controls.Add(this.mostrarTextbox);
            this.Controls.Add(this.button1);
            this.Name = "ServidorChatForm";
            this.Text = "Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServidorChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ServidorChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mostrarTextbox;
        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox IPtextbox;
    }
}

