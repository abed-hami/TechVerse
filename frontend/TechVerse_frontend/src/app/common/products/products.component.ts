import { CommonModule } from '@angular/common';
import { Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {



  products = [
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 11 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 12 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 13 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 14 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},

  ];



}
