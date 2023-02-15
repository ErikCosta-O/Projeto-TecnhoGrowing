let time = 4000, //o tempo que eu quero de rotação
    currentImageIndex = 0, // a primeira imagem é zero
    images = document.querySelectorAll("#slider img"); // pegas as imagens
    max = images.length; // máximo de imagens que existe pra mim 
function nextImage() { //ele vai puxar a próxima imagem
    images[currentImageIndex].classList.remove("selected");
    //remover a classe do elemento atual , para as outras imagens
    //irem adicionando 
    currentImageIndex++; //incrementamos uma imagem para ela ir trocando
    if(currentImageIndex >= max)
    // se o meu create imageindex for maior ou igual ao meu máximo de imagem
    //eu reseto ele, e ele volta para a sua posição 0
    //(e então nosso banner fica rotativo)
        currentImageIndex = 0;
    images[currentImageIndex].classList.add("selected");
}
function start() { 
    //setInterval vai executar uma função a cada momento
    setInterval(() => {
        // troca de imagem
        nextImage(); //usando a função de troca de imagem que eu criei
    }, time)
}
window.addEventListener("load", start);