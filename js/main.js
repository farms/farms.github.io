jQuery(function($) {

	//#main-slider
	$( '.centered' ).each(function( e ) {
		$(this).css('margin-top',  ($('#main-slider').height() - $(this).height())/2);
	});

	// Launching the right tab section on click on index button
	$('#main-slider button[data-toggle="modal"]').click(function(e) {
		e.preventDefault();
		var tab = ($(this).text() == 'CADASTRAR') ? "#register" : '#login';
		$('#modal-tab a[href="'+ tab + '"]').click();
	});

	// Changing modal header according to tab section
	$('#modal-tab a').click(function (e) {
		var headerText = ($(this).attr('href') == '#register') ? 'Crie a sua conta' : 'Entre na sua conta';
		$('#login-register .modal-header h2').text(headerText);
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