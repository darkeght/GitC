jQuery(document).ready(function(){
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:59271/Api/Generos",
        "method": "GET",
        "headers": {
            "Content-Type": "application/json",
            "Accept": "*/*"
          }
        }

        $.ajax(settings).done(function (response) {
            $.each(response,function(index,value){
                $('#Genero')[0].innerHTML += '<option value=\''+ value.Id +'\'>'+ value.Tipo +'</option>';
            });
        });
});