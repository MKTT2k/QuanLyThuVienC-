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

namespace LVH
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyThuVienCSharp")]
	public partial class QuanLyThuVienDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    partial void InsertSACH(SACH instance);
    partial void UpdateSACH(SACH instance);
    partial void DeleteSACH(SACH instance);
    partial void InsertPHIEUMUON(PHIEUMUON instance);
    partial void UpdatePHIEUMUON(PHIEUMUON instance);
    partial void DeletePHIEUMUON(PHIEUMUON instance);
    partial void InsertDANHMUC(DANHMUC instance);
    partial void UpdateDANHMUC(DANHMUC instance);
    partial void DeleteDANHMUC(DANHMUC instance);
    partial void InsertCTPHIEUMUON(CTPHIEUMUON instance);
    partial void UpdateCTPHIEUMUON(CTPHIEUMUON instance);
    partial void DeleteCTPHIEUMUON(CTPHIEUMUON instance);
    #endregion
		
		public QuanLyThuVienDataContext() : 
				base(global::LVH.Properties.Settings.Default.QuanLyThuVienCSharpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThuVienDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThuVienDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThuVienDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThuVienDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
		
		public System.Data.Linq.Table<SACH> SACHes
		{
			get
			{
				return this.GetTable<SACH>();
			}
		}
		
		public System.Data.Linq.Table<PHIEUMUON> PHIEUMUONs
		{
			get
			{
				return this.GetTable<PHIEUMUON>();
			}
		}
		
		public System.Data.Linq.Table<DANHMUC> DANHMUCs
		{
			get
			{
				return this.GetTable<DANHMUC>();
			}
		}
		
		public System.Data.Linq.Table<CTPHIEUMUON> CTPHIEUMUONs
		{
			get
			{
				return this.GetTable<CTPHIEUMUON>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDTaiKhoan;
		
		private System.Data.Linq.Binary _AnhDaiDien;
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private string _TenNguoiDung;
		
		private System.Nullable<int> _LoaiTaiKhoan;
		
		private System.Nullable<bool> _TinhTrang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDTaiKhoanChanging(int value);
    partial void OnIDTaiKhoanChanged();
    partial void OnAnhDaiDienChanging(System.Data.Linq.Binary value);
    partial void OnAnhDaiDienChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnTenNguoiDungChanging(string value);
    partial void OnTenNguoiDungChanged();
    partial void OnLoaiTaiKhoanChanging(System.Nullable<int> value);
    partial void OnLoaiTaiKhoanChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public TAIKHOAN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTaiKhoan", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDTaiKhoan
		{
			get
			{
				return this._IDTaiKhoan;
			}
			set
			{
				if ((this._IDTaiKhoan != value))
				{
					this.OnIDTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._IDTaiKhoan = value;
					this.SendPropertyChanged("IDTaiKhoan");
					this.OnIDTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhDaiDien", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary AnhDaiDien
		{
			get
			{
				return this._AnhDaiDien;
			}
			set
			{
				if ((this._AnhDaiDien != value))
				{
					this.OnAnhDaiDienChanging(value);
					this.SendPropertyChanging();
					this._AnhDaiDien = value;
					this.SendPropertyChanged("AnhDaiDien");
					this.OnAnhDaiDienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNguoiDung", DbType="NVarChar(50)")]
		public string TenNguoiDung
		{
			get
			{
				return this._TenNguoiDung;
			}
			set
			{
				if ((this._TenNguoiDung != value))
				{
					this.OnTenNguoiDungChanging(value);
					this.SendPropertyChanging();
					this._TenNguoiDung = value;
					this.SendPropertyChanged("TenNguoiDung");
					this.OnTenNguoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTaiKhoan", DbType="Int")]
		public System.Nullable<int> LoaiTaiKhoan
		{
			get
			{
				return this._LoaiTaiKhoan;
			}
			set
			{
				if ((this._LoaiTaiKhoan != value))
				{
					this.OnLoaiTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._LoaiTaiKhoan = value;
					this.SendPropertyChanged("LoaiTaiKhoan");
					this.OnLoaiTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SACH")]
	public partial class SACH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSach;
		
		private System.Data.Linq.Binary _AnhSach;
		
		private string _TenSach;
		
		private System.Nullable<int> _SoLuong;
		
		private string _TacGia;
		
		private string _NhaXuatBan;
		
		private System.Nullable<System.DateTime> _NamXuatBan;
		
		private System.Nullable<int> _LanXuatBan;
		
		private System.Nullable<decimal> _GiaMuon;
		
		private int _MaDanhMuc;
		
		private EntitySet<CTPHIEUMUON> _CTPHIEUMUONs;
		
		private EntityRef<DANHMUC> _DANHMUC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(int value);
    partial void OnMaSachChanged();
    partial void OnAnhSachChanging(System.Data.Linq.Binary value);
    partial void OnAnhSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OnNhaXuatBanChanging(string value);
    partial void OnNhaXuatBanChanged();
    partial void OnNamXuatBanChanging(System.Nullable<System.DateTime> value);
    partial void OnNamXuatBanChanged();
    partial void OnLanXuatBanChanging(System.Nullable<int> value);
    partial void OnLanXuatBanChanged();
    partial void OnGiaMuonChanging(System.Nullable<decimal> value);
    partial void OnGiaMuonChanged();
    partial void OnMaDanhMucChanging(int value);
    partial void OnMaDanhMucChanged();
    #endregion
		
		public SACH()
		{
			this._CTPHIEUMUONs = new EntitySet<CTPHIEUMUON>(new Action<CTPHIEUMUON>(this.attach_CTPHIEUMUONs), new Action<CTPHIEUMUON>(this.detach_CTPHIEUMUONs));
			this._DANHMUC = default(EntityRef<DANHMUC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhSach", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary AnhSach
		{
			get
			{
				return this._AnhSach;
			}
			set
			{
				if ((this._AnhSach != value))
				{
					this.OnAnhSachChanging(value);
					this.SendPropertyChanging();
					this._AnhSach = value;
					this.SendPropertyChanged("AnhSach");
					this.OnAnhSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(50)")]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(50)")]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhaXuatBan", DbType="NVarChar(50)")]
		public string NhaXuatBan
		{
			get
			{
				return this._NhaXuatBan;
			}
			set
			{
				if ((this._NhaXuatBan != value))
				{
					this.OnNhaXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NhaXuatBan = value;
					this.SendPropertyChanged("NhaXuatBan");
					this.OnNhaXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamXuatBan", DbType="Date")]
		public System.Nullable<System.DateTime> NamXuatBan
		{
			get
			{
				return this._NamXuatBan;
			}
			set
			{
				if ((this._NamXuatBan != value))
				{
					this.OnNamXuatBanChanging(value);
					this.SendPropertyChanging();
					this._NamXuatBan = value;
					this.SendPropertyChanged("NamXuatBan");
					this.OnNamXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXuatBan", DbType="Int")]
		public System.Nullable<int> LanXuatBan
		{
			get
			{
				return this._LanXuatBan;
			}
			set
			{
				if ((this._LanXuatBan != value))
				{
					this.OnLanXuatBanChanging(value);
					this.SendPropertyChanging();
					this._LanXuatBan = value;
					this.SendPropertyChanged("LanXuatBan");
					this.OnLanXuatBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaMuon", DbType="Money")]
		public System.Nullable<decimal> GiaMuon
		{
			get
			{
				return this._GiaMuon;
			}
			set
			{
				if ((this._GiaMuon != value))
				{
					this.OnGiaMuonChanging(value);
					this.SendPropertyChanging();
					this._GiaMuon = value;
					this.SendPropertyChanged("GiaMuon");
					this.OnGiaMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="Int NOT NULL")]
		public int MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					if (this._DANHMUC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SACH_CTPHIEUMUON", Storage="_CTPHIEUMUONs", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<CTPHIEUMUON> CTPHIEUMUONs
		{
			get
			{
				return this._CTPHIEUMUONs;
			}
			set
			{
				this._CTPHIEUMUONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SACH", Storage="_DANHMUC", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public DANHMUC DANHMUC
		{
			get
			{
				return this._DANHMUC.Entity;
			}
			set
			{
				DANHMUC previousValue = this._DANHMUC.Entity;
				if (((previousValue != value) 
							|| (this._DANHMUC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DANHMUC.Entity = null;
						previousValue.SACHes.Remove(this);
					}
					this._DANHMUC.Entity = value;
					if ((value != null))
					{
						value.SACHes.Add(this);
						this._MaDanhMuc = value.MaDanhMuc;
					}
					else
					{
						this._MaDanhMuc = default(int);
					}
					this.SendPropertyChanged("DANHMUC");
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
		
		private void attach_CTPHIEUMUONs(CTPHIEUMUON entity)
		{
			this.SendPropertyChanging();
			entity.SACH = this;
		}
		
		private void detach_CTPHIEUMUONs(CTPHIEUMUON entity)
		{
			this.SendPropertyChanging();
			entity.SACH = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHIEUMUON")]
	public partial class PHIEUMUON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoPhieuMuon;
		
		private string _TenDangNhap;
		
		private string _MaSinhVien;
		
		private EntitySet<CTPHIEUMUON> _CTPHIEUMUONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoPhieuMuonChanging(int value);
    partial void OnSoPhieuMuonChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMaSinhVienChanging(string value);
    partial void OnMaSinhVienChanged();
    #endregion
		
		public PHIEUMUON()
		{
			this._CTPHIEUMUONs = new EntitySet<CTPHIEUMUON>(new Action<CTPHIEUMUON>(this.attach_CTPHIEUMUONs), new Action<CTPHIEUMUON>(this.detach_CTPHIEUMUONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoPhieuMuon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoPhieuMuon
		{
			get
			{
				return this._SoPhieuMuon;
			}
			set
			{
				if ((this._SoPhieuMuon != value))
				{
					this.OnSoPhieuMuonChanging(value);
					this.SendPropertyChanging();
					this._SoPhieuMuon = value;
					this.SendPropertyChanged("SoPhieuMuon");
					this.OnSoPhieuMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSinhVien", DbType="Char(10)")]
		public string MaSinhVien
		{
			get
			{
				return this._MaSinhVien;
			}
			set
			{
				if ((this._MaSinhVien != value))
				{
					this.OnMaSinhVienChanging(value);
					this.SendPropertyChanging();
					this._MaSinhVien = value;
					this.SendPropertyChanged("MaSinhVien");
					this.OnMaSinhVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHIEUMUON_CTPHIEUMUON", Storage="_CTPHIEUMUONs", ThisKey="SoPhieuMuon", OtherKey="SoPhieuMuon")]
		public EntitySet<CTPHIEUMUON> CTPHIEUMUONs
		{
			get
			{
				return this._CTPHIEUMUONs;
			}
			set
			{
				this._CTPHIEUMUONs.Assign(value);
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
		
		private void attach_CTPHIEUMUONs(CTPHIEUMUON entity)
		{
			this.SendPropertyChanging();
			entity.PHIEUMUON = this;
		}
		
		private void detach_CTPHIEUMUONs(CTPHIEUMUON entity)
		{
			this.SendPropertyChanging();
			entity.PHIEUMUON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANHMUC")]
	public partial class DANHMUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDanhMuc;
		
		private string _TenDanhMuc;
		
		private EntitySet<SACH> _SACHes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDanhMucChanging(int value);
    partial void OnMaDanhMucChanged();
    partial void OnTenDanhMucChanging(string value);
    partial void OnTenDanhMucChanged();
    #endregion
		
		public DANHMUC()
		{
			this._SACHes = new EntitySet<SACH>(new Action<SACH>(this.attach_SACHes), new Action<SACH>(this.detach_SACHes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NVarChar(50)")]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this.OnTenDanhMucChanging(value);
					this.SendPropertyChanging();
					this._TenDanhMuc = value;
					this.SendPropertyChanged("TenDanhMuc");
					this.OnTenDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SACH", Storage="_SACHes", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc")]
		public EntitySet<SACH> SACHes
		{
			get
			{
				return this._SACHes;
			}
			set
			{
				this._SACHes.Assign(value);
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
		
		private void attach_SACHes(SACH entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = this;
		}
		
		private void detach_SACHes(SACH entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTPHIEUMUON")]
	public partial class CTPHIEUMUON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MaSach;
		
		private int _SoPhieuMuon;
		
		private System.Nullable<bool> _TinhTrang;
		
		private System.Nullable<System.DateTime> _NgayMuon;
		
		private System.Nullable<System.DateTime> _NgayTra;
		
		private EntityRef<PHIEUMUON> _PHIEUMUON;
		
		private EntityRef<SACH> _SACH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMaSachChanging(int value);
    partial void OnMaSachChanged();
    partial void OnSoPhieuMuonChanging(int value);
    partial void OnSoPhieuMuonChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    partial void OnNgayMuonChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayMuonChanged();
    partial void OnNgayTraChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTraChanged();
    #endregion
		
		public CTPHIEUMUON()
		{
			this._PHIEUMUON = default(EntityRef<PHIEUMUON>);
			this._SACH = default(EntityRef<SACH>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="Int NOT NULL")]
		public int MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._SACH.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoPhieuMuon", DbType="Int NOT NULL")]
		public int SoPhieuMuon
		{
			get
			{
				return this._SoPhieuMuon;
			}
			set
			{
				if ((this._SoPhieuMuon != value))
				{
					if (this._PHIEUMUON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSoPhieuMuonChanging(value);
					this.SendPropertyChanging();
					this._SoPhieuMuon = value;
					this.SendPropertyChanged("SoPhieuMuon");
					this.OnSoPhieuMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMuon", DbType="Date")]
		public System.Nullable<System.DateTime> NgayMuon
		{
			get
			{
				return this._NgayMuon;
			}
			set
			{
				if ((this._NgayMuon != value))
				{
					this.OnNgayMuonChanging(value);
					this.SendPropertyChanging();
					this._NgayMuon = value;
					this.SendPropertyChanged("NgayMuon");
					this.OnNgayMuonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="Date")]
		public System.Nullable<System.DateTime> NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHIEUMUON_CTPHIEUMUON", Storage="_PHIEUMUON", ThisKey="SoPhieuMuon", OtherKey="SoPhieuMuon", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public PHIEUMUON PHIEUMUON
		{
			get
			{
				return this._PHIEUMUON.Entity;
			}
			set
			{
				PHIEUMUON previousValue = this._PHIEUMUON.Entity;
				if (((previousValue != value) 
							|| (this._PHIEUMUON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHIEUMUON.Entity = null;
						previousValue.CTPHIEUMUONs.Remove(this);
					}
					this._PHIEUMUON.Entity = value;
					if ((value != null))
					{
						value.CTPHIEUMUONs.Add(this);
						this._SoPhieuMuon = value.SoPhieuMuon;
					}
					else
					{
						this._SoPhieuMuon = default(int);
					}
					this.SendPropertyChanged("PHIEUMUON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SACH_CTPHIEUMUON", Storage="_SACH", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public SACH SACH
		{
			get
			{
				return this._SACH.Entity;
			}
			set
			{
				SACH previousValue = this._SACH.Entity;
				if (((previousValue != value) 
							|| (this._SACH.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SACH.Entity = null;
						previousValue.CTPHIEUMUONs.Remove(this);
					}
					this._SACH.Entity = value;
					if ((value != null))
					{
						value.CTPHIEUMUONs.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(int);
					}
					this.SendPropertyChanged("SACH");
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
