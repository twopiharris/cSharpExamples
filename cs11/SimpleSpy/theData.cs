﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3328.4
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace SimpleSpy {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class theData : DataSet {
        
        private AgentsDataTable tableAgents;
        
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
                if ((ds.Tables["Agents"] != null)) {
                    this.Tables.Add(new AgentsDataTable(ds.Tables["Agents"]));
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
        public AgentsDataTable Agents {
            get {
                return this.tableAgents;
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
            if ((ds.Tables["Agents"] != null)) {
                this.Tables.Add(new AgentsDataTable(ds.Tables["Agents"]));
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
            this.tableAgents = ((AgentsDataTable)(this.Tables["Agents"]));
            if ((this.tableAgents != null)) {
                this.tableAgents.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "theData";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/theData.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableAgents = new AgentsDataTable();
            this.Tables.Add(this.tableAgents);
        }
        
        private bool ShouldSerializeAgents() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void AgentsRowChangeEventHandler(object sender, AgentsRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class AgentsDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAgentID;
            
            private DataColumn columnCodeName;
            
            private DataColumn columnSpecialty;
            
            private DataColumn columnAssignment;
            
            internal AgentsDataTable() : 
                    base("Agents") {
                this.InitClass();
            }
            
            internal AgentsDataTable(DataTable table) : 
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
            
            internal DataColumn AgentIDColumn {
                get {
                    return this.columnAgentID;
                }
            }
            
            internal DataColumn CodeNameColumn {
                get {
                    return this.columnCodeName;
                }
            }
            
            internal DataColumn SpecialtyColumn {
                get {
                    return this.columnSpecialty;
                }
            }
            
            internal DataColumn AssignmentColumn {
                get {
                    return this.columnAssignment;
                }
            }
            
            public AgentsRow this[int index] {
                get {
                    return ((AgentsRow)(this.Rows[index]));
                }
            }
            
            public event AgentsRowChangeEventHandler AgentsRowChanged;
            
            public event AgentsRowChangeEventHandler AgentsRowChanging;
            
            public event AgentsRowChangeEventHandler AgentsRowDeleted;
            
            public event AgentsRowChangeEventHandler AgentsRowDeleting;
            
            public void AddAgentsRow(AgentsRow row) {
                this.Rows.Add(row);
            }
            
            public AgentsRow AddAgentsRow(int AgentID, string CodeName, string Specialty, string Assignment) {
                AgentsRow rowAgentsRow = ((AgentsRow)(this.NewRow()));
                rowAgentsRow.ItemArray = new object[] {
                        AgentID,
                        CodeName,
                        Specialty,
                        Assignment};
                this.Rows.Add(rowAgentsRow);
                return rowAgentsRow;
            }
            
            public AgentsRow FindByAgentID(int AgentID) {
                return ((AgentsRow)(this.Rows.Find(new object[] {
                            AgentID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                AgentsDataTable cln = ((AgentsDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            internal void InitVars() {
                this.columnAgentID = this.Columns["AgentID"];
                this.columnCodeName = this.Columns["CodeName"];
                this.columnSpecialty = this.Columns["Specialty"];
                this.columnAssignment = this.Columns["Assignment"];
            }
            
            private void InitClass() {
                this.columnAgentID = new DataColumn("AgentID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAgentID);
                this.columnCodeName = new DataColumn("CodeName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCodeName);
                this.columnSpecialty = new DataColumn("Specialty", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSpecialty);
                this.columnAssignment = new DataColumn("Assignment", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAssignment);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnAgentID}, true));
                this.columnAgentID.AllowDBNull = false;
                this.columnAgentID.Unique = true;
            }
            
            public AgentsRow NewAgentsRow() {
                return ((AgentsRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new AgentsRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(AgentsRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.AgentsRowChanged != null)) {
                    this.AgentsRowChanged(this, new AgentsRowChangeEvent(((AgentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.AgentsRowChanging != null)) {
                    this.AgentsRowChanging(this, new AgentsRowChangeEvent(((AgentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.AgentsRowDeleted != null)) {
                    this.AgentsRowDeleted(this, new AgentsRowChangeEvent(((AgentsRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.AgentsRowDeleting != null)) {
                    this.AgentsRowDeleting(this, new AgentsRowChangeEvent(((AgentsRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveAgentsRow(AgentsRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class AgentsRow : DataRow {
            
            private AgentsDataTable tableAgents;
            
            internal AgentsRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableAgents = ((AgentsDataTable)(this.Table));
            }
            
            public int AgentID {
                get {
                    return ((int)(this[this.tableAgents.AgentIDColumn]));
                }
                set {
                    this[this.tableAgents.AgentIDColumn] = value;
                }
            }
            
            public string CodeName {
                get {
                    try {
                        return ((string)(this[this.tableAgents.CodeNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableAgents.CodeNameColumn] = value;
                }
            }
            
            public string Specialty {
                get {
                    try {
                        return ((string)(this[this.tableAgents.SpecialtyColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableAgents.SpecialtyColumn] = value;
                }
            }
            
            public string Assignment {
                get {
                    try {
                        return ((string)(this[this.tableAgents.AssignmentColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableAgents.AssignmentColumn] = value;
                }
            }
            
            public bool IsCodeNameNull() {
                return this.IsNull(this.tableAgents.CodeNameColumn);
            }
            
            public void SetCodeNameNull() {
                this[this.tableAgents.CodeNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsSpecialtyNull() {
                return this.IsNull(this.tableAgents.SpecialtyColumn);
            }
            
            public void SetSpecialtyNull() {
                this[this.tableAgents.SpecialtyColumn] = System.Convert.DBNull;
            }
            
            public bool IsAssignmentNull() {
                return this.IsNull(this.tableAgents.AssignmentColumn);
            }
            
            public void SetAssignmentNull() {
                this[this.tableAgents.AssignmentColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class AgentsRowChangeEvent : EventArgs {
            
            private AgentsRow eventRow;
            
            private DataRowAction eventAction;
            
            public AgentsRowChangeEvent(AgentsRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public AgentsRow Row {
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
