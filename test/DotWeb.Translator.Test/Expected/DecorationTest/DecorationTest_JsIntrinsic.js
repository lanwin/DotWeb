﻿$Namespace('H8');

H8.IntrinsicClass = function() {
};

H8.IntrinsicClass.prototype.$ctor = function() {
	return this;
};

$Namespace('System');

System.Console = function() {
};

System.Console.Write = function(value /*System.Int32*/) {
	console.log(value);
};

$Namespace('DotWeb.Client');

DotWeb.Client.JsScript = function() {
};

H8.DecorationTests = function() {
	this.$super.constructor();
};
H8.DecorationTests.$extend(DotWeb.Client.JsScript);

H8.DecorationTests.prototype.TestJsIntrinsic = function() {
	var __g__initLocal3 = new H8.IntrinsicClass().$ctor();
	__g__initLocal3.Value = 1;
	var item = __g__initLocal3;
	System.Console.Write(item.Value);
};
