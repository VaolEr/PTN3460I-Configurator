using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.Collections.ObjectModel;

namespace PTN3460I_Configurator
{
    public class USB
    {
        public Int32 USB_VID;
        public Int32 USB_PID;

        public  String DeviceInfoStatus     = "Device Info Status";
        public  String DeviceSerialNumber   = "Device Serial Number";
        public  String DeviceProductName    = "Device Product Name";
        public  String DeviceManufacturer   = "Device Manufacturer";

        public  String ErrorMessage         = "Error_message";

        public String MessageReportID;

        public bool DeviceOnBusDetected = false;

        /// <summary>
        /// Constructor of USB device class
        /// </summary>
        /// <param name="USB_VID">Device Vendor ID</param>
        /// <param name="USB_PID">Device Product ID</param>
        public USB(Int32 USB_VID, Int32 USB_PID)
        {
            this.USB_VID = USB_VID;
            this.USB_PID = USB_PID;

            DeviceInfoStatus = "Device Info Status";
        }

        public static UsbDevice MyUsbDevice;
        
        static ErrorCode ec = ErrorCode.None;


        #region Functions for connect & disconnect USB device
        /// <summary>
        /// Function to find USB device using VID & PID data from class member
        /// </summary>
        public void FindUSBDevice()
        {
            //this.USB_VID = USB_VID;
            //this.USB_PID = USB_PID;

            try
            {
                var myUsbFinder = new UsbDeviceFinder(USB_VID, USB_PID);

                MyUsbDevice = UsbDevice.OpenUsbDevice(myUsbFinder);
                

                if (MyUsbDevice != null)
                {
                    DeviceInfoStatus = "Connected";

                    DeviceSerialNumber = MyUsbDevice.Info.SerialString;
                    DeviceProductName = MyUsbDevice.Info.ProductString;
                    DeviceManufacturer = MyUsbDevice.Info.ManufacturerString;

                    // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                    // it exposes an IUsbDevice interface. If not (WinUSB) the 
                    // 'wholeUsbDevice' variable will be null indicating this is 
                    // an interface of a device; it does not require or support 
                    // configuration and interface selection.
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;

                    if (wholeUsbDevice != null)
                    {
                        DeviceInfoStatus = "Connected Full";
                    }
                }
                else
                {
                    DeviceInfoStatus = "Device not found!";
                }
                
                ErrorMessage = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = "FindUSBDevice function error: " + Environment.NewLine + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message; // is this condition true ? yes : no
            }
            finally
            {

            }
        }
        /// <summary>
        /// Find USB device function
        /// </summary>
        /// <param name="USB_VID">The value of Vendor ID</param>
        /// <param name="USB_PID">The value of Product ID</param>
        public void FindUSBDeviceByVIDPID(Int32 USB_VID, Int32 USB_PID)
        {
            this.USB_VID = USB_VID;
            this.USB_PID = USB_PID;

            try
            {
                var myUsbFinder = new UsbDeviceFinder(USB_VID, USB_PID);
                MyUsbDevice = UsbDevice.OpenUsbDevice(myUsbFinder);

                if (MyUsbDevice != null)
                {
                    DeviceInfoStatus = "Connected";

                    DeviceSerialNumber = MyUsbDevice.Info.SerialString;
                    DeviceProductName = MyUsbDevice.Info.ProductString;
                    DeviceManufacturer = MyUsbDevice.Info.ManufacturerString;

                    // If this is a "whole" usb device (libusb-win32, linux libusb-1.0)
                    // it exposes an IUsbDevice interface. If not (WinUSB) the 
                    // 'wholeUsbDevice' variable will be null indicating this is 
                    // an interface of a device; it does not require or support 
                    // configuration and interface selection.
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;

                    if (wholeUsbDevice != null)
                    {
                        DeviceInfoStatus = "Connected Full";
                    }
                }
                else
                {
                    DeviceInfoStatus = "Device not found!";
                }

                ErrorMessage = "";

            }
            catch (Exception ex)
            {
                ErrorMessage = "FindUSBDeviceByVIDPID function error: " + Environment.NewLine + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message; // is this condition true ? yes : no
            }
            finally
            {

            }
        }
        /// <summary>
        /// Free connected USB device
        /// </summary>
        public void DiconnectUSB()
        {
            if (MyUsbDevice != null)
            {
                if (MyUsbDevice.Close())
                {
                    MyUsbDevice = null;
                    DeviceInfoStatus = "Disconnected";
                }
            }
            UsbDevice.Exit();
        }
        #endregion

        #region Functions and veriables for get data from USB device (data to HOST; input interruptions)
        public byte[] USBreadDataBuffer = new byte[1024];
        byte[] USBreadBuffer = new byte[1024];
        public int CountOfGotBytes = 0;
        /// <summary>
        /// Function to get data, translated on USB bus for connected device using the report ID
        /// </summary>
        /// <param name="ReportID_IN">The value of report ID</param>
        public void GetData(Int32 ReportID_IN)
        {
            // get the data from USB device by Report ID
            try
            {
                var CountOfBytes = 1;
                var ReportID = ReportID_IN; 

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;

                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);
                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                        // open read endpoint 1.
                    }   
                        //UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01, 8, LibUsbDotNet.Main.EndpointType.Interrupt);
                        UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);


                        int i = 0;

                        ErrorMessage = "Ошибок нет";

