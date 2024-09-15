import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from "../../common/navbar/navbar.component";

@Component({
  selector: 'app-product-details',
  standalone: true,
  imports: [RouterModule, NavbarComponent],
  templateUrl: './product-details.component.html',
  styleUrl: './product-details.component.css'
})
export class ProductDetailsComponent {

}
