var AppModel = Backbone.Model.extend({

	initialize: function () {
		// something else
		console.log('AppModel initialized');
	},

	defaults: {
		name: '',
		created: new Date()
	}

});