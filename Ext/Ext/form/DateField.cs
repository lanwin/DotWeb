using System;
using DotWeb.Core;

namespace Ext.form {
    /// <summary>
    ///     /**
    ///     Provides a date input field with a {@link Ext.DatePicker} dropdown and automatic date validation.
    /// </summary>
    /// <jssource>C:\home\src\external\ext-2.2\source\widgets\form\DateField.js</jssource>
    [Native]
    public class DateField : Ext.form.TriggerField {

        /// <summary>Create a new DateField</summary>
        /// <returns></returns>
        public DateField() {}
        /// <summary>Create a new DateField</summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public DateField(object config) {}
        /// <summary></summary>
        /// <param name="config">The configuration options.</param>
        /// <returns></returns>
        public DateField(Ext.Element config) {}
        /// <summary></summary>
        /// <param name="config">The configuration options.</param>
        /// <returns></returns>
        public DateField(System.String config) {}

        /// <summary>The reference to the prototype the every object of this type is constructed with</summary>
        public static DateField prototype { get { return null; } set { } }

        /// <summary>The reference to the constructor function</summary>
        public static Delegate constructor { get { return null; } set { } }

        /// <summary>The reference to the class that this class inherits from</summary>
        public static Ext.form.TriggerField superclass { get { return null; } set { } }

        /// <summary>
        ///     The default date format string which can be overriden for localization support.  The format must be
        ///     valid according to {@link Date#parseDate} (defaults to 'm/d/Y').
        /// </summary>
        public System.String format { get { return null; } set { } }

        /// <summary>
        ///     Multiple date formats separated by "|" to try when parsing a user input value and it doesn't match the defined
        ///     format (defaults to 'm/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d').
        /// </summary>
        public System.String altFormats { get { return null; } set { } }

        /// <summary>The tooltip to display when the date falls on a disabled day (defaults to 'Disabled')</summary>
        public System.String disabledDaysText { get { return null; } set { } }

        /// <summary>The tooltip text to display when the date falls on a disabled date (defaults to 'Disabled')</summary>
        public System.String disabledDatesText { get { return null; } set { } }

        /// <summary>
        ///     The error text to display when the date in the cell is before minValue (defaults to
        ///     'The date in this field must be after {minValue}').
        /// </summary>
        public System.String minText { get { return null; } set { } }

        /// <summary>
        ///     The error text to display when the date in the cell is after maxValue (defaults to
        ///     'The date in this field must be before {maxValue}').
        /// </summary>
        public System.String maxText { get { return null; } set { } }

        /// <summary>
        ///     The error text to display when the date in the field is invalid (defaults to
        ///     '{value} is not a valid date - it must be in the format {format}').
        /// </summary>
        public System.String invalidText { get { return null; } set { } }

        /// <summary>
        ///     An additional CSS class used to style the trigger button.  The trigger will always get the
        ///     class 'x-form-trigger' and triggerClass will be <b>appended</b> if specified (defaults to 'x-form-date-trigger'
        ///     which displays a calendar icon).
        /// </summary>
        public System.String triggerClass { get { return null; } set { } }

        /// <summary>
        ///     False to hide the footer area of the DatePicker containing the Today button and disable the keyboard
        ///     handler for spacebar that selects the current date (defaults to true).
        /// </summary>
        public bool showToday { get { return false; } set { } }

        /// <summary>
        ///     The minimum allowed date. Can be either a Javascript date object or a string date in a
        ///     valid format (defaults to null).
        /// </summary>
        public object minValue { get { return null; } set { } }

        /// <summary>
        ///     The maximum allowed date. Can be either a Javascript date object or a string date in a
        ///     valid format (defaults to null).
        /// </summary>
        public object maxValue { get { return null; } set { } }

        /// <summary>An array of days to disable, 0 based. For example, [0, 6] disables Sunday and Saturday (defaults to null).</summary>
        public System.Array disabledDays { get { return null; } set { } }

