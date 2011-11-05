iamopen.Action.extend('iamopen.GetAction', {

   process: function (url) {
      $.get(url)
         .success(this.proxy('show'))
         .error(this.proxy('onProcessFailed'));
      return { cancel: true };
   }
});