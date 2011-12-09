$(function () {

	var tabs = $('#notification-center .tab');
	var tabpages = $('#notification-center .tabpage');

	tabs.on('click', function () {
		var tab = $(this),
			id = tab.attr('id');

		// mark all tabs and tabpages as inactive.
		tabs.removeClass('active');
		tabpages.removeClass('active');

		// mark clicked tab as active.
		tab.addClass('active');

		// mark associated tabpage as active.
		tabpages.parent().find('[data-tab-id=' + id + ']').addClass('active');

	});
});