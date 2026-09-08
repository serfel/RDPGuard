using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ProtocolRulesDialog : Form0
{
	public string string_0 = string.Empty;

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private PictureBox imgBigIcon;

	private Class62 mlblSubCaption;

	private Class62 mlblCaption;

	private GControl0 separatorLine1;

	private GClass3 mlnkOnlineHelp;

	private TextBox medRules;

	private Class62 mlblRules;

	private Class63 mlblRulesHint;

	public string String_0
	{
		set
		{
			Text = value;
		}
	}

	public string String_1
	{
		set
		{
			mlblCaption.Text = value;
		}
	}

	public string String_2
	{
		set
		{
			mlblSubCaption.Text = value;
		}
	}

	public string String_3
	{
		set
		{
			mlblRules.Text = value;
		}
	}

	public string String_4
	{
		get
		{
			return medRules.Text;
		}
		set
		{
			medRules.Text = value;
		}
	}

	public string String_5
	{
		set
		{
			mlblRulesHint.Text = value;
		}
	}

	public ProtocolRulesDialog()
		: base(new Size(580, 470))
	{
		OnButtonOk();
		InitializeFormPosition();
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mbtnSave.Click += mbtnSave_Click;
		btnCancel.Click += btnCancel_Click;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnButtonOk()
	{
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(ProtocolRulesDialog));
		mbtnSave = new Class66();
		btnCancel = new Class66();
		imgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlblCaption = new Class62();
		separatorLine1 = new GControl0();
		mlnkOnlineHelp = new GClass3();
		medRules = new TextBox();
		mlblRules = new Class62();
		mlblRulesHint = new Class63();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(295, 433);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 7;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnCancel.Image = Resources.cancl_16;
		btnCancel.Location = new Point(403, 433);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 8;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		imgBigIcon.Image = Resources.filter_48;
		imgBigIcon.Location = new Point(16, 15);
		imgBigIcon.Margin = new Padding(4);
		imgBigIcon.Name = "imgBigIcon";
		imgBigIcon.Size = new Size(48, 48);
		imgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		imgBigIcon.TabIndex = 47;
		imgBigIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(104, 16);
		mlblSubCaption.TabIndex = 48;
		mlblSubCaption.Text = "{SUBCAPTION}";
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(85, 16);
		mlblCaption.TabIndex = 49;
		mlblCaption.Text = "{CAPTION}";
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(487, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(430, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medRules.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medRules.Location = new Point(16, 126);
		medRules.Multiline = true;
		medRules.Name = "m_edRules";
		medRules.ScrollBars = ScrollBars.Both;
		medRules.Size = new Size(486, 261);
		medRules.TabIndex = 51;
		medRules.WordWrap = false;
		mlblRules.AutoSize = true;
		mlblRules.Location = new Point(13, 97);
		mlblRules.Margin = new Padding(4, 0, 4, 0);
		mlblRules.Name = "m_lblRules";
		mlblRules.Size = new Size(128, 16);
		mlblRules.TabIndex = 52;
		mlblRules.Text = "{RULES_CAPTION}";
		mlblRulesHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblRulesHint.AutoSize = true;
		mlblRulesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblRulesHint.Location = new Point(13, 397);
		mlblRulesHint.Name = "m_lblRulesHint";
		mlblRulesHint.Size = new Size(101, 16);
		mlblRulesHint.TabIndex = 59;
		mlblRulesHint.Text = "{RULES_HINT}";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(515, 482);
		base.Controls.Add(mlblRulesHint);
		base.Controls.Add(mlblRules);
		base.Controls.Add(medRules);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "ProtocolRulesDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "{WINDOW_TITLE}";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(string_0);
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
