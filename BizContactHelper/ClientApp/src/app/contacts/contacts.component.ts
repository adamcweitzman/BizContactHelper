import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent {
  public contacts: Contacts[];
  public name: string;
  public email: string;
  public city: string;
  public state: string;
  private _http: HttpClient
  private _baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl
    this._http = http;

    this.get(http, baseUrl);
  }

  onSubmit(form: NgForm) {
    var contact: Contacts = {
      name: form.value.name,
      email: form.value.email,
      city: form.value.city,
      state: form.value.state,
      id: null,
      phoneNumber: null,
      street: null,
      zipcode: null,
      followUpDate: new Date()
    }

    

    this.post(contact);
    form.reset();
  }

  onDelete(id: number) {
    this.delete(id);
  }

  post(contact: Contacts) {
    this._http.post<Contacts[]>(this._baseUrl + 'api/contacts', contact).subscribe(result => {
      this.get(this._http, this._baseUrl);
    }, error => console.error(error));
  }

  get(http: HttpClient, baseUrl: string) {
    http.get<Contacts[]>(baseUrl + 'api/contacts').subscribe(result => {
      this.contacts = result.reverse();
    }, error => console.error(error));
  }

  delete(id: number) {
    this._http.delete<Contacts[]>(this._baseUrl + `api/contacts/${id}`).subscribe(result => {
      this.get(this._http, this._baseUrl);
    }, error => console.error(error));
  }
}

interface Contacts {
  name: string;
  email: number;
  id: number;
  phoneNumber: string;
  city: string;
  state: string;
  street: string;
  zipcode: string;
  followUpDate: Date;
}
