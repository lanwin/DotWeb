using System;
using H8.Support;

namespace Ext.Toolbar {
    /// <summary>
    ///     /**
    ///     A simple class that adds a vertical separator bar between toolbar items.  Example usage:
    ///     <pre><code>
    ///     new Ext.Panel({
    ///     tbar : [
    ///     'Item 1',
    ///     {xtype: 'tbseparator'}, // or '-'
    ///     'Item 2'
    ///     ]
    ///     });
    ///     </code></pre>
    /// </summary>
    /// <jssource>C:\home\src\external\ext-2.2\source\widgets\Toolbar.js</jssource>
    [Native]
    public class Separator : Ext.Toolbar.Item {

        /// <summary>Creates a new Separator</summary>
        /// <returns></returns>
        public Separator() {}
        /// <summary>Creates a new Item</summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public Separator(DOMElement el) {}

        /// <summary>The reference to the prototype the every object of this type is constructed with</summary>
        public static Separator prototype { get { return null; } set { } }

        /// <summary>The reference to the constructor function</summary>
        public static Delegate constructor { get { return null; } set { } }

        /// <summary>The reference to the class that this class inherits from</summary>
        public static Ext.Toolbar.Item superclass { get { return null; } set { } }




    }
    [Anonymous]
    public class SeparatorConfig {

    }


}
