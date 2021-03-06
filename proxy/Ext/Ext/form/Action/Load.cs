using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form.Action {
	/// <summary>
	///     /**
	///     <p>A class which handles loading of data from a server into the Fields of an {@link Ext.form.BasicForm}.</p>
	///     <p>Instances of this class are only created by a {@link Ext.form.BasicForm Form} when
	///     {@link Ext.form.BasicForm#load load}ing.</p>
	///     <p>A response packet <b>must</b> contain a boolean <tt style="font-weight:bold">success</tt> property, and
	///     a <tt style="font-weight:bold">data</tt> property. The <tt style="font-weight:bold">data</tt> property
	///     contains the values of Fields to load. The individual value object for each Field
	///     is passed to the Field's {@link Ext.form.Field#setValue setValue} method.</p>
	///     <p>By default, response packets are assumed to be JSON, so a typical response
	///     packet may look like this:</p><pre><code>
	///     {
	///     success: true,
	///     data: {
	///     clientName: "Fred. Olsen Lines",
	///     portOfLoading: "FXT",
	///     portOfDischarge: "OSL"
	///     }
	///     }</code></pre>
	///     <p>Other data may be placed into the response for processing the {@link Ext.form.BasicForm Form}'s callback
	///     or event handler methods. The object decoded from this JSON is available in the {@link #result} property.</p>
	///     */
	///     Ext.form.Action.Load = function(form, options){
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\form\Action.js</jssource>
	public class Load : Ext.form.ActionClass {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Load();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Load prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.form.ActionClass superclass { get; set; }




	}

	[JsAnonymous]
	public class LoadConfig : System.DotWeb.JsDynamic {
		/// <summary> The URL that the Action is to invoke.</summary>
		public string url { get { return (string)this["url"]; } set { this["url"] = value; } }

		/// <summary> When set to <tt><b>true</b></tt>, causes the Form to be {@link Ext.form.BasicForm.reset reset} on Action success. If specified, this happens <b>before</b> the {@link #success} callback is called and before the Form's {@link Ext.form.BasicForm.actioncomplete actioncomplete} event fires.</summary>
		public bool reset { get { return (bool)this["reset"]; } set { this["reset"] = value; } }

		/// <summary> The HTTP method to use to access the requested URL. Defaults to the {@link Ext.form.BasicForm}'s method, or if that is not specified, the underlying DOM form's method.</summary>
		public string method { get { return (string)this["method"]; } set { this["method"] = value; } }

		/// <summary> Extra parameter values to pass. These are added to the Form's {@link Ext.form.BasicForm#baseParams} and passed to the specified URL along with the Form's input fields.</summary>
		public object params_ { get { return (object)this["params_"]; } set { this["params_"] = value; } }

		/// <summary> The number of milliseconds to wait for a server response before failing with the {@link #failureType} as {@link #CONNECT_FAILURE}.</summary>
		public double timeout { get { return (double)this["timeout"]; } set { this["timeout"] = value; } }

		/// <summary> The function to call when a valid success return packet is recieved. The function is passed the following parameters:<ul class="mdetail-params"> <li><b>form</b> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li> <li><b>action</b> : Ext.form.Action<div class="sub-desc">The Action class. The {@link #result} property of this object may be examined to perform custom postprocessing.</div></li> </ul></summary>
		public Delegate success { get { return (Delegate)this["success"]; } set { this["success"] = value; } }

		/// <summary> The function to call when a failure packet was recieved, or when an error ocurred in the Ajax communication. The function is passed the following parameters:<ul class="mdetail-params"> <li><b>form</b> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li> <li><b>action</b> : Ext.form.Action<div class="sub-desc">The Action class. If an Ajax error ocurred, the failure type will be in {@link #failureType}. The {@link #result} property of this object may be examined to perform custom postprocessing.</div></li> </ul></summary>
		public Delegate failure { get { return (Delegate)this["failure"]; } set { this["failure"] = value; } }

		/// <summary> The scope in which to call the callback functions (The <tt>this</tt> reference for the callback functions).</summary>
		public object scope { get { return (object)this["scope"]; } set { this["scope"] = value; } }

		/// <summary> The message to be displayed by a call to {@link Ext.MessageBox#wait} during the time the action is being processed.</summary>
		public string waitMsg { get { return (string)this["waitMsg"]; } set { this["waitMsg"] = value; } }

		/// <summary> The title to be displayed by a call to {@link Ext.MessageBox#wait} during the time the action is being processed.</summary>
		public string waitTitle { get { return (string)this["waitTitle"]; } set { this["waitTitle"] = value; } }

	}
}
