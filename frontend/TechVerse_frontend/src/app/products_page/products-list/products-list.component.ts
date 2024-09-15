import { Component } from '@angular/core';
import { NavbarComponent } from "../../common/navbar/navbar.component";
import { MenuItem } from 'primeng/api';
import { BreadcrumbModule } from 'primeng/breadcrumb';
import { CommonModule } from '@angular/common';
import { FooterComponent } from "../../common/footer/footer.component";
import { SideMenuComponent } from "../side-menu/side-menu.component";
import { ProductsDisplayComponent } from "../products-display/products-display.component";
import { RouterModule } from '@angular/router';
@Component({
  selector: 'app-products-list',
  standalone: true,
  imports: [NavbarComponent, BreadcrumbModule, CommonModule, FooterComponent, SideMenuComponent, ProductsDisplayComponent,RouterModule],
  templateUrl: './products-list.component.html',
  styleUrl: './products-list.component.css'
})
export class ProductsListComponent {

  

  items: any[] | undefined;

  home: MenuItem | undefined;

  ngOnInit() {
      this.items = [
          { label: 'Products',color:'' },
          { label: 'All', color:'' },

        ];
        this.items[this.items.length-1].color='text-indigo-600'

      this.home = { icon: 'pi pi-home', routerLink: '/' };



    }



}
