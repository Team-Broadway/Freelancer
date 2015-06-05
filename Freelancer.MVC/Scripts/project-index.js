$(document).ready(function () {
 
    $.ajax({
        url: "Projects/List",
        type: 'GET',
        cache: false,
        success: function (result) {
            $('#projects-container').html(result);
        }
    });
   

    $(document).on("click", ".pagination li a", function () {
        $.ajax({
            url: $(this).attr("href"),
            type: 'GET',
            cache: false,
            success: function (result) {
                $('#projects-container').html(result);
            }
        });
        return false;
    });
});