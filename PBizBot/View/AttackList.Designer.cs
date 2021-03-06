﻿namespace PBizBot.View
{
    partial class AttackList
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
            this.pAttackItems = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbAttacker = new System.Windows.Forms.ComboBox();
            this.pbLastAttackSort = new System.Windows.Forms.PictureBox();
            this.pbLoseSort = new System.Windows.Forms.PictureBox();
            this.pbWinSort = new System.Windows.Forms.PictureBox();
            this.pbCashSort = new System.Windows.Forms.PictureBox();
            this.pbNameSort = new System.Windows.Forms.PictureBox();
            this.pbAttackerSort = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLastAttackSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoseSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNameSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackerSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pAttackItems
            // 
            this.pAttackItems.AutoScroll = true;
            this.pAttackItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAttackItems.Location = new System.Drawing.Point(0, 14);
            this.pAttackItems.Name = "pAttackItems";
            this.pAttackItems.Size = new System.Drawing.Size(584, 464);
            this.pAttackItems.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(110, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Nazwa";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Location = new System.Drawing.Point(252, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(73, 13);
            this.textBox2.TabIndex = 11;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Kasa";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Location = new System.Drawing.Point(326, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(50, 13);
            this.textBox3.TabIndex = 12;
            this.textBox3.TabStop = false;
            this.textBox3.Text = " Win";
            this.textBox3.WordWrap = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.Location = new System.Drawing.Point(377, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(50, 13);
            this.textBox4.TabIndex = 12;
            this.textBox4.TabStop = false;
            this.textBox4.Text = " Lose";
            this.textBox4.WordWrap = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox5.HideSelection = false;
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox5.Location = new System.Drawing.Point(428, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(115, 13);
            this.textBox5.TabIndex = 12;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Ostatni Atak";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.WordWrap = false;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(110, 484);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 13);
            this.tbName.TabIndex = 14;
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEnabled.Checked = true;
            this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEnabled.Location = new System.Drawing.Point(3, 485);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(12, 11);
            this.cbEnabled.TabIndex = 13;
            this.cbEnabled.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox6.Location = new System.Drawing.Point(21, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(88, 13);
            this.textBox6.TabIndex = 18;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Atakujący";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.WordWrap = false;
            // 
            // cbAttacker
            // 
            this.cbAttacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAttacker.FormattingEnabled = true;
            this.cbAttacker.Location = new System.Drawing.Point(21, 481);
            this.cbAttacker.Name = "cbAttacker";
            this.cbAttacker.Size = new System.Drawing.Size(88, 20);
            this.cbAttacker.TabIndex = 20;
            // 
            // pbLastAttackSort
            // 
            this.pbLastAttackSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLastAttackSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbLastAttackSort.Location = new System.Drawing.Point(530, 0);
            this.pbLastAttackSort.Name = "pbLastAttackSort";
            this.pbLastAttackSort.Size = new System.Drawing.Size(13, 13);
            this.pbLastAttackSort.TabIndex = 26;
            this.pbLastAttackSort.TabStop = false;
            this.pbLastAttackSort.Click += new System.EventHandler(this.pbLastAttackSort_Click);
            // 
            // pbLoseSort
            // 
            this.pbLoseSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLoseSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbLoseSort.Location = new System.Drawing.Point(414, 0);
            this.pbLoseSort.Name = "pbLoseSort";
            this.pbLoseSort.Size = new System.Drawing.Size(13, 13);
            this.pbLoseSort.TabIndex = 25;
            this.pbLoseSort.TabStop = false;
            this.pbLoseSort.Click += new System.EventHandler(this.pbLoseSort_Click);
            // 
            // pbWinSort
            // 
            this.pbWinSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWinSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbWinSort.Location = new System.Drawing.Point(363, 0);
            this.pbWinSort.Name = "pbWinSort";
            this.pbWinSort.Size = new System.Drawing.Size(13, 13);
            this.pbWinSort.TabIndex = 24;
            this.pbWinSort.TabStop = false;
            this.pbWinSort.Click += new System.EventHandler(this.pbWinSort_Click);
            // 
            // pbCashSort
            // 
            this.pbCashSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCashSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbCashSort.Location = new System.Drawing.Point(312, 0);
            this.pbCashSort.Name = "pbCashSort";
            this.pbCashSort.Size = new System.Drawing.Size(13, 13);
            this.pbCashSort.TabIndex = 23;
            this.pbCashSort.TabStop = false;
            this.pbCashSort.Click += new System.EventHandler(this.pbCashSort_Click);
            // 
            // pbNameSort
            // 
            this.pbNameSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNameSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbNameSort.Location = new System.Drawing.Point(238, 0);
            this.pbNameSort.Name = "pbNameSort";
            this.pbNameSort.Size = new System.Drawing.Size(13, 13);
            this.pbNameSort.TabIndex = 22;
            this.pbNameSort.TabStop = false;
            this.pbNameSort.Click += new System.EventHandler(this.pbNameSort_Click);
            // 
            // pbAttackerSort
            // 
            this.pbAttackerSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAttackerSort.Image = global::PBizBot.Properties.Resources.updown_small;
            this.pbAttackerSort.Location = new System.Drawing.Point(96, 0);
            this.pbAttackerSort.Name = "pbAttackerSort";
            this.pbAttackerSort.Size = new System.Drawing.Size(13, 13);
            this.pbAttackerSort.TabIndex = 21;
            this.pbAttackerSort.TabStop = false;
            this.pbAttackerSort.Click += new System.EventHandler(this.pbAttackerSort_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::PBizBot.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(257, 483);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(16, 16);
            this.pbAdd.TabIndex = 17;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // AttackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLastAttackSort);
            this.Controls.Add(this.pbLoseSort);
            this.Controls.Add(this.pbWinSort);
            this.Controls.Add(this.pbCashSort);
            this.Controls.Add(this.pbNameSort);
            this.Controls.Add(this.pbAttackerSort);
            this.Controls.Add(this.cbAttacker);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pAttackItems);
            this.Controls.Add(this.textBox1);
            this.Name = "AttackList";
            this.Size = new System.Drawing.Size(584, 504);
            this.Load += new System.EventHandler(this.AttackList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLastAttackSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoseSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWinSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNameSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackerSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pAttackItems;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cbAttacker;
        private System.Windows.Forms.PictureBox pbAttackerSort;
        private System.Windows.Forms.PictureBox pbNameSort;
        private System.Windows.Forms.PictureBox pbCashSort;
        private System.Windows.Forms.PictureBox pbWinSort;
        private System.Windows.Forms.PictureBox pbLoseSort;
        private System.Windows.Forms.PictureBox pbLastAttackSort;
    }
}
