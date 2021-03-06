using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.data {
	/// <summary>
	///     /**
	///     Represents a tree data structure and bubbles all the events for its nodes. The nodes
	///     in the tree have most standard DOM functionality.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\data\Tree.js</jssource>
	public class Tree : Ext.util.Observable {

		/// <summary></summary>
		/// <returns></returns>
		public extern Tree();
		/// <summary></summary>
		/// <param name="root">(optional) The root node</param>
		/// <returns></returns>
		public extern Tree(Ext.data.Node root);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Ext.data.Tree prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.Observable superclass { get; set; }

		/// <summary>The root node for this tree</summary>
		public extern Ext.data.Node root { get; set; }

		/// <summary>The token used to separate paths in node ids (defaults to '/').</summary>
		public extern string pathSeparator { get; set; }


		/// <summary>Returns the root node for this tree.</summary>
		/// <returns>Node</returns>
		public extern virtual void getRootNode();

		/// <summary>Sets the root node for this tree.</summary>
		/// <returns>Node</returns>
		public extern virtual void setRootNode();

		/// <summary>Sets the root node for this tree.</summary>
		/// <param name="node"></param>
		/// <returns>Node</returns>
		public extern virtual void setRootNode(Ext.data.Node node);

		/// <summary>Gets a node in this tree by its id.</summary>
		/// <returns>Node</returns>
		public extern virtual void getNodeById();

		/// <summary>Gets a node in this tree by its id.</summary>
		/// <param name="id"></param>
		/// <returns>Node</returns>
		public extern virtual void getNodeById(string id);



	}

	[JsAnonymous]
	public class TreeConfig : System.DotWeb.JsDynamic {
		/// <summary>  The token used to separate paths in node ids (defaults to '/').</summary>
		public string pathSeparator { get { return (string)this["pathSeparator"]; } set { this["pathSeparator"] = value; } }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return (object)this["listeners"]; } set { this["listeners"] = value; } }

	}

    public class TreeEvents {
        /// <summary>Fires when a new child node is appended to a node in this tree.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The newly appended node</description></item>
        /// <item><term><b>index</b></term><description>The index of the newly appended node</description></item>
        /// </list>
        /// </summary>
        public static string append { get { return "append"; } }
        /// <summary>Fires when a child node is removed from a node in this tree.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The child node removed</description></item>
        /// </list>
        /// </summary>
        public static string remove { get { return "remove"; } }
        /// <summary>Fires when a node is moved to a new location in the tree
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} node, {Node} oldParent, {Node} newParent, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>node</b></term><description>The node moved</description></item>
        /// <item><term><b>oldParent</b></term><description>The old parent of this node</description></item>
        /// <item><term><b>newParent</b></term><description>The new parent of this node</description></item>
        /// <item><term><b>index</b></term><description>The index it was moved to</description></item>
        /// </list>
        /// </summary>
        public static string move { get { return "move"; } }
        /// <summary>Fires when a new child node is inserted in a node in this tree.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node, {Node} refNode)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The child node inserted</description></item>
        /// <item><term><b>refNode</b></term><description>The child node the node was inserted before</description></item>
        /// </list>
        /// </summary>
        public static string insert { get { return "insert"; } }
        /// <summary>Fires before a new child is appended to a node in this tree, return false to cancel the append.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be appended</description></item>
        /// </list>
        /// </summary>
        public static string beforeappend { get { return "beforeappend"; } }
        /// <summary>Fires before a child is removed from a node in this tree, return false to cancel the remove.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be removed</description></item>
        /// </list>
        /// </summary>
        public static string beforeremove { get { return "beforeremove"; } }
        /// <summary>Fires before a node is moved to a new location in the tree. Return false to cancel the move.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} node, {Node} oldParent, {Node} newParent, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>node</b></term><description>The node being moved</description></item>
        /// <item><term><b>oldParent</b></term><description>The parent of the node</description></item>
        /// <item><term><b>newParent</b></term><description>The new parent the node is moving to</description></item>
        /// <item><term><b>index</b></term><description>The index it is being moved to</description></item>
        /// </list>
        /// </summary>
        public static string beforemove { get { return "beforemove"; } }
        /// <summary>Fires before a new child is inserted in a node in this tree, return false to cancel the insert.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} parent, {Node} node, {Node} refNode)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>parent</b></term><description>The parent node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be inserted</description></item>
        /// <item><term><b>refNode</b></term><description>The child node the node is being inserted before</description></item>
        /// </list>
        /// </summary>
        public static string beforeinsert { get { return "beforeinsert"; } }
    }

    public delegate void TreeAppendDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node, double index);
    public delegate void TreeRemoveDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node);
    public delegate void TreeMoveDelegate(Ext.data.Tree tree, Ext.data.Node node, Ext.data.Node oldParent, Ext.data.Node newParent, double index);
    public delegate void TreeInsertDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node, Ext.data.Node refNode);
    public delegate void TreeBeforeappendDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node);
    public delegate void TreeBeforeremoveDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node);
    public delegate void TreeBeforemoveDelegate(Ext.data.Tree tree, Ext.data.Node node, Ext.data.Node oldParent, Ext.data.Node newParent, double index);
    public delegate void TreeBeforeinsertDelegate(Ext.data.Tree tree, Ext.data.Node parent, Ext.data.Node node, Ext.data.Node refNode);
}
