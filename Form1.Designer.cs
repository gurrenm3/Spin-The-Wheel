namespace Spin_The_Wheel
{
    partial class Main
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
            this.Title_Label = new System.Windows.Forms.Label();
            this.Spin_Button = new System.Windows.Forms.Button();
            this.Wheel_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(31, 24);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(524, 48);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Spin the prize wheel!";
            // 
            // Spin_Button
            // 
            this.Spin_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_Button.Location = new System.Drawing.Point(181, 566);
            this.Spin_Button.Name = "Spin_Button";
            this.Spin_Button.Size = new System.Drawing.Size(221, 47);
            this.Spin_Button.TabIndex = 1;
            this.Spin_Button.Text = "Spin the wheel";
            this.Spin_Button.UseVisualStyleBackColor = true;
            this.Spin_Button.Click += new System.EventHandler(this.Spin_Button_Click);
            // 
            // Wheel_PictureBox
            // 
            this.Wheel_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wheel_PictureBox.BackgroundImage = global::Spin_The_Wheel.Properties.Resources.No_Slots_active;
            this.Wheel_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wheel_PictureBox.Location = new System.Drawing.Point(49, 91);
            this.Wheel_PictureBox.Name = "Wheel_PictureBox";
            this.Wheel_PictureBox.Size = new System.Drawing.Size(486, 469);
            this.Wheel_PictureBox.TabIndex = 2;
            this.Wheel_PictureBox.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 625);
            this.Controls.Add(this.Wheel_PictureBox);
            this.Controls.Add(this.Spin_Button);
            this.Controls.Add(this.Title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Spin The Wheel!";
            ((System.ComponentModel.ISupportInitialize)(this.Wheel_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Button Spin_Button;
        private System.Windows.Forms.PictureBox Wheel_PictureBox;
    }
}

