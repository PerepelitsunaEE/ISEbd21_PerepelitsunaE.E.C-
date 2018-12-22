namespace WindowsFormsBoats
{
    partial class FormBoat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
            this.pictureBoxBoats = new System.Windows.Forms.PictureBox();
            this.buttonCreat = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreatSail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoats)).BeginInit();
            this.SuspendLayout();
            //
            // pictureBoxBoats
            //
            this.pictureBoxBoats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBoats.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBoats.Name = "pictureBoxBoats";
            this.pictureBoxBoats.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxBoats.TabIndex = 0;
            this.pictureBoxBoats.TabStop = false;
            this.pictureBoxBoats.Click += new System.EventHandler(this.pictureBoxBoats_Click);
            //
            // buttonCreat
            //
            this.buttonCreat.Location = new System.Drawing.Point(12, 12);
            this.buttonCreat.Name = "buttonCreat";
            this.buttonCreat.Size = new System.Drawing.Size(129, 23);
            this.buttonCreat.TabIndex = 1;
            this.buttonCreat.Text = "Создать парусник";
            this.buttonCreat.UseVisualStyleBackColor = true;
            this.buttonCreat.Click += new System.EventHandler(this.buttonCreate_Click);
            //
            // buttonLeft
            //
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.Location = new System.Drawing.Point(782, 431);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            //
            // buttonDown
            //
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.Location = new System.Drawing.Point(818, 431);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            //
            // buttonUp
            //
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.Location = new System.Drawing.Point(818, 395);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            //
            // buttonRight
            //
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.Location = new System.Drawing.Point(854, 431);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            //
            // buttonCreatSail
            //
            this.buttonCreatSail.Location = new System.Drawing.Point(12, 41);
            this.buttonCreatSail.Name = "buttonCreatSail";
            this.buttonCreatSail.Size = new System.Drawing.Size(129, 24);
            this.buttonCreatSail.TabIndex = 6;
            this.buttonCreatSail.Text = "Создать лодку";
            this.buttonCreatSail.UseVisualStyleBackColor = true;
            this.buttonCreatSail.Click += new System.EventHandler(this.buttonCreateSail_Click);
            //
            // FormBoat
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreatSail);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreat);
            this.Controls.Add(this.pictureBoxBoats);
            this.Name = "FormBoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парусник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBoats;
        private System.Windows.Forms.Button buttonCreat;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreatSail;
    }
}
