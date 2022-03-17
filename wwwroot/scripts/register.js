const firstSection = document.querySelector("#first-section");
const secondSection = document.querySelector("#second-section");
const thirdSection = document.querySelector("#third-section");

const firstNextBtn = document.querySelector("#first-next");
const firstPrevious = document.querySelector("#first-previous");
const secondNext = document.querySelector("#second-next");
const lastPrevious = document.querySelector("#last-previous");

firstNextBtn.addEventListener('click', () => {
    secondSection.classList.remove('hidden');
    firstSection.classList.add('hidden');
})

firstPrevious.addEventListener('click', () => {
    firstSection.classList.remove('hidden');
    secondSection.classList.add('hidden');
})

secondNext.addEventListener('click', () => {
    thirdSection.classList.remove('hidden');
    secondSection.classList.add('hidden');
})

lastPrevious.addEventListener('click', () => {
    secondSection.classList.remove('hidden');
    thirdSection.classList.add('hidden');
})


