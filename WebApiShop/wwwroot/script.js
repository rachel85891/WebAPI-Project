

const loginButton = document.querySelector(".loginbutton")
const signUpButton = document.querySelector(".signupbutton")

// ----Login----
async function login(user) {
    const response = await fetch('api/Login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(user)
    });
    const data = await response;
    console.log('POST Data:', data);
    if (response.status == 200) {
        const dataObj = await response.json();
        sessionStorage.setItem("user", dataObj.firstName)
        sessionStorage.setItem("userID", dataObj.id)
        window.location.href = "UserDetails.html"
    }
    else {
        alert(`Error occured. status ${response.status}`)
    }
}
loginButton.addEventListener("click", (event) => {
    const name = document.querySelector("#username1").value
    const pass = document.querySelector("#password1").value
    const user = {
        UserName: name,
        Password: pass,
    }
    login(user)

})

// ----Signup----
async function signUp(user) {
    const response = await fetch('api/Users', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(user)
    });
    const data = await response;
    console.log('POST Data:', data);
    if (response.status == 201) {
        alert(`User added successfully! ☑️\nplease log in to get inside`)
    }
    else if (response.status == 400) {
        alert("Password id too weak!")
    }
    else {
        alert(`Error occured. status ${response.status}`)
    }

}
signUpButton.addEventListener("click", (event) => {
    const name = document.querySelector("#username2").value
    const pass = document.querySelector("#password2").value
    const fname = document.querySelector("#firstname").value
    const lname = document.querySelector("#lastname").value
    const user = {
        UserName: name,
        Password: pass,
        FirstName: fname,
        LastName: lname
    }
    signUp(user)
})

//----check password strength----------

const checkButton = document.querySelector("#checkPassStrength")
checkButton.addEventListener('click', async (event) => {
    const password = document.querySelector("#password2").value
    const progressBar = document.querySelector(".progressBar")
    strength = await checkPassword(password)
    console.log(strength)
    progressBar.innerHTML=`<progress value="${strength}"></progress>`
})

async function checkPassword(password) {
    const response = await fetch('api/Password', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(password)
    });
    const data = await response.json();
    console.log('POST Data:', data);
    if (response.status == 200) {
        return data.strength/4;
    }
    else {
        return 0;
    }

}

// ----Show----
const form = document.querySelector(".signup")
const openForm = document.querySelector("#openform")
openForm.addEventListener("click", (event) => {
    form.style.display = "flex"
})

