$(function () {
   var meta = window.iamopen.meta;
   var mainWrapper = $('.' + meta.mainWrapperClass);

   if (meta.useAjax) {
      $.Controller('Initializer', {
         'a click': function (a, ev) {
            var self = this;
            $.get(a.attr("href"))
               .success(function (data) {
                  self.element.html(data);
               })
               .error(function (err) {
                  alert("error occured while loading page. error code = " + err.status + " - " + err.statusText);
               });
            ev.preventDefault();
         }
      });

      mainWrapper.initializer();
   }
});