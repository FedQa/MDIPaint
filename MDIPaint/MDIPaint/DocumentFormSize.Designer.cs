
namespace MDIPaint
{
    partial class DocumentFormSize
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Высота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина:";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(82, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(291, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxHeight.Location = new System.Drawing.Point(82, 30);
            this.textBoxHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.textBoxHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(75, 20);
            this.textBoxHeight.TabIndex = 6;
            this.textBoxHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxWidth.Location = new System.Drawing.Point(291, 34);
            this.textBoxWidth.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.textBoxWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(75, 20);
            this.textBoxWidth.TabIndex = 7;
            this.textBoxWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // DocumentFormSize
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(414, 197);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentFormSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Холст";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown textBoxHeight;
        private System.Windows.Forms.NumericUpDown textBoxWidth;
    }
}