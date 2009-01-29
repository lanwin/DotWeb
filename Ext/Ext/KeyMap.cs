using System;
using DotWeb.Core;

namespace Ext {
    /// <summary>
    ///     /**
    ///     Handles mapping keys to actions for an element. One key map can be used for multiple actions.
    ///     The constructor accepts the same config object as defined by {@link #addBinding}.
    ///     If you bind a callback function to a KeyMap, anytime the KeyMap handles an expected key
    ///     combination it will call the function with this signature (if the match is a multi-key
    ///     combination the callback will still be called only once): (String key, Ext.EventObject e)
    ///     A KeyMap can also handle a string representation of keys.<br />
    ///     Usage:
    ///     <pre><code>
    ///     // map one key by key code
    ///     var map = new Ext.KeyMap("my-element", {
    ///     key: 13, // or Ext.EventObject.ENTER
    ///     fn: myHandler,
    ///     scope: myObject
    ///     });
    ///     // map multiple keys to one action by string
    ///     var map = new Ext.KeyMap("my-element", {
    ///     key: "a\r\n\t",
    ///     fn: myHandler,
    ///     scope: myObject
    ///     });
    ///     // map multiple keys to multiple actions by strings and array of codes
    ///     var map = new Ext.KeyMap("my-element", [
    ///     {
    ///     key: [10,13],
    ///     fn: function(){ alert("Return was pressed"); }
    ///     }, {
    ///     key: "abc",
    ///     fn: function(){ alert('a, b or c was pressed'); }
    ///     }, {
    ///     key: "\t",
    ///     ctrl:true,
    ///     shift:true,
    ///     fn: function(){ alert('Control + shift + tab was pressed.'); }
    ///     }
    ///     ]);
    ///     </code></pre>
    ///     <b>Note: A KeyMap starts enabled</b>
    /// </summary>
    /// <jssource>C:\home\src\external\ext-2.2\source\util\KeyMap.js</jssource>
    [Native]
    public class KeyMap  {

        /// <summary></summary>
        /// <returns></returns>
        public KeyMap() {}
        /// <summary></summary>
        /// <param name="el">The element to bind to</param>
        /// <returns></returns>
        public KeyMap(object el) {}
        /// <summary></summary>
        /// <param name="el">The element to bind to</param>
        /// <param name="config">The config (see {@link #addBinding})</param>
        /// <returns></returns>
        public KeyMap(object el, object config) {}
        /// <summary></summary>
        /// <param name="el">The element to bind to</param>
        /// <param name="config">The config (see {@link #addBinding})</param>
        /// <param name="eventName">(optional) The event to bind to (defaults to "keydown")</param>
        /// <returns></returns>
        public KeyMap(object el, object config, System.String eventName) {}

        /// <summary>The reference to the prototype the every object of this type is constructed with</summary>
        public static KeyMap prototype { get { return null; } set { } }

        /// <summary>The reference to the constructor function</summary>
        public static Delegate constructor { get { return null; } set { } }

        /// <summary>
        ///     True to stop the event from bubbling and prevent the default browser action if the
        ///     key was handled by the KeyMap (defaults to false)
        /// </summary>
        public bool stopEvent { get { return false; } set { } }


        /// <summary>
        ///     Add a new binding to this KeyMap. The following config object properties are supported:
        ///     <pre>
        ///     Property    Type             Description
        ///     ----------  ---------------  ----------------------------------------------------------------------
        ///     key         String/Array     A single keycode or an array of keycodes to handle
        ///     shift       Boolean          True to handle key only when shift is pressed (defaults to false)
        ///     ctrl        Boolean          True to handle key only when ctrl is pressed (defaults to false)
        ///     alt         Boolean          True to handle key only when alt is pressed (defaults to false)
        ///     handler     Function         The function to call when KeyMap finds the expected key combination
        ///     fn          Function         Alias of handler (for backwards-compatibility)
        ///     scope       Object           The scope of the callback function
        ///     stopEvent   Boolean          True to stop the event
        ///     </pre>
        ///     Usage:
        ///     <pre><code>
        ///     // Create a KeyMap
        ///     var map = new Ext.KeyMap(document, {
        ///     key: Ext.EventObject.ENTER,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     //Add a new binding to the existing KeyMap later
        ///     map.addBinding({
        ///     key: 'abc',
        ///     shift: true,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     </code></pre>
        /// </summary>
        /// <returns></returns>
        public virtual void addBinding() { return ; }

