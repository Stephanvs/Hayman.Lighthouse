$(function () {
	$('.close').on('click', function (e) { e.preventDefault(); $(this).parents('.alert-box').slideUp(); });
});

// Initialize all select boxes as Chosen plugin
$("select").chosen();