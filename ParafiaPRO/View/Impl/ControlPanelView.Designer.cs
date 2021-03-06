﻿namespace ParafiaPRO.View.Impl
{
    partial class ControlPanelView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.pbLightControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(0, 154);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(95, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(99, 154);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(95, 23);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // pbLightControl
            // 
            this.pbLightControl.Image = global::ParafiaPRO.Properties.Resources.green;
            this.pbLightControl.Location = new System.Drawing.Point(3, 3);
            this.pbLightControl.Name = "pbLightControl";
            this.pbLightControl.Size = new System.Drawing.Size(16, 16);
            this.pbLightControl.TabIndex = 2;
            this.pbLightControl.TabStop = false;
            // 
            // ControlPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLightControl);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "ControlPanelView";
            this.Size = new System.Drawing.Size(194, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pbLightControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.PictureBox pbLightControl;
    }
}
