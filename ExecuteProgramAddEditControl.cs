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

	private Class65 class65_0;

	private TextBox textBox_0;

	private Class62 class62_0;

	private Class63 class63_0;

	private Class54 class54_0;

	private Class62 class62_1;

	private Class63 class63_1;

	private GClass2 gclass2_0;

	private PictureBox pictureBox_0;

	private GClass3 gclass3_1;

	public override Size Size_0 => new Size(570, 340);

	public override GClass3 GClass3_0 => gclass3_1;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class174
			{
				string_2 = class54_0.Text,
				string_3 = textBox_0.Text
			};
		}
		set
		{
			Class174 @class = value as Class174;
			class54_0.Text = @class.string_2;
			textBox_0.Text = @class.string_3;
		}
	}

	public override void vmethod_3(GEnum2 genum2_0)
	{
		textBox_0.Text = dictionary_0[genum2_0];
		string text = dictionary_1[genum2_0];
		gclass2_0"You can use the following variables as arguments:\r\n" + new string('-', 100) + "\r\n" + text + ((string.IsNullOrEmpty(text) ? true : false) ? null : "\r\n") + "%HOSTNAME% - Host name\r\n%TOTAL_IP_BLOCKED% - Total IP addresses currently blocked";
	}

	public override bool vmethod_4()
	{
		return true;
	}

	protected override void vmethod_0()
	{
		InitializeComponent();
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void vmethod_1()
	{
	}

	public override void vmethod_5(bool bool_1)
	{
		pictureBox_0.Visible = !bool_1;
		class62_1.Enabled = bool_1;
		class63_1.Enabled = bool_1;
		class54_0.Enabled = bool_1;
		class62_0.Enabled = bool_1;
		class63_0.Enabled = bool_1;
		textBox_0.Enabled = bool_1;
		gclass3_1.Enabled = bool_1;
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(class54_0.Text);
		gclass3_1.Enabled = base.Boolean_0;
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
		class65_0 = new Class65();
		gclass2_0 = new GClass2();
		pictureBox_0 = new PictureBox();
		gclass3_1 = new GClass3();
		textBox_0 = new TextBox();
		class62_0 = new Class62();
		class63_0 = new Class63();
		class54_0 = new Class54();
		class62_1 = new Class62();
		class63_1 = new Class63();
		class65_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(gclass2_0);
		class65_0.Controls.Add(pictureBox_0);
		class65_0.Controls.Add(gclass3_1);
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Controls.Add(class54_0);
		class65_0.Controls.Add(class62_1);
		class65_0.Controls.Add(class63_1);
		class65_0.Location = new Point(4, 4);
		class65_0.Margin = new Padding(4);
		class65_0.Name = "m_grbSettings";
		class65_0.Padding = new Padding(4);
		class65_0.Size = new Size(559, 333);
		class65_0.TabIndex = 38;
		class65_0.TabStop = false;
		class65_0.Text = "Настройки";
		gclass2_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass2_0.BackColor = SystemColors.Control;
		gclass2_0.BorderStyle = BorderStyle.None;
		gclass2_0.Enabled = false;
		gclass2_0.ForeColor = SystemColors.ControlDarkDark;
		gclass2_0.Location = new Point(19, 166);
		gclass2_0.Name = "m_lblVariablesHint";
		gclass2_0.Size = new Size(449, 160);
		gclass2_0.TabIndex = 88;
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(474, 313);
		pictureBox_0.Name = "m_picLoading";
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.TabIndex = 87;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(496, 313);
		gclass3_1.Name = "m_lnkTestRun";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(49, 16);
		gclass3_1.TabIndex = 86;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "тестовый запуск";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(187, 97);
		textBox_0.Name = "m_edArguments";
		textBox_0.Size = new Size(362, 22);
		textBox_0.TabIndex = 83;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(16, 97);
		class62_0.Name = "m_lblArguments";
		class62_0.Size = new Size(74, 16);
		class62_0.TabIndex = 85;
		class62_0.Text = "Аргументы:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(184, 125);
		class63_0.Name = "m_lblArgumentsHint";
		class63_0.Size = new Size(123, 16);
		class63_0.TabIndex = 84;
		class63_0.Text = "Необязательные аргументы";
		class54_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class54_0.String_1 = null;
		class54_0.Location = new Point(187, 32);
		class54_0.Name = "m_edPath";
		class54_0.Size = new Size(362, 22);
		class54_0.TabIndex = 80;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(16, 32);
		class62_1.Name = "m_lblPath";
		class62_1.Size = new Size(98, 16);
		class62_1.TabIndex = 82;
		class62_1"Program/script:";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(184, 60);
		class63_1.Name = "m_lblPathHint";
		class63_1.Size = new Size(331, 16);
		class63_1.TabIndex = 81;
		class63_1"Specify the path of the program or script you want to run";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "ExecuteProgramAddEditControl";
		base.Size = new Size(570, 340);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}
}
