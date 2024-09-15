import { ViewportScroller } from '@angular/common';
import { Component, ElementRef, ViewChild } from '@angular/core';
import { NavigationEnd, Router, RouterModule } from '@angular/router';
import { filter } from 'rxjs';
import { BadgeModule } from 'primeng/badge';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterModule,BadgeModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

  constructor(private router: Router, private viewportScroller: ViewportScroller) {}

  ngOnInit() {
    this.router.events.pipe(
      filter(event => event instanceof NavigationEnd)
    ).subscribe(() => {
      const fragment = this.router.url.split('#')[1];
      if (fragment) {
        this.viewportScroller.scrollToAnchor(fragment);
      }
    });
  }

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
