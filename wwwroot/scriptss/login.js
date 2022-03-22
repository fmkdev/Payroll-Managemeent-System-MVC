const loginForm = document.querySelector('#login-form');
const registerForm = document.querySelector('#register-form');

const loginBtn = document.querySelector('#login-btn');
const registerBtn = document.querySelector('#register-btn');

registerBtn.addEventListener('click', () => {
    registerForm.classList.remove('hidden');
    loginForm.classList.add('hidden');
})

loginBtn.addEventListener('click', () => {
    loginForm.classList.remove('hidden');
    registerForm.classList.add('hidden');
})