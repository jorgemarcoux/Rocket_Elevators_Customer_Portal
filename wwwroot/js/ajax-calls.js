var xhr = new XMLHttpRequest();
xhr.onreadystatechange = function() {
   if(this.readyState == 4 && this.status == 200){
     var parsedResponse = JSON.parse(xhr.responseText);
     var result = '';
     for(var i in parsedResponse){
        result += '<ul>'+
        '<li>ID: '+parsedResponse[i].id+'</li>'+
        '<li>Namme: '+parsedResponse[i].name+'</li>'+
        '<li>Email: '+parsedResponse[i].email+'</li>'+
        '</ul>';
     }
     document.getElementById('test').innerHTML = result;
  }
};
xhr.open('GET', 'https://jsonplaceholder.typicode.com/users?email=Shanna@melissa.tv');
xhr.send();


//Batteires product page AJAX call
var bat = new XMLHttpRequest();
bat.onreadystatechange = function() {
   if(this.readyState == 4 && this.status == 200){
     var batteries = JSON.parse(bat.responseText);
     var allBatteries = '';
     for(var i in batteries){
        allBatteries += '<ul>'+
        '<li>ID: '+batteries[i].id+'</li>'+
        '<li>Building ID: '+batteries[i].buildingId+'</li>'+
        '<li>Battery Type: '+batteries[i].batteryType+'</li>'+
        '<li>Status: '+batteries[i].batteryStatus+'</li>'+
        '<li>Certificate of Operations: '+batteries[i].certificateOfOperations+'</li>'+
        '<li>Date of Commissioning: '+batteries[i].dateOfCommissioning+'</li>'+
        '<li>BDate of Last Inspection: '+batteries[i].dateOfLastInspection+'</li>'+
        '<li>Information: '+batteries[i].information+'</li>'+
        '<li>Update dAt: '+batteries[i].updatedAt+'</li>'+
        '</ul>';
     }
     document.getElementById('allBatteries').innerHTML = allBatteries;
  }
};
//bat.open('GET', 'https://consolidation-jorge-rest.azurewebsites.net/api/batteries');
bat.send();








//WorldTime API call for Portal page
var xhr2 = new XMLHttpRequest();
xhr2.onreadystatechange = function() {
if (xhr2.readyState === 4){
   date = JSON.parse(xhr2.response)
document.getElementById('date1').innerHTML = ' '+ date.datetime;
document.getElementById('date2').innerHTML = ' '+date.timezone;
document.getElementById('date3').innerHTML =' '+date.client_ip;
}
};
xhr2.open('GET', "https://worldtimeapi.org/api/ip");
xhr2.send();

