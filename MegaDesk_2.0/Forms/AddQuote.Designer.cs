namespace MegaDesk_Ebenal
{
    partial class AddQuote
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
            this.label_NewQuote = new System.Windows.Forms.Label();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.groupBox_DeskSize = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Depth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.label_Depth = new System.Windows.Forms.Label();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_NumberOfDrawers = new System.Windows.Forms.Label();
            this.numericUpDown_NumberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.label_SurfaceMaterial = new System.Windows.Forms.Label();
            this.comboBox_SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label_Delivery = new System.Windows.Forms.Label();
            this.comboBox_Delivery = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_GetQuote = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_DeskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NewQuote
            // 
            this.label_NewQuote.AutoSize = true;
            this.label_NewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewQuote.Location = new System.Drawing.Point(250, 10);
            this.label_NewQuote.Name = "label_NewQuote";
            this.label_NewQuote.Size = new System.Drawing.Size(177, 37);
            this.label_NewQuote.TabIndex = 0;
            this.label_NewQuote.Text = "New Quote";
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(191, 76);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(202, 26);
            this.textBox_CustomerName.TabIndex = 1;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.Location = new System.Drawing.Point(57, 79);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(128, 20);
            this.label_CustomerName.TabIndex = 2;
            this.label_CustomerName.Text = "Customer Name:";
            // 
            // groupBox_DeskSize
            // 
            this.groupBox_DeskSize.Controls.Add(this.numericUpDown_Depth);
            this.groupBox_DeskSize.Controls.Add(this.numericUpDown_Width);
            this.groupBox_DeskSize.Controls.Add(this.label_Depth);
            this.groupBox_DeskSize.Controls.Add(this.label_Width);
            this.groupBox_DeskSize.Location = new System.Drawing.Point(52, 125);
            this.groupBox_DeskSize.Name = "groupBox_DeskSize";
            this.groupBox_DeskSize.Size = new System.Drawing.Size(247, 115);
            this.groupBox_DeskSize.TabIndex = 3;
            this.groupBox_DeskSize.TabStop = false;
            this.groupBox_DeskSize.Text = "Desk Size";
            // 
            // numericUpDown_Depth
            // 
            this.numericUpDown_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_Depth.Location = new System.Drawing.Point(93, 73);
            this.numericUpDown_Depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown_Depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown_Depth.Name = "numericUpDown_Depth";
            this.numericUpDown_Depth.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Depth.TabIndex = 3;
            this.numericUpDown_Depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_Width.Location = new System.Drawing.Point(93, 30);
            this.numericUpDown_Width.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown_Width.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown_Width.Name = "numericUpDown_Width";
            this.numericUpDown_Width.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Width.TabIndex = 2;
            this.numericUpDown_Width.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label_Depth
            // 
            this.label_Depth.AutoSize = true;
            this.label_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Depth.Location = new System.Drawing.Point(32, 70);
            this.label_Depth.Name = "label_Depth";
            this.label_Depth.Size = new System.Drawing.Size(57, 20);
            this.label_Depth.TabIndex = 1;
            this.label_Depth.Text = "Depth:";
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Width.Location = new System.Drawing.Point(28, 30);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(54, 20);
            this.label_Width.TabIndex = 0;
            this.label_Width.Text = "Width:";
            // 
            // label_NumberOfDrawers
            // 
            this.label_NumberOfDrawers.AutoSize = true;
            this.label_NumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_NumberOfDrawers.Location = new System.Drawing.Point(319, 127);
            this.label_NumberOfDrawers.Name = "label_NumberOfDrawers";
            this.label_NumberOfDrawers.Size = new System.Drawing.Size(150, 20);
            this.label_NumberOfDrawers.TabIndex = 4;
            this.label_NumberOfDrawers.Text = "Number of Drawers:";
            // 
            // numericUpDown_NumberOfDrawers
            // 
            this.numericUpDown_NumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_NumberOfDrawers.Location = new System.Drawing.Point(475, 125);
            this.numericUpDown_NumberOfDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_NumberOfDrawers.Name = "numericUpDown_NumberOfDrawers";
            this.numericUpDown_NumberOfDrawers.Size = new System.Drawing.Size(150, 26);
            this.numericUpDown_NumberOfDrawers.TabIndex = 5;
            // 
            // label_SurfaceMaterial
            // 
            this.label_SurfaceMaterial.AutoSize = true;
            this.label_SurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_SurfaceMaterial.Location = new System.Drawing.Point(340, 170);
            this.label_SurfaceMaterial.Name = "label_SurfaceMaterial";
            this.label_SurfaceMaterial.Size = new System.Drawing.Size(129, 20);
            this.label_SurfaceMaterial.TabIndex = 6;
            this.label_SurfaceMaterial.Text = "Surface Material:";
            // 
            // comboBox_SurfaceMaterial
            // 
            this.comboBox_SurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_SurfaceMaterial.FormattingEnabled = true;
            this.comboBox_SurfaceMaterial.Location = new System.Drawing.Point(475, 167);
            this.comboBox_SurfaceMaterial.Name = "comboBox_SurfaceMaterial";
            this.comboBox_SurfaceMaterial.Size = new System.Drawing.Size(150, 28);
            this.comboBox_SurfaceMaterial.TabIndex = 7;
            // 
            // label_Delivery
            // 
            this.label_Delivery.AutoSize = true;
            this.label_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Delivery.Location = new System.Drawing.Point(401, 215);
            this.label_Delivery.Name = "label_Delivery";
            this.label_Delivery.Size = new System.Drawing.Size(68, 20);
            this.label_Delivery.TabIndex = 8;
            this.label_Delivery.Text = "Delivery:";
            // 
            // comboBox_Delivery
            // 
            this.comboBox_Delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_Delivery.FormattingEnabled = true;
            this.comboBox_Delivery.Location = new System.Drawing.Point(475, 212);
            this.comboBox_Delivery.Name = "comboBox_Delivery";
            this.comboBox_Delivery.Size = new System.Drawing.Size(150, 28);
            this.comboBox_Delivery.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // button_GetQuote
            // 
            this.button_GetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_GetQuote.Location = new System.Drawing.Point(178, 274);
            this.button_GetQuote.Name = "button_GetQuote";
            this.button_GetQuote.Size = new System.Drawing.Size(150, 50);
            this.button_GetQuote.TabIndex = 10;
            this.button_GetQuote.Text = "Get Quote";
            this.button_GetQuote.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Cancel.Location = new System.Drawing.Point(353, 274);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(150, 50);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_GetQuote);
            this.Controls.Add(this.comboBox_Delivery);
            this.Controls.Add(this.label_Delivery);
            this.Controls.Add(this.comboBox_SurfaceMaterial);
            this.Controls.Add(this.label_SurfaceMaterial);
            this.Controls.Add(this.numericUpDown_NumberOfDrawers);
            this.Controls.Add(this.label_NumberOfDrawers);
            this.Controls.Add(this.groupBox_DeskSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.label_NewQuote);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.groupBox_DeskSize.ResumeLayout(false);
            this.groupBox_DeskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NewQuote;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.GroupBox groupBox_DeskSize;
        private System.Windows.Forms.NumericUpDown numericUpDown_Depth;
        private System.Windows.Forms.NumericUpDown numericUpDown_Width;
        private System.Windows.Forms.Label label_Depth;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_NumberOfDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfDrawers;
        private System.Windows.Forms.Label label_SurfaceMaterial;
        private System.Windows.Forms.ComboBox comboBox_SurfaceMaterial;
        private System.Windows.Forms.Label label_Delivery;
        private System.Windows.Forms.ComboBox comboBox_Delivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_GetQuote;
        private System.Windows.Forms.Button button_Cancel;
    }
}