namespace WindowsFormsBoats
{
    partial class FormPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPort));
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.buttonPortSail = new System.Windows.Forms.Button();
            this.buttonPortBoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeBoat = new System.Windows.Forms.PictureBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPort.BackgroundImage")));
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(800, 465);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // buttonPortSail
            // 
            this.buttonPortSail.Location = new System.Drawing.Point(806, 3);
            this.buttonPortSail.Name = "buttonPortSail";
            this.buttonPortSail.Size = new System.Drawing.Size(150, 23);
            this.buttonPortSail.TabIndex = 1;
            this.buttonPortSail.Text = "Пришвартовать лодку";
            this.buttonPortSail.UseVisualStyleBackColor = true;
            this.buttonPortSail.Click += new System.EventHandler(this.buttonPortSail_Click);
            // 
            // buttonPortBoat
            // 
            this.buttonPortBoat.Location = new System.Drawing.Point(806, 32);
            this.buttonPortBoat.Name = "buttonPortBoat";
            this.buttonPortBoat.Size = new System.Drawing.Size(150, 23);
            this.buttonPortBoat.TabIndex = 2;
            this.buttonPortBoat.Text = "Пришвартовать парусник";
            this.buttonPortBoat.UseVisualStyleBackColor = true;
            this.buttonPortBoat.Click += new System.EventHandler(this.buttonPortBoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeBoat);
            this.groupBox1.Controls.Add(this.buttonTake);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(806, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxTakeBoat
            // 
            this.pictureBoxTakeBoat.Location = new System.Drawing.Point(9, 92);
            this.pictureBoxTakeBoat.Name = "pictureBoxTakeBoat";
            this.pictureBoxTakeBoat.Size = new System.Drawing.Size(134, 71);
            this.pictureBoxTakeBoat.TabIndex = 4;
            this.pictureBoxTakeBoat.TabStop = false;
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(35, 58);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 39);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(24, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать лодку";
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPortBoat);
            this.Controls.Add(this.buttonPortSail);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "Гавань";
            this.Load += new System.EventHandler(this.FormPort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonPortSail;
        private System.Windows.Forms.Button buttonPortBoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTakeBoat;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}