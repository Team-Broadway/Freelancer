$(document).ready(function () {
    $(".project-info").hover(function () {
        $(this).next().css("display", "table-row");
        $(this).css("background-color", "#CFBDA5");
        $(this).next().css("background-color", "#CFBDA5");
        $(this).next().children().css("border", "none");
    }, function () {
        if (!$(this).next().is(":hover")) {
            $(this).css("background-color", "");
            $(this).next().css("background-color", "");
        }
        $(this).next().css("display", "none");
    })

    $(".project-description").hover(function () {
        $(this).css("background-color", "#CFBDA5");
        $(this).prev().css("background-color", "#CFBDA5");
        $(this).css("display", "table-row");
        $(this).children().css("border", "none");
    }, function () {
        if (!$(this).prev().is(":hover")) {
            $(this).css("background-color", "");
            $(this).prev().css("background-color", "");
        }
        $(this).css("display", "none");
    })

    $(".favorite-star").hover(function () {
        var polygon = $(this).find("polygon");
        polygon.data("fav-color", polygon.css("fill"));
        polygon.css("fill", "skyblue");
    }, function () {
        $(this).find("polygon").css("fill", $(this).find("polygon").data("fav-color"));
    })

    $(".project-info").on("click", ".favorite-star", function () {
        return function () {
            var $this = $(this);
            var id = $this.data("id");
            $.ajax({
                type: "POST",
                url: "/Projects/Bookmark/" + id,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data, datatype) {
                    if (data) {
                        $this.find("polygon").css("fill", "yellow");
                    } else {
                        $this.find("polygon").css("fill", "gray");
                    }
                },
                error: function (err) {
                }
            });
        }
    }());

});