$('a').on('click', function () {
    //deactivate all link in sidebar
    $('#sidebar_body').find('a')
        .each(function () {
            $(this).removeClass('is-active');
        });

    //activate clicked link
    $(this).addClass('is-active');
});