﻿$Namespace('H8');

H8.DecorationTests = function() {
};

H8.DecorationTests.prototype.box_OnMouseOver = function(/*DotWeb.Client.Dom.Events.MouseEvent*/ evt) {
};

H8.DecorationTests.prototype.TestCastInterface = function() {
	var element = $doc.getElementById("box");
	var box = /*(DotWeb.Client.Dom.Html.HtmlDivElement)*/element;
	box.onmouseover = $Delegate(this, this.box_OnMouseOver);
};
