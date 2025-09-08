
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
            this.mostrarTextbox = new System.Windows.Forms.TextBox();
            this.entradaTextbox = new System.Windows.Forms.TextBox();
            this.button1_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mostrarTextbox
            // 
            this.mostrarTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mostrarTextbox.Location = new System.Drawing.Point(58, 41);
            this.mostrarTextbox.Multiline = true;
            this.mostrarTextbox.Name = "mostrarTextbox";
            this.mostrarTextbox.Size = new System.Drawing.Size(252, 91);
            this.mostrarTextbox.TabIndex = 1;
            // 
            // entradaTextbox
            // 
            this.entradaTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaTextbox.Location = new System.Drawing.Point(58, 174);
            this.entradaTextbox.Multiline = true;
            this.entradaTextbox.Name = "entradaTextbox";
            this.entradaTextbox.Size = new System.Drawing.Size(252, 111);
            this.entradaTextbox.TabIndex = 0;
            this.entradaTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entradaTextBox_KeyDown);
            // 
            // button1_Click
            // 
            this.button1_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_Click.Location = new System.Drawing.Point(447, 52);
            this.button1_Click.Name = "button1_Click";
            this.button1_Click.Size = new System.Drawing.Size(75, 23);
            this.button1_Click.TabIndex = 2;
            this.button1_Click.Text = "button1";
            this.button1_Click.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(447, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Obtener Ip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(288, 367);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(141, 23);
            this.IPtextbox.TabIndex = 6;
            // 
            // ServidorChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1_Click);
            this.Controls.Add(this.entradaTextbox);
            this.Controls.Add(this.mostrarTextbox);
            this.Name = "ServidorChatForm";
            this.Text = "Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServidorChatForm_FormClosing);
            this.Load += new System.EventHandler(this.ServidorChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mostrarTextbox;
        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.Button button1_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IPtextbox;
    }
}

