using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class WinPcapDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class127, bool> _003C_003E9__10_0;

		public static Func<Class127, bool> _003C_003E9__10_1;

		internal bool method_0(Class127 class127_0)
		{
			return class127_0.Boolean_2;
		}

		internal bool method_1(Class127 class127_0)
		{
			return class127_0.Boolean_1;
		}
	}

	private sealed class Class17
	{
		public WinPcapDialog form18_0;

		public object object_0;

		public EventArgs6 eventArgs6_0;

		internal void method_0()
		{
			form18_0.OnButtonOk(object_0, eventArgs6_0);
		}
	}

	private Class127[] class127_0 = new Class127[0];

	private bi<Class127> bi_0;

	private Class127 class127_1 = Class127.class127_0;

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 mlblCaption;

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private GClass3 mlnkOnlineHelp;

	private ImageList imageList_0;

	private GClass3 mlnkWinPcap;

	private Class62 mlblWinPcapWarning;

	private Class61 mchbHideIrrelevantAdapters;

	public Class127 Class127_0
	{
		get
		{
			return bi_0.Prop_0.FirstOrDefault();
		}
		private set
		{
			class127_1 = value;
		}
	}

	protected override Button Button_0 => mbtnSave;

	public WinPcapDialog(Class127 class127_2)
		: base(new Size(550, 400))
	{
		Class127_0 = class127_2;
		OnTextChanged();
		InitializeFormPosition();
		ValidateInput();
		LoadSettings();
		base.Shown += Form18_Shown;
	}

	public void InitializeComponent()
	{
		Class89.eventHandler_22 = (EventHandler<EventArgs6>)Delegate.Combine(Class89.eventHandler_22, new EventHandler<EventArgs6>(OnButtonOk));
		Class89.smethod_31();
	}

	private void OnButtonOk(object sender, EventArgs6 e)
	{
		Class17 @class = new Class17();
		@class.form18_0 = this;
		@class.object_0 = sender;
		@class.eventArgs6_0 = e;
		Class89.eventHandler_22 = (EventHandler<EventArgs6>)Delegate.Remove(Class89.eventHandler_22, new EventHandler<EventArgs6>(OnButtonOk));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else if (!@class.eventArgs6_0.bool_0)
		{
			mchbHideIrrelevantAdapters.Visible = false;
			mlblWinPcapWarning.Visible = true;
			mlnkWinPcap.Visible = true;
		}
		else
		{
			class127_0 = @class.eventArgs6_0.class127_0;
			OnButtonCancel();
		}
	}

	private void OnButtonCancel()
	{
		bi_0.SuspendLayout();
		bi_0.Items.Clear();
		bi_0.Items.AddRange(OnLoad().Select(OnCheckedChanged).ToArray());
		bi_0.ResumeLayout();
		bi_0.Focus();
	}

	private Class127[] OnLoad()
	{
		if (!mchbHideIrrelevantAdapters.Checked)
		{
			Class127[] source = class127_0;
			Func<Class127, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return source.Where(predicate).ToArray();
		}
		Class127[] source2 = class127_0;
		Func<Class127, bool> predicate2 = _003C_003Ec._003C_003E9.method_0;
		return source2.Where(predicate2).ToArray();
	}

	private void ValidateInput()
	{
		base.Controls.Add(bi_0 = SaveSettings());
	}

	private bi<Class127> SaveSettings()
	{
		bi<Class127> bi2 = new bi<Class127>();
		bi2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bi2.FullRowSelect = true;
		bi2.MultiSelect = false;
		bi2.GridLines = true;
		bi2.HideSelection = false;
		bi2.HeaderStyle = ColumnHeaderStyle.None;
		bi2.Location = new Point(16, 97);
		bi2.Width = base.ClientRectangle.Width - 30;
		bi2.Height = mbtnCancel.Top - 97 - 15;
		bi2.SmallImageList = imageList_0;
		bi2.UseCompatibleStateImageBehavior = false;
		bi2.View = View.Details;
		bi2.ColumnHeader_0 = new ColumnHeader[1]
		{
			new ColumnHeader()
		};
		return bi2;
	}

	private void LoadSettings()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		bi_0.SelectedIndexChanged += bi_0_SelectedIndexChanged;
		mchbHideIrrelevantAdapters.CheckedChanged += mchbHideIrrelevantAdapters_CheckedChanged;
		mlnkWinPcap.Click += mlnkWinPcap_Click;
		mbtnSave.Click += mbtnSave_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	protected override void OnFormClosing()
	{
		Button_0.Enabled = bi_0.Boolean_2;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnTextChanged()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WinPcapDialog));
		mbtnSave = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlblCaption = new Class62();
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		imageList_0 = new ImageList(icontainer_0);
		mlnkWinPcap = new GClass3();
		mlblWinPcapWarning = new Class62();
		mchbHideIrrelevantAdapters = new Class61();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(315, 349);
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
		mbtnCancel.Location = new Point(423, 349);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 8;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 73);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(507, 10);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(181, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "WinPcap/Npcap Settings";
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
		mlblSubCaption.Size = new Size(397, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "Please select network adapter for traffic monitoring and click Save";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(451, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("m_smallImageList.ImageStream");
		imageList_0.TransparentColor = Color.Transparent;
		imageList_0.Images.SetKeyName(0, "PCI-card_24.png");
		mlnkWinPcap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlnkWinPcap.AutoSize = true;
		mlnkWinPcap.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkWinPcap.Location = new Point(13, 369);
		mlnkWinPcap.Name = "m_lnkWinPcap";
		mlnkWinPcap.Size = new Size(244, 16);
		mlnkWinPcap.TabIndex = 137;
		mlnkWinPcap.TabStop = true;
		mlnkWinPcap.Text = "click here to download WinPcap/Npcap";
		mlnkWinPcap.Visible = false;
		mlnkWinPcap.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlblWinPcapWarning.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblWinPcapWarning.AutoSize = true;
		mlblWinPcapWarning.ForeColor = Color.Red;
		mlblWinPcapWarning.Location = new Point(13, 349);
		mlblWinPcapWarning.Margin = new Padding(4, 0, 4, 0);
		mlblWinPcapWarning.Name = "m_lblWinPcapWarning";
		mlblWinPcapWarning.Size = new Size(235, 16);
		mlblWinPcapWarning.TabIndex = 138;
		mlblWinPcapWarning.Text = "WinPcap/Npcap driver is not installed,";
		mlblWinPcapWarning.Boolean_0 = true;
		mlblWinPcapWarning.Visible = false;
		mchbHideIrrelevantAdapters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mchbHideIrrelevantAdapters.AutoSize = true;
		mchbHideIrrelevantAdapters.Checked = true;
		mchbHideIrrelevantAdapters.CheckState = CheckState.Checked;
		mchbHideIrrelevantAdapters.Location = new Point(16, 365);
		mchbHideIrrelevantAdapters.Name = "m_chbHideIrrelevantAdapters";
		mchbHideIrrelevantAdapters.Size = new Size(171, 20);
		mchbHideIrrelevantAdapters.TabIndex = 140;
		mchbHideIrrelevantAdapters.Text = "Hide irrelevant adapters";
		mchbHideIrrelevantAdapters.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(536, 398);
		base.Controls.Add(mchbHideIrrelevantAdapters);
		base.Controls.Add(mlblWinPcapWarning);
		base.Controls.Add(mlnkWinPcap);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "WinPcapDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "WinPcap/Npcap Settings";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form18_Shown(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private ListViewItem OnCheckedChanged(Class127 class127_2)
	{
		return new ListViewItem(class127_2.Name)
		{
			Tag = class127_2,
			Selected = (class127_2.string_0 == class127_1.string_0),
			ImageIndex = 0
		};
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class155.String_1);
	}

	private void bi_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		OnFormClosing();
	}

	private void mchbHideIrrelevantAdapters_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonCancel();
	}

	private void mlnkWinPcap_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_6);
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
