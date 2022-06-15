function forgotSenha(event){
    event.preventDefault()
    fetch("./EsqueciSenha.html").then(teste => {
        return teste.text()
    }).then(teste2 => {
        document.querySelector(".homeLogin").innerHTML=teste2
    })
}

const teste = document.querySelector(".homeLogin-links-forgot")
teste.addEventListener("click", forgotSenha)