        /// <summary>
        ///     An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular
        ///     expression so they are very powerful. Some examples:
        ///     <ul>
        ///     <li>["03/08/2003", "09/16/2003"] would disable those exact dates</li>
        ///     <li>["03/08", "09/16"] would disable those days for every year</li>
        ///     <li>["^03/08"] would only match the beginning (useful if you are using short years)</li>
        ///     <li>["03/../2006"] would disable every day in March 2006</li>
        ///     <li>["^03"] would disable every day in every March</li>
        ///     </ul>
        ///     Note that the format of the dates included in the array should exactly match the {@link #format} config.
        ///     In order to support regular expressions, if you are using a date format that has "." in it, you will have to
        ///     escape the dot when restricting dates. For example: ["03\\.08\\.03"].
        /// </summary>
        public System.Array disabledDates { get { return null; } set { } }

        /// <summary>
        ///     A DomHelper element spec, or true for a default element spec (defaults to
        ///     {tag: "input", type: "text", size: "10", autocomplete: "off"})
        /// </summary>
        public object autoCreate { get { return null; } set { } }


        /// <summary>
        ///     Replaces any existing disabled dates with new values and refreshes the DatePicker.
        ///     for details on supported values) used to disable a pattern of dates.
        /// </summary>
        /// <returns></returns>
        public virtual void setDisabledDates() { return ; }

        /// <summary>
        ///     Replaces any existing disabled dates with new values and refreshes the DatePicker.
        ///     for details on supported values) used to disable a pattern of dates.
        /// </summary>
        /// <param name="disabledDates">An array of date strings (see the {@link #disabledDates} config</param>
        /// <returns></returns>
        public virtual void setDisabledDates(System.Array disabledDates) { return ; }

        /// <summary>
        ///     Replaces any existing disabled days (by index, 0-6) with new values and refreshes the DatePicker.
        ///     for details on supported values.
        /// </summary>
        /// <returns></returns>
        public virtual void setDisabledDays() { return ; }

        /// <summary>
        ///     Replaces any existing disabled days (by index, 0-6) with new values and refreshes the DatePicker.
        ///     for details on supported values.
        /// </summary>
        /// <param name="disabledDays">An array of disabled day indexes. See the {@link #disabledDays} config</param>
        /// <returns></returns>
        public virtual void setDisabledDays(System.Array disabledDays) { return ; }

        /// <summary>Replaces any existing {@link #minValue} with the new value and refreshes the DatePicker.</summary>
        /// <returns></returns>
        public virtual void setMinValue() { return ; }

        /// <summary>Replaces any existing {@link #minValue} with the new value and refreshes the DatePicker.</summary>
        /// <param name="value">The minimum date that can be selected</param>
        /// <returns></returns>
        public virtual void setMinValue(System.DateTime value) { return ; }

        /// <summary>Replaces any existing {@link #maxValue} with the new value and refreshes the DatePicker.</summary>
        /// <returns></returns>
        public virtual void setMaxValue() { return ; }

        /// <summary>Replaces any existing {@link #maxValue} with the new value and refreshes the DatePicker.</summary>
        /// <param name="value">The maximum date that can be selected</param>
        /// <returns></returns>
        public virtual void setMaxValue(System.DateTime value) { return ; }

        /// <summary>Returns the current date value of the date field.</summary>
        /// <returns>Date</returns>
        public virtual System.DateTime getValue() { return DateTime.MinValue; }

        /// <summary>
        ///     Sets the value of the date field.  You can pass a date object or any string that can be parsed into a valid
        ///     date, using DateField.format as the date format, according to the same rules as {@link Date#parseDate}
        ///     (the default format used is "m/d/Y").
        ///     <br />Usage:
        ///     <pre><code>
        ///     //All of these calls set the same date value (May 4, 2006)
        ///     //Pass a date object:
        ///     var dt = new Date('5/4/2006');
        ///     dateField.setValue(dt);
        ///     //Pass a date string (default format):
        ///     dateField.setValue('05/04/2006');
        ///     //Pass a date string (custom format):
        ///     dateField.format = 'Y-m-d';
        ///     dateField.setValue('2006-05-04');
        ///     </code></pre>
        /// </summary>
        /// <returns></returns>
        public virtual void setValue() { return ; }

