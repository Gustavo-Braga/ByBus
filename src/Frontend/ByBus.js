$(document).ready(function(){
  $("#btnPesquisar").click(function(){
    alert("gustavo");
    //codeAddress();

    //<script>
    function initMap() {

// // var latlng = new google.maps.LatLng(-34.397, 150.644);
// //     var mapOptions = {
// //       zoom: 8,
// //       center: latlng
// //     }
// //     map = new google.maps.Map(document.getElementById('map'), mapOptions);
////Codigo para inicialização do mapa

      latlng = {};
     navigator.geolocation.getCurrentPosition(function(position) {
       latlng = {
           lat: position.coords.latitude,
           lng: position.coords.longitude
       };
       map = new google.maps.Map(document.getElementById('map'), {
         center:  latlng,
         zoom: 18
       });
       var directionsService = new google.maps.DirectionsService;

       var directionsDisplay = new google.maps.DirectionsRenderer({suppressMarkers: true});
       var directionsDisplay2 = new google.maps.DirectionsRenderer();
       var directionsDisplay3 = new google.maps.DirectionsRenderer();
       directionsDisplay.setMap(map);
       directionsDisplay2.setMap(map);
       directionsDisplay3.setMap(map);
 
     var Marker = new google.maps.Marker({
       position:latlng,
      //  position: {
      //      lat: -21.7820448,
      //      lng: -48.1474005
      //  },
       map: map,
       title: 'Ponto de Referencia'
     });

          directionsService.route({
           origin: "av. São João,ARARAQUARA, SP",
           destination:"R Gregorio Angelieri,ARARAQUARA, SP",
           optimizeWaypoints: false,
           travelMode: 'DRIVING',
         }, function(response, status) {
           if (status === 'OK') {
              directionsDisplay.setDirections(response);
           } else {
             window.alert('Directions request failed due to ' + status);
           }
         });


          directionsService.route({
           origin: "R Gregorio Angelieri,ARARAQUARA, SP",
           destination:"av jocelyn machado,ARARAQUARA, SP",
           optimizeWaypoints: false,
           travelMode: 'DRIVING',
         }, function(response, status) {
           if (status === 'OK') {
              directionsDisplay2.setDirections(response);
           } else {
             window.alert('Directions request failed due to ' + status);
           }
         });

          directionsService.route({
           origin: "av jocelyn machado,ARARAQUARA, SP",
           destination:"R Benjamim Lost,ARARAQUARA, SP",
           optimizeWaypoints: false,
           travelMode: 'DRIVING',
         }, function(response, status) {
           if (status === 'OK') {
              directionsDisplay3.setDirections(response);
           } else {
             window.alert('Directions request failed due to ' + status);
           }
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
          editable:true,
          radius: 100
        });

        // $("#btnPesquisar").click(function(){
        //   var param = $("#txtPesquisar").val();
        //   var a = {}
        //   $.ajax({
        //     method: 'POST',
        //     url: 'https://localhost:44369/api/v1/Bus/BusRouteById?id='+param,
        //     success: function (res) {
        //       console.log("success");
        //       console.log(res);
        //       a = res.data();
        //       alert("success -> "+a);

        //       return a;
        //     },
        //     error: function (res) {
        //         console.log("error");
        //         console.log(res);
        //         alert("error");
        //     }
        // })
        // })

      var geocoder = new google.maps.Geocoder();

      // $("#btnPesquisar").click(function(){
      //   codeAddress();
      // });

       function codeAddress() {
            var address = document.getElementById('txtPesquisar').value;
            console.log("address");
            console.log(address);

            geocoder.geocode({'address': address}, function(results, status) {
            if (status === 'OK') {
              resultsMap.setCenter(results[0].geometry.location);
              var marker = new google.maps.Marker({
                map: resultsMap,
                position: results[0].geometry.location
              });
            } else {
              alert('Geocode was not successful for the following reason: ' + status);
            }
          });
          }
 
          // var a = google.maps.geometry.spherical.computeDistanceBetween(Marker.getPosition(), circle.getCenter()) <= circle.getRadius();
          // console.log(a);
     

   });//navigator
   };//initMap
     //</script>
  });

  //  $("#modalTeste").modal("show");

  // $("#enviar").click(function(){
  //   var teste = $("#pesquisar").val();
  //   alert(teste);
  //   var position= {
  //     lat: -21.7820448,
  //     lng: -48.1474005
  //   }
  //   return new google.maps.Circle({
  //     strokeColor: '#FF0000',
  //     strokeOpacity: 1,
  //     strokeWeight: 2,
  //     fillColor: '#FF0000',
  //     fillOpacity: 0.2,
  //     map: map,
  //     center: position,
  //     draggable: true,
  //     editable:true,
  //     radius: 100
  //   });
  // })

  // $("#enviar").click(function(){
  //   var endereco = $("#pesquisar").val();
  //     $("#modalTeste").modal("show");
  // })

  // $("#enviar").click(function(){
  //   var param = $("#pesquisar").val();
  //   $.ajax({
  //     method: 'POST',
  //     url: 'https://localhost:44369/api/v1/Bus/BusRouteById?id='+param,
  //     success: function (res) {
  //        alert("sucesso");
  //        console.log("sucesso");
  //        console.log(res);
  //     },
  //     error: function (res) {
  //         console.log("error");
  //         console.log(res);
  //         alert("deu ruim, "+JSON.parse(res)+ " <-");
  //      }
  //  })
  // })

});
/*

TODA VEZ QUE O USUÁRIO SOLTAR O RAIO OU QUE O RAIO FOR MANIPULADO IRA CONSULTAR AS ROTAS DE ONIBUS
E APARECERA NA LISTA DE EMPRESAS
O MENU EMPRESAS PODERÁ FICAR BLOQUEADO QUANDO NAO HOUVER NENHUMA ROTA DE ONIBUS
CASO HAJA ALGUMA DESBLOQUEAR O MENU

O USUARIO IRA VERIFICAR OS HORARIOS DE DETERMINADA ROTA QUANDO ELE CLICAR
EM UMA ROTA DE ONIBUS E A MESMA ESTIVER RENDERIZADA NO MAPA

  QUANDO O USUÁRIO CLICAR NO MENU EMPRESAS IRA APARECER EM UMA MODAL A LISTA DE TODAS AS EMPRESAS 
  DE ONIBUS {PODE SER UMA TABELA COM O NOME DA EMPRESA E A LINHA DE ONIBUS QUE PASSA POR DENTRO DO RAIO}
*/