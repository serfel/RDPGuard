using System;
using System.ServiceProcess;

internal class Class84
{
	private readonly string string_0;

	private ServiceController serviceController_0;

	private ServiceController ServiceController_0
	{
		get
		{
			if (serviceController_0 == null)
			{
				serviceController_0 = new ServiceController(string_0);
			}
			serviceController_0.Refresh();
			return serviceController_0;
		}
	}

	public bool Boolean_0
	{
		get
		{
			try
			{
				_ = ServiceController_0.Status;
				return true;
			}
			catch (InvalidOperationException)
			{
				return false;
			}
		}
	}

	public bool Boolean_1 => ServiceControllerStatus.Running == ServiceControllerStatus_0;

	public bool Boolean_2 => ServiceControllerStatus.Stopped == ServiceControllerStatus_0;

	public bool Boolean_3 => ServiceControllerStatus.StopPending == ServiceControllerStatus_0;

	public ServiceControllerStatus ServiceControllerStatus_0
	{
		get
		{
			if (!Boolean_0)
			{
				return ServiceControllerStatus.Stopped;
			}
			return ServiceController_0.Status;
		}
	}

	public Class84(string string_1)
	{
		string_0 = string_1;
	}

	public void method_0()
	{
		ServiceController_0.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 10));
	}

	public void method_1()
	{
		try
		{
			ServiceController_0.Start();
		}
		catch
		{
			Class87.smethod_1(string_0);
		}
	}

	public void method_2()
	{
		try
		{
			ServiceController_0.Stop();
		}
		catch
		{
			Class87.smethod_2(string_0);
		}
	}

	public void method_3()
	{
		try
		{
			if (!Boolean_2 && !Boolean_3)
			{
				ServiceController_0.Stop();
			}
			ServiceController_0.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 5));
			if (Boolean_2)
			{
				ServiceController_0.Start();
			}
		}
		catch
		{
			Class87.smethod_3(string_0);
		}
	}
}
