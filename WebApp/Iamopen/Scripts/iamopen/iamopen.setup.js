$(function () {
   var meta = window.iamopen.meta;
   var mainWrapper = $('.' + meta.mainWrapperClass);

   if (meta.useAjax) {

      window.iamopen.GetController('Initializer', {

         'a click': function (a, ev) {
            this.invokeAction(this.actions.ajaxifyLinks, a, ev);
         },

         actions: {
            ajaxifyLinks: {
               readParams: function () { return this.sender.attr("href"); },
               process: function (url) {
                  this.event.preventDefault();
                  // todo MM: find a better way to call base class methods
                  return this.constructor.prototype.process.call(this, url);
               },
               show: function (data) { this.controller.element.html(data); }
            }
         }
      });


      mainWrapper.initializer();

   }
});