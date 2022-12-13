window.onscroll = function showHeader() {
    const header = document.querySelector('.header');
    const headerHeight = header.offsetHeight;
    let scrollDistance = window.scrollY;
 
    if (scrollDistance >= headerHeight) {
       header.classList.add('header__fixed');
    } else {
       header.classList.remove('header__fixed');
    }
 }