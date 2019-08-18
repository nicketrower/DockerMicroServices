import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FriendsService {

  constructor(private http: HttpClient) { }

  addfriend() {
    let user = 'Testing';
    return this.http.post('http://friends.api/account', user);
  }

  getfriends() {
    return this.http.get('http://friends.api/account');
  }
}
