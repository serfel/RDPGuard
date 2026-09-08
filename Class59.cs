using System.Drawing;
using System.Windows.Forms;

internal sealed class Class59 : ToolStripProfessionalRenderer
{
	public class Class60 : ProfessionalColorTable
	{
		public override Color ImageMarginGradientBegin => Class70.color_1;

		public override Color ImageMarginGradientMiddle => Class70.color_1;

		public override Color ImageMarginGradientEnd => Class70.color_1;

		public Class60()
		{
			base.UseSystemColors = !Class163.Class163_0.Boolean_0;
		}
	}

	public Class59()
		: base(new Class60())
	{
		base.ColorTable.UseSystemColors = !Class163.Class163_0.Boolean_0;
	}

	protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			base.OnRenderToolStripBorder(toolStripRenderEventArgs_0);
			return;
		}
		int num = toolStripRenderEventArgs_0.AffectedBounds.Height - 1;
		Color color = ((toolStripRenderEventArgs_0.ToolStrip.Enabled ? true : false) ? Class70.color_13 : Class70.color_14);
		GEnum0 gEnum = GEnum0.flag_5;
		if (toolStripRenderEventArgs_0.ToolStrip is Class67 @class)
		{
			color = Class70.color_14;
			gEnum = @class.gEnum;
		}
		if (toolStripRenderEventArgs_0.ToolStrip is StatusStrip)
		{
			color = Class70.color_0;
		}
		if (toolStripRenderEventArgs_0.ToolStrip is MenuStrip)
		{
			color = Class70.color_0;
			gEnum = GEnum0.flag_1 | GEnum0.flag_2;
		}
		using Pen pen = new Pen(color);
		if (gEnum.HasFlag(GEnum0.flag_1))
		{
			toolStripRenderEventArgs_0.Graphics.DrawLine(pen, 0, 0, toolStripRenderEventArgs_0.AffectedBounds.Width, 0);
		}
		if (gEnum.HasFlag(GEnum0.flag_2))
		{
			toolStripRenderEventArgs_0.Graphics.DrawLine(pen, 0, num, toolStripRenderEventArgs_0.AffectedBounds.Width, num);
		}
		if (gEnum.HasFlag(GEnum0.flag_3))
		{
			toolStripRenderEventArgs_0.Graphics.DrawLine(pen, 0, 0, 0, num);
		}
		if (gEnum.HasFlag(GEnum0.flag_4))
		{
			toolStripRenderEventArgs_0.Graphics.DrawLine(pen, toolStripRenderEventArgs_0.AffectedBounds.Width - 1, 0, toolStripRenderEventArgs_0.AffectedBounds.Width - 1, num);
		}
	}

	protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			toolStripRenderEventArgs_0.ToolStrip.BackColor = Class70.color_1;
		}
		base.OnRenderToolStripBackground(toolStripRenderEventArgs_0);
	}

	protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			base.OnRenderButtonBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		Rectangle rect = new Rectangle(Point.Empty, toolStripItemRenderEventArgs_0.Item.Size);
		bool flag = toolStripItemRenderEventArgs_0.Item is ToolStripButton toolStripButton && toolStripButton.Checked;
		using (SolidBrush brush = new SolidBrush((((toolStripItemRenderEventArgs_0.Item.Pressed ? true : false) || toolStripItemRenderEventArgs_0.Item.Selected || flag) ? true : false) ? Class70.color_5 : Class70.color_1))
		{
			toolStripItemRenderEventArgs_0.Graphics.FillRectangle(brush, rect);
		}
		if (!((toolStripItemRenderEventArgs_0.Item.Pressed ? true : false) || toolStripItemRenderEventArgs_0.Item.Selected || flag))
		{
			return;
		}
		using Pen pen = new Pen(Class70.color_6);
		toolStripItemRenderEventArgs_0.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1);
	}

	protected override void OnRenderArrow(ToolStripArrowRenderEventArgs toolStripArrowRenderEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0)
		{
			toolStripArrowRenderEventArgs_0.ArrowColor = Class70.color_2;
		}
		base.OnRenderArrow(toolStripArrowRenderEventArgs_0);
	}

	protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		OnRenderButtonBackground(toolStripItemRenderEventArgs_0);
	}

	protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			base.OnRenderMenuItemBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		Rectangle rect = new Rectangle(Point.Empty, toolStripItemRenderEventArgs_0.Item.Size);
		using (SolidBrush brush = new SolidBrush((toolStripItemRenderEventArgs_0.Item.Pressed || false || (toolStripItemRenderEventArgs_0.Item.Selected ? true : false)) ? Class70.color_5 : Class70.color_1))
		{
			toolStripItemRenderEventArgs_0.Graphics.FillRectangle(brush, rect);
		}
		if (!toolStripItemRenderEventArgs_0.Item.Pressed && !toolStripItemRenderEventArgs_0.Item.Selected)
		{
			return;
		}
		using Pen pen = new Pen(Class70.color_6);
		toolStripItemRenderEventArgs_0.Graphics.DrawRectangle(pen, 2, 0, rect.Width - 4, rect.Height - 1);
	}

	protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs_0)
	{
		if (!Class163.Class163_0.Boolean_0)
		{
			base.OnRenderItemText(toolStripItemTextRenderEventArgs_0);
			return;
		}
		Color textColor = toolStripItemTextRenderEventArgs_0.TextColor;
		toolStripItemTextRenderEventArgs_0.TextColor = ((toolStripItemTextRenderEventArgs_0.Item.Enabled ? true : false) ? Class70.color_2 : Class70.color_7);
		if ("ThemeIndependentForeColor" == toolStripItemTextRenderEventArgs_0.Item.Tag?.ToString())
		{
			toolStripItemTextRenderEventArgs_0.TextColor = textColor;
		}
		if (toolStripItemTextRenderEventArgs_0.Item is ToolStripStatusLabel)
		{
			toolStripItemTextRenderEventArgs_0.TextColor = Class70.color_7;
		}
		TextRenderer.DrawText(toolStripItemTextRenderEventArgs_0.Graphics, toolStripItemTextRenderEventArgs_0.Text, toolStripItemTextRenderEventArgs_0.TextFont, toolStripItemTextRenderEventArgs_0.TextRectangle, toolStripItemTextRenderEventArgs_0.TextColor, toolStripItemTextRenderEventArgs_0.TextFormat);
	}

	protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs toolStripSeparatorRenderEventArgs_0)
	{
		if (Class163.Class163_0.Boolean_0 && !(toolStripSeparatorRenderEventArgs_0.ToolStrip is ToolStripDropDownMenu))
		{
			Color color = ((toolStripSeparatorRenderEventArgs_0.Item.Enabled ? true : false) ? Class70.color_17 : Class70.color_18);
			int num = toolStripSeparatorRenderEventArgs_0.Item.Width / 2 - 1;
			using Pen pen = new Pen(color);
			toolStripSeparatorRenderEventArgs_0.Graphics.DrawLine(pen, num, 0, num, toolStripSeparatorRenderEventArgs_0.Item.Height);
			return;
		}
		base.OnRenderSeparator(toolStripSeparatorRenderEventArgs_0);
	}
}
