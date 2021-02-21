namespace FiveM_Default_Build
{
    partial class SavedBuildNumberForm
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
            this.ToggleButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.radioBuildUnset = new System.Windows.Forms.RadioButton();
            this.radioBuild1604 = new System.Windows.Forms.RadioButton();
            this.radioBuild2060 = new System.Windows.Forms.RadioButton();
            this.radioBuild2189 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ToggleButton
            // 
            this.ToggleButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToggleButton.Location = new System.Drawing.Point(133, 47);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(91, 102);
            this.ToggleButton.TabIndex = 0;
            this.ToggleButton.Text = "Set";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(8, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(238, 30);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Set FiveM default build:";
            // 
            // radioBuildUnset
            // 
            this.radioBuildUnset.AutoSize = true;
            this.radioBuildUnset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuildUnset.Location = new System.Drawing.Point(26, 42);
            this.radioBuildUnset.Name = "radioBuildUnset";
            this.radioBuildUnset.Size = new System.Drawing.Size(68, 25);
            this.radioBuildUnset.TabIndex = 2;
            this.radioBuildUnset.TabStop = true;
            this.radioBuildUnset.Tag = "Unset";
            this.radioBuildUnset.Text = "Unset";
            this.radioBuildUnset.UseVisualStyleBackColor = true;
            // 
            // radioBuild1604
            // 
            this.radioBuild1604.AutoSize = true;
            this.radioBuild1604.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuild1604.Location = new System.Drawing.Point(26, 69);
            this.radioBuild1604.Name = "radioBuild1604";
            this.radioBuild1604.Size = new System.Drawing.Size(73, 25);
            this.radioBuild1604.TabIndex = 3;
            this.radioBuild1604.TabStop = true;
            this.radioBuild1604.Tag = "1604";
            this.radioBuild1604.Text = "b1604";
            this.radioBuild1604.UseVisualStyleBackColor = true;
            // 
            // radioBuild2060
            // 
            this.radioBuild2060.AutoSize = true;
            this.radioBuild2060.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuild2060.Location = new System.Drawing.Point(26, 97);
            this.radioBuild2060.Name = "radioBuild2060";
            this.radioBuild2060.Size = new System.Drawing.Size(73, 25);
            this.radioBuild2060.TabIndex = 4;
            this.radioBuild2060.TabStop = true;
            this.radioBuild2060.Tag = "2060";
            this.radioBuild2060.Text = "b2060";
            this.radioBuild2060.UseVisualStyleBackColor = true;
            // 
            // radioBuild2189
            // 
            this.radioBuild2189.AutoSize = true;
            this.radioBuild2189.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuild2189.Location = new System.Drawing.Point(26, 124);
            this.radioBuild2189.Name = "radioBuild2189";
            this.radioBuild2189.Size = new System.Drawing.Size(73, 25);
            this.radioBuild2189.TabIndex = 5;
            this.radioBuild2189.TabStop = true;
            this.radioBuild2189.Tag = "2189";
            this.radioBuild2189.Text = "b2189";
            this.radioBuild2189.UseVisualStyleBackColor = true;
            // 
            // SavedBuildNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 155);
            this.Controls.Add(this.radioBuild2189);
            this.Controls.Add(this.radioBuild2060);
            this.Controls.Add(this.radioBuild1604);
            this.Controls.Add(this.radioBuildUnset);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ToggleButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(263, 194);
            this.Name = "SavedBuildNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveM Default Build";
            this.Load += new System.EventHandler(this.SavedBuildNumberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.RadioButton radioBuildUnset;
        private System.Windows.Forms.RadioButton radioBuild1604;
        private System.Windows.Forms.RadioButton radioBuild2060;
        private System.Windows.Forms.RadioButton radioBuild2189;
    }
}

