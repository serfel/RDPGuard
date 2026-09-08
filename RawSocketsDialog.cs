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

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private Class65 gbSelectIPAddresses;

	private TextBox medAddressesToMonitor;

	private Class63 mlblMonitoringViaRawSocketsHint;

	private Class64 mrbMonitorSelectedAddresses;

	private Class64 mrbMonitorAllAddresses;

	public bool Boolean_0
	{
		get
		{
			return mrbMonitorAllAddresses.Checked;
		}
		set
		{
			mrbMonitorAllAddresses.Checked = value;
			mrbMonitorSelectedAddresses.Checked = !value;
		}
	}

	public GClass24[] GClass24_0
	{
		get
		{
			if (medAddressesToMonitor.Lines.Length == 0)
			{
				return GClass23.GClass24_1;
			}
			string[] lines = medAddressesToMonitor.Lines;
			Func<string, GClass24> selector = _003C_003Ec._003C_003E9.method_0;
			IEnumerable<GClass24> source = lines.Select(selector);
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return source.Where(predicate).ToArray();
		}
		set
		{
			TextBox textBox = medAddressesToMonitor;
			Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_2;
			IEnumerable<GClass24> source = value.Where(predicate);
			Func<GClass24, string> selector = _003C_003Ec._003C_003E9.method_3;
			textBox.Lines = source.Select(selector).ToArray();
			if (medAddressesToMonitor.Lines.Length < 1)
			{
				TextBox textBox2 = medAddressesToMonitor;
				GClass24[] gClass24_ = GClass23.GClass24_1;
				Func<GClass24, string> selector2 = _003C_003Ec._003C_003E9.method_4;
				textBox2.Lines = gClass24_.Select(selector2).ToArray();
			}
		}
	}

	protected override Button Button_0 => mbtnSave;

	public RawSocketsDialog()
		: base(new Size(560, 480))
	{
		OnButtonCancel();
		InitializeFormPosition();
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mrbMonitorAllAddresses.CheckedChanged += mrbMonitorAllAddresses_CheckedChanged;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnButtonOk()
	{
		GClass24[] gClass24_ = GClass24_0;
		Func<GClass24, bool> predicate = _003C_003Ec._003C_003E9.method_6;
		if (gClass24_.Any(predicate))
		{
			string[] lines = medAddressesToMonitor.Lines;
			Func<string, bool> predicate2 = _003C_003Ec._003C_003E9.InitializeComponent;
			string text = string.Join("\r\n", lines.Where(predicate2).Take(10));
			MessageBox.Show("Invalid IP Addresses:\r\n\r\n" + text, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			CloseDialog(DialogResult.OK);
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
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		gbSelectIPAddresses = new Class65();
		medAddressesToMonitor = new TextBox();
		mlblMonitoringViaRawSocketsHint = new Class63();
		mrbMonitorSelectedAddresses = new Class64();
		mrbMonitorAllAddresses = new Class64();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		gbSelectIPAddresses.SuspendLayout();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(323, 393);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 7;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(431, 393);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 8;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(516, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(193, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "Raw Sockets Configuration";
		mimgBigIcon.Image = Resources.traffic_monitoring_48;
		mimgBigIcon.Location = new Point(16, 15);
		mimgBigIcon.Margin = new Padding(4);
		mimgBigIcon.Name = "m_imgBigIcon";
		mimgBigIcon.Size = new Size(48, 48);
		mimgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgBigIcon.TabIndex = 47;
		mimgBigIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(328, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Advanced settings of Raw Sockets monitoring method";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(459, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		gbSelectIPAddresses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gbSelectIPAddresses.Controls.Add(medAddressesToMonitor);
		gbSelectIPAddresses.Controls.Add(mlblMonitoringViaRawSocketsHint);
		gbSelectIPAddresses.Controls.Add(mrbMonitorSelectedAddresses);
		gbSelectIPAddresses.Controls.Add(mrbMonitorAllAddresses);
		gbSelectIPAddresses.Location = new Point(16, 98);
		gbSelectIPAddresses.Name = "gb_SelectIPAddresses";
		gbSelectIPAddresses.Size = new Size(515, 288);
		gbSelectIPAddresses.TabIndex = 136;
		gbSelectIPAddresses.TabStop = false;
		gbSelectIPAddresses.Text = "Select IP addresses for monitoring";
		medAddressesToMonitor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medAddressesToMonitor.Location = new Point(15, 116);
		medAddressesToMonitor.Multiline = true;
		medAddressesToMonitor.Name = "m_edAddressesToMonitor";
		medAddressesToMonitor.Size = new Size(494, 166);
		medAddressesToMonitor.TabIndex = 136;
		mlblMonitoringViaRawSocketsHint.AutoSize = true;
		mlblMonitoringViaRawSocketsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblMonitoringViaRawSocketsHint.Location = new Point(12, 55);
		mlblMonitoringViaRawSocketsHint.Name = "m_lblMonitoringViaRawSocketsHint";
		mlblMonitoringViaRawSocketsHint.Size = new Size(472, 16);
		mlblMonitoringViaRawSocketsHint.TabIndex = 135;
		mlblMonitoringViaRawSocketsHint.Text = "Monitor traffic on all IP addresses associated with the machine (may work slow)";
		mrbMonitorSelectedAddresses.AutoSize = true;
		mrbMonitorSelectedAddresses.Location = new Point(15, 85);
		mrbMonitorSelectedAddresses.Name = "m_rbMonitorSelectedAddresses";
		mrbMonitorSelectedAddresses.Size = new Size(210, 20);
		mrbMonitorSelectedAddresses.TabIndex = 134;
		mrbMonitorSelectedAddresses.TabStop = true;
		mrbMonitorSelectedAddresses.Text = "Monitor Selected IP Addresses";
		mrbMonitorSelectedAddresses.UseVisualStyleBackColor = true;
		mrbMonitorAllAddresses.AutoSize = true;
		mrbMonitorAllAddresses.Location = new Point(15, 32);
		mrbMonitorAllAddresses.Name = "m_rbMonitorAllAddresses";
		mrbMonitorAllAddresses.Size = new Size(170, 20);
		mrbMonitorAllAddresses.TabIndex = 133;
		mrbMonitorAllAddresses.TabStop = true;
		mrbMonitorAllAddresses.Text = "Monitor All IP Addresses";
		mrbMonitorAllAddresses.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(544, 442);
		base.Controls.Add(gbSelectIPAddresses);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "RawSocketsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Raw Sockets";
		((ISupportInitialize)mimgBigIcon).EndInit();
		gbSelectIPAddresses.ResumeLayout(performLayout: false);
		gbSelectIPAddresses.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class155.String_0);
	}

	private void mrbMonitorAllAddresses_CheckedChanged(object sender, EventArgs e)
	{
		if (mrbMonitorAllAddresses.Checked)
		{
			TextBox textBox = medAddressesToMonitor;
			GClass24[] gClass24_ = GClass23.GClass24_1;
			Func<GClass24, string> selector = _003C_003Ec._003C_003E9.method_5;
			textBox.Lines = gClass24_.Select(selector).ToArray();
		}
		medAddressesToMonitor.Enabled = base.Enabled && !mrbMonitorAllAddresses.Checked;
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
