const firstName = document.querySelector("#first-name");
const lastName = document.querySelector("#last-name");
const email = document.querySelector("#email");
const phoneNumber = document.querySelector("#phone-number");
const gender = document.querySelector("#gender");
const maritalStatus = document.querySelector("#marital-status");
const department = document.querySelector("#department");
const position = document.querySelector("#position");
const paymentType = document.querySelector("#payment-type");
const resumptionDate = document.querySelector("#resumption-date");
const payLevel = document.querySelector("#pay-level");
const appointmentType = document.querySelector("#appointment-type");
const roleType = document.querySelector("#role-type");
const houseNumber = document.querySelector("#house-no");
const streetName = document.querySelector("#street-name");
const city = document.querySelector("#city");
const state = document.querySelector("#state");
const nationality = document.querySelector("#nationality");
const homeNumber = document.querySelector("#home-number");
const localGovernment = document.querySelector("#local-government");
const accountNumber = document.querySelector("#acc-number");
const bankName = document.querySelector("#bank-name");
const password = document.querySelector("#password");
const confirmPassword = document.querySelector("#confirm-password");

const registerBtn = document.querySelector("#register-btn");


let spanErrorMessage = document.querySelector("#span-error-message");

let userDetails = {};

const registerEmployeeRequest = () => {

    fetch('https://localhost:5001/api/Employee/CreateEmployee', {
        method: 'POST',
        body: JSON.stringify(userDetails),
        headers: {
            'Content-Type': 'application/json',
        }
    })
    .then(response => response.json())
    .then(data => {
        console.log(data)
        if(data.isSuccess) {
            setUserFirstName(data.data.firstName)
        }
        else{
            spanErrorMessage.innerText = data.Message;
            spanErrorMessage.classList.remove('hidden');
        }
    })
    .catch(error => console.error(error));
}

const setUserFirstName = firstName => {
    localStorage.setItem('firstName', firstName);
}

const validateInputs = (firstName, lastName, email, phoneNumber, gender, maritalStatus, position, department, 
    paymentType, resumptionDate, payLevel, appointmentType, roleType, houseNumber, streetName, city, state, 
    nationality, localGovernment,homeNumber, accountNumber, bankName, password, confirmPassword) => {

    return firstName.value.trim() == "" || lastName.value.trim() == "" || email.value.trim() == "" || phoneNumber.value.trim() == "" || 
    gender.value.trim() == "" || maritalStatus.value.trim() == "" || position.value.trim() == "" || department.value.trim() == "" || 
    paymentType.value.trim() == "" || resumptionDate.value.trim() == "" || payLevel.value.trim() == "" || appointmentType.value.trim() == "" || 
    roleType.value.trim() == "" || houseNumber.value.trim() == "" || streetName.value.trim() == "" || city.value.trim() == "" || 
    state.value.trim() == "" || nationality.value.trim() == "" || localGovernment.value.trim() == "" || homeNumber.value.trim() == "" || 
    accountNumber.value.trim() == "" || bankName.value.trim() == "" || password.value.trim() == "" || confirmPassword.value.trim() == ""
}

registerBtnStartBtn.addEventListener('click', () => {
    if (validateInputs(firstName, lastName, email, phoneNumber, gender, maritalStatus, position, department, 
        paymentType, resumptionDate, payLevel, appointmentType, roleType, houseNumber, streetName, city, state, 
        nationality, localGovernment,homeNumber, accountNumber, bankName, password, confirmPassword)) {

        spanErrorMessage.innerText = "Please check all your entries";
        spanErrorMessage.classList.remove('hidden');
        return;
    }

    userDetails.firstName = firstName.value.trim();
    userDetails.lastName = lastName.value.trim();
    userDetails.email = email.value.trim();
    userDetails.phoneNumber = phoneNumber.value.trim();
    userDetails.gender = gender.value.trim();
    userDetails.maritalStatus = maritalStatus.value.trim();
    userDetails.position = position.value.trim();
    userDetails.department = department.value.trim();
    userDetails.paymentType = [paymentType.value];
    userDetails.resumptionDate = resumptionDate.value;
    userDetails.payLevel = [payLevel.value];
    userDetails.appointmentType = [appointmentType.value];
    userDetails.roleType = [roleType.value];
    userDetails.houseNumber = houseNumber.value.trim();
    userDetails.streetName = streetName.value.trim();
    userDetails.city = city.value.trim();
    userDetails.state = state.value.trim();
    userDetails.nationality = nationality.value.trim();
    userDetails.localGovernment = localGovernment.value.trim();
    userDetails.homeNumber = homeNumber.value.trim();
    userDetails.accountNumber = accountNumber.value.trim();
    userDetails.bankName = bankName.value.trim();
    userDetails.password = password.value;
    userDetails.confirmPassword = confirmPassword.value;

    registerUserRequest();
})
