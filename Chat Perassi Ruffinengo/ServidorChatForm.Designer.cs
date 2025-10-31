
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
            button1 = new System.Windows.Forms.Button();
            entradaTextbox = new System.Windows.Forms.TextBox();
            IPtextbox = new System.Windows.Forms.TextBox();
            mostrarTextbox = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LavenderBlush;
            button1.Cursor = System.Windows.Forms.Cursors.PanNW;
            button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.HotPink;
            button1.Location = new System.Drawing.Point(556, 489);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(144, 71);
            button1.TabIndex = 5;
            button1.Text = "Obtener Ip";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // entradaTextbox
            // 
            entradaTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            entradaTextbox.Location = new System.Drawing.Point(31, 450);
            entradaTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            entradaTextbox.Name = "entradaTextbox";
            entradaTextbox.Size = new System.Drawing.Size(849, 27);
            entradaTextbox.TabIndex = 7;
            entradaTextbox.TextChanged += entradaTextbox_TextChanged;
            entradaTextbox.KeyDown += entradaTextBox_KeyDown;
            // 
            // IPtextbox
            // 
            IPtextbox.Location = new System.Drawing.Point(728, 513);
            IPtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            IPtextbox.Name = "IPtextbox";
            IPtextbox.ReadOnly = true;
            IPtextbox.Size = new System.Drawing.Size(161, 27);
            IPtextbox.TabIndex = 9;
            // 
            // mostrarTextbox
            // 
            mostrarTextbox.Location = new System.Drawing.Point(31, 30);
            mostrarTextbox.Name = "mostrarTextbox";
            mostrarTextbox.Size = new System.Drawing.Size(849, 388);
            mostrarTextbox.TabIndex = 10;
            mostrarTextbox.Text = "";
            // 
            // ServidorChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flll;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(mostrarTextbox);
            Controls.Add(IPtextbox);
            Controls.Add(entradaTextbox);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ServidorChatForm";
            Text = "Servidor";
            FormClosing += ServidorChatForm_FormClosing;
            Load += ServidorChatForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.RichTextBox mostrarTextbox;
    }
}

