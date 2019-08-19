jQuery(document).ready(function(){
    /* Indica que o evento submit do form irá realizar esta ação agora*/
    jQuery('.form-post').submit(function(){
        /* Neste contesto 'this' representa o form deste ID  #myform */  
        var Id = $($(this)[0][1]).val();            
        var dados = $(this).serialize();
        var sendpost = $(this).attr('send-post');
        var callStr  = $(this).attr('call');
        var method = "POST";

        if(Id !== "") {
            method = "PUT";
            Id = "/"+Id;
        }

         var settings = {
          "crossDomain": true,
          "url": "http://localhost:59271/Api/"+sendpost + Id,
          "method": method,
          "headers": {
            "Content-Type": "application/x-www-form-urlencoded",
            "Accept": "*/*"
          },
          "data": dados
        }

        $.ajax(settings).done(function (response) {
           window[callStr](response);
        });
        
        return false;
    });

    SetGridClickEvents();
});

function SetGridClickEvents(){
    $('.btn-delet-event').click(function(){
        var id = $(this).attr('value');
        var sendpost = $(this).attr('send-post');

        var settings = {
            "crossDomain": true,
            "url": "http://localhost:59271/Api/"+ sendpost +"/"+ id,
            "method": "DELETE",
            "headers": {
              "Content-Type": "application/x-www-form-urlencoded",
              "Accept": "*/*"
            }
          }

          $.ajax(settings).done(function (response) {
              GetMethod(null);
          });
    });
}
