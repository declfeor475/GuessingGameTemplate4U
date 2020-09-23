namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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
            this.guessesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guessesLabel.ForeColor = System.Drawing.Color.White;
            this.guessesLabel.Location = new System.Drawing.Point(26, 95);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(0, 23);
            this.guessesLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "You Got It!";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.orderLabel.ForeColor = System.Drawing.Color.White;
            this.orderLabel.Location = new System.Drawing.Point(26, 174);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(0, 23);
            this.orderLabel.TabIndex = 2;
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sortedLabel.ForeColor = System.Drawing.Color.White;
            this.sortedLabel.Location = new System.Drawing.Point(26, 261);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(0, 23);
            this.sortedLabel.TabIndex = 3;
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessesLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(400, 369);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}
