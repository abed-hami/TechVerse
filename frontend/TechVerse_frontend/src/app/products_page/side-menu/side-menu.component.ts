import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { AccordionModule } from 'primeng/accordion';
@Component({
  selector: 'app-side-menu',
  standalone: true,
  imports: [AccordionModule,CommonModule],
  templateUrl: './side-menu.component.html',
  styleUrl: './side-menu.component.css'
})
export class SideMenuComponent {

  categories:string[]=[]

  ngOnInit(){
    this.categories=["All","Phone","Laptops","Accessories","Drones","Audio", "Games", "TVs", "Cameras"]
  }

}
