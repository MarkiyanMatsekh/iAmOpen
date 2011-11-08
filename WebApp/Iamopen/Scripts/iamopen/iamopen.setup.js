$(function () {
   var meta = window.iamopen.meta;
   var mainWrapper = $('.' + meta.mainWrapperClass);

   // note MM: don't use _super() - it's EVIL! (try debugging with and without it's usage and look at it's state)
   
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
                  return this.base.process.call(this, url);
               },
               show: function (data) { this.controller.element.html(data); }
            }
         }
      });

      mainWrapper.initializer();

   }
});