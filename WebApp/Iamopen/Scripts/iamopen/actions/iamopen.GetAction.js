iamopen.Action('iamopen.GetAction', {
   process: function (url) {
      var self = this;
      $.get(url).success(function () {
            self.show.apply(self, arguments);
         })
         .error(function () {
            self.onProcessFailed.apply(self, arguments);
         });
      return { cancel: true };
   }
});