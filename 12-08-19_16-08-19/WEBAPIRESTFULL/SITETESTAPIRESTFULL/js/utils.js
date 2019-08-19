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
});
