$(function () {
	$('.close').on('click', function (e) { e.preventDefault(); $(this).parents('.alert-box').slideUp(); });
});