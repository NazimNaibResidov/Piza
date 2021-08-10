import { Component, OnInit } from '@angular/core';
import { Piza } from 'src/app/models/Piza';
import { MainService } from 'src/app/services/main.service';
import { PizaService } from 'src/app/services/piza.service';

@Component({
  selector: 'app-base',
  templateUrl: './base.component.html',
  styleUrls: ['./base.component.css']
})
export class BaseComponent implements OnInit {

  items:Piza[];
  constructor(private _services:PizaService) { }

  ngOnInit() {
    this._services.GetItems()
    .subscribe((resp:Piza[])=>{
      this.items=resp;
    })
  }

}
