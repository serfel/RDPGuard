using System.Drawing;

internal class Control4 : Control2
{
	private readonly GClass3 gclass3_0;

	private GClass10 gclass10_0;

	public override Size Size_0 => new Size(640, 480);

	public virtual GClass3 GClass3_0 => gclass3_0;

	public virtual GClass10 GClass10_0
	{
		get
		{
			return gclass10_0;
		}
		set
		{
			gclass10_0 = value;
		}
	}

	protected override void OnFormClosing()
	{
	}

	protected override void InitializeFormPosition()
	{
	}

	protected override void AdjustFormSize()
	{
	}

	public virtual void UpdateTaskType(GEnum2 genum2_0)
	{
	}

	public virtual bool ValidateInput()
	{
		return true;
	}

	public virtual void SetEditMode(bool bool_1)
	{
	}
}
