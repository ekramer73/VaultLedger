﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Bandl.VaultLedger.Web.Printing {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsReceiveList : DataSet {
        
        private HeaderLogoDataTable tableHeaderLogo;
        
        private ReceiveListDataTable tableReceiveList;
        
        public dsReceiveList() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsReceiveList(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["HeaderLogo"] != null)) {
                    this.Tables.Add(new HeaderLogoDataTable(ds.Tables["HeaderLogo"]));
                }
                if ((ds.Tables["ReceiveList"] != null)) {
                    this.Tables.Add(new ReceiveListDataTable(ds.Tables["ReceiveList"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public HeaderLogoDataTable HeaderLogo {
            get {
                return this.tableHeaderLogo;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ReceiveListDataTable ReceiveList {
            get {
                return this.tableReceiveList;
            }
        }
        
        public override DataSet Clone() {
            dsReceiveList cln = ((dsReceiveList)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["HeaderLogo"] != null)) {
                this.Tables.Add(new HeaderLogoDataTable(ds.Tables["HeaderLogo"]));
            }
            if ((ds.Tables["ReceiveList"] != null)) {
                this.Tables.Add(new ReceiveListDataTable(ds.Tables["ReceiveList"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableHeaderLogo = ((HeaderLogoDataTable)(this.Tables["HeaderLogo"]));
            if ((this.tableHeaderLogo != null)) {
                this.tableHeaderLogo.InitVars();
            }
            this.tableReceiveList = ((ReceiveListDataTable)(this.Tables["ReceiveList"]));
            if ((this.tableReceiveList != null)) {
                this.tableReceiveList.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsReceiveList";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsReceiveList.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableHeaderLogo = new HeaderLogoDataTable();
            this.Tables.Add(this.tableHeaderLogo);
            this.tableReceiveList = new ReceiveListDataTable();
            this.Tables.Add(this.tableReceiveList);
        }
        
        private bool ShouldSerializeHeaderLogo() {
            return false;
        }
        
        private bool ShouldSerializeReceiveList() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void HeaderLogoRowChangeEventHandler(object sender, HeaderLogoRowChangeEvent e);
        
        public delegate void ReceiveListRowChangeEventHandler(object sender, ReceiveListRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HeaderLogoDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCompanyLogo;
            
            private DataColumn columnProductLogo;
            
            private DataColumn columnReportTitle;
            
            internal HeaderLogoDataTable() : 
                    base("HeaderLogo") {
                this.InitClass();
            }
            
            internal HeaderLogoDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn CompanyLogoColumn {
                get {
                    return this.columnCompanyLogo;
                }
            }
            
            internal DataColumn ProductLogoColumn {
                get {
                    return this.columnProductLogo;
                }
            }
            
            internal DataColumn ReportTitleColumn {
                get {
                    return this.columnReportTitle;
                }
            }
            
            public HeaderLogoRow this[int index] {
                get {
                    return ((HeaderLogoRow)(this.Rows[index]));
                }
            }
            
            public event HeaderLogoRowChangeEventHandler HeaderLogoRowChanged;
            
            public event HeaderLogoRowChangeEventHandler HeaderLogoRowChanging;
            
            public event HeaderLogoRowChangeEventHandler HeaderLogoRowDeleted;
            
            public event HeaderLogoRowChangeEventHandler HeaderLogoRowDeleting;
            
            public void AddHeaderLogoRow(HeaderLogoRow row) {
                this.Rows.Add(row);
            }
            
            public HeaderLogoRow AddHeaderLogoRow(System.Byte[] CompanyLogo, System.Byte[] ProductLogo, string ReportTitle) {
                HeaderLogoRow rowHeaderLogoRow = ((HeaderLogoRow)(this.NewRow()));
                rowHeaderLogoRow.ItemArray = new object[] {
                        CompanyLogo,
                        ProductLogo,
                        ReportTitle};
                this.Rows.Add(rowHeaderLogoRow);
                return rowHeaderLogoRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                HeaderLogoDataTable cln = ((HeaderLogoDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new HeaderLogoDataTable();
            }
            
            internal void InitVars() {
                this.columnCompanyLogo = this.Columns["CompanyLogo"];
                this.columnProductLogo = this.Columns["ProductLogo"];
                this.columnReportTitle = this.Columns["ReportTitle"];
            }
            
            private void InitClass() {
                this.columnCompanyLogo = new DataColumn("CompanyLogo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyLogo);
                this.columnProductLogo = new DataColumn("ProductLogo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductLogo);
                this.columnReportTitle = new DataColumn("ReportTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReportTitle);
            }
            
            public HeaderLogoRow NewHeaderLogoRow() {
                return ((HeaderLogoRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new HeaderLogoRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(HeaderLogoRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.HeaderLogoRowChanged != null)) {
                    this.HeaderLogoRowChanged(this, new HeaderLogoRowChangeEvent(((HeaderLogoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.HeaderLogoRowChanging != null)) {
                    this.HeaderLogoRowChanging(this, new HeaderLogoRowChangeEvent(((HeaderLogoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.HeaderLogoRowDeleted != null)) {
                    this.HeaderLogoRowDeleted(this, new HeaderLogoRowChangeEvent(((HeaderLogoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.HeaderLogoRowDeleting != null)) {
                    this.HeaderLogoRowDeleting(this, new HeaderLogoRowChangeEvent(((HeaderLogoRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveHeaderLogoRow(HeaderLogoRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HeaderLogoRow : DataRow {
            
            private HeaderLogoDataTable tableHeaderLogo;
            
            internal HeaderLogoRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableHeaderLogo = ((HeaderLogoDataTable)(this.Table));
            }
            
            public System.Byte[] CompanyLogo {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableHeaderLogo.CompanyLogoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.CompanyLogoColumn] = value;
                }
            }
            
            public System.Byte[] ProductLogo {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableHeaderLogo.ProductLogoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.ProductLogoColumn] = value;
                }
            }
            
            public string ReportTitle {
                get {
                    try {
                        return ((string)(this[this.tableHeaderLogo.ReportTitleColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.ReportTitleColumn] = value;
                }
            }
            
            public bool IsCompanyLogoNull() {
                return this.IsNull(this.tableHeaderLogo.CompanyLogoColumn);
            }
            
            public void SetCompanyLogoNull() {
                this[this.tableHeaderLogo.CompanyLogoColumn] = System.Convert.DBNull;
            }
            
            public bool IsProductLogoNull() {
                return this.IsNull(this.tableHeaderLogo.ProductLogoColumn);
            }
            
            public void SetProductLogoNull() {
                this[this.tableHeaderLogo.ProductLogoColumn] = System.Convert.DBNull;
            }
            
            public bool IsReportTitleNull() {
                return this.IsNull(this.tableHeaderLogo.ReportTitleColumn);
            }
            
            public void SetReportTitleNull() {
                this[this.tableHeaderLogo.ReportTitleColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HeaderLogoRowChangeEvent : EventArgs {
            
            private HeaderLogoRow eventRow;
            
            private DataRowAction eventAction;
            
            public HeaderLogoRowChangeEvent(HeaderLogoRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public HeaderLogoRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ReceiveListDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnListName;
            
            private DataColumn columnStatus;
            
            private DataColumn columnAccount;
            
            private DataColumn columnCreateDate;
            
            private DataColumn columnComposite;
            
            private DataColumn columnNotes;
            
            internal ReceiveListDataTable() : 
                    base("ReceiveList") {
                this.InitClass();
            }
            
            internal ReceiveListDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ListNameColumn {
                get {
                    return this.columnListName;
                }
            }
            
            internal DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            
            internal DataColumn AccountColumn {
                get {
                    return this.columnAccount;
                }
            }
            
            internal DataColumn CreateDateColumn {
                get {
                    return this.columnCreateDate;
                }
            }
            
            internal DataColumn CompositeColumn {
                get {
                    return this.columnComposite;
                }
            }
            
            internal DataColumn NotesColumn {
                get {
                    return this.columnNotes;
                }
            }
            
            public ReceiveListRow this[int index] {
                get {
                    return ((ReceiveListRow)(this.Rows[index]));
                }
            }
            
            public event ReceiveListRowChangeEventHandler ReceiveListRowChanged;
            
            public event ReceiveListRowChangeEventHandler ReceiveListRowChanging;
            
            public event ReceiveListRowChangeEventHandler ReceiveListRowDeleted;
            
            public event ReceiveListRowChangeEventHandler ReceiveListRowDeleting;
            
            public void AddReceiveListRow(ReceiveListRow row) {
                this.Rows.Add(row);
            }
            
            public ReceiveListRow AddReceiveListRow(string ListName, string Status, string Account, string CreateDate, string Composite, string Notes) {
                ReceiveListRow rowReceiveListRow = ((ReceiveListRow)(this.NewRow()));
                rowReceiveListRow.ItemArray = new object[] {
                        ListName,
                        Status,
                        Account,
                        CreateDate,
                        Composite,
                        Notes};
                this.Rows.Add(rowReceiveListRow);
                return rowReceiveListRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ReceiveListDataTable cln = ((ReceiveListDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ReceiveListDataTable();
            }
            
            internal void InitVars() {
                this.columnListName = this.Columns["ListName"];
                this.columnStatus = this.Columns["Status"];
                this.columnAccount = this.Columns["Account"];
                this.columnCreateDate = this.Columns["CreateDate"];
                this.columnComposite = this.Columns["Composite"];
                this.columnNotes = this.Columns["Notes"];
            }
            
            private void InitClass() {
                this.columnListName = new DataColumn("ListName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnListName);
                this.columnStatus = new DataColumn("Status", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStatus);
                this.columnAccount = new DataColumn("Account", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAccount);
                this.columnCreateDate = new DataColumn("CreateDate", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCreateDate);
                this.columnComposite = new DataColumn("Composite", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnComposite);
                this.columnNotes = new DataColumn("Notes", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNotes);
            }
            
            public ReceiveListRow NewReceiveListRow() {
                return ((ReceiveListRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ReceiveListRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ReceiveListRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ReceiveListRowChanged != null)) {
                    this.ReceiveListRowChanged(this, new ReceiveListRowChangeEvent(((ReceiveListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ReceiveListRowChanging != null)) {
                    this.ReceiveListRowChanging(this, new ReceiveListRowChangeEvent(((ReceiveListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ReceiveListRowDeleted != null)) {
                    this.ReceiveListRowDeleted(this, new ReceiveListRowChangeEvent(((ReceiveListRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ReceiveListRowDeleting != null)) {
                    this.ReceiveListRowDeleting(this, new ReceiveListRowChangeEvent(((ReceiveListRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveReceiveListRow(ReceiveListRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ReceiveListRow : DataRow {
            
            private ReceiveListDataTable tableReceiveList;
            
            internal ReceiveListRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableReceiveList = ((ReceiveListDataTable)(this.Table));
            }
            
            public string ListName {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.ListNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.ListNameColumn] = value;
                }
            }
            
            public string Status {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.StatusColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.StatusColumn] = value;
                }
            }
            
            public string Account {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.AccountColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.AccountColumn] = value;
                }
            }
            
            public string CreateDate {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.CreateDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.CreateDateColumn] = value;
                }
            }
            
            public string Composite {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.CompositeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.CompositeColumn] = value;
                }
            }
            
            public string Notes {
                get {
                    try {
                        return ((string)(this[this.tableReceiveList.NotesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveList.NotesColumn] = value;
                }
            }
            
            public bool IsListNameNull() {
                return this.IsNull(this.tableReceiveList.ListNameColumn);
            }
            
            public void SetListNameNull() {
                this[this.tableReceiveList.ListNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsStatusNull() {
                return this.IsNull(this.tableReceiveList.StatusColumn);
            }
            
            public void SetStatusNull() {
                this[this.tableReceiveList.StatusColumn] = System.Convert.DBNull;
            }
            
            public bool IsAccountNull() {
                return this.IsNull(this.tableReceiveList.AccountColumn);
            }
            
            public void SetAccountNull() {
                this[this.tableReceiveList.AccountColumn] = System.Convert.DBNull;
            }
            
            public bool IsCreateDateNull() {
                return this.IsNull(this.tableReceiveList.CreateDateColumn);
            }
            
            public void SetCreateDateNull() {
                this[this.tableReceiveList.CreateDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsCompositeNull() {
                return this.IsNull(this.tableReceiveList.CompositeColumn);
            }
            
            public void SetCompositeNull() {
                this[this.tableReceiveList.CompositeColumn] = System.Convert.DBNull;
            }
            
            public bool IsNotesNull() {
                return this.IsNull(this.tableReceiveList.NotesColumn);
            }
            
            public void SetNotesNull() {
                this[this.tableReceiveList.NotesColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ReceiveListRowChangeEvent : EventArgs {
            
            private ReceiveListRow eventRow;
            
            private DataRowAction eventAction;
            
            public ReceiveListRowChangeEvent(ReceiveListRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ReceiveListRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
