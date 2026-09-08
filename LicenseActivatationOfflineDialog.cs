using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class LicenseActivatationOfflineDialog : Form0
{
	private sealed class Class15
	{
		public LicenseActivatationOfflineDialog form10_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form10_0.InitializeComponents(object_0, eventArgs11_0);
		}
	}

	private sealed class Class16
	{
		public LicenseActivatationOfflineDialog form10_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form10_0.ValidateInput(object_0, eventArgs11_0);
		}
	}

	public Class146 class146_0;

	private string string_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private TextBox textBox_0;

	public Label label_0;

	private GControl0 gcontrol0_0;

	private Class62 class62_2;

	private Class62 class62_3;

	private TextBox textBox_1;

	private GClass3 gclass3_0;

	private Class62 class62_4;

	private TextBox textBox_2;

	public Label label_1;

	private GClass3 gclass3_1;

	private GClass3 gclass3_2;

	public LicenseActivatationOfflineDialog()
		: base(new Size(583, 757))
	{
		SaveSettings();
		vmethod_1();
		OnButtonOk();
		OnButtonCancel();
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponents));
		Class89.smethod_10();
	}

	private void InitializeComponents(object sender, EventArgs11 e)
	{
		Class15 @class = new Class15();
		@class.form10_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponents));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			string_0 = @class.eventArgs11_0.class146_0.string_0;
		}
	}

	public void OnButtonOk()
	{
		class62_0.Text = "Use this dialog to activate RdpGuard if you unable to use online activation";
	}

	public void OnButtonCancel()
	{
		textBox_0.TextChanged += textBox_0_TextChanged;
		gclass3_1.Click += gclass3_1_Click;
		textBox_2.TextChanged += textBox_2_TextChanged;
		gclass3_2.Click += gclass3_2_Click;
		gclass3_0.LinkClicked += gclass3_0_LinkClicked;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void OnLoad(string string_1)
	{
		MessageBox.Show("Unable to activate the license on this computer. " + string_1, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	private void ValidateInput(object sender, EventArgs11 e)
	{
		Class16 @class = new Class16();
		@class.form10_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_8 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_8, new EventHandler<EventArgs11>(ValidateInput));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		class146_0 = @class.eventArgs11_0.class146_0;
		method_8(DialogResult.OK);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void SaveSettings()
	{
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		class66_0 = new Class66();
		class66_1 = new Class66();
		textBox_0 = new TextBox();
		label_0 = new Class62();
		gcontrol0_0 = new GControl0();
		class62_2 = new Class62();
		class62_3 = new Class62();
		textBox_1 = new TextBox();
		gclass3_0 = new GClass3();
		class62_4 = new Class62();
		textBox_2 = new TextBox();
		label_1 = new Class62();
		gclass3_1 = new GClass3();
		gclass3_2 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Image = Resources.activate_pro_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "pictureBox1";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(421, 16);
		class62_0.TabIndex = 4;
		class62_0.Text = "Use this dialog to activate {0} Pro if you unable to use online activation";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(124, 16);
		class62_1.TabIndex = 14;
		class62_1.Text = "Offline Activation";
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Enabled = false;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(324, 663);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnActivate";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 1;
		class66_0.Text = "Activate";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(432, 663);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 2;
		class66_1.Text = "Cancel";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(33, 123);
		textBox_0.Margin = new Padding(4);
		textBox_0.Name = "m_edActivationKey";
		textBox_0.Size = new Size(496, 22);
		textBox_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Location = new Point(13, 97);
		label_0.Margin = new Padding(4, 0, 4, 0);
		label_0.Name = "m_lblActivationKey";
		label_0.Size = new Size(171, 16);
		label_0.TabIndex = 15;
		label_0.Text = "1. Enter your Activation Key:";
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(513, 2);
		gcontrol0_0.TabIndex = 36;
		gcontrol0_0.TabStop = false;
		class62_2.AutoSize = true;
		class62_2.ForeColor = SystemColors.ControlDarkDark;
		class62_2.Location = new Point(30, 150);
		class62_2.Name = "label2";
		class62_2.Size = new Size(334, 16);
		class62_2.TabIndex = 97;
		class62_2.Text = "Enter your Activation Key from order confirmation e-mail";
		class62_3.AutoSize = true;
		class62_3.ForeColor = SystemColors.ControlDarkDark;
		class62_3.Location = new Point(30, 396);
		class62_3.Name = "label1";
		class62_3.Size = new Size(221, 16);
		class62_3.TabIndex = 100;
		class62_3.Text = "Send us the text from the field above";
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(33, 213);
		textBox_1.Margin = new Padding(4);
		textBox_1.Multiline = true;
		textBox_1.Name = "m_edActivationRequest";
		textBox_1.ReadOnly = true;
		textBox_1.ScrollBars = ScrollBars.Both;
		textBox_1.Size = new Size(496, 178);
		textBox_1.TabIndex = 98;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(13, 187);
		gclass3_0.Name = "m_lnkContactUs";
		gclass3_0.Size = new Size(185, 16);
		gclass3_0.TabIndex = 101;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "2. Send us Activation Request";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_4.AutoSize = true;
		class62_4.ForeColor = SystemColors.ControlDarkDark;
		class62_4.Location = new Point(30, 642);
		class62_4.Name = "label3";
		class62_4.Size = new Size(293, 16);
		class62_4.TabIndex = 103;
		class62_4.Text = "Paste the Activation Response received from us";
		textBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_2.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox_2.Location = new Point(33, 459);
		textBox_2.Margin = new Padding(4);
		textBox_2.Multiline = true;
		textBox_2.Name = "m_edActivationResponse";
		textBox_2.ScrollBars = ScrollBars.Both;
		textBox_2.Size = new Size(496, 178);
		textBox_2.TabIndex = 102;
		label_1.AutoSize = true;
		label_1.Location = new Point(13, 433);
		label_1.Margin = new Padding(4, 0, 4, 0);
		label_1.Name = "label4";
		label_1.Size = new Size(182, 16);
		label_1.TabIndex = 104;
		label_1.Text = "3. Enter Activation Response:";
		gclass3_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(491, 187);
		gclass3_1.Name = "m_lnkCopy";
		gclass3_1.Size = new Size(38, 16);
		gclass3_1.TabIndex = 105;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "copy";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_2.AutoSize = true;
		gclass3_2.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_2.Location = new Point(487, 433);
		gclass3_2.Name = "m_lnkPaste";
		gclass3_2.Size = new Size(42, 16);
		gclass3_2.TabIndex = 106;
		gclass3_2.TabStop = true;
		gclass3_2.Text = "paste";
		gclass3_2.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(542, 712);
		base.Controls.Add(gclass3_2);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(label_1);
		base.Controls.Add(class62_4);
		base.Controls.Add(textBox_2);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(class62_3);
		base.Controls.Add(textBox_1);
		base.Controls.Add(class62_2);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(textBox_0);
		base.Controls.Add(label_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "LicenseActivatationOfflineDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Offline Activation";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		GClass31 gClass = new GClass31(GClass32.Get(textBox_0.Text), null, null, string_0, "10.2.1", 5250827023818041824L);
		textBox_1.Text = gClass.Serialize(3);
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(textBox_1.Text))
		{
			Class77.smethod_0(textBox_1.Text);
		}
		textBox_1.SelectAll();
	}

	private void textBox_2_TextChanged(object sender, EventArgs e)
	{
		class66_0.Enabled = !string.IsNullOrEmpty(textBox_2.Text);
	}

	private void gclass3_2_Click(object sender, EventArgs e)
	{
		textBox_2.Text = Class77.smethod_1();
	}

	private void gclass3_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		method_9(Class148.String_1);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		GClass31 gClass = null;
		try
		{
			gClass = GClass31.smethod_0(textBox_2.Text, 3);
		}
		catch
		{
			OnLoad("Unable to decode Activation Response.");
			return;
		}
		if (!(gClass.string_5 != "10.2.1") && gClass.long_0 == 5250827023818041824L)
		{
			if (string_0 == gClass.string_4)
			{
				Class89.eventHandler_8 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_8, new EventHandler<EventArgs11>(ValidateInput));
				Class89.smethod_12(gClass);
			}
			else
			{
				OnLoad("Activation Request and Activation Response are valid within one PC.");
			}
		}
		else
		{
			OnLoad("Activation Response is valid for RdpGuard version " + gClass.string_5 + " only.");
		}
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
