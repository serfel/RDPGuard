using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class IPFilterDialog : Form0
{
	private Class135 class135_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Class62 mlblSubCaption;

	private Class62 lblCaption;

	private Class62 mlblFilter;

	private TextBox medFilter;

	private Class66 mbtnSetFilter;

	private Class66 mbtnCancel;

	private GControl0 separatorLine1;

	private GClass3 mlnkOnlineHelp;

	private Class62 label4;

	public Class135 Class135_0
	{
		get
		{
			return class135_0;
		}
		private set
		{
			class135_0 = value;
		}
	}

	public bool Boolean_0 => !string.IsNullOrEmpty(Class135_0?.String_0);

	protected override Button Button_0 => mbtnSetFilter;

	public void InitializeComponent()
	{
		medFilter.Text = string.Empty;
		Class135_0 = null;
	}

	public IPFilterDialog()
		: base(new Size(520, 265))
	{
		OnLoad();
		InitializeFormPosition();
		OnButtonOk();
		OnButtonCancel();
	}

	private void OnButtonOk()
	{
		medFilter.Focus();
	}

	private void OnButtonCancel()
	{
		mbtnSetFilter.Click += mbtnSetFilter_Click;
		mbtnCancel.Click += mbtnCancel_Click;
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
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
		pictureBox1 = new PictureBox();
		mlblSubCaption = new Class62();
		lblCaption = new Class62();
		mlblFilter = new Class62();
		medFilter = new TextBox();
		mbtnSetFilter = new Class66();
		mbtnCancel = new Class66();
		separatorLine1 = new GControl0();
		mlnkOnlineHelp = new GClass3();
		label4 = new Class62();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		pictureBox1.Image = Resources.filter_48;
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
		mlblSubCaption.Size = new Size(329, 16);
		mlblSubCaption.TabIndex = 4;
		mlblSubCaption.Text = "Filter allows you to display only a certain IP addresses";
		lblCaption.AutoSize = true;
		lblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		lblCaption.Location = new Point(79, 15);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(89, 16);
		lblCaption.TabIndex = 14;
		lblCaption.Text = "IP List Filter";
		mlblFilter.AutoSize = true;
		mlblFilter.Location = new Point(13, 97);
		mlblFilter.Name = "m_lblFilter";
		mlblFilter.Size = new Size(174, 16);
		mlblFilter.TabIndex = 20;
		mlblFilter.Text = "IP Address, Range or CIDR:";
		medFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medFilter.Location = new Point(34, 123);
		medFilter.Name = "m_edFilter";
		medFilter.Size = new Size(459, 22);
		medFilter.TabIndex = 0;
		mbtnSetFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSetFilter.Image = Resources.opts_16;
		mbtnSetFilter.ImageAlign = ContentAlignment.MiddleRight;
		mbtnSetFilter.Location = new Point(258, 178);
		mbtnSetFilter.Margin = new Padding(4);
		mbtnSetFilter.Name = "m_btnSetFilter";
		mbtnSetFilter.Size = new Size(125, 36);
		mbtnSetFilter.TabIndex = 1;
		mbtnSetFilter.Text = "Set filter";
		mbtnSetFilter.TextAlign = ContentAlignment.MiddleLeft;
		mbtnSetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSetFilter.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.DialogResult = DialogResult.Cancel;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(391, 178);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 2;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextAlign = ContentAlignment.MiddleRight;
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(477, 2);
		separatorLine1.TabIndex = 42;
		separatorLine1.TabStop = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(418, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.RightToLeft = RightToLeft.No;
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 43;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		label4.AutoSize = true;
		label4.ForeColor = SystemColors.ControlDarkDark;
		label4.Location = new Point(31, 148);
		label4.Name = "label4";
		label4.Size = new Size(449, 16);
		label4.TabIndex = 44;
		label4.Text = "Example 1.2.3.4 or 192.168.2.1-192.168.2.255 or 192.168.0.* or 192.168.0.0/24";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(504, 227);
		base.Controls.Add(label4);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mbtnSetFilter);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(medFilter);
		base.Controls.Add(mlblFilter);
		base.Controls.Add(lblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(pictureBox1);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "IPFilterDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "IP Filter";
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mbtnSetFilter_Click(object sender, EventArgs e)
	{
		Class135_0 = new Class135(medFilter.Text);
		CloseDialog(DialogResult.OK);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_4);
	}
}
