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

namespace Car_Rental
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Car_Rent_System")]
	public partial class AppDbContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcar(car instance);
    partial void Updatecar(car instance);
    partial void Deletecar(car instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertcarseat(carseat instance);
    partial void Updatecarseat(carseat instance);
    partial void Deletecarseat(carseat instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertidentity_type(identity_type instance);
    partial void Updateidentity_type(identity_type instance);
    partial void Deleteidentity_type(identity_type instance);
    partial void Inserttransaction(transaction instance);
    partial void Updatetransaction(transaction instance);
    partial void Deletetransaction(transaction instance);
    #endregion
		
		public AppDbContextDataContext() : 
				base(global::Car_Rental.Properties.Settings.Default.Car_Rent_SystemConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<car> cars
		{
			get
			{
				return this.GetTable<car>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<carseat> carseats
		{
			get
			{
				return this.GetTable<carseat>();
			}
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<identity_type> identity_types
		{
			get
			{
				return this.GetTable<identity_type>();
			}
		}
		
		public System.Data.Linq.Table<transaction> transactions
		{
			get
			{
				return this.GetTable<transaction>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cars")]
	public partial class car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _car_id;
		
		private string _brand;
		
		private string _plate;
		
		private string _color;
		
		private System.Nullable<System.DateTime> _year;
		
		private System.Nullable<int> _status;
		
		private string _rental_price;
		
		private int _car_seat_id;
		
		private string _image_name;
		
		private EntityRef<carseat> _carseat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncar_idChanging(int value);
    partial void Oncar_idChanged();
    partial void OnbrandChanging(string value);
    partial void OnbrandChanged();
    partial void OnplateChanging(string value);
    partial void OnplateChanged();
    partial void OncolorChanging(string value);
    partial void OncolorChanged();
    partial void OnyearChanging(System.Nullable<System.DateTime> value);
    partial void OnyearChanged();
    partial void OnstatusChanging(System.Nullable<int> value);
    partial void OnstatusChanged();
    partial void Onrental_priceChanging(string value);
    partial void Onrental_priceChanged();
    partial void Oncar_seat_idChanging(int value);
    partial void Oncar_seat_idChanged();
    partial void Onimage_nameChanging(string value);
    partial void Onimage_nameChanged();
    #endregion
		
		public car()
		{
			this._carseat = default(EntityRef<carseat>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int car_id
		{
			get
			{
				return this._car_id;
			}
			set
			{
				if ((this._car_id != value))
				{
					this.Oncar_idChanging(value);
					this.SendPropertyChanging();
					this._car_id = value;
					this.SendPropertyChanged("car_id");
					this.Oncar_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brand", DbType="VarChar(50)")]
		public string brand
		{
			get
			{
				return this._brand;
			}
			set
			{
				if ((this._brand != value))
				{
					this.OnbrandChanging(value);
					this.SendPropertyChanging();
					this._brand = value;
					this.SendPropertyChanged("brand");
					this.OnbrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plate", DbType="VarChar(50)")]
		public string plate
		{
			get
			{
				return this._plate;
			}
			set
			{
				if ((this._plate != value))
				{
					this.OnplateChanging(value);
					this.SendPropertyChanging();
					this._plate = value;
					this.SendPropertyChanged("plate");
					this.OnplateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="VarChar(50)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this.OncolorChanging(value);
					this.SendPropertyChanging();
					this._color = value;
					this.SendPropertyChanged("color");
					this.OncolorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="Date")]
		public System.Nullable<System.DateTime> year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this.OnyearChanging(value);
					this.SendPropertyChanging();
					this._year = value;
					this.SendPropertyChanged("year");
					this.OnyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int")]
		public System.Nullable<int> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rental_price", DbType="VarChar(50)")]
		public string rental_price
		{
			get
			{
				return this._rental_price;
			}
			set
			{
				if ((this._rental_price != value))
				{
					this.Onrental_priceChanging(value);
					this.SendPropertyChanging();
					this._rental_price = value;
					this.SendPropertyChanged("rental_price");
					this.Onrental_priceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_seat_id", DbType="Int NOT NULL")]
		public int car_seat_id
		{
			get
			{
				return this._car_seat_id;
			}
			set
			{
				if ((this._car_seat_id != value))
				{
					if (this._carseat.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncar_seat_idChanging(value);
					this.SendPropertyChanging();
					this._car_seat_id = value;
					this.SendPropertyChanged("car_seat_id");
					this.Oncar_seat_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image_name", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string image_name
		{
			get
			{
				return this._image_name;
			}
			set
			{
				if ((this._image_name != value))
				{
					this.Onimage_nameChanging(value);
					this.SendPropertyChanging();
					this._image_name = value;
					this.SendPropertyChanged("image_name");
					this.Onimage_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="carseat_car", Storage="_carseat", ThisKey="car_seat_id", OtherKey="car_seat_id", IsForeignKey=true)]
		public carseat carseat
		{
			get
			{
				return this._carseat.Entity;
			}
			set
			{
				carseat previousValue = this._carseat.Entity;
				if (((previousValue != value) 
							|| (this._carseat.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._carseat.Entity = null;
						previousValue.cars.Remove(this);
					}
					this._carseat.Entity = value;
					if ((value != null))
					{
						value.cars.Add(this);
						this._car_seat_id = value.car_seat_id;
					}
					else
					{
						this._car_seat_id = default(int);
					}
					this.SendPropertyChanged("carseat");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private string _name;
		
		private string _username;
		
		private string _password;
		
		private System.Nullable<int> _level;
		
		private EntitySet<transaction> _transactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnlevelChanging(System.Nullable<int> value);
    partial void OnlevelChanged();
    #endregion
		
		public user()
		{
			this._transactions = new EntitySet<transaction>(new Action<transaction>(this.attach_transactions), new Action<transaction>(this.detach_transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[level]", Storage="_level", DbType="Int")]
		public System.Nullable<int> level
		{
			get
			{
				return this._level;
			}
			set
			{
				if ((this._level != value))
				{
					this.OnlevelChanging(value);
					this.SendPropertyChanging();
					this._level = value;
					this.SendPropertyChanged("level");
					this.OnlevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_transaction", Storage="_transactions", ThisKey="user_id", OtherKey="user_id")]
		public EntitySet<transaction> transactions
		{
			get
			{
				return this._transactions;
			}
			set
			{
				this._transactions.Assign(value);
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
		
		private void attach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.carseat")]
	public partial class carseat : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _car_seat_id;
		
		private string _name;
		
		private EntitySet<car> _cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncar_seat_idChanging(int value);
    partial void Oncar_seat_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public carseat()
		{
			this._cars = new EntitySet<car>(new Action<car>(this.attach_cars), new Action<car>(this.detach_cars));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_seat_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int car_seat_id
		{
			get
			{
				return this._car_seat_id;
			}
			set
			{
				if ((this._car_seat_id != value))
				{
					this.Oncar_seat_idChanging(value);
					this.SendPropertyChanging();
					this._car_seat_id = value;
					this.SendPropertyChanged("car_seat_id");
					this.Oncar_seat_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="carseat_car", Storage="_cars", ThisKey="car_seat_id", OtherKey="car_seat_id")]
		public EntitySet<car> cars
		{
			get
			{
				return this._cars;
			}
			set
			{
				this._cars.Assign(value);
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
		
		private void attach_cars(car entity)
		{
			this.SendPropertyChanging();
			entity.carseat = this;
		}
		
		private void detach_cars(car entity)
		{
			this.SendPropertyChanging();
			entity.carseat = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customer")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _customer_id;
		
		private string _identity_number;
		
		private int _identity_type_id;
		
		private string _address;
		
		private int _gender;
		
		private string _phone_number;
		
		private EntitySet<transaction> _transactions;
		
		private EntityRef<identity_type> _identity_type;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncustomer_idChanging(int value);
    partial void Oncustomer_idChanged();
    partial void Onidentity_numberChanging(string value);
    partial void Onidentity_numberChanged();
    partial void Onidentity_type_idChanging(int value);
    partial void Onidentity_type_idChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OngenderChanging(int value);
    partial void OngenderChanged();
    partial void Onphone_numberChanging(string value);
    partial void Onphone_numberChanged();
    #endregion
		
		public customer()
		{
			this._transactions = new EntitySet<transaction>(new Action<transaction>(this.attach_transactions), new Action<transaction>(this.detach_transactions));
			this._identity_type = default(EntityRef<identity_type>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identity_number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string identity_number
		{
			get
			{
				return this._identity_number;
			}
			set
			{
				if ((this._identity_number != value))
				{
					this.Onidentity_numberChanging(value);
					this.SendPropertyChanging();
					this._identity_number = value;
					this.SendPropertyChanged("identity_number");
					this.Onidentity_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identity_type_id", DbType="Int NOT NULL")]
		public int identity_type_id
		{
			get
			{
				return this._identity_type_id;
			}
			set
			{
				if ((this._identity_type_id != value))
				{
					if (this._identity_type.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onidentity_type_idChanging(value);
					this.SendPropertyChanging();
					this._identity_type_id = value;
					this.SendPropertyChanged("identity_type_id");
					this.Onidentity_type_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="Int NOT NULL")]
		public int gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone_number", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string phone_number
		{
			get
			{
				return this._phone_number;
			}
			set
			{
				if ((this._phone_number != value))
				{
					this.Onphone_numberChanging(value);
					this.SendPropertyChanging();
					this._phone_number = value;
					this.SendPropertyChanged("phone_number");
					this.Onphone_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_transaction", Storage="_transactions", ThisKey="customer_id", OtherKey="customer_id")]
		public EntitySet<transaction> transactions
		{
			get
			{
				return this._transactions;
			}
			set
			{
				this._transactions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="identity_type_customer", Storage="_identity_type", ThisKey="identity_type_id", OtherKey="identity_type_id", IsForeignKey=true)]
		public identity_type identity_type
		{
			get
			{
				return this._identity_type.Entity;
			}
			set
			{
				identity_type previousValue = this._identity_type.Entity;
				if (((previousValue != value) 
							|| (this._identity_type.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._identity_type.Entity = null;
						previousValue.customers.Remove(this);
					}
					this._identity_type.Entity = value;
					if ((value != null))
					{
						value.customers.Add(this);
						this._identity_type_id = value.identity_type_id;
					}
					else
					{
						this._identity_type_id = default(int);
					}
					this.SendPropertyChanged("identity_type");
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
		
		private void attach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.customer = this;
		}
		
		private void detach_transactions(transaction entity)
		{
			this.SendPropertyChanging();
			entity.customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.identity_type")]
	public partial class identity_type : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _identity_type_id;
		
		private string _name;
		
		private EntitySet<customer> _customers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onidentity_type_idChanging(int value);
    partial void Onidentity_type_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public identity_type()
		{
			this._customers = new EntitySet<customer>(new Action<customer>(this.attach_customers), new Action<customer>(this.detach_customers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_identity_type_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int identity_type_id
		{
			get
			{
				return this._identity_type_id;
			}
			set
			{
				if ((this._identity_type_id != value))
				{
					this.Onidentity_type_idChanging(value);
					this.SendPropertyChanging();
					this._identity_type_id = value;
					this.SendPropertyChanged("identity_type_id");
					this.Onidentity_type_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="identity_type_customer", Storage="_customers", ThisKey="identity_type_id", OtherKey="identity_type_id")]
		public EntitySet<customer> customers
		{
			get
			{
				return this._customers;
			}
			set
			{
				this._customers.Assign(value);
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
		
		private void attach_customers(customer entity)
		{
			this.SendPropertyChanging();
			entity.identity_type = this;
		}
		
		private void detach_customers(customer entity)
		{
			this.SendPropertyChanging();
			entity.identity_type = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.transactions")]
	public partial class transaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _transaction_id;
		
		private int _user_id;
		
		private int _customer_id;
		
		private int _car_id;
		
		private System.DateTime _rent_date;
		
		private System.DateTime _return_date;
		
		private double _total_price;
		
		private EntityRef<customer> _customer;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontransaction_idChanging(int value);
    partial void Ontransaction_idChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Oncustomer_idChanging(int value);
    partial void Oncustomer_idChanged();
    partial void Oncar_idChanging(int value);
    partial void Oncar_idChanged();
    partial void Onrent_dateChanging(System.DateTime value);
    partial void Onrent_dateChanged();
    partial void Onreturn_dateChanging(System.DateTime value);
    partial void Onreturn_dateChanged();
    partial void Ontotal_priceChanging(double value);
    partial void Ontotal_priceChanged();
    #endregion
		
		public transaction()
		{
			this._customer = default(EntityRef<customer>);
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transaction_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int transaction_id
		{
			get
			{
				return this._transaction_id;
			}
			set
			{
				if ((this._transaction_id != value))
				{
					this.Ontransaction_idChanging(value);
					this.SendPropertyChanging();
					this._transaction_id = value;
					this.SendPropertyChanged("transaction_id");
					this.Ontransaction_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int NOT NULL")]
		public int customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					if (this._customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncustomer_idChanging(value);
					this.SendPropertyChanging();
					this._customer_id = value;
					this.SendPropertyChanged("customer_id");
					this.Oncustomer_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_id", DbType="Int NOT NULL")]
		public int car_id
		{
			get
			{
				return this._car_id;
			}
			set
			{
				if ((this._car_id != value))
				{
					this.Oncar_idChanging(value);
					this.SendPropertyChanging();
					this._car_id = value;
					this.SendPropertyChanged("car_id");
					this.Oncar_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rent_date", DbType="Date NOT NULL")]
		public System.DateTime rent_date
		{
			get
			{
				return this._rent_date;
			}
			set
			{
				if ((this._rent_date != value))
				{
					this.Onrent_dateChanging(value);
					this.SendPropertyChanging();
					this._rent_date = value;
					this.SendPropertyChanged("rent_date");
					this.Onrent_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_return_date", DbType="Date NOT NULL")]
		public System.DateTime return_date
		{
			get
			{
				return this._return_date;
			}
			set
			{
				if ((this._return_date != value))
				{
					this.Onreturn_dateChanging(value);
					this.SendPropertyChanging();
					this._return_date = value;
					this.SendPropertyChanged("return_date");
					this.Onreturn_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_price", DbType="Float NOT NULL")]
		public double total_price
		{
			get
			{
				return this._total_price;
			}
			set
			{
				if ((this._total_price != value))
				{
					this.Ontotal_priceChanging(value);
					this.SendPropertyChanging();
					this._total_price = value;
					this.SendPropertyChanged("total_price");
					this.Ontotal_priceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="customer_transaction", Storage="_customer", ThisKey="customer_id", OtherKey="customer_id", IsForeignKey=true)]
		public customer customer
		{
			get
			{
				return this._customer.Entity;
			}
			set
			{
				customer previousValue = this._customer.Entity;
				if (((previousValue != value) 
							|| (this._customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._customer.Entity = null;
						previousValue.transactions.Remove(this);
					}
					this._customer.Entity = value;
					if ((value != null))
					{
						value.transactions.Add(this);
						this._customer_id = value.customer_id;
					}
					else
					{
						this._customer_id = default(int);
					}
					this.SendPropertyChanged("customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_transaction", Storage="_user", ThisKey="user_id", OtherKey="user_id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.transactions.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.transactions.Add(this);
						this._user_id = value.user_id;
					}
					else
					{
						this._user_id = default(int);
					}
					this.SendPropertyChanged("user");
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
