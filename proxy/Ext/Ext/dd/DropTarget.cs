using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.dd {
	/// <summary>
	///     /**
	///     A simple class that provides the basic implementation needed to make any element a drop target that can have
	///     draggable items dropped onto it.  The drop has no effect until an implementation of notifyDrop is provided.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\dd\DropTarget.js</jssource>
	public class DropTarget : Ext.dd.DDTarget {

		/// <summary></summary>
		/// <returns></returns>
		public extern DropTarget();
		/// <summary></summary>
		/// <param name="el">The container element</param>
		/// <returns></returns>
		public extern DropTarget(object el);
		/// <summary></summary>
		/// <param name="el">The container element</param>
		/// <param name="config"></param>
		/// <returns></returns>
		public extern DropTarget(object el, object config);
		/// <summary>
		///     Valid properties for DDTarget in addition to those in
		///     DragDrop:
		///     none
		/// </summary>
		/// <param name="id">the id of the element that is a drop target</param>
		/// <returns></returns>
		public extern DropTarget(string id);
		/// <summary>
		///     Valid properties for DDTarget in addition to those in
		///     DragDrop:
		///     none
		/// </summary>
		/// <param name="id">the id of the element that is a drop target</param>
		/// <param name="sGroup">the group of related DragDrop objects</param>
		/// <returns></returns>
		public extern DropTarget(string id, string sGroup);
		/// <summary>
		///     Valid properties for DDTarget in addition to those in
		///     DragDrop:
		///     none
		/// </summary>
		/// <param name="id">the id of the element that is a drop target</param>
		/// <param name="sGroup">the group of related DragDrop objects</param>
		/// <param name="config">an object containing configurable attributes</param>
		/// <returns></returns>
		public extern DropTarget(string id, string sGroup, object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static DropTarget prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.dd.DDTarget superclass { get; set; }

		/// <summary>
		///     A named drag drop group to which this object belongs.  If a group is specified, then this object will only
		///     interact with other drag drop objects in the same group (defaults to undefined).
		/// </summary>
		public extern string ddGroup { get; set; }

		/// <summary>The CSS class applied to the drop target element while the drag source is over it (defaults to "").</summary>
		public extern string overClass { get; set; }

		/// <summary>The CSS class returned to the drag source when drop is allowed (defaults to "x-dd-drop-ok").</summary>
		public extern string dropAllowed { get; set; }

		/// <summary>The CSS class returned to the drag source when drop is not allowed (defaults to "x-dd-drop-nodrop").</summary>
		public extern string dropNotAllowed { get; set; }


		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source is now over the
		///     target.  This default implementation adds the CSS class specified by overClass (if any) to the drop element
		///     and returns the dropAllowed config value.  This method should be overridden if drop validation is required.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <returns>String</returns>
		public extern virtual void notifyEnter();

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source is now over the
		///     target.  This default implementation adds the CSS class specified by overClass (if any) to the drop element
		///     and returns the dropAllowed config value.  This method should be overridden if drop validation is required.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <returns>String</returns>
		public extern virtual void notifyEnter(Ext.dd.DragSource source);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source is now over the
		///     target.  This default implementation adds the CSS class specified by overClass (if any) to the drop element
		///     and returns the dropAllowed config value.  This method should be overridden if drop validation is required.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <returns>String</returns>
		public extern virtual void notifyEnter(Ext.dd.DragSource source, Event e);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source is now over the
		///     target.  This default implementation adds the CSS class specified by overClass (if any) to the drop element
		///     and returns the dropAllowed config value.  This method should be overridden if drop validation is required.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <param name="data">An object containing arbitrary data supplied by the drag source</param>
		/// <returns>String</returns>
		public extern virtual void notifyEnter(Ext.dd.DragSource source, Event e, object data);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls continuously while it is being dragged over the target.
		///     This method will be called on every mouse movement while the drag source is over the drop target.
		///     This default implementation simply returns the dropAllowed config value.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <returns>String</returns>
		public extern virtual void notifyOver();

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls continuously while it is being dragged over the target.
		///     This method will be called on every mouse movement while the drag source is over the drop target.
		///     This default implementation simply returns the dropAllowed config value.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <returns>String</returns>
		public extern virtual void notifyOver(Ext.dd.DragSource source);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls continuously while it is being dragged over the target.
		///     This method will be called on every mouse movement while the drag source is over the drop target.
		///     This default implementation simply returns the dropAllowed config value.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <returns>String</returns>
		public extern virtual void notifyOver(Ext.dd.DragSource source, Event e);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls continuously while it is being dragged over the target.
		///     This method will be called on every mouse movement while the drag source is over the drop target.
		///     This default implementation simply returns the dropAllowed config value.
		///     underlying {@link Ext.dd.StatusProxy} can be updated
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <param name="data">An object containing arbitrary data supplied by the drag source</param>
		/// <returns>String</returns>
		public extern virtual void notifyOver(Ext.dd.DragSource source, Event e, object data);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source has been dragged
		///     out of the target without dropping.  This default implementation simply removes the CSS class specified by
		///     overClass (if any) from the drop element.
		/// </summary>
		/// <returns></returns>
		public extern virtual void notifyOut();

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source has been dragged
		///     out of the target without dropping.  This default implementation simply removes the CSS class specified by
		///     overClass (if any) from the drop element.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <returns></returns>
		public extern virtual void notifyOut(Ext.dd.DragSource source);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source has been dragged
		///     out of the target without dropping.  This default implementation simply removes the CSS class specified by
		///     overClass (if any) from the drop element.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <returns></returns>
		public extern virtual void notifyOut(Ext.dd.DragSource source, Event e);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the source has been dragged
		///     out of the target without dropping.  This default implementation simply removes the CSS class specified by
		///     overClass (if any) from the drop element.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <param name="data">An object containing arbitrary data supplied by the drag source</param>
		/// <returns></returns>
		public extern virtual void notifyOut(Ext.dd.DragSource source, Event e, object data);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the dragged item has
		///     been dropped on it.  This method has no default implementation and returns false, so you must provide an
		///     implementation that does something to process the drop event and returns true so that the drag source's
		///     repair action does not run.
		/// </summary>
		/// <returns>Boolean</returns>
		public extern virtual void notifyDrop();

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the dragged item has
		///     been dropped on it.  This method has no default implementation and returns false, so you must provide an
		///     implementation that does something to process the drop event and returns true so that the drag source's
		///     repair action does not run.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <returns>Boolean</returns>
		public extern virtual void notifyDrop(Ext.dd.DragSource source);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the dragged item has
		///     been dropped on it.  This method has no default implementation and returns false, so you must provide an
		///     implementation that does something to process the drop event and returns true so that the drag source's
		///     repair action does not run.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <returns>Boolean</returns>
		public extern virtual void notifyDrop(Ext.dd.DragSource source, Event e);

		/// <summary>
		///     The function a {@link Ext.dd.DragSource} calls once to notify this drop target that the dragged item has
		///     been dropped on it.  This method has no default implementation and returns false, so you must provide an
		///     implementation that does something to process the drop event and returns true so that the drag source's
		///     repair action does not run.
		/// </summary>
		/// <param name="source">The drag source that was dragged over this drop target</param>
		/// <param name="e">The event</param>
		/// <param name="data">An object containing arbitrary data supplied by the drag source</param>
		/// <returns>Boolean</returns>
		public extern virtual void notifyDrop(Ext.dd.DragSource source, Event e, object data);



	}

	[JsAnonymous]
	public class DropTargetConfig : System.DotWeb.JsDynamic {
		/// <summary>  A named drag drop group to which this object belongs.  If a group is specified, then this object will only interact with other drag drop objects in the same group (defaults to undefined).</summary>
		public string ddGroup { get { return (string)this["ddGroup"]; } set { this["ddGroup"] = value; } }

		/// <summary>  The CSS class applied to the drop target element while the drag source is over it (defaults to "").</summary>
		public string overClass { get { return (string)this["overClass"]; } set { this["overClass"] = value; } }

		/// <summary>  The CSS class returned to the drag source when drop is allowed (defaults to "x-dd-drop-ok").</summary>
		public string dropAllowed { get { return (string)this["dropAllowed"]; } set { this["dropAllowed"] = value; } }

		/// <summary>  The CSS class returned to the drag source when drop is not allowed (defaults to "x-dd-drop-nodrop").</summary>
		public string dropNotAllowed { get { return (string)this["dropNotAllowed"]; } set { this["dropNotAllowed"] = value; } }

	}
}
