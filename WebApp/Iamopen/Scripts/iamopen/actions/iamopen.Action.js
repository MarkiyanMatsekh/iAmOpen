$.Class('iamopen.Action', {
   init: function (action, controller, sender, event) {
      $.extend(this, action);
      this.controller = controller;
      this.sender = sender;
      this.event = event;
   },
   readParams: function () {
      alert(1);
      return true;
   },
   process: function () {
      return true;
   },
   show: function () {
      return true;
   },

   onReadParamsFailed: function (e) { this.onFail(e); },
   onProcessFailed: function (e) { debugger; this.onFail(e); },
   onShowFailed: function (e) { this.onFail(e); },
   onFail: function (e) {
      if (typeof (e) === 'string') {
         alert(e);
      } else if (e.status) {
         alert(e.status + ": " + e.statusText);
      }
   }

});