using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.util {
	/// <summary>
	///     /**
	///     A Collection class that maintains both numeric indexes and keys and exposes events.
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\util\MixedCollection.js</jssource>
	public class MixedCollection : Ext.util.Observable {

		/// <summary>
		///     collection (defaults to false)
		///     and return the key value for that item.  This is used when available to look up the key on items that
		///     were passed without an explicit key parameter to a MixedCollection method.  Passing this parameter is
		///     equivalent to providing an implementation for the {@link #getKey} method.
		/// </summary>
		/// <returns></returns>
		public extern MixedCollection();
		/// <summary>
		///     collection (defaults to false)
		///     and return the key value for that item.  This is used when available to look up the key on items that
		///     were passed without an explicit key parameter to a MixedCollection method.  Passing this parameter is
		///     equivalent to providing an implementation for the {@link #getKey} method.
		/// </summary>
		/// <param name="allowFunctions">True if the addAll function should add function references to the</param>
		/// <returns></returns>
		public extern MixedCollection(bool allowFunctions);
		/// <summary>
		///     collection (defaults to false)
		///     and return the key value for that item.  This is used when available to look up the key on items that
		///     were passed without an explicit key parameter to a MixedCollection method.  Passing this parameter is
		///     equivalent to providing an implementation for the {@link #getKey} method.
		/// </summary>
		/// <param name="allowFunctions">True if the addAll function should add function references to the</param>
		/// <param name="keyFn">A function that can accept an item of the type(s) stored in this MixedCollection</param>
		/// <returns></returns>
		public extern MixedCollection(bool allowFunctions, Delegate keyFn);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Ext.util.MixedCollection prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.Observable superclass { get; set; }


		/// <summary>
		///     Adds an item to the collection. Fires the {@link #add} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key for the new item. In this case just pass the new item in
		///     this parameter.</p>
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void add();

		/// <summary>
		///     Adds an item to the collection. Fires the {@link #add} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key for the new item. In this case just pass the new item in
		///     this parameter.</p>
		/// </summary>
		/// <param name="key"><p>The key to associate with the item, or the new item.</p></param>
		/// <returns>Object</returns>
		public extern virtual void add(string key);

		/// <summary>
		///     Adds an item to the collection. Fires the {@link #add} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key for the new item. In this case just pass the new item in
		///     this parameter.</p>
		/// </summary>
		/// <param name="key"><p>The key to associate with the item, or the new item.</p></param>
		/// <param name="o">The item to add.</param>
		/// <returns>Object</returns>
		public extern virtual void add(string key, object o);

		/// <summary>
		///     MixedCollection has a generic way to fetch keys if you implement getKey.  The default implementation
		///     simply returns <tt style="font-weight:bold;">item.id</tt> but you can provide your own implementation
		///     to return a different value as in the following examples:
		///     <pre><code>
		///     // normal way
		///     var mc = new Ext.util.MixedCollection();
		///     mc.add(someEl.dom.id, someEl);
		///     mc.add(otherEl.dom.id, otherEl);
		///     //and so on
		///     // using getKey
		///     var mc = new Ext.util.MixedCollection();
		///     mc.getKey = function(el){
		///     return el.dom.id;
		///     };
		///     mc.add(someEl);
		///     mc.add(otherEl);
		///     // or via the constructor
		///     var mc = new Ext.util.MixedCollection(false, function(el){
		///     return el.dom.id;
		///     });
		///     mc.add(someEl);
		///     mc.add(otherEl);
		///     </code></pre>
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void getKey();

		/// <summary>
		///     MixedCollection has a generic way to fetch keys if you implement getKey.  The default implementation
		///     simply returns <tt style="font-weight:bold;">item.id</tt> but you can provide your own implementation
		///     to return a different value as in the following examples:
		///     <pre><code>
		///     // normal way
		///     var mc = new Ext.util.MixedCollection();
		///     mc.add(someEl.dom.id, someEl);
		///     mc.add(otherEl.dom.id, otherEl);
		///     //and so on
		///     // using getKey
		///     var mc = new Ext.util.MixedCollection();
		///     mc.getKey = function(el){
		///     return el.dom.id;
		///     };
		///     mc.add(someEl);
		///     mc.add(otherEl);
		///     // or via the constructor
		///     var mc = new Ext.util.MixedCollection(false, function(el){
		///     return el.dom.id;
		///     });
		///     mc.add(someEl);
		///     mc.add(otherEl);
		///     </code></pre>
		/// </summary>
		/// <param name="item">The item for which to find the key.</param>
		/// <returns>Object</returns>
		public extern virtual void getKey(object item);

		/// <summary>
		///     Replaces an item in the collection. Fires the {@link #replace} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key of the replacement item. If you want to replace an item
		///     with one having the same key value, then just pass the replacement item in this parameter.</p>
		///     with that key.
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void replace();

		/// <summary>
		///     Replaces an item in the collection. Fires the {@link #replace} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key of the replacement item. If you want to replace an item
		///     with one having the same key value, then just pass the replacement item in this parameter.</p>
		///     with that key.
		/// </summary>
		/// <param name="key"><p>The key associated with the item to replace, or the replacement item.</p></param>
		/// <returns>Object</returns>
		public extern virtual void replace(string key);

		/// <summary>
		///     Replaces an item in the collection. Fires the {@link #replace} event when complete.
		///     <p>If you supplied a {@link #getKey} implementation for this MixedCollection, or if the key
		///     of your stored items is in a property called <tt><b>id</b></tt>, then the MixedCollection
		///     will be able to <i>derive</i> the key of the replacement item. If you want to replace an item
		///     with one having the same key value, then just pass the replacement item in this parameter.</p>
		///     with that key.
		/// </summary>
		/// <param name="key"><p>The key associated with the item to replace, or the replacement item.</p></param>
		/// <param name="o">{Object} o (optional) If the first parameter passed was a key, the item to associate</param>
		/// <returns>Object</returns>
		public extern virtual void replace(string key, object o);

		/// <summary>
		///     Adds all elements of an Array or an Object to the collection.
		///     an Array of values, each of which are added to the collection.
		/// </summary>
		/// <returns></returns>
		public extern virtual void addAll();

		/// <summary>
		///     Adds all elements of an Array or an Object to the collection.
		///     an Array of values, each of which are added to the collection.
		/// </summary>
		/// <param name="objs">An Object containing properties which will be added to the collection, or</param>
		/// <returns></returns>
		public extern virtual void addAll(object objs);

		/// <summary>
		///     Adds all elements of an Array or an Object to the collection.
		///     an Array of values, each of which are added to the collection.
		/// </summary>
		/// <param name="objs">An Object containing properties which will be added to the collection, or</param>
		/// <returns></returns>
		public extern virtual void addAll(System.Array objs);

		/// <summary>
		///     Executes the specified function once for every item in the collection, passing the following arguments:
		///     <div class="mdetail-params"><ul>
		///     <li><b>item</b> : Mixed<p class="sub-desc">The collection item</p></li>
		///     <li><b>index</b> : Number<p class="sub-desc">The item's index</p></li>
		///     <li><b>length</b> : Number<p class="sub-desc">The total number of items in the collection</p></li>
		///     </ul></div>
		///     The function should return a boolean value. Returning false from the function will stop the iteration.
		/// </summary>
		/// <returns></returns>
		public extern virtual void each();

		/// <summary>
		///     Executes the specified function once for every item in the collection, passing the following arguments:
		///     <div class="mdetail-params"><ul>
		///     <li><b>item</b> : Mixed<p class="sub-desc">The collection item</p></li>
		///     <li><b>index</b> : Number<p class="sub-desc">The item's index</p></li>
		///     <li><b>length</b> : Number<p class="sub-desc">The total number of items in the collection</p></li>
		///     </ul></div>
		///     The function should return a boolean value. Returning false from the function will stop the iteration.
		/// </summary>
		/// <param name="fn">The function to execute for each item.</param>
		/// <returns></returns>
		public extern virtual void each(Delegate fn);

		/// <summary>
		///     Executes the specified function once for every item in the collection, passing the following arguments:
		///     <div class="mdetail-params"><ul>
		///     <li><b>item</b> : Mixed<p class="sub-desc">The collection item</p></li>
		///     <li><b>index</b> : Number<p class="sub-desc">The item's index</p></li>
		///     <li><b>length</b> : Number<p class="sub-desc">The total number of items in the collection</p></li>
		///     </ul></div>
		///     The function should return a boolean value. Returning false from the function will stop the iteration.
		/// </summary>
		/// <param name="fn">The function to execute for each item.</param>
		/// <param name="scope">(optional) The scope in which to execute the function.</param>
		/// <returns></returns>
		public extern virtual void each(Delegate fn, object scope);

		/// <summary>
		///     Executes the specified function once for every key in the collection, passing each
		///     key, and its associated item as the first two parameters.
		/// </summary>
		/// <returns></returns>
		public extern virtual void eachKey();

		/// <summary>
		///     Executes the specified function once for every key in the collection, passing each
		///     key, and its associated item as the first two parameters.
		/// </summary>
		/// <param name="fn">The function to execute for each item.</param>
		/// <returns></returns>
		public extern virtual void eachKey(Delegate fn);

		/// <summary>
		///     Executes the specified function once for every key in the collection, passing each
		///     key, and its associated item as the first two parameters.
		/// </summary>
		/// <param name="fn">The function to execute for each item.</param>
		/// <param name="scope">(optional) The scope in which to execute the function.</param>
		/// <returns></returns>
		public extern virtual void eachKey(Delegate fn, object scope);

		/// <summary>
		///     Returns the first item in the collection which elicits a true return value from the
		///     passed selection function.
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void find();

		/// <summary>
		///     Returns the first item in the collection which elicits a true return value from the
		///     passed selection function.
		/// </summary>
		/// <param name="fn">The selection function to execute for each item.</param>
		/// <returns>Object</returns>
		public extern virtual void find(Delegate fn);

		/// <summary>
		///     Returns the first item in the collection which elicits a true return value from the
		///     passed selection function.
		/// </summary>
		/// <param name="fn">The selection function to execute for each item.</param>
		/// <param name="scope">(optional) The scope in which to execute the function.</param>
		/// <returns>Object</returns>
		public extern virtual void find(Delegate fn, object scope);

		/// <summary>Inserts an item at the specified index in the collection. Fires the {@link #add} event when complete.</summary>
		/// <returns>Object</returns>
		public extern virtual void insert();

		/// <summary>Inserts an item at the specified index in the collection. Fires the {@link #add} event when complete.</summary>
		/// <param name="index">The index to insert the item at.</param>
		/// <returns>Object</returns>
		public extern virtual void insert(double index);

		/// <summary>Inserts an item at the specified index in the collection. Fires the {@link #add} event when complete.</summary>
		/// <param name="index">The index to insert the item at.</param>
		/// <param name="key">The key to associate with the new item, or the item itself.</param>
		/// <returns>Object</returns>
		public extern virtual void insert(double index, string key);

		/// <summary>Inserts an item at the specified index in the collection. Fires the {@link #add} event when complete.</summary>
		/// <param name="index">The index to insert the item at.</param>
		/// <param name="key">The key to associate with the new item, or the item itself.</param>
		/// <param name="o">(optional) If the second parameter was a key, the new item.</param>
		/// <returns>Object</returns>
		public extern virtual void insert(double index, string key, object o);

		/// <summary>Remove an item from the collection.</summary>
		/// <returns>Object</returns>
		public extern virtual void remove();

		/// <summary>Remove an item from the collection.</summary>
		/// <param name="o">The item to remove.</param>
		/// <returns>Object</returns>
		public extern virtual void remove(object o);

		/// <summary>Remove an item from a specified index in the collection. Fires the {@link #remove} event when complete.</summary>
		/// <returns>Object</returns>
		public extern virtual void removeAt();

		/// <summary>Remove an item from a specified index in the collection. Fires the {@link #remove} event when complete.</summary>
		/// <param name="index">The index within the collection of the item to remove.</param>
		/// <returns>Object</returns>
		public extern virtual void removeAt(double index);

		/// <summary>Removed an item associated with the passed key fom the collection.</summary>
		/// <returns>Object</returns>
		public extern virtual void removeKey();

		/// <summary>Removed an item associated with the passed key fom the collection.</summary>
		/// <param name="key">The key of the item to remove.</param>
		/// <returns>Object</returns>
		public extern virtual void removeKey(string key);

		/// <summary>Returns the number of items in the collection.</summary>
		/// <returns>Number</returns>
		public extern virtual void getCount();

		/// <summary>Returns index within the collection of the passed Object.</summary>
		/// <returns>Number</returns>
		public extern virtual void indexOf();

		/// <summary>Returns index within the collection of the passed Object.</summary>
		/// <param name="o">The item to find the index of.</param>
		/// <returns>Number</returns>
		public extern virtual void indexOf(object o);

		/// <summary>Returns index within the collection of the passed key.</summary>
		/// <returns>Number</returns>
		public extern virtual void indexOfKey();

		/// <summary>Returns index within the collection of the passed key.</summary>
		/// <param name="key">The key to find the index of.</param>
		/// <returns>Number</returns>
		public extern virtual void indexOfKey(string key);

		/// <summary>
		///     Returns the item associated with the passed key OR index. Key has priority over index.  This is the equivalent
		///     of calling {@link #key} first, then if nothing matched calling {@link #itemAt}.
		/// </summary>
		/// <returns>Object</returns>
		public extern virtual void item();

		/// <summary>
		///     Returns the item associated with the passed key OR index. Key has priority over index.  This is the equivalent
		///     of calling {@link #key} first, then if nothing matched calling {@link #itemAt}.
		/// </summary>
		/// <param name="key">The key or index of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void item(string key);

		/// <summary>
		///     Returns the item associated with the passed key OR index. Key has priority over index.  This is the equivalent
		///     of calling {@link #key} first, then if nothing matched calling {@link #itemAt}.
		/// </summary>
		/// <param name="key">The key or index of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void item(double key);

		/// <summary>Returns the item at the specified index.</summary>
		/// <returns>Object</returns>
		public extern virtual void itemAt();

		/// <summary>Returns the item at the specified index.</summary>
		/// <param name="index">The index of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void itemAt(double index);

		/// <summary>Returns the item associated with the passed key.</summary>
		/// <returns>Object</returns>
		public extern virtual void key();

		/// <summary>Returns the item associated with the passed key.</summary>
		/// <param name="key">The key of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void key(string key);

		/// <summary>Returns the item associated with the passed key.</summary>
		/// <param name="key">The key of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void key(double key);

		/// <summary>Returns true if the collection contains the passed Object as an item.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void contains();

		/// <summary>Returns true if the collection contains the passed Object as an item.</summary>
		/// <param name="o">The Object to look for in the collection.</param>
		/// <returns>Boolean</returns>
		public extern virtual void contains(object o);

		/// <summary>Returns true if the collection contains the passed Object as a key.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void containsKey();

		/// <summary>Returns true if the collection contains the passed Object as a key.</summary>
		/// <param name="key">The key to look for in the collection.</param>
		/// <returns>Boolean</returns>
		public extern virtual void containsKey(string key);

		/// <summary>Removes all items from the collection.  Fires the {@link #clear} event when complete.</summary>
		/// <returns></returns>
		public extern virtual void clear();

		/// <summary>Returns the first item in the collection.</summary>
		/// <returns>Object</returns>
		public extern virtual void first();

		/// <summary>Returns the last item in the collection.</summary>
		/// <returns>Object</returns>
		public extern virtual void last();

		/// <summary>Sorts this collection with the passed comparison function</summary>
		/// <returns></returns>
		public extern virtual void sort();

		/// <summary>Sorts this collection with the passed comparison function</summary>
		/// <param name="direction">(optional) "ASC" or "DESC"</param>
		/// <returns></returns>
		public extern virtual void sort(string direction);

		/// <summary>Sorts this collection with the passed comparison function</summary>
		/// <param name="direction">(optional) "ASC" or "DESC"</param>
		/// <param name="fn">(optional) comparison function</param>
		/// <returns></returns>
		public extern virtual void sort(string direction, Delegate fn);

		/// <summary>Sorts this collection by keys</summary>
		/// <returns></returns>
		public extern virtual void keySort();

		/// <summary>Sorts this collection by keys</summary>
		/// <param name="direction">(optional) "ASC" or "DESC"</param>
		/// <returns></returns>
		public extern virtual void keySort(string direction);

		/// <summary>Sorts this collection by keys</summary>
		/// <param name="direction">(optional) "ASC" or "DESC"</param>
		/// <param name="fn">(optional) a comparison function (defaults to case insensitive string)</param>
		/// <returns></returns>
		public extern virtual void keySort(string direction, Delegate fn);

		/// <summary>Returns a range of items in this collection</summary>
		/// <returns>Array</returns>
		public extern virtual void getRange();

		/// <summary>Returns a range of items in this collection</summary>
		/// <param name="startIndex">(optional) defaults to 0</param>
		/// <returns>Array</returns>
		public extern virtual void getRange(double startIndex);

		/// <summary>Returns a range of items in this collection</summary>
		/// <param name="startIndex">(optional) defaults to 0</param>
		/// <param name="endIndex">(optional) default to the last item</param>
		/// <returns>Array</returns>
		public extern virtual void getRange(double startIndex, double endIndex);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter();

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, string value);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, string value, bool anyMatch);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning</param>
		/// <param name="caseSensitive">(optional) True for case sensitive comparison (defaults to False).</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, string value, bool anyMatch, bool caseSensitive);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, object value);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, object value, bool anyMatch);

		/// <summary>
		///     Filter the <i>objects</i> in this collection by a specific property.
		///     Returns a new collection that has been filtered.
		///     should start with or a RegExp to test against the property
		/// </summary>
		/// <param name="property">A property on your objects</param>
		/// <param name="value">Either string that the property values</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning</param>
		/// <param name="caseSensitive">(optional) True for case sensitive comparison (defaults to False).</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filter(string property, object value, bool anyMatch, bool caseSensitive);

		/// <summary>
		///     Filter by a function. Returns a <i>new</i> collection that has been filtered.
		///     The passed function will be called with each object in the collection.
		///     If the function returns true, the value is included otherwise it is filtered.
		/// </summary>
		/// <returns>MixedCollection</returns>
		public extern virtual void filterBy();

		/// <summary>
		///     Filter by a function. Returns a <i>new</i> collection that has been filtered.
		///     The passed function will be called with each object in the collection.
		///     If the function returns true, the value is included otherwise it is filtered.
		/// </summary>
		/// <param name="fn">The function to be called, it will receive the args o (the object), k (the key)</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filterBy(Delegate fn);

		/// <summary>
		///     Filter by a function. Returns a <i>new</i> collection that has been filtered.
		///     The passed function will be called with each object in the collection.
		///     If the function returns true, the value is included otherwise it is filtered.
		/// </summary>
		/// <param name="fn">The function to be called, it will receive the args o (the object), k (the key)</param>
		/// <param name="scope">(optional) The scope of the function (defaults to this)</param>
		/// <returns>MixedCollection</returns>
		public extern virtual void filterBy(Delegate fn, object scope);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <returns>Number</returns>
		public extern virtual void findIndex();

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, string value);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, string value, double start);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning.</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, string value, double start, bool anyMatch);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning.</param>
		/// <param name="caseSensitive">(optional) True for case sensitive comparison.</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, string value, double start, bool anyMatch, bool caseSensitive);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, object value);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, object value, double start);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning.</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, object value, double start, bool anyMatch);

		/// <summary>
		///     Finds the index of the first matching object in this collection by a specific property/value.
		///     should start with or a RegExp to test against the property.
		/// </summary>
		/// <param name="property">The name of a property on your objects.</param>
		/// <param name="value">A string that the property values</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <param name="anyMatch">(optional) True to match any part of the string, not just the beginning.</param>
		/// <param name="caseSensitive">(optional) True for case sensitive comparison.</param>
		/// <returns>Number</returns>
		public extern virtual void findIndex(string property, object value, double start, bool anyMatch, bool caseSensitive);

		/// <summary>
		///     Find the index of the first matching object in this collection by a function.
		///     If the function returns <i>true</i> it is considered a match.
		/// </summary>
		/// <returns>Number</returns>
		public extern virtual void findIndexBy();

		/// <summary>
		///     Find the index of the first matching object in this collection by a function.
		///     If the function returns <i>true</i> it is considered a match.
		/// </summary>
		/// <param name="fn">The function to be called, it will receive the args o (the object), k (the key).</param>
		/// <returns>Number</returns>
		public extern virtual void findIndexBy(Delegate fn);

		/// <summary>
		///     Find the index of the first matching object in this collection by a function.
		///     If the function returns <i>true</i> it is considered a match.
		/// </summary>
		/// <param name="fn">The function to be called, it will receive the args o (the object), k (the key).</param>
		/// <param name="scope">(optional) The scope of the function (defaults to this).</param>
		/// <returns>Number</returns>
		public extern virtual void findIndexBy(Delegate fn, object scope);

		/// <summary>
		///     Find the index of the first matching object in this collection by a function.
		///     If the function returns <i>true</i> it is considered a match.
		/// </summary>
		/// <param name="fn">The function to be called, it will receive the args o (the object), k (the key).</param>
		/// <param name="scope">(optional) The scope of the function (defaults to this).</param>
		/// <param name="start">(optional) The index to start searching at (defaults to 0).</param>
		/// <returns>Number</returns>
		public extern virtual void findIndexBy(Delegate fn, object scope, double start);

		/// <summary>Creates a duplicate of this collection</summary>
		/// <returns>MixedCollection</returns>
		public extern virtual void clone();

		/// <summary>Returns the item associated with the passed key or index.</summary>
		/// <returns>Object</returns>
		public extern virtual void get();

		/// <summary>Returns the item associated with the passed key or index.</summary>
		/// <param name="key">The key or index of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void get(string key);

		/// <summary>Returns the item associated with the passed key or index.</summary>
		/// <param name="key">The key or index of the item.</param>
		/// <returns>Object</returns>
		public extern virtual void get(double key);



	}

	[JsAnonymous]
	public class MixedCollectionConfig : System.DotWeb.JsDynamic {
		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public object listeners { get { return (object)this["listeners"]; } set { this["listeners"] = value; } }

	}

    public class MixedCollectionEvents {
        /// <summary>Fires when the collection is cleared.
        /// <pre><code>
        /// USAGE: ()
        /// </code></pre>
        /// <list type="bullet">
        /// </list>
        /// </summary>
        public static string clear { get { return "clear"; } }
        /// <summary>Fires when an item is added to the collection.
        /// <pre><code>
        /// USAGE: ({Number} index, {Object} o, {String} key)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>index</b></term><description>The index at which the item was added.</description></item>
        /// <item><term><b>o</b></term><description>The item added.</description></item>
        /// <item><term><b>key</b></term><description>The key associated with the added item.</description></item>
        /// </list>
        /// </summary>
        public static string add { get { return "add"; } }
        /// <summary>Fires when an item is replaced in the collection.
        /// <pre><code>
        /// USAGE: ({String} key, {Object} old, {Object} newItem)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>key</b></term><description>he key associated with the new added.</description></item>
        /// <item><term><b>old</b></term><description>The item being replaced.</description></item>
        /// <item><term><b>newItem</b></term><description>The new item.</description></item>
        /// </list>
        /// </summary>
        public static string replace { get { return "replace"; } }
        /// <summary>Fires when an item is removed from the collection.
        /// <pre><code>
        /// USAGE: ({Object} o, {String} key)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>o</b></term><description>The item being removed.</description></item>
        /// <item><term><b>key</b></term><description>(optional) The key associated with the removed item.</description></item>
        /// </list>
        /// </summary>
        public static string remove { get { return "remove"; } }
    }

    public delegate void MixedCollectionClearDelegate();
    public delegate void MixedCollectionAddDelegate(double index, object o, string key);
    public delegate void MixedCollectionReplaceDelegate(string key, object old, object newItem);
    public delegate void MixedCollectionRemoveDelegate(object o, string key);
}
