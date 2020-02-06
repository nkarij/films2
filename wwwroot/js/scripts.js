

(function ListFilms(){

    let filmList = document.querySelector(".list-of-films");

    fetch('http://localhost:5000/api/films')
    .then((response) => {
        return response.json();
    })
    .then((json) => {
        //console.log(json);
        let data = json;
        data.forEach(item => {
            let listElement = document.createElement("li");
            let buttonElement = document.createElement("button");
            let button = document.createElement("button");
            listElement.innerText = item.name;
            buttonElement.dataset.filmid = item.id;
            buttonElement.classList.add("choose-film-button");
            buttonElement.innerText = "Choose";
            button.classList.add("change-film-number");
            button.innerText = "Change Nr";
            filmList.appendChild(listElement);
            filmList.appendChild(buttonElement);
            filmList.appendChild(button);
        })

        chooseFilm();
        changeNumber();
    });
})()

function changeNumber() {
    
    let changeButton = document.querySelector(".change-film-number");
    changeButton.addEventListener('click', (e) => {
        e.preventDefault();
        let target = e.currentTarget;
        let filmname = target.parentNode.innerText;
        let filmid = target.parentNode.querySelector(".choose-film-button").dataset.filmid;
        console.log(filmname);
        console.log(filmid);

        let changeSection = document.querySelector(".change-number-film").style.display = "block";
        // insert filmname, display block, then get the new number, post with id. 
 
        let changeButton = document.querySelector(".change-number-film-button");
        let changeNumberForm = document.querySelector("#change-number-form");
        changeButton.addEventListener('click', (e) => {
            e.preventDefault();
            let number = changeNumberForm.numberoffilms

            fetch('http://localhost:5000/api/films?number=' + "9", {
                method: 'POST',
                mode: 'cors',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(),
            }).then((response) => {
                console.log(response.status);
                return response.json();
            }).then((response) => {
                console.log("response", response);
            }).catch(error => console.log(error))
        })



    })

}


let createButton = document.querySelector(".new-film-button");
//console.log(createButton);
createButton.addEventListener('click', (e) => {
    e.preventDefault();
    console.log("davs");

    let createFilmForm = document.querySelector("#new-film-form");
    let IdInput = createFilmForm.filmid.value
    let NameInput = createFilmForm.filmname.value;
    let NumberInput = createFilmForm.numberoffilms.value

    // I WOULD LIKE TO POST THIS IN FETCH BODY, BUT THE CONTROLLER WILL ONLY ACCEPT THE STRING/NAMES,
    // NOT ANY INTEGERS, EVEN IF I MAKE USE OF [FROMBODY] WHICH SHOULD BE ABLE TO HANDLE COMPLEX REQUESTS.
    /*let body = {
        Id: "23" ,
        Name: "Nanna",
        NumbersOfFilms: "8",
    }*/

    // //CreateNewFilm
    // AT THE MOMENT I WORK AROUND THIS WITH A NAME INPUT OR A QUERY STRING.
    // BUT ITS NOT WHAT I WOULD LIKE TO DO...
    fetch('http://localhost:5000/api/films', {
        method: 'POST',
        mode: 'cors',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            "Id": "23",
            "Name": "Nanna",
            "NumbersOfFilms": "8"
        }),
    }).then((response) => {
        console.log(response);
        return response.json();
    })
    .then((response) => {
        console.log("response", response);
    }).catch(error => console.log(error))

})

function chooseFilm() {

    let borrowButton = document.querySelector(".choose-film-button");
    borrowButton.addEventListener('click', (e) => {
        let target = e.currentTarget;
        let id = target.dataset.filmid;
        let body = {
            id: id
        }

        console.log("body", body)
        fetch("http://localhost:5000/api/films/" + id, {
            method: 'POST',
            mode: 'cors',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(body),
        }).then((response) => {
            console.log(response.status);
            return response.json();
        }).then((response) => {
               console.log("response", response);
          }).catch(error => console.log(error))

    })

}