        /// <summary>
        ///     Sets the value of the date field.  You can pass a date object or any string that can be parsed into a valid
        ///     date, using DateField.format as the date format, according to the same rules as {@link Date#parseDate}
        ///     (the default format used is "m/d/Y").
        ///     <br />Usage:
        ///     <pre><code>
        ///     //All of these calls set the same date value (May 4, 2006)
        ///     //Pass a date object:
        ///     var dt = new Date('5/4/2006');
        ///     dateField.setValue(dt);
        ///     //Pass a date string (default format):
        ///     dateField.setValue('05/04/2006');
        ///     //Pass a date string (custom format):
        ///     dateField.format = 'Y-m-d';
        ///     dateField.setValue('2006-05-04');
        ///     </code></pre>
        /// </summary>
        /// <param name="date">The date or valid date string</param>
        /// <returns></returns>
        public virtual void setValue(System.String date) { return ; }

        /// <summary>
        ///     Sets the value of the date field.  You can pass a date object or any string that can be parsed into a valid
        ///     date, using DateField.format as the date format, according to the same rules as {@link Date#parseDate}
        ///     (the default format used is "m/d/Y").
        ///     <br />Usage:
        ///     <pre><code>
        ///     //All of these calls set the same date value (May 4, 2006)
        ///     //Pass a date object:
        ///     var dt = new Date('5/4/2006');
        ///     dateField.setValue(dt);
        ///     //Pass a date string (default format):
        ///     dateField.setValue('05/04/2006');
        ///     //Pass a date string (custom format):
        ///     dateField.format = 'Y-m-d';
        ///     dateField.setValue('2006-05-04');
        ///     </code></pre>
        /// </summary>
        /// <param name="date">The date or valid date string</param>
        /// <returns></returns>
        public virtual void setValue(System.DateTime date) { return ; }

        /// <summary>@hide</summary>
        /// <returns></returns>
        public virtual void onTriggerClick() { return ; }

        /// <summary>@hide</summary>
        /// <returns></returns>
        public virtual void autoSize() { return ; }



    }
    [Anonymous]
    public class DateFieldConfig {

        /// <summary>  The default date format string which can be overriden for localization support.  The format must be valid according to {@link Date#parseDate} (defaults to 'm/d/Y').</summary>
        public System.String format { get { return null; } set { } }

        /// <summary>  Multiple date formats separated by "|" to try when parsing a user input value and it doesn't match the defined format (defaults to 'm/d/Y|n/j/Y|n/j/y|m/j/y|n/d/y|m/j/Y|n/d/Y|m-d-y|m-d-Y|m/d|m-d|md|mdy|mdY|d|Y-m-d').</summary>
        public System.String altFormats { get { return null; } set { } }

        /// <summary>  The tooltip to display when the date falls on a disabled day (defaults to 'Disabled')</summary>
        public System.String disabledDaysText { get { return null; } set { } }

        /// <summary>  The tooltip text to display when the date falls on a disabled date (defaults to 'Disabled')</summary>
        public System.String disabledDatesText { get { return null; } set { } }

        /// <summary>  The error text to display when the date in the cell is before minValue (defaults to 'The date in this field must be after {minValue}').</summary>
        public System.String minText { get { return null; } set { } }

        /// <summary>  The error text to display when the date in the cell is after maxValue (defaults to 'The date in this field must be before {maxValue}').</summary>
        public System.String maxText { get { return null; } set { } }

        /// <summary>  The error text to display when the date in the field is invalid (defaults to '{value} is not a valid date - it must be in the format {format}').</summary>
        public System.String invalidText { get { return null; } set { } }

        /// <summary>  An additional CSS class used to style the trigger button.  The trigger will always get the class 'x-form-trigger' and triggerClass will be <b>appended</b> if specified (defaults to 'x-form-date-trigger' which displays a calendar icon).</summary>
        public System.String triggerClass { get { return null; } set { } }

        /// <summary>  False to hide the footer area of the DatePicker containing the Today button and disable the keyboard handler for spacebar that selects the current date (defaults to true).</summary>
        public bool showToday { get { return false; } set { } }

        /// <summary>{Date/String}  The minimum allowed date. Can be either a Javascript date object or a string date in a valid format (defaults to null).</summary>
        public object minValue { get { return null; } set { } }

        /// <summary>{Date/String}  The maximum allowed date. Can be either a Javascript date object or a string date in a valid format (defaults to null).</summary>
        public object maxValue { get { return null; } set { } }

        /// <summary>  An array of days to disable, 0 based. For example, [0, 6] disables Sunday and Saturday (defaults to null).</summary>
        public System.Array disabledDays { get { return null; } set { } }

