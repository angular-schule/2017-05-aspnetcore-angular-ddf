import { Component, OnInit } from '@angular/core';
import { Book } from "../../models/book";

@Component({
  selector: 'br-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  books: Book[]; 

  constructor() { }

  ngOnInit() {
    this.books = [      
      new Book('000', 'Angular', 'Zurück in die Zukunft', 5),
      new Book('111', 'AngularJS 1.x', 'Oldie but Goldie', 3)
    ];
  }
}
