namespace Minecraft
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(291, 138);
            button1.Name = "button1";
            button1.Size = new Size(219, 67);
            button1.TabIndex = 0;
            button1.Text = "PLAY";
            toolTip1.SetToolTip(button1, "Play Minecraft");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(228, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 81);
            label1.TabIndex = 1;
            label1.Text = "MINECRAFT";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(291, 242);
            button2.Name = "button2";
            button2.Size = new Size(219, 69);
            button2.TabIndex = 2;
            button2.Text = "SHOP";
            toolTip1.SetToolTip(button2, "Marketplace");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(291, 348);
            button3.Name = "button3";
            button3.Size = new Size(219, 65);
            button3.TabIndex = 3;
            button3.Text = "REALMNS";
            toolTip1.SetToolTip(button3, "Join Realmns");
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(326, 90);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "DOTNET EDITION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 443);
            label3.Name = "label3";
            label3.Size = new Size(263, 20);
            label3.TabIndex = 5;
            label3.Text = "@Sam ALL COPY RIGHTS RESERVED";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 483);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Minecraft DotNet Edition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
    }
}