        /// <summary>  An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular expression so they are very powerful. Some examples: <ul> <li>["03/08/2003", "09/16/2003"] would disable those exact dates</li> <li>["03/08", "09/16"] would disable those days for every year</li> <li>["^03/08"] would only match the beginning (useful if you are using short years)</li> <li>["03/../2006"] would disable every day in March 2006</li> <li>["^03"] would disable every day in every March</li> </ul> Note that the format of the dates included in the array should exactly match the {@link #format} config. In order to support regular expressions, if you are using a date format that has "." in it, you will have to escape the dot when restricting dates. For example: ["03\\.08\\.03"].</summary>
        public System.Array disabledDates { get { return null; } set { } }

        /// <summary>{String/Object}  A DomHelper element spec, or true for a default element spec (defaults to {tag: "input", type: "text", size: "10", autocomplete: "off"})</summary>
        public object autoCreate { get { return null; } set { } }

        /// <summary> True to hide the trigger element and display only the base text field (defaults to false)</summary>
        public bool hideTrigger { get { return false; } set { } }

        /// <summary> A custom error message to display in place of the default message provided for the {@link #vtype} currently set for this field (defaults to '').  Only applies if vtype is set, else ignored.</summary>
        public System.String vtypeText { get { return null; } set { } }

        /// <summary> True if this field should automatically grow and shrink to its content</summary>
        public bool grow { get { return false; } set { } }

        /// <summary> The minimum width to allow when grow = true (defaults to 30)</summary>
        public double growMin { get { return 0; } set { } }

        /// <summary> The maximum width to allow when grow = true (defaults to 800)</summary>
        public double growMax { get { return 0; } set { } }

        /// <summary> A validation type name as defined in {@link Ext.form.VTypes} (defaults to null)</summary>
        public System.String vtype { get { return null; } set { } }

        /// <summary> An input mask regular expression that will be used to filter keystrokes that don't match (defaults to null)</summary>
        public object maskRe { get { return null; } set { } }

        /// <summary> True to disable input keystroke filtering (defaults to false)</summary>
        public bool disableKeyFilter { get { return false; } set { } }

        /// <summary> False to validate that the value length > 0 (defaults to true)</summary>
        public bool allowBlank { get { return false; } set { } }

        /// <summary> Minimum input field length required (defaults to 0)</summary>
        public double minLength { get { return 0; } set { } }

        /// <summary> Maximum input field length allowed (defaults to Number.MAX_VALUE)</summary>
        public double maxLength { get { return 0; } set { } }

        /// <summary> Error text to display if the minimum length validation fails (defaults to "The minimum length for this field is {minLength}")</summary>
        public System.String minLengthText { get { return null; } set { } }

        /// <summary> Error text to display if the maximum length validation fails (defaults to "The maximum length for this field is {maxLength}")</summary>
        public System.String maxLengthText { get { return null; } set { } }

        /// <summary> True to automatically select any existing field text when the field receives input focus (defaults to false)</summary>
        public bool selectOnFocus { get { return false; } set { } }

        /// <summary> Error text to display if the allow blank validation fails (defaults to "This field is required")</summary>
        public System.String blankText { get { return null; } set { } }

        /// <summary> A custom validation function to be called during field validation (defaults to null). If available, this function will be called only after the basic validators all return true, and will be passed the current field value and expected to return boolean true if the value is valid or a string error message if invalid.</summary>
        public Delegate validator { get { return null; } set { } }

        /// <summary> A JavaScript RegExp object to be tested against the field value during validation (defaults to null). If available, this regex will be evaluated only after the basic validators all return true, and will be passed the current field value.  If the test fails, the field will be marked invalid using {@link #regexText}.</summary>
        public object regex { get { return null; } set { } }

        /// <summary> The error text to display if {@link #regex} is used and the test fails during validation (defaults to "")</summary>
        public System.String regexText { get { return null; } set { } }

        /// <summary> The default text to display in an empty field (defaults to null).</summary>
        public System.String emptyText { get { return null; } set { } }

        /// <summary> The CSS class to apply to an empty field to style the {@link #emptyText} (defaults to 'x-form-empty-field').  This class is automatically added and removed as needed depending on the current field value.</summary>
        public System.String emptyClass { get { return null; } set { } }

