using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class MsSqlSettingsDialog : Form0
{
	private string[] string_0 = new string[0];

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbEnableEngine;

	private Class63 mlblEnableEngineHint;

	private Class62 mlblEnable18456Hint;

	private Class61 mchbEnable18456;

	private GClass3 mlnkEevent18456Exclusions;

	private Class62 mlblEnable17832Hint;

	private Class61 mchbEnable17832;

	private Class62 mlblEnable17836Hint;

	private Class61 mchbEnable17836;

	public Class117 Class117_0
	{
		get
		{
			return new Class117
			{
				bool_0 = mchbEnableEngine.Checked,
				int_1 = Int32_0,
				string_10 = string_0
			};
		}
		set
		{
			mchbEnableEngine.Checked = value.bool_0;
			Int32_0 = value.int_1;
			string_0 = value.string_10;
		}
	}

	private int[] Int32_0
	{
		get
		{
			List<int> list = new List<int>();
			if (mchbEnable18456.Checked)
			{
				list.Add(18456);
			}
			if (mchbEnable17832.Checked)
			{
				list.Add(17832);
			}
			if (mchbEnable17836.Checked)
			{
				list.Add(17836);
			}
			return list.ToArray();
		}
		set
		{
			mchbEnable18456.Checked = value.Contains(18456);
			mchbEnable17832.Checked = value.Contains(17832);
			mchbEnable17836.Checked = value.Contains(17836);
		}
	}

	public MsSqlSettingsDialog(Class117 class117_0)
		: base(new Size(465, 415))
	{
		OnButtonCancel();
		InitializeFormPosition();
		InitializeComponent();
		Class117_0 = class117_0;
		mchbEnableEngine.Focus();
	}

	private void InitializeComponent()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbEnableEngine.CheckedChanged += mchbEnableEngine_CheckedChanged;
		mchbEnable18456.CheckedChanged += mchbEnable18456_CheckedChanged;
		mchbEnable17832.CheckedChanged += mchbEnable17832_CheckedChanged;
		mchbEnable17836.CheckedChanged += mchbEnable17836_CheckedChanged;
		mlnkEevent18456Exclusions.Click += mlnkEevent18456Exclusions_Click;
		mbtnSave.Click += mbtnSave_Click;
		btnCancel.Click += btnCancel_Click;
	}

	private void OnButtonOk()
	{
		mchbEnable18456.Enabled = mchbEnableEngine.Checked;
		mlblEnable18456Hint.Enabled = mchbEnableEngine.Checked;
		mlnkEevent18456Exclusions.Enabled = mchbEnableEngine.Checked && mchbEnable18456.Checked;
		mchbEnable17832.Enabled = mchbEnableEngine.Checked;
		mlblEnable17832Hint.Enabled = mchbEnableEngine.Checked;
		mchbEnable17836.Enabled = mchbEnableEngine.Checked;
		mlblEnable17836Hint.Enabled = mchbEnableEngine.Checked;
		mbtnSave.Enabled = !mchbEnableEngine.Checked || mchbEnable18456.Checked || false || (mchbEnable17832.Checked ? true : false) || mchbEnable17836.Checked;
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
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(MsSqlSettingsDialog));
		mbtnSave = new Class66();
		btnCancel = new Class66();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbEnableEngine = new Class61();
		mlblEnableEngineHint = new Class63();
		mlblEnable18456Hint = new Class62();
		mchbEnable18456 = new Class61();
		mlnkEevent18456Exclusions = new GClass3();
		mlblEnable17832Hint = new Class62();
		mchbEnable17832 = new Class61();
		mlblEnable17836Hint = new Class62();
		mchbEnable17836 = new Class61();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(228, 328);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 5;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnCancel.Image = Resources.cancl_16;
		btnCancel.Location = new Point(336, 328);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 6;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(421, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(124, 16);
		label2.TabIndex = 49;
		label2.Text = "MS-SQL Settings";
		imgBigIcon.Image = Resources.ms_sql_48;
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
		lblCaption.Size = new Size(234, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Advanced MS-SQL protection settings";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(364, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 7;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbEnableEngine.AutoSize = true;
		mchbEnableEngine.Location = new Point(16, 97);
		mchbEnableEngine.Name = "m_chbEnableEngine";
		mchbEnableEngine.Size = new Size(185, 20);
		mchbEnableEngine.TabIndex = 0;
		mchbEnableEngine.Text = "Enable MS-SQL protection";
		mchbEnableEngine.UseVisualStyleBackColor = true;
		mlblEnableEngineHint.AutoSize = true;
		mlblEnableEngineHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnableEngineHint.Location = new Point(13, 122);
		mlblEnableEngineHint.Name = "m_lblEnableEngineHint";
		mlblEnableEngineHint.Size = new Size(227, 16);
		mlblEnableEngineHint.TabIndex = 58;
		mlblEnableEngineHint.Text = "Turn on to enable MS-SQL protection";
		mlblEnable18456Hint.AutoSize = true;
		mlblEnable18456Hint.Enabled = false;
		mlblEnable18456Hint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnable18456Hint.Location = new Point(13, 179);
		mlblEnable18456Hint.Name = "m_lblEnable18456Hint";
		mlblEnable18456Hint.Size = new Size(418, 16);
		mlblEnable18456Hint.TabIndex = 74;
		mlblEnable18456Hint.Text = "In most cases this event indicates brute-force attacks, keep it enabled";
		mchbEnable18456.AutoSize = true;
		mchbEnable18456.Checked = true;
		mchbEnable18456.CheckState = CheckState.Checked;
		mchbEnable18456.Enabled = false;
		mchbEnable18456.Location = new Point(16, 154);
		mchbEnable18456.Name = "m_chbEnable18456";
		mchbEnable18456.Size = new Size(162, 20);
		mchbEnable18456.TabIndex = 1;
		mchbEnable18456.Text = "Monitor Event ID 18456";
		mchbEnable18456.UseVisualStyleBackColor = true;
		mlnkEevent18456Exclusions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkEevent18456Exclusions.AutoSize = true;
		mlnkEevent18456Exclusions.Enabled = false;
		mlnkEevent18456Exclusions.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkEevent18456Exclusions.Location = new Point(351, 155);
		mlnkEevent18456Exclusions.Name = "m_lnkEevent18456Exclusions";
		mlnkEevent18456Exclusions.Size = new Size(77, 16);
		mlnkEevent18456Exclusions.TabIndex = 2;
		mlnkEevent18456Exclusions.TabStop = true;
		mlnkEevent18456Exclusions.Text = "exclusions..";
		mlnkEevent18456Exclusions.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mlblEnable17832Hint.AutoSize = true;
		mlblEnable17832Hint.Enabled = false;
		mlblEnable17832Hint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnable17832Hint.Location = new Point(13, 236);
		mlblEnable17832Hint.Name = "m_lblEnable17832Hint";
		mlblEnable17832Hint.Size = new Size(367, 16);
		mlblEnable17832Hint.TabIndex = 77;
		mlblEnable17832Hint.Text = "This event may also be a part of an attack on MS-SQL server";
		mchbEnable17832.AutoSize = true;
		mchbEnable17832.Enabled = false;
		mchbEnable17832.Location = new Point(16, 211);
		mchbEnable17832.Name = "m_chbEnable17832";
		mchbEnable17832.Size = new Size(162, 20);
		mchbEnable17832.TabIndex = 3;
		mchbEnable17832.Text = "Monitor Event ID 17832";
		mchbEnable17832.UseVisualStyleBackColor = true;
		mlblEnable17836Hint.AutoSize = true;
		mlblEnable17836Hint.Enabled = false;
		mlblEnable17836Hint.ForeColor = SystemColors.ControlDarkDark;
		mlblEnable17836Hint.Location = new Point(13, 293);
		mlblEnable17836Hint.Name = "m_lblEnable17836Hint";
		mlblEnable17836Hint.Size = new Size(367, 16);
		mlblEnable17836Hint.TabIndex = 79;
		mlblEnable17836Hint.Text = "This event may also be a part of an attack on MS-SQL server";
		mchbEnable17836.AutoSize = true;
		mchbEnable17836.Enabled = false;
		mchbEnable17836.Location = new Point(16, 268);
		mchbEnable17836.Name = "m_chbEnable17836";
		mchbEnable17836.Size = new Size(162, 20);
		mchbEnable17836.TabIndex = 4;
		mchbEnable17836.Text = "Monitor Event ID 17836";
		mchbEnable17836.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(449, 377);
		base.Controls.Add(mlblEnable17836Hint);
		base.Controls.Add(mchbEnable17836);
		base.Controls.Add(mlblEnable17832Hint);
		base.Controls.Add(mchbEnable17832);
		base.Controls.Add(mlnkEevent18456Exclusions);
		base.Controls.Add(mlblEnable18456Hint);
		base.Controls.Add(mchbEnable18456);
		base.Controls.Add(mlblEnableEngineHint);
		base.Controls.Add(mchbEnableEngine);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "MsSqlSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "MS-SQL Settings";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class151.String_9);
	}

	private void mchbEnableEngine_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mchbEnable18456_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mchbEnable17832_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mchbEnable17836_CheckedChanged(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mlnkEevent18456Exclusions_Click(object sender, EventArgs e)
	{
		MsSqlExclusionsDialog form = new MsSqlExclusionsDialog
		{
			String_0 = string_0
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				string_0 = form.String_0;
			}
		}
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
