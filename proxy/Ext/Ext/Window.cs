using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A specialized panel intended for use as an application window.  Windows are floated and draggable by default, and
	///     also provide specific behavior like the ability to maximize and restore (with an event for minimizing, since the
	///     minimize behavior is application-specific).  Windows can also be linked to a {@link Ext.WindowGroup} or managed
	///     by the {@link Ext.WindowManager} to provide grouping, activation, to front/back and other application-specific behavior.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\widgets\Window.js</jssource>
	public class WindowClass : Ext.Panel {

		/// <summary></summary>
		/// <returns></returns>
		public extern WindowClass();
		/// <summary></summary>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern WindowClass(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern WindowClass(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern WindowClass(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static WindowClass prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Panel superclass { get; set; }

		/// <summary>
		///     The X position of the left edge of the Window on initial showing. Defaults to centering the Window within
		///     the width of the Window's container {@link Ext.Element Element) (The Element that the Window is rendered to).
		/// </summary>
		public extern double x { get; set; }

		/// <summary>
		///     The Y position of the top edge of the Window on initial showing. Defaults to centering the Window within
		///     the height of the Window's container {@link Ext.Element Element) (The Element that the Window is rendered to).
		/// </summary>
		public extern double y { get; set; }

		/// <summary>
		///     True to make the window modal and mask everything behind it when displayed, false to display it without
		///     restricting access to other UI elements (defaults to false).
		/// </summary>
		public extern bool modal { get; set; }

		/// <summary>Id or element from which the window should animate while opening (defaults to null with no animation).</summary>
		public extern object animateTarget { get; set; }

		/// <summary>A valid {@link Ext.Resizable} handles config string (defaults to 'all').  Only applies when resizable = true.</summary>
		public extern string resizeHandles { get; set; }

		/// <summary>A reference to the WindowGroup that should manage this window (defaults to {@link Ext.WindowMgr}).</summary>
		public extern Ext.WindowGroup manager { get; set; }

		/// <summary>The id / index of a button or a button instance to focus when this window received the focus.</summary>
		public extern object defaultButton { get; set; }

		/// <summary>
		///     Allows override of the built-in processing for the escape key. Default action
		///     is to close the Window (performing whatever action is specified in {@link #closeAction}.
		///     To prevent the Window closing when the escape key is pressed, specify this as
		///     Ext.emptyFn (See {@link Ext#emptyFn}).
		/// </summary>
		public extern Delegate onEsc { get; set; }

		/// <summary>The base CSS class to apply to this panel's element (defaults to 'x-window').</summary>
		public extern string baseCls { get; set; }

		/// <summary>True to allow user resizing at each edge and corner of the window, false to disable resizing (defaults to true).</summary>
		public extern bool resizable { get; set; }

		/// <summary>
		///     True to allow the window to be dragged by the header bar, false to disable dragging (defaults to true).  Note
		///     that by default the window will be centered in the viewport, so if dragging is disabled the window may need
		///     to be positioned programmatically after render (e.g., myWindow.setPosition(100, 100);).
		/// </summary>
		public extern bool draggable { get; set; }

		/// <summary>
		///     <p>True to display the 'close' tool button and allow the user to close the window, false to
		///     hide the button and disallow closing the window (default to true).</p>
		///     <p>By default, when close is requested by either clicking the close button in the header
		///     or pressing ESC when the Window has focus, the {@link #close} method will be called. This
		///     will <i>destroy</i> the Window and its content meaning that it may not be reused.</p>
		///     <p>To make closing a Window <i>hide</i> the Window so that it may be reused, set
		///     {@link #closeAction} to 'hide'.
		/// </summary>
		public extern bool closable { get; set; }

		/// <summary>
		///     True to constrain the window to the viewport, false to allow it to fall outside of the viewport
		///     (defaults to false).  Optionally the header only can be constrained using {@link #constrainHeader}.
		/// </summary>
		public extern bool constrain { get; set; }

		/// <summary>
		///     True to constrain the window header to the viewport, allowing the window body to fall outside of the viewport,
		///     false to allow the header to fall outside the viewport (defaults to false).  Optionally the entire window
		///     can be constrained using {@link #constrain}.
		/// </summary>
		public extern bool constrainHeader { get; set; }

		/// <summary>
		///     True to render the window body with a transparent background so that it will blend into the framing
		///     elements, false to add a lighter background color to visually highlight the body element and separate it
		///     more distinctly from the surrounding frame (defaults to false).
		/// </summary>
		public extern bool plain { get; set; }

		/// <summary>
		///     True to display the 'minimize' tool button and allow the user to minimize the window, false to hide the button
		///     and disallow minimizing the window (defaults to false).  Note that this button provides no implementation --
		///     the behavior of minimizing a window is implementation-specific, so the minimize event must be handled and a
		///     custom minimize behavior implemented for this option to be useful.
		/// </summary>
		public extern bool minimizable { get; set; }

		/// <summary>
		///     True to display the 'maximize' tool button and allow the user to maximize the window, false to hide the button
		///     and disallow maximizing the window (defaults to false).  Note that when a window is maximized, the tool button
		///     will automatically change to a 'restore' button with the appropriate behavior already built-in that will
		///     restore the window to its previous size.
		/// </summary>
		public extern bool maximizable { get; set; }

		/// <summary>The minimum height in pixels allowed for this window (defaults to 100).  Only applies when resizable = true.</summary>
		public extern double minHeight { get; set; }

		/// <summary>The minimum width in pixels allowed for this window (defaults to 200).  Only applies when resizable = true.</summary>
		public extern double minWidth { get; set; }

		/// <summary>
		///     True to always expand the window when it is displayed, false to keep it in its current state (which may be
		///     collapsed) when displayed (defaults to true).
		/// </summary>
		public extern bool expandOnShow { get; set; }

		/// <summary>
		///     The action to take when the close button is clicked.  The default action is 'close' which will actually remove
		///     the window from the DOM and destroy it.  The other valid option is 'hide' which will simply hide the window
		///     by setting visibility to hidden and applying negative offsets, keeping the window available to be redisplayed
		///     via the {@link #show} method.
		/// </summary>
		public extern string closeAction { get; set; }

		/// <summary>
		///     A comma-delimited list of panel elements to initialize when the window is rendered.  Normally, this list will be
		///     generated automatically based on the items added to the window at config time, but sometimes it might be useful to
		///     make sure a structural element is rendered even if not specified at config time (for example, you may want
		///     to add a button or toolbar dynamically after the window has been rendered).  Adding those elements to this
		///     list will allocate the required placeholders in the window when it is rendered.  Valid values are<ul>
		///     <li><b>header</b> (required)</li>
		///     <li><b>tbar</b> (top bar)</li>
		///     <li><b>body</b> (required)</li>
		///     <li><b>bbar</b> (bottom bar)</li>
		///     <li><b>footer</b><li>
		///     </ul>
		///     Defaults to 'header,body'.
		/// </summary>
		public extern string elements { get; set; }

		/// <summary>
		///     @cfg {Boolean} monitorResize @hide
		///     This is automatically managed based on the value of constrain and constrainToHeader
		/// </summary>
		public extern object monitorResize { get; set; }

		/// <summary>
		///     If this Window is configured {@link #draggable}, this property will contain
		///     an instance of {@link Ext.dd.DD} which handles dragging the Window's DOM Element.
		/// </summary>
		public extern Ext.dd.DD dd { get; set; }


		/// <summary>
		///     Focuses the window.  If a defaultButton is set, it will receive focus, otherwise the
		///     window itself will receive focus.
		/// </summary>
		/// <returns></returns>
		public extern virtual void focus();

		/// <summary>Sets the target element from which the window should animate while opening.</summary>
		/// <returns></returns>
		public extern virtual void setAnimateTarget();

		/// <summary>Sets the target element from which the window should animate while opening.</summary>
		/// <param name="el">The target element or id</param>
		/// <returns></returns>
		public extern virtual void setAnimateTarget(string el);

		/// <summary>Sets the target element from which the window should animate while opening.</summary>
		/// <param name="el">The target element or id</param>
		/// <returns></returns>
		public extern virtual void setAnimateTarget(Element el);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <returns></returns>
		public extern virtual void show();

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <returns></returns>
		public extern virtual void show(string animateTarget);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is displayed</param>
		/// <returns></returns>
		public extern virtual void show(string animateTarget, Delegate callback);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is displayed</param>
		/// <param name="scope">(optional) The scope in which to execute the callback</param>
		/// <returns></returns>
		public extern virtual void show(string animateTarget, Delegate callback, object scope);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <returns></returns>
		public extern virtual void show(Element animateTarget);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is displayed</param>
		/// <returns></returns>
		public extern virtual void show(Element animateTarget, Delegate callback);

		/// <summary>
		///     Shows the window, rendering it first if necessary, or activates it and brings it to front if hidden.
		///     animate while opening (defaults to undefined with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id from which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is displayed</param>
		/// <param name="scope">(optional) The scope in which to execute the callback</param>
		/// <returns></returns>
		public extern virtual void show(Element animateTarget, Delegate callback, object scope);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <returns></returns>
		public extern virtual void hide();

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <returns></returns>
		public extern virtual void hide(string animateTarget);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is hidden</param>
		/// <returns></returns>
		public extern virtual void hide(string animateTarget, Delegate callback);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is hidden</param>
		/// <param name="scope">(optional) The scope in which to execute the callback</param>
		/// <returns></returns>
		public extern virtual void hide(string animateTarget, Delegate callback, object scope);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <returns></returns>
		public extern virtual void hide(Element animateTarget);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is hidden</param>
		/// <returns></returns>
		public extern virtual void hide(Element animateTarget, Delegate callback);

		/// <summary>
		///     Hides the window, setting it to invisible and applying negative offsets.
		///     animate while hiding (defaults to null with no animation)
		/// </summary>
		/// <param name="animateTarget">(optional) The target element or id to which the window should</param>
		/// <param name="callback">(optional) A callback function to call after the window is hidden</param>
		/// <param name="scope">(optional) The scope in which to execute the callback</param>
		/// <returns></returns>
		public extern virtual void hide(Element animateTarget, Delegate callback, object scope);

		/// <summary>
		///     Placeholder method for minimizing the window.  By default, this method simply fires the {@link #minimize} event
		///     since the behavior of minimizing a window is application-specific.  To implement custom minimize behavior,
		///     either the minimize event can be handled or this method can be overridden.
		/// </summary>
		/// <returns></returns>
		public extern virtual void minimize();

		/// <summary>
		///     Closes the window, removes it from the DOM and destroys the window object.  The beforeclose event is fired
		///     before the close happens and will cancel the close action if it returns false.
		/// </summary>
		/// <returns></returns>
		public extern virtual void close();

		/// <summary>
		///     Fits the window within its current container and automatically replaces the 'maximize' tool button with
		///     the 'restore' tool button.
		/// </summary>
		/// <returns></returns>
		public extern virtual void maximize();

		/// <summary>
		///     Restores a maximized window back to its original size and position prior to being maximized and also replaces
		///     the 'restore' tool button with the 'maximize' tool button.
		/// </summary>
		/// <returns></returns>
		public extern virtual void restore();

		/// <summary>
		///     A shortcut method for toggling between {@link #maximize} and {@link #restore} based on the current maximized
		///     state of the window.
		/// </summary>
		/// <returns></returns>
		public extern virtual void toggleMaximize();

		/// <summary>Aligns the window to the specified element</summary>
		/// <returns>Ext.Window</returns>
		public extern virtual void alignTo();

		/// <summary>Aligns the window to the specified element</summary>
		/// <param name="element">The element to align to.</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void alignTo(object element);

		/// <summary>Aligns the window to the specified element</summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details).</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void alignTo(object element, string position);

		/// <summary>Aligns the window to the specified element</summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details).</param>
		/// <param name="offsets">(optional) Offset the positioning by [x, y]</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void alignTo(object element, string position, System.Array offsets);

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo();

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <param name="element">The element to align to.</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo(object element);

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details)</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo(object element, string position);

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details)</param>
		/// <param name="offsets">(optional) Offset the positioning by [x, y]</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo(object element, string position, System.Array offsets);

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details)</param>
		/// <param name="offsets">(optional) Offset the positioning by [x, y]</param>
		/// <param name="monitorScroll">(optional) true to monitor body scroll and reposition. If this parameter</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo(object element, string position, System.Array offsets, bool monitorScroll);

		/// <summary>
		///     Anchors this window to another element and realigns it when the window is resized or scrolled.
		///     is a number, it is used as the buffer delay (defaults to 50ms).
		/// </summary>
		/// <param name="element">The element to align to.</param>
		/// <param name="position">The position to align to (see {@link Ext.Element#alignTo} for more details)</param>
		/// <param name="offsets">(optional) Offset the positioning by [x, y]</param>
		/// <param name="monitorScroll">(optional) true to monitor body scroll and reposition. If this parameter</param>
		/// <returns>Ext.Window</returns>
		public extern virtual void anchorTo(object element, string position, System.Array offsets, double monitorScroll);

		/// <summary>Brings this window to the front of any other visible windows</summary>
		/// <returns>Ext.Window</returns>
		public extern virtual void toFront();

		/// <summary>
		///     Makes this the active window by showing its shadow, or deactivates it by hiding its shadow.  This method also
		///     fires the {@link #activate} or {@link #deactivate} event depending on which action occurred.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setActive();

		/// <summary>
		///     Makes this the active window by showing its shadow, or deactivates it by hiding its shadow.  This method also
		///     fires the {@link #activate} or {@link #deactivate} event depending on which action occurred.
		/// </summary>
		/// <param name="active">True to activate the window, false to deactivate it (defaults to false)</param>
		/// <returns></returns>
		public extern virtual void setActive(bool active);

		/// <summary>Sends this window to the back of (lower z-index than) any other visible windows</summary>
		/// <returns>Ext.Window</returns>
		public extern virtual void toBack();

		/// <summary>Centers this window in the viewport</summary>
		/// <returns>Ext.Window</returns>
		public extern virtual void center();



	}

	[JsAnonymous]
	public class WindowConfig : System.DotWeb.JsDynamic {
		/// <summary>  The X position of the left edge of the Window on initial showing. Defaults to centering the Window within the width of the Window's container {@link Ext.Element Element) (The Element that the Window is rendered to).</summary>
		public double x { get { return (double)this["x"]; } set { this["x"] = value; } }

		/// <summary>  The Y position of the top edge of the Window on initial showing. Defaults to centering the Window within the height of the Window's container {@link Ext.Element Element) (The Element that the Window is rendered to).</summary>
		public double y { get { return (double)this["y"]; } set { this["y"] = value; } }

		/// <summary>  True to make the window modal and mask everything behind it when displayed, false to display it without restricting access to other UI elements (defaults to false).</summary>
		public bool modal { get { return (bool)this["modal"]; } set { this["modal"] = value; } }

		/// <summary>{String/Element}  Id or element from which the window should animate while opening (defaults to null with no animation).</summary>
		public object animateTarget { get { return (object)this["animateTarget"]; } set { this["animateTarget"] = value; } }

		/// <summary>  A valid {@link Ext.Resizable} handles config string (defaults to 'all').  Only applies when resizable = true.</summary>
		public string resizeHandles { get { return (string)this["resizeHandles"]; } set { this["resizeHandles"] = value; } }

		/// <summary>  A reference to the WindowGroup that should manage this window (defaults to {@link Ext.WindowMgr}).</summary>
		public Ext.WindowGroup manager { get { return (Ext.WindowGroup)this["manager"]; } set { this["manager"] = value; } }

		/// <summary>{String/Number/Button}  The id / index of a button or a button instance to focus when this window received the focus.</summary>
		public object defaultButton { get { return (object)this["defaultButton"]; } set { this["defaultButton"] = value; } }

		/// <summary>  Allows override of the built-in processing for the escape key. Default action is to close the Window (performing whatever action is specified in {@link #closeAction}. To prevent the Window closing when the escape key is pressed, specify this as Ext.emptyFn (See {@link Ext#emptyFn}).</summary>
		public Delegate onEsc { get { return (Delegate)this["onEsc"]; } set { this["onEsc"] = value; } }

		/// <summary>  The base CSS class to apply to this panel's element (defaults to 'x-window').</summary>
		public string baseCls { get { return (string)this["baseCls"]; } set { this["baseCls"] = value; } }

		/// <summary>  True to allow user resizing at each edge and corner of the window, false to disable resizing (defaults to true).</summary>
		public bool resizable { get { return (bool)this["resizable"]; } set { this["resizable"] = value; } }

		/// <summary>  True to allow the window to be dragged by the header bar, false to disable dragging (defaults to true).  Note that by default the window will be centered in the viewport, so if dragging is disabled the window may need to be positioned programmatically after render (e.g., myWindow.setPosition(100, 100);).</summary>
		public bool draggable { get { return (bool)this["draggable"]; } set { this["draggable"] = value; } }

		/// <summary>  <p>True to display the 'close' tool button and allow the user to close the window, false to hide the button and disallow closing the window (default to true).</p> <p>By default, when close is requested by either clicking the close button in the header or pressing ESC when the Window has focus, the {@link #close} method will be called. This will <i>destroy</i> the Window and its content meaning that it may not be reused.</p> <p>To make closing a Window <i>hide</i> the Window so that it may be reused, set {@link #closeAction} to 'hide'.</summary>
		public bool closable { get { return (bool)this["closable"]; } set { this["closable"] = value; } }

		/// <summary>  True to constrain the window to the viewport, false to allow it to fall outside of the viewport (defaults to false).  Optionally the header only can be constrained using {@link #constrainHeader}.</summary>
		public bool constrain { get { return (bool)this["constrain"]; } set { this["constrain"] = value; } }

		/// <summary>  True to constrain the window header to the viewport, allowing the window body to fall outside of the viewport, false to allow the header to fall outside the viewport (defaults to false).  Optionally the entire window can be constrained using {@link #constrain}.</summary>
		public bool constrainHeader { get { return (bool)this["constrainHeader"]; } set { this["constrainHeader"] = value; } }

		/// <summary>  True to render the window body with a transparent background so that it will blend into the framing elements, false to add a lighter background color to visually highlight the body element and separate it more distinctly from the surrounding frame (defaults to false).</summary>
		public bool plain { get { return (bool)this["plain"]; } set { this["plain"] = value; } }

		/// <summary>  True to display the 'minimize' tool button and allow the user to minimize the window, false to hide the button and disallow minimizing the window (defaults to false).  Note that this button provides no implementation -- the behavior of minimizing a window is implementation-specific, so the minimize event must be handled and a custom minimize behavior implemented for this option to be useful.</summary>
		public bool minimizable { get { return (bool)this["minimizable"]; } set { this["minimizable"] = value; } }

		/// <summary>  True to display the 'maximize' tool button and allow the user to maximize the window, false to hide the button and disallow maximizing the window (defaults to false).  Note that when a window is maximized, the tool button will automatically change to a 'restore' button with the appropriate behavior already built-in that will restore the window to its previous size.</summary>
		public bool maximizable { get { return (bool)this["maximizable"]; } set { this["maximizable"] = value; } }

		/// <summary>  The minimum height in pixels allowed for this window (defaults to 100).  Only applies when resizable = true.</summary>
		public double minHeight { get { return (double)this["minHeight"]; } set { this["minHeight"] = value; } }

		/// <summary>  The minimum width in pixels allowed for this window (defaults to 200).  Only applies when resizable = true.</summary>
		public double minWidth { get { return (double)this["minWidth"]; } set { this["minWidth"] = value; } }

		/// <summary>  True to always expand the window when it is displayed, false to keep it in its current state (which may be collapsed) when displayed (defaults to true).</summary>
		public bool expandOnShow { get { return (bool)this["expandOnShow"]; } set { this["expandOnShow"] = value; } }

		/// <summary>  The action to take when the close button is clicked.  The default action is 'close' which will actually remove the window from the DOM and destroy it.  The other valid option is 'hide' which will simply hide the window by setting visibility to hidden and applying negative offsets, keeping the window available to be redisplayed via the {@link #show} method.</summary>
		public string closeAction { get { return (string)this["closeAction"]; } set { this["closeAction"] = value; } }

		/// <summary>  A comma-delimited list of panel elements to initialize when the window is rendered.  Normally, this list will be generated automatically based on the items added to the window at config time, but sometimes it might be useful to make sure a structural element is rendered even if not specified at config time (for example, you may want to add a button or toolbar dynamically after the window has been rendered).  Adding those elements to this list will allocate the required placeholders in the window when it is rendered.  Valid values are<ul> <li><b>header</b> (required)</li> <li><b>tbar</b> (top bar)</li> <li><b>body</b> (required)</li> <li><b>bbar</b> (bottom bar)</li> <li><b>footer</b><li> </ul> Defaults to 'header,body'.</summary>
		public string elements { get { return (string)this["elements"]; } set { this["elements"] = value; } }

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some panel-specific structural markup.  When applyTo is used, constituent parts of the panel can be specified by CSS class name within the main element, and the panel will automatically create those components from that markup. Any required components not specified in the markup will be autogenerated if necessary. The following class names are supported (baseCls will be replaced by {@link #baseCls}): <ul><li>baseCls + '-header'</li> <li>baseCls + '-header-text'</li> <li>baseCls + '-bwrap'</li> <li>baseCls + '-tbar'</li> <li>baseCls + '-body'</li> <li>baseCls + '-bbar'</li> <li>baseCls + '-footer'</li></ul> Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the panel's container.</summary>
		public object applyTo { get { return (object)this["applyTo"]; } set { this["applyTo"] = value; } }

		/// <summary>{Object/Array}  The top toolbar of the panel. This can be a {@link Ext.Toolbar} object, a toolbar config, or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the top toolbar after render, use {@link #getTopToolbar}.</summary>
		public object tbar { get { return (object)this["tbar"]; } set { this["tbar"] = value; } }

		/// <summary>{Object/Array}  The bottom toolbar of the panel. This can be a {@link Ext.Toolbar} object, a toolbar config, or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the bottom toolbar after render, use {@link #getBottomToolbar}.</summary>
		public object bbar { get { return (object)this["bbar"]; } set { this["bbar"] = value; } }

		/// <summary>  True to create the header element explicitly, false to skip creating it.  By default, when header is not specified, if a {@link #title} is set the header will be created automatically, otherwise it will not.  If a title is set but header is explicitly set to false, the header will not be rendered.</summary>
		public bool header { get { return (bool)this["header"]; } set { this["header"] = value; } }

		/// <summary>  True to create the footer element explicitly, false to skip creating it.  By default, when footer is not specified, if one or more buttons have been added to the panel the footer will be created automatically, otherwise it will not.</summary>
		public bool footer { get { return (bool)this["footer"]; } set { this["footer"] = value; } }

		/// <summary>  The title text to display in the panel header (defaults to '').  When a title is specified the header element will automatically be created and displayed unless {@link #header} is explicitly set to false.  If you don't want to specify a title at config time, but you may want one later, you must either specify a non-empty title (a blank space ' ' will do) or header:true so that the container element will get created.</summary>
		public string title { get { return (string)this["title"]; } set { this["title"] = value; } }

		/// <summary>  An array of {@link Ext.Button}s or {@link Ext.Button} configs used to add buttons to the footer of this panel.</summary>
		public System.Array buttons { get { return (System.Array)this["buttons"]; } set { this["buttons"] = value; } }

		/// <summary>{Object/String/Function}  A valid url spec according to the Updater {@link Ext.Updater#update} method. If autoLoad is not null, the panel will attempt to load its contents immediately upon render.<p> The URL will become the default URL for this panel's {@link #body} element, so it may be {@link Ext.Element#refresh refresh}ed at any time.</p></summary>
		public object autoLoad { get { return (object)this["autoLoad"]; } set { this["autoLoad"] = value; } }

		/// <summary>  True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to false).</summary>
		public bool frame { get { return (bool)this["frame"]; } set { this["frame"] = value; } }

		/// <summary>  True to display the borders of the panel's body element, false to hide them (defaults to true).  By default, the border is a 2px wide inset border, but this can be further altered by setting {@link #bodyBorder} to false.</summary>
		public bool border { get { return (bool)this["border"]; } set { this["border"] = value; } }

		/// <summary>  True to display an interior border on the body element of the panel, false to hide it (defaults to true). This only applies when {@link #border} == true.  If border == true and bodyBorder == false, the border will display as a 1px wide inset border, giving the entire body element an inset appearance.</summary>
		public bool bodyBorder { get { return (bool)this["bodyBorder"]; } set { this["bodyBorder"] = value; } }

		/// <summary>{String/Object/Function}  Custom CSS styles to be applied to the body element in the format expected by {@link Ext.Element#applyStyles} (defaults to null).</summary>
		public object bodyStyle { get { return (object)this["bodyStyle"]; } set { this["bodyStyle"] = value; } }

		/// <summary>  A CSS class that will provide a background image to be used as the header icon (defaults to '').  An example custom icon class would be something like: .my-icon { background: url(../images/my-icon.gif) 0 6px no-repeat !important;}</summary>
		public string iconCls { get { return (string)this["iconCls"]; } set { this["iconCls"] = value; } }

		/// <summary>  True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).</summary>
		public bool collapsible { get { return (bool)this["collapsible"]; } set { this["collapsible"] = value; } }

		/// <summary>  An array of tool button configs to be added to the header tool area. When rendered, each tool is stored as an {@link Ext.Element Element} referenced by a public property called <tt><b></b>tools.<i>&lt;tool-type&gt;</i></tt> <p>Each tool config may contain the following properties: <div class="mdetail-params"><ul> <li><b>id</b> : String<div class="sub-desc"><b>Required.</b> The type of tool to create. Values may be<ul> <li><tt>toggle</tt> (Created by default when {@link #collapsible} is <tt>true</tt>)</li> <li><tt>close</tt></li> <li><tt>minimize</tt></li> <li><tt>maximize</tt></li> <li><tt>restore</tt></li> <li><tt>gear</tt></li> <li><tt>pin</tt></li> <li><tt>unpin</tt></li> <li><tt>right</tt></li> <li><tt>left</tt></li> <li><tt>up</tt></li> <li><tt>down</tt></li> <li><tt>refresh</tt></li> <li><tt>minus</tt></li> <li><tt>plus</tt></li> <li><tt>help</tt></li> <li><tt>search</tt></li> <li><tt>save</tt></li> <li><tt>print</tt></li> </ul></div></li> <li><b>handler</b> : Function<div class="sub-desc"><b>Required.</b> The function to call when clicked. Arguments passed are:<ul> <li><b>event</b> : Ext.EventObject<div class="sub-desc">The click event.</div></li> <li><b>toolEl</b> : Ext.Element<div class="sub-desc">The tool Element.</div></li> <li><b>Panel</b> : Ext.Panel<div class="sub-desc">The host Panel</div></li> </ul></div></li> <li><b>scope</b> : Object<div class="sub-desc">The scope in which to call the handler.</div></li> <li><b>qtip</b> : String/Object<div class="sub-desc">A tip string, or a config argument to {@link Ext.QuickTip#register}</div></li> <li><b>hidden</b> : Boolean<div class="sub-desc">True to initially render hidden.</div></li> <li><b>on</b> : Object<div class="sub-desc">A listener config object specifiying event listeners in the format of an argument to {@link #addListener}</div></li> </ul></div> Example usage: <pre><code> tools:[{ id:'refresh', qtip: 'Refresh form Data', // hidden:true, handler: function(event, toolEl, panel){ // refresh logic } }] </code></pre> Note that apart from the toggle tool which is provided when a panel is collapsible, these tools only provide the visual button. Any required functionality must be provided by adding handlers that implement the necessary behavior.</summary>
		public System.Array tools { get { return (System.Array)this["tools"]; } set { this["tools"] = value; } }

		/// <summary>  True to hide the expand/collapse toggle button when {@link #collapsible} = true, false to display it (defaults to false).</summary>
		public bool hideCollapseTool { get { return (bool)this["hideCollapseTool"]; } set { this["hideCollapseTool"] = value; } }

		/// <summary>  True to allow expanding and collapsing the panel (when {@link #collapsible} = true) by clicking anywhere in the header bar, false to allow it only by clicking to tool button (defaults to false).</summary>
		public bool titleCollapse { get { return (bool)this["titleCollapse"]; } set { this["titleCollapse"] = value; } }

		/// <summary>  True to use overflow:'auto' on the panel's body element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).</summary>
		public bool autoScroll { get { return (bool)this["autoScroll"]; } set { this["autoScroll"] = value; } }

		/// <summary>  True to float the panel (absolute position it with automatic shimming and shadow), false to display it inline where it is rendered (defaults to false).  Note that by default, setting floating to true will cause the panel to display at negative offsets so that it is hidden -- because the panel is absolute positioned, the position must be set explicitly after render (e.g., myPanel.setPosition(100,100);).  Also, when floating a panel you should always assign a fixed width, otherwise it will be auto width and will expand to fill to the right edge of the viewport.</summary>
		public bool floating { get { return (bool)this["floating"]; } set { this["floating"] = value; } }

		/// <summary>{Boolean/String}  True (or a valid Ext.Shadow {@link Ext.Shadow#mode} value) to display a shadow behind the panel, false to display no shadow (defaults to 'sides').  Note that this option only applies when floating = true.</summary>
		public object shadow { get { return (object)this["shadow"]; } set { this["shadow"] = value; } }

		/// <summary>  The number of pixels to offset the shadow if displayed (defaults to 4). Note that this option only applies when floating = true.</summary>
		public double shadowOffset { get { return (double)this["shadowOffset"]; } set { this["shadowOffset"] = value; } }

		/// <summary>  False to disable the iframe shim in browsers which need one (defaults to true).  Note that this option only applies when floating = true.</summary>
		public bool shim { get { return (bool)this["shim"]; } set { this["shim"] = value; } }

		/// <summary>{String/Object}  An HTML fragment, or a {@link Ext.DomHelper DomHelper} specification to use as the panel's body content (defaults to '').</summary>
		public object html { get { return (object)this["html"]; } set { this["html"] = value; } }

		/// <summary>  The id of an existing HTML node to use as the panel's body content (defaults to '').</summary>
		public string contentEl { get { return (string)this["contentEl"]; } set { this["contentEl"] = value; } }

		/// <summary>{Object/Array}  A KeyMap config object (in the format expected by {@link Ext.KeyMap#addBinding} used to assign custom key handling to this panel (defaults to null).</summary>
		public object keys { get { return (object)this["keys"]; } set { this["keys"] = value; } }

		/// <summary>  Adds a tooltip when mousing over the tab of a Ext.Panel which is an item of a Ext.TabPanel. Ext.QuickTips.init() must be called in order for the tips to render.</summary>
		public string tabTip { get { return (string)this["tabTip"]; } set { this["tabTip"] = value; } }

		/// <summary>  Render this panel disabled (default is false). An important note when using the disabled config on panels is that IE will often fail to initialize the disabled mask element correectly if the panel's layout has not yet completed by the time the Panel is disabled during the render process. If you experience this issue, you may need to instead use the {@link afterlayout} event to initialize the disabled state: <pre><code> new Ext.Panel({ ... listeners: { 'afterlayout': { fn: function(p){ p.disable(); }, single: true // important, as many layouts can occur } } }); </code></pre></summary>
		public bool disabled { get { return (bool)this["disabled"]; } set { this["disabled"] = value; } }

		/// <summary>  A CSS class to add to the panel's element after it has been collapsed (defaults to 'x-panel-collapsed').</summary>
		public string collapsedCls { get { return (string)this["collapsedCls"]; } set { this["collapsedCls"] = value; } }

		/// <summary>  True to mask the panel when it is disabled, false to not mask it (defaults to true).  Either way, the panel will always tell its contained elements to disable themselves when it is disabled, but masking the panel can provide an additional visual cue that the panel is disabled.</summary>
		public bool maskDisabled { get { return (bool)this["maskDisabled"]; } set { this["maskDisabled"] = value; } }

		/// <summary>  True to animate the transition when the panel is collapsed, false to skip the animation (defaults to true if the {@link Ext.Fx} class is available, otherwise false).</summary>
		public bool animCollapse { get { return (bool)this["animCollapse"]; } set { this["animCollapse"] = value; } }

		/// <summary>  True to display the panel title in the header, false to hide it (defaults to true).</summary>
		public bool headerAsText { get { return (bool)this["headerAsText"]; } set { this["headerAsText"] = value; } }

		/// <summary>  The alignment of any buttons added to this panel.  Valid values are 'right,' 'left' and 'center' (defaults to 'right').</summary>
		public string buttonAlign { get { return (string)this["buttonAlign"]; } set { this["buttonAlign"] = value; } }

		/// <summary>  True to render the panel collapsed, false to render it expanded (defaults to false).</summary>
		public bool collapsed { get { return (bool)this["collapsed"]; } set { this["collapsed"] = value; } }

		/// <summary>  True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools in the panel's title bar, false to render it last (defaults to true).</summary>
		public bool collapseFirst { get { return (bool)this["collapseFirst"]; } set { this["collapseFirst"] = value; } }

		/// <summary>  Minimum width in pixels of all buttons in this panel (defaults to 75)</summary>
		public double minButtonWidth { get { return (double)this["minButtonWidth"]; } set { this["minButtonWidth"] = value; } }

		/// <summary> The default type of container represented by this object as registered in Ext.ComponentMgr (defaults to 'panel').</summary>
		public string defaultType { get { return (string)this["defaultType"]; } set { this["defaultType"] = value; } }

		/// <summary>  The layout type to be used in this container.  If not specified, a default {@link Ext.layout.ContainerLayout} will be created and used.  Valid values are: absolute, accordion, anchor, border, card, column, fit, form and table. Specific config values for the chosen layout type can be specified using {@link #layoutConfig}.</summary>
		public string layout { get { return (string)this["layout"]; } set { this["layout"] = value; } }

		/// <summary>  This is a config object containing properties specific to the chosen layout (to be used in conjunction with the {@link #layout} config value).  For complete details regarding the valid config options for each layout type, see the layout class corresponding to the type specified:<ul class="mdetail-params"> <li>{@link Ext.layout.Absolute}</li> <li>{@link Ext.layout.Accordion}</li> <li>{@link Ext.layout.AnchorLayout}</li> <li>{@link Ext.layout.BorderLayout}</li> <li>{@link Ext.layout.CardLayout}</li> <li>{@link Ext.layout.ColumnLayout}</li> <li>{@link Ext.layout.FitLayout}</li> <li>{@link Ext.layout.FormLayout}</li> <li>{@link Ext.layout.TableLayout}</li></ul></summary>
		public object layoutConfig { get { return (object)this["layoutConfig"]; } set { this["layoutConfig"] = value; } }

		/// <summary>{Boolean/Number}  When set to true (100 milliseconds) or a number of milliseconds, the layout assigned for this container will buffer the frequency it calculates and does a re-layout of components. This is useful for heavy containers or containers with a large quantity of sub-components for which frequent layout calls would be expensive.</summary>
		public object bufferResize { get { return (object)this["bufferResize"]; } set { this["bufferResize"] = value; } }

		/// <summary>{String/Number}  A string component id or the numeric index of the component that should be initially activated within the container's layout on render.  For example, activeItem: 'item-1' or activeItem: 0 (index 0 = the first item in the container's collection).  activeItem only applies to layout styles that can display items one at a time (like {@link Ext.layout.Accordion}, {@link Ext.layout.CardLayout} and {@link Ext.layout.FitLayout}).  Related to {@link Ext.layout.ContainerLayout#activeItem}.</summary>
		public object activeItem { get { return (object)this["activeItem"]; } set { this["activeItem"] = value; } }

		/// <summary>  A single item, or an array of child Components to be added to this container. Each item can be any type of object based on {@link Ext.Component}.<br><br> Component config objects may also be specified in order to avoid the overhead of constructing a real Component object if lazy rendering might mean that the added Component will not be rendered immediately. To take advantage of this "lazy instantiation", set the {@link Ext.Component#xtype} config property to the registered type of the Component wanted.<br><br> For a list of all available xtypes, see {@link Ext.Component}. If a single item is being passed, it should be passed directly as an object reference (e.g., items: {...}).  Multiple items should be passed as an array of objects (e.g., items: [{...}, {...}]).</summary>
		public object items { get { return (object)this["items"]; } set { this["items"] = value; } }

		/// <summary>  A config object that will be applied to all components added to this container either via the {@link #items} config or via the {@link #add} or {@link #insert} methods.  The defaults config can contain any number of name/value property pairs to be added to each item, and should be valid for the types of items being added to the container.  For example, to automatically apply padding to the body of each of a set of contained {@link Ext.Panel} items, you could pass: defaults: {bodyStyle:'padding:15px'}.</summary>
		public object defaults { get { return (object)this["defaults"]; } set { this["defaults"] = value; } }

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

		/// <summary>  An optional extra CSS class that will be added to this component's Element (defaults to '').  This can be useful for adding customized styles to the component or any of its children using standard CSS rules.</summary>
		public string cls { get { return (string)this["cls"]; } set { this["cls"] = value; } }

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

    public class WindowEvents {
        /// <summary>Fires after the window has been visually activated via {@link setActive}.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string activate { get { return "activate"; } }
        /// <summary>Fires after the window has been visually deactivated via {@link setActive}.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string deactivate { get { return "deactivate"; } }
        /// <summary>Fires after the window has been resized.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis, {Number} width, {Number} height)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>width</b></term><description>The window's new width</description></item>
        /// <item><term><b>height</b></term><description>The window's new height</description></item>
        /// </list>
        /// </summary>
        public static string resize { get { return "resize"; } }
        /// <summary>Fires after the window has been maximized.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string maximize { get { return "maximize"; } }
        /// <summary>Fires after the window has been minimized.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string minimize { get { return "minimize"; } }
        /// <summary>Fires after the window has been restored to its original size after being maximized.
        /// <pre><code>
        /// USAGE: ({Ext.Window} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string restore { get { return "restore"; } }
    }

    public delegate void WindowActivateDelegate(Ext.WindowClass objthis);
    public delegate void WindowDeactivateDelegate(Ext.WindowClass objthis);
    public delegate void WindowResizeDelegate(Ext.WindowClass objthis, double width, double height);
    public delegate void WindowMaximizeDelegate(Ext.WindowClass objthis);
    public delegate void WindowMinimizeDelegate(Ext.WindowClass objthis);
    public delegate void WindowRestoreDelegate(Ext.WindowClass objthis);
}
