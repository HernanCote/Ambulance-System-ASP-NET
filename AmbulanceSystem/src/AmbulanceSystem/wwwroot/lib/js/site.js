(function () {
    var $sidebarAndWrapperAndFooter = $('#sidebar, #wrapper, #footer-site');
    var $icon = $("#sidebarToggle i.fa");

    $('#sidebarToggle').on('click', function () {
        $sidebarAndWrapperAndFooter.toggleClass('hide-sidebar');
        if ($sidebarAndWrapperAndFooter.hasClass('hide-sidebar')) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        } else {
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
    });
})();