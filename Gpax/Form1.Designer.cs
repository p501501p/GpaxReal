namespace Gpax
{
    partial class Form1
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
            TBGpa = new TextBox();
            BTAdd = new Button();
            TBGpax = new TextBox();
            TBMin = new TextBox();
            TBMax = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // TBGpa
            // 
            TBGpa.Location = new Point(188, 87);
            TBGpa.Name = "TBGpa";
            TBGpa.Size = new Size(100, 23);
            TBGpa.TabIndex = 0;
            // 
            // BTAdd
            // 
            BTAdd.Location = new Point(294, 87);
            BTAdd.Name = "BTAdd";
            BTAdd.Size = new Size(52, 110);
            BTAdd.TabIndex = 1;
            BTAdd.Text = "ADD";
            BTAdd.UseVisualStyleBackColor = true;
            BTAdd.Click += button1_Click;
            // 
            // TBGpax
            // 
            TBGpax.Location = new Point(188, 116);
            TBGpax.Name = "TBGpax";
            TBGpax.Size = new Size(100, 23);
            TBGpax.TabIndex = 2;
            // 
            // TBMin
            // 
            TBMin.Location = new Point(188, 174);
            TBMin.Name = "TBMin";
            TBMin.Size = new Size(100, 23);
            TBMin.TabIndex = 4;
            // 
            // TBMax
            // 
            TBMax.Location = new Point(188, 145);
            TBMax.Name = "TBMax";
            TBMax.Size = new Size(100, 23);
            TBMax.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 95);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 5;
            label1.Text = "GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 124);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "GPAX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 182);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 8;
            label3.Text = "MIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 153);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "MAX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBMin);
            Controls.Add(TBMax);
            Controls.Add(TBGpax);
            Controls.Add(BTAdd);
            Controls.Add(TBGpa);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBGpa;
        private Button BTAdd;
        private TextBox TBGpax;
        private TextBox TBMin;
        private TextBox TBMax;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
