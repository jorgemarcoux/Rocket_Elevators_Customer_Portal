//Make Company information editable after click on Edit information botton

document.getElementById("edit-info-btn").addEventListener("click", makeEditable);

function makeEditable() {
    document.getElementById("company_contact_phone").contentEditable = "true";
    document.getElementById("company_contact_name").contentEditable = "true";
    document.getElementById("company_desc").contentEditable = "true";
    document.getElementById("company_tech_phone").contentEditable = "true";
    document.getElementById("tech_manager_mail").contentEditable = "true";
  }


//Ajax call for current customer information
var custmr = new XMLHttpRequest();
custmr.onreadystatechange = function() {
if (custmr.readyState === 4){
   customerInfo = JSON.parse(custmr.response)
document.getElementById('company_contact_name').innerHTML = ' '+ customerInfo.companyContactFullName;
document.getElementById('company_contact_phone').innerHTML = ' '+customerInfo.companyContactPhone;
document.getElementById('company_desc').innerHTML =' '+customerInfo.companyDescription;
document.getElementById('company_tech_phone').innerHTML = customerInfo.technicalAuthorityPhoneNumber;
document.getElementById('tech_manager_mail').innerHTML = customerInfo.technicalManagerEmailService;
}
};
custmr.open('GET', "https://consolidation-jorge-rest.azurewebsites.net/api/customers/1");
custmr.send();