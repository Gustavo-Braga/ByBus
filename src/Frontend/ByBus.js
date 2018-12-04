$(document).ready(function () {
   ByBus.init();
});

var action,
   ByBus = {
      init: function () {
         this.bindActionsUI();
         action = this.actions;
         this.initMap();
      },

      initMap: function () {
         latlng = {};
         navigator.geolocation.getCurrentPosition(function (position) {
            latlng = {
               lat: position.coords.latitude,
               lng: position.coords.longitude
            };
            map = new google.maps.Map(document.getElementById('map'), {
               center: latlng,
               zoom: 18
            });

            var Marker = new google.maps.Marker({
               position: latlng,
               //  position: {
               //      lat: -21.7820448,
               //      lng: -48.1474005
               //  },
               map: map,
               title: 'Ponto de Referencia'
            });

            var circle = new google.maps.Circle({
               strokeColor: '#FF0000',
               strokeOpacity: 1,
               strokeWeight: 2,
               fillColor: '#FF0000',
               fillOpacity: 0.2,
               map: map,
               center: Marker.position,
               draggable: true,
               editable: true,
               radius: 100
            });
         });
      },

      bindActionsUI: function () {
         $("#btnPesquisar").on("click", function () {
            action.abrirModal();
         });
      },

      actions: {
         abrirModal: function () {
            $("#modalTeste").show();
         }
      }
   }