import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/retry';
import 'rxjs/add/operator/catch';

import { Book } from "../../models/book";

@Component({
  selector: 'br-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {
  books: Book[] = []; 

  constructor(private http: Http) { }

  private errorHandler(error: Error | any): Observable<any> {
    console.log('************', error);
    return Observable.throw(error);
  }

  ngOnInit() {
    this.http.get('http://localhost:5000/api/Book')
      .retry(3)
      .map(res => res.json()) // Observable.map()
      .map(raw => raw.map( // Array.map()
        obj => new Book(obj.isbn, obj.title, obj.description, obj.rating))
      )
      .catch(this.errorHandler)
      .subscribe(books => {
        this.books = books;
        this.reorderBooks(null);
      })
  }

  reorderBooks(book: Book) {
    this.books.sort((a, b) => b.rating - a.rating);
  }
}
