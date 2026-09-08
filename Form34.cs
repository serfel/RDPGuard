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
		method_19();
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
		textBox_0.Text = "Loading data...";
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

	private void method_19()
	{
		new ComponentResourceManager(typeof(DiagnosticReportDialog));
		textBox_0 = new TextBox();
		class66_0 = new Class66();
		class66_1 = new Class66();
		pictureBox_0 = new PictureBox();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_1 = new PictureBox();
		class62_1 = new Class62();
		class62_2 = new Class62();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		class62_3 = new Class62();
		textBox_3 = new TextBox();
		class62_4 = new Class62();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		SuspendLayout();
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		textBox_0.Location = new Point(16, 98);
		textBox_0.Margin = new Padding(5, 4, 5, 4);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_txtDiagnosticReport";
		textBox_0.ReadOnly = true;
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(665, 308);
		textBox_0.TabIndex = 0;
		textBox_0.WordWrap = false;
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Enabled = false;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(471, 542);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSend";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 20;
		class66_0.Text = "Send";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(579, 542);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 21;
		class66_1.Text = "Cancel";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(440, 549);
		pictureBox_0.Name = "picWait";
		pictureBox_0.Size = new Size(25, 25);
		pictureBox_0.TabIndex = 46;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(664, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(133, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Diagnostic Report";
		pictureBox_1.Image = Resources.diagnostics_48;
		pictureBox_1.Location = new Point(16, 15);
		pictureBox_1.Margin = new Padding(4);
		pictureBox_1.Name = "imgBigIcon";
		pictureBox_1.Size = new Size(48, 48);
		pictureBox_1.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_1.TabIndex = 47;
		pictureBox_1.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(404, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Please send us diagnostic report if you have any problems with {0}.";
		class62_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 421);
		class62_2.Name = "m_lblName";
		class62_2.Size = new Size(76, 16);
		class62_2.TabIndex = 51;
		class62_2.Text = "Your name:";
		textBox_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		textBox_1.Location = new Point(25, 440);
		textBox_1.Name = "m_edName";
		textBox_1.Size = new Size(247, 22);
		textBox_1.TabIndex = 52;
		textBox_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		textBox_2.Location = new Point(25, 498);
		textBox_2.Name = "m_edEmail";
		textBox_2.Size = new Size(247, 22);
		textBox_2.TabIndex = 54;
		class62_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_3.AutoSize = true;
		class62_3.Location = new Point(13, 479);
		class62_3.Name = "m_lblEmail";
		class62_3.Size = new Size(75, 16);
		class62_3.TabIndex = 53;
		class62_3.Text = "Your email:";
		textBox_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_3.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		textBox_3.Location = new Point(291, 440);
		textBox_3.Margin = new Padding(5, 4, 5, 4);
		textBox_3.MaxLength = 2048;
		textBox_3.Multiline = true;
		textBox_3.Name = "m_edDescription";
		textBox_3.ScrollBars = ScrollBars.Both;
		textBox_3.Size = new Size(389, 80);
		textBox_3.TabIndex = 55;
		class62_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_4.AutoSize = true;
		class62_4.Location = new Point(279, 421);
		class62_4.Name = "m_lblDescription";
		class62_4.Size = new Size(131, 16);
		class62_4.TabIndex = 56;
		class62_4.Text = "Problem description:";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(692, 591);
		base.Controls.Add(class62_4);
		base.Controls.Add(textBox_3);
		base.Controls.Add(textBox_2);
		base.Controls.Add(class62_3);
		base.Controls.Add(textBox_1);
		base.Controls.Add(class62_2);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(textBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "DiagnosticReportDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Diagnostic Report";
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
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
