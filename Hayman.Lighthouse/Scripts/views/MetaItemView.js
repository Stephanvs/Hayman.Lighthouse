var MetaItemView = Backbone.View.extend({

	// Cache the template function.
	template: _.template($('#metaitem-create').html()),

	initialize: function (args) {
		console.log('MetaItemView initialized');
	},

	// Select the root application container
	el: $('.approot > .container'),

	render: function () {

		$(this.el).html(this.template());

		return this;
	}

});
