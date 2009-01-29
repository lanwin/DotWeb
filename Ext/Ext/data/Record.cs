using System;
using DotWeb.Core;

namespace Ext.data {
    /// <summary>
    ///     /**
    ///     Instances of this class encapsulate both Record <em>definition</em> information, and Record
    ///     <em>value</em> information for use in {@link Ext.data.Store} objects, or any code which needs
    ///     to access Records cached in an {@link Ext.data.Store} object.<br>
    ///     <p>
    ///     Constructors for this class are generated by passing an Array of field definition objects to {@link #create}.
    ///     Instances are usually only created by {@link Ext.data.Reader} implementations when processing unformatted data
    ///     objects.<br>
    ///     <p>
    ///     Record objects generated by this constructor inherit all the methods of Ext.data.Record listed below.
    /// </summary>
    /// <jssource>C:\home\src\external\ext-2.2\source\data\Record.js</jssource>
    [Native]
    public class Record  {

        /// <summary>
        ///     This constructor should not be used to create Record objects. Instead, use the constructor generated by
        ///     {@link #create}. The parameters are the same.
        ///     {@link Ext.data.Store} object which owns the Record to index its collection of Records. If
        ///     not specified an integer id is generated.
        /// </summary>
        /// <returns></returns>
        public Record() {}
        /// <summary>
        ///     This constructor should not be used to create Record objects. Instead, use the constructor generated by
        ///     {@link #create}. The parameters are the same.
        ///     {@link Ext.data.Store} object which owns the Record to index its collection of Records. If
        ///     not specified an integer id is generated.
        /// </summary>
        /// <param name="data">An object, the properties of which provide values for the new Record's fields.</param>
        /// <returns></returns>
        public Record(System.Array data) {}
        /// <summary>
        ///     This constructor should not be used to create Record objects. Instead, use the constructor generated by
        ///     {@link #create}. The parameters are the same.
        ///     {@link Ext.data.Store} object which owns the Record to index its collection of Records. If
        ///     not specified an integer id is generated.
        /// </summary>
        /// <param name="data">An object, the properties of which provide values for the new Record's fields.</param>
        /// <param name="id">(Optional) The id of the Record. This id should be unique, and is used by the</param>
        /// <returns></returns>
        public Record(System.Array data, object id) {}

        /// <summary>The reference to the prototype the every object of this type is constructed with</summary>
        public static Record prototype { get { return null; } set { } }

        /// <summary>The reference to the constructor function</summary>
        public static Delegate constructor { get { return null; } set { } }

        /// <summary>An object hash representing the data for this Record.</summary>
        public object data { get { return null; } set { } }

        /// <summary>The unique ID of the Record as specified at construction time.</summary>
        public object id { get { return null; } set { } }

        /// <summary>Readonly flag - true if this Record has been modified.</summary>
        public bool dirty { get { return false; } set { } }

        /// <summary>This object contains a key and value storing the original values of all modified fields or is null if no fields have been modified.</summary>
        public object modified { get { return null; } set { } }


        /// <summary>
        ///     Generate a constructor for a specific Record layout.
        ///     data types, and a mapping for an {@link Ext.data.Reader} to extract the field's value from a data object.
        ///     Each field definition object may contain the following properties: <ul>
        ///     <li><b>name</b> : String<div class="sub-desc">The name by which the field is referenced within the Record. This is referenced by,
        ///     for example, the <em>dataIndex</em> property in column definition objects passed to {@link Ext.grid.ColumnModel}</div></li>
        ///     <li><b>mapping</b> : String<div class="sub-desc">(Optional) A path specification for use by the {@link Ext.data.Reader} implementation
        ///     that is creating the Record to access the data value from the data object. If an {@link Ext.data.JsonReader}
        ///     is being used, then this is a string containing the javascript expression to reference the data relative to
        ///     the Record item's root. If an {@link Ext.data.XmlReader} is being used, this is an {@link Ext.DomQuery} path
        ///     to the data item relative to the Record element. If the mapping expression is the same as the field name,
        ///     this may be omitted.</div></li>
        ///     <li><b>type</b> : String<div class="sub-desc">(Optional) The data type for conversion to displayable value. Possible values are
        ///     <ul><li>auto (Default, implies no conversion)</li>
        ///     <li>string</li>
        ///     <li>int</li>
        ///     <li>float</li>
        ///     <li>boolean</li>
        ///     <li>date</li></ul></div></li>
        ///     <li><b>sortType</b> : Mixed<div class="sub-desc">(Optional) A member of {@link Ext.data.SortTypes}.</div></li>
        ///     <li><b>sortDir</b> : String<div class="sub-desc">(Optional) Initial direction to sort. "ASC" or "DESC"</div></li>
        ///     <li><b>convert</b> : Function<div class="sub-desc">(Optional) A function which converts the value provided
        ///     by the Reader into an object that will be stored in the Record. It is passed the
        ///     following parameters:<ul>
        ///     <li><b>v</b> : Mixed<div class="sub-desc">The data value as read by the Reader.</div></li>
        ///     <li><b>rec</b> : Mixed<div class="sub-desc">The data object containing the row as read by the Reader.
        ///     Depending on Reader type, this could be an Array, an object, or an XML element.</div></li>
        ///     </ul></div></li>
        ///     <li><b>dateFormat</b> : String<div class="sub-desc">(Optional) A format String for the Date.parseDate function.</div></li>
        ///     <li><b>defaultValue</b> : Mixed<div class="sub-desc">(Optional) The default value passed to the Reader when the field does
        ///     not exist in the data object (i.e. undefined). (defaults to "")</div></li>
        ///     </ul>
        ///     <br>usage:<br><pre><code>
        ///     var TopicRecord = Ext.data.Record.create([
        ///     {name: 'title', mapping: 'topic_title'},
        ///     {name: 'author', mapping: 'username'},
        ///     {name: 'totalPosts', mapping: 'topic_replies', type: 'int'},
        ///     {name: 'lastPost', mapping: 'post_time', type: 'date'},
        ///     {name: 'lastPoster', mapping: 'user2'},
        ///     {name: 'excerpt', mapping: 'post_text'}
        ///     ]);
        ///     var myNewRecord = new TopicRecord({
        ///     topic_title: 'Do my job please',
        ///     username: 'noobie',
        ///     topic_replies: 1,
        ///     post_time: new Date(),
        ///     user2: 'Animal',
        ///     post_text: 'No way dude!'
        ///     });
        ///     myStore.add(myNewRecord);
        ///     </code></pre>
        ///     <p>In the simplest case, if no properties other than <tt>name</tt> are required, a field definition
        ///     may consist of just a field name string.</p>
        ///     to the definition.
        /// </summary>
        /// <returns>function</returns>
        public static Delegate create() { return null; }

