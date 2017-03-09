    var ItemView = Backbone.View.extend({
        render: function () {
            var data = this.model.toJSON();
            this.$el.html("<option class='optionClass' value=" + data.key + ">" + data.name + "</option>");
            return this.$el.html();
        }
    });
    CinemaView = Backbone.View.extend({
        el: "#cinema-ddl",
        cinemaSelf: null,
        events: {
            "change #cinema": "CinemaSelected"
        },
        CinemaSelected: function (e) {
            var cinemaKey = e.currentTarget.selectedOptions[0].value;
            var selectedCinema = cinemaSelf.collection.GetModelbyKey(cinemaKey);
            var movieCollection = new MovieCollection(selectedCinema.get('movies'));
            var movieView = new MovieView({ collection: movieCollection }).render();
        },
        initialize: function () {
            cinemaSelf = this;
            this.collection = new CinemaCollection;
            this.collection.on('sync', this.render, this);
            this.collection.fetch();
        },
        render: function () {
            _.each(this.collection.models, function (item) {
                var option = new ItemView({ model: item }).render();
                this.$el.find('select').append(option);
            }, this);
            $('#cinema').trigger('change');
            return this;
        }
    });