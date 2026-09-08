using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class MsSqlExclusionsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private Class62 label2;

	private GControl0 separatorLine1;

	private GClass3 mlnkOnlineHelp;

	private TextBox medExclusions;

	private Class62 label1;

	private GClass2 mlblExlucionsHint;

	public string[] String_0
	{
		get
		{
			return medExclusions.Lines;
		}
		set
		{
			medExclusions.Lines = value;
		}
	}

	public MsSqlExclusionsDialog()
		: base(new Size(465, 415))
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
		new ComponentResourceManager(typeof(MsSqlExclusionsDialog));
		mbtnSave = new Class66();
		btnCancel = new Class66();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		label2 = new Class62();
		separatorLine1 = new GControl0();
		mlnkOnlineHelp = new GClass3();
		medExclusions = new TextBox();
		label1 = new Class62();
		mlblExlucionsHint = new GClass2();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(294, 416);
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
		btnCancel.Location = new Point(402, 416);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 8;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		imgBigIcon.Image = Resources.ms_sql_filter_48;
		imgBigIcon.Location = new Point(16, 15);
		imgBigIcon.Margin = new Padding(4);
		imgBigIcon.Name = "imgBigIcon";
		imgBigIcon.Size = new Size(48, 48);
		imgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		imgBigIcon.TabIndex = 47;
		imgBigIcon.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Location = new Point(79, 47);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(180, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Exclusions for Event ID 18456";
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(141, 16);
		label2.TabIndex = 49;
		label2.Text = "MS-SQL Exclusions";
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(487, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(430, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(72, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medExclusions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medExclusions.Location = new Point(16, 126);
		medExclusions.Multiline = true;
		medExclusions.Name = "m_edExclusions";
		medExclusions.Size = new Size(486, 231);
		medExclusions.TabIndex = 51;
		label1.AutoSize = true;
		label1.Location = new Point(13, 97);
		label1.Margin = new Padding(4, 0, 4, 0);
		label1.Name = "label1";
		label1.Size = new Size(236, 16);
		label1.TabIndex = 52;
		label1.Text = "Exclusion patterns for the Reason field:";
		mlblExlucionsHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlblExlucionsHint.Location = new Point(16, 363);
		mlblExlucionsHint.Name = "m_lblExlucionsHint";
		mlblExlucionsHint.Size = new Size(486, 46);
		mlblExlucionsHint.TabIndex = 53;
		mlblExlucionsHint.Text = "You can specify one exclusion pattern per line. Event ID 18456 is skipped if the Reason field contains any of the exclusion patterns.";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(515, 465);
		base.Controls.Add(mlblExlucionsHint);
		base.Controls.Add(label1);
		base.Controls.Add(medExclusions);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "MsSqlExclusionsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MS-SQL Exclusions";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_10);
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
