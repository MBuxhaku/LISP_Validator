namespace LISP_Validator
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
            this.inputTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearTextBtn = new System.Windows.Forms.Button();
            this.validateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTb
            // 
            this.inputTb.Location = new System.Drawing.Point(35, 67);
            this.inputTb.Name = "inputTb";
            this.inputTb.Size = new System.Drawing.Size(347, 23);
            this.inputTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter LISP code to be validated for paranthesis";
            // 
            // clearTextBtn
            // 
            this.clearTextBtn.Location = new System.Drawing.Point(280, 106);
            this.clearTextBtn.Name = "clearTextBtn";
            this.clearTextBtn.Size = new System.Drawing.Size(75, 23);
            this.clearTextBtn.TabIndex = 2;
            this.clearTextBtn.Text = "Clear Text";
            this.clearTextBtn.UseVisualStyleBackColor = true;
            this.clearTextBtn.Click += new System.EventHandler(this.clearTextBtn_Click);
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(46, 106);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(75, 23);
            this.validateBtn.TabIndex = 3;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.clearTextBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTb);
            this.Name = "Form1";
            this.Text = "Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTb;
        private Label label1;
        private Button clearTextBtn;
        private Button validateBtn;
    }
}