                        while (i < CountOfBytes)
                        {
                            
                            // If the device hasn't sent data in the last 5 seconds,
                            // a timeout error (ec = IoTimedOut) will occur. 
                            ec = reader.Read(USBreadBuffer, 5000, out CountOfGotBytes);

                            if (CountOfGotBytes == 0) throw new Exception(string.Format("{0}:No more bytes!", ec));

                            // fill the fields in the normal work mode
                            MessageReportID = "Report ID сообщения - 0 x " + Convert.ToString(USBreadBuffer[0], 16).ToUpper();

                            if (USBreadBuffer[0] == ReportID)
                            {
                                i++;
                                
                                for (int j = 0; j < CountOfGotBytes-1; j++)
                                {
                                    USBreadDataBuffer[j] = USBreadBuffer[j+1];
                                }

                            }   
                        }
                        if (i >= CountOfBytes)
                        {
                            i = 0;
                        }                   
                }

                ErrorMessage = "";

            }
            catch (Exception ex)
            {
                ErrorMessage = "GetData function error: " + "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;

                if (ex.Message.ToString().Equals("Win32Error:No more bytes!"))
                {
                    FindUSBDeviceByVIDPID(USB_VID, USB_PID);
                }
            }
        }
        #endregion

        #region Functions and veriables for send data to USB device (data from HOST; output interruptions)
        public byte[] USBwriteBuffer = new byte[1024];
        public int CountOfSentBytes = 0;
        /// <summary>
        /// Function to send 8 data bytes to USB HID device by Report ID in Endpoint 1 from the 0 offset
        /// </summary>
        /// <param name="ReportID_OUT">Output Report ID value</param>
        public void SendData(Int32 ReportID_OUT)
        {
            // send 8 bytes of data to USB HID device by Report ID 
            // in Endpoint 1 from the 0 offset
            try
            {
                var ReportID = ReportID_OUT;

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);

                    USBwriteBuffer[0] = Convert.ToByte(ReportID_OUT);
                    //ec = writer.Write(USBwriteBuffer, 2000, out CountOfSentBytes); //this function worked ok
                    ec = writer.Write(USBwriteBuffer, 0, 8, 2000, out CountOfSentBytes); //byte[] buffer, int offset, int count, int timeout, out int transferLength

                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "SendData function error: " + "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
            }

        }

        /// <summary>
        /// Function to send CountOfBytes data bytes to USB HID device by Report ID in Endpoint 1 from the 0 offset
        /// </summary>
        /// <param name="ReportID_OUT">Output Report ID value</param>
        /// <param name="CountOfBytes">Count of transmitting bytes</param>
        public void SendData(Int32 ReportID_OUT, int CountOfBytes)
        {
            // send CountOfBytes bytes of data to USB HID device by Report ID 
            // in Endpoint 1 from the 0 offset
            try
            {
                var ReportID = ReportID_OUT;

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);

                    USBwriteBuffer[0] = Convert.ToByte(ReportID_OUT);
                    //ec = writer.Write(USBwriteBuffer, 2000, out bytesWritten); this function worked ok
                    ec = writer.Write(USBwriteBuffer, 0, CountOfBytes, 1000, out CountOfSentBytes); //byte[] buffer, int offset, int count, int timeout, out int transferLength

                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "SendData function error: " + "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
            }
        }

        /// <summary>
        /// Function to send "CountOfBytes" data bytes from the "BufferOffset" offset of transmitting buffer value to USB HID device by Report ID in Endpoint 1 from the 0 offset
        /// </summary>
        /// <param name="ReportID_OUT">Output Report ID value</param>
        /// <param name="CountOfBytes">Count of transmitting bytes</param>
        /// <param name="BufferOffset">Start transmitting buffer index</param>
        public void SendData(Int32 ReportID_OUT, int CountOfBytes, int BufferOffset)
        {
            // send CountOfBytes bytes of data to USB HID device by Report ID 
            // in Endpoint 1 from the BufferOffset offset
            try
            {
                var ReportID = ReportID_OUT;

                if (MyUsbDevice != null)
                {
                    IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // This is a "whole" USB device. Before it can be used, 
                        // the desired configuration and interface must be selected.

                        // Select config #1
                        wholeUsbDevice.SetConfiguration(1);

                        // Claim interface #0.
                        wholeUsbDevice.ClaimInterface(0);
                    }

                    // open write endpoint 1.
                    UsbEndpointWriter writer = MyUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01, LibUsbDotNet.Main.EndpointType.Interrupt);

                    USBwriteBuffer[0] = Convert.ToByte(ReportID_OUT);
                    //ec = writer.Write(USBwriteBuffer, 2000, out bytesWritten); this function worked ok
                    ec = writer.Write(USBwriteBuffer, BufferOffset, CountOfBytes, 2000, out CountOfSentBytes); //byte[] buffer, int offset, int count, int timeout, out int transferLength

                    if (ec != ErrorCode.None) throw new Exception(UsbDevice.LastErrorString);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "SendData function error: " + "Error: " + (ec != ErrorCode.None ? ec + ":" : String.Empty) + ex.Message;
            }
        }
        #endregion

        /// <summary>
        /// Function to check the presence of the device on the USB bus
        /// </summary>
        /// <param name="USB_VID"> Device Vendor ID</param>
        /// <param name="USB_PID"> Device Product ID</param>
        public void DetectDeviceOnBus (Int32 USB_VID, Int32 USB_PID)
        {
            UsbDevice usbDevice = null;
            UsbDeviceFinder usbDeviceFinder = new UsbDeviceFinder(USB_VID, USB_PID);
            usbDevice = UsbDevice.OpenUsbDevice(usbDeviceFinder);
            if (usbDevice != null)
            {
                DeviceOnBusDetected = true;
            }
            else
            {
                DeviceOnBusDetected = false;
            }
            UsbDevice.Exit();
        }

    }
}
