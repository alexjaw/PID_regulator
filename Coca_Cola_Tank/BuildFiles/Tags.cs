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
	
	
	public partial class Tags : Neo.ApplicationFramework.Tools.OpcClient.GlobalController
	{
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_HMI_Start_Stopp;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Tank_niva;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_HMI_Tank_Reset;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Kc;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Ti;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Td;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_HMI_PID_Auto;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Out_tank;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_SP_tank;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_PV_tank;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_HMI_Out;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_PID_out;
		
		private Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem m_Inflöde;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup1;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup2;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup3;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup4;
		
		private Neo.ApplicationFramework.Tools.OpcClient.PollGroup m_PollGroup5;
		
		public Tags()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem HMI_Start_Stopp
		{
			get
			{
				return this.m_HMI_Start_Stopp;
			}
			set
			{
				this.m_HMI_Start_Stopp = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Tank_niva
		{
			get
			{
				return this.m_Tank_niva;
			}
			set
			{
				this.m_Tank_niva = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem HMI_Tank_Reset
		{
			get
			{
				return this.m_HMI_Tank_Reset;
			}
			set
			{
				this.m_HMI_Tank_Reset = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Kc
		{
			get
			{
				return this.m_Kc;
			}
			set
			{
				this.m_Kc = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Ti
		{
			get
			{
				return this.m_Ti;
			}
			set
			{
				this.m_Ti = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Td
		{
			get
			{
				return this.m_Td;
			}
			set
			{
				this.m_Td = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem HMI_PID_Auto
		{
			get
			{
				return this.m_HMI_PID_Auto;
			}
			set
			{
				this.m_HMI_PID_Auto = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Out_tank
		{
			get
			{
				return this.m_Out_tank;
			}
			set
			{
				this.m_Out_tank = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem SP_tank
		{
			get
			{
				return this.m_SP_tank;
			}
			set
			{
				this.m_SP_tank = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem PV_tank
		{
			get
			{
				return this.m_PV_tank;
			}
			set
			{
				this.m_PV_tank = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem HMI_Out
		{
			get
			{
				return this.m_HMI_Out;
			}
			set
			{
				this.m_HMI_Out = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem PID_out
		{
			get
			{
				return this.m_PID_out;
			}
			set
			{
				this.m_PID_out = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem Inflöde
		{
			get
			{
				return this.m_Inflöde;
			}
			set
			{
				this.m_Inflöde = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup1
		{
			get
			{
				return this.m_PollGroup1;
			}
			set
			{
				this.m_PollGroup1 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup2
		{
			get
			{
				return this.m_PollGroup2;
			}
			set
			{
				this.m_PollGroup2 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup3
		{
			get
			{
				return this.m_PollGroup3;
			}
			set
			{
				this.m_PollGroup3 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup4
		{
			get
			{
				return this.m_PollGroup4;
			}
			set
			{
				this.m_PollGroup4 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup5
		{
			get
			{
				return this.m_PollGroup5;
			}
			set
			{
				this.m_PollGroup5 = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
		}
		
		private void InitializeObjectCreations()
		{
			this.HMI_Start_Stopp = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("HMI_Start_Stopp", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), "", ((short)(1)));
			this.Tank_niva = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Tank_niva", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), "", ((short)(1)));
			this.HMI_Tank_Reset = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("HMI_Tank_Reset", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.Kc = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Kc", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.Ti = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Ti", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.Td = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Td", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.HMI_PID_Auto = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("HMI_PID_Auto", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_BIT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.Out_tank = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Out_tank", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.SP_tank = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("SP_tank", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.PV_tank = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("PV_tank", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.HMI_Out = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("HMI_Out", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.PID_out = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("PID_out", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.Inflöde = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("Inflöde", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Neo.ApplicationFramework.Interfaces.AccessRights)((Neo.ApplicationFramework.Interfaces.AccessRights.Read | Neo.ApplicationFramework.Interfaces.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), null, ((short)(1)));
			this.PollGroup1 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup2 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup3 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup4 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup5 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.HMI_Start_Stopp.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem1"}, true));
			this.Tank_niva.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem4"}, true));
			this.HMI_Tank_Reset.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem2"}, true));
			this.Kc.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem5"}, true));
			this.Ti.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem6"}, true));
			this.Td.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem7"}, true));
			this.HMI_PID_Auto.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem10"}, true));
			this.Out_tank.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem3"}, true));
			this.SP_tank.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem8"}, true));
			this.PV_tank.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem9"}, true));
			this.HMI_Out.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem11"}, true));
			this.PID_out.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem12"}, true));
			this.Inflöde.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem13"}, true));
			this.GlobalDataItems.Add(this.HMI_Start_Stopp);
			this.GlobalDataItems.Add(this.Tank_niva);
			this.GlobalDataItems.Add(this.HMI_Tank_Reset);
			this.GlobalDataItems.Add(this.Kc);
			this.GlobalDataItems.Add(this.Ti);
			this.GlobalDataItems.Add(this.Td);
			this.GlobalDataItems.Add(this.HMI_PID_Auto);
			this.GlobalDataItems.Add(this.Out_tank);
			this.GlobalDataItems.Add(this.SP_tank);
			this.GlobalDataItems.Add(this.PV_tank);
			this.GlobalDataItems.Add(this.HMI_Out);
			this.GlobalDataItems.Add(this.PID_out);
			this.GlobalDataItems.Add(this.Inflöde);
			this.PollGroup1.Interval = 500;
			this.PollGroup1.Name = "PollGroup1";
			this.PollGroup2.Interval = 500;
			this.PollGroup2.Name = "PollGroup2";
			this.PollGroup3.Interval = 500;
			this.PollGroup3.Name = "PollGroup3";
			this.PollGroup4.Interval = 500;
			this.PollGroup4.Name = "PollGroup4";
			this.PollGroup5.Interval = 500;
			this.PollGroup5.Name = "PollGroup5";
			this.PollGroups.Add(this.PollGroup1);
			this.PollGroups.Add(this.PollGroup2);
			this.PollGroups.Add(this.PollGroup3);
			this.PollGroups.Add(this.PollGroup4);
			this.PollGroups.Add(this.PollGroup5);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Tags));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
