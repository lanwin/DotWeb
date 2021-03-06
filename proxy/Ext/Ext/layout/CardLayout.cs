using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>This layout contains multiple panels, each fit to the container, where only a single panel can be
	///     visible at any given time.  This layout style is most commonly used for wizards, tab implementations, etc.
	///     This class is intended to be extended or created via the layout:'card' {@link Ext.Container#layout} config,
	///     and should generally not need to be created directly via the new keyword.</p>
	///     <p>The CardLayout's focal method is {@link #setActiveItem}.  Since only one panel is displayed at a time,
	///     the only way to move from one panel to the next is by calling setActiveItem, passing the id or index of
	///     the next panel to display.  The layout itself does not provide a mechanism for handling this navigation,
	///     so that functionality must be provided by the developer.</p>
	///     <p>In the following example, a simplistic wizard setup is demonstrated.  A button bar is added
	///     to the footer of the containing panel to provide navigation buttons.  The buttons will be handled by a
	///     common navigation routine -- for this example, the implementation of that routine has been ommitted since
	///     it can be any type of custom logic.  Note that other uses of a CardLayout (like a tab control) would require a
	///     completely different implementation.  For serious implementations, a better approach would be to extend
	///     CardLayout to provide the custom functionality needed.  Example usage:</p>
	///     <pre><code>
	///     var navHandler = function(direction){
	///     // This routine could contain business logic required to manage the navigation steps.
	///     // It would call setActiveItem as needed, manage navigation button state, handle any
	///     // branching logic that might be required, handle alternate actions like cancellation
	///     // or finalization, etc.  A complete wizard implementation could get pretty
	///     // sophisticated depending on the complexity required, and should probably be
	///     // done as a subclass of CardLayout in a real-world implementation.
	///     };
	///     var card = new Ext.Panel({
	///     title: 'Example Wizard',
	///     layout:'card',
	///     activeItem: 0, // make sure the active item is set on the container config!
	///     bodyStyle: 'padding:15px',
	///     defaults: {
	///     // applied to each contained panel
	///     border:false
	///     },
	///     // just an example of one possible navigation scheme, using buttons
	///     bbar: [
	///     {
	///     id: 'move-prev',
	///     text: 'Back',
	///     handler: navHandler.createDelegate(this, [-1]),
	///     disabled: true
	///     },
	///     '->', // greedy spacer so that the buttons are aligned to each side
	///     {
	///     id: 'move-next',
	///     text: 'Next',
	///     handler: navHandler.createDelegate(this, [1])
	///     }
	///     ],
	///     // the panels (or "cards") within the layout
	///     items: [{
	///     id: 'card-0',
	///     html: '&lt;h1&gt;Welcome to the Wizard!&lt;/h1&gt;&lt;p&gt;Step 1 of 3&lt;/p&gt;'
	///     },{
	///     id: 'card-1',
	///     html: '&lt;p&gt;Step 2 of 3&lt;/p&gt;'
	///     },{
	///     id: 'card-2',
	///     html: '&lt;h1&gt;Congratulations!&lt;/h1&gt;&lt;p&gt;Step 3 of 3 - Complete&lt;/p&gt;'
	///     }]
	///     });
	///     </code></pre>
	///     */
	///     Ext.layout.CardLayout = Ext.extend(Ext.layout.FitLayout, {
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\layout\CardLayout.js</jssource>
	public class CardLayout : Ext.layout.FitLayout {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern CardLayout();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static CardLayout prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.layout.FitLayout superclass { get; set; }

		/// <summary>
		///     True to render each contained item at the time it becomes active, false to render all contained items
		///     as soon as the layout is rendered (defaults to false).  If there is a significant amount of content or
		///     a lot of heavy controls being rendered into panels that are not displayed by default, setting this to
		///     true might improve performance.
		/// </summary>
		public extern bool deferredRender { get; set; }


		/// <summary>Sets the active (visible) item in the layout.</summary>
		/// <returns></returns>
		public extern virtual void setActiveItem();

		/// <summary>Sets the active (visible) item in the layout.</summary>
		/// <param name="item">The string component id or numeric index of the item to activate</param>
		/// <returns></returns>
		public extern virtual void setActiveItem(string item);

		/// <summary>Sets the active (visible) item in the layout.</summary>
		/// <param name="item">The string component id or numeric index of the item to activate</param>
		/// <returns></returns>
		public extern virtual void setActiveItem(double item);



	}

	[JsAnonymous]
	public class CardLayoutConfig : System.DotWeb.JsDynamic {
		/// <summary>  True to render each contained item at the time it becomes active, false to render all contained items as soon as the layout is rendered (defaults to false).  If there is a significant amount of content or a lot of heavy controls being rendered into panels that are not displayed by default, setting this to true might improve performance.</summary>
		public bool deferredRender { get { return (bool)this["deferredRender"]; } set { this["deferredRender"] = value; } }

		/// <summary>  An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public string extraCls { get { return (string)this["extraCls"]; } set { this["extraCls"] = value; } }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public bool renderHidden { get { return (bool)this["renderHidden"]; } set { this["renderHidden"] = value; } }

	}
}
