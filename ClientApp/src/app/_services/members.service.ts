import { HttpClient, HttpHandler, HttpHeaders } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Member } from '../models/member';
import { AccountService } from './account.service';

@Injectable({
  providedIn: 'root'
})
export class MembersService {
//inject http client
private  http =inject(HttpClient)
private accountService = inject(AccountService)
baseUrl = environment.apiUrl
 

getMembers(){
  return this.http.get<Member[]>(this.baseUrl + 'users',this.getHttpOptions());
}

getMember(username:string)
{
  return this.http.get<Member>(this.baseUrl + 'users/' + username, this.getHttpOptions())
}

//generate the HTTP headers needed to make authenticated API requests, specifically adding an Authorization header using a Bearer token.
getHttpOptions() {
  return {
    headers: new HttpHeaders({
      Authorization: `Bearer ${this.accountService.currentUser()?.token}`
    })
  };
}
 
}

