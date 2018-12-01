$(document).ready(function(){
    
    $("#id").click(function() {
     initMap();
    });

    function initMap() {
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
     directionsDisplay.setMap(map);

   var Marker = new google.maps.Marker({
     position: {
         lat: -21.7820448,
         lng: -48.1474005
     },
     map: map,
     title: 'Hello World!'
   });
       var waypts = [];
       waypts.push({location:" av. Engenheiro Roberto Lepre Sampaio,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua José João Biffi ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua Matão,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"rua São José do Rio Preto ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" av. Santa Adélia,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua Jurupema,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua Pindorama,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" av mirassol,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" av taquaritinga,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua Fernando Prestes ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. Votuporanga ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" av. América,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"rua Acre ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"rua sao jose do rio preto ,ARARAQUARA, SP",stopover:true});
       waypts.push({location:" rua Geraldo Moreira,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. guanabara,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. Carlos Batista Magalhães,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"Rua Antonio Frederico Ozanan,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. Márzio Munhoz, SP",stopover:true});
       waypts.push({location:"rua José do Patrocinio,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. Carlos Batista Magalhães,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"rua Marechal D. da Fonseca,ARARAQUARA, SP",stopover:true});
       waypts.push({location:"av. Padre Antônio Cezarino,ARARAQUARA, SP",stopover:true});

        directionsService.route({
         origin: "av. São João,ARARAQUARA, SP",
         destination:"av. Joaquim Vieira dos Santos,ARARAQUARA, SP",
         waypoints: waypts,
         optimizeWaypoints: false,
         travelMode: 'DRIVING',
       }, function(response, status) {
         if (status === 'OK') {
            directionsDisplay.setDirections(response);
         } else {
           window.alert('Directions request failed due to ' + status);
         }
       });

     var a = google.maps.geometry.spherical.computeDistanceBetween(Marker.getPosition(), circle.getCenter()) <= circle.getRadius();
    console.log(a);

   var infowindow = new google.maps.InfoWindow({
     content: "TESTE DE <br>INFOWINDOW"
   });

   Marker.addListener('click', function() {
   infowindow.open(map, Marker);
 });


 });

   console.log(latlng);
 };



});