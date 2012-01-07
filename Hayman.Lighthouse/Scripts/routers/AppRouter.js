var AppRouter = Backbone.Router.extend({

	routes: {
		// /
		"": "dashboard",

		// /dashboard
		"dashboard": "dashboard",

		// /metaitem/create
		"metaitem/create": "metaitemcreate",

		// /search/{query}
		"search/:query": "search"
	},

	dashboard: function () {

		console.log('changing to DashboardView');

		app.views.DashboardView.render();

		console.log('changed to DashboardView');
	},

	metaitemcreate: function () {

		console.log('changing to metaitem/create view');

		app.views.MetaItemView.render();

		console.log('changed to metaitem/create view');
	},

	search: function (query) {

		console.log('searching for: ' + query);

	}

});