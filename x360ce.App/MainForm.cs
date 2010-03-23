﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using x360ce.App.XnaInput;
using System.Text.RegularExpressions;
using Microsoft.DirectX.DirectInput;
using System.Collections.Specialized;
using System.Security.Principal;
using System.Security.AccessControl;

namespace x360ce.App
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		private ButtonValues lastButtonsPressed = ButtonValues.None;


		string cIniFile = "x360ce.ini";
		string cIniFileNew = "x360ce.ini";
		string cIniTmpFile = "x360ce.tmp";
		string cXinput0File = "xinput9_1_0.dll";
		string cXinput1File = "xinput1_1.dll";
		string cXinput2File = "xinput1_2.dll";
		string cXinput3File = "xinput1_3.dll";

		public int oldIndex;

		public int controllerIndex
		{
			get
			{
				int newIndex = 0;
				if (MainTabControl.SelectedTab == Pad1TabPage) newIndex = 0;
				if (MainTabControl.SelectedTab == Pad2TabPage) newIndex = 1;
				if (MainTabControl.SelectedTab == Pad3TabPage) newIndex = 2;
				if (MainTabControl.SelectedTab == Pad4TabPage) newIndex = 3;
				return newIndex;
			}
		}

		Controller CurrentController { get { return XInput.Controllers[controllerIndex]; } }
		GamePad CurrentPad { get { return CurrentController.State.Gamepad; } }
		Controls.PadControl CurrentPadControl { get { return ControlPads[controllerIndex]; } }
		TabPage CurrentPadTabControl { get { return ControlPages[controllerIndex]; } }

		public Controls.AboutControl ControlAbout;
		public Controls.PadControl[] ControlPads;
		public TabPage[] ControlPages;

		private void MainForm_Load(object sender, EventArgs e)
		{
			Win32.WinAPI.EnableShieldIcon(ElevatedActionButton);

			StatusSaveLabel.Visible = false;
			StatusEventsLabel.Visible = false;
			// If it is old ini file.
			if (System.IO.File.Exists("xbox360cemu.ini")
				&& !System.IO.File.Exists(cIniFile))
			{
				// Use old file.
				cIniFile = "xbox360cemu.ini";
				cIniTmpFile = "xbox360cemu.tmp";
			}
			// Init presets. Execute only after name of cIniFile is set.
			InitPresets();
			// Load about control.
			ControlAbout = new Controls.AboutControl();
			ControlAbout.Dock = DockStyle.Fill;
			AboutTabPage.Controls.Add(ControlAbout);
			// Load Tab pages.
			ControlPages = new TabPage[4];
			ControlPages[0] = Pad1TabPage;
			ControlPages[1] = Pad2TabPage;
			ControlPages[2] = Pad3TabPage;
			ControlPages[3] = Pad4TabPage;
			BuletImageList.Images.Add("bullet_square_glass_blue.png", new Bitmap(Helper.GetResource("Images.bullet_square_glass_blue.png")));
			BuletImageList.Images.Add("bullet_square_glass_green.png", new Bitmap(Helper.GetResource("Images.bullet_square_glass_green.png")));
			BuletImageList.Images.Add("bullet_square_glass_grey.png", new Bitmap(Helper.GetResource("Images.bullet_square_glass_grey.png")));
			BuletImageList.Images.Add("bullet_square_glass_red.png", new Bitmap(Helper.GetResource("Images.bullet_square_glass_red.png")));
			BuletImageList.Images.Add("bullet_square_glass_yellow.png", new Bitmap(Helper.GetResource("Images.bullet_square_glass_yellow.png")));
			foreach (var item in ControlPages) item.ImageKey = "bullet_square_glass_grey.png";
			// Load PAD controls.
			ControlPads = new Controls.PadControl[4];
			for (int i = 0; i < ControlPads.Length; i++)
			{
				ControlPads[i] = new Controls.PadControl(i);
				ControlPads[i].Name = string.Format("ControlPad{0}", i + 1);
				ControlPads[i].Dock = DockStyle.Fill;
				ControlPages[i].Controls.Add(ControlPads[i]);
				ControlPads[i].InitPadControl();
			}
			// Check if ini and dll is on disk.
			CheckFiles(true);
			// Can't run witout ini.
			if (!File.Exists(cIniFile))
			{
				MessageBox.Show(
					string.Format("Configuration file '{0}' is required for application to run!", cIniFile),
					"Error", MessageBoxButtons.OK);
				this.Close();
				return;
			}
			// If temp file exist then.
			FileInfo iniTmp = new FileInfo(cIniTmpFile);
			if (iniTmp.Exists)
			{
				// It means that application crashed. Restore ini from temp.
				iniTmp.CopyTo(cIniFile, true);
			}
			else
			{
				// Create temp file to store original settings.
				File.Copy(cIniFile, cIniTmpFile, true);
			}
			ReloadXinputSettings();
			Version v = new Version(Application.ProductVersion);
			this.Text = string.Format(this.Text, Application.ProductVersion);
			switch (v.Build)
			{
				case 0: this.Text += " Alpha"; break;
				case 1: this.Text += " Beta 1"; break;
				case 2: this.Text += " Beta 2"; break;
				case 3: this.Text += " Beta 3"; break;
				case 4: this.Text += " RC"; break;
			}
			//InitDirectInputTab();
			// Timer will execute ReloadXInputLibrary();
			//XInput.ReLoadLibrary(cXinput3File);
			//XInput.ReLoadLibrary(cXinput3File);
			// start capture events.
			if (Win32.WinAPI.IsElevated && Win32.WinAPI.IsInAdministratorRole) this.Text += " (Administrator)";


			timer.Start();
			//ReloadXInputLibrary();
		}

		public void CopyElevated(string source, string dest)
		{
			if (!Win32.WinAPI.IsVista)
			{
				System.IO.File.Copy(source, dest);
				return;
			}
			var di = new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(dest));
			var security = di.GetAccessControl();
			var fi = new FileInfo(dest);
			var fileSecurity = fi.GetAccessControl();
			// Allow Users to Write.
			//SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
			//fileSecurity.AddAccessRule(new FileSystemAccessRule(sid, FileSystemRights.Write, AccessControlType.Allow));
			//fi.SetAccessControl(fileSecurity);
			var rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
			string message = string.Empty;
			foreach (var myacc in rules)
			{
				var acc = (FileSystemAccessRule)myacc;
				message += string.Format("IdentityReference: {0}\r\n", acc.IdentityReference.Value);
				message += string.Format("Access Control Type: {0}\r\n", acc.AccessControlType.ToString());
				message += string.Format("\t{0}\r\n", acc.FileSystemRights.ToString());
				//if ((acc.FileSystemRights & FileSystemRights.FullControl) == FileSystemRights.FullControl)
				//{
				//    Console.Write("FullControl");
				//}
				//if ((acc.FileSystemRights & FileSystemRights.ReadData) == FileSystemRights.ReadData)
				//{
				//    Console.Write("ReadData");
				//}
				//if ((acc.FileSystemRights & FileSystemRights.WriteData) == FileSystemRights.WriteData)
				//{
				//    Console.Write("WriteData");
				//}
				//if ((acc.FileSystemRights & FileSystemRights.ListDirectory) == FileSystemRights.ListDirectory)
				//{
				//    Console.Write("ListDirectory");
				//}
				//if ((acc.FileSystemRights & FileSystemRights.ExecuteFile) == FileSystemRights.ExecuteFile)
				//{
				//    Console.Write("ExecuteFile");
				//}
			}
			MessageBox.Show(message);
			//WindowsIdentity self = System.Security.Principal.WindowsIdentity.GetCurrent();

			//			 FileSystemAccessRule rule = new FileSystemAccessRule(
			//    self.Name, 
			//    FileSystemRights.FullControl,
			//    AccessControlType.Allow);



		}


		void InitPresets()
		{
			PresetComboBox.Items.Clear();
			var prefix = System.IO.Path.GetFileNameWithoutExtension(cIniFileNew);
			var ext = System.IO.Path.GetExtension(cIniFileNew);
			string name;
			// Presets: Embedded.
			var embeddedPresets = new List<string>();
			var assembly = Assembly.GetExecutingAssembly();
			string[] files = assembly.GetManifestResourceNames();
			var pattern = string.Format("Presets\\.{0}\\.(?<name>.*?){1}", prefix, ext);
			Regex rx = new Regex(pattern);
			for (int i = 0; i < files.Length; i++)
			{
				if (rx.IsMatch(files[i]))
				{
					name = rx.Match(files[i]).Groups["name"].Value.Replace("_", " ");
					embeddedPresets.Add(name);
				}
			}
			// Presets: Custom.
			var dir = new System.IO.DirectoryInfo(".");
			FileInfo[] fis = dir.GetFiles(string.Format("{0}.*{1}", prefix, ext));
			List<string> customPresets = new List<string>();
			for (int i = 0; i < fis.Length; i++)
			{
				name = fis[i].Name.Substring(prefix.Length + 1);
				name = name.Substring(0, name.Length - ext.Length);
				name = name.Replace("_", " ");
				if (!embeddedPresets.Contains(name)) customPresets.Add(name);
			}
			PresetComboBox.Items.Add("Presets:");
			string[] cNames = customPresets.ToArray();
			string[] eNames = embeddedPresets.ToArray();
			Array.Sort(cNames);
			Array.Sort(eNames);
			foreach (var item in cNames) PresetComboBox.Items.Add(item);
			if (cNames.Length > 0) PresetComboBox.Items.Add("Embeded:");
			foreach (var item in eNames) PresetComboBox.Items.Add(item);
			PresetComboBox.SelectedIndex = 0;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			for (int i = 0; i < ControlPads.Length; i++)
			{
				// Stop recording on all panels.
				if (e.KeyCode == Keys.Escape && ControlPads[i].Recording)
				{
					ControlPads[i].RecordingStop(null);
					e.Handled = true;
					e.SuppressKeyPress = true;
				}
			}
			toolStripStatusLabel1.Text = "";
		}

		private void CleanStatusTimer_Tick(object sender, EventArgs e)
		{
			//toolStripStatusLabel1.Text = "";
			//CleanStatusTimer.Stop();
		}

		private void LoadPresetButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(PresetComboBox.Text)) return;
			string name = PresetComboBox.Text.Replace(" ", "_");
			LoadPreset(name);
		}

		void LoadPreset(string name)
		{
			// exit if "Presets:" or "Embedded:".
			if (name.Contains(":")) return;
			string prefix = System.IO.Path.GetFileNameWithoutExtension(cIniFile);
			string ext = System.IO.Path.GetExtension(cIniFile);
			string resourceName = string.Format("{0}.{1}{2}", prefix, name, ext);
			var resource = Helper.GetResource("Presets." + resourceName);
			// If internal preset was found.
			if (resource != null)
			{
				// Export file.
				var sr = new StreamReader(resource);
				System.IO.File.WriteAllText(resourceName, sr.ReadToEnd());
			}
			// preset will be stored in inside [PAD0] section;
			SuspendEvents();
			ReadSettings(resourceName, 0);
			ResumeEvents();
			SaveSettings();
			NotifySettingsChange();
			//CleanStatusTimer.Start();
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			ReloadXinputSettings();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer.Stop();
			FileInfo tmp = new FileInfo(cIniTmpFile);
			if (tmp.Exists)
			{
				// Rename temp to ini.
				tmp.CopyTo(cIniFile, true);
				// delete temp.
				tmp.Delete();
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			// Owerwrite temp file.
			FileInfo ini = new FileInfo(cIniFile);
			ini.CopyTo(cIniTmpFile, true);
			toolStripStatusLabel1.Text = "Settings saved";
		}

		//void SaveReloadSetting(Control control)
		//{
		//    SaveSettings(control);
		//    DiDevices = null;
		//    ReloadXInputLibrary();
		//    CleanStatusTimer.Start();
		//}

		//private void SettingsCheckBox_CheckedChanged(object sender, EventArgs e)
		//{
		//    SaveReloadSetting((Control)sender);
		//}

		//private void SettingsTextBox_TextChanged(object sender, EventArgs e)
		//{
		//    var control = (TextBox)sender;
		//    Regex idRx = new Regex("^0x[0-9abcdefABCDEF]{4,4}$");
		//    if (control == FakePidTextBox
		//        || control == FakeVidTextBox
		//        )
		//    {
		//        if (idRx.IsMatch(control.Text)) SaveReloadSetting((Control)control);
		//    }
		//}

		//private void GamePadTypeComboBox_TextChanged(object sender, EventArgs e)
		//{
		//    SaveReloadSetting((Control)sender);
		//}

		//private void DiDevicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
		//{
		//    CurrentDiDevice.Dispose();
		//    CurrentDiDevice = null;
		//    ShowDeviceInfo();
		//    ResetDiMenuStrip();

		//}

		#region Timer


		List<DeviceInstance> _DiInstances = new List<DeviceInstance>();
		/// <summary>
		/// Access this only insite Timer_Click!
		/// </summary>
		List<DeviceInstance> GetCurrentInstances(ref bool instancesChanged)
		{
			//Populate All devices
			var list = new List<DeviceInstance>();
			foreach (DeviceInstance di in Manager.Devices)
			{
				// Skip if device is not what we are looking for. 
				if (di.DeviceType != DeviceType.Driving
					&& di.DeviceType != DeviceType.Flight
					&& di.DeviceType != DeviceType.Gamepad
					&& di.DeviceType != DeviceType.Joystick) continue;
				list.Add(di);
			}
			instancesChanged = false;
			if (_DiInstances.Count != list.Count)
			{
				instancesChanged = true;
			}
			else
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (!_DiInstances[i].InstanceGuid.Equals(list[i].InstanceGuid))
					{
						instancesChanged = true;
					}
				}
			}
			_DiInstances = list;
			return _DiInstances;
		}

		Device _CurrentDiDevice;
		/// <summary>
		/// Access this only insite Timer_Click!
		/// </summary>
		Device GetCurrentDiDevice(List<DeviceInstance> instances)
		{
			// Assign instance guid (empty guid is instance is unavailable)
			Guid ig = controllerIndex < instances.Count
				? instances[controllerIndex].InstanceGuid
				: Guid.Empty;
			// Current is not empty and instance is different or empty then...
			if (_CurrentDiDevice != null &&
				(!_CurrentDiDevice.DeviceInformation.InstanceGuid.Equals(ig) || Guid.Empty.Equals(ig)))
			{
				// Dispose current device.
				_CurrentDiDevice.Unacquire();
				_CurrentDiDevice.Dispose();
				_CurrentDiDevice = null;
			}
			// If current device is empty and instance guid sugested then...
			if (_CurrentDiDevice == null && !ig.Equals(Guid.Empty))
			{
				_CurrentDiDevice = new Device(ig);
				_CurrentDiDevice.SetCooperativeLevel(this, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
				_CurrentDiDevice.Acquire();
			}
			//if (!attached) return null;
			return _CurrentDiDevice;
		}

		/// <summary>
		/// Delay settings trough timer so interface will be more responsive on TrackBars.
		/// Or fast changes. Library will be reloaded as soon as user calms down (no setting changes in 500ms).
		/// </summary>
		public void NotifySettingsChange()
		{
			SettingsTimer.Stop();
			SettingsTimer.Start();
		}

		private void SettingsTimer_Tick(object sender, EventArgs e)
		{
			settingsChanged = true;
			SettingsTimer.Stop();
		}

		bool settingsChanged = false;

		int reloads = 0;
		int tcount = 0;
		private void timer_Tick(object sender, EventArgs e)
		{
			bool instancesChanged = false;
			var instances = new List<DeviceInstance>();
			try
			{
				instances = GetCurrentInstances(ref instancesChanged);
			}
			catch (Exception)
			{
				System.Threading.Thread.Sleep(100);
				return;
			}
			var device = GetCurrentDiDevice(instances);
			tcount++;
			if (instancesChanged || settingsChanged)
			{
				settingsChanged = false;
				XInput.ReLoadLibrary(cXinput3File);
				reloads++;
				return;
			}
			// Check all pads.
			//toolStripStatusLabel1.Text = "";
			for (int i = 0; i < 4; i++)
			{
				XInput.Controllers[i].PollState();
				var on = XInput.Controllers[i].IsConnected;
				string image = on ? "green" : "grey";
				// If DirectInput device exist but controller doesn't work then error.
				if (i < instances.Count) if (!on) image = "red";
				string bullet = string.Format("bullet_square_glass_{0}.png", image);
				if (ControlPages[i].ImageKey != bullet) ControlPages[i].ImageKey = bullet;
			}
			try
			{
				CurrentPadControl.UpdateFrom(CurrentController, device);
			}
			catch (Exception) { }
			//toolStripStatusLabel1.Text = string.Format("Reloads: {0}; Count: {1}", reloads, tcount);
		}

		#endregion

		private void ElevateThisAppButton_Click(object sender, EventArgs e)
		{
			timer.Stop();
			Win32.WinAPI.RunElevated();
		}

		bool HelpInit = false;

		private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (MainTabControl.SelectedTab == HelpTabPage && !HelpInit)
			{
				// Move this here so interface will load one second faster.
				HelpInit = true;
				var stream = Helper.GetResource("Documents.Help.htm");
				var sr = new StreamReader(stream);
				NameValueCollection list = new NameValueCollection();
				list.Add("font-name-default", "'Microsoft Sans Serif'");
				list.Add("font-size-default", "16");
				HelpRichTextBox.Rtf = Html2Rtf.Converter.Html2Rtf(sr.ReadToEnd(), list);
				HelpRichTextBox.SelectAll();
				HelpRichTextBox.SelectionIndent = 8;
				HelpRichTextBox.SelectionRightIndent = 8;
				HelpRichTextBox.DeselectAll();
			}
		}
	

	
		

	}
}
