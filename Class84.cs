using System;
using System.ServiceProcess;

internal class Class84
{
	private readonly string string_0;

	private ServiceController serviceController_0;

	private ServiceController _ServiceController
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
				_ = _ServiceController.Status;
				return true;
			}
			catch (InvalidOperationException)
			{
				return false;
			}
		}
	}

	public bool IsRunning => ServiceControllerStatus.Running == _ServiceControllerStatus;

	public bool IsStopped => ServiceControllerStatus.Stopped == _ServiceControllerStatus;

	public bool IsStopPending => ServiceControllerStatus.StopPending == _ServiceControllerStatus;

	public ServiceControllerStatus _ServiceControllerStatus
	{
		get
		{
			if (!Boolean_0)
			{
				return ServiceControllerStatus.Stopped;
			}
			return _ServiceController.Status;
		}
	}

	public Class84(string string_1)
	{
		string_0 = string_1;
	}

	public void method_0()
	{
		_ServiceController.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 10));
	}

	public void method_1()
	{
		try
		{
			_ServiceController.Start();
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
			_ServiceController.Stop();
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
			if (!IsStopped && !IsStopPending)
			{
				_ServiceController.Stop();
			}
			_ServiceController.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 5));
			if (IsStopped)
			{
				_ServiceController.Start();
			}
		}
		catch
		{
			Class87.smethod_3(string_0);
		}
	}
}
