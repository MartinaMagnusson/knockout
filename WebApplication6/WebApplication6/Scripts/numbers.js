


// Adding random number and color //

var NumbersViewModel = function () {
    var self = this;

    self.data = ko.observableArray();

    self.init = function () {

    };
    self.addRandomNumber = function (value) {
        for (var i = 0; i < value; i++) {
            self.data().randomNumbers.Numbers.push(Math.floor((Math.random() * 100) + 1));
        }
    };

    self.addStaticNumber = function (color, value) {
        self.data().staticNumbers.Numbers.push(value);
        $('.number:last-of-type').css("color", color);
    };

}

