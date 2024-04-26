namespace client_sideWF
{
    partial class SEND
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
            button1 = new Button();
            Textbox1 = new TextBox();
            select = new Label();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(275, 91);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Textbox1
            // 
            Textbox1.Location = new Point(35, 49);
            Textbox1.Name = "Textbox1";
            Textbox1.Size = new Size(334, 27);
            Textbox1.TabIndex = 4;
            // 
            // select
            // 
            select.AutoSize = true;
            select.BackColor = SystemColors.ButtonHighlight;
            select.Location = new Point(35, 25);
            select.Name = "select";
            select.Size = new Size(154, 20);
            select.TabIndex = 3;
            select.Text = "Select the Source File ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(177, 178);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 7;
            button2.Text = "SEND";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 225);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // SEND
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(Textbox1);
            Controls.Add(select);
            Controls.Add(button1);
            Name = "SEND";
            Text = "SEND";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Textbox1;
        private Label select;
        private Button button2;
        private Label label1;
    }
}
