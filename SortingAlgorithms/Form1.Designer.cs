namespace SortingAlgorithms
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bubble = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Insertion = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1333, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // Bubble
            // 
            this.Bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Bubble.Location = new System.Drawing.Point(629, 243);
            this.Bubble.Margin = new System.Windows.Forms.Padding(4);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(123, 52);
            this.Bubble.TabIndex = 3;
            this.Bubble.Text = "Bubble Sort";
            this.Bubble.UseVisualStyleBackColor = true;
            this.Bubble.Click += new System.EventHandler(this.Bubble_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Insertion
            // 
            this.Insertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Insertion.Location = new System.Drawing.Point(629, 303);
            this.Insertion.Margin = new System.Windows.Forms.Padding(4);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(123, 52);
            this.Insertion.TabIndex = 5;
            this.Insertion.Text = "Insertion Sort";
            this.Insertion.UseVisualStyleBackColor = true;
            this.Insertion.Click += new System.EventHandler(this.Insertion_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Reset.Location = new System.Drawing.Point(152, 243);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(345, 288);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset array";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Selection
            // 
            this.Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Selection.Location = new System.Drawing.Point(629, 363);
            this.Selection.Margin = new System.Windows.Forms.Padding(4);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(123, 52);
            this.Selection.TabIndex = 7;
            this.Selection.Text = "Selection Sort";
            this.Selection.UseVisualStyleBackColor = true;
            this.Selection.Click += new System.EventHandler(this.Selection_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MergeSortButton.Location = new System.Drawing.Point(629, 423);
            this.MergeSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(123, 52);
            this.MergeSortButton.TabIndex = 8;
            this.MergeSortButton.Text = "Merge Sort";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuickSortButton.Location = new System.Drawing.Point(629, 483);
            this.QuickSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(123, 52);
            this.QuickSortButton.TabIndex = 9;
            this.QuickSortButton.Text = "QuickSort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(600, 184);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(952, 590);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Bubble);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sorting Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bubble;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Insertion;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Selection;
        private System.Windows.Forms.Button MergeSortButton;
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

