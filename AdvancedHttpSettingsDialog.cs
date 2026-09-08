using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedHttpSettingsDialog : Form0
{
	private readonly string string_0 = string.Empty;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Class61 class61_0;

	private Class63 class63_0;

	private GClass3 gclass3_1;

	private Class61 class61_1;

	private Class63 class63_1;

	public bool Boolean_0
	{
		get
		{
			return class61_0.Checked;
		}
		set
		{
			class61_0.Checked = value;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return class61_1.Checked;
		}
		set
		{
			class61_1.Checked = value;
		}
	}

	public AdvancedHttpSettingsDialog(string string_1)
		: base(new Size(470, 330))
	{
		string_0 = string_1;
		OnLoad();
		vmethod_1();
		InitializeComponents();
		OnButtonOk();
	}

	private void InitializeComponents()
	{
		OnButtonCancel();
	}

	private void OnButtonOk()
	{
		gclass3_0.Click += gclass3_0_Click;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		gclass3_1.Click += gclass3_1_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void OnButtonCancel()
	{
		bool enabled = class61_0.Checked;
		class61_1.Enabled = enabled;
		class63_1.Enabled = enabled;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnLoad()
	{
		icontainer_0 = new Container();
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class61_0 = new Class61();
		class63_0 = new Class63();
		gclass3_1 = new GClass3();
		class61_1 = new Class61();
		class63_1 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(213, 206);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Save";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(321, 206);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(406, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(108, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "HTTP Settings";
		pictureBox_0.Image = Resources.http_48;
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(220, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced HTTP protection settings";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(349, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 97);
		class61_0.Name = "m_chbUseXForwardedFor";
		class61_0.Size = new Size(351, 20);
		class61_0.TabIndex = 65;
		class61_0.Text = "Use the X-Forwarded-For field to read client IP address";
		class61_0.UseVisualStyleBackColor = true;
		class63_0.AutoSize = true;
		class63_0.ForeColor = Color.Red;
		class63_0.Location = new Point(13, 122);
		class63_0.Name = "m_chbUseXForwardedForHint";
		class63_0.Size = new Size(391, 16);
		class63_0.TabIndex = 67;
		class63_0.Text = "Do not enable unless you are hosting the website behind a proxy.";
		class63_0.Boolean_0 = true;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(13, 145);
		gclass3_1.Name = "m_lnkIISConfiguration";
		gclass3_1.Size = new Size(405, 16);
		gclass3_1.TabIndex = 68;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "Additional configuration required for the proxy and the HTTP server.";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class61_1 = new Class61();
		class61_1.AutoSize = true;
		class61_1.Location = new Point(16, 180);
		class61_1.Name = "m_chbXffFallbackToRemoteAddr";
		class61_1.Size = new Size(382, 20);
		class61_1.TabIndex = 69;
		class61_1.Text = "Fall back to the client IP address if the header is missing";
		class61_1.UseVisualStyleBackColor = true;
		class63_1 = new Class63();
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(13, 205);
		class63_1.Name = "m_lblXffFallbackHint";
		class63_1.Size = new Size(382, 16);
		class63_1.TabIndex = 70;
		class63_1.Text = "Allows using the client IP when the X-Forwarded-For header is not set.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(434, 255);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class63_0);
		base.Controls.Add(class61_0);
		base.Controls.Add(class61_1);
		base.Controls.Add(class63_1);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedHttpSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Advanced HTTP Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(string_0);
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_7);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
