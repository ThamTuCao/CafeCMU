﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CafeCMU.Module.BusinessObjects.ORMDataModel1
{

    public partial class Khachhang
    {
        public Khachhang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}