using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class RawSocketsDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, GClass24> _003C_003E9__4_0;

		public static Func<GClass24, bool> _003C_003E9__4_1;

		public static Func<GClass24, bool> _003C_003E9__5_0;

		public static Func<GClass24, string> _003C_003E9__5_1;

		public static Func<GClass24, string> _003C_003E9__5_2;

		public static Func<GClass24, string> _003C_003E9__7_4;

		public static Func<GClass24, bool> _003C_003E9__8_0;

		public static Func<string, bool> _003C_003E9__8_1;

		internal GClass24 method_0(string string_0)
		{
			return GClass24.smethod_1(string_0);
		}

		internal bool method_1(GClass24 gclass24_0)
		{
			return gclass24_0.Boolean_2;
		}

		internal bool method_2(GClass24 gclass24_0)
		{
			return gclass24_0.Boolean_2;
		}

		internal string method_3(GClass24 gclass24_0)
		{
			return gclass24_0.method_6();
		}

		internal string method_4(GClass24 gclass24_0)
		{
			return gclass24_0.method_6();
		}

		internal string method_5(GClass24 gclass24_0)
		{
			return gclass24_0.method_6();
		}

		internal bool method_6(GClass24 gclass24_0)
		{
			return !gclass24_0.Boolean_2;
		}

		internal bool InitializeComponent(string string_0)
		{
			return !GClass24.smethod_1(string_0).Boolean_2;
		}
	}

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private Class65 class65_0;

	private TextBox textBox_0;

	private Class63 class63_0;

	private Class64 class64_0;

	private Class64 class64_1;

	public bool Boolean_0
	{
		get
		{
			return class64_1.Checked;
		}
		set
		{
			class64_1.Checked = value;
			class64_0.Checked = !value;
		}
	}

	public GClass24[] GClass24_0
	{
		get
		{
			if (textBox_0.Lines.Length == 0)
			{
				return GClass23.GClass24_1;
			}
			string[] lines = textBox_0.Lines;
			Func<string, GClass24> selector = _003C_003Ec._003C_003E9.method_0;
			IEnumerable<GClass24> source = lines.Select(selector);
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return source.Where(predicate).ToArray();
		}
		set
		{
			TextBox textBox = textBox_0;
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_2;
			IEnumerable<GClass24> source = value.Where(predicate);
			Func<GClass24, string> selector = _003C_003Ec._003C_003E9.method_3;
			textBox.Lines = source.Select(selector).ToArray();
			if (textBox_0.Lines.Length < 1)
			{
				TextBox textBox2 = textBox_0;
				GClass24[] gClass24_ = GClass23.GClass24_1;
				Func<GClass24, string> selector2 = _003C_003Ec._003C_003E9.method_4;
				textBox2.Lines = gClass24_.Select(selector2).ToArray();
			}
		}
	}

	protected override Button Button_0 => class66_0;

	public RawSocketsDialog()
		: base(new Size(560, 480))
	{
		OnButtonCancel();
		vmethod_1();
		InitializeComponents();
	}

	private void InitializeComponents()
	{
		gclass3_0.Click += gclass3_0_Click;
		class64_1.CheckedChanged += class64_1_CheckedChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void OnButtonOk()
	{
		GClass24[] gClass24_ = GClass24_0;
		Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_6;
		if (gClass24_.Any(predicate))
		{
			string[] lines = textBox_0.Lines;
			Func<string, bool> predicate2 = _003C_003Ec._003C_003E9.InitializeComponent;
			string text = string.Join("\r\n", lines.Where(predicate2).Take(10));
			MessageBox.Show("Invalid IP Addresses:\r\n\r\n" + text, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			method_8(DialogResult.OK);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnButtonCancel()
	{
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		class65_0 = new Class65();
		textBox_0 = new TextBox();
		class63_0 = new Class63();
		class64_0 = new Class64();
		class64_1 = new Class64();
		((ISupportInitialize)pictureBox_0).BeginInit();
		class65_0.SuspendLayout();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(323, 393);
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
		class66_1.Location = new Point(431, 393);
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
		gcontrol0_0.Size = new Size(516, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(193, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Raw Sockets Configuration";
		pictureBox_0.Image = Resources.traffic_monitoring_48;
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
		class62_1.Size = new Size(328, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Advanced settings of Raw Sockets monitoring method";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(459, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class64_0);
		class65_0.Controls.Add(class64_1);
		class65_0.Location = new Point(16, 98);
		class65_0.Name = "gb_SelectIPAddresses";
		class65_0.Size = new Size(515, 288);
		class65_0.TabIndex = 136;
		class65_0.TabStop = false;
		class65_0.Text = "Select IP addresses for monitoring";
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(15, 116);
		textBox_0.Multiline = true;
		textBox_0.Name = "m_edAddressesToMonitor";
		textBox_0.Size = new Size(494, 166);
		textBox_0.TabIndex = 136;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(12, 55);
		class63_0.Name = "m_lblMonitoringViaRawSocketsHint";
		class63_0.Size = new Size(472, 16);
		class63_0.TabIndex = 135;
		class63_0.Text = "Monitor traffic on all IP addresses associated with the machine (may work slow)";
		class64_0.AutoSize = true;
		class64_0.Location = new Point(15, 85);
		class64_0.Name = "m_rbMonitorSelectedAddresses";
		class64_0.Size = new Size(210, 20);
		class64_0.TabIndex = 134;
		class64_0.TabStop = true;
		class64_0.Text = "Monitor Selected IP Addresses";
		class64_0.UseVisualStyleBackColor = true;
		class64_1.AutoSize = true;
		class64_1.Location = new Point(15, 32);
		class64_1.Name = "m_rbMonitorAllAddresses";
		class64_1.Size = new Size(170, 20);
		class64_1.TabIndex = 133;
		class64_1.TabStop = true;
		class64_1.Text = "Monitor All IP Addresses";
		class64_1.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(544, 442);
		base.Controls.Add(class65_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "RawSocketsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Raw Sockets";
		((ISupportInitialize)pictureBox_0).EndInit();
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class155.String_0);
	}

	private void class64_1_CheckedChanged(object sender, EventArgs e)
	{
		if (class64_1.Checked)
		{
			TextBox textBox = textBox_0;
			GClass24[] gClass24_ = GClass23.GClass24_1;
			Func<GClass24, string> selector = _003C_003Ec._003C_003E9.method_5;
			textBox.Lines = gClass24_.Select(selector).ToArray();
		}
		textBox_0.Enabled = base.Enabled && !class64_1.Checked;
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
