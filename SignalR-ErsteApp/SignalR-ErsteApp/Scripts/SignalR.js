(function () {
    var chat = $.connection.chat;
    $.connection.hub.start()
        .done(function () {
            $.connection.hub.logging = true;
            writeToPage("IT WORKED");
            chat.server.announceToEverybody("Connected!");
            $.connection.hub.log("Hello");
        })
        .fail(function() {
             writeToPage("ERROR!!");
        });

    chat.client.announce = function (message) {
        writeToPage(message);
    }

    var writeToPage = function (message) {
        $("#welcome-messages").append(message + "<br />");
    }

    $("#click-me").on("click", function () {
        chat.server.getServerDateTime()
            .done(function (data) {
                writeToPage(data);
            })
            .fail(function (e) {
                writeToPage(e);
            });
    })
})()