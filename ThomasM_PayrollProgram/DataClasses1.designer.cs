﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThomasM_PayrollProgram
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeDatabase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ThomasM_PayrollProgram.Properties.Settings.Default.EmployeeDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Type;
		
		private string _SocialSecurityNumber;
		
		private string _NetPay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnSocialSecurityNumberChanging(string value);
    partial void OnSocialSecurityNumberChanged();
    partial void OnNetPayChanging(string value);
    partial void OnNetPayChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(19) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SocialSecurityNumber", DbType="VarChar(12)")]
		public string SocialSecurityNumber
		{
			get
			{
				return this._SocialSecurityNumber;
			}
			set
			{
				if ((this._SocialSecurityNumber != value))
				{
					this.OnSocialSecurityNumberChanging(value);
					this.SendPropertyChanging();
					this._SocialSecurityNumber = value;
					this.SendPropertyChanged("SocialSecurityNumber");
					this.OnSocialSecurityNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NetPay", DbType="VarChar(10)")]
		public string NetPay
		{
			get
			{
				return this._NetPay;
			}
			set
			{
				if ((this._NetPay != value))
				{
					this.OnNetPayChanging(value);
					this.SendPropertyChanging();
					this._NetPay = value;
					this.SendPropertyChanged("NetPay");
					this.OnNetPayChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591