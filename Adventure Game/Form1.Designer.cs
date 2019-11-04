namespace Adventure_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(274, 402);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "Pass";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(274, 366);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "Enter";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Freefrm721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Gold;
            this.outputLabel.Location = new System.Drawing.Point(65, 25);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(624, 105);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "you are going on a walk through a forest and you come across some old ruins.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 131);
            this.label1.TabIndex = 12;
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::Adventure_Game.Properties.Resources.Old_Ruins;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImage.Location = new System.Drawing.Point(176, 143);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(381, 208);
            this.sceneImage.TabIndex = 11;
            this.sceneImage.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueImage.BackgroundImage")));
            this.blueImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.blueImage.Location = new System.Drawing.Point(231, 392);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 7;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redImage.BackgroundImage")));
            this.redImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redImage.Location = new System.Drawing.Point(231, 356);
            this.redImage.Margin = new System.Windows.Forms.Padding(2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 6;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.Label label1;
    }
}

