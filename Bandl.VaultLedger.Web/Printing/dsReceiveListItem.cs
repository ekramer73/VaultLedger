﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
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
    public class dsReceiveListItem : DataSet {
        
        private HeaderLogoDataTable tableHeaderLogo;
        
        private ReceiveListItemDataTable tableReceiveListItem;
        
        public dsReceiveListItem() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsReceiveListItem(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["HeaderLogo"] != null)) {
                    this.Tables.Add(new HeaderLogoDataTable(ds.Tables["HeaderLogo"]));
                }
                if ((ds.Tables["ReceiveListItem"] != null)) {
                    this.Tables.Add(new ReceiveListItemDataTable(ds.Tables["ReceiveListItem"]));
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
        public ReceiveListItemDataTable ReceiveListItem {
            get {
                return this.tableReceiveListItem;
            }
        }
        
        public override DataSet Clone() {
            dsReceiveListItem cln = ((dsReceiveListItem)(base.Clone()));
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
            if ((ds.Tables["ReceiveListItem"] != null)) {
                this.Tables.Add(new ReceiveListItemDataTable(ds.Tables["ReceiveListItem"]));
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
            this.tableReceiveListItem = ((ReceiveListItemDataTable)(this.Tables["ReceiveListItem"]));
            if ((this.tableReceiveListItem != null)) {
                this.tableReceiveListItem.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsReceiveListItem";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsReceiveListItem.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableHeaderLogo = new HeaderLogoDataTable();
            this.Tables.Add(this.tableHeaderLogo);
            this.tableReceiveListItem = new ReceiveListItemDataTable();
            this.Tables.Add(this.tableReceiveListItem);
        }
        
        private bool ShouldSerializeHeaderLogo() {
            return false;
        }
        
        private bool ShouldSerializeReceiveListItem() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void HeaderLogoRowChangeEventHandler(object sender, HeaderLogoRowChangeEvent e);
        
        public delegate void ReceiveListItemRowChangeEventHandler(object sender, ReceiveListItemRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HeaderLogoDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnCompanyLogo;
            
            private DataColumn columnProductLogo;
            
            private DataColumn columnReportTitle;
            
            private DataColumn columnListNumber;
            
            private DataColumn columnStatus;
            
            private DataColumn columnCreateDate;
            
            private DataColumn columnAccount;
            
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
            
            internal DataColumn ListNumberColumn {
                get {
                    return this.columnListNumber;
                }
            }
            
            internal DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            
            internal DataColumn CreateDateColumn {
                get {
                    return this.columnCreateDate;
                }
            }
            
            internal DataColumn AccountColumn {
                get {
                    return this.columnAccount;
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
            
            public HeaderLogoRow AddHeaderLogoRow(System.Byte[] CompanyLogo, System.Byte[] ProductLogo, string ReportTitle, string ListNumber, string Status, string CreateDate, string Account) {
                HeaderLogoRow rowHeaderLogoRow = ((HeaderLogoRow)(this.NewRow()));
                rowHeaderLogoRow.ItemArray = new object[] {
                        CompanyLogo,
                        ProductLogo,
                        ReportTitle,
                        ListNumber,
                        Status,
                        CreateDate,
                        Account};
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
                this.columnListNumber = this.Columns["ListNumber"];
                this.columnStatus = this.Columns["Status"];
                this.columnCreateDate = this.Columns["CreateDate"];
                this.columnAccount = this.Columns["Account"];
            }
            
            private void InitClass() {
                this.columnCompanyLogo = new DataColumn("CompanyLogo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCompanyLogo);
                this.columnProductLogo = new DataColumn("ProductLogo", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductLogo);
                this.columnReportTitle = new DataColumn("ReportTitle", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReportTitle);
                this.columnListNumber = new DataColumn("ListNumber", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnListNumber);
                this.columnStatus = new DataColumn("Status", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStatus);
                this.columnCreateDate = new DataColumn("CreateDate", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCreateDate);
                this.columnAccount = new DataColumn("Account", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAccount);
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
            
            public string ListNumber {
                get {
                    try {
                        return ((string)(this[this.tableHeaderLogo.ListNumberColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.ListNumberColumn] = value;
                }
            }
            
            public string Status {
                get {
                    try {
                        return ((string)(this[this.tableHeaderLogo.StatusColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.StatusColumn] = value;
                }
            }
            
            public string CreateDate {
                get {
                    try {
                        return ((string)(this[this.tableHeaderLogo.CreateDateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.CreateDateColumn] = value;
                }
            }
            
            public string Account {
                get {
                    try {
                        return ((string)(this[this.tableHeaderLogo.AccountColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableHeaderLogo.AccountColumn] = value;
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
            
            public bool IsListNumberNull() {
                return this.IsNull(this.tableHeaderLogo.ListNumberColumn);
            }
            
            public void SetListNumberNull() {
                this[this.tableHeaderLogo.ListNumberColumn] = System.Convert.DBNull;
            }
            
            public bool IsStatusNull() {
                return this.IsNull(this.tableHeaderLogo.StatusColumn);
            }
            
            public void SetStatusNull() {
                this[this.tableHeaderLogo.StatusColumn] = System.Convert.DBNull;
            }
            
            public bool IsCreateDateNull() {
                return this.IsNull(this.tableHeaderLogo.CreateDateColumn);
            }
            
            public void SetCreateDateNull() {
                this[this.tableHeaderLogo.CreateDateColumn] = System.Convert.DBNull;
            }
            
            public bool IsAccountNull() {
                return this.IsNull(this.tableHeaderLogo.AccountColumn);
            }
            
            public void SetAccountNull() {
                this[this.tableHeaderLogo.AccountColumn] = System.Convert.DBNull;
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
        public class ReceiveListItemDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnSerialNo;
            
            private DataColumn columnStatus;
            
            private DataColumn columnCaseName;
            
            private DataColumn columnNotes;
            
            private DataColumn columnMediaType;
            
            internal ReceiveListItemDataTable() : 
                    base("ReceiveListItem") {
                this.InitClass();
            }
            
            internal ReceiveListItemDataTable(DataTable table) : 
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
            
            internal DataColumn SerialNoColumn {
                get {
                    return this.columnSerialNo;
                }
            }
            
            internal DataColumn StatusColumn {
                get {
                    return this.columnStatus;
                }
            }
            
            internal DataColumn CaseNameColumn {
                get {
                    return this.columnCaseName;
                }
            }
            
            internal DataColumn NotesColumn {
                get {
                    return this.columnNotes;
                }
            }
            
            internal DataColumn MediaTypeColumn {
                get {
                    return this.columnMediaType;
                }
            }
            
            public ReceiveListItemRow this[int index] {
                get {
                    return ((ReceiveListItemRow)(this.Rows[index]));
                }
            }
            
            public event ReceiveListItemRowChangeEventHandler ReceiveListItemRowChanged;
            
            public event ReceiveListItemRowChangeEventHandler ReceiveListItemRowChanging;
            
            public event ReceiveListItemRowChangeEventHandler ReceiveListItemRowDeleted;
            
            public event ReceiveListItemRowChangeEventHandler ReceiveListItemRowDeleting;
            
            public void AddReceiveListItemRow(ReceiveListItemRow row) {
                this.Rows.Add(row);
            }
            
            public ReceiveListItemRow AddReceiveListItemRow(string SerialNo, string Status, string CaseName, string Notes, string MediaType) {
                ReceiveListItemRow rowReceiveListItemRow = ((ReceiveListItemRow)(this.NewRow()));
                rowReceiveListItemRow.ItemArray = new object[] {
                        SerialNo,
                        Status,
                        CaseName,
                        Notes,
                        MediaType};
                this.Rows.Add(rowReceiveListItemRow);
                return rowReceiveListItemRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ReceiveListItemDataTable cln = ((ReceiveListItemDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ReceiveListItemDataTable();
            }
            
            internal void InitVars() {
                this.columnSerialNo = this.Columns["SerialNo"];
                this.columnStatus = this.Columns["Status"];
                this.columnCaseName = this.Columns["CaseName"];
                this.columnNotes = this.Columns["Notes"];
                this.columnMediaType = this.Columns["MediaType"];
            }
            
            private void InitClass() {
                this.columnSerialNo = new DataColumn("SerialNo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSerialNo);
                this.columnStatus = new DataColumn("Status", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStatus);
                this.columnCaseName = new DataColumn("CaseName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCaseName);
                this.columnNotes = new DataColumn("Notes", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNotes);
                this.columnMediaType = new DataColumn("MediaType", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMediaType);
            }
            
            public ReceiveListItemRow NewReceiveListItemRow() {
                return ((ReceiveListItemRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ReceiveListItemRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ReceiveListItemRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ReceiveListItemRowChanged != null)) {
                    this.ReceiveListItemRowChanged(this, new ReceiveListItemRowChangeEvent(((ReceiveListItemRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ReceiveListItemRowChanging != null)) {
                    this.ReceiveListItemRowChanging(this, new ReceiveListItemRowChangeEvent(((ReceiveListItemRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ReceiveListItemRowDeleted != null)) {
                    this.ReceiveListItemRowDeleted(this, new ReceiveListItemRowChangeEvent(((ReceiveListItemRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ReceiveListItemRowDeleting != null)) {
                    this.ReceiveListItemRowDeleting(this, new ReceiveListItemRowChangeEvent(((ReceiveListItemRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveReceiveListItemRow(ReceiveListItemRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ReceiveListItemRow : DataRow {
            
            private ReceiveListItemDataTable tableReceiveListItem;
            
            internal ReceiveListItemRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableReceiveListItem = ((ReceiveListItemDataTable)(this.Table));
            }
            
            public string SerialNo {
                get {
                    try {
                        return ((string)(this[this.tableReceiveListItem.SerialNoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveListItem.SerialNoColumn] = value;
                }
            }
            
            public string Status {
                get {
                    try {
                        return ((string)(this[this.tableReceiveListItem.StatusColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveListItem.StatusColumn] = value;
                }
            }
            
            public string CaseName {
                get {
                    try {
                        return ((string)(this[this.tableReceiveListItem.CaseNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveListItem.CaseNameColumn] = value;
                }
            }
            
            public string Notes {
                get {
                    try {
                        return ((string)(this[this.tableReceiveListItem.NotesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveListItem.NotesColumn] = value;
                }
            }
            
            public string MediaType {
                get {
                    try {
                        return ((string)(this[this.tableReceiveListItem.MediaTypeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableReceiveListItem.MediaTypeColumn] = value;
                }
            }
            
            public bool IsSerialNoNull() {
                return this.IsNull(this.tableReceiveListItem.SerialNoColumn);
            }
            
            public void SetSerialNoNull() {
                this[this.tableReceiveListItem.SerialNoColumn] = System.Convert.DBNull;
            }
            
            public bool IsStatusNull() {
                return this.IsNull(this.tableReceiveListItem.StatusColumn);
            }
            
            public void SetStatusNull() {
                this[this.tableReceiveListItem.StatusColumn] = System.Convert.DBNull;
            }
            
            public bool IsCaseNameNull() {
                return this.IsNull(this.tableReceiveListItem.CaseNameColumn);
            }
            
            public void SetCaseNameNull() {
                this[this.tableReceiveListItem.CaseNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsNotesNull() {
                return this.IsNull(this.tableReceiveListItem.NotesColumn);
            }
            
            public void SetNotesNull() {
                this[this.tableReceiveListItem.NotesColumn] = System.Convert.DBNull;
            }
            
            public bool IsMediaTypeNull() {
                return this.IsNull(this.tableReceiveListItem.MediaTypeColumn);
            }
            
            public void SetMediaTypeNull() {
                this[this.tableReceiveListItem.MediaTypeColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ReceiveListItemRowChangeEvent : EventArgs {
            
            private ReceiveListItemRow eventRow;
            
            private DataRowAction eventAction;
            
            public ReceiveListItemRowChangeEvent(ReceiveListItemRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ReceiveListItemRow Row {
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
