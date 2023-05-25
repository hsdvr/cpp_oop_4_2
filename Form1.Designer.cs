using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Лабораторная_работа_4_2
{
    partial class frmMain
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
            lbText = new Label();
            txtBxA = new TextBox();
            txtBxB = new TextBox();
            txtBxC = new TextBox();
            numUDA = new NumericUpDown();
            numUDB = new NumericUpDown();
            numUDC = new NumericUpDown();
            trckBrA = new TrackBar();
            trckBrB = new TrackBar();
            trckBrC = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numUDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trckBrA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trckBrB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trckBrC).BeginInit();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            lbText.Location = new Point(153, 15);
            lbText.Name = "lbText";
            lbText.Size = new Size(373, 81);
            lbText.TabIndex = 0;
            lbText.Text = "A <= B <= C";
            // 
            // txtBxA
            // 
            txtBxA.Location = new Point(130, 112);
            txtBxA.Margin = new Padding(3, 2, 3, 2);
            txtBxA.Name = "txtBxA";
            txtBxA.Size = new Size(110, 23);
            txtBxA.TabIndex = 1;
            txtBxA.Tag = 0;
            txtBxA.Text = "0";
            txtBxA.KeyDown += txtBx_KeyDown;
            txtBxA.LostFocus += txtBx_LostFocus;
            // 
            // txtBxB
            // 
            txtBxB.Location = new Point(304, 112);
            txtBxB.Margin = new Padding(3, 2, 3, 2);
            txtBxB.Name = "txtBxB";
            txtBxB.Size = new Size(110, 23);
            txtBxB.TabIndex = 2;
            txtBxB.Tag = 1;
            txtBxB.Text = "0";
            txtBxB.KeyDown += txtBx_KeyDown;
            txtBxB.LostFocus += txtBx_LostFocus;
            // 
            // txtBxC
            // 
            txtBxC.Location = new Point(478, 112);
            txtBxC.Margin = new Padding(3, 2, 3, 2);
            txtBxC.Name = "txtBxC";
            txtBxC.Size = new Size(110, 23);
            txtBxC.TabIndex = 3;
            txtBxC.Tag = 2;
            txtBxC.Text = "0";
            txtBxC.KeyDown += txtBx_KeyDown;
            txtBxC.LostFocus += txtBx_LostFocus;
            // 
            // numUDA
            // 
            numUDA.Location = new Point(130, 150);
            numUDA.Margin = new Padding(3, 2, 3, 2);
            numUDA.Name = "numUDA";
            numUDA.Size = new Size(109, 23);
            numUDA.TabIndex = 4;
            numUDA.Tag = 0;
            numUDA.ValueChanged += numUD_ValueChanged;
            numUDA.LostFocus += numUD_LostFocus;
            // 
            // numUDB
            // 
            numUDB.Location = new Point(304, 150);
            numUDB.Margin = new Padding(3, 2, 3, 2);
            numUDB.Name = "numUDB";
            numUDB.Size = new Size(109, 23);
            numUDB.TabIndex = 5;
            numUDB.Tag = 1;
            numUDB.ValueChanged += numUD_ValueChanged;
            numUDB.LostFocus += numUD_LostFocus;
            // 
            // numUDC
            // 
            numUDC.Location = new Point(478, 150);
            numUDC.Margin = new Padding(3, 2, 3, 2);
            numUDC.Name = "numUDC";
            numUDC.Size = new Size(109, 23);
            numUDC.TabIndex = 6;
            numUDC.Tag = 2;
            numUDC.ValueChanged += numUD_ValueChanged;
            numUDC.LostFocus += numUD_LostFocus;
            // 
            // trckBrA
            // 
            trckBrA.Location = new Point(130, 188);
            trckBrA.Margin = new Padding(3, 2, 3, 2);
            trckBrA.Name = "trckBrA";
            trckBrA.Size = new Size(109, 45);
            trckBrA.TabIndex = 7;
            trckBrA.Tag = 0;
            trckBrA.ValueChanged += trckBr_ValueChanged;
            // 
            // trckBrB
            // 
            trckBrB.Location = new Point(304, 188);
            trckBrB.Margin = new Padding(3, 2, 3, 2);
            trckBrB.Name = "trckBrB";
            trckBrB.Size = new Size(109, 45);
            trckBrB.SmallChange = 2;
            trckBrB.TabIndex = 8;
            trckBrB.Tag = 1;
            trckBrB.ValueChanged += trckBr_ValueChanged;
            // 
            // trckBrC
            // 
            trckBrC.Location = new Point(478, 188);
            trckBrC.Margin = new Padding(3, 2, 3, 2);
            trckBrC.Name = "trckBrC";
            trckBrC.Size = new Size(109, 45);
            trckBrC.TabIndex = 9;
            trckBrC.Tag = 2;
            trckBrC.ValueChanged += trckBr_ValueChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(trckBrC);
            Controls.Add(trckBrB);
            Controls.Add(trckBrA);
            Controls.Add(numUDA);
            Controls.Add(numUDB);
            Controls.Add(numUDC);
            Controls.Add(txtBxA);
            Controls.Add(txtBxB);
            Controls.Add(txtBxC);
            Controls.Add(lbText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "Лабораторная работа 4 часть 2";
            FormClosing += frmMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numUDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trckBrA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trckBrB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trckBrC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lbText;
        public TextBox txtBxA;
        public TextBox txtBxB;
        public TextBox txtBxC;
        public NumericUpDown numUDA;
        public NumericUpDown numUDB;
        public NumericUpDown numUDC;
        public TrackBar trckBrA;
        public TrackBar trckBrB;
        public TrackBar trckBrC;
    }
}
