const updateBut = document.querySelector(".updateBut")

async function putResponse(user) {
    const id = sessionStorage.getItem("userID")
    const responsePost = await fetch(`api/Users/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',

        },
        body: JSON.stringify(user)
    });
    const dataPost = await responsePost;
    console.log('PUT Data:', dataPost);
}

updateBut.addEventListener("click", (event) => {
    const userName = document.querySelector("#userName").value
    const password = document.querySelector("#password").value
    const fName = document.querySelector("#fName").value
    const lName = document.querySelector("#lName").value

    const user = { UserName: userName, Password: password, FName: fName, LName: lName }
    putResponse(user)
})

const hello = document.querySelector("#hello")
hello.textContent = "Hello " + sessionStorage.getItem("user") +"!!"

const form = document.querySelector(".Update")
const openForm = document.querySelector("#update")
openForm.addEventListener("click", (event) => {
    form.style.display = "flex"
})
