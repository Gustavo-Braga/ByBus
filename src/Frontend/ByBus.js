$(document).ready(function(){
  $("#btnPesquisar").click(function(){
    alert("gustavo");
  });

    function initMap() {

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
 
     var Marker = new google.maps.Marker({
       position:latlng,
       map: map,
       title: 'Ponto de Referencia'
     });

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