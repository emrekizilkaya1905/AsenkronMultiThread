namespace TextForAdd
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
			this.btnRead = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.BtnCounter = new System.Windows.Forms.Button();
			this.textBoxCounter = new System.Windows.Forms.TextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(0, 0);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(99, 56);
			this.btnRead.TabIndex = 0;
			this.btnRead.Text = "Dosya Oku";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 118);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(253, 191);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// BtnCounter
			// 
			this.BtnCounter.Location = new System.Drawing.Point(523, 77);
			this.BtnCounter.Name = "BtnCounter";
			this.BtnCounter.Size = new System.Drawing.Size(75, 44);
			this.BtnCounter.TabIndex = 2;
			this.BtnCounter.Text = "Sayac Artir";
			this.BtnCounter.UseVisualStyleBackColor = true;
			this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
			// 
			// textBoxCounter
			// 
			this.textBoxCounter.Location = new System.Drawing.Point(510, 187);
			this.textBoxCounter.Name = "textBoxCounter";
			this.textBoxCounter.Size = new System.Drawing.Size(100, 22);
			this.textBoxCounter.TabIndex = 3;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(839, 139);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(100, 170);
			this.richTextBox2.TabIndex = 4;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1131, 509);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.textBoxCounter);
			this.Controls.Add(this.BtnCounter);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnRead);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button BtnCounter;
		private System.Windows.Forms.TextBox textBoxCounter;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}

