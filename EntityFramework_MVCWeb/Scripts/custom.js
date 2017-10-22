$(document).ready(function () {
    //all generalized functions to go here. prefer
    //Fuction to adjust textbox width to their placeholder length
    $("input[placeholder]").each(function () {
        $(this).attr('size', $(this).attr('placeholder').length);
    });
});