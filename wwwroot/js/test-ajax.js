
   var xhr = new XMLHttpRequest();
   xhr.onreadystatechange = function() {
        var parsedResponse = JSON.parse(xhr.responseText);
        document.getElementById('test').innerHTML = parsedResponse[0].id;
       
   };
   xhr.open('GET', 'https://consolidation-jorge-rest.azurewebsites.net/api/interventions/');
   xhr.send();


