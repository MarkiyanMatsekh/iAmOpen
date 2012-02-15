$(function () {
    var meta = window.iamopen.meta;
    var mainWrapper = $('.' + meta.mainWrapperClass);

    // note MM: don't use _super() - it's EVIL! (try debugging with and without it's usage and look at it's state)

    if (meta.useAjax) {

        window.iamopen.GetController('Initializer', {

            init: function () {
                var self = this;
                var mockAnchor = $('<a>');
                var mockEvent = { preventDefault: function () { } };
                var popped = ('state' in window.history);
                var initialUrl = location.href;

                $(window).bind('popstate', function () {

                    // fix of different browsers behavior
                    var initialPop = !popped && location.href == initialUrl;
                    popped = true;
                    if (initialPop) return;

                    self.invokeAction(self.actions.ajaxifyLinks,
                            mockAnchor.attr("href", window.location),
                            mockEvent,
                            { pushState: false });

                    //history.go(0);
                });
            },

            'a click': function (a, ev) {
                this.invokeAction(this.actions.ajaxifyLinks, a, ev, { pushState: true });
            },

            actions: {
                ajaxifyLinks: {
                    readParams: function () { return this.sender.attr("href"); }, // inside this function 'this' refers to an event
                    process: function (url) {
                        this.event.preventDefault();
                        if (this.data.pushState) {
                            history.pushState({ test: 1 }, 'my-id', url);
                        }
                        return this.base.process.call(this, url);
                    },
                    show: function (data) {
                        this.controller.element.html(data);
                    }
                }
            }
        });

        mainWrapper.initializer();

    }
});