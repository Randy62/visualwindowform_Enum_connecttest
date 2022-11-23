
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axAxAltairU1 = new AxAxAltairUDrv.AxAxAltairU();
            this.axAxBlobROIBW81 = new AxAxOvkBase.AxAxBlobROIBW8();
            this.axAxObject1 = new AxAxOvkBlob.AxAxObject();
            this.axAxCanvas1 = new AxAxOvkBase.AxAxCanvas();
            this.axAxAltairU2 = new AxAxAltairUDrv.AxAxAltairU();
            this.live = new System.Windows.Forms.Button();
            this.snap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axAxAltairU1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxBlobROIBW81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxObject1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxCanvas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxAltairU2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAxAltairU1
            // 
            this.axAxAltairU1.Location = new System.Drawing.Point(-4, 331);
            this.axAxAltairU1.Name = "axAxAltairU1";
            this.axAxAltairU1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxAltairU1.OcxState")));
            this.axAxAltairU1.Size = new System.Drawing.Size(192, 192);
            this.axAxAltairU1.TabIndex = 0;
            this.axAxAltairU1.OnSurfaceFilled += new AxAxAltairUDrv.IAxAltairUEvents_OnSurfaceFilledEventHandler(this.axAxAltairU1_OnSurfaceFilled);
            this.axAxAltairU1.OnSurfaceDraw += new AxAxAltairUDrv.IAxAltairUEvents_OnSurfaceDrawEventHandler(this.axAxAltairU1_OnSurfaceDraw);
            // 
            // axAxBlobROIBW81
            // 
            this.axAxBlobROIBW81.Location = new System.Drawing.Point(78, 510);
            this.axAxBlobROIBW81.Name = "axAxBlobROIBW81";
            this.axAxBlobROIBW81.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxBlobROIBW81.OcxState")));
            this.axAxBlobROIBW81.Size = new System.Drawing.Size(192, 192);
            this.axAxBlobROIBW81.TabIndex = 2;
            this.axAxBlobROIBW81.OnBlobPlaceChange += new System.EventHandler(this.axAxBlobROIBW81_OnBlobPlaceChange);
            // 
            // axAxObject1
            // 
            this.axAxObject1.Location = new System.Drawing.Point(715, 361);
            this.axAxObject1.Name = "axAxObject1";
            this.axAxObject1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxObject1.OcxState")));
            this.axAxObject1.Size = new System.Drawing.Size(30, 30);
            this.axAxObject1.TabIndex = 1;
            this.axAxObject1.Enter += new System.EventHandler(this.axAxObject1_Enter);
            // 
            // axAxCanvas1
            // 
            this.axAxCanvas1.Location = new System.Drawing.Point(12, 3);
            this.axAxCanvas1.Name = "axAxCanvas1";
            this.axAxCanvas1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxCanvas1.OcxState")));
            this.axAxCanvas1.Size = new System.Drawing.Size(641, 351);
            this.axAxCanvas1.TabIndex = 2;
            this.axAxCanvas1.Enter += new System.EventHandler(this.axAxCanvas1_Enter);
            // 
            // axAxAltairU2
            // 
            this.axAxAltairU2.Location = new System.Drawing.Point(82, 331);
            this.axAxAltairU2.Name = "axAxAltairU2";
            this.axAxAltairU2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAxAltairU2.OcxState")));
            this.axAxAltairU2.Size = new System.Drawing.Size(192, 192);
            this.axAxAltairU2.TabIndex = 3;
            // 
            // live
            // 
            this.live.Location = new System.Drawing.Point(295, 390);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(75, 23);
            this.live.TabIndex = 4;
            this.live.Text = "live";
            this.live.UseVisualStyleBackColor = true;
            this.live.Click += new System.EventHandler(this.button3_Click);
            // 
            // snap
            // 
            this.snap.Location = new System.Drawing.Point(405, 390);
            this.snap.Name = "snap";
            this.snap.Size = new System.Drawing.Size(75, 23);
            this.snap.TabIndex = 5;
            this.snap.Text = "snap";
            this.snap.UseVisualStyleBackColor = true;
            this.snap.Click += new System.EventHandler(this.snap_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(503, 361);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(503, 396);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 351);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.snap);
            this.Controls.Add(this.live);
            this.Controls.Add(this.axAxAltairU2);
            this.Controls.Add(this.axAxBlobROIBW81);
            this.Controls.Add(this.axAxCanvas1);
            this.Controls.Add(this.axAxObject1);
            this.Controls.Add(this.axAxAltairU1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAxAltairU1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxBlobROIBW81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxObject1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxCanvas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAxAltairU2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAxAltairUDrv.AxAxAltairU axAxAltairU1, axAxAltairU2;
        private AxAxOvkBase.AxAxCanvas axAxCanvas1;
        private AxAxOvkBase.AxAxBlobROIBW8 axAxBlobROIBW81;
        private AxAxOvkBlob.AxAxObject axAxObject1;
        private System.Windows.Forms.CheckBox cbShowBlobROIRegion;
        private System.Windows.Forms.CheckBox cbShowResult;
        private System.Windows.Forms.Button live;
        private System.Windows.Forms.Button snap;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

