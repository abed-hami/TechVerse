import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

  viewNavigation(){
    let links=document.getElementsByClassName("navlinks");
    let navicons=document.getElementsByClassName("navicons");
    let icon = document.getElementsByClassName("bi-list");
    let ficon = document.getElementsByClassName("bi-x");
    let view = document.getElementsByClassName("view")

    if(!view[0]){
      links[0].classList.add("view")
      navicons[0].classList.add("view")
      icon[0].classList.add("bi-x")
      icon[0].classList.remove("bi-list")
    }
    else if(view[0]){
      links[0].classList.remove("view")
      navicons[0].classList.remove("view")
      ficon[0].classList.add("bi-list")
      ficon[0].classList.remove("bi-x")
    }

  }

}
