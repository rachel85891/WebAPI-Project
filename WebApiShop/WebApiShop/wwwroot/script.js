

async function getResponse() {
    const response = await fetch(
        'api/Users'
    );
    if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
    }
    const data = await response.json();
    alert(data);
}
const postData = {
    userId: 1,
    id: 101,
    title: 'New Post',
    body: 'This is a new post created using fetch.'
}
async function postResponse() {
    const responsePost = await fetch('api/Users', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            
        },
        body: JSON.stringify(postData)
    });
    const dataPost = await responsePost;
    console.log('POST Data:', dataPost);
}

const loginBut = document.querySelector(".loginBut")
const SignUp = document.querySelector(".sign")


async function PostResponseLogin(user) {
    const responsePost = await fetch('api/Login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(user)
    });
    const dataPost = await responsePost.json();
    console.log('POST Data:', dataPost);
    if (responsePost.ok) {
        sessionStorage.setItem("user", dataPost.fName)
        sessionStorage.setItem("userID", dataPost.userID)
        window.location.href = "UserDetails.html"
    }
    else {
        alert(responsePost.status)
    }
}

loginBut.addEventListener("click", (event)=>{
    const userName = document.querySelector("#userName1").value
    const password = document.querySelector("#password1").value
    const user = { UserName: userName, Password: password }
    PostResponseLogin(user)
}) 

async function postResponseUser(user) {
    const responsePost = await fetch('api/Users', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',

        },
        body: JSON.stringify(user)
    });
    const dataPost = await responsePost;
    console.log('POST Data:', dataPost);
}

SignUp.addEventListener("click", (event) => {
    const userName = document.querySelector("#userName").value
    const password = document.querySelector("#password").value
    const fName = document.querySelector("#fName").value
    const lName = document.querySelector("#lName").value

    const user = { UserName: userName, Password: password, FName: fName, LName: lName}
    postResponseUser(user)
}) 
const form = document.querySelector(".signUp")
const openForm = document.querySelector("#openForm")
openForm.addEventListener("click", (event) => {
    form.style.display = "flex"
})













