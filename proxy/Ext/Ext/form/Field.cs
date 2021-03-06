using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form {
	/// <summary>
	///     /**
	///     Base class for form fields that provides default event handling, sizing, value handling and other functionality.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\form\Field.js</jssource>
	public class Field : Ext.BoxComponent {

		/// <summary>Creates a new Field</summary>
		/// <returns></returns>
		public extern Field();
		/// <summary>Creates a new Field</summary>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern Field(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Field(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Field(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Field prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.BoxComponent superclass { get; set; }

		/// <summary>The label text to display next to this field (defaults to '')</summary>
		public extern string fieldLabel { get; set; }

		/// <summary>A CSS style specification to apply directly to this field's label (defaults to thecontainer's labelStyle value if set, or ''). For example, <code>labelStyle: 'font-weight:bold;'</code>.</summary>
		public extern string labelStyle { get; set; }

		/// <summary>
		///     The standard separator to display after the text of each form label (defaultsto the value of {@link Ext.layout.FormLayout#labelSeparator}, which is a colon ':' by default).  To display
		///     no separator for this field's label specify empty string ''.
		/// </summary>
		public extern string labelSeparator { get; set; }

		/// <summary>True to completely hide the label element (defaults to false)</summary>
		public extern bool hideLabel { get; set; }

		/// <summary>The CSS class used to provide field clearing (defaults to 'x-form-clear-left')</summary>
		public extern string clearCls { get; set; }

		/// <summary>
		///     An additional CSS class to apply to the wrapper's form item element of this field (defaultsto the container's itemCls value if set, or '').  Since it is applied to the item wrapper, it allows you to write
		///     standard CSS rules that can apply to the field, the label (if specified) or any other element within the markup for
		///     the field. NOTE: this will not have any effect on fields that are not part of a form. Example use:
		///     <pre><code>
		///     // Apply a style to the field's label:
		///     &lt;style>
		///     .required .x-form-item-label {font-weight:bold;color:red;}
		///     &lt;/style>
		///     new Ext.FormPanel({
		///     height: 100,
		///     renderTo: document.body,
		///     items: [{
		///     xtype: 'textfield',
		///     fieldLabel: 'Name',
		///     itemCls: 'required' //this label will be styled
		///     },{
		///     xtype: 'textfield',
		///     fieldLabel: 'Favorite Color'
		///     }]
		///     });
		///     </code></pre>
		/// </summary>
		public extern string itemCls { get; set; }

		/// <summary>
		///     The type attribute for input fields -- e.g. radio, text, password, file (defaultsto "text"). The types "file" and "password" must be used to render those field types currently -- there are
		///     no separate Ext components for those. Note that if you use <tt>inputType:'file'</tt>, {@link #emptyText}
		///     is not supported and should be avoided.
		/// </summary>
		public extern string inputType { get; set; }

		/// <summary>The tabIndex for this field. Note this only applies to fields that are rendered,not those which are built via applyTo (defaults to undefined).</summary>
		public extern double tabIndex { get; set; }

		/// <summary>A value to initialize this field with (defaults to undefined).</summary>
		public extern object value { get; set; }

		/// <summary>The field's HTML name attribute (defaults to "").</summary>
		public extern string name { get; set; }

		/// <summary>A custom CSS class to apply to the field's underlying element (defaults to "").</summary>
		public extern string cls { get; set; }

		/// <summary>The CSS class to use when marking a field invalid (defaults to "x-form-invalid")</summary>
		public extern string invalidClass { get; set; }

		/// <summary>The error text to use when marking a field invalid and no message is provided(defaults to "The value in this field is invalid")</summary>
		public extern string invalidText { get; set; }

		/// <summary>The CSS class to use when the field receives focus (defaults to "x-form-focus")</summary>
		public extern string focusClass { get; set; }

		/// <summary>The event that should initiate field validation. Set to false to disableautomatic validation (defaults to "keyup").</summary>
		public extern object validationEvent { get; set; }

		/// <summary>Whether the field should validate when it loses focus (defaults to true).</summary>
		public extern bool validateOnBlur { get; set; }

		/// <summary>The length of time in milliseconds after user input begins until validationis initiated (defaults to 250)</summary>
		public extern double validationDelay { get; set; }

		/// <summary>A DomHelper element spec, or true for a default element spec (defaults to{tag: "input", type: "text", size: "20", autocomplete: "off"})</summary>
		public extern object autoCreate { get; set; }

		/// <summary>The default CSS class for the field (defaults to "x-form-field")</summary>
		public extern string fieldClass { get; set; }

		/// <summary>
		///     The location where error text should display.  Should be one of the following values(defaults to 'qtip'):
		///     <pre>
		///     Value         Description
		///     -----------   ----------------------------------------------------------------------
		///     qtip          Display a quick tip when the user hovers over the field
		///     title         Display a default browser title attribute popup
		///     under         Add a block div beneath the field containing the error text
		///     side          Add an error icon to the right of the field with a popup on hover
		///     [element id]  Add the error text directly to the innerHTML of the specified element
		///     </pre>
		/// </summary>
		public extern string msgTarget { get; set; }

		/// <summary><b>Experimental</b> The effect used when displaying a validation message under the field(defaults to 'normal').</summary>
		public extern string msgFx { get; set; }

		/// <summary>True to mark the field as readOnly in HTML (defaults to false) -- Note: this onlysets the element's readOnly DOM attribute.</summary>
		public extern bool readOnly { get; set; }

		/// <summary>True to disable the field (defaults to false).</summary>
		public extern bool disabled { get; set; }


		/// <summary>Returns the name attribute of the field if available</summary>
		/// <returns>String</returns>
		public extern virtual void getName();

		/// <summary>Returns true if this field has been changed since it was originally loaded and is not disabled.</summary>
		/// <returns></returns>
		public extern virtual void isDirty();

		/// <summary>Resets the current field value to the originally loaded value and clears any validation messages</summary>
		/// <returns></returns>
		public extern virtual void reset();

		/// <summary>Returns whether or not the field value is currently valid</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isValid();

		/// <summary>Returns whether or not the field value is currently valid</summary>
		/// <param name="preventMark">True to disable marking the field invalid</param>
		/// <returns>Boolean</returns>
		public extern virtual void isValid(bool preventMark);

		/// <summary>Validates the field value</summary>
		/// <returns>Boolean</returns>
		public extern virtual void validate();

		/// <summary>
		///     Mark this field as invalid, using {@link #msgTarget} to determine how to display the error and
		///     applying {@link #invalidClass} to the field's element.
		/// </summary>
		/// <returns></returns>
		public extern virtual void markInvalid();

		/// <summary>
		///     Mark this field as invalid, using {@link #msgTarget} to determine how to display the error and
		///     applying {@link #invalidClass} to the field's element.
		/// </summary>
		/// <param name="msg">(optional) The validation message (defaults to {@link #invalidText})</param>
		/// <returns></returns>
		public extern virtual void markInvalid(string msg);

		/// <summary>Clear any invalid styles/messages for this field</summary>
		/// <returns></returns>
		public extern virtual void clearInvalid();

		/// <summary>Returns the raw data value which may or may not be a valid, defined value.  To return a normalized value see {@link #getValue}.</summary>
		/// <returns>Mixed</returns>
		public extern virtual void getRawValue();

		/// <summary>Returns the normalized data value (undefined or emptyText will be returned as '').  To return the raw value see {@link #getRawValue}.</summary>
		/// <returns>Mixed</returns>
		public extern virtual void getValue();

		/// <summary>Sets the underlying DOM field's value directly, bypassing validation.  To set the value with validation see {@link #setValue}.</summary>
		/// <returns>Mixed</returns>
		public extern virtual void setRawValue();

		/// <summary>Sets the underlying DOM field's value directly, bypassing validation.  To set the value with validation see {@link #setValue}.</summary>
		/// <param name="value">The value to set</param>
		/// <returns>Mixed</returns>
		public extern virtual void setRawValue(object value);

		/// <summary>Sets a data value into the field and validates it.  To set the value directly without validation see {@link #setRawValue}.</summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>Sets a data value into the field and validates it.  To set the value directly without validation see {@link #setRawValue}.</summary>
		/// <param name="value">The value to set</param>
		/// <returns></returns>
		public extern virtual void setValue(object value);



	}

	[JsAnonymous]
	public class FieldConfig : System.DotWeb.JsDynamic {
		/// <summary> The label text to display next to this field (defaults to '')</summary>
		public string fieldLabel { get { return (string)this["fieldLabel"]; } set { this["fieldLabel"] = value; } }

		/// <summary> A CSS style specification to apply directly to this field's label (defaults to the container's labelStyle value if set, or ''). For example, <code>labelStyle: 'font-weight:bold;'</code>.</summary>
		public string labelStyle { get { return (string)this["labelStyle"]; } set { this["labelStyle"] = value; } }

		/// <summary> The standard separator to display after the text of each form label (defaults to the value of {@link Ext.layout.FormLayout#labelSeparator}, which is a colon ':' by default).  To display no separator for this field's label specify empty string ''.</summary>
		public string labelSeparator { get { return (string)this["labelSeparator"]; } set { this["labelSeparator"] = value; } }

		/// <summary> True to completely hide the label element (defaults to false)</summary>
		public bool hideLabel { get { return (bool)this["hideLabel"]; } set { this["hideLabel"] = value; } }

		/// <summary> The CSS class used to provide field clearing (defaults to 'x-form-clear-left')</summary>
		public string clearCls { get { return (string)this["clearCls"]; } set { this["clearCls"] = value; } }

		/// <summary> An additional CSS class to apply to the wrapper's form item element of this field (defaults to the container's itemCls value if set, or '').  Since it is applied to the item wrapper, it allows you to write standard CSS rules that can apply to the field, the label (if specified) or any other element within the markup for the field. NOTE: this will not have any effect on fields that are not part of a form. Example use: <pre><code> // Apply a style to the field's label: &lt;style> .required .x-form-item-label {font-weight:bold;color:red;} &lt;/style> new Ext.FormPanel({ height: 100, renderTo: document.body, items: [{ xtype: 'textfield', fieldLabel: 'Name', itemCls: 'required' //this label will be styled },{ xtype: 'textfield', fieldLabel: 'Favorite Color' }] }); </code></pre></summary>
		public string itemCls { get { return (string)this["itemCls"]; } set { this["itemCls"] = value; } }

		/// <summary> The type attribute for input fields -- e.g. radio, text, password, file (defaults to "text"). The types "file" and "password" must be used to render those field types currently -- there are no separate Ext components for those. Note that if you use <tt>inputType:'file'</tt>, {@link #emptyText} is not supported and should be avoided.</summary>
		public string inputType { get { return (string)this["inputType"]; } set { this["inputType"] = value; } }

		/// <summary> The tabIndex for this field. Note this only applies to fields that are rendered, not those which are built via applyTo (defaults to undefined).</summary>
		public double tabIndex { get { return (double)this["tabIndex"]; } set { this["tabIndex"] = value; } }

		/// <summary> A value to initialize this field with (defaults to undefined).</summary>
		public object value { get { return (object)this["value"]; } set { this["value"] = value; } }

		/// <summary> The field's HTML name attribute (defaults to "").</summary>
		public string name { get { return (string)this["name"]; } set { this["name"] = value; } }

		/// <summary> A custom CSS class to apply to the field's underlying element (defaults to "").</summary>
		public string cls { get { return (string)this["cls"]; } set { this["cls"] = value; } }

		/// <summary> The CSS class to use when marking a field invalid (defaults to "x-form-invalid")</summary>
		public string invalidClass { get { return (string)this["invalidClass"]; } set { this["invalidClass"] = value; } }

		/// <summary> The error text to use when marking a field invalid and no message is provided (defaults to "The value in this field is invalid")</summary>
		public string invalidText { get { return (string)this["invalidText"]; } set { this["invalidText"] = value; } }

		/// <summary> The CSS class to use when the field receives focus (defaults to "x-form-focus")</summary>
		public string focusClass { get { return (string)this["focusClass"]; } set { this["focusClass"] = value; } }

		/// <summary>{String/Boolean} The event that should initiate field validation. Set to false to disable automatic validation (defaults to "keyup").</summary>
		public object validationEvent { get { return (object)this["validationEvent"]; } set { this["validationEvent"] = value; } }

		/// <summary> Whether the field should validate when it loses focus (defaults to true).</summary>
		public bool validateOnBlur { get { return (bool)this["validateOnBlur"]; } set { this["validateOnBlur"] = value; } }

		/// <summary> The length of time in milliseconds after user input begins until validation is initiated (defaults to 250)</summary>
		public double validationDelay { get { return (double)this["validationDelay"]; } set { this["validationDelay"] = value; } }

		/// <summary>{String/Object} A DomHelper element spec, or true for a default element spec (defaults to {tag: "input", type: "text", size: "20", autocomplete: "off"})</summary>
		public object autoCreate { get { return (object)this["autoCreate"]; } set { this["autoCreate"] = value; } }

		/// <summary> The default CSS class for the field (defaults to "x-form-field")</summary>
		public string fieldClass { get { return (string)this["fieldClass"]; } set { this["fieldClass"] = value; } }

		/// <summary> The location where error text should display.  Should be one of the following values (defaults to 'qtip'): <pre> Value         Description -----------   ---------------------------------------------------------------------- qtip          Display a quick tip when the user hovers over the field title         Display a default browser title attribute popup under         Add a block div beneath the field containing the error text side          Add an error icon to the right of the field with a popup on hover [element id]  Add the error text directly to the innerHTML of the specified element </pre></summary>
		public string msgTarget { get { return (string)this["msgTarget"]; } set { this["msgTarget"] = value; } }

		/// <summary> <b>Experimental</b> The effect used when displaying a validation message under the field (defaults to 'normal').</summary>
		public string msgFx { get { return (string)this["msgFx"]; } set { this["msgFx"] = value; } }

		/// <summary> True to mark the field as readOnly in HTML (defaults to false) -- Note: this only sets the element's readOnly DOM attribute.</summary>
		public bool readOnly { get { return (bool)this["readOnly"]; } set { this["readOnly"] = value; } }

		/// <summary> True to disable the field (defaults to false).</summary>
		public bool disabled { get { return (bool)this["disabled"]; } set { this["disabled"] = value; } }

		/// <summary>  The local x (left) coordinate for this component if contained within a positioning container.</summary>
		public double x { get { return (double)this["x"]; } set { this["x"] = value; } }

		/// <summary>  The local y (top) coordinate for this component if contained within a positioning container.</summary>
		public double y { get { return (double)this["y"]; } set { this["y"] = value; } }

		/// <summary>  The page level x coordinate for this component if contained within a positioning container.</summary>
		public double pageX { get { return (double)this["pageX"]; } set { this["pageX"] = value; } }

		/// <summary>  The page level y coordinate for this component if contained within a positioning container.</summary>
		public double pageY { get { return (double)this["pageY"]; } set { this["pageY"] = value; } }

		/// <summary>  The height of this component in pixels (defaults to auto).</summary>
		public double height { get { return (double)this["height"]; } set { this["height"] = value; } }

		/// <summary>  The width of this component in pixels (defaults to auto).</summary>
		public double width { get { return (double)this["width"]; } set { this["width"] = value; } }

		/// <summary>  True to use height:'auto', false to use fixed height. Note: although many components inherit this config option, not all will function as expected with a height of 'auto'. (defaults to false).</summary>
		public bool autoHeight { get { return (bool)this["autoHeight"]; } set { this["autoHeight"] = value; } }

		/// <summary>  True to use width:'auto', false to use fixed width. Note: although many components inherit this config option, not all will function as expected with a width of 'auto'. (defaults to false).</summary>
		public bool autoWidth { get { return (bool)this["autoWidth"]; } set { this["autoWidth"] = value; } }

		/// <summary> 
		///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
		///     The predefined xtypes are listed at the top of this document.
		///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
		/// </summary>
		public string xtype { get { return (string)this["xtype"]; } set { this["xtype"] = value; } }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id).</summary>
		public string id { get { return (string)this["id"]; } set { this["id"] = value; } }

		/// <summary>{String/Object}  A tag name or DomHelper spec to create an element with. This is intended to create shorthand utility components inline via JSON. It should not be used for higher level components which already create their own elements. Example usage: <pre><code> {xtype:'box', autoEl: 'div', cls:'my-class'} {xtype:'box', autoEl: {tag:'blockquote', html:'autoEl is cool!'}} // with DomHelper </code></pre></summary>
		public object autoEl { get { return (object)this["autoEl"]; } set { this["autoEl"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public string overCls { get { return (string)this["overCls"]; } set { this["overCls"] = value; } }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public string style { get { return (string)this["style"]; } set { this["style"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public string ctCls { get { return (string)this["ctCls"]; } set { this["ctCls"] = value; } }

		/// <summary>  Render this component hidden (default is false).</summary>
		public bool hidden { get { return (bool)this["hidden"]; } set { this["hidden"] = value; } }

		/// <summary>{Object/Array}  An object or array of objects that will provide custom functionality for this component.  The only requirement for a valid plugin is that it contain an init method that accepts a reference of type Ext.Component. When a component is created, if any plugins are available, the component will call the init method on each plugin, passing a reference to itself.  Each plugin can then call methods or respond to events on the component as needed to provide its functionality.</summary>
		public object plugins { get { return (object)this["plugins"]; } set { this["plugins"] = value; } }

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some structural markup for this component.  When applyTo is used, constituent parts of the component can also be specified by id or CSS class name within the main element, and the component being created may attempt to create its subcomponents from that markup if applicable. Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the component's container.</summary>
		public object applyTo { get { return (object)this["applyTo"]; } set { this["applyTo"] = value; } }

		/// <summary>  The id of the node, a DOM node or an existing Element that will be the container to render this component into. Using this config, a call to render() is not required.</summary>
		public object renderTo { get { return (object)this["renderTo"]; } set { this["renderTo"] = value; } }

		/// <summary>  A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link staterestore}, {@link beforestatesave} and {@link statesave} events</p></summary>
		public bool stateful { get { return (bool)this["stateful"]; } set { this["stateful"] = value; } }

		/// <summary>  The unique id for this component to use for state management purposes (defaults to the component id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
		public string stateId { get { return (string)this["stateId"]; } set { this["stateId"] = value; } }

		/// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
		public string disabledClass { get { return (string)this["disabledClass"]; } set { this["disabledClass"] = value; } }

		/// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
		public bool allowDomMove { get { return (bool)this["allowDomMove"]; } set { this["allowDomMove"] = value; } }

		/// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
		public bool autoShow { get { return (bool)this["autoShow"]; } set { this["autoShow"] = value; } }

		/// <summary>  How this component should hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</summary>
		public string hideMode { get { return (string)this["hideMode"]; } set { this["hideMode"] = value; } }

		/// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
		public bool hideParent { get { return (bool)this["hideParent"]; } set { this["hideParent"] = value; } }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return (object)this["listeners"]; } set { this["listeners"] = value; } }

	}

    public class FieldEvents {
        /// <summary>Fires when this field receives input focus.
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string focus { get { return "focus"; } }
        /// <summary>Fires when this field loses input focus.
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string blur { get { return "blur"; } }
        /// <summary>
        ///     Fires when any key related to navigation (arrows, tab, enter, esc, etc.) is pressed.  You can check
        ///     {@link Ext.EventObject#getKey} to determine which key was pressed.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string specialkey { get { return "specialkey"; } }
        /// <summary>Fires just before the field blurs if the field value has changed.
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis, {Mixed} newValue, {Mixed} oldValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>newValue</b></term><description>The new value</description></item>
        /// <item><term><b>oldValue</b></term><description>The original value</description></item>
        /// </list>
        /// </summary>
        public static string change { get { return "change"; } }
        /// <summary>Fires after the field has been marked as invalid.
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis, {String} msg)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>msg</b></term><description>The validation message</description></item>
        /// </list>
        /// </summary>
        public static string invalid { get { return "invalid"; } }
        /// <summary>Fires after the field has been validated with no errors.
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string valid { get { return "valid"; } }
    }

    public delegate void FieldFocusDelegate(Ext.form.Field objthis);
    public delegate void FieldBlurDelegate(Ext.form.Field objthis);
    public delegate void FieldSpecialkeyDelegate(Ext.form.Field objthis, Ext.EventObject e);
    public delegate void FieldChangeDelegate(Ext.form.Field objthis, object newValue, object oldValue);
    public delegate void FieldInvalidDelegate(Ext.form.Field objthis, string msg);
    public delegate void FieldValidDelegate(Ext.form.Field objthis);
}
