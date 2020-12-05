var curentCostomerEmail = $('#current-email').text();


//Sending current user email AJAX call and getting back id
var currentCustomer = new XMLHttpRequest();
currentCustomer.onreadystatechange = function() {
if (currentCustomer.readyState === 4){
   customerResponse = JSON.parse(currentCustomer.responseText)
   var customerID = parseInt(customerResponse[0].id, 10);
   $("#current_author").val(customerID);
   $("#customer-id-p").text(customerID);
}
};
currentCustomer.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/customers/find/${curentCostomerEmail}`);
currentCustomer.send();


//Sending Customer ID to API to get buildings/customer/id
setTimeout(function () {
    var customerID2 = $("#current_author").val();
    var getBld = new XMLHttpRequest();
    getBld.onreadystatechange = function() {
    if (getBld.readyState === 4){   
    customerBuild = JSON.parse(getBld.responseText)
    var buildingID = customerBuild[0].id;
    
    //Displaying each element of building array as a dropdown option
    var listbuildings = "";
    for(var i in customerBuild){
        listbuildings += "<option value='" + customerBuild[i].id+ "'>" + customerBuild[i].id + "</option>";
        $("#select_build").append(listbuildings);
    }
    
    }
    };
    getBld.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/buildings/customer/${customerID2}`);
    getBld.send();

}, 3000);

//Listening to change on building selection
$("#select_build").on('click change', function(){
    buildID = $(this).val();

    //AJAX call for batteries
    var getBat = new XMLHttpRequest();
    getBat.onreadystatechange = function() {
    if (getBat.readyState === 4){   

      batteriesFromBuilding = JSON.parse(getBat.responseText);
      var listBatteries = "";
      for(var i in batteriesFromBuilding){
          listBatteries += "<option value=" + batteriesFromBuilding[i].id+ "'>" + batteriesFromBuilding[i].id + "</option>";
          $("#select_bat").append(listBatteries);
      }
    
    }
    }
    //Send AJAX request only if value is not null
    if(buildID !== 'null'){
        getBat.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/batteries/building/${buildID}`);
        getBat.send();
    }
});

//Listening to change on battery selection
$("#select_bat").on('click change', function(){
   batteryID = $(this).val();

   //AJAX call for columns
   var getCol = new XMLHttpRequest();
   getCol.onreadystatechange = function() {
   if (getCol.readyState === 4){ 

    columnsFromBatteries = JSON.parse(getCol.responseText);
      var listcolumns = "";
      for(var i in columnsFromBatteries){
          listcolumns += "<option value=" + columnsFromBatteries[i].id+ "'>" + columnsFromBatteries[i].id + "</option>";
          $("#select_col").append(listcolumns);
      }
    }
    }

   //Send AJAX request only if value is not null
    if(batteryID !== 'null'){
        getCol.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/columns/battery/${batteryID}`);
        getCol.send();
    }

});

//Listening to change on column selection
$("#select_col").on('change click', function(){
    columnID = $(this).val();

   //AJAX call for elevators
   var getElev = new XMLHttpRequest();
   getElev.onreadystatechange = function() {
   if (getElev.readyState === 4){ 

    elevFromColumns = JSON.parse(getElev.responseText);
      var listElev = "";
      for(var i in elevFromColumns){
          listElev += "<option value=" + elevFromColumns[i].id+ "'>" + elevFromColumns[i].id + "</option>";
          $("#select_elev").append(listElev);
      }
    }
    }

    //Send AJAX request only if value is not null
    if(columnID !== 'null'){
        getElev.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/columns/battery/${columnID}`);
        getElev.send();
    }

});