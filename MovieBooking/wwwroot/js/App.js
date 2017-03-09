$(function () {

    var api = {
        views: {},
        models: {},
        collections: {},
        content: null,
        router: null,
        cinemas: null,
        init: function () {
            this.content = $("#content");
           // this.cinemas = new api.collections.Cinemas();
            return this;
        },
        changeContent: function (el) {
            this.content.empty().append(el);
            return this;
        },
        title: function (str) {
            $("h1").text(str);
            return this;
        }
    };
    var ViewsFactory = {
        GetAppView: function () {
                return new CinemaView()
        }
    }
    var Router = Backbone.Router.extend({});
    api.router = new Router();

    var AppView = ViewsFactory.GetAppView();
    
});