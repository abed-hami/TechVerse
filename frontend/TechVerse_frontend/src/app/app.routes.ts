import { RouterModule, Routes } from '@angular/router';
import { LandingPageComponent } from './common/landing-page/landing-page.component';
import { ProductsListComponent } from './products_page/products-list/products-list.component';
import { NgModule } from '@angular/core';
import { FooterComponent } from './common/footer/footer.component';
import { CategoriesComponent } from './common/categories/categories.component';
import { ProductDetailsComponent } from './products_page/product-details/product-details.component';

export const routes: Routes = [
  {path:'', component:LandingPageComponent},
  {path:'home', component:LandingPageComponent},
  {path:'products',children:[
    {path:'',component:ProductsListComponent},
    {path:'details', component:ProductDetailsComponent},
  ]},



];


