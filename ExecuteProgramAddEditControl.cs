using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ExecuteProgramAddEditControl : Control4
{
	private readonly Dictionary<GEnum2, string> dictionary_0 = new Dictionary<GEnum2, string>
	{
		{
			GEnum2.const_0,
			"ip-blocked %IP% %USER% %PROTOCOL%"
		},
		{
			GEnum2.const_1,
			"ip-unblocked %IP% %USER% %PROTOCOL%"
		},
		{
			GEnum2.const_2,
			"user-logged-in %IP% %USER%"
		},
		{
			GEnum2.const_3,
			"new-version %NEW_VERSION_NUMBER% %NEW_VERSION_LINK%"
		},
		{
			GEnum2.const_4,
			"maintenance-expiring %MAINTENANCE_DAYS%"
		},
		{
			GEnum2.const_5,
			"maintenance-expired"
		}
	};

	private readonly Dictionary<GEnum2, string> dictionary_1 = new Dictionary<GEnum2, string>
	{
		{
			GEnum2.const_0,
			"%IP% - IP address\r\n%USER% - User name\r\n%BLOCK_DATE% - Block Date\r\n%UNBLOCK_DATE% - Unblock Date\r\n%PROTOCOL% - Protocol"
		},
		{
			GEnum2.const_1,
			"%IP% - IP address\r\n%USER% - User name\r\n%BLOCK_DATE% - Block Date\r\n%UNBLOCK_DATE% - Unblock Date\r\n%PROTOCOL% - Protocol"
		},
		{
			GEnum2.const_2,
			"%IP% - IP address\r\n%USER% - User name"
		},
		{
			GEnum2.const_3,
			"%NEW_VERSION_NUMBER% - New version number\r\n%NEW_VERSION_LINK% - New version download link"
		},
		{
			GEnum2.const_4,
			"%MAINTENANCE_DAYS% - Maintenance days remaining"
		},
		{
			GEnum2.const_5,
			null
		}
	};

	private IContainer icontainer_0;

	private Class65 mgrbSettings;

	private TextBox medArguments;

	private Class62 mlblArguments;

	private Class63 mlblArgumentsHint;

	private Class54 medPath;

	private Class62 mlblPath;

	private Class63 mlblPathHint;

	private GClass2 mlblVariablesHint;

	private PictureBox mpicLoading;

	private GClass3 mlnkTestRun;

	public override Size Size_0 => new Size(570, 340);

	public override GClass3 GClass3_0 => mlnkTestRun;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class174
			{
				string_2 = medPath.Text,
				string_3 = medArguments.Text
			};
		}
		set
		{
			Class174 @class = value as Class174;
			medPath.Text = @class.string_2;
			medArguments.Text = @class.string_3;
		}
	}

	public override void UpdateTaskType(GEnum2 genum2_0)
	{
		medArguments.Text = dictionary_0[genum2_0];
		string text = dictionary_1[genum2_0];
		mlblVariablesHint.Text = "You can use the following variables as arguments:\r\n" + new string('-', 100) + "\r\n" + text + ((string.IsNullOrEmpty(text) ? true : false) ? null : "\r\n") + "%HOSTNAME% - Host name\r\n%TOTAL_IP_BLOCKED% - Total IP addresses currently blocked";
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
		mlblPath.Enabled = bool_1;
		mlblPathHint.Enabled = bool_1;
		medPath.Enabled = bool_1;
		mlblArguments.Enabled = bool_1;
		mlblArgumentsHint.Enabled = bool_1;
		medArguments.Enabled = bool_1;
		mlnkTestRun.Enabled = bool_1;
	}

	protected override void AdjustFormSize()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(medPath.Text);
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
		mgrbSettings = new Class65();
		mlblVariablesHint = new GClass2();
		mpicLoading = new PictureBox();
		mlnkTestRun = new GClass3();
		medArguments = new TextBox();
		mlblArguments = new Class62();
		mlblArgumentsHint = new Class63();
		medPath = new Class54();
		mlblPath = new Class62();
		mlblPathHint = new Class63();
		mgrbSettings.SuspendLayout();
		((ISupportInitialize)mpicLoading).BeginInit();
		SuspendLayout();
		mgrbSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mgrbSettings.Controls.Add(mlblVariablesHint);
		mgrbSettings.Controls.Add(mpicLoading);
		mgrbSettings.Controls.Add(mlnkTestRun);
		mgrbSettings.Controls.Add(medArguments);
		mgrbSettings.Controls.Add(mlblArguments);
		mgrbSettings.Controls.Add(mlblArgumentsHint);
		mgrbSettings.Controls.Add(medPath);
		mgrbSettings.Controls.Add(mlblPath);
		mgrbSettings.Controls.Add(mlblPathHint);
		mgrbSettings.Location = new Point(4, 4);
		mgrbSettings.Margin = new Padding(4);
		mgrbSettings.Name = "m_grbSettings";
		mgrbSettings.Padding = new Padding(4);
		mgrbSettings.Size = new Size(559, 333);
		mgrbSettings.TabIndex = 38;
		mgrbSettings.TabStop = false;
		mgrbSettings.Text = "Settings";
		mlblVariablesHint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlblVariablesHint.BackColor = SystemColors.Control;
		mlblVariablesHint.BorderStyle = BorderStyle.None;
		mlblVariablesHint.Enabled = false;
		mlblVariablesHint.ForeColor = SystemColors.ControlDarkDark;
		mlblVariablesHint.Location = new Point(19, 166);
		mlblVariablesHint.Name = "m_lblVariablesHint";
		mlblVariablesHint.Size = new Size(449, 160);
		mlblVariablesHint.TabIndex = 88;
		mpicLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mpicLoading.Location = new Point(474, 313);
		mpicLoading.Name = "m_picLoading";
		mpicLoading.Size = new Size(16, 16);
		mpicLoading.TabIndex = 87;
		mpicLoading.TabStop = false;
		mpicLoading.Visible = false;
		mlnkTestRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mlnkTestRun.AutoSize = true;
		mlnkTestRun.LinkBehavior = LinkBehavior.NeverUnderline;
		mlnkTestRun.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkTestRun.Location = new Point(496, 313);
		mlnkTestRun.Name = "m_lnkTestRun";
		mlnkTestRun.RightToLeft = RightToLeft.No;
		mlnkTestRun.Size = new Size(49, 16);
		mlnkTestRun.TabIndex = 86;
		mlnkTestRun.TabStop = true;
		mlnkTestRun.Text = "test run";
		mlnkTestRun.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		medArguments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medArguments.Location = new Point(187, 97);
		medArguments.Name = "m_edArguments";
		medArguments.Size = new Size(362, 22);
		medArguments.TabIndex = 83;
		mlblArguments.AutoSize = true;
		mlblArguments.Location = new Point(16, 97);
		mlblArguments.Name = "m_lblArguments";
		mlblArguments.Size = new Size(74, 16);
		mlblArguments.TabIndex = 85;
		mlblArguments.Text = "Arguments:";
		mlblArgumentsHint.AutoSize = true;
		mlblArgumentsHint.ForeColor = SystemColors.ControlDarkDark;
		mlblArgumentsHint.Location = new Point(184, 125);
		mlblArgumentsHint.Name = "m_lblArgumentsHint";
		mlblArgumentsHint.Size = new Size(123, 16);
		mlblArgumentsHint.TabIndex = 84;
		mlblArgumentsHint.Text = "Optional arguments";
		medPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		medPath.String_1 = null;
		medPath.Location = new Point(187, 32);
		medPath.Name = "m_edPath";
		medPath.Size = new Size(362, 22);
		medPath.TabIndex = 80;
		mlblPath.AutoSize = true;
		mlblPath.Location = new Point(16, 32);
		mlblPath.Name = "m_lblPath";
		mlblPath.Size = new Size(98, 16);
		mlblPath.TabIndex = 82;
		mlblPath.Text = "Program/script:";
		mlblPathHint.AutoSize = true;
		mlblPathHint.ForeColor = SystemColors.ControlDarkDark;
		mlblPathHint.Location = new Point(184, 60);
		mlblPathHint.Name = "m_lblPathHint";
		mlblPathHint.Size = new Size(331, 16);
		mlblPathHint.TabIndex = 81;
		mlblPathHint.Text = "Specify the path of the program or script you want to run";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(mgrbSettings);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "ExecuteProgramAddEditControl";
		base.Size = new Size(570, 340);
		mgrbSettings.ResumeLayout(performLayout: false);
		mgrbSettings.PerformLayout();
		((ISupportInitialize)mpicLoading).EndInit();
		ResumeLayout(performLayout: false);
	}
}