        /// <summary>
        ///     Add a new binding to this KeyMap. The following config object properties are supported:
        ///     <pre>
        ///     Property    Type             Description
        ///     ----------  ---------------  ----------------------------------------------------------------------
        ///     key         String/Array     A single keycode or an array of keycodes to handle
        ///     shift       Boolean          True to handle key only when shift is pressed (defaults to false)
        ///     ctrl        Boolean          True to handle key only when ctrl is pressed (defaults to false)
        ///     alt         Boolean          True to handle key only when alt is pressed (defaults to false)
        ///     handler     Function         The function to call when KeyMap finds the expected key combination
        ///     fn          Function         Alias of handler (for backwards-compatibility)
        ///     scope       Object           The scope of the callback function
        ///     stopEvent   Boolean          True to stop the event
        ///     </pre>
        ///     Usage:
        ///     <pre><code>
        ///     // Create a KeyMap
        ///     var map = new Ext.KeyMap(document, {
        ///     key: Ext.EventObject.ENTER,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     //Add a new binding to the existing KeyMap later
        ///     map.addBinding({
        ///     key: 'abc',
        ///     shift: true,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     </code></pre>
        /// </summary>
        /// <param name="config">A single KeyMap config or an array of configs</param>
        /// <returns></returns>
        public virtual void addBinding(object config) { return ; }

        /// <summary>
        ///     Add a new binding to this KeyMap. The following config object properties are supported:
        ///     <pre>
        ///     Property    Type             Description
        ///     ----------  ---------------  ----------------------------------------------------------------------
        ///     key         String/Array     A single keycode or an array of keycodes to handle
        ///     shift       Boolean          True to handle key only when shift is pressed (defaults to false)
        ///     ctrl        Boolean          True to handle key only when ctrl is pressed (defaults to false)
        ///     alt         Boolean          True to handle key only when alt is pressed (defaults to false)
        ///     handler     Function         The function to call when KeyMap finds the expected key combination
        ///     fn          Function         Alias of handler (for backwards-compatibility)
        ///     scope       Object           The scope of the callback function
        ///     stopEvent   Boolean          True to stop the event
        ///     </pre>
        ///     Usage:
        ///     <pre><code>
        ///     // Create a KeyMap
        ///     var map = new Ext.KeyMap(document, {
        ///     key: Ext.EventObject.ENTER,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     //Add a new binding to the existing KeyMap later
        ///     map.addBinding({
        ///     key: 'abc',
        ///     shift: true,
        ///     fn: handleKey,
        ///     scope: this
        ///     });
        ///     </code></pre>
        /// </summary>
        /// <param name="config">A single KeyMap config or an array of configs</param>
        /// <returns></returns>
        public virtual void addBinding(System.Array config) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <returns></returns>
        public virtual void on() { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <returns></returns>
        public virtual void on(double key) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <returns></returns>
        public virtual void on(double key, Delegate fn) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <param name="scope">(optional) The scope of the function</param>
        /// <returns></returns>
        public virtual void on(double key, Delegate fn, object scope) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <returns></returns>
        public virtual void on(System.Array key) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <returns></returns>
        public virtual void on(System.Array key, Delegate fn) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <param name="scope">(optional) The scope of the function</param>
        /// <returns></returns>
        public virtual void on(System.Array key, Delegate fn, object scope) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <returns></returns>
        public virtual void on(object key) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <returns></returns>
        public virtual void on(object key, Delegate fn) { return ; }

        /// <summary>
        ///     Shorthand for adding a single key listener
        ///     following options:
        ///     {key: (number or array), shift: (true/false), ctrl: (true/false), alt: (true/false)}
        /// </summary>
        /// <param name="key">Either the numeric key code, array of key codes or an object with the</param>
        /// <param name="fn">The function to call</param>
        /// <param name="scope">(optional) The scope of the function</param>
        /// <returns></returns>
        public virtual void on(object key, Delegate fn, object scope) { return ; }

        /// <summary>Returns true if this KeyMap is enabled</summary>
        /// <returns>Boolean</returns>
        public virtual bool isEnabled() { return false; }

        /// <summary>Enables this KeyMap</summary>
        /// <returns></returns>
        public virtual void enable() { return ; }

        /// <summary>Disable this KeyMap</summary>
        /// <returns></returns>
        public virtual void disable() { return ; }



    }
    [Anonymous]
    public class KeyMapConfig {

    }


}
