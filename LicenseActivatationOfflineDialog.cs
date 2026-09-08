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
			form10_0.InitializeComponent(object_0, eventArgs11_0);
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

	private PictureBox pictureBox1;

	private Class62 mlblSubCaption;

	private Class62 lblCaption;

	private Class66 mbtnActivate;

	private Class66 mbtnCancel;

	private TextBox medActivationKey;

	public Label mlblActivationKey;

	private GControl0 separatorLine1;

	private Class62 label2;

	private Class62 label1;

	private TextBox medActivationRequest;

	private GClass3 mlnkContactUs;

	private Class62 label3;

	private TextBox medActivationResponse;

	public Label label4;

	private GClass3 mlnkCopy;

	private GClass3 mlnkPaste;

	public LicenseActivatationOfflineDialog()
		: base(new Size(583, 757))
	{
		SaveSettings();
		InitializeFormPosition();
		OnButtonOk();
		OnButtonCancel();
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponent));
		Class89.smethod_10();
	}

	private void InitializeComponent(object sender, EventArgs11 e)
	{
		Class15 @class = new Class15();
		@class.form10_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		Class89.eventHandler_11 = (EventHandler<EventArgs11>)Delegate.Remove(Class89.eventHandler_11, new EventHandler<EventArgs11>(InitializeComponent));
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
		mlblSubCaption.Text = "Use this dialog to activate RdpGuard if you unable to use online activation";
	}

	public void OnButtonCancel()
	{
		medActivationKey.TextChanged += medActivationKey_TextChanged;
		mlnkCopy.Click += mlnkCopy_Click;
		medActivationResponse.TextChanged += medActivationResponse_TextChanged;
		mlnkPaste.Click += mlnkPaste_Click;
		mlnkContactUs.LinkClicked += mlnkContactUs_LinkClicked;
		mbtnActivate.Click += mbtnActivate_Click;
		mbtnCancel.Click += mbtnCancel_Click;
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
		CloseDialog(DialogResult.OK);
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
		pictureBox1 = new PictureBox();
		mlblSubCaption = new Class62();
		lblCaption = new Class62();
		mbtnActivate = new Class66();
		mbtnCancel = new Class66();
		medActivationKey = new TextBox();
		mlblActivationKey = new Class62();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		label1 = new Class62();
		medActivationRequest = new TextBox();
		mlnkContactUs = new GClass3();
		label3 = new Class62();
		medActivationResponse = new TextBox();
		label4 = new Class62();
		mlnkCopy = new GClass3();
		mlnkPaste = new GClass3();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		pictureBox1.Image = Resources.activate_pro_48;
		pictureBox1.Location = new Point(16, 15);
		pictureBox1.Margin = new Padding(4);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(48, 48);
		pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 0;
		pictureBox1.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(421, 16);
		mlblSubCaption.TabIndex = 4;
		mlblSubCaption.Text = "Use this dialog to activate {0} Pro if you unable to use online activation";
		lblCaption.AutoSize = true;
		lblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		lblCaption.Location = new Point(79, 15);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(124, 16);
		lblCaption.TabIndex = 14;
		lblCaption.Text = "Offline Activation";
		mbtnActivate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnActivate.Enabled = false;
		mbtnActivate.Image = Resources.opts_16;
		mbtnActivate.Location = new Point(324, 663);
		mbtnActivate.Margin = new Padding(4);
		mbtnActivate.Name = "m_btnActivate";
		mbtnActivate.Size = new Size(100, 36);
		mbtnActivate.TabIndex = 1;
		mbtnActivate.Text = "Activate";
		mbtnActivate.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnActivate.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(432, 663);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 2;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		medActivationKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medActivationKey.Location = new Point(33, 123);
		medActivationKey.Margin = new Padding(4);
		medActivationKey.Name = "m_edActivationKey";
		medActivationKey.Size = new Size(496, 22);
		medActivationKey.TabIndex = 0;
		mlblActivationKey.AutoSize = true;
		mlblActivationKey.Location = new Point(13, 97);
		mlblActivationKey.Margin = new Padding(4, 0, 4, 0);
		mlblActivationKey.Name = "m_lblActivationKey";
		mlblActivationKey.Size = new Size(171, 16);
		mlblActivationKey.TabIndex = 15;
		mlblActivationKey.Text = "1. Enter your Activation Key:";
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(513, 2);
		separatorLine1.TabIndex = 36;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.ForeColor = SystemColors.ControlDarkDark;
		label2.Location = new Point(30, 150);
		label2.Name = "label2";
		label2.Size = new Size(334, 16);
		label2.TabIndex = 97;
		label2.Text = "Enter your Activation Key from order confirmation e-mail";
		label1.AutoSize = true;
		label1.ForeColor = SystemColors.ControlDarkDark;
		label1.Location = new Point(30, 396);
		label1.Name = "label1";
		label1.Size = new Size(221, 16);
		label1.TabIndex = 100;
		label1.Text = "Send us the text from the field above";
		medActivationRequest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medActivationRequest.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		medActivationRequest.Location = new Point(33, 213);
		medActivationRequest.Margin = new Padding(4);
		medActivationRequest.Multiline = true;
		medActivationRequest.Name = "m_edActivationRequest";
		medActivationRequest.ReadOnly = true;
		medActivationRequest.ScrollBars = ScrollBars.Both;
		medActivationRequest.Size = new Size(496, 178);
		medActivationRequest.TabIndex = 98;
		mlnkContactUs.AutoSize = true;
		mlnkContactUs.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkContactUs.Location = new Point(13, 187);
		mlnkContactUs.Name = "m_lnkContactUs";
		mlnkContactUs.Size = new Size(185, 16);
		mlnkContactUs.TabIndex = 101;
		mlnkContactUs.TabStop = true;
		mlnkContactUs.Text = "2. Send us Activation Request";
		mlnkContactUs.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		label3.AutoSize = true;
		label3.ForeColor = SystemColors.ControlDarkDark;
		label3.Location = new Point(30, 642);
		label3.Name = "label3";
		label3.Size = new Size(293, 16);
		label3.TabIndex = 103;
		label3.Text = "Paste the Activation Response received from us";
		medActivationResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medActivationResponse.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		medActivationResponse.Location = new Point(33, 459);
		medActivationResponse.Margin = new Padding(4);
		medActivationResponse.Multiline = true;
		medActivationResponse.Name = "m_edActivationResponse";
		medActivationResponse.ScrollBars = ScrollBars.Both;
		medActivationResponse.Size = new Size(496, 178);
		medActivationResponse.TabIndex = 102;
		label4.AutoSize = true;
		label4.Location = new Point(13, 433);
		label4.Margin = new Padding(4, 0, 4, 0);
		label4.Name = "label4";
		label4.Size = new Size(182, 16);
		label4.TabIndex = 104;
		label4.Text = "3. Enter Activation Response:";
		mlnkCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkCopy.AutoSize = true;
		mlnkCopy.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkCopy.Location = new Point(491, 187);
		mlnkCopy.Name = "m_lnkCopy";
		mlnkCopy.Size = new Size(38, 16);
		mlnkCopy.TabIndex = 105;
		mlnkCopy.TabStop = true;
		mlnkCopy.Text = "copy";
		mlnkCopy.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlnkPaste.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkPaste.AutoSize = true;
		mlnkPaste.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkPaste.Location = new Point(487, 433);
		mlnkPaste.Name = "m_lnkPaste";
		mlnkPaste.Size = new Size(42, 16);
		mlnkPaste.TabIndex = 106;
		mlnkPaste.TabStop = true;
		mlnkPaste.Text = "paste";
		mlnkPaste.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(542, 712);
		base.Controls.Add(mlnkPaste);
		base.Controls.Add(mlnkCopy);
		base.Controls.Add(label4);
		base.Controls.Add(label3);
		base.Controls.Add(medActivationResponse);
		base.Controls.Add(mlnkContactUs);
		base.Controls.Add(label1);
		base.Controls.Add(medActivationRequest);
		base.Controls.Add(label2);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mbtnActivate);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(medActivationKey);
		base.Controls.Add(mlblActivationKey);
		base.Controls.Add(lblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(pictureBox1);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "LicenseActivatationOfflineDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Offline Activation";
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void medActivationKey_TextChanged(object sender, EventArgs e)
	{
		GClass31 gClass = new GClass31(GClass32.Get(medActivationKey.Text), null, null, string_0, "10.2.1", 5250827023818041824L);
		medActivationRequest.Text = gClass.Serialize(3);
	}

	private void mlnkCopy_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(medActivationRequest.Text))
		{
			Class77.smethod_0(medActivationRequest.Text);
		}
		medActivationRequest.SelectAll();
	}

	private void medActivationResponse_TextChanged(object sender, EventArgs e)
	{
		mbtnActivate.Enabled = !string.IsNullOrEmpty(medActivationResponse.Text);
	}

	private void mlnkPaste_Click(object sender, EventArgs e)
	{
		medActivationResponse.Text = Class77.smethod_1();
	}

	private void mlnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.String_1);
	}

	private void mbtnActivate_Click(object sender, EventArgs e)
	{
		GClass31 gClass = null;
		try
		{
			gClass = GClass31.smethod_0(medActivationResponse.Text, 3);
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

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
