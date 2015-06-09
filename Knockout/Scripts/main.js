require.config({
    baseUrl: "/scripts",
    paths: {
        "jquery": "jquery-2.1.4.min",
        "underscore": "underscore.min",
        "text":"text"
    }

});

require(['jquery','text'], function ($,requireText) {

    // some code here
    console.log($("body").html());

    require(['text!' +"/home/index"], function (content) {
        console.log(content);
    });
});