$(document).ready(function () {
    var bidMenuButton = $("#show-bid-menu");
    var biddersContainer = $("#bidders-table-container tbody");
    var project_id = parseInt($("#project-id").attr("value"));


    $.ajax({
        url: $("#project-id").attr("data-url"),
        data: { projectId: project_id },
        type: 'GET',
        cache: false,
        success: function (result) {
            biddersContainer.html(result);
        }
    });

    $.ajax({
        url: bidMenuButton.attr("data-url"),
        data: { projectId: project_id },
        type: 'GET',
        cache: false,
        success: function (result) {
            $('#bid-menu').html(result);
        }
    });

    bidMenuButton.click(function () {
        if ($("#bid-menu").css("display") == "none") {
            $("#bid-menu").css("display", "block");
            $(this).find("span").text("Hide");
            $(this).find("span").attr("class", "glyphicon glyphicon-arrow-down");
        } else {
            $("#bid-menu").css("display", "none")
            $(this).find("span").text("Bid on this project");
            $(this).find("span").attr("class", "glyphicon glyphicon-arrow-up");
        }
    });
})