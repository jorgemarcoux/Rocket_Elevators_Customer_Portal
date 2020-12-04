var curentCostomerEmail = $('#current-email').text();



//Sending current user email AJAX call and getting back id
var currentCustomer = new XMLHttpRequest();
currentCustomer.onreadystatechange = function() {
if (currentCustomer.readyState === 4){
   customerResponse = JSON.parse(currentCustomer.responseText)
   var customerID = customerResponse[0].id;
   $("#current_author").val(customerID);
}
};
currentCustomer.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/customers/find/${curentCostomerEmail}`);
currentCustomer.send();

//Sending Customer ID to API to get buildings/customer/id
var getBld = new XMLHttpRequest();
getBld.onreadystatechange = function() {
if (getBld.readyState === 4){
   var customerID2 = $("#current_author").val();
   customerBuild = JSON.parse(getBld.responseText)
   //var buildingID = customerBuild[0].id;
}
};
getBld.open('GET', `https://consolidation-jorge-rest.azurewebsites.net/api/buildings/customer/${customerID2}`);
getBld.send();

