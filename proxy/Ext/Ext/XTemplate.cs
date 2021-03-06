using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     <p>A template class that supports advanced functionality like autofilling arrays, conditional processing with
	///     basic comparison operators, sub-templates, basic math function support, special built-in template variables,
	///     inline code execution and more.  XTemplate also provides the templating mechanism built into {@link Ext.DataView}.</p>
	///     <p>XTemplate supports many special tags and built-in operators that aren't defined as part of the API, but are
	///     supported in the templates that can be created.  The following examples demonstrate all of the supported features.
	///     This is the data object used for reference in each code example:</p>
	///     <pre><code>
	///     var data = {
	///     name: 'Jack Slocum',
	///     title: 'Lead Developer',
	///     company: 'Ext JS, LLC',
	///     email: 'jack@extjs.com',
	///     address: '4 Red Bulls Drive',
	///     city: 'Cleveland',
	///     state: 'Ohio',
	///     zip: '44102',
	///     drinks: ['Red Bull', 'Coffee', 'Water'],
	///     kids: [{
	///     name: 'Sara Grace',
	///     age:3
	///     },{
	///     name: 'Zachary',
	///     age:2
	///     },{
	///     name: 'John James',
	///     age:0
	///     }]
	///     };
	///     </code></pre>
	///     <p><b>Auto filling of arrays and scope switching</b><br/>Using the <tt>tpl</tt> tag and the <tt>for</tt> operator,
	///     you can switch to the scope of the object specified by <tt>for</tt> and access its members to populate the template.
	///     If the variable in <tt>for</tt> is an array, it will auto-fill, repeating the template block inside the <tt>tpl</tt>
	///     tag for each item in the array:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Title: {title}&lt;/p>',
	///     '&lt;p>Company: {company}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;p>{name}&lt;/p>',
	///     '&lt;/tpl>&lt;/p>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Access to parent object from within sub-template scope</b><br/>When processing a sub-template, for example while
	///     looping through a child array, you can access the parent object's members via the <tt>parent</tt> object:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;tpl if="age &amp;gt; 1">',  // <-- Note that the &gt; is encoded
	///     '&lt;p>{name}&lt;/p>',
	///     '&lt;p>Dad: {parent.name}&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;/tpl>&lt;/p>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Array item index and basic math support</b> <br/>While processing an array, the special variable <tt>{#}</tt>
	///     will provide the current array index + 1 (starts at 1, not 0). Templates also support the basic math operators
	///     + - * and / that can be applied directly on numeric data values:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;tpl if="age &amp;gt; 1">',  // <-- Note that the &gt; is encoded
	///     '&lt;p>{#}: {name}&lt;/p>',  // <-- Auto-number each item
	///     '&lt;p>In 5 Years: {age+5}&lt;/p>',  // <-- Basic math
	///     '&lt;p>Dad: {parent.name}&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;/tpl>&lt;/p>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Auto-rendering of flat arrays</b> <br/>Flat arrays that contain values (and not objects) can be auto-rendered
	///     using the special <tt>{.}</tt> variable inside a loop.  This variable will represent the value of
	///     the array at the current index:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>{name}\'s favorite beverages:&lt;/p>',
	///     '&lt;tpl for="drinks">',
	///     '&lt;div> - {.}&lt;/div>',
	///     '&lt;/tpl>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Basic conditional logic</b> <br/>Using the <tt>tpl</tt> tag and the <tt>if</tt>
	///     operator you can provide conditional checks for deciding whether or not to render specific parts of the template.
	///     Note that there is no <tt>else</tt> operator &mdash; if needed, you should use two opposite <tt>if</tt> statements.
	///     Properly-encoded attributes are required as seen in the following example:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;tpl if="age &amp;gt; 1">',  // <-- Note that the &gt; is encoded
	///     '&lt;p>{name}&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;/tpl>&lt;/p>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Ability to execute arbitrary inline code</b> <br/>In an XTemplate, anything between {[ ... ]}  is considered
	///     code to be executed in the scope of the template. There are some special variables available in that code:
	///     <ul>
	///     <li><b><tt>values</tt></b>: The values in the current scope. If you are using scope changing sub-templates, you
	///     can change what <tt>values</tt> is.</li>
	///     <li><b><tt>parent</tt></b>: The scope (values) of the ancestor template.</li>
	///     <li><b><tt>xindex</tt></b>: If you are in a looping template, the index of the loop you are in (1-based).</li>
	///     <li><b><tt>xcount</tt></b>: If you are in a looping template, the total length of the array you are looping.</li>
	///     <li><b><tt>fm</tt></b>: An alias for <tt>Ext.util.Format</tt>.</li>
	///     </ul>
	///     This example demonstrates basic row striping using an inline code block and the <tt>xindex</tt> variable:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Company: {[values.company.toUpperCase() + ", " + values.title]}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;div class="{[xindex % 2 === 0 ? "even" : "odd"]}">',
	///     '{name}',
	///     '&lt;/div>',
	///     '&lt;/tpl>&lt;/p>'
	///     );
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	///     <p><b>Template member functions</b> <br/>One or more member functions can be defined directly on the config
	///     object passed into the XTemplate constructor for more complex processing:</p>
	///     <pre><code>
	///     var tpl = new Ext.XTemplate(
	///     '&lt;p>Name: {name}&lt;/p>',
	///     '&lt;p>Kids: ',
	///     '&lt;tpl for="kids">',
	///     '&lt;tpl if="this.isGirl(name)">',
	///     '&lt;p>Girl: {name} - {age}&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;tpl if="this.isGirl(name) == false">',
	///     '&lt;p>Boy: {name} - {age}&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;tpl if="this.isBaby(age)">',
	///     '&lt;p>{name} is a baby!&lt;/p>',
	///     '&lt;/tpl>',
	///     '&lt;/tpl>&lt;/p>', {
	///     isGirl: function(name){
	///     return name == 'Sara Grace';
	///     },
	///     isBaby: function(age){
	///     return age < 1;
	///     }
	///     });
	///     tpl.overwrite(panel.body, data);
	///     </code></pre>
	/// </summary>
	/// <jssource>F:\src\git\DotWeb\proxy\ExtJsParser\ext-2.2\source\util\XTemplate.js</jssource>
	public class XTemplate : Ext.Template {

		/// <summary>to join("") that can also include a config object</summary>
		/// <returns></returns>
		public extern XTemplate();
		/// <summary>to join("") that can also include a config object</summary>
		/// <param name="parts">The HTML fragment or an array of fragments to join(""), or multiple arguments</param>
		/// <returns></returns>
		public extern XTemplate(string parts);
		/// <summary>to join("") that can also include a config object</summary>
		/// <param name="parts">The HTML fragment or an array of fragments to join(""), or multiple arguments</param>
		/// <returns></returns>
		public extern XTemplate(System.Array parts);
		/// <summary>to join("") that can also include a config object</summary>
		/// <param name="parts">The HTML fragment or an array of fragments to join(""), or multiple arguments</param>
		/// <returns></returns>
		public extern XTemplate(object parts);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static XTemplate prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Template superclass { get; set; }


		/// <summary>Returns an HTML fragment of this template with the specified values applied.</summary>
		/// <returns>String</returns>
		public extern virtual void applyTemplate();

		/// <summary>Returns an HTML fragment of this template with the specified values applied.</summary>
		/// <param name="values">The template values. Can be an array if your params are numeric (i.e. {0}) or an object (i.e. {foo: 'bar'})</param>
		/// <returns>String</returns>
		public extern virtual void applyTemplate(object values);

		/// <summary>Compile the template to a function for optimized performance.  Recommended if the template will be used frequently.</summary>
		/// <returns>Function</returns>
		public extern virtual void compile();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void set();

		/// <summary>Creates a template from the passed element's value (<i>display:none</i> textarea, preferred) or innerHTML.</summary>
		/// <returns>Ext.Template</returns>
		public extern static void from();

		/// <summary>Creates a template from the passed element's value (<i>display:none</i> textarea, preferred) or innerHTML.</summary>
		/// <param name="el">A DOM element or its id</param>
		/// <returns>Ext.Template</returns>
		public extern static void from(string el);

		/// <summary>Creates a template from the passed element's value (<i>display:none</i> textarea, preferred) or innerHTML.</summary>
		/// <param name="el">A DOM element or its id</param>
		/// <returns>Ext.Template</returns>
		public extern static void from(DOMElement el);



	}
}
