namespace CEN4802_Proj3
{
    partial class formMain
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
            this.btnEquals = new System.Windows.Forms.Button();
            this.ouputTextBox = new System.Windows.Forms.RichTextBox();
            this.layoutButtonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.lblHints = new System.Windows.Forms.Label();
            this.layoutButtonGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEquals
            // 
            // Req 6)	The calculator shall have an equals button to process the calculation.
            this.btnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEquals.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEquals.Location = new System.Drawing.Point(6, 328);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(160, 55);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // ouputTextBox
            // 
            // Req 2)	The calculator shall have a window that shows the user’s input.
            this.ouputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ouputTextBox.Location = new System.Drawing.Point(6, 6);
            this.ouputTextBox.Name = "ouputTextBox";
            this.ouputTextBox.Size = new System.Drawing.Size(329, 62);
            this.ouputTextBox.TabIndex = 1;
            this.ouputTextBox.Text = "";
            // 
            // layoutButtonGrid
            // 
            this.layoutButtonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutButtonGrid.ColumnCount = 3;
            this.layoutButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.Controls.Add(this.btnMinus, 2, 3);
            this.layoutButtonGrid.Controls.Add(this.btnPlus, 1, 3);
            this.layoutButtonGrid.Controls.Add(this.btnZero, 0, 3);
            this.layoutButtonGrid.Controls.Add(this.btnNine, 2, 2);
            this.layoutButtonGrid.Controls.Add(this.btnEight, 1, 2);
            this.layoutButtonGrid.Controls.Add(this.btnSeven, 0, 2);
            this.layoutButtonGrid.Controls.Add(this.btnSix, 2, 1);
            this.layoutButtonGrid.Controls.Add(this.btnFive, 1, 1);
            this.layoutButtonGrid.Controls.Add(this.btnFour, 0, 1);
            this.layoutButtonGrid.Controls.Add(this.btnThree, 2, 0);
            this.layoutButtonGrid.Controls.Add(this.btnTwo, 1, 0);
            this.layoutButtonGrid.Controls.Add(this.btnOne, 0, 0);
            this.layoutButtonGrid.Location = new System.Drawing.Point(6, 100);
            this.layoutButtonGrid.Name = "layoutButtonGrid";
            this.layoutButtonGrid.RowCount = 4;
            this.layoutButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtonGrid.Size = new System.Drawing.Size(329, 222);
            this.layoutButtonGrid.TabIndex = 4;
            // 
            // btnMinus
            // 
            // Req 4)	The calculator shall have a button for the subtraction operation.
            this.btnMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(221, 168);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(103, 51);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            // Req 5)	The calculator shall have a button for the addition operation.
            this.btnPlus.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(112, 168);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(103, 51);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnZero
            // 
            // Req 16)	The calculator shall have a button to represent the number 0.
            this.btnZero.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(3, 168);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(103, 51);
            this.btnZero.TabIndex = 9;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            // Req 15)	The calculator shall have a button to represent the number 9.
            this.btnNine.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(221, 113);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(103, 49);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            // Req 14)	The calculator shall have a button to represent the number 8.
            this.btnEight.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(112, 113);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(103, 49);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            // Req 13)	The calculator shall have a button to represent the number 7.
            this.btnSeven.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(3, 113);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(103, 49);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            // Req 12)	The calculator shall have a button to represent the number 6.
            this.btnSix.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(221, 58);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(103, 49);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            // Req 11)	The calculator shall have a button to represent the number 5.
            this.btnFive.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(112, 58);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(103, 49);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            // Req 10)	The calculator shall have a button to represent the number 4.
            this.btnFour.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(3, 58);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(103, 49);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            // Req 9)	The calculator shall have a button to represent the number 3.
            this.btnThree.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(221, 3);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(103, 49);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            // Req 8)	The calculator shall have a button to represent the number 2.
            this.btnTwo.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(112, 3);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(103, 49);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            // Req 7)	The calculator shall have a button to represent the number 1.
            this.btnOne.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(3, 3);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(103, 49);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnPower
            // 
            // Req 
            this.btnPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPower.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.Location = new System.Drawing.Point(177, 328);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(160, 55);
            this.btnPower.TabIndex = 5;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // lblHints
            // 
            this.lblHints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHints.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHints.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHints.Location = new System.Drawing.Point(6, 71);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(331, 26);
            this.lblHints.TabIndex = 6;
            this.lblHints.Text = "Help messages/exceptions";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(345, 386);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.layoutButtonGrid);
            this.Controls.Add(this.ouputTextBox);
            this.Controls.Add(this.btnEquals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formMain";
            this.Text = "CEN4802_Proj3";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.layoutButtonGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.RichTextBox ouputTextBox;
        private System.Windows.Forms.TableLayoutPanel layoutButtonGrid;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Label lblHints;
    }
}

