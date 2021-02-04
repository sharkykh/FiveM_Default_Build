namespace FiveM_Default_Build
{
    partial class MainForm
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
            this.radioBuildDefault = new System.Windows.Forms.RadioButton();
            this.radioBuild2060 = new System.Windows.Forms.RadioButton();
            this.radioBuild2189 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ToggleButton
            // 
            this.ToggleButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToggleButton.Location = new System.Drawing.Point(133, 51);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(91, 63);
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
            // radioBuildDefault
            // 
            this.radioBuildDefault.AutoSize = true;
            this.radioBuildDefault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuildDefault.Location = new System.Drawing.Point(26, 42);
            this.radioBuildDefault.Name = "radioBuildDefault";
            this.radioBuildDefault.Size = new System.Drawing.Size(78, 25);
            this.radioBuildDefault.TabIndex = 2;
            this.radioBuildDefault.TabStop = true;
            this.radioBuildDefault.Tag = "Default";
            this.radioBuildDefault.Text = "Default";
            this.radioBuildDefault.UseVisualStyleBackColor = true;
            // 
            // radioBuild2060
            // 
            this.radioBuild2060.AutoSize = true;
            this.radioBuild2060.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuild2060.Location = new System.Drawing.Point(26, 71);
            this.radioBuild2060.Name = "radioBuild2060";
            this.radioBuild2060.Size = new System.Drawing.Size(73, 25);
            this.radioBuild2060.TabIndex = 2;
            this.radioBuild2060.TabStop = true;
            this.radioBuild2060.Tag = "2060";
            this.radioBuild2060.Text = "b2060";
            this.radioBuild2060.UseVisualStyleBackColor = true;
            // 
            // radioBuild2189
            // 
            this.radioBuild2189.AutoSize = true;
            this.radioBuild2189.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBuild2189.Location = new System.Drawing.Point(26, 102);
            this.radioBuild2189.Name = "radioBuild2189";
            this.radioBuild2189.Size = new System.Drawing.Size(73, 25);
            this.radioBuild2189.TabIndex = 2;
            this.radioBuild2189.TabStop = true;
            this.radioBuild2189.Tag = "2189";
            this.radioBuild2189.Text = "b2189";
            this.radioBuild2189.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 135);
            this.Controls.Add(this.radioBuild2189);
            this.Controls.Add(this.radioBuild2060);
            this.Controls.Add(this.radioBuildDefault);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ToggleButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(263, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(263, 174);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveM Default Build";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.RadioButton radioBuildDefault;
        private System.Windows.Forms.RadioButton radioBuild2060;
        private System.Windows.Forms.RadioButton radioBuild2189;
    }
}

