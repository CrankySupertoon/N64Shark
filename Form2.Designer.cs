namespace n64shark
{
	// Token: 0x02000002 RID: 2
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000024CC File Offset: 0x000006CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002504 File Offset: 0x00000704
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(12, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(183, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button1.Location = new global::System.Drawing.Point(201, 25);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(71, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 68);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(260, 44);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(56, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Line editor";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(103, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Decompiled preview";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 121);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(30, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Line:";
			this.textBox2.Enabled = false;
			this.textBox2.Location = new global::System.Drawing.Point(45, 118);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(56, 20);
			this.textBox2.TabIndex = 6;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new global::System.Drawing.Point(154, 118);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(118, 20);
			this.textBox3.TabIndex = 8;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(107, 121);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(41, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "GS file:";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(208, 51);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(64, 17);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Decimal";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 148);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "Form2";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Line editor";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
