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
            entradaTextbox = new TextBox();
            IPtextbox = new TextBox();
            button1 = new Button();
            mostrarTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // entradaTextbox
            // 
            entradaTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            entradaTextbox.Location = new System.Drawing.Point(47, 452);
            entradaTextbox.Margin = new Padding(3, 4, 3, 4);
            entradaTextbox.Name = "entradaTextbox";
            entradaTextbox.Size = new System.Drawing.Size(825, 27);
            entradaTextbox.TabIndex = 2;
            entradaTextbox.TextChanged += entradaTextbox_TextChanged;
            entradaTextbox.KeyDown += entradaTextBox_KeyDown;
            // 
            // IPtextbox
            // 
            IPtextbox.Location = new System.Drawing.Point(34, 532);
            IPtextbox.Margin = new Padding(3, 4, 3, 4);
            IPtextbox.Name = "IPtextbox";
            IPtextbox.Size = new System.Drawing.Size(161, 27);
            IPtextbox.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.LavenderBlush;
            button1.Cursor = Cursors.PanNW;
            button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            button1.ForeColor = System.Drawing.Color.HotPink;
            button1.Location = new System.Drawing.Point(241, 508);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(144, 71);
            button1.TabIndex = 7;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // mostrarTextbox
            // 
            mostrarTextbox.Location = new System.Drawing.Point(47, 31);
            mostrarTextbox.Name = "mostrarTextbox";
            mostrarTextbox.Size = new System.Drawing.Size(825, 389);
            mostrarTextbox.TabIndex = 9;
            mostrarTextbox.Text = "";
            // 
            // ClienteChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tulip;
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(mostrarTextbox);
            Controls.Add(IPtextbox);
            Controls.Add(button1);
            Controls.Add(entradaTextbox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteChatForm";
            Text = "Cliente";
            FormClosing += ClienteChatForm_FormClosing;
            Load += ClienteChatForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradaTextbox;
        private TextBox IPtextbox;
        private Button button1;
        private RichTextBox mostrarTextbox;
    }
}