        /// <summary>
        ///     Generate a constructor for a specific Record layout.
        ///     data types, and a mapping for an {@link Ext.data.Reader} to extract the field's value from a data object.
        ///     Each field definition object may contain the following properties: <ul>
        ///     <li><b>name</b> : String<div class="sub-desc">The name by which the field is referenced within the Record. This is referenced by,
        ///     for example, the <em>dataIndex</em> property in column definition objects passed to {@link Ext.grid.ColumnModel}</div></li>
        ///     <li><b>mapping</b> : String<div class="sub-desc">(Optional) A path specification for use by the {@link Ext.data.Reader} implementation
        ///     that is creating the Record to access the data value from the data object. If an {@link Ext.data.JsonReader}
        ///     is being used, then this is a string containing the javascript expression to reference the data relative to
        ///     the Record item's root. If an {@link Ext.data.XmlReader} is being used, this is an {@link Ext.DomQuery} path
        ///     to the data item relative to the Record element. If the mapping expression is the same as the field name,
        ///     this may be omitted.</div></li>
        ///     <li><b>type</b> : String<div class="sub-desc">(Optional) The data type for conversion to displayable value. Possible values are
        ///     <ul><li>auto (Default, implies no conversion)</li>
        ///     <li>string</li>
        ///     <li>int</li>
        ///     <li>float</li>
        ///     <li>boolean</li>
        ///     <li>date</li></ul></div></li>
        ///     <li><b>sortType</b> : Mixed<div class="sub-desc">(Optional) A member of {@link Ext.data.SortTypes}.</div></li>
        ///     <li><b>sortDir</b> : String<div class="sub-desc">(Optional) Initial direction to sort. "ASC" or "DESC"</div></li>
        ///     <li><b>convert</b> : Function<div class="sub-desc">(Optional) A function which converts the value provided
        ///     by the Reader into an object that will be stored in the Record. It is passed the
        ///     following parameters:<ul>
        ///     <li><b>v</b> : Mixed<div class="sub-desc">The data value as read by the Reader.</div></li>
        ///     <li><b>rec</b> : Mixed<div class="sub-desc">The data object containing the row as read by the Reader.
        ///     Depending on Reader type, this could be an Array, an object, or an XML element.</div></li>
        ///     </ul></div></li>
        ///     <li><b>dateFormat</b> : String<div class="sub-desc">(Optional) A format String for the Date.parseDate function.</div></li>
        ///     <li><b>defaultValue</b> : Mixed<div class="sub-desc">(Optional) The default value passed to the Reader when the field does
        ///     not exist in the data object (i.e. undefined). (defaults to "")</div></li>
        ///     </ul>
        ///     <br>usage:<br><pre><code>
        ///     var TopicRecord = Ext.data.Record.create([
        ///     {name: 'title', mapping: 'topic_title'},
        ///     {name: 'author', mapping: 'username'},
        ///     {name: 'totalPosts', mapping: 'topic_replies', type: 'int'},
        ///     {name: 'lastPost', mapping: 'post_time', type: 'date'},
        ///     {name: 'lastPoster', mapping: 'user2'},
        ///     {name: 'excerpt', mapping: 'post_text'}
        ///     ]);
        ///     var myNewRecord = new TopicRecord({
        ///     topic_title: 'Do my job please',
        ///     username: 'noobie',
        ///     topic_replies: 1,
        ///     post_time: new Date(),
        ///     user2: 'Animal',
        ///     post_text: 'No way dude!'
        ///     });
        ///     myStore.add(myNewRecord);
        ///     </code></pre>
        ///     <p>In the simplest case, if no properties other than <tt>name</tt> are required, a field definition
        ///     may consist of just a field name string.</p>
        ///     to the definition.
        /// </summary>
        /// <param name="o">An Array of field definition objects which specify field names, and optionally,</param>
        /// <returns>function</returns>
        public static Delegate create(System.Array o) { return null; }

