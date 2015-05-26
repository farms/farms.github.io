jQuery(function($) {

	//#main-slider
	$( '.centered' ).each(function( e ) {
		$(this).css('margin-top',  ($('#main-slider').height() - $(this).height())/2);
	});

	//contact form
	var form = $('.subscribe-form');
	form.submit(function () {
		$this = $(this);
		$.post($(this).attr('action'), function(data) {
			$this.prev().text(data.message).fadeIn().delay(3000).fadeOut();
		},'json');
		return false;
	});
});