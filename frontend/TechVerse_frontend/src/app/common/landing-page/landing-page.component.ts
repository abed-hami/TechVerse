import { Component } from '@angular/core';
import { NavbarComponent } from "../navbar/navbar.component";
import { HomeComponent } from "../home/home.component";
import { CategoriesComponent } from "../categories/categories.component";
import { CommercialComponent } from "../commercial/commercial.component";
import { ProductsComponent } from "../products/products.component";
import { FooterComponent } from "../footer/footer.component";

@Component({
  selector: 'app-landing-page',
  standalone: true,
  imports: [NavbarComponent, HomeComponent, CategoriesComponent, CommercialComponent, ProductsComponent, FooterComponent],
  templateUrl: './landing-page.component.html',
  styleUrl: './landing-page.component.css'
})
export class LandingPageComponent {

}
