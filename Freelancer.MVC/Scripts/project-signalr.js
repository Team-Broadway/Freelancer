$(document).ready(function () {
  
    var projects = $.connection.projectsHub;
    projects.client.addProjectsHubMessage = function (id) {
        $.ajax({
            url: $("#partial-render").attr("data-url"),
            data: {
                id: parseInt(id)
            },
            type: 'GET',
            cache: false,
            success: function (result) {
                $('#projects-table tbody').prepend(result);
            }
        });
    }

    $.connection.hub.start();
});