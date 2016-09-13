using System;
using System.Collections.Generic;

namespace Robotics.Mobile.Core.Bluetooth.LE
{
	public interface IAdapter
	{
		// events
		event EventHandler<DeviceDiscoveredEventArgs> DeviceDiscovered;
		event EventHandler<DeviceConnectionEventArgs> DeviceConnected;
		event EventHandler<DeviceConnectionEventArgs> DeviceDisconnected;
		//TODO: add this
		//event EventHandler<DeviceConnectionEventArgs> DeviceFailedToConnect;
		event EventHandler ScanTimeoutElapsed;
		//TODO: add this
		//event EventHandler ConnectTimeoutElapsed;

		// properties
		bool IsScanning { get; }
		IList<IDevice> DiscoveredDevices { get; }
		IList<IDevice> ConnectedDevices { get; }

		// methods
		void StartScanningForDevices (int timeOutSeconds = 10);
		void StartScanningForDevices (Guid serviceUuid, int timeOutSeconds = 10);

		void StopScanningForDevices ();
		void ConnectToDevice (IDevice device);
		void DisconnectDevice (IDevice device);

	}
}

