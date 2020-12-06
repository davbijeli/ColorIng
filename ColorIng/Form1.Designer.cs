namespace ColorIng
{
    partial class frmMain
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnAddColorToList = new System.Windows.Forms.Button();
            this.pnlChoosedColor = new System.Windows.Forms.Panel();
            this.gbColorsInList = new System.Windows.Forms.GroupBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(13, 40);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(123, 23);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "CHOOSE COLOR";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnAddColorToList
            // 
            this.btnAddColorToList.Location = new System.Drawing.Point(13, 69);
            this.btnAddColorToList.Name = "btnAddColorToList";
            this.btnAddColorToList.Size = new System.Drawing.Size(123, 23);
            this.btnAddColorToList.TabIndex = 1;
            this.btnAddColorToList.Text = "ADD COLOR TO LIST";
            this.btnAddColorToList.UseVisualStyleBackColor = true;
            this.btnAddColorToList.Click += new System.EventHandler(this.btnAddColorToList_Click);
            // 
            // pnlChoosedColor
            // 
            this.pnlChoosedColor.Location = new System.Drawing.Point(143, 40);
            this.pnlChoosedColor.Name = "pnlChoosedColor";
            this.pnlChoosedColor.Size = new System.Drawing.Size(167, 23);
            this.pnlChoosedColor.TabIndex = 2;
            // 
            // gbColorsInList
            // 
            this.gbColorsInList.Location = new System.Drawing.Point(13, 99);
            this.gbColorsInList.Name = "gbColorsInList";
            this.gbColorsInList.Size = new System.Drawing.Size(297, 100);
            this.gbColorsInList.TabIndex = 3;
            this.gbColorsInList.TabStop = false;
            this.gbColorsInList.Text = "Colors in list";
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(13, 205);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(297, 198);
            this.pnlColor.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 415);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.gbColorsInList);
            this.Controls.Add(this.pnlChoosedColor);
            this.Controls.Add(this.btnAddColorToList);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "frmMain";
            this.Text = "ColorIng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnAddColorToList;
        private System.Windows.Forms.Panel pnlChoosedColor;
        private System.Windows.Forms.GroupBox gbColorsInList;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Timer timer1;
    }
}

