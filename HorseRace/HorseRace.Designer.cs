namespace RandomLabelMove
{
    partial class game
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
            this.components = new System.ComponentModel.Container();
            this.Race_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.Housenumberupdown = new System.Windows.Forms.NumericUpDown();
            this.label_bike = new System.Windows.Forms.Label();
            this.betmoneyupdown = new System.Windows.Forms.NumericUpDown();
            this.bet_button = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.AmousLB = new System.Windows.Forms.Label();
            this.jhonLB = new System.Windows.Forms.Label();
            this.KateLB = new System.Windows.Forms.Label();
            this.labelbt = new System.Windows.Forms.Label();
            this.AmousRB = new System.Windows.Forms.RadioButton();
            this.jhonRb = new System.Windows.Forms.RadioButton();
            this.KateRB = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racePicture = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Housenumberupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betmoneyupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Race_Button
            // 
            this.Race_Button.BackColor = System.Drawing.Color.Moccasin;
            this.Race_Button.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race_Button.Location = new System.Drawing.Point(773, 485);
            this.Race_Button.Name = "Race_Button";
            this.Race_Button.Size = new System.Drawing.Size(172, 85);
            this.Race_Button.TabIndex = 3;
            this.Race_Button.Text = "Go";
            this.Race_Button.UseVisualStyleBackColor = false;
            this.Race_Button.Click += new System.EventHandler(this.Race_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Khaki;
            this.gb1.Controls.Add(this.Housenumberupdown);
            this.gb1.Controls.Add(this.label_bike);
            this.gb1.Controls.Add(this.betmoneyupdown);
            this.gb1.Controls.Add(this.bet_button);
            this.gb1.Controls.Add(this.labelName);
            this.gb1.Controls.Add(this.AmousLB);
            this.gb1.Controls.Add(this.jhonLB);
            this.gb1.Controls.Add(this.KateLB);
            this.gb1.Controls.Add(this.labelbt);
            this.gb1.Controls.Add(this.AmousRB);
            this.gb1.Controls.Add(this.jhonRb);
            this.gb1.Controls.Add(this.KateRB);
            this.gb1.Location = new System.Drawing.Point(12, 389);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(933, 187);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            this.gb1.Text = "Horse  Race Place Your bet here";
            // 
            // Housenumberupdown
            // 
            this.Housenumberupdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Housenumberupdown.Location = new System.Drawing.Point(453, 154);
            this.Housenumberupdown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Housenumberupdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Housenumberupdown.Name = "Housenumberupdown";
            this.Housenumberupdown.Size = new System.Drawing.Size(45, 22);
            this.Housenumberupdown.TabIndex = 16;
            this.Housenumberupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_bike
            // 
            this.label_bike.AutoSize = true;
            this.label_bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bike.Location = new System.Drawing.Point(272, 159);
            this.label_bike.Name = "label_bike";
            this.label_bike.Size = new System.Drawing.Size(155, 16);
            this.label_bike.TabIndex = 15;
            this.label_bike.Text = "dollars on horse  number";
            // 
            // betmoneyupdown
            // 
            this.betmoneyupdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betmoneyupdown.Location = new System.Drawing.Point(186, 153);
            this.betmoneyupdown.Name = "betmoneyupdown";
            this.betmoneyupdown.Size = new System.Drawing.Size(45, 22);
            this.betmoneyupdown.TabIndex = 14;
            this.betmoneyupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bet_button
            // 
            this.bet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_button.Location = new System.Drawing.Point(99, 153);
            this.bet_button.Name = "bet_button";
            this.bet_button.Size = new System.Drawing.Size(54, 23);
            this.bet_button.TabIndex = 13;
            this.bet_button.Text = "Bets";
            this.bet_button.UseVisualStyleBackColor = true;
            this.bet_button.Click += new System.EventHandler(this.Beter_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(27, 159);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 16);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "name";
            // 
            // AmousLB
            // 
            this.AmousLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmousLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmousLB.Location = new System.Drawing.Point(709, 24);
            this.AmousLB.Name = "AmousLB";
            this.AmousLB.Size = new System.Drawing.Size(201, 23);
            this.AmousLB.TabIndex = 11;
            this.AmousLB.Text = "AmousLabel";
            // 
            // jhonLB
            // 
            this.jhonLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jhonLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jhonLB.Location = new System.Drawing.Point(488, 26);
            this.jhonLB.Name = "jhonLB";
            this.jhonLB.Size = new System.Drawing.Size(201, 23);
            this.jhonLB.TabIndex = 10;
            this.jhonLB.Text = "JhonLabel";
            // 
            // KateLB
            // 
            this.KateLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KateLB.Location = new System.Drawing.Point(252, 26);
            this.KateLB.Name = "KateLB";
            this.KateLB.Size = new System.Drawing.Size(201, 25);
            this.KateLB.TabIndex = 9;
            this.KateLB.Text = "KateLabel";
            // 
            // labelbt
            // 
            this.labelbt.AutoSize = true;
            this.labelbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbt.Location = new System.Drawing.Point(184, 31);
            this.labelbt.Name = "labelbt";
            this.labelbt.Size = new System.Drawing.Size(39, 16);
            this.labelbt.TabIndex = 8;
            this.labelbt.Text = "Bets";
            // 
            // AmousRB
            // 
            this.AmousRB.AutoSize = true;
            this.AmousRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmousRB.Location = new System.Drawing.Point(15, 110);
            this.AmousRB.Name = "AmousRB";
            this.AmousRB.Size = new System.Drawing.Size(142, 20);
            this.AmousRB.TabIndex = 7;
            this.AmousRB.TabStop = true;
            this.AmousRB.Text = "AmousRadioButton";
            this.AmousRB.UseVisualStyleBackColor = true;
            this.AmousRB.CheckedChanged += new System.EventHandler(this.AmousRB_CheckedChanged);
            // 
            // jhonRb
            // 
            this.jhonRb.AutoSize = true;
            this.jhonRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jhonRb.Location = new System.Drawing.Point(15, 70);
            this.jhonRb.Name = "jhonRb";
            this.jhonRb.Size = new System.Drawing.Size(129, 20);
            this.jhonRb.TabIndex = 6;
            this.jhonRb.TabStop = true;
            this.jhonRb.Text = "JhonRadioButton";
            this.jhonRb.UseVisualStyleBackColor = true;
            this.jhonRb.CheckedChanged += new System.EventHandler(this.JhonRB_CheckedChanged);
            // 
            // KateRB
            // 
            this.KateRB.AutoSize = true;
            this.KateRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KateRB.Location = new System.Drawing.Point(15, 31);
            this.KateRB.Name = "KateRB";
            this.KateRB.Size = new System.Drawing.Size(127, 20);
            this.KateRB.TabIndex = 5;
            this.KateRB.TabStop = true;
            this.KateRB.Text = "KateRadioButton";
            this.KateRB.UseVisualStyleBackColor = true;
            this.KateRB.CheckedChanged += new System.EventHandler(this.KateRB_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::bikerace.Properties.Resources.proxy_duckduckgo1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bikerace.Properties.Resources.proxy_duckduckgo1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bikerace.Properties.Resources.proxy_duckduckgo1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bikerace.Properties.Resources.proxy_duckduckgo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // racePicture
            // 
            this.racePicture.Image = global::bikerace.Properties.Resources.sadasdas;
            this.racePicture.Location = new System.Drawing.Point(0, 0);
            this.racePicture.Name = "racePicture";
            this.racePicture.Size = new System.Drawing.Size(957, 383);
            this.racePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePicture.TabIndex = 8;
            this.racePicture.TabStop = false;
            this.racePicture.Click += new System.EventHandler(this.raceTrackPicture_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(957, 588);
            this.Controls.Add(this.Race_Button);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racePicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game";
            this.Text = "horse race";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Housenumberupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betmoneyupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Race_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox racePicture;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.NumericUpDown Housenumberupdown;
        private System.Windows.Forms.Label label_bike;
        private System.Windows.Forms.NumericUpDown betmoneyupdown;
        private System.Windows.Forms.Button bet_button;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label AmousLB;
        private System.Windows.Forms.Label jhonLB;
        private System.Windows.Forms.Label KateLB;
        private System.Windows.Forms.Label labelbt;
        private System.Windows.Forms.RadioButton AmousRB;
        private System.Windows.Forms.RadioButton jhonRb;
        private System.Windows.Forms.RadioButton KateRB;
    }
}

