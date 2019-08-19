jQuery(document).ready(function(){
    /* Indica que o evento submit do form irá realizar esta ação agora*/
    jQuery('.form-post').submit(function(){
        /* Neste contesto 'this' representa o form deste ID  #myform */                
        var dados = $(this).serialize();
        var sendpost = $(this).attr('send-post');
        var callStr  = $(this).attr('call');

         var settings = {
          "crossDomain": true,
          "url": "http://localhost:59271/Api/"+sendpost,
          "method": "POST",
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
