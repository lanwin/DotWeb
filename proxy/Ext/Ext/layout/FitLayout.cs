using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>This is a base class for layouts that contain a single item that automatically expands to fill the layout's
	///     container.  This class is intended to be extended or created via the layout:'fit' {@link Ext.Container#layout}
	///     config, and should generally not need to be created directly via the new keyword.</p>
	///     <p>FitLayout does not have any direct config options (other than inherited ones).  To fit a panel to a container
	///     using FitLayout, simply set layout:'fit' on the container and add a single panel to it.  If the container has
	///     multiple panels, only the first one will be displayed.  Example usage:</p>
	///     <pre><code>
	///     var p = new Ext.Panel({
	///     title: 'Fit Layout',
	///     layout:'fit',
	///     items: {
	///     title: 'Inner Panel',
	///     html: '&lt;p&gt;This is the inner panel content&lt;/p&gt;',
	///     border: false
	///     }
	///     });
	///     </code></pre>
	///     */
	///     Ext.layout.FitLayout = Ext.extend(Ext.layout.ContainerLayout, {
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\layout\FitLayout.js</jssource>
	public class FitLayout : Ext.layout.ContainerLayout {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern FitLayout();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static FitLayout prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.layout.ContainerLayout superclass { get; set; }




	}

	[JsAnonymous]
	public class FitLayoutConfig : System.DotWeb.JsDynamic {
		/// <summary>  An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public string extraCls { get { return (string)this["extraCls"]; } set { this["extraCls"] = value; } }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public bool renderHidden { get { return (bool)this["renderHidden"]; } set { this["renderHidden"] = value; } }

	}
}
