using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Properties;

internal sealed class DiagnosticReportDialog : Form0
{
	private sealed class Class39
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs8 eventArgs8_0;

		internal void method_0()
		{
			form34_0.method_12(object_0, eventArgs8_0);
		}
	}

	private sealed class Class40
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs9 eventArgs9_0;

		internal void method_0()
		{
			form34_0.method_14(object_0, eventArgs9_0);
		}
	}

	private sealed class Class41
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs10 eventArgs10_0;

		internal void method_0()
		{
			form34_0.method_15(object_0, eventArgs10_0);
		}
	}

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private PictureBox pictureBox_0;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_1;

	private Class62 class62_1;

	private Class62 class62_2;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private Class62 class62_3;

	private TextBox textBox_3;

	private Class62 class62_4;

	private bool Boolean_0
	{
		get
		{
			if (!string.IsNullOrEmpty(textBox_1.Text) && !string.IsNullOrEmpty(textBox_2.Text))
			{
				return !string.IsNullOrEmpty(textBox_3.Text);
			}
			return false;
		}
	}

	public DiagnosticReportDialog()
		: base(new Size(700, 620))
	{
		InitializeComponent();
		vmethod_1();
		method_16();
		method_17();
		base.Shown += Form34_Shown;
	}

	private void method_11()
	{
		Class89.eventHandler_3 = (EventHandler<EventArgs8>)Delegate.Combine(Class89.eventHandler_3, new EventHandler<EventArgs8>(method_12));
		Class89.smethod_21();
		method_18(bool_0: true);
	}

	private void method_12(object sender, EventArgs8 e)
	{
		Class39 @class = new Class39();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs8_0 = e;
		Class89.eventHandler_3 = (EventHandler<EventArgs8>)Delegate.Remove(Class89.eventHandler_3, new EventHandler<EventArgs8>(method_12));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_18(bool_0: false);
		textBox_0.Text = @class.eventArgs8_0.class141_0.string_2;
	}

	private void method_13(string string_0, string string_1, string string_2)
	{
		Class89.eventHandler_4 = (EventHandler<EventArgs9>)Delegate.Combine(Class89.eventHandler_4, new EventHandler<EventArgs9>(method_14));
		Class89.eventHandler_5 = (EventHandler<EventArgs10>)Delegate.Combine(Class89.eventHandler_5, new EventHandler<EventArgs10>(method_15));
		Class89.smethod_22(new Class141
		{
			Name = string_0,
			string_0 = string_1,
			string_1 = string_2,
			string_2 = textBox_0.Text
		});
		textBox_0.Clear();
		method_18(bool_0: true);
	}

	private void method_14(object sender, EventArgs9 e)
	{
		Class40 @class = new Class40();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs9_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			textBox_0.AppendText(@class.eventArgs9_0.string_0);
		}
	}

	private void method_15(object sender, EventArgs10 e)
	{
		Class41 @class = new Class41();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs10_0 = e;
		Class89.eventHandler_4 = (EventHandler<EventArgs9>)Delegate.Remove(Class89.eventHandler_4, new EventHandler<EventArgs9>(method_14));
		Class89.eventHandler_5 = (EventHandler<EventArgs10>)Delegate.Remove(Class89.eventHandler_5, new EventHandler<EventArgs10>(method_15));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_18(bool_0: false);
		if (@class.eventArgs10_0.bool_0)
		{
			Thread.Sleep(2000);
			method_8(DialogResult.OK);
		}
	}

	private void method_16()
	{
		class62_1.Text = string.Format(class62_1.Text, "RdpGuard");
		textBox_0"Loading data...";
		class66_0.Enabled = Boolean_0;
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_25_dark : Resources.wait_25);
	}

	private void method_17()
	{
		textBox_1.TextChanged += textBox_1_TextChanged;
		textBox_2.TextChanged += textBox_2_TextChanged;
		textBox_3.TextChanged += textBox_3_TextChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_18(bool bool_0)
	{
		pictureBox_0.Visible = bool_0;
		class66_0.Enabled = !bool_0 && Boolean_0;
		class62_2.Enabled = !bool_0;
		textBox_1.Enabled = !bool_0;
		class62_3.Enabled = !bool_0;
		textBox_2.Enabled = !bool_0;
		class62_4.Enabled = !bool_0;
		textBox_3.Enabled = !bool_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.class66_0 = new Class66();
            this.class66_1 = new Class66();
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.gcontrol0_0 = new GControl0();
            this.class62_0 = new Class62();
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.class62_1 = new Class62();
            this.class62_2 = new Class62();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.class62_3 = new Class62();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.class62_4 = new Class62();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_0.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_0.Location = new System.Drawing.Point(16, 98);
            this.textBox_0.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_0.Multiline = true;
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.ReadOnly = true;
            this.textBox_0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_0.Size = new System.Drawing.Size(665, 308);
            this.textBox_0.TabIndex = 0;
            this.textBox_0.WordWrap = false;
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.Enabled = false;
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.opts_16;
            this.class66_0.Location = new System.Drawing.Point(471, 542);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 20;
            this.class66_0"Send";
            this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_0.UseVisualStyleBackColor = false;
            // 
            // class66_1
            // 
            this.class66_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_1.Image = global::Properties.Resources.cancl_16;
            this.class66_1.Location = new System.Drawing.Point(579, 542);
            this.class66_1.Margin = new System.Windows.Forms.Padding(4);
            this.class66_1.Name = "class66_1";
            this.class66_1.Size = new System.Drawing.Size(100, 36);
            this.class66_1.TabIndex = 21;
            this.class66_1.Text = "Отмена";
            this.class66_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_1.UseVisualStyleBackColor = false;
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Location = new System.Drawing.Point(440, 549);
            this.pictureBox_0.Name = "pictureBox_0";
            this.pictureBox_0.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_0.TabIndex = 46;
            this.pictureBox_0.TabStop = false;
            this.pictureBox_0.Visible = false;
            // 
            // gcontrol0_0
            // 
            this.gcontrol0_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcontrol0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gcontrol0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gcontrol0_0.Location = new System.Drawing.Point(16, 81);
            this.gcontrol0_0.Name = "gcontrol0_0";
            this.gcontrol0_0.Size = new System.Drawing.Size(664, 2);
            this.gcontrol0_0.TabIndex = 50;
            this.gcontrol0_0.TabStop = false;
            // 
            // class62_0
            // 
            this.class62_0.AutoSize = true;
            this.class62_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_0.Boolean_0 = false;
            this.class62_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class62_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_0.Location = new System.Drawing.Point(79, 15);
            this.class62_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_0.Name = "class62_0";
            this.class62_0.Size = new System.Drawing.Size(132, 16);
            this.class62_0.TabIndex = 49;
            this.class62_0"Diagnostic Report";
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_1.Image = global::Properties.Resources.diagnostics_48;
            this.pictureBox_1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_1.TabIndex = 47;
            this.pictureBox_1.TabStop = false;
            // 
            // class62_1
            // 
            this.class62_1.AutoSize = true;
            this.class62_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_1.Boolean_0 = false;
            this.class62_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_1.Location = new System.Drawing.Point(79, 47);
            this.class62_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_1.Name = "class62_1";
            this.class62_1.Size = new System.Drawing.Size(403, 16);
            this.class62_1.TabIndex = 48;
            this.class62_1"Please send us diagnostic report if you have any problems with {0}.";
            // 
            // class62_2
            // 
            this.class62_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class62_2.AutoSize = true;
            this.class62_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_2.Boolean_0 = false;
            this.class62_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_2.Location = new System.Drawing.Point(13, 421);
            this.class62_2.Name = "class62_2";
            this.class62_2.Size = new System.Drawing.Size(75, 16);
            this.class62_2.TabIndex = 51;
            this.class62_2"Your name:";
            // 
            // textBox_1
            // 
            this.textBox_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_1.Location = new System.Drawing.Point(25, 440);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(247, 22);
            this.textBox_1.TabIndex = 52;
            // 
            // textBox_2
            // 
            this.textBox_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_2.Location = new System.Drawing.Point(25, 498);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(247, 22);
            this.textBox_2.TabIndex = 54;
            // 
            // class62_3
            // 
            this.class62_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class62_3.AutoSize = true;
            this.class62_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_3.Boolean_0 = false;
            this.class62_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_3.Location = new System.Drawing.Point(13, 479);
            this.class62_3.Name = "class62_3";
            this.class62_3.Size = new System.Drawing.Size(74, 16);
            this.class62_3.TabIndex = 53;
            this.class62_3"Your email:";
            // 
            // textBox_3
            // 
            this.textBox_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBox_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_3.Location = new System.Drawing.Point(291, 440);
            this.textBox_3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_3.MaxLength = 2048;
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_3.Size = new System.Drawing.Size(389, 80);
            this.textBox_3.TabIndex = 55;
            // 
            // class62_4
            // 
            this.class62_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class62_4.AutoSize = true;
            this.class62_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_4.Boolean_0 = false;
            this.class62_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_4.Location = new System.Drawing.Point(279, 421);
            this.class62_4.Name = "class62_4";
            this.class62_4.Size = new System.Drawing.Size(130, 16);
            this.class62_4.TabIndex = 56;
            this.class62_4"Problem description:";
            // 
            // DiagnosticReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.class62_4);
            this.Controls.Add(this.textBox_3);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.class62_3);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.class62_2);
            this.Controls.Add(this.gcontrol0_0);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.pictureBox_1);
            this.Controls.Add(this.pictureBox_0);
            this.Controls.Add(this.class66_0);
            this.Controls.Add(this.class66_1);
            this.Controls.Add(this.textBox_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DiagnosticReportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this"Diagnostic Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void Form34_Shown(object sender, EventArgs e)
	{
		method_11();
	}

	private void textBox_1_TextChanged(object sender, EventArgs e)
	{
		class66_0.Enabled = Boolean_0;
	}

	private void textBox_2_TextChanged(object sender, EventArgs e)
	{
		class66_0.Enabled = Boolean_0;
	}

	private void textBox_3_TextChanged(object sender, EventArgs e)
	{
		class66_0.Enabled = Boolean_0;
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_13(textBox_1.Text, textBox_2.Text, textBox_3.Text);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
