(function ($) {

   $.Controller('iamopen.ControllerBase', {

      invokeAction: function (_action, sender, event) {

         var action = new window.iamopen.GetAction(_action, this, sender, event);

         safeInvoke.call(action, action.readParams, [], action.onReadParamsFailed, function (params) {
            safeInvoke.call(action, action.process, params, action.onProcessFailed, function (data) {
               safeInvoke.call(action, action.show, data, action.onShowFailed);
            });
         });
      },

      _actionProto: window.iamopen.Action

   });


   function safeInvoke(fn, arg, fail, success) {
      var result = null,
                   resultFailed = false,
                   errorMessage = '';
      try {
         result = fn.call(this, arg);
         if (result.cancel) {
            return;
         }
         if (!result || result.error) {
            resultFailed = true;
            errorMessage = result.error;
         }
      } catch (e) {
         resultFailed = true;
         errorMessage = e;
      };
      if (resultFailed) {
         fail.call(this, errorMessage);
      } else {
         success.call(this, result);
      };
   }

})(jQuery);