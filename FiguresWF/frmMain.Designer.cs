//GabdrahmanovRadmir220_Figures3

namespace FiguresWF
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbRadius = new System.Windows.Forms.GroupBox();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.lbRadius = new System.Windows.Forms.Label();
            this.lbThickness = new System.Windows.Forms.Label();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.gbPoint3 = new System.Windows.Forms.GroupBox();
            this.numY3 = new System.Windows.Forms.NumericUpDown();
            this.numX3 = new System.Windows.Forms.NumericUpDown();
            this.lbY3 = new System.Windows.Forms.Label();
            this.lbX3 = new System.Windows.Forms.Label();
            this.gbPoint2 = new System.Windows.Forms.GroupBox();
            this.numY2 = new System.Windows.Forms.NumericUpDown();
            this.numX2 = new System.Windows.Forms.NumericUpDown();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.gbPoint1 = new System.Windows.Forms.GroupBox();
            this.numY1 = new System.Windows.Forms.NumericUpDown();
            this.numX1 = new System.Windows.Forms.NumericUpDown();
            this.lbY1 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbMenu.SuspendLayout();
            this.gbRadius.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            this.gbParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.gbPoint3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX3)).BeginInit();
            this.gbPoint2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).BeginInit();
            this.gbPoint1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Honeydew;
            this.gbMenu.Controls.Add(this.gbRadius);
            this.gbMenu.Controls.Add(this.lbThickness);
            this.gbMenu.Controls.Add(this.numThickness);
            this.gbMenu.Controls.Add(this.btnClear);
            this.gbMenu.Controls.Add(this.gbParams);
            this.gbMenu.Controls.Add(this.gbPoint3);
            this.gbMenu.Controls.Add(this.gbPoint2);
            this.gbMenu.Controls.Add(this.gbPoint1);
            this.gbMenu.Controls.Add(this.btnLoad);
            this.gbMenu.Controls.Add(this.btnSave);
            this.gbMenu.Controls.Add(this.btnDraw);
            this.gbMenu.Controls.Add(this.btnCircle);
            this.gbMenu.Controls.Add(this.btnRectangle);
            this.gbMenu.Controls.Add(this.btnTriangle);
            this.gbMenu.Controls.Add(this.btnLine);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMenu.Location = new System.Drawing.Point(0, 0);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(293, 591);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // gbRadius
            // 
            this.gbRadius.Controls.Add(this.numRadius);
            this.gbRadius.Controls.Add(this.lbRadius);
            this.gbRadius.Location = new System.Drawing.Point(12, 192);
            this.gbRadius.Name = "gbRadius";
            this.gbRadius.Padding = new System.Windows.Forms.Padding(0);
            this.gbRadius.Size = new System.Drawing.Size(262, 58);
            this.gbRadius.TabIndex = 10;
            this.gbRadius.TabStop = false;
            this.gbRadius.Visible = false;
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(113, 21);
            this.numRadius.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(56, 27);
            this.numRadius.TabIndex = 4;
            // 
            // lbRadius
            // 
            this.lbRadius.AutoSize = true;
            this.lbRadius.Location = new System.Drawing.Point(51, 23);
            this.lbRadius.Name = "lbRadius";
            this.lbRadius.Size = new System.Drawing.Size(56, 20);
            this.lbRadius.TabIndex = 2;
            this.lbRadius.Text = "Radius:";
            // 
            // lbThickness
            // 
            this.lbThickness.AutoSize = true;
            this.lbThickness.Location = new System.Drawing.Point(73, 384);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(74, 20);
            this.lbThickness.TabIndex = 15;
            this.lbThickness.Text = "Thickness:";
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(153, 382);
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(56, 27);
            this.numThickness.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(153, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 38);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.numHeight);
            this.gbParams.Controls.Add(this.numWidth);
            this.gbParams.Controls.Add(this.lbHeight);
            this.gbParams.Controls.Add(this.lbWidth);
            this.gbParams.Location = new System.Drawing.Point(12, 318);
            this.gbParams.Name = "gbParams";
            this.gbParams.Padding = new System.Windows.Forms.Padding(0);
            this.gbParams.Size = new System.Drawing.Size(262, 58);
            this.gbParams.TabIndex = 11;
            this.gbParams.TabStop = false;
            this.gbParams.Visible = false;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(203, 18);
            this.numHeight.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(56, 27);
            this.numHeight.TabIndex = 5;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(61, 18);
            this.numWidth.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(56, 27);
            this.numWidth.TabIndex = 4;
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(141, 20);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(57, 20);
            this.lbHeight.TabIndex = 3;
            this.lbHeight.Text = "Height:";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(6, 20);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(52, 20);
            this.lbWidth.TabIndex = 2;
            this.lbWidth.Text = "Width:";
            // 
            // gbPoint3
            // 
            this.gbPoint3.Controls.Add(this.numY3);
            this.gbPoint3.Controls.Add(this.numX3);
            this.gbPoint3.Controls.Add(this.lbY3);
            this.gbPoint3.Controls.Add(this.lbX3);
            this.gbPoint3.Location = new System.Drawing.Point(12, 254);
            this.gbPoint3.Name = "gbPoint3";
            this.gbPoint3.Padding = new System.Windows.Forms.Padding(0);
            this.gbPoint3.Size = new System.Drawing.Size(262, 58);
            this.gbPoint3.TabIndex = 10;
            this.gbPoint3.TabStop = false;
            this.gbPoint3.Visible = false;
            // 
            // numY3
            // 
            this.numY3.Location = new System.Drawing.Point(175, 18);
            this.numY3.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numY3.Name = "numY3";
            this.numY3.Size = new System.Drawing.Size(56, 27);
            this.numY3.TabIndex = 5;
            // 
            // numX3
            // 
            this.numX3.Location = new System.Drawing.Point(41, 18);
            this.numX3.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numX3.Name = "numX3";
            this.numX3.Size = new System.Drawing.Size(56, 27);
            this.numX3.TabIndex = 4;
            // 
            // lbY3
            // 
            this.lbY3.AutoSize = true;
            this.lbY3.Location = new System.Drawing.Point(141, 20);
            this.lbY3.Name = "lbY3";
            this.lbY3.Size = new System.Drawing.Size(28, 20);
            this.lbY3.TabIndex = 3;
            this.lbY3.Text = "Y3:";
            // 
            // lbX3
            // 
            this.lbX3.AutoSize = true;
            this.lbX3.Location = new System.Drawing.Point(6, 20);
            this.lbX3.Name = "lbX3";
            this.lbX3.Size = new System.Drawing.Size(29, 20);
            this.lbX3.TabIndex = 2;
            this.lbX3.Text = "X3:";
            // 
            // gbPoint2
            // 
            this.gbPoint2.Controls.Add(this.numY2);
            this.gbPoint2.Controls.Add(this.numX2);
            this.gbPoint2.Controls.Add(this.lbY2);
            this.gbPoint2.Controls.Add(this.lbX2);
            this.gbPoint2.Location = new System.Drawing.Point(12, 190);
            this.gbPoint2.Name = "gbPoint2";
            this.gbPoint2.Padding = new System.Windows.Forms.Padding(0);
            this.gbPoint2.Size = new System.Drawing.Size(262, 58);
            this.gbPoint2.TabIndex = 9;
            this.gbPoint2.TabStop = false;
            this.gbPoint2.Visible = false;
            // 
            // numY2
            // 
            this.numY2.Location = new System.Drawing.Point(175, 18);
            this.numY2.Name = "numY2";
            this.numY2.Size = new System.Drawing.Size(56, 27);
            this.numY2.TabIndex = 5;
            // 
            // numX2
            // 
            this.numX2.Location = new System.Drawing.Point(41, 18);
            this.numX2.Name = "numX2";
            this.numX2.Size = new System.Drawing.Size(56, 27);
            this.numX2.TabIndex = 4;
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.Location = new System.Drawing.Point(141, 20);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(28, 20);
            this.lbY2.TabIndex = 3;
            this.lbY2.Text = "Y2:";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(6, 20);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(29, 20);
            this.lbX2.TabIndex = 2;
            this.lbX2.Text = "X2:";
            // 
            // gbPoint1
            // 
            this.gbPoint1.BackColor = System.Drawing.Color.Honeydew;
            this.gbPoint1.Controls.Add(this.numY1);
            this.gbPoint1.Controls.Add(this.numX1);
            this.gbPoint1.Controls.Add(this.lbY1);
            this.gbPoint1.Controls.Add(this.lbX1);
            this.gbPoint1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPoint1.Location = new System.Drawing.Point(12, 128);
            this.gbPoint1.Name = "gbPoint1";
            this.gbPoint1.Padding = new System.Windows.Forms.Padding(0);
            this.gbPoint1.Size = new System.Drawing.Size(262, 58);
            this.gbPoint1.TabIndex = 8;
            this.gbPoint1.TabStop = false;
            this.gbPoint1.Visible = false;
            // 
            // numY1
            // 
            this.numY1.Location = new System.Drawing.Point(175, 18);
            this.numY1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numY1.Name = "numY1";
            this.numY1.Size = new System.Drawing.Size(56, 27);
            this.numY1.TabIndex = 5;
            // 
            // numX1
            // 
            this.numX1.Location = new System.Drawing.Point(41, 18);
            this.numX1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numX1.Name = "numX1";
            this.numX1.Size = new System.Drawing.Size(56, 27);
            this.numX1.TabIndex = 4;
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.Location = new System.Drawing.Point(141, 20);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(28, 20);
            this.lbY1.TabIndex = 3;
            this.lbY1.Text = "Y1:";
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(6, 20);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(29, 20);
            this.lbX1.TabIndex = 2;
            this.lbX1.Text = "X1:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(67, 530);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(153, 38);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(34, 418);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(99, 38);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCircle.BackgroundImage = global::FiguresWF.Properties.Resources.circle;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.Location = new System.Drawing.Point(153, 82);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(121, 40);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btn_Click);
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRectangle.BackgroundImage = global::FiguresWF.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.Location = new System.Drawing.Point(153, 26);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(121, 40);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btn_Click);
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTriangle.BackgroundImage = global::FiguresWF.Properties.Resources.triangle;
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriangle.Location = new System.Drawing.Point(12, 82);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(121, 40);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btn_Click);
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLine.BackgroundImage = global::FiguresWF.Properties.Resources.line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.Location = new System.Drawing.Point(12, 26);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(121, 40);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btn_Click);
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.White;
            this.pnlPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaper.Location = new System.Drawing.Point(293, 0);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(555, 591);
            this.pnlPaper.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 591);
            this.Controls.Add(this.pnlPaper);
            this.Controls.Add(this.gbMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.Text = "Main";
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.gbRadius.ResumeLayout(false);
            this.gbRadius.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.gbPoint3.ResumeLayout(false);
            this.gbPoint3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX3)).EndInit();
            this.gbPoint2.ResumeLayout(false);
            this.gbPoint2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).EndInit();
            this.gbPoint1.ResumeLayout(false);
            this.gbPoint1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox gbPoint1;
        private System.Windows.Forms.NumericUpDown numY1;
        private System.Windows.Forms.NumericUpDown numX1;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.GroupBox gbPoint2;
        private System.Windows.Forms.NumericUpDown numY2;
        private System.Windows.Forms.NumericUpDown numX2;
        private System.Windows.Forms.Label lbY2;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.GroupBox gbPoint3;
        private System.Windows.Forms.NumericUpDown numY3;
        private System.Windows.Forms.NumericUpDown numX3;
        private System.Windows.Forms.Label lbY3;
        private System.Windows.Forms.Label lbX3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbThickness;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.GroupBox gbRadius;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.Label lbRadius;
    }
}

