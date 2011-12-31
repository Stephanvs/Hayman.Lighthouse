$(function () {
	if (URI(window.location.href).path().toString() !== "/") {
		window.location = URI(window.location.origin).hash("!" + URI(window.location.href).path().toString()).toString();
	}
});

function BreadcrumbItem(name, href, active) {
	var self = this;

	self.name = ko.observable(name);
	self.href = ko.observable(href);
	self.active = ko.observable(active);
};

function BreadcrumbViewModel() {
	var self = this;

	// Editable data
	self.items = ko.observableArray([
        new BreadcrumbItem("Dashboard", "#!/Dashboard", false),
        new BreadcrumbItem("Bert", "#!/Bert", true)
    ]);
}

ko.applyBindings(new BreadcrumbViewModel());