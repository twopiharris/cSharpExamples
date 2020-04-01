﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3328.4
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Access_Xml {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class theData : DataSet {
        
        private ContactsDataTable tableContacts;
        
        public theData() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected theData(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Contacts"] != null)) {
                    this.Tables.Add(new ContactsDataTable(ds.Tables["Contacts"]));
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
        public ContactsDataTable Contacts {
            get {
                return this.tableContacts;
            }
        }
        
        public override DataSet Clone() {
            theData cln = ((theData)(base.Clone()));
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
            if ((ds.Tables["Contacts"] != null)) {
                this.Tables.Add(new ContactsDataTable(ds.Tables["Contacts"]));
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
            this.tableContacts = ((ContactsDataTable)(this.Tables["Contacts"]));
            if ((this.tableContacts != null)) {
                this.tableContacts.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "theData";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/theData.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableContacts = new ContactsDataTable();
            this.Tables.Add(this.tableContacts);
        }
        
        private bool ShouldSerializeContacts() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ContactsRowChangeEventHandler(object sender, ContactsRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ContactsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnName;
            
            private DataColumn columnAddress;
            
            private DataColumn columnPhone;
            
            private DataColumn columnid;
            
            internal ContactsDataTable() : 
                    base("Contacts") {
                this.InitClass();
            }
            
            internal ContactsDataTable(DataTable table) : 
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
            
            internal DataColumn NameColumn {
                get {
                    return this.columnName;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn PhoneColumn {
                get {
                    return this.columnPhone;
                }
            }
            
            internal DataColumn idColumn {
                get {
                    return this.columnid;
                }
            }
            
            public ContactsRow this[int index] {
                get {
                    return ((ContactsRow)(this.Rows[index]));
                }
            }
            
            public event ContactsRowChangeEventHandler ContactsRowChanged;
            
            public event ContactsRowChangeEventHandler ContactsRowChanging;
            
            public event ContactsRowChangeEventHandler ContactsRowDeleted;
            
            public event ContactsRowChangeEventHandler ContactsRowDeleting;
            
            public void AddContactsRow(ContactsRow row) {
                this.Rows.Add(row);
            }
            
            public ContactsRow AddContactsRow(string Name, string Address, string Phone) {
                ContactsRow rowContactsRow = ((ContactsRow)(this.NewRow()));
                rowContactsRow.ItemArray = new object[] {
                        Name,
                        Address,
                        Phone,
                        null};
                this.Rows.Add(rowContactsRow);
                return rowContactsRow;
            }
            
            public ContactsRow FindByid(int id) {
                return ((ContactsRow)(this.Rows.Find(new object[] {
                            id})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ContactsDataTable cln = ((ContactsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            internal void InitVars() {
                this.columnName = this.Columns["Name"];
                this.columnAddress = this.Columns["Address"];
                this.columnPhone = this.Columns["Phone"];
                this.columnid = this.Columns["id"];
            }
            
            private void InitClass() {
                this.columnName = new DataColumn("Name", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnName);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnPhone = new DataColumn("Phone", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPhone);
                this.columnid = new DataColumn("id", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnid);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnid}, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
            }
            
            public ContactsRow NewContactsRow() {
                return ((ContactsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ContactsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ContactsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ContactsRowChanged != null)) {
                    this.ContactsRowChanged(this, new ContactsRowChangeEvent(((ContactsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ContactsRowChanging != null)) {
                    this.ContactsRowChanging(this, new ContactsRowChangeEvent(((ContactsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ContactsRowDeleted != null)) {
                    this.ContactsRowDeleted(this, new ContactsRowChangeEvent(((ContactsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ContactsRowDeleting != null)) {
                    this.ContactsRowDeleting(this, new ContactsRowChangeEvent(((ContactsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveContactsRow(ContactsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ContactsRow : DataRow {
            
            private ContactsDataTable tableContacts;
            
            internal ContactsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableContacts = ((ContactsDataTable)(this.Table));
            }
            
            public string Name {
                get {
                    try {
                        return ((string)(this[this.tableContacts.NameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableContacts.NameColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableContacts.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableContacts.AddressColumn] = value;
                }
            }
            
            public string Phone {
                get {
                    try {
                        return ((string)(this[this.tableContacts.PhoneColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableContacts.PhoneColumn] = value;
                }
            }
            
            public int id {
                get {
                    return ((int)(this[this.tableContacts.idColumn]));
                }
                set {
                    this[this.tableContacts.idColumn] = value;
                }
            }
            
            public bool IsNameNull() {
                return this.IsNull(this.tableContacts.NameColumn);
            }
            
            public void SetNameNull() {
                this[this.tableContacts.NameColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableContacts.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableContacts.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsPhoneNull() {
                return this.IsNull(this.tableContacts.PhoneColumn);
            }
            
            public void SetPhoneNull() {
                this[this.tableContacts.PhoneColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ContactsRowChangeEvent : EventArgs {
            
            private ContactsRow eventRow;
            
            private DataRowAction eventAction;
            
            public ContactsRowChangeEvent(ContactsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ContactsRow Row {
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
