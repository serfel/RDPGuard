using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class GeoIPCountryAddDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GClass5, string> _003C_003E9__4_0;

		public static Func<GClass5, string> _003C_003E9__6_2;

		internal string method_0(GClass5 gclass5_0)
		{
			return gclass5_0.string_1;
		}

		internal string method_1(GClass5 gclass5_0)
		{
			return gclass5_0.Name;
		}
	}

	private sealed class Class9
	{
		public GeoIPCountryAddDialog form7_0;

		public object object_0;

		public EventArgs0 eventArgs0_0;

		internal void method_0()
		{
			form7_0.OnButtonOk(object_0, eventArgs0_0);
		}

		internal bool method_1(GClass5 gclass5_0)
		{
			return !form7_0.string_0.Contains(gclass5_0.string_1);
		}
	}

	private string[] string_0;

	private GeoIPDBVersion geoIPDBVersion_0;

	private IContainer icontainer_0;

	private Class66 mbtnAdd;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox mimgBigIcon;

	private Class62 lblCaption;

	private GClass3 mlnkOnlineHelp;

	private GeoIPCountriesTable mlstCountries;

	private PictureBox mpicLoading;

	private Class63 mlblLoadingHint;

	public GClass5[] GClass5_0 => mlstCountries.GClass5_0;

	protected override Button Button_0 => mbtnAdd;

	public GeoIPCountryAddDialog(GClass5[] gclass5_0, GeoIPDBVersion geoIPDBVersion_1)
		: base(new Size(600, 525))
	{
		Func<GClass5, string> selector = _003C_003Ec._003C_003E9.method_0;
		string_0 = gclass5_0.Select(selector).ToArray();
		geoIPDBVersion_0 = geoIPDBVersion_1;
		SaveSettings();
		InitializeFormPosition();
		OnButtonCancel();
		OnLoad();
		base.Shown += Form7_Shown;
	}

	private void InitializeComponent()
	{
		ValidateInput(bool_0: true);
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Combine(Class89.eventHandler_28, new EventHandler<EventArgs0>(OnButtonOk));
		Class89.smethod_39(geoIPDBVersion_0);
	}

	private void OnButtonOk(object sender, EventArgs0 e)
	{
		Class9 @class = new Class9();
		@class.form7_0 = this;
		@class.object_0 = sender;
		@class.eventArgs0_0 = e;
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Remove(Class89.eventHandler_28, new EventHandler<EventArgs0>(OnButtonOk));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		ValidateInput(bool_0: false);
		GeoIPCountriesTable control = mlstCountries;
		IEnumerable<GClass5> source = @class.eventArgs0_0.gclass29_0.gclass5_0.Where(@class.method_1);
		Func<GClass5, string> keySelector = _003C_003Ec._003C_003E9.method_1;
		control.GClass5_1 = source.OrderBy(keySelector).ToArray();
	}

	private void OnButtonCancel()
	{
		mimgBigIcon.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_48_dark : Resources.location_pin_48);
		mpicLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	private void OnLoad()
	{
		mlstCountries.Event_0 += LoadSettings;
		mlstCountries.Event_3 += OnTextChanged;
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnCancel.Click += mbtnCancel_Click;
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
	}

	private void ValidateInput(bool bool_0)
	{
		mpicLoading.Visible = bool_0;
		mlblLoadingHint.Visible = bool_0;
		mlstCountries.Enabled = !bool_0;
		mbtnAdd.Enabled = !bool_0;
		mbtnCancel.Enabled = !bool_0;
		OnFormClosing();
		mlstCountries.Focus();
	}

	protected override void OnFormClosing()
	{
		mbtnAdd.Enabled = mlstCountries.Boolean_0;
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
		mbtnAdd = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		mimgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mlstCountries = new GeoIPCountriesTable();
		mpicLoading = new PictureBox();
		mlblLoadingHint = new Class63();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mbtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnAdd.Image = Resources.opts_16;
		mbtnAdd.Location = new Point(464, 438);
		mbtnAdd.Margin = new Padding(4);
		mbtnAdd.Name = "m_btnAdd";
		mbtnAdd.Size = new Size(100, 36);
		mbtnAdd.TabIndex = 20;
		mbtnAdd.Text = "Add";
		mbtnAdd.TextAlign = ContentAlignment.MiddleRight;
		mbtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnAdd.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(572, 438);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 21;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(656, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(91, 16);
		label2.TabIndex = 49;
		label2.Text = "Add Country";
		mimgBigIcon.Location = new Point(16, 15);
		mimgBigIcon.Margin = new Padding(4);
		mimgBigIcon.Name = "m_imgBigIcon";
		mimgBigIcon.Size = new Size(48, 48);
		mimgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgBigIcon.TabIndex = 47;
		mimgBigIcon.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Location = new Point(79, 47);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(384, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Select one or multiple countries from the list below and click Add";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(599, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 55;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlstCountries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlstCountries.GClass5_1 = new GClass5[0];
		mlstCountries.IPListEntry_0 = new IPListEntry[0];
		mlstCountries.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mlstCountries.Location = new Point(16, 98);
		mlstCountries.Margin = new Padding(4);
		mlstCountries.Name = "m_lstCountries";
		mlstCountries.Size = new Size(656, 327);
		mlstCountries.TabIndex = 56;
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mpicLoading.Location = new Point(16, 458);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 76;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlblLoadingHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblLoadingHint.AutoSize = true;
		mlblLoadingHint.ForeColor = SystemColors.ControlDarkDark;
		mlblLoadingHint.Location = new Point(39, 458);
		mlblLoadingHint.Margin = new Padding(4, 0, 4, 0);
		mlblLoadingHint.Name = "m_lblLoadingHint";
		mlblLoadingHint.Size = new Size(58, 16);
		mlblLoadingHint.TabIndex = 77;
		mlblLoadingHint.Text = "loading..";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 487);
		base.Controls.Add(mlblLoadingHint);
		base.Controls.Add(mpicLoading);
		base.Controls.Add(mlstCountries);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(mimgBigIcon);
		base.Controls.Add(mbtnAdd);
		base.Controls.Add(mbtnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "GeoIPCountryAddDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Add Country";
		((ISupportInitialize)mimgBigIcon).EndInit();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form7_Shown(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void LoadSettings(object sender, EventArgs e)
	{
		OnFormClosing();
	}

	private void OnTextChanged(object sender, MouseEventArgs e)
	{
		mbtnAdd.PerformClick();
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class156.String_0);
	}
}
