namespace EmbryoStats
{
    partial class Form1
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
            this.imagesView = new System.Windows.Forms.FlowLayoutPanel();
            this.openImageDialogBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.processBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imagesView
            // 
            this.imagesView.Location = new System.Drawing.Point(12, 58);
            this.imagesView.Name = "imagesView";
            this.imagesView.Size = new System.Drawing.Size(1211, 574);
            this.imagesView.TabIndex = 0;
            // 
            // openImageDialogBtn
            // 
            this.openImageDialogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openImageDialogBtn.Location = new System.Drawing.Point(12, 638);
            this.openImageDialogBtn.Name = "openImageDialogBtn";
            this.openImageDialogBtn.Size = new System.Drawing.Size(309, 143);
            this.openImageDialogBtn.TabIndex = 0;
            this.openImageDialogBtn.Text = "Open Image";
            this.openImageDialogBtn.UseVisualStyleBackColor = true;
            this.openImageDialogBtn.Click += new System.EventHandler(this.openImageDialogBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.openFileDialog1.Multiselect = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images:";
            // 
            // processBtn
            // 
            this.processBtn.Enabled = false;
            this.processBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processBtn.Location = new System.Drawing.Point(327, 638);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(346, 143);
            this.processBtn.TabIndex = 0;
            this.processBtn.Text = "Process";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 793);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openImageDialogBtn);
            this.Controls.Add(this.imagesView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel imagesView;
        private System.Windows.Forms.Button openImageDialogBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button processBtn;
    }
}

