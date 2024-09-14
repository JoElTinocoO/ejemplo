﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ramlethal_Service_1._2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ramlethal_Service")]
	public partial class DatosUsuarioSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertReportes(Reportes instance);
    partial void UpdateReportes(Reportes instance);
    partial void DeleteReportes(Reportes instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void InsertTickets(Tickets instance);
    partial void UpdateTickets(Tickets instance);
    partial void DeleteTickets(Tickets instance);
    #endregion
		
		public DatosUsuarioSQLDataContext() : 
				base(global::Ramlethal_Service_1._2.Properties.Settings.Default.Ramlethal_ServiceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosUsuarioSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosUsuarioSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosUsuarioSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosUsuarioSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Reportes> Reportes
		{
			get
			{
				return this.GetTable<Reportes>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<Tickets> Tickets
		{
			get
			{
				return this.GetTable<Tickets>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reportes")]
	public partial class Reportes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReporteID;
		
		private int _UsuarioID;
		
		private System.DateTime _FechaReporte;
		
		private string _Descripcion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReporteIDChanging(int value);
    partial void OnReporteIDChanged();
    partial void OnUsuarioIDChanging(int value);
    partial void OnUsuarioIDChanged();
    partial void OnFechaReporteChanging(System.DateTime value);
    partial void OnFechaReporteChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
		
		public Reportes()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReporteID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ReporteID
		{
			get
			{
				return this._ReporteID;
			}
			set
			{
				if ((this._ReporteID != value))
				{
					this.OnReporteIDChanging(value);
					this.SendPropertyChanging();
					this._ReporteID = value;
					this.SendPropertyChanged("ReporteID");
					this.OnReporteIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this.OnUsuarioIDChanging(value);
					this.SendPropertyChanging();
					this._UsuarioID = value;
					this.SendPropertyChanged("UsuarioID");
					this.OnUsuarioIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaReporte", DbType="DateTime NOT NULL")]
		public System.DateTime FechaReporte
		{
			get
			{
				return this._FechaReporte;
			}
			set
			{
				if ((this._FechaReporte != value))
				{
					this.OnFechaReporteChanging(value);
					this.SendPropertyChanging();
					this._FechaReporte = value;
					this.SendPropertyChanged("FechaReporte");
					this.OnFechaReporteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UsuarioID;
		
		private string _Nombre;
		
		private string _Correo;
		
		private string _Contraseña;
		
		private bool _Administrador;
		
		private string _CodigoAdmin;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsuarioIDChanging(int value);
    partial void OnUsuarioIDChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void OnAdministradorChanging(bool value);
    partial void OnAdministradorChanged();
    partial void OnCodigoAdminChanging(string value);
    partial void OnCodigoAdminChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this.OnUsuarioIDChanging(value);
					this.SendPropertyChanging();
					this._UsuarioID = value;
					this.SendPropertyChanged("UsuarioID");
					this.OnUsuarioIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Administrador", DbType="Bit NOT NULL")]
		public bool Administrador
		{
			get
			{
				return this._Administrador;
			}
			set
			{
				if ((this._Administrador != value))
				{
					this.OnAdministradorChanging(value);
					this.SendPropertyChanging();
					this._Administrador = value;
					this.SendPropertyChanged("Administrador");
					this.OnAdministradorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoAdmin", DbType="NVarChar(50)")]
		public string CodigoAdmin
		{
			get
			{
				return this._CodigoAdmin;
			}
			set
			{
				if ((this._CodigoAdmin != value))
				{
					this.OnCodigoAdminChanging(value);
					this.SendPropertyChanging();
					this._CodigoAdmin = value;
					this.SendPropertyChanged("CodigoAdmin");
					this.OnCodigoAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tickets")]
	public partial class Tickets : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_ticket;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private string _Problematitulo;
		
		private string _descrpcion_problema;
		
		private string _status_ticket;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ticketChanging(int value);
    partial void OnId_ticketChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    partial void OnProblematituloChanging(string value);
    partial void OnProblematituloChanged();
    partial void Ondescrpcion_problemaChanging(string value);
    partial void Ondescrpcion_problemaChanged();
    partial void Onstatus_ticketChanging(string value);
    partial void Onstatus_ticketChanged();
    #endregion
		
		public Tickets()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_ticket", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_ticket
		{
			get
			{
				return this._Id_ticket;
			}
			set
			{
				if ((this._Id_ticket != value))
				{
					this.OnId_ticketChanging(value);
					this.SendPropertyChanging();
					this._Id_ticket = value;
					this.SendPropertyChanged("Id_ticket");
					this.OnId_ticketChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Problematitulo", DbType="VarChar(30)")]
		public string Problematitulo
		{
			get
			{
				return this._Problematitulo;
			}
			set
			{
				if ((this._Problematitulo != value))
				{
					this.OnProblematituloChanging(value);
					this.SendPropertyChanging();
					this._Problematitulo = value;
					this.SendPropertyChanged("Problematitulo");
					this.OnProblematituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descrpcion_problema", DbType="VarChar(200)")]
		public string descrpcion_problema
		{
			get
			{
				return this._descrpcion_problema;
			}
			set
			{
				if ((this._descrpcion_problema != value))
				{
					this.Ondescrpcion_problemaChanging(value);
					this.SendPropertyChanging();
					this._descrpcion_problema = value;
					this.SendPropertyChanged("descrpcion_problema");
					this.Ondescrpcion_problemaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status_ticket", DbType="VarChar(15)")]
		public string status_ticket
		{
			get
			{
				return this._status_ticket;
			}
			set
			{
				if ((this._status_ticket != value))
				{
					this.Onstatus_ticketChanging(value);
					this.SendPropertyChanging();
					this._status_ticket = value;
					this.SendPropertyChanged("status_ticket");
					this.Onstatus_ticketChanged();
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
