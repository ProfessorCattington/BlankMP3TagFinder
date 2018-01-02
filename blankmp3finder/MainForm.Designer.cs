namespace blankmp3finder
{
    partial class MainForm
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
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.blankButton = new System.Windows.Forms.Button();
            this.searchProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Location = new System.Drawing.Point(12, 25);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(266, 20);
            this.sourcePathTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(284, 17);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(93, 35);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(51, 22);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add a blank space to the comment field for each file";
            // 
            // blankButton
            // 
            this.blankButton.Location = new System.Drawing.Point(17, 504);
            this.blankButton.Name = "blankButton";
            this.blankButton.Size = new System.Drawing.Size(58, 21);
            this.blankButton.TabIndex = 6;
            this.blankButton.Text = "Blank";
            this.blankButton.UseVisualStyleBackColor = true;
            this.blankButton.Click += new System.EventHandler(this.blankButton_Click);
            // 
            // searchProgress
            // 
            this.searchProgress.Location = new System.Drawing.Point(83, 79);
            this.searchProgress.Name = "searchProgress";
            this.searchProgress.Size = new System.Drawing.Size(460, 21);
            this.searchProgress.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 531);
            this.Controls.Add(this.searchProgress);
            this.Controls.Add(this.blankButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button blankButton;
        private System.Windows.Forms.ProgressBar searchProgress;
    }
}

