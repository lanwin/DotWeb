﻿$Namespace('H8');

H8.OuterClassTest = function() {
};

H8.OuterClassTest.prototype.set_Text = function(value /*System.String*/) {
	this._Text_k__BackingField = value;
};

H8.OuterClassTest.prototype.set_Value = function(value /*System.Int32*/) {
	this.m_value = value;
};

H8.OuterClassTest.prototype.$ctor = function(text /*System.String*/, value /*System.Int32*/) {
	this.set_Text(text);
	this.set_Value(value);
	return this;
};

H8.OuterClassTest.prototype.$ctor = function() {
	return this;
};

H8.OuterClassTest.prototype.get_Text = function() {
	return this._Text_k__BackingField;
};

H8.OuterClassTest.prototype.get_Value = function() {
	return this.m_value;
};

$Namespace('System');

System.Console = function() {
};

System.Console.WriteLine = function(format /*System.String*/, arg0 /*System.Object*/, arg1 /*System.Object*/) {
	console.log(format);
};

H8.SourceTests = function() {
};

H8.SourceTests.prototype.CreateOuterObject = function() {
	var test1 = new H8.OuterClassTest().$ctor("Test1", 1);
	var __g__initLocal1 = new H8.OuterClassTest().$ctor();
	__g__initLocal1.set_Text("Test2");
	__g__initLocal1.set_Value(2);
	var test2 = __g__initLocal1;
	System.Console.WriteLine("{0}, {1}", test1.get_Text(), test1.get_Value());
	System.Console.WriteLine("{0}, {1}", test2.get_Text(), test2.get_Value());
};
