﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CafeCMU.Module.BusinessObjects.ORMDataModel1
{

    public partial class Nhanvien : XPObject
    {
        string fHoten;
        public string Hoten
        {
            get { return fHoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref fHoten, value); }
        }
        string fDienthoai;
        public string Dienthoai
        {
            get { return fDienthoai; }
            set { SetPropertyValue<string>(nameof(Dienthoai), ref fDienthoai, value); }
        }
        string fMucluong;
        public string Mucluong
        {
            get { return fMucluong; }
            set { SetPropertyValue<string>(nameof(Mucluong), ref fMucluong, value); }
        }
        [Association(@"PhieuchiReferencesNhanvien"), Aggregated]
        public XPCollection<Phieuchi> Phieuchis { get { return GetCollection<Phieuchi>(nameof(Phieuchis)); } }
        [Association(@"BangluongReferencesNhanvien"), Aggregated]
        public XPCollection<Bangluong> Bangluongs { get { return GetCollection<Bangluong>(nameof(Bangluongs)); } }
        [Association(@"ChamcongReferencesNhanvien"), Aggregated]
        public XPCollection<Chamcong> Chamcongs { get { return GetCollection<Chamcong>(nameof(Chamcongs)); } }
        [Association(@"HoadonReferencesNhanvien"), Aggregated]
        public XPCollection<Hoadon> Hoadons { get { return GetCollection<Hoadon>(nameof(Hoadons)); } }
        [Association(@"PhieunhapReferencesNhanvien"), Aggregated]
        public XPCollection<Phieunhap> Phieunhaps { get { return GetCollection<Phieunhap>(nameof(Phieunhaps)); } }
    }

}