import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-products-display',
  standalone: true,
  imports: [CommonModule,RouterModule],
  templateUrl: './products-display.component.html',
  styleUrl: './products-display.component.css'
})
export class ProductsDisplayComponent {
  products = [
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 11 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 12 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 13 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 14 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 11 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 12 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 13 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 14 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 11 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 12 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 13 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 14 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},
    {img:'https://www.apple.com/v/iphone/home/bv/images/overview/select/iphone_15_pro__bpnjhcrxofqu_large.png',name:'iPhone 15 Pro',description:'The ultimate powerhouse',price:'999$'},

  ];
}
