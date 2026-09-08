using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class AdvancedBlockingSettingsDialog : Form0
{
	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private GClass3 mlnkOnlineHelp;

	private Class61 mchbBlockAllPorts;

	private Class63 mlblBlockAllPortsHint;

	private Class63 mlblPortsHint;

	private Class62 mlblPorts;

	private TextBox medPorts;

	private Class62 mlblPerformanceWarning;

	public Class169 Class169_0
	{
		get
		{
			return new Class169
			{
				ushort_0 = Class168.smethod_1(medPorts.Text),
				Boolean_0 = mchbBlockAllPorts.Checked
			};
		}
		set
		{
			mchbBlockAllPorts.CheckState = CheckState.Checked;
			mchbBlockAllPorts.Checked = !value.Boolean_1;
			medPorts.Text = Class168.smethod_0(value.ushort_0);
		}
	}

	protected override Button Button_0 => mbtnSave;

	public AdvancedBlockingSettingsDialog(Class169 class169_0)
		: base(new Size(500, 345))
	{
		OnButtonCancel();
		InitializeFormPosition();
		InitializeComponent();
		OnButtonOk();
		Class169_0 = class169_0;
	}

	private void InitializeComponent()
	{
		mlblPerformanceWarning.Left = mlblPorts.Right;
	}

	private void OnButtonOk()
	{
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
		mchbBlockAllPorts.CheckedChanged += mchbBlockAllPorts_CheckedChanged;
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

	private void OnButtonCancel()
	{
		icontainer_0 = new Container();
		new ComponentResourceManager(typeof(AdvancedBlockingSettingsDialog));
		mbtnSave = new Class66();
		btnCancel = new Class66();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlnkOnlineHelp = new GClass3();
		mchbBlockAllPorts = new Class61();
		mlblBlockAllPortsHint = new Class63();
		mlblPortsHint = new Class63();
		mlblPorts = new Class62();
		medPorts = new TextBox();
		mlblPerformanceWarning = new Class62();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(263, 257);
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
		btnCancel.Location = new Point(371, 257);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 8;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(456, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(199, 16);
		label2.TabIndex = 49;
		label2.Text = "Advanced blocking settings";
		imgBigIcon.Image = Resources.firewall_edit_48;
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
		lblCaption.Size = new Size(206, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Advanced settings for IP blocking";
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(399, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 9;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mchbBlockAllPorts.AutoSize = true;
		mchbBlockAllPorts.Location = new Point(16, 97);
		mchbBlockAllPorts.Name = "m_chbBlockAllPorts";
		mchbBlockAllPorts.Size = new Size(351, 20);
		mchbBlockAllPorts.TabIndex = 0;
		mchbBlockAllPorts.Text = "Block access to all ports on the server (recommended)";
		mchbBlockAllPorts.UseVisualStyleBackColor = true;
		mlblBlockAllPortsHint.AutoSize = true;
		mlblBlockAllPortsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblBlockAllPortsHint.Location = new Point(13, 122);
		mlblBlockAllPortsHint.Name = "m_lblBlockAllPortsHint";
		mlblBlockAllPortsHint.Size = new Size(297, 16);
		mlblBlockAllPortsHint.TabIndex = 58;
		mlblBlockAllPortsHint.Text = "Turn on to block access to all ports  on the server";
		mlblPortsHint.AutoSize = true;
		mlblPortsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblPortsHint.Location = new Point(20, 213);
		mlblPortsHint.Name = "m_lblPortsHint";
		mlblPortsHint.Size = new Size(426, 16);
		mlblPortsHint.TabIndex = 71;
		mlblPortsHint.Text = "You can also specify multiple comma-separated ports, i.e. 3389, 21, 25";
		mlblPorts.AutoSize = true;
		mlblPorts.Location = new Point(13, 157);
		mlblPorts.Name = "m_lblPorts";
		mlblPorts.Size = new Size(92, 16);
		mlblPorts.TabIndex = 70;
		mlblPorts.Text = "Ports to block:";
		medPorts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medPorts.Location = new Point(23, 183);
		medPorts.Name = "m_edPorts";
		medPorts.Size = new Size(448, 22);
		medPorts.TabIndex = 77;
		mlblPerformanceWarning.AutoSize = true;
		mlblPerformanceWarning.ForeColor = Color.Red;
		mlblPerformanceWarning.Location = new Point(103, 157);
		mlblPerformanceWarning.Name = "m_lblPerformanceWarning";
		mlblPerformanceWarning.Size = new Size(356, 16);
		mlblPerformanceWarning.TabIndex = 78;
		mlblPerformanceWarning.Text = "(network performance may be affected, please check help)";
		mlblPerformanceWarning.Boolean_0 = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(484, 306);
		base.Controls.Add(mlblPerformanceWarning);
		base.Controls.Add(medPorts);
		base.Controls.Add(mlblPortsHint);
		base.Controls.Add(mlblPorts);
		base.Controls.Add(mlblBlockAllPortsHint);
		base.Controls.Add(mchbBlockAllPorts);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "AdvancedBlockingSettingsDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Blocking Settings";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_5);
	}

	private void mchbBlockAllPorts_CheckedChanged(object sender, EventArgs e)
	{
		bool enabled = !mchbBlockAllPorts.Checked;
		mlblPorts.Enabled = enabled;
		mlblPerformanceWarning.Enabled = enabled;
		medPorts.Enabled = enabled;
		mlblPortsHint.Enabled = enabled;
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
