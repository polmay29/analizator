namespace TextAnalyzer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblUniqueWordCount = new System.Windows.Forms.Label();
            this.lblLongestWord = new System.Windows.Forms.Label();
            this.lblShortestWord = new System.Windows.Forms.Label();
            this.lstWordFrequency = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 150);
            this.txtInput.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(12, 168);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Анализировать";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(12, 204);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(0, 13);
            this.lblCharacterCount.TabIndex = 3;
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(12, 217);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(0, 13);
            this.lblWordCount.TabIndex = 4;
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.AutoSize = true;
            this.lblSentenceCount.Location = new System.Drawing.Point(12, 230);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(0, 13);
            this.lblSentenceCount.TabIndex = 5;
            // 
            // lblUniqueWordCount
            // 
            this.lblUniqueWordCount.AutoSize = true;
            this.lblUniqueWordCount.Location = new System.Drawing.Point(12, 243);
            this.lblUniqueWordCount.Name = "lblUniqueWordCount";
            this.lblUniqueWordCount.Size = new System.Drawing.Size(0, 13);
            this.lblUniqueWordCount.TabIndex = 6;
            // 
            // lblLongestWord
            // 
            this.lblLongestWord.AutoSize = true;
            this.lblLongestWord.Location = new System.Drawing.Point(12, 256);
            this.lblLongestWord.Name = "lblLongestWord";
            this.lblLongestWord.Size = new System.Drawing.Size(0, 13);
            this.lblLongestWord.TabIndex = 7;
            // 
            // lblShortestWord
            // 
            this.lblShortestWord.AutoSize = true;
            this.lblShortestWord.Location = new System.Drawing.Point(12, 269);
            this.lblShortestWord.Name = "lblShortestWord";
            this.lblShortestWord.Size = new System.Drawing.Size(0, 13);
            this.lblShortestWord.TabIndex = 8;
            // 
            // lstWordFrequency
            // 
            this.lstWordFrequency.FormattingEnabled = true;
            this.lstWordFrequency.Location = new System.Drawing.Point(12, 285);
            this.lstWordFrequency.Name = "lstWordFrequency";
            this.lstWordFrequency.Size = new System.Drawing.Size(360, 95);
            this.lstWordFrequency.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.lstWordFrequency);
            this.Controls.Add(this.lblShortestWord);
            this.Controls.Add(this.lblLongestWord);
            this.Controls.Add(this.lblUniqueWordCount);
            this.Controls.Add(this.lblSentenceCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Текстовый анализатор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Label lblUniqueWordCount;
        private System.Windows.Forms.Label lblLongestWord;
        private System.Windows.Forms.Label lblShortestWord;
        private System.Windows.Forms.ListBox lstWordFrequency;
    }
}