        /// <summary> True to enable the proxying of key events for the HTML input field (defaults to false)</summary>
        public bool enableKeyEvents { get { return false; } set { } }

        /// <summary> The label text to display next to this field (defaults to '')</summary>
        public System.String fieldLabel { get { return null; } set { } }

        /// <summary> A CSS style specification to apply directly to this field's label (defaults to the container's labelStyle value if set, or ''). For example, <code>labelStyle: 'font-weight:bold;'</code>.</summary>
        public System.String labelStyle { get { return null; } set { } }

        /// <summary> The standard separator to display after the text of each form label (defaults to the value of {@link Ext.layout.FormLayout#labelSeparator}, which is a colon ':' by default).  To display no separator for this field's label specify empty string ''.</summary>
        public System.String labelSeparator { get { return null; } set { } }

        /// <summary> True to completely hide the label element (defaults to false)</summary>
        public bool hideLabel { get { return false; } set { } }

        /// <summary> The CSS class used to provide field clearing (defaults to 'x-form-clear-left')</summary>
        public System.String clearCls { get { return null; } set { } }

        /// <summary> An additional CSS class to apply to the wrapper's form item element of this field (defaults to the container's itemCls value if set, or '').  Since it is applied to the item wrapper, it allows you to write standard CSS rules that can apply to the field, the label (if specified) or any other element within the markup for the field. NOTE: this will not have any effect on fields that are not part of a form. Example use: <pre><code> // Apply a style to the field's label: &lt;style> .required .x-form-item-label {font-weight:bold;color:red;} &lt;/style> new Ext.FormPanel({ height: 100, renderTo: document.body, items: [{ xtype: 'textfield', fieldLabel: 'Name', itemCls: 'required' //this label will be styled },{ xtype: 'textfield', fieldLabel: 'Favorite Color' }] }); </code></pre></summary>
        public System.String itemCls { get { return null; } set { } }

        /// <summary> The type attribute for input fields -- e.g. radio, text, password, file (defaults to "text"). The types "file" and "password" must be used to render those field types currently -- there are no separate Ext components for those. Note that if you use <tt>inputType:'file'</tt>, {@link #emptyText} is not supported and should be avoided.</summary>
        public System.String inputType { get { return null; } set { } }

        /// <summary> The tabIndex for this field. Note this only applies to fields that are rendered, not those which are built via applyTo (defaults to undefined).</summary>
        public double tabIndex { get { return 0; } set { } }

        /// <summary> A value to initialize this field with (defaults to undefined).</summary>
        public object value { get { return null; } set { } }

        /// <summary> The field's HTML name attribute (defaults to "").</summary>
        public System.String name { get { return null; } set { } }

        /// <summary> A custom CSS class to apply to the field's underlying element (defaults to "").</summary>
        public System.String cls { get { return null; } set { } }

        /// <summary> The CSS class to use when marking a field invalid (defaults to "x-form-invalid")</summary>
        public System.String invalidClass { get { return null; } set { } }

        /// <summary> The CSS class to use when the field receives focus (defaults to "x-form-focus")</summary>
        public System.String focusClass { get { return null; } set { } }

        /// <summary>{String/Boolean} The event that should initiate field validation. Set to false to disable automatic validation (defaults to "keyup").</summary>
        public object validationEvent { get { return null; } set { } }

        /// <summary> Whether the field should validate when it loses focus (defaults to true).</summary>
        public bool validateOnBlur { get { return false; } set { } }

        /// <summary> The length of time in milliseconds after user input begins until validation is initiated (defaults to 250)</summary>
        public double validationDelay { get { return 0; } set { } }

        /// <summary> The default CSS class for the field (defaults to "x-form-field")</summary>
        public System.String fieldClass { get { return null; } set { } }

        /// <summary> The location where error text should display.  Should be one of the following values (defaults to 'qtip'): <pre> Value         Description -----------   ---------------------------------------------------------------------- qtip          Display a quick tip when the user hovers over the field title         Display a default browser title attribute popup under         Add a block div beneath the field containing the error text side          Add an error icon to the right of the field with a popup on hover [element id]  Add the error text directly to the innerHTML of the specified element </pre></summary>
        public System.String msgTarget { get { return null; } set { } }

