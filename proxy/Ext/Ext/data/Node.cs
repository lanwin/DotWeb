using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.data {
	/// <summary>
	///     /**
	///     @cfg {Boolean} leaf true if this node is a leaf and does not have children
	///     @cfg {String} id The id for this node. If one is not specified, one is generated.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\data\Tree.js</jssource>
	public class Node : Ext.util.Observable {

		/// <summary></summary>
		/// <returns></returns>
		public extern Node();
		/// <summary></summary>
		/// <param name="attributes">The attributes/config for the node</param>
		/// <returns></returns>
		public extern Node(object attributes);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Ext.data.Node prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.Observable superclass { get; set; }

		/// <summary>The attributes supplied for the node. You can use this property to access any custom attributes you supplied.</summary>
		public extern object attributes { get; set; }

		/// <summary>The node id. @type String</summary>
		public extern object id { get; set; }

		/// <summary>All child nodes of this node. @type Array</summary>
		public extern object childNodes { get; set; }

		/// <summary>The parent node for this node. @type Node</summary>
		public extern object parentNode { get; set; }

		/// <summary>The first direct child node of this node, or null if this node has no child nodes. @type Node</summary>
		public extern object firstChild { get; set; }

		/// <summary>The last direct child node of this node, or null if this node has no child nodes. @type Node</summary>
		public extern object lastChild { get; set; }

		/// <summary>The node immediately preceding this node in the tree, or null if there is no sibling node. @type Node</summary>
		public extern object previousSibling { get; set; }

		/// <summary>The node immediately following this node in the tree, or null if there is no sibling node. @type Node</summary>
		public extern object nextSibling { get; set; }


		/// <summary>Returns true if this node is a leaf</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isLeaf();

		/// <summary>Returns true if this node is the last child of its parent</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isLast();

		/// <summary>Returns true if this node is the first child of its parent</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isFirst();

		/// <summary>Returns true if this node has one or more child nodes, else false.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void hasChildNodes();

		/// <summary>
		///     Returns true if this node has one or more child nodes, or if the <tt>expandable</tt>
		///     node attribute is explicitly specified as true (see {@link #attributes}), otherwise returns false.
		/// </summary>
		/// <returns>Boolean</returns>
		public extern virtual void isExpandable();

		/// <summary>Insert node(s) as the last child node of this node.</summary>
		/// <returns>Node</returns>
		public extern virtual void appendChild();

		/// <summary>Insert node(s) as the last child node of this node.</summary>
		/// <param name="node">The node or Array of nodes to append</param>
		/// <returns>Node</returns>
		public extern virtual void appendChild(Ext.data.Node node);

		/// <summary>Insert node(s) as the last child node of this node.</summary>
		/// <param name="node">The node or Array of nodes to append</param>
		/// <returns>Node</returns>
		public extern virtual void appendChild(System.Array node);

		/// <summary>Removes a child node from this node.</summary>
		/// <returns>Node</returns>
		public extern virtual void removeChild();

		/// <summary>Removes a child node from this node.</summary>
		/// <param name="node">The node to remove</param>
		/// <returns>Node</returns>
		public extern virtual void removeChild(Ext.data.Node node);

		/// <summary>Inserts the first node before the second node in this nodes childNodes collection.</summary>
		/// <returns>Node</returns>
		public extern virtual void insertBefore();

		/// <summary>Inserts the first node before the second node in this nodes childNodes collection.</summary>
		/// <param name="node">The node to insert</param>
		/// <returns>Node</returns>
		public extern virtual void insertBefore(Ext.data.Node node);

		/// <summary>Inserts the first node before the second node in this nodes childNodes collection.</summary>
		/// <param name="node">The node to insert</param>
		/// <param name="refNode">The node to insert before (if null the node is appended)</param>
		/// <returns>Node</returns>
		public extern virtual void insertBefore(Ext.data.Node node, Ext.data.Node refNode);

		/// <summary>Removes this node from it's parent</summary>
		/// <returns>Node</returns>
		public extern virtual void remove();

		/// <summary>Returns the child node at the specified index.</summary>
		/// <returns>Node</returns>
		public extern virtual void item();

		/// <summary>Returns the child node at the specified index.</summary>
		/// <param name="index"></param>
		/// <returns>Node</returns>
		public extern virtual void item(double index);

		/// <summary>Replaces one child node in this node with another.</summary>
		/// <returns>Node</returns>
		public extern virtual void replaceChild();

		/// <summary>Replaces one child node in this node with another.</summary>
		/// <param name="newChild">The replacement node</param>
		/// <returns>Node</returns>
		public extern virtual void replaceChild(Ext.data.Node newChild);

		/// <summary>Replaces one child node in this node with another.</summary>
		/// <param name="newChild">The replacement node</param>
		/// <param name="oldChild">The node to replace</param>
		/// <returns>Node</returns>
		public extern virtual void replaceChild(Ext.data.Node newChild, Ext.data.Node oldChild);

		/// <summary>Returns the index of a child node</summary>
		/// <returns>Number</returns>
		public extern virtual void indexOf();

		/// <summary>Returns the index of a child node</summary>
		/// <param name="node"></param>
		/// <returns>Number</returns>
		public extern virtual void indexOf(Ext.data.Node node);

		/// <summary>Returns the tree this node is in.</summary>
		/// <returns>Tree</returns>
		public extern virtual void getOwnerTree();

		/// <summary>Returns depth of this node (the root node has a depth of 0)</summary>
		/// <returns>Number</returns>
		public extern virtual void getDepth();

		/// <summary>Returns the path for this node. The path can be used to expand or select this node programmatically.</summary>
		/// <returns>String</returns>
		public extern virtual void getPath();

		/// <summary>Returns the path for this node. The path can be used to expand or select this node programmatically.</summary>
		/// <param name="attr">(optional) The attr to use for the path (defaults to the node's id)</param>
		/// <returns>String</returns>
		public extern virtual void getPath(string attr);

		/// <summary>
		///     Bubbles up the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <returns></returns>
		public extern virtual void bubble();

		/// <summary>
		///     Bubbles up the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn);

		/// <summary>
		///     Bubbles up the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn, object scope);

		/// <summary>
		///     Bubbles up the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <param name="args">(optional) The args to call the function with (default to passing the current node)</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn, object scope, System.Array args);

		/// <summary>
		///     Cascades down the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <returns></returns>
		public extern virtual void cascade();

		/// <summary>
		///     Cascades down the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn);

		/// <summary>
		///     Cascades down the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn, object scope);

		/// <summary>
		///     Cascades down the tree from this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <param name="args">(optional) The args to call the function with (default to passing the current node)</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn, object scope, System.Array args);

		/// <summary>
		///     Iterates the child nodes of this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the iteration stops.
		/// </summary>
		/// <returns></returns>
		public extern virtual void eachChild();

		/// <summary>
		///     Iterates the child nodes of this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the iteration stops.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern virtual void eachChild(Delegate fn);

		/// <summary>
		///     Iterates the child nodes of this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the iteration stops.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <returns></returns>
		public extern virtual void eachChild(Delegate fn, object scope);

		/// <summary>
		///     Iterates the child nodes of this node, calling the specified function with each node. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current node. The arguments to the function
		///     will be the args provided or the current node. If the function returns false at any point,
		///     the iteration stops.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <param name="args">(optional) The args to call the function with (default to passing the current node)</param>
		/// <returns></returns>
		public extern virtual void eachChild(Delegate fn, object scope, System.Array args);

		/// <summary>Finds the first child that has the attribute with the specified value.</summary>
		/// <returns>Node</returns>
		public extern virtual void findChild();

		/// <summary>Finds the first child that has the attribute with the specified value.</summary>
		/// <param name="attribute">The attribute name</param>
		/// <returns>Node</returns>
		public extern virtual void findChild(string attribute);

		/// <summary>Finds the first child that has the attribute with the specified value.</summary>
		/// <param name="attribute">The attribute name</param>
		/// <param name="value">The value to search for</param>
		/// <returns>Node</returns>
		public extern virtual void findChild(string attribute, object value);

		/// <summary>
		///     Finds the first child by a custom function. The child matches if the function passed
		///     returns true.
		/// </summary>
		/// <returns>Node</returns>
		public extern virtual void findChildBy();

		/// <summary>
		///     Finds the first child by a custom function. The child matches if the function passed
		///     returns true.
		/// </summary>
		/// <param name="fn"></param>
		/// <returns>Node</returns>
		public extern virtual void findChildBy(Delegate fn);

		/// <summary>
		///     Finds the first child by a custom function. The child matches if the function passed
		///     returns true.
		/// </summary>
		/// <param name="fn"></param>
		/// <param name="scope">(optional)</param>
		/// <returns>Node</returns>
		public extern virtual void findChildBy(Delegate fn, object scope);

		/// <summary>Sorts this nodes children using the supplied sort function</summary>
		/// <returns></returns>
		public extern virtual void sort();

		/// <summary>Sorts this nodes children using the supplied sort function</summary>
		/// <param name="fn"></param>
		/// <returns></returns>
		public extern virtual void sort(Delegate fn);

		/// <summary>Sorts this nodes children using the supplied sort function</summary>
		/// <param name="fn"></param>
		/// <param name="scope">(optional)</param>
		/// <returns></returns>
		public extern virtual void sort(Delegate fn, object scope);

		/// <summary>Returns true if this node is an ancestor (at any point) of the passed node.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void contains();

		/// <summary>Returns true if this node is an ancestor (at any point) of the passed node.</summary>
		/// <param name="node"></param>
		/// <returns>Boolean</returns>
		public extern virtual void contains(Ext.data.Node node);

		/// <summary>Returns true if the passed node is an ancestor (at any point) of this node.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isAncestor();

		/// <summary>Returns true if the passed node is an ancestor (at any point) of this node.</summary>
		/// <param name="node"></param>
		/// <returns>Boolean</returns>
		public extern virtual void isAncestor(Ext.data.Node node);



	}

	[JsAnonymous]
	public class NodeConfig : System.DotWeb.JsDynamic {
		/// <summary> true if this node is a leaf and does not have children</summary>
		public bool leaf { get { return (bool)this["leaf"]; } set { this["leaf"] = value; } }

		/// <summary> The id for this node. If one is not specified, one is generated.</summary>
		public string id { get { return (string)this["id"]; } set { this["id"] = value; } }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return (object)this["listeners"]; } set { this["listeners"] = value; } }

	}

    public class NodeEvents {
        /// <summary>Fires when a new child node is appended
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The newly appended node</description></item>
        /// <item><term><b>index</b></term><description>The index of the newly appended node</description></item>
        /// </list>
        /// </summary>
        public static string append { get { return "append"; } }
        /// <summary>Fires when a child node is removed
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The removed node</description></item>
        /// </list>
        /// </summary>
        public static string remove { get { return "remove"; } }
        /// <summary>Fires when this node is moved to a new location in the tree
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} oldParent, {Node} newParent, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>oldParent</b></term><description>The old parent of this node</description></item>
        /// <item><term><b>newParent</b></term><description>The new parent of this node</description></item>
        /// <item><term><b>index</b></term><description>The index it was moved to</description></item>
        /// </list>
        /// </summary>
        public static string move { get { return "move"; } }
        /// <summary>Fires when a new child node is inserted.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node, {Node} refNode)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The child node inserted</description></item>
        /// <item><term><b>refNode</b></term><description>The child node the node was inserted before</description></item>
        /// </list>
        /// </summary>
        public static string insert { get { return "insert"; } }
        /// <summary>Fires before a new child is appended, return false to cancel the append.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be appended</description></item>
        /// </list>
        /// </summary>
        public static string beforeappend { get { return "beforeappend"; } }
        /// <summary>Fires before a child is removed, return false to cancel the remove.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be removed</description></item>
        /// </list>
        /// </summary>
        public static string beforeremove { get { return "beforeremove"; } }
        /// <summary>Fires before this node is moved to a new location in the tree. Return false to cancel the move.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} oldParent, {Node} newParent, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>oldParent</b></term><description>The parent of this node</description></item>
        /// <item><term><b>newParent</b></term><description>The new parent this node is moving to</description></item>
        /// <item><term><b>index</b></term><description>The index it is being moved to</description></item>
        /// </list>
        /// </summary>
        public static string beforemove { get { return "beforemove"; } }
        /// <summary>Fires before a new child is inserted, return false to cancel the insert.
        /// <pre><code>
        /// USAGE: ({Tree} tree, {Node} objthis, {Node} node, {Node} refNode)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>tree</b></term><description>The owner tree</description></item>
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>node</b></term><description>The child node to be inserted</description></item>
        /// <item><term><b>refNode</b></term><description>The child node the node is being inserted before</description></item>
        /// </list>
        /// </summary>
        public static string beforeinsert { get { return "beforeinsert"; } }
    }

    public delegate void NodeAppendDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node, double index);
    public delegate void NodeRemoveDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node);
    public delegate void NodeMoveDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node oldParent, Ext.data.Node newParent, double index);
    public delegate void NodeInsertDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node, Ext.data.Node refNode);
    public delegate void NodeBeforeappendDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node);
    public delegate void NodeBeforeremoveDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node);
    public delegate void NodeBeforemoveDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node oldParent, Ext.data.Node newParent, double index);
    public delegate void NodeBeforeinsertDelegate(Ext.data.Tree tree, Ext.data.Node objthis, Ext.data.Node node, Ext.data.Node refNode);
}
