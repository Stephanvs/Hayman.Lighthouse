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

	dashboard: function() {
		// Prep the home page and render stuff
		console.log('changing to root application view');
	},

	metaitemcreate: function() {
		// Re-render views to show a collection of books
		console.log('changing to metaitem/create view');
	},

	search: function (query) {
		console.log('searching for: ' + query);
	}

});