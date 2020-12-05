//Make Company information editable after click on Edit information botton
//and getting rid off 'readOnly' property
document.getElementById("edit-info-btn").addEventListener("click", makeEditable);

function makeEditable() {
    document.getElementById("company_contact_phone").contentEditable = "true";
    document.getElementById("company_contact_phone").readOnly = false;
    document.getElementById("company_contact_name").readOnly = false;
    document.getElementById("company_contact_name").contentEditable = "true";
    document.getElementById("company_desc").contentEditable = "true";
    document.getElementById("company_desc").readOnly = false;
    document.getElementById("company_tech_phone").contentEditable = "true";
    document.getElementById("company_tech_phone").readOnly = false;
    document.getElementById("tech_manager_mail").contentEditable = "true";
    document.getElementById("tech_manager_mail").readOnly = false;
  }


//Send info from AJAX call to company info table
var custmr = new XMLHttpRequest();
custmr.onreadystatechange = function() {
if (custmr.readyState === 4){
   customerInfo = JSON.parse(custmr.response)
document.getElementById('company_contact_name').setAttribute('value', customerInfo.companyContactFullName);
document.getElementById('company_contact_phone').setAttribute('value',customerInfo.companyContactPhone);
document.getElementById('company_desc').setAttribute('value', customerInfo.companyDescription);
document.getElementById('company_tech_phone').setAttribute('value', customerInfo.technicalAuthorityPhoneNumber);
document.getElementById('tech_manager_mail').setAttribute('value', customerInfo.technicalManagerEmailService);
}
};
custmr.open('GET', "https://consolidation-jorge-rest.azurewebsites.net/api/customers/2");
custmr.send();

//Send info from AJAX call to addresses table
var adrs = new XMLHttpRequest();
adrs.onreadystatechange = function() {
if(this.readyState == 4 && this.status == 200){
   var customerAdresses = JSON.parse(adrs.responseText);
   var numberAddresses = customerAdresses.length;
   var allAddresses = '';
   for(var i in customerAdresses){  
      allAddresses += '<tr>';
      allAddresses += '<td>'+customerAdresses[i].id+'</td>';
      allAddresses += '<td>'+customerAdresses[i].typeOfAddress+'</td>';
      allAddresses += '<td>'+customerAdresses[i].numberAndStreet+'</td>';
      allAddresses += '<td>'+customerAdresses[i].suiteOrApartment+'</td>';
      allAddresses += '<td>'+customerAdresses[i].city+'</td>';
      allAddresses += '<td>'+customerAdresses[i].state+'</td>';
      allAddresses += '<td>'+customerAdresses[i].postalCode+'</td>';
      allAddresses += '<td>'+customerAdresses[i].country+'</td></tr>';
   }
   document.getElementById('addressesData').innerHTML = allAddresses;
   
}
};
adrs.open('GET', "https://consolidation-jorge-rest.azurewebsites.net/api/addresses");
adrs.send();




//Listen to user input changes to send to DB with Ajax PUT request
function getNameValue(){
  
    console.log(this.value);
    //console.log(newCompanyName);
  
}



console.log('test');


//document.getElementById('company_contact_name').addEventListener("input", function() {


//function getInfoValues(val) {
 