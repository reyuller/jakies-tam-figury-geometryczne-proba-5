namespace jakies_tam_figury_geometryczne_proba_5
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			button1 = new Button();
			sigmabox = new ComboBox();
			fontDialog1 = new FontDialog();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			labelwynikas = new Label();
			label5 = new Label();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(245, 162);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(245, 219);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(446, 218);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 2;
			button1.Text = "połe";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// sigmabox
			// 
			sigmabox.FormattingEnabled = true;
			sigmabox.Location = new Point(417, 162);
			sigmabox.Name = "sigmabox";
			sigmabox.Size = new Size(121, 23);
			sigmabox.TabIndex = 4;
			sigmabox.Tag = "sigma67";
			sigmabox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(277, 136);
			label1.Name = "label1";
			label1.Size = new Size(33, 15);
			label1.TabIndex = 5;
			label1.Text = "bok1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(446, 136);
			label2.Name = "label2";
			label2.Size = new Size(73, 15);
			label2.TabIndex = 6;
			label2.Text = "rodzaj figury";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(277, 197);
			label3.Name = "label3";
			label3.Size = new Size(33, 15);
			label3.TabIndex = 7;
			label3.Text = "bok2";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(291, 267);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 8;
			label4.Text = "wynikas=";
			// 
			// labelwynikas
			// 
			labelwynikas.AutoSize = true;
			labelwynikas.Location = new Point(461, 267);
			labelwynikas.Name = "labelwynikas";
			labelwynikas.Size = new Size(0, 15);
			labelwynikas.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(277, 57);
			label5.Name = "label5";
			label5.Size = new Size(193, 15);
			label5.TabIndex = 10;
			label5.Text = "w przypadku koła 2 bok się nie liczy";
			// 
			// button2
			// 
			button2.Location = new Point(573, 221);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 11;
			button2.Text = "obwód";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(106, 195);
			button3.Name = "button3";
			button3.Size = new Size(115, 23);
			button3.TabIndex = 12;
			button3.Text = "wyczyść liczby";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(label5);
			Controls.Add(labelwynikas);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(sigmabox);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private ComboBox sigmabox;
		private FontDialog fontDialog1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label labelwynikas;
		private Label label5;
		private Button button2;
		private Button button3;
	}
}
