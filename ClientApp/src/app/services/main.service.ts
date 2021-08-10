import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AnonymousSubject } from 'rxjs/internal/Subject';

@Injectable({
  providedIn: 'root'
})
export class MainService {

  constructor(private url:string,private http:HttpClient) { }

  GetItems(){
  return  this.http.get(this.url);
  }
  InsertItem(item:any)
  {
   return this.http.post(this.url,item);
  }
  UpdateItem(item:any)
  {
    return this.http.put(this.url,item);
  }
  Remove(id:number)
  {
    return this.http.delete(this.url+'/'+id);
  }
}
