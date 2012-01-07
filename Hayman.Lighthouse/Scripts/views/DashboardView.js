var DashboardView = Backbone.View.extend({

	// Cache the template function.
	template: _.template($('#dashboard').html()),

	initialize: function (args) {
		console.log('DashboardView initialized');
	},

	// Select the root application container
	el: $('.approot > .container'),

	events: {
		"click .mi-create": "metaitemcreate"
	},

	render: function () {

		$(this.el).html(this.template());

		return this;
	},

	metaitemcreate: function () {
		console.log('metaitemcreate event handled');
	}

});