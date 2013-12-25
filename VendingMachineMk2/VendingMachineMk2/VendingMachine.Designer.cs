namespace VendingMachineMk2
{
    partial class VendingMachine
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShohin01 = new System.Windows.Forms.Button();
            this.btnShohin02 = new System.Windows.Forms.Button();
            this.btnShohin03 = new System.Windows.Forms.Button();
            this.btnInsertYen1000 = new System.Windows.Forms.Button();
            this.btnInsertYen100 = new System.Windows.Forms.Button();
            this.btnInsertYen10 = new System.Windows.Forms.Button();
            this.lblTotalOtsuriYen = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.lblInsertedYen2 = new System.Windows.Forms.Label();
            this.btnOtsuri = new System.Windows.Forms.Button();
            this.pictOutputShohinBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShohin04 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnShohin05 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictOutputShohinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShohin01
            // 
            this.btnShohin01.Enabled = false;
            this.btnShohin01.Location = new System.Drawing.Point(13, 147);
            this.btnShohin01.Name = "btnShohin01";
            this.btnShohin01.Size = new System.Drawing.Size(64, 23);
            this.btnShohin01.TabIndex = 0;
            this.btnShohin01.UseVisualStyleBackColor = true;
            this.btnShohin01.Click += new System.EventHandler(this.BtnShohin01_OnClick);
            // 
            // btnShohin02
            // 
            this.btnShohin02.Enabled = false;
            this.btnShohin02.Location = new System.Drawing.Point(83, 147);
            this.btnShohin02.Name = "btnShohin02";
            this.btnShohin02.Size = new System.Drawing.Size(64, 23);
            this.btnShohin02.TabIndex = 0;
            this.btnShohin02.UseVisualStyleBackColor = true;
            this.btnShohin02.Click += new System.EventHandler(this.BtnShohin02_OnClick);
            // 
            // btnShohin03
            // 
            this.btnShohin03.Enabled = false;
            this.btnShohin03.Location = new System.Drawing.Point(153, 147);
            this.btnShohin03.Name = "btnShohin03";
            this.btnShohin03.Size = new System.Drawing.Size(64, 23);
            this.btnShohin03.TabIndex = 4;
            this.btnShohin03.UseVisualStyleBackColor = true;
            this.btnShohin03.Click += new System.EventHandler(this.BtnShohin03_OnClick);
            // 
            // btnInsertYen1000
            // 
            this.btnInsertYen1000.Location = new System.Drawing.Point(19, 232);
            this.btnInsertYen1000.Name = "btnInsertYen1000";
            this.btnInsertYen1000.Size = new System.Drawing.Size(58, 22);
            this.btnInsertYen1000.TabIndex = 6;
            this.btnInsertYen1000.Text = "1000\\";
            this.btnInsertYen1000.UseVisualStyleBackColor = true;
            this.btnInsertYen1000.Click += new System.EventHandler(this.BtnInsertYen1000_OnClick);
            // 
            // btnInsertYen100
            // 
            this.btnInsertYen100.Location = new System.Drawing.Point(89, 232);
            this.btnInsertYen100.Name = "btnInsertYen100";
            this.btnInsertYen100.Size = new System.Drawing.Size(58, 22);
            this.btnInsertYen100.TabIndex = 7;
            this.btnInsertYen100.Text = "100\\";
            this.btnInsertYen100.UseVisualStyleBackColor = true;
            this.btnInsertYen100.Click += new System.EventHandler(this.btnInsertYen100_OnClick);
            // 
            // btnInsertYen10
            // 
            this.btnInsertYen10.Location = new System.Drawing.Point(152, 232);
            this.btnInsertYen10.Name = "btnInsertYen10";
            this.btnInsertYen10.Size = new System.Drawing.Size(58, 22);
            this.btnInsertYen10.TabIndex = 8;
            this.btnInsertYen10.Text = "10\\";
            this.btnInsertYen10.UseVisualStyleBackColor = true;
            this.btnInsertYen10.Click += new System.EventHandler(this.btnInsertYen10_OnClick);
            // 
            // lblTotalOtsuriYen
            // 
            this.lblTotalOtsuriYen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOtsuriYen.Location = new System.Drawing.Point(298, 283);
            this.lblTotalOtsuriYen.Name = "lblTotalOtsuriYen";
            this.lblTotalOtsuriYen.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalOtsuriYen.Size = new System.Drawing.Size(59, 24);
            this.lblTotalOtsuriYen.TabIndex = 10;
            this.lblTotalOtsuriYen.Text = "0円";
            this.lblTotalOtsuriYen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(2, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(227, 129);
            this.button7.TabIndex = 12;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // lblInsertedYen2
            // 
            this.lblInsertedYen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInsertedYen2.Location = new System.Drawing.Point(298, 197);
            this.lblInsertedYen2.Name = "lblInsertedYen2";
            this.lblInsertedYen2.Padding = new System.Windows.Forms.Padding(5);
            this.lblInsertedYen2.Size = new System.Drawing.Size(59, 24);
            this.lblInsertedYen2.TabIndex = 5;
            this.lblInsertedYen2.Text = "0円";
            this.lblInsertedYen2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnOtsuri
            // 
            this.btnOtsuri.Image = global::VendingMachineMk2.Properties.Resources.Lever_MoneyRefund;
            this.btnOtsuri.Location = new System.Drawing.Point(324, 249);
            this.btnOtsuri.Name = "btnOtsuri";
            this.btnOtsuri.Size = new System.Drawing.Size(33, 31);
            this.btnOtsuri.TabIndex = 8;
            this.btnOtsuri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtsuri.UseVisualStyleBackColor = true;
            this.btnOtsuri.Click += new System.EventHandler(this.btnOtsuri_OnClick);
            // 
            // pictOutputShohinBox
            // 
            this.pictOutputShohinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictOutputShohinBox.Location = new System.Drawing.Point(12, 325);
            this.pictOutputShohinBox.Name = "pictOutputShohinBox";
            this.pictOutputShohinBox.Size = new System.Drawing.Size(345, 78);
            this.pictOutputShohinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictOutputShohinBox.TabIndex = 9;
            this.pictOutputShohinBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VendingMachineMk2.Properties.Resources.Can02;
            this.pictureBox3.Location = new System.Drawing.Point(153, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VendingMachineMk2.Properties.Resources.Can04;
            this.pictureBox2.Location = new System.Drawing.Point(83, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VendingMachineMk2.Properties.Resources.Can03;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnShohin04
            // 
            this.btnShohin04.Enabled = false;
            this.btnShohin04.Location = new System.Drawing.Point(223, 147);
            this.btnShohin04.Name = "btnShohin04";
            this.btnShohin04.Size = new System.Drawing.Size(64, 23);
            this.btnShohin04.TabIndex = 14;
            this.btnShohin04.UseVisualStyleBackColor = true;
            this.btnShohin04.Click += new System.EventHandler(this.BtnShohin04_OnClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VendingMachineMk2.Properties.Resources.Can05;
            this.pictureBox4.Location = new System.Drawing.Point(223, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btnShohin05
            // 
            this.btnShohin05.Enabled = false;
            this.btnShohin05.Location = new System.Drawing.Point(293, 147);
            this.btnShohin05.Name = "btnShohin05";
            this.btnShohin05.Size = new System.Drawing.Size(64, 23);
            this.btnShohin05.TabIndex = 16;
            this.btnShohin05.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(293, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // VendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 415);
            this.Controls.Add(this.btnShohin05);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnShohin04);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblTotalOtsuriYen);
            this.Controls.Add(this.pictOutputShohinBox);
            this.Controls.Add(this.btnOtsuri);
            this.Controls.Add(this.btnInsertYen10);
            this.Controls.Add(this.btnInsertYen100);
            this.Controls.Add(this.btnInsertYen1000);
            this.Controls.Add(this.lblInsertedYen2);
            this.Controls.Add(this.btnShohin03);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnShohin02);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShohin01);
            this.Controls.Add(this.button7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendingMachine";
            this.Text = "じはんき";
            ((System.ComponentModel.ISupportInitialize)(this.pictOutputShohinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnInsertYen1000;
        private System.Windows.Forms.Button btnInsertYen100;
        private System.Windows.Forms.Button btnInsertYen10;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.Label lblInsertedYen2;
        public System.Windows.Forms.Button btnShohin01;
        public System.Windows.Forms.PictureBox pictOutputShohinBox;
        public System.Windows.Forms.Button btnShohin02;
        public System.Windows.Forms.Button btnShohin03;
        private System.Windows.Forms.Button btnOtsuri;
        public System.Windows.Forms.Label lblTotalOtsuriYen;
        public System.Windows.Forms.Button btnShohin04;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Button btnShohin05;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