        /// <summary>Set the named field to the specified value.</summary>
        /// <returns></returns>
        public virtual void set() { return ; }

        /// <summary>Set the named field to the specified value.</summary>
        /// <param name="name">The name of the field to set.</param>
        /// <returns></returns>
        public virtual void set(System.String name) { return ; }

        /// <summary>Set the named field to the specified value.</summary>
        /// <param name="name">The name of the field to set.</param>
        /// <param name="value">The value to set the field to.</param>
        /// <returns></returns>
        public virtual void set(System.String name, object value) { return ; }

        /// <summary>Get the value of the named field.</summary>
        /// <returns>Object</returns>
        public virtual object get() { return null; }

        /// <summary>Get the value of the named field.</summary>
        /// <param name="name">The name of the field to get the value of.</param>
        /// <returns>Object</returns>
        public virtual object get(System.String name) { return null; }

        /// <summary>Begin an edit. While in edit mode, no events are relayed to the containing store.</summary>
        /// <returns></returns>
        public virtual void beginEdit() { return ; }

        /// <summary>Cancels all changes made in the current edit operation.</summary>
        /// <returns></returns>
        public virtual void cancelEdit() { return ; }

        /// <summary>End an edit. If any data was modified, the containing store is notified.</summary>
        /// <returns></returns>
        public virtual void endEdit() { return ; }

        /// <summary>
        ///     Usually called by the {@link Ext.data.Store} which owns the Record.
        ///     Rejects all changes made to the Record since either creation, or the last commit operation.
        ///     Modified fields are reverted to their original values.
        ///     <p>
        ///     Developers should subscribe to the {@link Ext.data.Store#update} event to have their code notified
        ///     of reject operations.
        /// </summary>
        /// <returns></returns>
        public virtual void reject() { return ; }

        /// <summary>
        ///     Usually called by the {@link Ext.data.Store} which owns the Record.
        ///     Rejects all changes made to the Record since either creation, or the last commit operation.
        ///     Modified fields are reverted to their original values.
        ///     <p>
        ///     Developers should subscribe to the {@link Ext.data.Store#update} event to have their code notified
        ///     of reject operations.
        /// </summary>
        /// <param name="silent">(optional) True to skip notification of the owning store of the change (defaults to false)</param>
        /// <returns></returns>
        public virtual void reject(bool silent) { return ; }

        /// <summary>
        ///     Usually called by the {@link Ext.data.Store} which owns the Record.
        ///     Commits all changes made to the Record since either creation, or the last commit operation.
        ///     <p>
        ///     Developers should subscribe to the {@link Ext.data.Store#update} event to have their code notified
        ///     of commit operations.
        /// </summary>
        /// <returns></returns>
        public virtual void commit() { return ; }

        /// <summary>
        ///     Usually called by the {@link Ext.data.Store} which owns the Record.
        ///     Commits all changes made to the Record since either creation, or the last commit operation.
        ///     <p>
        ///     Developers should subscribe to the {@link Ext.data.Store#update} event to have their code notified
        ///     of commit operations.
        /// </summary>
        /// <param name="silent">(optional) True to skip notification of the owning store of the change (defaults to false)</param>
        /// <returns></returns>
        public virtual void commit(bool silent) { return ; }

        /// <summary>Gets a hash of only the fields that have been modified since this Record was created or commited.</summary>
        /// <returns>Object</returns>
        public virtual object getChanges() { return null; }

        /// <summary>Creates a copy of this Record.</summary>
        /// <returns>Record</returns>
        public virtual Ext.data.Record copy() { return null; }

        /// <summary>Creates a copy of this Record.</summary>
        /// <param name="id">(optional) A new Record id if you don't want to use this Record's id</param>
        /// <returns>Record</returns>
        public virtual Ext.data.Record copy(System.String id) { return null; }

        /// <summary>Returns true if the field passed has been modified since the load or last commit.</summary>
        /// <returns>Boolean</returns>
        public virtual bool isModified() { return false; }

        /// <summary>Returns true if the field passed has been modified since the load or last commit.</summary>
        /// <param name="fieldName"></param>
        /// <returns>Boolean</returns>
        public virtual bool isModified(System.String fieldName) { return false; }



    }
    [Anonymous]
    public class RecordConfig {

    }


}
