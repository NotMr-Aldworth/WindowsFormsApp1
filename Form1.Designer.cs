namespace WindowsFormsApp1
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
            this.btn1submit = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1submit
            // 
            this.btn1submit.Location = new System.Drawing.Point(15, 29);
            this.btn1submit.Name = "btn1submit";
            this.btn1submit.Size = new System.Drawing.Size(79, 34);
            this.btn1submit.TabIndex = 0;
            this.btn1submit.Text = "Click Me";
            this.btn1submit.UseVisualStyleBackColor = true;
            this.btn1submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(119, 40);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(50, 13);
            this.lblmessage.TabIndex = 1;
            this.lblmessage.Text = "Message";
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Location = new System.Drawing.Point(12, 9);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(84, 13);
            this.lblinstruction.TabIndex = 2;
            this.lblinstruction.Text = "Enter your name";
            this.lblinstruction.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(95, 3);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.lblinstruction);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btn1submit);
            this.Name = "Form1";
            this.Text = "GettingInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1submit;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lblinstruction;
        private System.Windows.Forms.TextBox txtinput;
    }
}

