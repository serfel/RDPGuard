using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ReportToAbuseIPDBAddEditControl : Control4
{
	private IContainer icontainer_0;

	private Class65 mgrbSettings;

	private TextBox medApiKey;

	private Class62 mlblApiKey;

	private Class63 mlblApiKeyHint;

	private PictureBox mpicLoading;

	private GClass3 mlnkTestRun;

	public override Size Size_0 => new Size(570, 120);

	public override GClass3 GClass3_0 => mlnkTestRun;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class172
			{
				string_2 = medApiKey.Text
			};
		}
		set
		{
			medApiKey.Text = ((Class172)value).string_2;
		}
	}

	public override void UpdateTaskType(GEnum2 genum2_0)
	{
	}

	public override bool ValidateInput()
	{
		return true;
	}

	protected override void OnFormClosing()
	{
		InitializeComponent();
		mpicLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void InitializeFormPosition()
	{
	}

	public override void SetEditMode(bool bool_1)
	{
		mpicLoading.Visible = !bool_1;
		mlblApiKey.Enabled = bool_1;
		mlblApiKeyHint.Enabled = bool_1;
		medApiKey.Enabled = bool_1;
		mlnkTestRun.Enabled = bool_1;
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(medApiKey.Text);
		mlnkTestRun.Enabled = base.Boolean_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		new ComponentResourceManager(typeof(ReportToAbuseIPDBAddEditControl));
		mgrbSettings = new Class65();
		mpicLoading = new PictureBox();
		mlnkTestRun = new GClass3();
		medApiKey = new TextBox();
		mlblApiKey = new Class62();
		mlblApiKeyHint = new Class63();
		mgrbSettings.SuspendLayout();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mgrbSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mgrbSettings.Controls.Add(mpicLoading);
		mgrbSettings.Controls.Add(mlnkTestRun);
		mgrbSettings.Controls.Add(medApiKey);
		mgrbSettings.Controls.Add(mlblApiKey);
		mgrbSettings.Controls.Add(mlblApiKeyHint);
		mgrbSettings.Location = new Point(4, 4);
		mgrbSettings.Margin = new Padding(4);
		mgrbSettings.Name = "m_grbSettings";
		mgrbSettings.Padding = new Padding(4);
		mgrbSettings.Size = new Size(608, 315);
		mgrbSettings.TabIndex = 38;
		mgrbSettings.TabStop = false;
		mgrbSettings.Text = "Settings";
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mpicLoading.Location = new Point(523, 295);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 87;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlnkTestRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mlnkTestRun.AutoSize = true;
		mlnkTestRun.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkTestRun.Location = new Point(545, 295);
		mlnkTestRun.Name = "m_lnkTestRun";
		mlnkTestRun.RightToLeft = RightToLeft.No;
		mlnkTestRun.Size = new Size(56, 16);
		mlnkTestRun.TabIndex = 86;
		mlnkTestRun.TabStop = true;
		mlnkTestRun.Text = "test run";
		mlnkTestRun.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medApiKey.Location = new Point(187, 32);
		medApiKey.Name = "m_edApiKey";
		medApiKey.Size = new Size(411, 22);
		medApiKey.TabIndex = 80;
		mlblApiKey.AutoSize = true;
		mlblApiKey.Location = new Point(16, 32);
		mlblApiKey.Name = "m_lblApiKey";
		mlblApiKey.Size = new Size(99, 16);
		mlblApiKey.TabIndex = 82;
		mlblApiKey.Text = "API key:";
		mlblApiKeyHint.AutoSize = true;
		mlblApiKeyHint.ForeColor = SystemColors.ControlDarkDark;
		mlblApiKeyHint.Location = new Point(184, 60);
		mlblApiKeyHint.Name = "m_lblApiKeyHint";
		mlblApiKeyHint.Size = new Size(332, 16);
		mlblApiKeyHint.TabIndex = 81;
		mlblApiKeyHint.Text = "Please enter your AbuseIPDB API key";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgrbSettings);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "ReportToAbuseIPDBAddEditControl";
		base.Size = new Size(619, 322);
		mgrbSettings.ResumeLayout(performLayout: false);
		mgrbSettings.PerformLayout();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
	}
}
