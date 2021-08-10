import { Component, OnInit } from '@angular/core';
import { Piza } from 'src/app/models/Piza';
import { PizaService } from 'src/app/services/piza.service';

@Component({
  selector: 'app-struct',
  templateUrl: './struct.component.html',
  styleUrls: ['./struct.component.css']
})
export class StructComponent implements OnInit {

  items:Piza[];
  constructor(private _services:PizaService) { }

  ngOnInit() {
    this._services.GetItems()
    .subscribe((resp:Piza[])=>{
      console.log(resp);
      this.items=resp;
    })
  }

}
