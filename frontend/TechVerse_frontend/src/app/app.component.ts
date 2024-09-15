import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from "./common/navbar/navbar.component";
import { HomeComponent } from "./common/home/home.component";
import { CategoriesComponent } from "./common/categories/categories.component";
import { CommercialComponent } from "./common/commercial/commercial.component";
import { ProductsComponent } from "./common/products/products.component";
import { FooterComponent } from "./common/footer/footer.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, NavbarComponent, HomeComponent, CategoriesComponent, CommercialComponent, ProductsComponent, FooterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TechVerse_frontend';
}
