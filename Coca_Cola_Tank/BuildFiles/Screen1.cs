//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	using Neo.ApplicationFramework.Common.MultiLanguage;
	
	
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
	public partial class Screen1 : Neo.ApplicationFramework.Controls.Screen.ScreenWindow
	{
		
		public Screen1()
		{
			this.DataContext = Globals.Instance;
			this.InitializeComponent();
			this.ApplyLanguageInternal();
			this.m_MultiPicture.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.m_MultiPicture_Action_MouseDown);
			this.m_MultiPicture1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.m_MultiPicture1_Action_MouseDown);
			this.m_MultiPicture2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.m_MultiPicture2_Action_MouseDown);
			this.m_MultiPicture2.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.m_MultiPicture2_Action_MouseUp);
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text10
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text10);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text9
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text9);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ColorElementAdapter Group
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ColorElementAdapter>(this.m_Group);
			}
		}
		
		public Neo.ApplicationFramework.Controls.Script.TrendAdapter TrendViewer
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TrendAdapter>(this.m_TrendViewer);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ColorElementAdapter Rectangle
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ColorElementAdapter>(this.m_Rectangle);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter AnalogNumeric1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter>(this.m_AnalogNumeric1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter AnalogNumeric2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter>(this.m_AnalogNumeric2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter AnalogNumeric3
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter>(this.m_AnalogNumeric3);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter AnalogNumeric4
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericAdapter>(this.m_AnalogNumeric4);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ElementAdapter MultiPicture
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ElementAdapter>(this.m_MultiPicture);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.MeterAdapter Slider
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.MeterAdapter>(this.m_Slider);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.MeterAdapter Slider1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.MeterAdapter>(this.m_Slider1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.MeterAdapter Slider2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.MeterAdapter>(this.m_Slider2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.LineAdapter Line
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineAdapter>(this.m_Line);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.LineAdapter Line1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineAdapter>(this.m_Line1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.LineAdapter Line2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineAdapter>(this.m_Line2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text3
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text3);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text4
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text4);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text5
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text5);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text6
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text6);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text7
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text7);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text8
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text8);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ColorElementAdapter Rectangle1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ColorElementAdapter>(this.m_Rectangle1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.MeterAdapter LinearMeter
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.MeterAdapter>(this.m_LinearMeter);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ElementAdapter MultiPicture1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ElementAdapter>(this.m_MultiPicture1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ElementAdapter MultiPicture2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ElementAdapter>(this.m_MultiPicture2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text11
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text11);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ColorElementAdapter Group1
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ColorElementAdapter>(this.m_Group1);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.ColorElementAdapter Rectangle2
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ColorElementAdapter>(this.m_Rectangle2);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text12
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text12);
			}
		}
		
		protected Neo.ApplicationFramework.Controls.Script.TextElementAdapter Text13
		{
			get
			{
				return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextElementAdapter>(this.m_Text13);
			}
		}
		
		protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData()
		{
			System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
			instanceList.Add(this.CreateInstanceData_Default());
			Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
			aliasInstances.Instances = instanceList.ToArray();
			return aliasInstances;
		}
		
		private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default()
		{
			Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
			aliasinstancecf1.Name = "Default";
			aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
			return aliasinstancecf1;
		}
		
		protected override void BindAliases()
		{
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Screen1));
			this.m_Text.Text = resources.GetText("Screen1.Text.Text", "100");
			this.m_Text1.Text = resources.GetText("Screen1.Text1.Text", "Td");
			this.m_Text2.Text = resources.GetText("Screen1.Text2.Text", "Ti");
			this.m_Text3.Text = resources.GetText("Screen1.Text3.Text", "PV");
			this.m_Text4.Text = resources.GetText("Screen1.Text4.Text", "50");
			this.m_Text5.Text = resources.GetText("Screen1.Text5.Text", "0");
			this.m_Text6.Text = resources.GetText("Screen1.Text6.Text", "Kc");
			this.m_Text7.Text = resources.GetText("Screen1.Text7.Text", "OUT");
			this.m_Text8.Text = resources.GetText("Screen1.Text8.Text", "SP");
			this.m_Text9.Text = resources.GetText("Screen1.Text9.Text", "Auto");
			this.m_Text10.Text = resources.GetText("Screen1.Text10.Text", "Sim");
			this.m_Text11.Text = resources.GetText("Screen1.Text11.Text", "Rst");
			this.m_Text12.Text = resources.GetText("Screen1.Text12.Text", "Simulering Tank");
			this.m_Text13.Text = resources.GetText("Screen1.Text13.Text", "PID regulator");
			this.m_TrendViewer.Curves[0].DisplayName = resources.GetText("Screen1.TrendViewer.Curves[0].DisplayName", "Curve1");
			this.m_TrendViewer.Curves[1].DisplayName = resources.GetText("Screen1.TrendViewer.Curves[1].DisplayName", "Curve2");
			this.m_TrendViewer.Curves[2].DisplayName = resources.GetText("Screen1.TrendViewer.Curves[2].DisplayName", "Curve3");
			this.ApplyResourcesOnWindow();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
		
		private void m_MultiPicture_Action_MouseDown(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture", "MouseDown", "Toggle Tag", "Tags.HMI_PID_Auto", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.HMI_PID_Auto.ToggleTag();
		}
		
		private void m_MultiPicture1_Action_MouseDown(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture1", "MouseDown", "Toggle Tag", "Tags.HMI_Start_Stopp", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.HMI_Start_Stopp.ToggleTag();
		}
		
		private void m_MultiPicture2_Action_MouseDown(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture2", "MouseDown", "Set Tag", "Tags.HMI_Tank_Reset", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.HMI_Tank_Reset.SetTag();
		}
		
		private void m_MultiPicture2_Action_MouseUp(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture2", "MouseUp", "Reset Tag", "Tags.HMI_Tank_Reset", "");
			Neo.ApplicationFramework.Generated.Globals.Tags.HMI_Tank_Reset.ResetTag();
		}
	}
}
