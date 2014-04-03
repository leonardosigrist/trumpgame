$(document).ready(function () {
    loadToolTips();
});


function loadToolTips() {
    //aplica tooltip em todos os divs que tenham o atributo definido 'data-enable-tooltip' como true.
    $('div[data-enable-tooltip="true"]').tooltip();
}

