$(() => {
    function init() {
        play.DataContext.getRandomPhrase((data) => {
            var viewModel = new play.ViewModel(data);
            ko.applyBindings(viewModel);
        });
    }

    init();
}); 