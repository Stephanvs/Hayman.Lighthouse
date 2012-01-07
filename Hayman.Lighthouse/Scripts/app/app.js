var app = {
	models: {},
	routers: {},
	views: {}
};

$(function () {

	// Init the main app Routers
	app.routers.ApplicationRouter = new AppRouter();

	// Enable back button support
	Backbone.history.start({ pushState: true });

	// Init the Models
	app.models.AppModel = new AppModel();

	// Init the Views
	app.views.DashboardView = new DashboardView();
	app.views.MetaItemView = new MetaItemView();

});