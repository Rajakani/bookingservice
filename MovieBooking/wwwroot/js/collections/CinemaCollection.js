CinemaCollection = Backbone.Collection.extend({
    initialize: function(){
    },
    model: CinemaModel,
    GetModelbyKey: function (key) {
        var CinemaByKey = this.filter(function (cinemaModel) {
            return cinemaModel.get('key').toString() === key;
        });
        return CinemaByKey[0];
    },
    url: 'http://localhost:62032/api/cinema',
    parse: function (response) {
        var resp = response;
        return resp;
    },
    });