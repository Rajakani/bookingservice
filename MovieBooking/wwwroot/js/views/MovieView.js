var MovieListView = Backbone.View.extend({
    render: function () {
        var data = this.model.toJSON();       
        this.$el.html("<li><span class='tabbed'>" + data.name + ": </span><span class='tabbed'>" + data.availability + "</span></li>");
        return this.$el.html();
    }
});

MovieView = Backbone.View.extend({
    el: "#movie-tab",
    
    movieSelf: null,
    initialize: function(){
        movieSelf = this;
    },
    render: function () {
        this.$el.find('ul').html('');
        _.each(movieSelf.collection.models, function (item) {
            var option = new MovieListView({ model: item }).render();
            this.$el.find('ul').append(option);
        }, this);
    }
});