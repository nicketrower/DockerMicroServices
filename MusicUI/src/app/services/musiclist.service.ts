import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MusiclistService {

  constructor(private http: HttpClient) { }

  addfriend() {
    let user = 'test';
    return this.http.post('http://account.api/account', user);
  }

  getfriends() {
    return this.http.get('http://account.api/account');
  }
}
