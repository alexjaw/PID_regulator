using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.Service;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Tools.ToolManager;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Attributes;
using System.Threading;
using System.Linq;

[assembly: AssemblyVersion("2.15.5751.0")]
[assembly: NeoDesignerVersion("2.15.5751.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));
        private static string[] m_Arguments;

        static Globals()
        {
            TypeDescriptor.AddProvider(new WPFToCFTypeDescriptionProvider(typeof(object)), typeof(object));
        }

        public Globals()
        {
            m_ProjectSettings.MainScreenTitle = "TestOPC";
            m_ProjectSettings.Topmost = false;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.MainScreenSize = new Size(800,600);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
                                       
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("ae8f7367-8918-4d37-bae5-cecd7efe11a8");
        }
        
        
        private static void SetWorkingFolder()
        {
            //Neo is dependent on the workingfolder being the folder where the application resides.
            Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }
                
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter Screen1
                    {
                        get
                        {
                            return GetObject<Screen1>().Adapter;
                        }
                    }           
                    public static SntpClientRootComponent SntpClientRootComponent
                    {
                        get
                        {
                            return GetObject<SntpClientRootComponent>();
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GetObject<Security>();
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GetObject<ProjectConfiguration>();
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GetObject<Tags>();
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GetObject<MultipleLanguages>();
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GetObject<LicenseRootComponent>();
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GetObject<Expressions>();
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GetObject<AlarmServer>();
                        }
                    }   
        [STAThread]
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            SetWorkingFolder();
            
			if (!CheckIfApplicationCanRun())
				return;

            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimeStamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = false;   

            Instance = new Globals();

            try
            {
                m_Arguments = args;
                
                m_ToolManager.OnToolAdded += OnToolAdded;
                m_ToolManager.LoadTools();
                SetRenderingMode();

                INativeAPI nativeAPI = Globals.GetService<IPlatformFactoryService>().Create<INativeAPI>();
                int mutexHandle = CreateMutex(nativeAPI);

                bool mutexAquired = 
                    mutexHandle != 0 &&
                    (Marshal.GetLastWin32Error() != (int)CREATEMUTEX.ERROR_ALREADY_EXISTS) && 
                    (Marshal.GetLastWin32Error() != (int)CREATEMUTEX.ERROR_ACCESS_DENIED)
                ;

                if (mutexAquired)
                {
                    ((Globals)Instance).SetBeShellMenuPassword();
                    ((Globals)Instance).SetScreenOrientation();
                    ((Globals)Instance).SetSerialPortMode();
                    ((Globals)Instance).SetKeyBeep();
                    ((Globals)Instance).ConfigureFtpServer();
                    ((Globals)Instance).StartVncServerCe();

                    nativeAPI.CeSetThreadQuantum(new IntPtr(65), 25);
                    InterpreterArguments(args);
                    ExecutablePath = typeof(Globals).Module.FullyQualifiedName;
                    RegisterDrivers();
                    
                    NeoApplication.Initialize();

                    m_ToolManager.Start();

                    Instanciate(new string[] {"Security","Tags","MultipleLanguages","AlarmServer","Database","Expressions","LicenseRootComponent","ProjectConfiguration","SntpClientRootComponent","ProjectImages"});
                    PreloadScreens = new string[] {}.Select(item => Type.GetType(string.Concat(StringConstants.NeoApplicationFrameworkGenerated, ".", item, ",", Assembly.GetExecutingAssembly().FullName), true)).ToArray();


                    InitAndRun();
                    NeoApplication.SetMainScreen(Screen1.AdaptedObject);
                    NeoApplication.Run(Screen1.AdaptedObject.GetType());                      
                    CloseRunningOnScreenKeyboard();
                    CloseRunningVncserverCe();                  
                }
            }
            catch(ControledRequestForShutdownException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                GenerateCrashReport(ex);
                ManageUnhandledException(ex, true);
                m_ShowUnhandledException = false;

                throw; //Preserves stacktrace and triggers Dr Watson to create dump file.
            }
            finally
            {
                try
                {
                    m_ToolManager.StopStoppable();
                    Stop();
                }
                catch (Exception e)
                {
                    m_Log.Info("Unable to successfully stop.", e);
                }
            }
        }

        private static void OnToolAdded(object sender, EventArgs e)
        {
            if (sender is ICommandLineService)
            {
                ServiceContainerCF.GetService<ICommandLineService>().Arguments = m_Arguments;
            }
        }

    }
}