        /// <summary> <b>Experimental</b> The effect used when displaying a validation message under the field (defaults to 'normal').</summary>
        public System.String msgFx { get { return null; } set { } }

        /// <summary> True to mark the field as readOnly in HTML (defaults to false) -- Note: this only sets the element's readOnly DOM attribute.</summary>
        public bool readOnly { get { return false; } set { } }

        /// <summary> True to disable the field (defaults to false).</summary>
        public bool disabled { get { return false; } set { } }

        /// <summary>  The local x (left) coordinate for this component if contained within a positioning container.</summary>
        public double x { get { return 0; } set { } }

        /// <summary>  The local y (top) coordinate for this component if contained within a positioning container.</summary>
        public double y { get { return 0; } set { } }

        /// <summary>  The page level x coordinate for this component if contained within a positioning container.</summary>
        public double pageX { get { return 0; } set { } }

        /// <summary>  The page level y coordinate for this component if contained within a positioning container.</summary>
        public double pageY { get { return 0; } set { } }

        /// <summary>  The height of this component in pixels (defaults to auto).</summary>
        public double height { get { return 0; } set { } }

        /// <summary>  The width of this component in pixels (defaults to auto).</summary>
        public double width { get { return 0; } set { } }

        /// <summary>  True to use height:'auto', false to use fixed height. Note: although many components inherit this config option, not all will function as expected with a height of 'auto'. (defaults to false).</summary>
        public bool autoHeight { get { return false; } set { } }

        /// <summary>  True to use width:'auto', false to use fixed width. Note: although many components inherit this config option, not all will function as expected with a width of 'auto'. (defaults to false).</summary>
        public bool autoWidth { get { return false; } set { } }

        /// <summary> 
        ///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
        ///     The predefined xtypes are listed at the top of this document.
        ///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
        /// </summary>
        public string xtype { get { return null; } set { } }

        /// <summary>  The unique id of this component (defaults to an auto-assigned id).</summary>
        public System.String id { get { return null; } set { } }

        /// <summary>{String/Object}  A tag name or DomHelper spec to create an element with. This is intended to create shorthand utility components inline via JSON. It should not be used for higher level components which already create their own elements. Example usage: <pre><code> {xtype:'box', autoEl: 'div', cls:'my-class'} {xtype:'box', autoEl: {tag:'blockquote', html:'autoEl is cool!'}} // with DomHelper </code></pre></summary>
        public object autoEl { get { return null; } set { } }

        /// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
        public System.String overCls { get { return null; } set { } }

        /// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
        public System.String style { get { return null; } set { } }

        /// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
        public System.String ctCls { get { return null; } set { } }

        /// <summary>  Render this component hidden (default is false).</summary>
        public bool hidden { get { return false; } set { } }

        /// <summary>{Object/Array}  An object or array of objects that will provide custom functionality for this component.  The only requirement for a valid plugin is that it contain an init method that accepts a reference of type Ext.Component. When a component is created, if any plugins are available, the component will call the init method on each plugin, passing a reference to itself.  Each plugin can then call methods or respond to events on the component as needed to provide its functionality.</summary>
        public object plugins { get { return null; } set { } }

        /// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some structural markup for this component.  When applyTo is used, constituent parts of the component can also be specified by id or CSS class name within the main element, and the component being created may attempt to create its subcomponents from that markup if applicable. Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the component's container.</summary>
        public object applyTo { get { return null; } set { } }

        /// <summary>  The id of the node, a DOM node or an existing Element that will be the container to render this component into. Using this config, a call to render() is not required.</summary>
        public object renderTo { get { return null; } set { } }

        /// <summary>  A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link staterestore}, {@link beforestatesave} and {@link statesave} events</p></summary>
        public bool stateful { get { return false; } set { } }

        /// <summary>  The unique id for this component to use for state management purposes (defaults to the component id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
        public System.String stateId { get { return null; } set { } }

        /// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
        public System.String disabledClass { get { return null; } set { } }

        /// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
        public bool allowDomMove { get { return false; } set { } }

        /// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
        public bool autoShow { get { return false; } set { } }

        /// <summary>  How this component should hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</summary>
        public System.String hideMode { get { return null; } set { } }

        /// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
        public bool hideParent { get { return false; } set { } }

        /// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
        public object listeners { get { return null; } set { } }

    }


}
